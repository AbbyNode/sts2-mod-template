using System.Collections.Generic;

namespace BaseLib.Abstracts;

/// <summary>
/// For use with ILocalizationProvider.<seealso cref="T:BaseLib.Abstracts.ILocalizationProvider" />
/// Localization for a power.
/// </summary>
public record PowerLoc(string Title, string Description, string SmartDescription, params (string, string)[] ExtraLoc)
{
	public static implicit operator List<(string, string)>(PowerLoc loc)
	{
		List<(string, string)> list = new List<(string, string)>();
		list.Add(("title", loc.Title));
		list.Add(("description", loc.Description));
		list.Add(("smartDescription", loc.SmartDescription));
		list.AddRange(loc.ExtraLoc);
		return list;
	}
}
