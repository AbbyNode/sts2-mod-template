using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Commands.Builders;
using MegaCrit.Sts2.Core.Entities.Relics;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class BoneFlute : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	public override extern Task AfterAttack(AttackCommand command);

	public extern BoneFlute();
}
