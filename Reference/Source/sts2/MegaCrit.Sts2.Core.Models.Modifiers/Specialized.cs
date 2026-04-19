using System;
using System.Threading.Tasks;

namespace MegaCrit.Sts2.Core.Models.Modifiers;

public class Specialized : ModifierModel
{
	public override extern Func<Task> GenerateNeowOption(EventModel eventModel);

	public extern Specialized();
}
