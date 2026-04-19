using System;
using Godot;

namespace BaseLib.Abstracts;

public readonly struct CustomEnergyCounter(Func<int, string> pathFunc, Color outlineColor, Color burstColor)
{
	public readonly Color OutlineColor = outlineColor;

	public readonly Color BurstColor = burstColor;

	public string LayerImagePath(int layer)
	{
		return pathFunc(layer);
	}
}
