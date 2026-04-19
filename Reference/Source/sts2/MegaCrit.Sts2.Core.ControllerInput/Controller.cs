using Godot;

namespace MegaCrit.Sts2.Core.ControllerInput;

public static class Controller
{
	public static readonly StringName leftTrigger;

	public static readonly StringName rightTrigger;

	public static readonly StringName leftBumper;

	public static readonly StringName rightBumper;

	public static readonly StringName dPadNorth;

	public static readonly StringName dPadSouth;

	public static readonly StringName dPadEast;

	public static readonly StringName dPadWest;

	public static readonly StringName faceButtonNorth;

	public static readonly StringName faceButtonSouth;

	public static readonly StringName faceButtonEast;

	public static readonly StringName faceButtonWest;

	public static readonly StringName startButton;

	public static readonly StringName selectButton;

	public static readonly StringName joystickPress;

	public static readonly StringName joystickLeft;

	public static readonly StringName joystickRight;

	public static readonly StringName joystickUp;

	public static readonly StringName joystickDown;

	public static readonly StringName ps4Touchpad;

	public static extern StringName[] AllControllerInputs { get; }
}
