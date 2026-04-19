using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Godot;
using Godot.Collections;
using HarmonyLib;
using MegaCrit.Sts2.Core.Nodes.Audio;

namespace BaseLib.Utils;

/// <summary>
/// Provides direct access to the FMOD audio engine for playing custom sounds.
/// Wraps the FmodServer GDExtension singleton so mods don't have to deal with
/// untyped Call() chains everywhere.
///
/// For existing game sounds, just pass the event path:
///   FmodAudio.PlayEvent("event:/sfx/heal");
///
/// For custom audio files (wav, ogg, mp3, etc.):
///   FmodAudio.PlayFile("path/to/sound.wav");
///
/// For full FMOD Studio banks built against the game's FMOD 2.03.x runtime:
///   FmodAudio.LoadBank("path/to/custom.bank");
///   FmodAudio.PlayEvent("event:/mods/mymod/my_sound");
///
/// Packs loaded through mods cannot be loaded through DirAccess/FileAccess, which the FMod GDExtension uses.
/// </summary>
[Obsolete("This class is not guaranteed to continue to exist in its current state, and is not recommended for use.")]
public static class FmodAudio
{
	private static class Methods
	{
		public static GodotMethodDelegate PlayOneShot = new GodotMethod(StringName.op_Implicit("play_one_shot"));

		public static GodotMethodDelegate CreateSound = new GodotMethod(StringName.op_Implicit("create_sound"));
	}

	private class SoundPool(string[] entries)
	{
		public readonly List<string> Entries = entries.ToList();

		private int _lastIndex = -1;

		public string PickNext(Random rng)
		{
			if (Entries.Count == 1)
			{
				return Entries[0];
			}
			int num;
			do
			{
				num = rng.Next(Entries.Count);
			}
			while (num == _lastIndex && Entries.Count > 1);
			_lastIndex = num;
			return Entries[num];
		}
	}

	private static GodotObject? _server;

	private static readonly Dictionary<string, Variant> _loadedFiles = new Dictionary<string, Variant>();

	private static readonly Dictionary<string, Variant> _loadedBanks = new Dictionary<string, Variant>();

	private static readonly Dictionary<string, Func<string, float, bool>> _replacements = new Dictionary<string, Func<string, float, bool>>();

	private static bool _replacementPatchApplied;

	private static readonly ConcurrentDictionary<string, long> _cooldowns = new ConcurrentDictionary<string, long>();

	private static readonly Dictionary<string, SoundPool> _soundPools = new Dictionary<string, SoundPool>();

	private static readonly Random _poolRng = new Random();

	private static GodotObject? Server
	{
		get
		{
			if (_server != null)
			{
				return _server;
			}
			try
			{
				_server = Engine.GetSingleton(StringName.op_Implicit("FmodServer"));
			}
			catch (Exception ex)
			{
				BaseLibMain.Logger.Error("Failed to get FmodServer singleton: " + ex.Message, 1);
			}
			return _server;
		}
	}

