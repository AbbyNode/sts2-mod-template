using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Nodes.Pooling;
using MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary;

namespace MegaCrit.Sts2.Core.Nodes.Cards.Holders;

[ScriptPath("res://src/Core/Nodes/Cards/Holders/NGridCardHolder.cs")]
public class NGridCardHolder : NCardHolder, IPoolable
{
	public new class MethodName : NCardHolder.MethodName
	{
		public static readonly StringName InitPool;

		public static readonly StringName Create;

		public static readonly StringName UpdateCardModel;

		public static readonly StringName OnInstantiated;

		public new static readonly StringName _Ready;

		public static readonly StringName EnsureCardLibraryStatsExists;

		public new static readonly StringName OnCardReassigned;

		public new static readonly StringName SetCard;

		public static readonly StringName UpdateName;

		public new static readonly StringName OnFocus;

		public static readonly StringName SetIsPreviewingUpgrade;

		public new static readonly StringName _ExitTree;

		public static readonly StringName OnReturnedFromPool;

		public static readonly StringName OnFreedToPool;

		public extern MethodName();
	}

	public new class PropertyName : NCardHolder.PropertyName
	{
		public static readonly StringName CardLibraryStats;

		public new static readonly StringName IsShowingUpgradedCard;

		public static readonly StringName _isPreviewingUpgrade;

		public extern PropertyName();
	}

	public new class SignalName : NCardHolder.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern IEnumerable<string> AssetPaths { get; }

	public extern NCardLibraryStats? CardLibraryStats
	{
		[CompilerGenerated]
		get;
	}

	public override extern CardModel CardModel { get; }

	public override extern bool IsShowingUpgradedCard { get; }

	public static extern void InitPool();

	public static extern NGridCardHolder? Create(NCard cardNode);

	public extern void OnInstantiated();

	public override extern void _Ready();

	public extern void EnsureCardLibraryStatsExists();

	protected override extern void OnCardReassigned();

	protected override extern void SetCard(NCard node);

	protected override extern void OnFocus();

	public extern void SetIsPreviewingUpgrade(bool showUpgradePreview);

	public override extern void _ExitTree();

	public extern void OnReturnedFromPool();

	public extern void OnFreedToPool();

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

	public extern NGridCardHolder();
}
