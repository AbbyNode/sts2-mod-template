using System;

namespace BaseLib.Patches.Content;

/// <summary>
/// Marks a CardKeyword field as having additional keyword properties. This is not required to create a keyword,
/// only if you want to use the additional features added by this.
/// </summary>
[AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
public sealed class KeywordPropertiesAttribute : Attribute
{
	public AutoKeywordPosition Position { get; }

	public bool RichKeyword { get; }

	/// <summary>
	/// Marks a CardKeyword field as having additional keyword properties. This is not required to create a keyword,
	/// only if you want to use the additional features added by this.
	/// </summary>
	/// <param name="position">The keyword's localized title will automatically be added to the specified position in the card's description for cards with the keyword.</param>
	public KeywordPropertiesAttribute(AutoKeywordPosition position)
		: this(position, richKeyword: true)
	{
	}

	/// <summary>
	/// Marks a CardKeyword field as having additional keyword properties. This is not required to create a keyword,
	/// only if you want to use the additional features added by this.
	/// </summary>
	/// <param name="position">The keyword's localized title will automatically be added to the specified position in the card's description for cards with the keyword.</param>
	/// <param name="richKeyword">Enables energy icons, ?, and ? in the keyword's tooltip.</param>
	public KeywordPropertiesAttribute(AutoKeywordPosition position, bool richKeyword)
	{
		Position = position;
		RichKeyword = richKeyword;
	}
}
