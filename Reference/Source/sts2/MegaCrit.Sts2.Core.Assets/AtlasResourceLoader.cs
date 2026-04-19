using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Assets;

[ScriptPath("res://src/Core/Assets/AtlasResourceLoader.cs")]
public class AtlasResourceLoader : ResourceFormatLoader
{
	public new class MethodName : ResourceFormatLoader.MethodName
	{
		public new static readonly StringName _GetRecognizedExtensions;

		public new static readonly StringName _HandlesType;

		public new static readonly StringName _GetResourceType;

		public new static readonly StringName _RecognizePath;

		public new static readonly StringName _Exists;

		public new static readonly StringName _Load;

		public new static readonly StringName _GetDependencies;

		public static readonly StringName IsSpritePath;

		public static readonly StringName HasFallback;

		public static readonly StringName LoadFallback;

		public static readonly StringName GetFallbackPath;

		public static readonly StringName GetRelicFallbackPath;

		public static readonly StringName GetPowerFallbackPath;

		public static readonly StringName GetCardFallbackPath;

		public static readonly StringName GetPotionFallbackPath;

		public static readonly StringName GetMissingTexture;

		public extern MethodName();
	}

	public new class PropertyName : ResourceFormatLoader.PropertyName
	{
		public extern PropertyName();
	}

	public new class SignalName : ResourceFormatLoader.SignalName
	{
		public extern SignalName();
	}

	public override extern string[] _GetRecognizedExtensions();

	public override extern bool _HandlesType(StringName type);

	public override extern string _GetResourceType(string path);

	public override extern bool _RecognizePath(string path, StringName type);

	public override extern bool _Exists(string path);

	public override extern Variant _Load(string path, string originalPath, bool useSubThreads, int cacheMode);

	public override extern string[] _GetDependencies(string path, bool addTypes);

	public static extern (string? AtlasName, string? SpriteName) ParsePath(string path);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool InvokeGodotClassMethod(in godot_string_name method, NativeVariantPtrArgs args, out godot_variant ret);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassMethod(in godot_string_name method);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void SaveGodotObjectData(GodotSerializationInfo info);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RestoreGodotObjectData(GodotSerializationInfo info);

	public extern AtlasResourceLoader();
}
