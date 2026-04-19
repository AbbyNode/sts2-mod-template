using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen;

[ScriptPath("res://src/Core/Nodes/Screens/FeedbackScreen/NFeedbackScreenOpener.cs")]
public class NFeedbackScreenOpener : Node
{
	public new class MethodName : Node.MethodName
	{
		public new static readonly StringName _EnterTree;

		public new static readonly StringName _ExitTree;

		public new static readonly StringName _Input;

		public extern MethodName();
	}

	public new class PropertyName : Node.PropertyName
	{
		public extern PropertyName();
	}

	public new class SignalName : Node.SignalName
	{
		public extern SignalName();
	}

	public static extern NFeedbackScreenOpener Instance
	{
		[CompilerGenerated]
		get;
	}

	public override extern void _EnterTree();

	public override extern void _ExitTree();

	public override extern void _Input(InputEvent inputEvent);

	[AsyncStateMachine(typeof(_003COpenFeedbackScreen_003Ed__7))]
	public extern Task OpenFeedbackScreen();

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool InvokeGodotClassMethod(in godot_string_name method, NativeVariantPtrArgs args, out godot_variant ret);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassMethod(in godot_string_name method);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void SaveGodotObjectData(GodotSerializationInfo info);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RestoreGodotObjectData(GodotSerializationInfo info);

	public extern NFeedbackScreenOpener();
}
