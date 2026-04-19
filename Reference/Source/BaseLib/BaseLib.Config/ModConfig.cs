using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using System.Threading;
using System.Threading.Tasks;
using BaseLib.Config.UI;
using BaseLib.Extensions;
using Godot;
using MegaCrit.Sts2.Core.Assets;
using MegaCrit.Sts2.Core.Helpers;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Nodes.CommonUi;
using MegaCrit.Sts2.Core.Nodes.Screens.Settings;
using MegaCrit.Sts2.addons.mega_text;

namespace BaseLib.Config;

public abstract class ModConfig
{
	public static class ModConfigLogger
	{
		public static List<string> PendingUserMessages { get; } = new List<string>();

		/// <summary>
		/// Show a message in the console, and optionally in the GUI. Only use showInGui=true if truly necessary;
		/// players won't enjoy having warnings/errors shoved in their faces unless it's something that truly impacts them.
		/// </summary>
		public static void Warn(string message, bool showInGui = false)
		{
			BaseLibMain.Logger.Warn(message, 1);
			if (showInGui && !PendingUserMessages.Contains(message))
			{
				PendingUserMessages.Add(message);
			}
		}

		/// <inheritdoc cref="M:BaseLib.Config.ModConfig.ModConfigLogger.Warn(System.String,System.Boolean)" />
		public static void Error(string message, bool showInGui = true)
		{
			BaseLibMain.Logger.Error(message, 1);
			if (showInGui && !PendingUserMessages.Contains(message))
			{
				PendingUserMessages.Add(message);
			}
		}
	}

	private const string SettingsTheme = "res://themes/settings_screen_line_header.tres";

	private readonly string _path;

	private readonly string _modConfigName;

	private bool _savingDisabled;

	private static readonly JsonSerializerOptions JsonOptions;

	private CancellationTokenSource? _saveDebounceToken;

	private readonly SemaphoreSlim _saveLock = new SemaphoreSlim(1, 1);

	protected readonly List<PropertyInfo> ConfigProperties = new List<PropertyInfo>();

	private readonly Dictionary<string, object?> _defaultValues = new Dictionary<string, object>();

	public string ModPrefix { get; private set; }

	[ConfigIgnore]
	public string? ModId { get; set; }

	/// <summary>
	/// Event that fires when <see cref="M:BaseLib.Config.ModConfig.Changed" /> is called. Custom controls must call Changed() when mutating
	/// a property.
	/// </summary>
	public event EventHandler? ConfigChanged;

	public event Action? OnConfigReloaded;

	public void ConfigReloaded()
	{
		this.OnConfigReloaded?.Invoke();
	}

	static ModConfig()
	{
		JsonOptions = new JsonSerializerOptions
		{
			WriteIndented = true
		};
		TypeDescriptor.AddAttributes(typeof(Color), new TypeConverterAttribute(typeof(GodotColorConverter)));
	}

	public ModConfig(string? filename = null)
	{
		ModPrefix = GetType().GetPrefix();
		ModId = null;
		_modConfigName = GetType().FullName ?? "unknown";
		string rootNamespace = GetType().GetRootNamespace();
		if (string.IsNullOrEmpty(rootNamespace) && string.IsNullOrEmpty(filename))
		{
			string message = "Cannot determine a safe configuration file path for " + _modConfigName + " (assembly " + GetType().Assembly.GetName().Name + "). You must either place your configuration class inside a namespace, or explicitly provide a filename in the constructor.";
			ModConfigLogger.Error(message);
			throw new InvalidOperationException(message);
		}
		string text = SpecialCharRegex().Replace(rootNamespace, "");
		filename = ((filename == null) ? text : SpecialCharRegex().Replace(filename, ""));
		if (!filename.Contains('.'))
		{
			filename += ".cfg";
		}
		_path = Path.Combine(OS.GetUserDataDir(), "mod_configs", filename);
		CheckConfigProperties();
		Init();
	}

	public bool HasSettings()
	{
		return ConfigProperties.Count > 0;
	}

