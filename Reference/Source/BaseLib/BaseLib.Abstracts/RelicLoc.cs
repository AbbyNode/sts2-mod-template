using System.Collections.Generic;

namespace BaseLib.Abstracts;

/// <summary>
/// For use with ILocalizationProvider.<seealso cref="T:BaseLib.Abstracts.ILocalizationProvider" />
/// Localization for a relic.
/// </summary>
public record RelicLoc(string Title, string Description, string Flavor, params (string, string)[] ExtraLoc)
{
	public static implicit operator List<(string, string)>(RelicLoc loc)
	{
		List<(string, string)> list = new List<(string, string)>();
		list.Add(("title", loc.Title));
		list.Add(("description", loc.Description));
		list.Add(("flavor", loc.Flavor));
		list.AddRange(loc.ExtraLoc);
		return list;
	}
}
