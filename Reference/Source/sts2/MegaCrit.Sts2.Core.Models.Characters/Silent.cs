using System.Collections.Generic;
using Godot;
using MegaCrit.Sts2.Core.Animation;
using MegaCrit.Sts2.Core.Bindings.MegaSpine;
using MegaCrit.Sts2.Core.Entities.Characters;

namespace MegaCrit.Sts2.Core.Models.Characters;

public sealed class Silent : CharacterModel
{
	public const string shivTrigger = "Shiv";

	public const string energyColorName = "silent";

	public override extern Color NameColor { get; }

	public override extern CharacterGender Gender { get; }

	public override extern int StartingHp { get; }

	public override extern int StartingGold { get; }

	public override extern CardPoolModel CardPool { get; }

	public override extern RelicPoolModel RelicPool { get; }

	public override extern PotionPoolModel PotionPool { get; }

	public override extern IEnumerable<CardModel> StartingDeck { get; }

	public override extern IReadOnlyList<RelicModel> StartingRelics { get; }

	public override extern float AttackAnimDelay { get; }

	public override extern float CastAnimDelay { get; }

	public override extern Color EnergyLabelOutlineColor { get; }

	public override extern Color DialogueColor { get; }

	public override extern Color MapDrawingColor { get; }

	public override extern Color RemoteTargetingLineColor { get; }

	public override extern Color RemoteTargetingLineOutline { get; }

	public override extern List<string> GetArchitectAttackVfx();

	public override extern CreatureAnimator GenerateAnimator(MegaSprite controller);

	public extern Silent();
}
