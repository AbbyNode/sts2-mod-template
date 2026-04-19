using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Powers;

namespace MegaCrit.Sts2.Core.Models.Powers;

public class ParryPower : PowerModel
{
	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	[AsyncStateMachine(typeof(_003CAfterSovereignBladePlayed_003Ed__4))]
	public extern Task AfterSovereignBladePlayed(Creature? dealer, IEnumerable<DamageResult> damageResults);

	public extern ParryPower();
}
