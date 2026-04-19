using System;
using System.Collections.Generic;
using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.UI;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Nodes.Cards;
using MegaCrit.Sts2.Core.Nodes.Cards.Holders;

namespace MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary;

[ScriptPath("res://src/Core/Nodes/Screens/CardLibrary/NCardLibraryGrid.cs")]
public class NCardLibraryGrid : NCardGrid
{
	public new class MethodName : NCardGrid.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName RefreshVisibility;

		public new static readonly StringName InitGrid;

		public new static readonly StringName UpdateGridNavigation;

		public extern MethodName();
	}

	public new class PropertyName : NCardGrid.PropertyName
	{
		public new static readonly StringName IsCardLibrary;

		public new static readonly StringName CenterGrid;

		public static readonly StringName ShowStats;

		public static readonly StringName _showStats;

		public extern PropertyName();
	}

	public new class SignalName : NCardGrid.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	protected override extern bool IsCardLibrary { get; }

	protected override extern bool CenterGrid { get; }

	public extern bool ShowStats { get; set; }

	public extern IEnumerable<CardModel> VisibleCards { get; }

	public override extern void _Ready();

	public extern void RefreshVisibility();

	public extern void FilterCards(Func<CardModel, bool> filter);

	public extern void FilterCards(Func<CardModel, bool> filter, List<SortingOrders> sortingPriority);

	protected override extern void InitGrid();

	protected override extern void AssignCardsToRow(List<NGridCardHolder> row, int startIndex);

	protected override extern ModelVisibility GetCardVisibility(CardModel card);

	protected override extern void UpdateGridNavigation();

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

	public extern NCardLibraryGrid();
}
