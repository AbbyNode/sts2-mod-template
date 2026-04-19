using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Nodes.Potions;

[ScriptPath("res://src/Core/Nodes/Potions/NPotion.cs")]
public class NPotion : Control
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName Reload;

		public static readonly StringName DoFlash;

		public static readonly StringName DoBounce;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName Image;

		public static readonly StringName Outline;

		public static readonly StringName _container;

		public static readonly StringName _bounceTween;

		public static readonly StringName _obtainedTween;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern TextureRect Image
	{
		[CompilerGenerated]
		get;
	}

	public extern TextureRect Outline
	{
		[CompilerGenerated]
		get;
	}

	public static extern IEnumerable<string> AssetPaths { get; }

	public extern PotionModel Model { get; set; }

	public static extern NPotion? Create(PotionModel potion);

	public override extern void _Ready();

	[AsyncStateMachine(typeof(_003CPlayNewlyAcquiredAnimation_003Ed__26))]
	public extern Task PlayNewlyAcquiredAnimation(Vector2? startLocation);

	public extern void DoBounce();

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool InvokeGodotClassMethod(in godot_string_name method, NativeVariantPtrArgs args, out godot_variant ret);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassMethod(in godot_string_name method);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool SetGodotClassPropertyValue(in godot_string_name name, in godot_variant value);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool GetGodotClassPropertyValue(in godot_string_name name, out godot_variant value);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void SaveGodotObjectData(GodotSerializationInfo info);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RestoreGodotObjectData(GodotSerializationInfo info);

	public extern NPotion();
}