	public bool HasVisibleSettings()
	{
		return ConfigProperties.Any((PropertyInfo p) => p.GetCustomAttribute<ConfigHideInUI>() == null);
	}

	private void CheckConfigProperties()
	{
		Type type = GetType();
		ConfigProperties.Clear();
		PropertyInfo[] properties = type.GetProperties();
		foreach (PropertyInfo propertyInfo in properties)
		{
			if (propertyInfo.GetCustomAttribute<ConfigIgnoreAttribute>() == null && propertyInfo.CanRead && propertyInfo.CanWrite)
			{
				MethodInfo? getMethod = propertyInfo.GetMethod;
				if ((object)getMethod == null || !getMethod.IsStatic)
				{
					ModConfigLogger.Warn($"Ignoring {_modConfigName} property {propertyInfo.Name}: only static properties are supported");
				}
				else
				{
					ConfigProperties.Add(propertyInfo);
				}
			}
		}
	}

	public T? GetDefaultValue<T>(string propertyName)
	{
		if (_defaultValues.TryGetValue(propertyName, out object value) && value is T)
		{
			return (T)value;
		}
		return default(T);
	}

	protected void RestoreDefaultsNoConfirm()
	{
		foreach (PropertyInfo configProperty in ConfigProperties)
		{
			object defaultValue = GetDefaultValue<object>(configProperty.Name);
			configProperty.SetValue(null, defaultValue);
		}
		Save();
		this.OnConfigReloaded?.Invoke();
	}

	public abstract void SetupConfigUI(Control optionContainer);

	private void Init()
	{
		foreach (PropertyInfo configProperty in ConfigProperties)
		{
			_defaultValues.TryAdd(configProperty.Name, configProperty.GetValue(null));
		}
		if (File.Exists(_path))
		{
			Load();
		}
		else
		{
			Save();
		}
	}

	public void Changed()
	{
		this.ConfigChanged?.Invoke(this, EventArgs.Empty);
	}

	/// <summary>
	/// Static helper to reload your mod's config, for when you don't have easy access to the instance.
	/// </summary>
	/// <typeparam name="T">Your ModConfig subclass</typeparam>
	/// <example><code>
	/// internal class MyConfig : SimpleModConfig { ... }
	/// ModConfig.Load&lt;MyConfig&gt;();
	/// </code></example>
	public static void Load<T>() where T : ModConfig
	{
		ModConfigRegistry.Get<T>()?.Load();
	}

	/// <summary>
	/// <para>Save after <paramref name="delayMs" /> ms, unless SaveDebounced was called again during the delay, in which
	/// case the old request is canceled and the new one replaces it.</para>
	/// <para>Note that you ONLY ever need to call this if you yourself modify the properties at runtime. BaseLib will
	/// always save when the user changes something in the settings screen.</para>
	/// </summary>
	/// <typeparam name="T">Your ModConfig subclass</typeparam>
	/// <example><code>
	/// internal class MyConfig : SimpleModConfig { ... }
	/// ModConfig.SaveDebounced&lt;MyConfig&gt;();
	/// </code></example>
	public static void SaveDebounced<T>(int delayMs = 1000) where T : ModConfig
	{
		ModConfigRegistry.Get<T>()?.SaveDebounced(delayMs);
	}

	/// <summary>
	/// <para>Save after <paramref name="delayMs" /> ms, unless SaveDebounced was called again during the delay, in which case
	/// the old request is canceled and the new one replaces it.</para>
	/// <para>Note that you ONLY ever need to call this if you yourself modify the properties at runtime. BaseLib will always
	/// save when the user changes something in the settings screen.</para>
	/// </summary>
	public void SaveDebounced(int delayMs = 1000)
	{
		SaveDebouncedInternal(delayMs);
	}

	private async void SaveDebouncedInternal(int delayMs = 1000)
	{
		_ = 1;
		try
		{
			_saveDebounceToken?.Cancel();
			_saveDebounceToken?.Dispose();
			_saveDebounceToken = new CancellationTokenSource();
			CancellationToken token = _saveDebounceToken.Token;
			await Task.Delay(delayMs, token);
			await _saveLock.WaitAsync(token);
			try
			{
				Save();
			}
			finally
			{
				_saveLock.Release();
			}
		}
		catch (OperationCanceledException)
		{
		}
		catch (Exception ex2)
		{
			ModConfigLogger.Error("Failed to save config for " + _modConfigName + ": " + ex2.Message);
		}
	}

