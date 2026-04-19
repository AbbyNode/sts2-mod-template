using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Nodes.Screens.MainMenu;

[ScriptPath("res://src/Core/Nodes/Screens/MainMenu/NMultiplayerHostSubmenu.cs")]
public class NMultiplayerHostSubmenu : NSubmenu
{
	public new class MethodName : NSubmenu.MethodName
	{
		public static readonly StringName Create;

		public new static readonly StringName _Ready;

		public static readonly StringName RefreshButtons;

		public new static readonly StringName OnSubmenuOpened;

		public static readonly StringName OnStandardPressed;

		public static readonly StringName OnDailyPressed;

		public static readonly StringName OnCustomPressed;

		public static readonly StringName StartHost;

		public extern MethodName();
	}

	public new class PropertyName : NSubmenu.PropertyName
	{
		public new static readonly StringName InitialFocusedControl;

		public static readonly StringName _standardButton;

		public static readonly StringName _dailyButton;

		public static readonly StringName _customButton;

		public static readonly StringName _loadingOverlay;

		public extern PropertyName();
	}

	public new class SignalName : NSubmenu.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	protected override extern Control InitialFocusedControl { get; }

	public static extern NMultiplayerHostSubmenu? Create();

	public override extern void _Ready();

	public override extern void OnSubmenuOpened();

	public extern void StartHost(GameMode gameMode);

	[AsyncStateMachine(typeof(_003CStartHostAsync_003Ed__18))]
	public static extern Task StartHostAsync(GameMode gameMode, Control loadingOverlay, NSubmenuStack stack);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool InvokeGodotClassMethod(in godot_string_name method, NativeVariantPtrArgs args, out godot_variant ret);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassMethod(in godot_string_name method);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool SetGodotClassPropertyValue(in godot_string_name name, in godot_variant value);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool GetGodotClassPropertyValue(in godot_string_name name, out godot_variant value);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void SaveGodotObjectData(GodotSerializationInfo info);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RestoreGodotObjectData(GodotSerializationInfo info);

	public extern NMultiplayerHostSubmenu();
}
