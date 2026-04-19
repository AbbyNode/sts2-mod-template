using System;

namespace MegaCrit.Sts2.Core.Assets;

public class AssetLoadException : Exception
{
	public extern AssetLoadException(string message);

	public extern AssetLoadException(string message, Exception innerException);
}
