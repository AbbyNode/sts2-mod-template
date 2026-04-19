using System;
using System.Threading.Tasks;

namespace MegaCrit.Sts2.Core.Models.Modifiers;

public class Draft : ModifierModel
{
	public override extern bool ClearsPlayerDeck { get; }

	public override extern Func<Task> GenerateNeowOption(EventModel eventModel);

	public extern Draft();
}
