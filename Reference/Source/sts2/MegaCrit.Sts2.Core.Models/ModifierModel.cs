using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Godot;
using MegaCrit.Sts2.Core.HoverTips;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Models;

public abstract class ModifierModel : AbstractModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern bool ShouldReceiveCombatHooks { get; }

	public virtual extern bool ClearsPlayerDeck { get; }

	public virtual extern IEnumerable<IHoverTip> HoverTips { get; }

	public virtual extern LocString Title { get; }

	public virtual extern LocString Description { get; }

	public virtual extern LocString NeowOptionTitle { get; }

	public virtual extern LocString NeowOptionDescription { get; }

	protected extern LocString? AdditionalRestSiteHealText { get; }

	public extern Texture2D Icon { get; }

	protected virtual extern string IconPath { get; }

	protected extern RunState RunState { get; }

	public extern void OnRunCreated(RunState runState);

	public extern void OnRunLoaded(RunState runState);

	public virtual extern Func<Task>? GenerateNeowOption(EventModel eventModel);

	protected virtual extern void AfterRunCreated(RunState runState);

	protected virtual extern void AfterRunLoaded(RunState runState);

	public virtual extern bool IsEquivalent(ModifierModel other);

	public extern ModifierModel ToMutable();

	public extern SerializableModifier ToSerializable();

	public static extern ModifierModel FromSerializable(SerializableModifier serializable);

	protected extern ModifierModel();
}
