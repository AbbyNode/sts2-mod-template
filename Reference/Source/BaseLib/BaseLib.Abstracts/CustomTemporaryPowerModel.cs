using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BaseLib.Patches.Localization;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Commands;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Powers;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Localization.DynamicVars;
using MegaCrit.Sts2.Core.Models;

namespace BaseLib.Abstracts;

/// <summary>
/// A generic version of the base games Temporary Strength and Dexterity Power with small functionality improvements
/// </summary>
public abstract class CustomTemporaryPowerModel : CustomPowerModel, ITemporaryPower, IAddDumbVariablesToPowerDescription
{
	private const string LocTurnEndBoolVar = "UntilEndOfOtherSideTurn";

	private bool _shouldIgnoreNextInstance;

	protected abstract Func<Creature, decimal, Creature?, CardModel?, bool, Task> ApplyPowerFunc { get; }

	public abstract PowerModel InternallyAppliedPower { get; }

	public abstract AbstractModel OriginModel { get; }

	protected virtual bool UntilEndOfOtherSideTurn => false;

	protected virtual int LastForXExtraTurns => 0;

	public override PowerType Type => InternallyAppliedPower.Type;

	public override PowerStackType StackType => (PowerStackType)1;

	public override bool AllowNegative => true;

	public override bool IsInstanced => LastForXExtraTurns != 0;

	protected override IEnumerable<DynamicVar> CanonicalVars => new _003C_003Ez__ReadOnlyArray<DynamicVar>((DynamicVar[])(object)new DynamicVar[2]
	{
		(DynamicVar)new RepeatVar(0),
		(DynamicVar)new BoolVar("UntilEndOfOtherSideTurn", false)
	});

	public void AddDumbVariablesToPowerDescription(LocString description)
	{
		description.Add("TemporaryPowerTitle", InternallyAppliedPower.Title);
	}

	public void IgnoreNextInstance()
	{
		_shouldIgnoreNextInstance = true;
	}

	public override async Task BeforeApplied(Creature target, decimal amount, Creature? applier, CardModel? cardSource)
	{
		if (InternallyAppliedPower is CustomTemporaryPowerModel)
		{
			BaseLibMain.Logger.Warn($"Don't put TemporaryPowerModels into a TemporaryPowerModel. Attempted to apply power '{((object)InternallyAppliedPower).GetType().Name}' in power '{((object)this).GetType().Name}'. Power will not be applied!", 1);
		}
		else if (_shouldIgnoreNextInstance)
		{
			_shouldIgnoreNextInstance = false;
		}
		else
		{
			((DynamicVar)((PowerModel)this).DynamicVars.Repeat).BaseValue = LastForXExtraTurns;
			((PowerModel)this).DynamicVars["UntilEndOfOtherSideTurn"].BaseValue = Convert.ToDecimal(UntilEndOfOtherSideTurn);
			await ApplyPowerFunc(target, amount, applier, cardSource, arg5: true);
		}
	}

	public override async Task AfterPowerAmountChanged(PowerModel power, decimal amount, Creature? applier, CardModel? cardSource)
	{
		CustomTemporaryPowerModel customTemporaryPowerModel = this;
		if (!(InternallyAppliedPower is CustomTemporaryPowerModel) && !(amount == (decimal)((PowerModel)customTemporaryPowerModel).Amount) && (object)power == customTemporaryPowerModel)
		{
			if (customTemporaryPowerModel._shouldIgnoreNextInstance)
			{
				customTemporaryPowerModel._shouldIgnoreNextInstance = false;
			}
			else
			{
				await ApplyPowerFunc(((PowerModel)customTemporaryPowerModel).Owner, amount, applier, cardSource, arg5: true);
			}
		}
	}

	public override async Task AfterTurnEnd(PlayerChoiceContext choiceContext, CombatSide side)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		CustomTemporaryPowerModel powerSource = this;
		if (InternallyAppliedPower is CustomTemporaryPowerModel)
		{
			await PowerCmd.Remove((PowerModel)(object)powerSource);
		}
		else if ((UntilEndOfOtherSideTurn || side == ((PowerModel)powerSource).Owner.Side) && (!UntilEndOfOtherSideTurn || side != ((PowerModel)powerSource).Owner.Side))
		{
			if (((DynamicVar)((PowerModel)powerSource).DynamicVars.Repeat).BaseValue > 0m)
			{
				((DynamicVar)((PowerModel)powerSource).DynamicVars.Repeat).UpgradeValueBy(-1m);
				return;
			}
			((PowerModel)powerSource).Flash();
			await ApplyPowerFunc(((PowerModel)powerSource).Owner, -((PowerModel)powerSource).Amount, ((PowerModel)powerSource).Owner, null, arg5: true);
			await PowerCmd.Remove((PowerModel)(object)powerSource);
		}
	}
}