	/// <summary>
	/// Immediately save the current configuration to disk. Prefer using <see cref="M:BaseLib.Config.ModConfig.SaveDebounced(System.Int32)" /> (on the instance or
	/// its static variant) instead unless you absolutely must save *now*. Indeed, using SaveDebounced(0) is likely still
	/// better than calling this directly.<br />
	/// Using both is not recommended and may cause issues with locking/hangs.
	/// </summary>
	public void Save()
	{
		if (_savingDisabled)
		{
			ModConfigLogger.Warn("Skipping save for " + _modConfigName + " because the config file is currently in a corrupted, read-only state.");
			return;
		}
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		try
		{
			foreach (PropertyInfo configProperty in ConfigProperties)
			{
				object value = configProperty.GetValue(null);
				string text = TypeDescriptor.GetConverter(configProperty.PropertyType).ConvertToInvariantString(value);
				if (text != null)
				{
					dictionary.Add(configProperty.Name, text);
					continue;
				}
				ModConfigLogger.Warn($"Failed to convert {_modConfigName} property {configProperty.Name} to string for saving; " + "it will be omitted.");
			}
		}
		catch (Exception)
		{
			ModConfigLogger.Error("Failed to save config " + _modConfigName + ": unknown error during conversion.", showInGui: false);
			return;
		}
		try
		{
			new FileInfo(_path).Directory?.Create();
			using FileStream utf8Json = File.Create(_path);
			JsonSerializer.Serialize(utf8Json, dictionary, JsonOptions);
		}
		catch (Exception ex2)
		{
			ModConfigLogger.Error("Failed to save config " + _modConfigName + ": " + ex2.Message);
		}
	}

	public void Load()
	{
		if (!File.Exists(_path))
		{
			ModConfigLogger.Error("Load for " + _modConfigName + " failed. File not found: " + _path);
			return;
		}
		bool flag = false;
		_savingDisabled = false;
		try
		{
			Dictionary<string, string> dictionary;
			using (FileStream utf8Json = File.OpenRead(_path))
			{
				dictionary = JsonSerializer.Deserialize<Dictionary<string, string>>(utf8Json);
			}
			if (dictionary == null)
			{
				ModConfigLogger.Warn("Config file " + _modConfigName + " was empty or null. Will re-save using default values.");
				flag = true;
			}
			else
			{
				foreach (PropertyInfo configProperty in ConfigProperties)
				{
					if (!dictionary.TryGetValue(configProperty.Name, out var value))
					{
						ModConfigLogger.Warn($"Config {_modConfigName} has no value for {configProperty.Name}; will re-save to fill in the default.");
						flag = true;
					}
					else if (!TryApplyPropertyValue(configProperty, value))
					{
						flag = true;
					}
				}
				if (flag)
				{
					ModConfigLogger.Warn("Loaded config " + _modConfigName + " with some missing or invalid fields.");
				}
			}
		}
		catch (JsonException ex)
		{
			string value2 = (ex.LineNumber.HasValue ? $"Line {ex.LineNumber + 1}, position {ex.BytePositionInLine + 1}" : "unknown line");
			ModConfigLogger.Error($"Failed to parse config file for {_modConfigName}. The JSON is likely invalid.\nFile path: {_path}\nError location: {value2}");
			ModConfigLogger.Warn("Config saving has been DISABLED for this mod to protect any manual edits.", showInGui: true);
			_savingDisabled = true;
			return;
		}
		catch (Exception ex2)
		{
			ModConfigLogger.Error("Unexpected error loading config " + _modConfigName + ": " + ex2.Message);
			return;
		}
		if (flag && !_savingDisabled)
		{
			ModConfigLogger.Warn("Saving fresh config for " + _modConfigName + " to correct soft errors (missing fields, invalid fields).");
			Save();
		}
	}

