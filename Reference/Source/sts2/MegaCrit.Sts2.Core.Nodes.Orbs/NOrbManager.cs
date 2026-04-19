using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Nodes.Combat;

namespace MegaCrit.Sts2.Core.Nodes.Orbs;

[ScriptPath("res://src/Core/Nodes/Orbs/NOrbManager.cs")]
public class NOrbManager : Control
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _EnterTree;

		public new static readonly StringName _ExitTree;

		public static readonly StringName Create;

		public static readonly StringName RemoveSlotAnim;

		public static readonly StringName AddSlotAnim;

		public static readonly StringName AddOrbAnim;

		public static readonly StringName UpdateControllerNavigation;

		public static readonly StringName TweenLayout;

		public static readonly StringName UpdateVisuals;

		public static readonly StringName ClearOrbs;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName IsLocal;

		public static readonly StringName DefaultFocusOwner;

		public static readonly StringName _orbContainer;

		public static readonly StringName _creatureNode;

		public static readonly StringName _curTween;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern IEnumerable<string> AssetPaths { get; }

	public extern bool IsLocal
	{
		[CompilerGenerated]
		get;
	}

	public extern Control DefaultFocusOwner { get; }

	public override extern void _Ready();

	public override extern void _EnterTree();

	public override extern void _ExitTree();

	public static extern NOrbManager Create(NCreature creature, bool isLocal);

	public extern void RemoveSlotAnim(int amount);

	public extern void AddSlotAnim(int amount);

	public extern void ReplaceOrb(OrbModel oldOrb, OrbModel newOrb);

	public extern void AddOrbAnim();

	public extern void EvokeOrbAnim(OrbModel orb);

	public extern void UpdateVisuals(OrbEvokeType evokeType);

	public extern void ClearOrbs();

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

	public extern NOrbManager();
}
