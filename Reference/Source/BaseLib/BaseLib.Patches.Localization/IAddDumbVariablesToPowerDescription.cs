using MegaCrit.Sts2.Core.Localization;

namespace BaseLib.Patches.Localization;

/// <summary>
/// Adds some extra dumb variables to the Power description
/// </summary>
public interface IAddDumbVariablesToPowerDescription
{
	/// <inheritdoc cref="T:BaseLib.Patches.Localization.IAddDumbVariablesToPowerDescription" />
	/// <param name="description">The original description</param>
	void AddDumbVariablesToPowerDescription(LocString description);
}
