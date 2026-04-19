using System;
using Godot;

namespace BaseLib.Utils;

/// <summary>
/// Utility class for handling playing animations using Godot's built-in nodes.
/// </summary>
public static class CustomAnimation
{
	private static readonly SpireField<Node, Func<string[], bool>> _animHandler = new SpireField<Node, Func<string[], bool>>(() => (Func<string[], bool>?)null);

	/// <summary>
	/// Returns true if any custom animation source exists.
	/// </summary>
	/// <param name="n"></param>
	/// <param name="tryAnimNames"></param>
	/// <returns></returns>
	public static bool PlayCustomAnimation(Node n, params string[] tryAnimNames)
	{
		if (_animHandler[n] == null)
		{
			SpireField<Node, Func<string[], bool>> animHandler = _animHandler;
			AnimationPlayer? obj = FindNode<AnimationPlayer>(n, (string?)null);
			object obj2 = ((obj != null) ? obj.UseAnimationPlayer() : null);
			if (obj2 == null)
			{
				AnimatedSprite2D? obj3 = FindNode<AnimatedSprite2D>(n, (string?)null);
				obj2 = ((obj3 != null) ? obj3.UseAnimatedSprite2D() : null);
				if (obj2 == null)
				{
					AnimationPlayer? obj4 = SearchRecursive<AnimationPlayer>(n);
					obj2 = ((obj4 != null) ? obj4.UseAnimationPlayer() : null);
					if (obj2 == null)
					{
						AnimatedSprite2D? obj5 = SearchRecursive<AnimatedSprite2D>(n);
						obj2 = ((obj5 != null) ? obj5.UseAnimatedSprite2D() : null);
					}
				}
			}
			animHandler[n] = (Func<string[], bool>?)obj2;
		}
		Func<string[], bool>? func = _animHandler[n];
		if (func == null)
		{
			return false;
		}
		func(tryAnimNames);
		return true;
	}

	private static Func<string[], bool> UseAnimatedSprite2D(this AnimatedSprite2D animSprite)
	{
		return delegate(string[] animNames)
		{
			foreach (string text in animNames)
			{
				if (animSprite.SpriteFrames.HasAnimation(StringName.op_Implicit(text)))
				{
					animSprite.Play(StringName.op_Implicit(text), 1f, false);
					return true;
				}
			}
			return false;
		};
	}

	private static Func<string[], bool> UseAnimationPlayer(this AnimationPlayer animPlayer)
	{
		return delegate(string[] animNames)
		{
			foreach (string text in animNames)
			{
				if (((AnimationMixer)animPlayer).HasAnimation(StringName.op_Implicit(text)))
				{
					if (animPlayer.CurrentAnimation.Equals(text))
					{
						animPlayer.Stop(false);
					}
					animPlayer.Play(StringName.op_Implicit(text), -1.0, 1f, false);
					return true;
				}
			}
			return false;
		};
	}

	private static T? FindNode<T>(Node root, string? name = null) where T : Node
	{
		if (name == null)
		{
			name = "T";
		}
		Node obj = root.GetNodeOrNull(NodePath.op_Implicit(name)) ?? root.GetNodeOrNull(NodePath.op_Implicit("Visuals/" + name)) ?? root.GetNodeOrNull(NodePath.op_Implicit("Body/" + name));
		return (T)(object)((obj is T) ? obj : null);
	}

	private static T? SearchRecursive<T>(Node parent) where T : Node
	{
		foreach (Node child in parent.GetChildren(false))
		{
			T val = (T)(object)((child is T) ? child : null);
			if (val != null)
			{
				return val;
			}
			T val2 = SearchRecursive<T>(child);
			if (val2 != null)
			{
				return val2;
			}
		}
		return default(T);
	}
}