	private static bool TryApplyPropertyValue(PropertyInfo property, string value)
	{
		try
		{
			object obj = TypeDescriptor.GetConverter(property.PropertyType).ConvertFromInvariantString(value);
			if (obj == null)
			{
				ModConfigLogger.Warn($"Failed to load saved config value \"{value}\" for property {property.Name}:" + "Converter returned null.");
				return false;
			}
			object value2 = property.GetValue(null);
			if (!obj.Equals(value2))
			{
				property.SetValue(null, obj);
			}
			return true;
		}
		catch (Exception ex)
		{
			ModConfigLogger.Warn($"Failed to load saved config value \"{value}\" for property {property.Name}. Error: {ex.Message}");
			return false;
		}
	}

	protected string GetLabelText(string labelName)
	{
		LocString ifExists = LocString.GetIfExists("settings_ui", ModPrefix + StringHelper.Slugify(labelName) + ".title");
		if (ifExists == null)
		{
			return labelName;
		}
		return ifExists.GetFormattedText();
	}

	protected static string GetBaseLibLabelText(string labelName)
	{
		LocString ifExists = LocString.GetIfExists("settings_ui", "BASELIB-" + StringHelper.Slugify(labelName) + ".title");
		if (ifExists == null)
		{
			return labelName;
		}
		return ifExists.GetFormattedText();
	}

	/// <summary>
	/// Creates a raw control, with no layout (label, margins), no automatic hover tip, etc.<br />
	/// Use the Create*Option methods instead unless you need a custom layout (or use them, and customize them).
	/// </summary>
	/// <param name="property">The property this control is bound to. Fetch with e.g. GetType().GetProperty() in
	/// a ModConfig.</param>
	protected NConfigTickbox CreateRawTickboxControl(PropertyInfo property)
	{
		NConfigTickbox nConfigTickbox = new NConfigTickbox();
		nConfigTickbox.Initialize(this, property);
		return nConfigTickbox;
	}

	/// <inheritdoc cref="M:BaseLib.Config.ModConfig.CreateRawTickboxControl(System.Reflection.PropertyInfo)" />
	protected NConfigSlider CreateRawSliderControl(PropertyInfo property)
	{
		NConfigSlider nConfigSlider = new NConfigSlider();
		nConfigSlider.Initialize(this, property);
		return nConfigSlider;
	}

	/// <inheritdoc cref="M:BaseLib.Config.ModConfig.CreateRawTickboxControl(System.Reflection.PropertyInfo)" />
	protected NConfigLineEdit CreateRawLineEditControl(PropertyInfo property)
	{
		NConfigLineEdit nConfigLineEdit = new NConfigLineEdit();
		nConfigLineEdit.Initialize(this, property);
		return nConfigLineEdit;
	}

	/// <inheritdoc cref="M:BaseLib.Config.ModConfig.CreateRawTickboxControl(System.Reflection.PropertyInfo)" />
	protected NConfigColorPicker CreateRawColorPickerControl(PropertyInfo property)
	{
		NConfigColorPicker nConfigColorPicker = new NConfigColorPicker();
		nConfigColorPicker.Initialize(this, property);
		return nConfigColorPicker;
	}

	/// <summary>
	/// Creates a raw button control. You may want <see cref="M:BaseLib.Config.SimpleModConfig.CreateButton(System.String,System.String,System.Action,System.Boolean)" /> instead.
	/// </summary>
	/// <param name="labelText">The text to place on the button</param>
	/// <param name="onPressed">Action to perform when the user clicks/presses the button.</param>
	protected NConfigButton CreateRawButtonControl(string labelText, Action onPressed)
	{
		NConfigButton nConfigButton = new NConfigButton();
		nConfigButton.Initialize(labelText, onPressed);
		return nConfigButton;
	}

