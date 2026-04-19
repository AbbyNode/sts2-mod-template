using System;
using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Models;
using SmartFormat.Core.Extensions;

namespace MegaCrit.Sts2.Core.Localization.DynamicVars;

public class DynamicVar : IConvertible
{
	protected AbstractModel? _owner;

	public extern string Name
	{
		[CompilerGenerated]
		get;
	}

	public extern decimal BaseValue { get; set; }

	public extern decimal EnchantedValue
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		protected set;
	}

	public extern decimal PreviewValue
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern bool WasJustUpgraded
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		protected set;
	}

	public extern int IntValue { get; }

	public extern DynamicVar(string name, decimal baseValue);

	public extern void ResetToBase();

	public virtual extern void SetOwner(AbstractModel owner);

	public virtual extern void UpdateCardPreview(CardModel card, CardPreviewMode previewMode, Creature? target, bool runGlobalHooks);

	public extern void UpgradeValueBy(decimal addend);

	public extern void FinalizeUpgrade();

	public extern DynamicVar Clone();

	public extern string ToHighlightedString(bool inverse);

	public override extern string ToString();

	public extern object GetSourceValue(ISelectorInfo selector);

	public extern TypeCode GetTypeCode();

	public extern bool ToBoolean(IFormatProvider? provider);

	public extern byte ToByte(IFormatProvider? provider);

	public extern char ToChar(IFormatProvider? provider);

	public extern DateTime ToDateTime(IFormatProvider? provider);

	public extern decimal ToDecimal(IFormatProvider? provider);

	public extern double ToDouble(IFormatProvider? provider);

	public extern short ToInt16(IFormatProvider? provider);

	public extern int ToInt32(IFormatProvider? provider);

	public extern long ToInt64(IFormatProvider? provider);

	public extern sbyte ToSByte(IFormatProvider? provider);

	public extern float ToSingle(IFormatProvider? provider);

	public extern string ToString(IFormatProvider? provider);

	public extern object ToType(Type conversionType, IFormatProvider? provider);

	public extern ushort ToUInt16(IFormatProvider? provider);

	public extern uint ToUInt32(IFormatProvider? provider);

	public extern ulong ToUInt64(IFormatProvider? provider);

	protected virtual extern decimal GetBaseValueForIConvertible();
}
