using System.Collections.Generic;

namespace BaseLib.Abstracts;

/// <summary>
/// <para>A model that implements this interface can define localization that will be added to its relevant localization table.
/// Recommended implementation is to return one of the provided Loc classes such as CardLoc.
/// To support translation, a switch statement like this is recommended:</para>
/// =&gt; LocManager.Instance.Language switch
/// { "aaa" =&gt; new CardLoc("translated"), _ =&gt; new CardLoc("default") };
/// <seealso cref="!:BaseLib.Patches.Utils.ModelLocPatch" />
/// </summary>
public interface ILocalizationProvider
{
	string? LocTable => null;

	List<(string, string)>? Localization { get; }
}
