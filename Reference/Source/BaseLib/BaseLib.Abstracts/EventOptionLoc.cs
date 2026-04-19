using System.Collections.Generic;

namespace BaseLib.Abstracts;

/// <summary>
/// Used as a parameter of EventPageLoc
/// </summary>
/// <param name="OptionKey">Name of option; expected to be all caps version of method passed as option task</param>
/// <param name="Title">Option name</param>
/// <param name="Description">Option text</param>
public record EventOptionLoc(string OptionKey, string Title, string Description)
{
	public IEnumerable<(string, string)> Create(EventPageLoc page)
	{
		yield return ($"pages.{page.PageKey}.options.{OptionKey}.title", Title);
		yield return ($"pages.{page.PageKey}.options.{OptionKey}.description", Description);
	}
}