	/// <inheritdoc cref="M:BaseLib.Config.ModConfig.CreateRawTickboxControl(System.Reflection.PropertyInfo)" />
	protected NDropdownPositioner CreateRawDropdownControl(PropertyInfo property)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		NConfigDropdown nConfigDropdown = new NConfigDropdown();
		nConfigDropdown.Initialize(this, property, ModPrefix, Changed);
		nConfigDropdown.SetFromProperty();
		NDropdownPositioner val = new NDropdownPositioner();
		((Control)val).SetCustomMinimumSize(new Vector2(324f, 64f));
		((Control)val).FocusMode = (FocusModeEnum)0;
		((Control)val).SizeFlagsHorizontal = (SizeFlags)8;
		((Control)val).SizeFlagsVertical = (SizeFlags)1;
		val._dropdownNode = (Control)(object)nConfigDropdown;
		((Node)val).AddChild((Node)(object)nConfigDropdown, false, (InternalMode)0);
		((Control)val).MouseFilter = (MouseFilterEnum)2;
		return val;
	}

	/// <inheritdoc cref="M:BaseLib.Config.ModConfig.CreateRawTickboxControl(System.Reflection.PropertyInfo)" />
	public static MegaRichTextLabel CreateRawLabelControl(string labelText, int fontSize)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00a8: Expected O, but got Unknown
		Font asset = PreloadManager.Cache.GetAsset<Font>("res://themes/kreon_regular_shared.tres");
		Font asset2 = PreloadManager.Cache.GetAsset<Font>("res://themes/kreon_bold_shared.tres");
		MegaRichTextLabel val = new MegaRichTextLabel
		{
			Name = StringName.op_Implicit("Label"),
			Theme = PreloadManager.Cache.GetAsset<Theme>("res://themes/settings_screen_line_header.tres"),
			AutoSizeEnabled = false,
			MouseFilter = (MouseFilterEnum)2,
			FocusMode = (FocusModeEnum)0,
			BbcodeEnabled = true,
			ScrollActive = false,
			VerticalAlignment = (VerticalAlignment)1,
			Text = labelText
		};
		((Control)val).AddThemeFontOverride(StringName.op_Implicit("normal_font"), asset);
		((Control)val).AddThemeFontOverride(StringName.op_Implicit("bold_font"), asset2);
		((Control)val).AddThemeFontSizeOverrideAll(fontSize);
		return val;
	}

	protected static ColorRect CreateDividerControl()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		return new ColorRect
		{
			Name = StringName.op_Implicit("Divider"),
			CustomMinimumSize = new Vector2(0f, 2f),
			MouseFilter = (MouseFilterEnum)2,
			Color = new Color(0.909804f, 0.862745f, 0.745098f, 0.25098f)
		};
	}

	public static void ShowAndClearPendingErrors()
	{
		List<string> pendingUserMessages = ModConfigLogger.PendingUserMessages;
		if (pendingUserMessages.Count <= 0)
		{
			return;
		}
		NErrorPopup val = NErrorPopup.Create("Mod configuration error", string.Join('\n', pendingUserMessages), false);
		if (val != null && NModalContainer.Instance != null)
		{
			NModalContainer.Instance.Add((Node)(object)val, true);
			NVerticalPopup nodeOrNull = ((Node)val).GetNodeOrNull<NVerticalPopup>(NodePath.op_Implicit("VerticalPopup"));
			if (nodeOrNull != null)
			{
				((Control)(object)nodeOrNull.BodyLabel).AddThemeFontSizeOverrideAll(22);
				pendingUserMessages.Clear();
			}
		}
	}

	/// <remarks>
	/// Pattern:<br />
	/// <code>[^a-zA-Z0-9_.]</code><br />
	/// Explanation:<br />
	/// <code>
	/// ○ Match a character in the set [^.0-9A-Z_a-z].<br />
	/// </code>
	/// </remarks>
	[GeneratedRegex("[^a-zA-Z0-9_.]")]
	[GeneratedCode("System.Text.RegularExpressions.Generator", "9.0.14.6317")]
	private static Regex SpecialCharRegex()
	{
		return _003CRegexGenerator_g_003EF2510F4315406E63A39BEC1503FA28868C36343733B7483E5396C61FEAF06DCCD__SpecialCharRegex_0.Instance;
	}
}
