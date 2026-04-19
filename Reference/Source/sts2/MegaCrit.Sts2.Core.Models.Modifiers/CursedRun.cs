using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace MegaCrit.Sts2.Core.Models.Modifiers;

public class CursedRun : ModifierModel
{
	[AsyncStateMachine(typeof(_003CAfterActEntered_003Ed__0))]
	public override extern Task AfterActEntered();

	public extern CursedRun();
}
