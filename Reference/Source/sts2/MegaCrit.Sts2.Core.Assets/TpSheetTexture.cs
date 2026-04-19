using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MegaCrit.Sts2.Core.Assets;

public class TpSheetTexture
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern string Image
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern TpSheetSize Size
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern List<TpSheetSprite> Sprites
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern TpSheetTexture();
}
