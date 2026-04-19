using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Models.Powers;

namespace MegaCrit.Sts2.Core.Localization.DynamicVars;

public class DynamicVarSet : IReadOnlyDictionary<string, DynamicVar>, IEnumerable<KeyValuePair<string, DynamicVar>>, IEnumerable, IReadOnlyCollection<KeyValuePair<string, DynamicVar>>
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern int Count { get; }

	public extern DynamicVar this[string key] { get; }

	public extern IEnumerable<string> Keys { get; }

	public extern IEnumerable<DynamicVar> Values { get; }

	public extern BlockVar Block { get; }

	public extern CalculatedBlockVar CalculatedBlock { get; }

	public extern CalculatedDamageVar CalculatedDamage { get; }

	public extern CalculationBaseVar CalculationBase { get; }

	public extern CalculationExtraVar CalculationExtra { get; }

	public extern CardsVar Cards { get; }

	public extern DamageVar Damage { get; }

	public extern PowerVar<DexterityPower> Dexterity { get; }

	public extern PowerVar<DoomPower> Doom { get; }

	public extern EnergyVar Energy { get; }

	public extern ExtraDamageVar ExtraDamage { get; }

	public extern ForgeVar Forge { get; }

	public extern GoldVar Gold { get; }

	public extern HealVar Heal { get; }

	public extern HpLossVar HpLoss { get; }

	public extern MaxHpVar MaxHp { get; }

	public extern OstyDamageVar OstyDamage { get; }

	public extern PowerVar<PoisonPower> Poison { get; }

	public extern RepeatVar Repeat { get; }

	public extern StarsVar Stars { get; }

	public extern PowerVar<StrengthPower> Strength { get; }

	public extern SummonVar Summon { get; }

	public extern PowerVar<VulnerablePower> Vulnerable { get; }

	public extern PowerVar<WeakPower> Weak { get; }

	public extern IEnumerator<KeyValuePair<string, DynamicVar>> GetEnumerator();

	extern IEnumerator IEnumerable.GetEnumerator();

	public extern bool ContainsKey(string key);

	public extern bool TryGetValue(string key, [MaybeNullWhen(false)] out DynamicVar value);

	public extern DynamicVarSet(IEnumerable<DynamicVar> vars);

	public extern void InitializeWithOwner(AbstractModel model);

	public extern void AddTo(LocString str);

	public extern void ClearPreview();

	public extern void FinalizeUpgrade();

	public extern void RecalculateForUpgradeOrEnchant();

	public extern DynamicVarSet Clone(AbstractModel model);
}
