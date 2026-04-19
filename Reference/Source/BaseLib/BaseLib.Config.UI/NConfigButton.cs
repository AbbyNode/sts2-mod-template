using System;
using System.Collections.Generic;
using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Assets;
using MegaCrit.Sts2.Core.Helpers;
using MegaCrit.Sts2.Core.Nodes.Combat;
using MegaCrit.Sts2.Core.Nodes.GodotExtensions;
using MegaCrit.Sts2.Core.Nodes.Screens.Settings;

namespace BaseLib.Config.UI;

[ScriptPath("res://Config/UI/NConfigButton.cs")]
public class NConfigButton : NSettingsButton
{
	/// <summary>
	/// Cached StringNames for the methods contained in this class, for fast lookup.
	/// </summary>
	public class MethodName : MethodName
	{
		/// <summary>
		/// Cached name for the 'SetColor' method.
		/// </summary>
		public static readonly StringName SetColor = StringName.op_Implicit("SetColor");

		/// <summary>
		/// Cached name for the '_Ready' method.
		/// </summary>
		public static readonly StringName _Ready = StringName.op_Implicit("_Ready");

		/// <summary>
		/// Cached name for the 'OnReleased' method.
		/// </summary>
		public static readonly StringName OnReleased = StringName.op_Implicit("OnReleased");

		/// <summary>
		/// Cached name for the '_ExitTree' method.
		/// </summary>
		public static readonly StringName _ExitTree = StringName.op_Implicit("_ExitTree");
	}

	/// <summary>
	/// Cached StringNames for the properties and fields contained in this class, for fast lookup.
	/// </summary>
	public class PropertyName : PropertyName
	{
		/// <summary>
		/// Cached name for the '_image' field.
		/// </summary>
		public static readonly StringName _image = StringName.op_Implicit("_image");
	}

	/// <summary>
	/// Cached StringNames for the signals contained in this class, for fast lookup.
	/// </summary>
	public class SignalName : SignalName
	{
	}

	private Action? _onPressedAction;

	private TextureRect _image;

	public static readonly string DefaultColor = "#3b7a83";