	/// <summary>
	/// Fire-and-forget play of an FMOD event. Works with any event path
	/// from loaded banks (the game's built-in banks or your own).
	/// </summary>
	public static bool PlayEvent(string eventPath)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (Server == null)
		{
			return false;
		}
		try
		{
			Methods.PlayOneShot(Server, Variant.op_Implicit(eventPath));
			return true;
		}
		catch (Exception ex)
		{
			BaseLibMain.Logger.Error("FmodAudio.PlayEvent failed for '" + eventPath + "': " + ex.Message, 1);
			return false;
		}
	}

	/// <summary>
	/// Play an FMOD event with parameters (e.g. "EnemyImpact_Intensity" for damage sounds).
	/// </summary>
	public static bool PlayEvent(string eventPath, Dictionary<string, float> parameters)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		if (Server == null)
		{
			return false;
		}
		try
		{
			Dictionary val = new Dictionary();
			foreach (KeyValuePair<string, float> parameter in parameters)
			{
				val[Variant.op_Implicit(parameter.Key)] = Variant.op_Implicit(parameter.Value);
			}
			Server.Call(StringName.op_Implicit("play_one_shot_with_params"), (Variant[])(object)new Variant[2]
			{
				Variant.op_Implicit(eventPath),
				Variant.op_Implicit(val)
			});
			return true;
		}
		catch (Exception ex)
		{
			BaseLibMain.Logger.Error("FmodAudio.PlayEvent failed for '" + eventPath + "': " + ex.Message, 1);
			return false;
		}
	}

	/// <summary>
	/// Play an FMOD event with cooldown. If the same event was played within
	/// cooldownMs, the call is silently skipped. Useful for sounds triggered
	/// by rapid game events (e.g. a power that fires on every card play).
	/// </summary>
	public static bool PlayEvent(string eventPath, int cooldownMs)
	{
		long timestamp = Stopwatch.GetTimestamp();
		long num = (long)((double)(cooldownMs * Stopwatch.Frequency) / 1000.0);
		if (_cooldowns.TryGetValue(eventPath, out var value) && timestamp - value < num)
		{
			return false;
		}
		_cooldowns[eventPath] = timestamp;
		return PlayEvent(eventPath);
	}

	/// <summary>
	/// Play an event by its GUID instead of path. Slightly faster lookup
	/// and immune to event renames in FMOD Studio.
	/// </summary>
	public static bool PlayEventByGuid(string guid)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (Server == null)
		{
			return false;
		}
		try
		{
			Server.Call(StringName.op_Implicit("play_one_shot_using_guid"), (Variant[])(object)new Variant[1] { Variant.op_Implicit(guid) });
			return true;
		}
		catch (Exception ex)
		{
			BaseLibMain.Logger.Error("FmodAudio.PlayEventByGuid failed for '" + guid + "': " + ex.Message, 1);
			return false;
		}
	}

	/// <summary>
	/// Create an event instance you can start/stop/adjust yourself.
	/// Don't forget to call Release() on the returned object when you're done.
	/// </summary>
	public static GodotObject? CreateEventInstance(string eventPath)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		if (Server == null)
		{
			return null;
		}
		try
		{
			Variant val = Server.Call(StringName.op_Implicit("create_event_instance"), (Variant[])(object)new Variant[1] { Variant.op_Implicit(eventPath) });
			object obj = ((Variant)(ref val)).Obj;
			return (GodotObject?)((obj is GodotObject) ? obj : null);
		}
		catch (Exception ex)
		{
			BaseLibMain.Logger.Error("FmodAudio.CreateEventInstance failed for '" + eventPath + "': " + ex.Message, 1);
			return null;
		}
	}

	/// <summary>
	/// Play a sound file (wav, ogg, mp3) through FMOD. The file gets loaded
	/// into FMOD's memory on first use and stays cached for subsequent calls.
	///
	/// Returns the FmodSound handle so you can control it (stop, volume, pitch).
	/// The handle has: play(), stop(), set_volume(float), set_pitch(float),
	/// is_playing(), set_paused(bool), release().
	/// </summary>
	public static GodotObject? PlayFile(string absolutePath, float volume = 1f, float pitch = 1f)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		GodotObject val = CreateSoundInstance(absolutePath);
		if (val == null)
		{
			return null;
		}
		try
		{
			if (volume != 1f)
			{
				val.Call(StringName.op_Implicit("set_volume"), (Variant[])(object)new Variant[1] { Variant.op_Implicit(volume) });
			}
			if (pitch != 1f)
			{
				val.Call(StringName.op_Implicit("set_pitch"), (Variant[])(object)new Variant[1] { Variant.op_Implicit(pitch) });
			}
			val.Call(StringName.op_Implicit("play"), Array.Empty<Variant>());
			return val;
		}
		catch (Exception ex)
		{
			BaseLibMain.Logger.Error("FmodAudio.PlayFile failed for '" + absolutePath + "': " + ex.Message, 1);
			return null;
		}
	}

	/// <summary>
	/// Play a custom file with cooldown, same idea as PlayEvent with cooldown.
	/// </summary>
	public static GodotObject? PlayFile(string absolutePath, int cooldownMs, float volume = 1f, float pitch = 1f)
	{
		long timestamp = Stopwatch.GetTimestamp();
		long num = (long)((double)(cooldownMs * Stopwatch.Frequency) / 1000.0);
		if (_cooldowns.TryGetValue(absolutePath, out var value) && timestamp - value < num)
		{
			return null;
		}
		_cooldowns[absolutePath] = timestamp;
		return PlayFile(absolutePath, volume, pitch);
	}

	/// <summary>
	/// Load a sound file into FMOD without playing it. Useful if you want to
	/// preload during init so there's no hitch on first play.
	/// </summary>
	public static bool PreloadFile(string absolutePath)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		if (Server == null)
		{
			return false;
		}
		if (_loadedFiles.ContainsKey(absolutePath))
		{
			return true;
		}
		try
		{
			Variant value = Server.Call(StringName.op_Implicit("load_file_as_sound"), (Variant[])(object)new Variant[1] { Variant.op_Implicit(absolutePath) });
			_loadedFiles[absolutePath] = value;
			return true;
		}
		catch (Exception ex)
		{
			BaseLibMain.Logger.Error("FmodAudio.PreloadFile failed for '" + absolutePath + "': " + ex.Message, 1);
			return false;
		}
	}

	/// <summary>
	/// Load a music/long-form file as streaming (reads from disk during playback
	/// instead of loading the whole thing into memory). Use this for tracks
	/// longer than ~10 seconds to save RAM.
	/// </summary>
	public static bool PreloadMusic(string absolutePath)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		if (Server == null)
		{
			return false;
		}
		if (_loadedFiles.ContainsKey(absolutePath))
		{
			return true;
		}
		try
		{
			Variant value = Server.Call(StringName.op_Implicit("load_file_as_music"), (Variant[])(object)new Variant[1] { Variant.op_Implicit(absolutePath) });
			_loadedFiles[absolutePath] = value;
			return true;
		}
		catch (Exception ex)
		{
			BaseLibMain.Logger.Error("FmodAudio.PreloadMusic failed for '" + absolutePath + "': " + ex.Message, 1);
			return false;
		}
	}

	/// <summary>
	/// Play a long-form audio file using streaming (doesn't load entire file
	/// into memory). Ideal for custom music tracks, long ambient loops, etc.
	/// </summary>
	public static GodotObject? PlayMusic(string absolutePath, float volume = 1f, float pitch = 1f)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		if (!_loadedFiles.ContainsKey(absolutePath) && !PreloadMusic(absolutePath))
		{
			return null;
		}
		GodotObject val = CreateSoundInstance(absolutePath);
		if (val == null)
		{
			return null;
		}
		try
		{
			if (volume != 1f)
			{
				val.Call(StringName.op_Implicit("set_volume"), (Variant[])(object)new Variant[1] { Variant.op_Implicit(volume) });
			}
			if (pitch != 1f)
			{
				val.Call(StringName.op_Implicit("set_pitch"), (Variant[])(object)new Variant[1] { Variant.op_Implicit(pitch) });
			}
			val.Call(StringName.op_Implicit("play"), Array.Empty<Variant>());
			return val;
		}
		catch (Exception ex)
		{
			BaseLibMain.Logger.Error("FmodAudio.PlayMusic failed for '" + absolutePath + "': " + ex.Message, 1);
			return null;
		}
	}

	/// <summary>
	/// Get a raw FmodSound instance for manual control. Loads the file first
	/// if it hasn't been loaded yet.
	/// </summary>
	public static GodotObject? CreateSoundInstance(string absolutePath)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		if (Server == null)
		{
			return null;
		}
		if (!_loadedFiles.ContainsKey(absolutePath) && !PreloadFile(absolutePath))
		{
			return null;
		}
		try
		{
			Variant val = Server.Call(StringName.op_Implicit("create_sound_instance"), (Variant[])(object)new Variant[1] { Variant.op_Implicit(absolutePath) });
			object obj = ((Variant)(ref val)).Obj;
			return (GodotObject?)((obj is GodotObject) ? obj : null);
		}
		catch (Exception ex)
		{
			BaseLibMain.Logger.Error("FmodAudio.CreateSoundInstance failed for '" + absolutePath + "': " + ex.Message, 1);
			return null;
		}
	}

	public static void UnloadFile(string absolutePath)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if (Server == null)
		{
			return;
		}
		try
		{
			Server.Call(StringName.op_Implicit("unload_file"), (Variant[])(object)new Variant[1] { Variant.op_Implicit(absolutePath) });
			_loadedFiles.Remove(absolutePath);
		}
		catch (Exception ex)
		{
			BaseLibMain.Logger.Error("FmodAudio.UnloadFile failed for '" + absolutePath + "': " + ex.Message, 1);
		}
	}

	/// <summary>
	/// Load a custom FMOD bank. Must be built with FMOD Studio 2.03.x to match
	/// the game's runtime. Load your strings bank first, then content banks.
	/// </summary>
	public static bool LoadBank(string bankPath)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (Server == null)
		{
			return false;
		}
		try
		{
			Variant value = Server.Call(StringName.op_Implicit("load_bank"), (Variant[])(object)new Variant[2]
			{
				Variant.op_Implicit(bankPath),
				Variant.op_Implicit(0)
			});
			_loadedBanks[bankPath] = value;
			BaseLibMain.Logger.Info("Loaded FMOD bank: " + bankPath, 1);
			return true;
		}
		catch (Exception ex)
		{
			BaseLibMain.Logger.Error("FmodAudio.LoadBank failed for '" + bankPath + "': " + ex.Message, 1);
			return false;
		}
	}

	public static void UnloadBank(string bankPath)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if (Server == null)
		{
			return;
		}
		try
		{
			Server.Call(StringName.op_Implicit("unload_bank"), (Variant[])(object)new Variant[1] { Variant.op_Implicit(bankPath) });
			_loadedBanks.Remove(bankPath);
		}
		catch (Exception ex)
		{
			BaseLibMain.Logger.Error("FmodAudio.UnloadBank failed for '" + bankPath + "': " + ex.Message, 1);
		}
	}

	/// <summary>
	/// Register a replacement for a game sound. When the game tries to play
	/// originalEvent, your replacement runs instead. Lets multiple mods swap
	/// sounds without writing their own Harmony patches.
	///
	/// The handler receives (eventPath, volume) and returns true if it handled
	/// playback (which skips the original), or false to let it through.
	/// </summary>
	public static void RegisterReplacement(string originalEvent, Func<string, float, bool> handler)
	{
		_replacements[originalEvent] = handler;
		EnsureReplacementPatch();
	}

	/// <summary>
	/// Shorthand: replace an FMOD event with a custom file.
	/// </summary>
	public static void RegisterFileReplacement(string originalEvent, string replacementFilePath)
	{
		RegisterReplacement(originalEvent, delegate(string _, float volume)
		{
			PlayFile(replacementFilePath, volume);
			return true;
		});
	}

	/// <summary>
	/// Shorthand: replace an FMOD event with a different FMOD event.
	/// </summary>
	public static void RegisterEventReplacement(string originalEvent, string replacementEvent)
	{
		RegisterReplacement(originalEvent, delegate
		{
			PlayEvent(replacementEvent);
			return true;
		});
	}

	/// <summary>
	/// Remove a previously registered replacement.
	/// </summary>
	public static void RemoveReplacement(string originalEvent)
	{
		_replacements.Remove(originalEvent);
	}

	/// <summary>
	/// Remove all replacements registered by any mod.
	/// </summary>
	public static void ClearReplacements()
	{
		_replacements.Clear();
	}

	private static void EnsureReplacementPatch()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		if (!_replacementPatchApplied)
		{
			_replacementPatchApplied = true;
			Harmony val = new Harmony("BaseLib.FmodAudio.Replacements");
			MethodInfo methodInfo = AccessTools.Method(typeof(NAudioManager), "PlayOneShot", new Type[2]
			{
				typeof(string),
				typeof(float)
			}, (Type[])null);
			MethodInfo methodInfo2 = AccessTools.Method(typeof(FmodAudio), "ReplacementPrefix", (Type[])null, (Type[])null);
			if (methodInfo != null && methodInfo2 != null)
			{
				val.Patch((MethodBase)methodInfo, new HarmonyMethod(methodInfo2), (HarmonyMethod)null, (HarmonyMethod)null, (HarmonyMethod)null);
			}
		}
	}

	private static bool ReplacementPrefix(string path, float volume)
	{
		if (_replacements.TryGetValue(path, out Func<string, float, bool> value))
		{
			try
			{
				if (value(path, volume))
				{
					return false;
				}
			}
			catch (Exception ex)
			{
				BaseLibMain.Logger.Error("FmodAudio replacement handler for '" + path + "' threw: " + ex.Message, 1);
			}
		}
		return true;
	}

	/// <summary>
	/// Create a named pool of sounds. When played, one is chosen at random.
	/// Avoids repeating the same sound twice in a row.
	///
	/// Entries can be FMOD event paths ("event:/...") or absolute file paths.
	/// </summary>
	public static void CreatePool(string poolName, params string[] soundPaths)
	{
		_soundPools[poolName] = new SoundPool(soundPaths);
	}

	/// <summary>
	/// Add more sounds to an existing pool, or create it if it doesn't exist.
	/// </summary>
	public static void AddToPool(string poolName, params string[] soundPaths)
	{
		if (!_soundPools.TryGetValue(poolName, out SoundPool value))
		{
			value = new SoundPool(Array.Empty<string>());
			_soundPools[poolName] = value;
		}
		value.Entries.AddRange(soundPaths);
	}

	/// <summary>
	/// Play a random sound from a named pool. Returns null if the pool doesn't exist
	/// or is empty. For file entries, returns the FmodSound handle.
	/// </summary>
	public static GodotObject? PlayPool(string poolName, float volume = 1f, float pitch = 1f)
	{
		if (!_soundPools.TryGetValue(poolName, out SoundPool value) || value.Entries.Count == 0)
		{
			return null;
		}
		string text = value.PickNext(_poolRng);
		if (text.StartsWith("event:/"))
		{
			PlayEvent(text);
			return null;
		}
		return PlayFile(text, volume, pitch);
	}

	/// <summary>
	/// Play from a pool with cooldown. Skipped if the pool was played within cooldownMs.
	/// </summary>
	public static GodotObject? PlayPool(string poolName, int cooldownMs, float volume = 1f, float pitch = 1f)
	{
		string key = "__pool__" + poolName;
		long timestamp = Stopwatch.GetTimestamp();
		long num = (long)((double)(cooldownMs * Stopwatch.Frequency) / 1000.0);
		if (_cooldowns.TryGetValue(key, out var value) && timestamp - value < num)
		{
			return null;
		}
		_cooldowns[key] = timestamp;
		return PlayPool(poolName, volume, pitch);
	}

	public static void RemovePool(string poolName)
	{
		_soundPools.Remove(poolName);
	}

	/// <summary>
	/// Start an FMOD snapshot (e.g. "snapshot:/pause" for the game's pause
	/// ducking effect). Snapshots apply mixer effects globally — low-pass
	/// filters, reverb changes, volume ducking, etc.
	///
	/// Returns the snapshot instance. Call stop + release on it when done.
	/// </summary>
	public static GodotObject? StartSnapshot(string snapshotPath)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		if (Server == null)
		{
			return null;
		}
		try
		{
			Variant val = Server.Call(StringName.op_Implicit("create_event_instance"), (Variant[])(object)new Variant[1] { Variant.op_Implicit(snapshotPath) });
			object obj = ((Variant)(ref val)).Obj;
			object obj2 = ((obj is GodotObject) ? obj : null);
			if (obj2 != null)
			{
				((GodotObject)obj2).Call(StringName.op_Implicit("start"), Array.Empty<Variant>());
			}
			return (GodotObject?)obj2;
		}
		catch (Exception ex)
		{
			BaseLibMain.Logger.Error("FmodAudio.StartSnapshot failed for '" + snapshotPath + "': " + ex.Message, 1);
			return null;
		}
	}

	/// <summary>
	/// Stop a snapshot instance. allowFadeout=true lets FMOD's release envelope
	/// run (smooth transition), false cuts immediately.
	/// </summary>
	public static void StopSnapshot(GodotObject? snapshot, bool allowFadeout = true)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (snapshot == null)
		{
			return;
		}
		try
		{
			snapshot.Call(StringName.op_Implicit("stop"), (Variant[])(object)new Variant[1] { Variant.op_Implicit((!allowFadeout) ? 1 : 0) });
			snapshot.Call(StringName.op_Implicit("release"), Array.Empty<Variant>());
		}
		catch (Exception ex)
		{
			BaseLibMain.Logger.Error("FmodAudio.StopSnapshot failed: " + ex.Message, 1);
		}
	}

	/// <summary>
	/// Get a bus object for direct control. Common paths:
	///   "bus:/master", "bus:/master/sfx", "bus:/master/music",
	///   "bus:/master/ambience", "bus:/master/sfx/Reverb", "bus:/master/sfx/chorus"
	/// </summary>
	public static GodotObject? GetBus(string busPath)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		if (Server == null)
		{
			return null;
		}
		try
		{
			Variant val = Server.Call(StringName.op_Implicit("get_bus"), (Variant[])(object)new Variant[1] { Variant.op_Implicit(busPath) });
			object obj = ((Variant)(ref val)).Obj;
			return (GodotObject?)((obj is GodotObject) ? obj : null);
		}
		catch (Exception ex)
		{
			BaseLibMain.Logger.Error("FmodAudio.GetBus failed for '" + busPath + "': " + ex.Message, 1);
			return null;
		}
	}

	/// <summary>
	/// Set the volume on a bus. Affects all sounds routed through it.
	/// </summary>
	public static void SetBusVolume(string busPath, float volume)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		GodotObject? bus = GetBus(busPath);
		if (bus != null)
		{
			bus.Call(StringName.op_Implicit("set_volume"), (Variant[])(object)new Variant[1] { Variant.op_Implicit(volume) });
		}
	}

	/// <summary>
	/// Get the current volume of a bus.
	/// </summary>
	public static float GetBusVolume(string busPath)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		GodotObject bus = GetBus(busPath);
		if (bus == null)
		{
			return 0f;
		}
		try
		{
			Variant val = bus.Call(StringName.op_Implicit("get_volume"), Array.Empty<Variant>());
			return ((Variant)(ref val)).AsSingle();
		}
		catch
		{
			return 0f;
		}
	}

	/// <summary>
	/// Mute or unmute a bus.
	/// </summary>
	public static void SetBusMute(string busPath, bool muted)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		GodotObject? bus = GetBus(busPath);
		if (bus != null)
		{
			bus.Call(StringName.op_Implicit("set_mute"), (Variant[])(object)new Variant[1] { Variant.op_Implicit(muted) });
		}
	}

	/// <summary>
	/// Pause or unpause all sounds on a bus.
	/// </summary>
	public static void SetBusPaused(string busPath, bool paused)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		GodotObject? bus = GetBus(busPath);
		if (bus != null)
		{
			bus.Call(StringName.op_Implicit("set_paused"), (Variant[])(object)new Variant[1] { Variant.op_Implicit(paused) });
		}
	}

	public static void SetGlobalParameter(string name, float value)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (Server == null)
		{
			return;
		}
		try
		{
			Server.Call(StringName.op_Implicit("set_global_parameter_by_name"), (Variant[])(object)new Variant[2]
			{
				Variant.op_Implicit(name),
				Variant.op_Implicit(value)
			});
		}
		catch (Exception ex)
		{
			BaseLibMain.Logger.Error("FmodAudio.SetGlobalParameter(" + name + "): " + ex.Message, 1);
		}
	}

	/// <summary>
	/// Set a global parameter using a label instead of a numeric value.
	/// Some parameters define named labels (e.g. Progress has "Enemy", "Merchant", etc.)
	/// </summary>
	public static void SetGlobalParameterByLabel(string name, string label)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (Server == null)
		{
			return;
		}
		try
		{
			Server.Call(StringName.op_Implicit("set_global_parameter_by_name_with_label"), (Variant[])(object)new Variant[2]
			{
				Variant.op_Implicit(name),
				Variant.op_Implicit(label)
			});
		}
		catch (Exception ex)
		{
			BaseLibMain.Logger.Error($"FmodAudio.SetGlobalParameterByLabel({name}, {label}): {ex.Message}", 1);
		}
	}

	public static float GetGlobalParameter(string name)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (Server == null)
		{
			return 0f;
		}
		try
		{
			Variant val = Server.Call(StringName.op_Implicit("get_global_parameter_by_name"), (Variant[])(object)new Variant[1] { Variant.op_Implicit(name) });
			return ((Variant)(ref val)).AsSingle();
		}
		catch
		{
			return 0f;
		}
	}

	public static void MuteAll()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (Server == null)
		{
			return;
		}
		try
		{
			Server.Call(StringName.op_Implicit("mute_all_events"), Array.Empty<Variant>());
		}
		catch (Exception ex)
		{
			BaseLibMain.Logger.Error("FmodAudio.MuteAll: " + ex.Message, 1);
		}
	}

	public static void UnmuteAll()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (Server == null)
		{
			return;
		}
		try
		{
			Server.Call(StringName.op_Implicit("unmute_all_events"), Array.Empty<Variant>());
		}
		catch (Exception ex)
		{
			BaseLibMain.Logger.Error("FmodAudio.UnmuteAll: " + ex.Message, 1);
		}
	}

	public static void PauseAll()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (Server == null)
		{
			return;
		}
		try
		{
			Server.Call(StringName.op_Implicit("pause_all_events"), Array.Empty<Variant>());
		}
		catch (Exception ex)
		{
			BaseLibMain.Logger.Error("FmodAudio.PauseAll: " + ex.Message, 1);
		}
	}

	public static void UnpauseAll()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (Server == null)
		{
			return;
		}
		try
		{
			Server.Call(StringName.op_Implicit("unpause_all_events"), Array.Empty<Variant>());
		}
		catch (Exception ex)
		{
			BaseLibMain.Logger.Error("FmodAudio.UnpauseAll: " + ex.Message, 1);
		}
	}

	/// <summary>
	/// Adjust the DSP buffer size. Larger buffers reduce crackling on slow
	/// hardware but increase audio latency. Default is usually 1024 samples
	/// with 4 buffers. Only change this if players report audio glitches.
	/// </summary>
	public static void SetDspBufferSize(int bufferLength, int numBuffers)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (Server == null)
		{
			return;
		}
		try
		{
			Server.Call(StringName.op_Implicit("set_system_dsp_buffer_size"), (Variant[])(object)new Variant[2]
			{
				Variant.op_Implicit(bufferLength),
				Variant.op_Implicit(numBuffers)
			});
		}
		catch (Exception ex)
		{
			BaseLibMain.Logger.Error("FmodAudio.SetDspBufferSize: " + ex.Message, 1);
		}
	}

	/// <summary>
	/// Get current DSP buffer settings: (bufferLength, numBuffers).
	/// </summary>
	public static (int bufferLength, int numBuffers) GetDspBufferSettings()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (Server == null)
		{
			return (bufferLength: 0, numBuffers: 0);
		}
		try
		{
			Variant val = Server.Call(StringName.op_Implicit("get_system_dsp_buffer_length"), Array.Empty<Variant>());
			int item = ((Variant)(ref val)).AsInt32();
			val = Server.Call(StringName.op_Implicit("get_system_dsp_num_buffers"), Array.Empty<Variant>());
			int item2 = ((Variant)(ref val)).AsInt32();
			return (bufferLength: item, numBuffers: item2);
		}
		catch
		{
			return (bufferLength: 0, numBuffers: 0);
		}
	}

	/// <summary>
	/// Get FMOD performance data. Returns raw performance info from the engine —
	/// CPU usage, memory, channels, etc. Useful for debugging audio-heavy mods.
	/// </summary>
	public static Variant GetPerformanceData()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if (Server == null)
		{
			return default(Variant);
		}
		try
		{
			return Server.Call(StringName.op_Implicit("get_performance_data"), Array.Empty<Variant>());
		}
		catch
		{
			return default(Variant);
		}
	}

	/// <summary>
	/// Check whether an event path exists in any currently loaded bank.
	/// </summary>
	public static bool EventExists(string eventPath)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		if (Server == null)
		{
			return false;
		}
		try
		{
			Variant val = Server.Call(StringName.op_Implicit("check_event_path"), (Variant[])(object)new Variant[1] { Variant.op_Implicit(eventPath) });
			return ((Variant)(ref val)).AsBool();
		}
		catch
		{
			return false;
		}
	}

	/// <summary>
	/// Check whether a bus path exists.
	/// </summary>
	public static bool BusExists(string busPath)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		if (Server == null)
		{
			return false;
		}
		try
		{
			Variant val = Server.Call(StringName.op_Implicit("check_bus_path"), (Variant[])(object)new Variant[1] { Variant.op_Implicit(busPath) });
			return ((Variant)(ref val)).AsBool();
		}
		catch
		{
			return false;
		}
	}

	/// <summary>
	/// Unload everything this helper has loaded and clear all registrations.
	/// FMOD cleans up on game exit anyway, but this is here for mods that
	/// need to tear down gracefully.
	/// </summary>
	public static void UnloadAll()
	{
		foreach (string item in _loadedFiles.Keys.ToList())
		{
			UnloadFile(item);
		}
		foreach (string item2 in _loadedBanks.Keys.ToList())
		{
			UnloadBank(item2);
		}
		_replacements.Clear();
		_cooldowns.Clear();
		_soundPools.Clear();
	}
}
