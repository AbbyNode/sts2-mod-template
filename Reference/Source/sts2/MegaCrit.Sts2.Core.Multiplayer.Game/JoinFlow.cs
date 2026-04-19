using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Godot;
using MegaCrit.Sts2.Core.Multiplayer.Connection;

namespace MegaCrit.Sts2.Core.Multiplayer.Game;

public class JoinFlow
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern NetClientGameService? NetService
	{
		[CompilerGenerated]
		get;
	}

	public extern CancellationTokenSource CancelToken
	{
		[CompilerGenerated]
		get;
	}

	[AsyncStateMachine(typeof(_003CBegin_003Ed__13))]
	public extern Task<JoinResult> Begin(IClientConnectionInitializer initializer, SceneTree sceneTree);

	public extern JoinFlow();
}
