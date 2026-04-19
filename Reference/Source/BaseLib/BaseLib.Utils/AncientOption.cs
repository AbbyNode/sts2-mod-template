using System;
using System.Collections.Generic;
using MegaCrit.Sts2.Core.Models;

namespace BaseLib.Utils;

public abstract class AncientOption(int weight) : IWeighted
{
	private class BasicAncientOption(RelicModel model, int weight) : AncientOption(weight)
	{
		public override IEnumerable<RelicModel> AllVariants { get; } = new _003C_003Ez__ReadOnlySingleElementList<RelicModel>(model.ToMutable());

		public override RelicModel ModelForOption => model.ToMutable();
	}

	public int Weight { get; } = weight;

	/// <summary>
	/// For special options like Orobas SeaGlass with multiple variants.
	/// </summary>
	public abstract IEnumerable<RelicModel> AllVariants { get; }

	public abstract RelicModel ModelForOption { get; }

	public static explicit operator AncientOption(RelicModel model)
	{
		return new BasicAncientOption(model, 1);
	}
}
public class AncientOption<T>(int weight) : AncientOption(weight) where T : RelicModel
{
	private readonly T _model = ModelDb.Relic<T>();

	/// <summary>
	/// Set this if relic needs to set up data based on current run state, eg. Sea Glass choosing a random other character.
	/// </summary>
	public Func<T, RelicModel>? ModelPrep { get; init; }

	public Func<T, IEnumerable<RelicModel>>? Variants { get; init; }

	public override IEnumerable<RelicModel> AllVariants
	{
		get
		{
			if (Variants != null)
			{
				return Variants(_model);
			}
			return new _003C_003Ez__ReadOnlySingleElementList<RelicModel>(((RelicModel)_model).ToMutable());
		}
	}

	public override RelicModel ModelForOption
	{
		get
		{
			if (ModelPrep != null)
			{
				Func<T, RelicModel>? modelPrep = ModelPrep;
				RelicModel obj = ((RelicModel)_model).ToMutable();
				return modelPrep(((T)(object)((obj is T) ? obj : null)) ?? _model);
			}
			return ((RelicModel)_model).ToMutable();
		}
	}
}
