using System.Collections.Generic;
using Godot;

namespace MegaCrit.Sts2.Core.Bindings.MegaSpine;

public class MegaSprite : MegaSpineBinding
{
	public const string spineClassName = "SpineSprite";

	protected override extern string SpineClassName { get; }

	protected override extern IEnumerable<string> SpineMethods { get; }

	protected override extern IEnumerable<string> SpineSignals { get; }

	public extern MegaSprite(Variant native);

	public extern Error ConnectAnimationStarted(Callable callable);

	public extern Error ConnectAnimationInterrupted(Callable callable);

	public extern Error ConnectAnimationEnded(Callable callable);

	public extern Error ConnectAnimationCompleted(Callable callable);

	public extern Error ConnectAnimationDisposed(Callable callable);

	public extern Error ConnectAnimationEvent(Callable callable);

	public extern Error ConnectBeforeAnimationStateUpdate(Callable callable);

	public extern Error ConnectBeforeAnimationStateApply(Callable callable);

	public extern Error ConnectBeforeWorldTransformsChange(Callable callable);

	public extern Error ConnectWorldTransformsChanged(Callable callable);

	public extern void DisconnectAnimationStarted(Callable callable);

	public extern void DisconnectAnimationInterrupted(Callable callable);

	public extern void DisconnectAnimationEnded(Callable callable);

	public extern void DisconnectAnimationCompleted(Callable callable);

	public extern void DisconnectAnimationDisposed(Callable callable);

	public extern void DisconnectAnimationEvent(Callable callable);

	public extern void DisconnectBeforeAnimationStateUpdate(Callable callable);

	public extern void DisconnectBeforeAnimationStateApply(Callable callable);

	public extern void DisconnectBeforeWorldTransformsChange(Callable callable);

	public extern void DisconnectWorldTransformsChanged(Callable callable);

	public extern bool HasAnimation(string animId);

	public extern MegaAnimationState GetAnimationState();

	public extern MegaSkeleton GetSkeleton();

	public extern Material? GetAdditiveMaterial();

	public extern Material? GetNormalMaterial();

	public extern MegaSkin NewSkin(string name);

	public extern void SetNormalMaterial(Material material);

	public extern void SetSkeletonDataRes(MegaSkeletonDataResource skeletonData);
}