	public NConfigButton()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_013a: Expected O, but got Unknown
		((Control)this).CustomMinimumSize = new Vector2(324f, 64f);
		((Control)this).SizeFlagsHorizontal = (SizeFlags)8;
		((Control)this).SizeFlagsVertical = (SizeFlags)1;
		((Control)this).FocusMode = (FocusModeEnum)2;
		_image = new TextureRect
		{
			Name = StringName.op_Implicit("Image"),
			CustomMinimumSize = new Vector2(64f, 64f),
			Texture = PreloadManager.Cache.GetAsset<Texture2D>("res://BaseLib/images/configbutton.png"),
			ExpandMode = (ExpandModeEnum)1,
			StretchMode = (StretchModeEnum)0
		};
		((Control)_image).SetAnchorsPreset((LayoutPreset)15, false);
		((Node)this).AddChild((Node)(object)_image, false, (InternalMode)0);
		Label val = new Label
		{
			Name = StringName.op_Implicit("Label"),
			HorizontalAlignment = (HorizontalAlignment)1,
			VerticalAlignment = (VerticalAlignment)1,
			LabelSettings = new LabelSettings
			{
				Font = (Font)(object)PreloadManager.Cache.GetAsset<FontVariation>("res://themes/kreon_bold_glyph_space_two.tres"),
				FontSize = 28,
				FontColor = new Color(0.91f, 0.86f, 0.74f, 1f),
				OutlineSize = 12,
				OutlineColor = new Color(0.29f, 0.14f, 0.14f, 1f)
			}
		};
		((Control)val).SetAnchorsPreset((LayoutPreset)15, false);
		((Node)this).AddChild((Node)(object)val, false, (InternalMode)0);
		NSelectionReticle val2 = PreloadManager.Cache.GetScene(SceneHelper.GetScenePath("ui/selection_reticle")).Instantiate<NSelectionReticle>((GenEditState)0);
		((Node)val2).Name = StringName.op_Implicit("SelectionReticle");
		((Control)val2).SetAnchorsAndOffsetsPreset((LayoutPreset)15, (LayoutPresetMode)0, 0);
		((Node)this).AddChild((Node)(object)val2, false, (InternalMode)0);
	}

	/// <summary>
	/// OBSOLETE: Sets the color using an HSV shader. Broken and will be removed soon; ONLY kept for binary compatibility.
	/// </summary>
	/// <param name="h">Hue, range 0-1</param>
	/// <param name="s">Saturation, 0-1 or higher for boosted saturation</param>
	/// <param name="v">Value, range 0-1</param>
	[Obsolete("BROKEN: Use SetColor(Color) instead")]
	public void SetColor(float h, float s, float v)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		float num = (0.48f + (1f - h)) % 1f;
		SetColor(Color.FromHsv(num, Math.Clamp(s * 0.4f, 0f, 1f), v, 1f));
	}

	/// <summary>
	/// Sets the button's color using Godot's SelfModulate property.<br />
	/// The overall color will be slightly darker than the color specified, since it's a modulation of the existing
	/// colors, that aren't fully white.
	/// </summary>
	/// <param name="color">The color to use for SelfModulate.</param>
	public void SetColor(Color color)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		((CanvasItem)_image).SelfModulate = color;
	}

	public override void _Ready()
	{
		((NClickableControl)this).ConnectSignals();
	}

	public void Initialize(string buttonText, Action onPressed)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		SetColor(Color.FromHtml((ReadOnlySpan<char>)DefaultColor));
		_onPressedAction = onPressed;
		Label nodeOrNull = ((Node)this).GetNodeOrNull<Label>(NodePath.op_Implicit("Label"));
		if (nodeOrNull != null)
		{
			nodeOrNull.Text = buttonText;
		}
		_onPressedAction = onPressed;
		((GodotObject)this).Connect(SignalName.Released, Callable.From<NConfigButton>((Action<NConfigButton>)OnReleased), 0u);
	}

	private void OnReleased(NConfigButton button)
	{
		_onPressedAction?.Invoke();
	}

	public override void _ExitTree()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		((NButton)this)._ExitTree();
		((GodotObject)this).Disconnect(SignalName.Released, Callable.From<NConfigButton>((Action<NConfigButton>)OnReleased));
	}

	/// <summary>
	/// Get the method information for all the methods declared in this class.
	/// This method is used by Godot to register the available methods in the editor.
	/// Do not call this method.
	/// </summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal static List<MethodInfo> GetGodotMethodList()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		return new List<MethodInfo>(5)
		{
			new MethodInfo(MethodName.SetColor, new PropertyInfo((Type)0, StringName.op_Implicit(""), (PropertyHint)0, "", (PropertyUsageFlags)6, false), (MethodFlags)1, new List<PropertyInfo>
			{
				new PropertyInfo((Type)3, StringName.op_Implicit("h"), (PropertyHint)0, "", (PropertyUsageFlags)6, false),
				new PropertyInfo((Type)3, StringName.op_Implicit("s"), (PropertyHint)0, "", (PropertyUsageFlags)6, false),
				new PropertyInfo((Type)3, StringName.op_Implicit("v"), (PropertyHint)0, "", (PropertyUsageFlags)6, false)
			}, (List<Variant>)null),
			new MethodInfo(MethodName.SetColor, new PropertyInfo((Type)0, StringName.op_Implicit(""), (PropertyHint)0, "", (PropertyUsageFlags)6, false), (MethodFlags)1, new List<PropertyInfo>
			{
				new PropertyInfo((Type)20, StringName.op_Implicit("color"), (PropertyHint)0, "", (PropertyUsageFlags)6, false)
			}, (List<Variant>)null),
			new MethodInfo(MethodName._Ready, new PropertyInfo((Type)0, StringName.op_Implicit(""), (PropertyHint)0, "", (PropertyUsageFlags)6, false), (MethodFlags)1, (List<PropertyInfo>)null, (List<Variant>)null),
			new MethodInfo(MethodName.OnReleased, new PropertyInfo((Type)0, StringName.op_Implicit(""), (PropertyHint)0, "", (PropertyUsageFlags)6, false), (MethodFlags)1, new List<PropertyInfo>
			{
				new PropertyInfo((Type)24, StringName.op_Implicit("button"), (PropertyHint)0, "", (PropertyUsageFlags)6, new StringName("Control"), false)
			}, (List<Variant>)null),
			new MethodInfo(MethodName._ExitTree, new PropertyInfo((Type)0, StringName.op_Implicit(""), (PropertyHint)0, "", (PropertyUsageFlags)6, false), (MethodFlags)1, (List<PropertyInfo>)null, (List<Variant>)null)
		};
	}

	/// <inheritdoc />
	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override bool InvokeGodotClassMethod(in godot_string_name method, NativeVariantPtrArgs args, out godot_variant ret)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		if ((ref method) == MethodName.SetColor && ((NativeVariantPtrArgs)(ref args)).Count == 3)
		{
			SetColor(VariantUtils.ConvertTo<float>(ref ((NativeVariantPtrArgs)(ref args))[0]), VariantUtils.ConvertTo<float>(ref ((NativeVariantPtrArgs)(ref args))[1]), VariantUtils.ConvertTo<float>(ref ((NativeVariantPtrArgs)(ref args))[2]));
			ret = default(godot_variant);
			return true;
		}
		if ((ref method) == MethodName.SetColor && ((NativeVariantPtrArgs)(ref args)).Count == 1)
		{
			SetColor(VariantUtils.ConvertTo<Color>(ref ((NativeVariantPtrArgs)(ref args))[0]));
			ret = default(godot_variant);
			return true;
		}
		if ((ref method) == MethodName._Ready && ((NativeVariantPtrArgs)(ref args)).Count == 0)
		{
			((Node)this)._Ready();
			ret = default(godot_variant);
			return true;
		}
		if ((ref method) == MethodName.OnReleased && ((NativeVariantPtrArgs)(ref args)).Count == 1)
		{
			OnReleased(VariantUtils.ConvertTo<NConfigButton>(ref ((NativeVariantPtrArgs)(ref args))[0]));
			ret = default(godot_variant);
			return true;
		}
		if ((ref method) == MethodName._ExitTree && ((NativeVariantPtrArgs)(ref args)).Count == 0)
		{
			((Node)this)._ExitTree();
			ret = default(godot_variant);
			return true;
		}
		return ((NSettingsButton)this).InvokeGodotClassMethod(ref method, args, ref ret);
	}

	/// <inheritdoc />
	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override bool HasGodotClassMethod(in godot_string_name method)
	{
		if ((ref method) == MethodName.SetColor)
		{
			return true;
		}
		if ((ref method) == MethodName._Ready)
		{
			return true;
		}
		if ((ref method) == MethodName.OnReleased)
		{
			return true;
		}
		if ((ref method) == MethodName._ExitTree)
		{
			return true;
		}
		return ((NSettingsButton)this).HasGodotClassMethod(ref method);
	}

	/// <inheritdoc />
	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override bool SetGodotClassPropertyValue(in godot_string_name name, in godot_variant value)
	{
		if ((ref name) == PropertyName._image)
		{
			_image = VariantUtils.ConvertTo<TextureRect>(ref value);
			return true;
		}
		return ((NSettingsButton)this).SetGodotClassPropertyValue(ref name, ref value);
	}

	/// <inheritdoc />
	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override bool GetGodotClassPropertyValue(in godot_string_name name, out godot_variant value)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if ((ref name) == PropertyName._image)
		{
			value = VariantUtils.CreateFrom<TextureRect>(ref _image);
			return true;
		}
		return ((NSettingsButton)this).GetGodotClassPropertyValue(ref name, ref value);
	}

	/// <summary>
	/// Get the property information for all the properties declared in this class.
	/// This method is used by Godot to register the available properties in the editor.
	/// Do not call this method.
	/// </summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal static List<PropertyInfo> GetGodotPropertyList()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		return new List<PropertyInfo>
		{
			new PropertyInfo((Type)24, PropertyName._image, (PropertyHint)0, "", (PropertyUsageFlags)4096, false)
		};
	}

	/// <inheritdoc />
	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override void SaveGodotObjectData(GodotSerializationInfo info)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		((NSettingsButton)this).SaveGodotObjectData(info);
		info.AddProperty(PropertyName._image, Variant.From<TextureRect>(ref _image));
	}

	/// <inheritdoc />
	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override void RestoreGodotObjectData(GodotSerializationInfo info)
	{
		((NSettingsButton)this).RestoreGodotObjectData(info);
		Variant val = default(Variant);
		if (info.TryGetProperty(PropertyName._image, ref val))
		{
			_image = ((Variant)(ref val)).As<TextureRect>();
		}
	}
}
