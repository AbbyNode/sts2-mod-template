using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Commands;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.HoverTips;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Models;

namespace BaseLib.Abstracts;

/// <summary>
/// An ease of use wrapper for CustomTemporaryPowerModel to simplify the process
/// </summary>
/// <typeparam name="TModel">The source of the power</typeparam>
/// <typeparam name="TPower">The power that will be applied to the target</typeparam>
public abstract class CustomTemporaryPowerModelWrapper<TModel, TPower> : CustomTemporaryPowerModel where TModel : AbstractModel where TPower : PowerModel
{
	public override string CustomBigBetaIconPath
	{
		get
		{
			if (((PowerModel)this).Amount < 0)
			{
				return "BaseLib/images/powers/big/baselib-power_temp_down.png";
			}
			return "BaseLib/images/powers/big/baselib-power_temp_up.png";
		}
	}

	/// <summary>
	/// Placeholder small icon; you are recommended to override this.
	/// </summary>
	public override string CustomPackedIconPath
	{
		get
		{
			if (((PowerModel)this).Amount < 0)
			{
				return "BaseLib/images/powers/baselib-power_temp_down.png";
			}
			return "BaseLib/images/powers/baselib-power_temp_up.png";
		}
	}

	/// <summary>
	/// Placeholder large icon; you are recommended to override this.
	/// </summary>
	public override string CustomBigIconPath
	{
		get
		{
			if (((PowerModel)this).Amount < 0)
			{
				return "BaseLib/images/powers/big/baselib-power_temp_down_big.png";
			}
			return "BaseLib/images/powers/big/baselib-power_temp_up_big.png";
		}
	}

	public override AbstractModel OriginModel => ModelDb.GetById<AbstractModel>(ModelDb.GetId<TModel>());

	public override PowerModel InternallyAppliedPower => (PowerModel)(object)ModelDb.Power<TPower>();

	protected override Func<Creature, decimal, Creature?, CardModel?, bool, Task> ApplyPowerFunc => PowerCmd.Apply<TPower>;

	public override LocString Title
	{
		get
		{
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Expected O, but got Unknown
			AbstractModel originModel = OriginModel;
			CardModel val = (CardModel)(object)((originModel is CardModel) ? originModel : null);
			if (val == null)
			{
				PotionModel val2 = (PotionModel)(object)((originModel is PotionModel) ? originModel : null);
				if (val2 == null)
				{
					RelicModel val3 = (RelicModel)(object)((originModel is RelicModel) ? originModel : null);
					if (val3 == null)
					{
						PowerModel val4 = (PowerModel)(object)((originModel is PowerModel) ? originModel : null);
						if (val4 == null)
						{
							OrbModel val5 = (OrbModel)(object)((originModel is OrbModel) ? originModel : null);
							if (val5 == null)
							{
								CharacterModel val6 = (CharacterModel)(object)((originModel is CharacterModel) ? originModel : null);
								if (val6 == null)
								{
									MonsterModel val7 = (MonsterModel)(object)((originModel is MonsterModel) ? originModel : null);
									if (val7 != null)
									{
										return val7.Title;
									}
									BaseLibMain.Logger.Warn("Getting the 'Title' for the base model type of '" + ((object)OriginModel).GetType().Name + "' has not been implemented yet. Using default title.", 1);
									return new LocString("powers", "BASELIB-CUSTOM_TEMPORARY_POWER_MODEL.title");
								}
								return val6.Title;
							}
							return val5.Title;
						}
						return val4.Title;
					}
					return val3.Title;
				}
				return val2.Title;
			}
			return val.TitleLocString;
		}
	}

	protected override IEnumerable<IHoverTip> ExtraHoverTips
	{
		get
		{
			AbstractModel originModel = OriginModel;
			CardModel val = (CardModel)(object)((originModel is CardModel) ? originModel : null);
			List<IHoverTip> list2;
			if (val == null)
			{
				PotionModel val2 = (PotionModel)(object)((originModel is PotionModel) ? originModel : null);
				if (val2 == null)
				{
					RelicModel val3 = (RelicModel)(object)((originModel is RelicModel) ? originModel : null);
					if (val3 == null)
					{
						PowerModel val4 = (PowerModel)(object)((originModel is PowerModel) ? originModel : null);
						if (val4 != null)
						{
							int num = 1;
							List<IHoverTip> list = new List<IHoverTip>(num);
							CollectionsMarshal.SetCount(list, num);
							Span<IHoverTip> span = CollectionsMarshal.AsSpan(list);
							int index = 0;
							span[index] = HoverTipFactory.FromPower(val4);
							list2 = list;
						}
						else
						{
							BaseLibMain.Logger.Warn("Getting the Hover Tips for the base model type of '" + ((object)OriginModel).GetType().Name + "' has not been implemented yet.", 1);
							list2 = new List<IHoverTip>();
						}
					}
					else
					{
						list2 = HoverTipFactory.FromRelic(val3).ToList();
					}
				}
				else
				{
					int index = 1;
					List<IHoverTip> list3 = new List<IHoverTip>(index);
					CollectionsMarshal.SetCount(list3, index);
					Span<IHoverTip> span2 = CollectionsMarshal.AsSpan(list3);
					int num = 0;
					span2[num] = HoverTipFactory.FromPotion(val2);
					list2 = list3;
				}
			}
			else
			{
				int num = 1;
				List<IHoverTip> list4 = new List<IHoverTip>(num);
				CollectionsMarshal.SetCount(list4, num);
				Span<IHoverTip> span3 = CollectionsMarshal.AsSpan(list4);
				int index = 0;
				span3[index] = HoverTipFactory.FromCard(val, false);
				list2 = list4;
			}
			list2.Add(HoverTipFactory.FromPower(InternallyAppliedPower));
			return list2;
		}
	}

	public override LocString Description => new LocString("powers", (((PowerModel)this).Amount > 0) ? "BASELIB-CUSTOM_TEMPORARY_POWER_MODEL.UP.description" : "BASELIB-CUSTOM_TEMPORARY_POWER_MODEL.DOWN.description");

	protected override string SmartDescriptionLocKey
	{
		get
		{
			if (((PowerModel)this).Amount <= 0)
			{
				return "BASELIB-CUSTOM_TEMPORARY_POWER_MODEL.DOWN.smartDescription";
			}
			return "BASELIB-CUSTOM_TEMPORARY_POWER_MODEL.UP.smartDescription";
		}
	}
}
