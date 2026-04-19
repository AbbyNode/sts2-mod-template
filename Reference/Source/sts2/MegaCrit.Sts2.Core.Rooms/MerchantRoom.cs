using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Merchant;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Rooms;

public class MerchantRoom : AbstractRoom
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern RoomType RoomType { get; }

	public extern MerchantInventory Inventory
	{
		[CompilerGenerated]
		get;
	}

	public override extern ModelId? ModelId { get; }

	public static extern MerchantDialogueSet Dialogue { get; }

	[AsyncStateMachine(typeof(_003CEnter_003Ed__11))]
	public override extern Task Enter(IRunState? runState, bool isRestoringRoomStackBase);

	public override extern Task Exit(IRunState? runState);

	public override extern Task Resume(AbstractRoom _, IRunState? runState);

	public extern MerchantRoom();
}
