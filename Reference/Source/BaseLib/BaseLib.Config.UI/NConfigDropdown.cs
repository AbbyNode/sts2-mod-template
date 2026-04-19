using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using BaseLib.Utils;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Helpers;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Nodes.CommonUi;
using MegaCrit.Sts2.Core.Nodes.GodotExtensions;
using MegaCrit.Sts2.Core.Nodes.Screens.Settings;

namespace BaseLib.Config.UI;

[ScriptPath("res://Config/UI/NConfigDropdown.cs")]
public class NConfigDropdown : NSettingsDropdown
{
	/// <summary>
	/// Cached StringNames for the methods contained in this class, for fast lookup.
	/// </summary>
	public class MethodName : MethodName
	{
		/// <summary>
		/// Cached name for the 'SetFromProperty' method.
		/// </summary>
		public static readonly StringName SetFromProperty = StringName.op_Implicit("SetFromProperty");

		/// <summary>
		/// Cached name for the '_Process' method.
		/// </summary>
		public static readonly StringName _Process = StringName.op_Implicit("_Process");

		/// <summary>
		/// Cached name for the '_Ready' method.
		/// </summary>
		public static readonly StringName _Ready = StringName.op_Implicit("_Ready");

		/// <summary>
		/// Cached name for the 'OnDropdownItemSelected' method.
		/// </summary>
		public static readonly StringName OnDropdownItemSelected = StringName.op_Implicit("OnDropdownItemSelected");

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
		/// Cached name for the '_currentDisplayIndex' field.
		/// </summary>
		public static readonly StringName _currentDisplayIndex = StringName.op_Implicit("_currentDisplayIndex");

		/// <summary>
		/// Cached name for the '_lastGlobalY' field.
		/// </summary>
		public static readonly StringName _lastGlobalY = StringName.op_Implicit("_lastGlobalY");

		/// <summary>
		/// Cached name for the '_selfNodePath' field.
		/// </summary>
		public static readonly StringName _selfNodePath = StringName.op_Implicit("_selfNodePath");
	}

	/// <summary>
	/// Cached StringNames for the signals contained in this class, for fast lookup.
	/// </summary>
	public class SignalName : SignalName
	{
	}

	private List<NConfigDropdownItem.ItemData>? _items;

	private ModConfig? _config;

	private PropertyInfo? _property;

	private int _currentDisplayIndex = -1;

	private float _lastGlobalY;

	private NodePath _selfNodePath = new NodePath(".");

	public NConfigDropdown()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).SetCustomMinimumSize(new Vector2(324f, 64f));
		((Control)this).SizeFlagsHorizontal = (SizeFlags)8;
		((Control)this).SizeFlagsVertical = (SizeFlags)1;
		((Control)this).FocusMode = (FocusModeEnum)2;
		this.TransferAllNodes<NConfigDropdown>(SceneHelper.GetScenePath("screens/settings_dropdown"), Array.Empty<string>());
	}

	public void Initialize(ModConfig config, PropertyInfo property, string modPrefix, Action? onChanged)
	{
		_config = config;
		_property = property;
		_items = new List<NConfigDropdownItem.ItemData>();
		Type propertyType = property.PropertyType;
		if (!propertyType.IsEnum)
		{
			throw new NotSupportedException("Dropdown only supports enum types currently");
		}
		foreach (object value in propertyType.GetEnumValues())
		{
			LocString ifExists = LocString.GetIfExists("settings_ui", $"{modPrefix}{StringHelper.Slugify(property.Name)}.{value}");
			string text = ((ifExists != null) ? ifExists.GetRawText() : null) ?? value?.ToString() ?? "UNKNOWN";
			_items.Add(new NConfigDropdownItem.ItemData(text, value, delegate
			{
				_property.SetValue(null, value);
				onChanged?.Invoke();
			}));
		}
		_config.OnConfigReloaded += SetFromProperty;
	}

	public void SetFromProperty()
	{
		if (!(_property == null) && _items != null)
		{
			object currentValue = _property.GetValue(null);
			int num = _items.FindIndex((NConfigDropdownItem.ItemData item) => item.Value?.Equals(currentValue) ?? false);
			if (num < 0)
			{
				num = 0;
			}
			_currentDisplayIndex = num;
			if (((Node)this).IsNodeReady())
			{
				((NDropdown)this)._currentOptionLabel.SetTextAutoSize(_items[num].Text);
			}
		}
	}

	public override void _Process(double delta)
	{
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		((Node)this)._Process(delta);
		if (((Control)this).FocusNeighborLeft != _selfNodePath || ((Control)this).FocusNeighborRight != _selfNodePath)
		{
			((Control)this).FocusNeighborLeft = _selfNodePath;
			((Control)this).FocusNeighborRight = _selfNodePath;
		}
		if (((Node)this).IsNodeReady() && ((CanvasItem)((NDropdown)this)._dropdownContainer).Visible)
		{
			((NDropdown)this)._dropdownContainer.GlobalPosition = ((Control)this).GlobalPosition + new Vector2(0f, ((Control)this).Size.Y);
		}
		_lastGlobalY = ((Control)this).GlobalPosition.Y;
	}

	public override void _Ready()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		((NClickableControl)this).ConnectSignals();
		((NDropdown)this).ClearDropdownItems();
		if (_items == null)
		{
			throw new Exception("Created config dropdown without calling Initialize");
		}
		for (int i = 0; i < _items.Count; i++)
		{
			NConfigDropdownItem nConfigDropdownItem = NConfigDropdownItem.Create(_items[i]);
			GodotTreeExtensions.AddChildSafely((Node)(object)((NDropdown)this)._dropdownItems, (Node)(object)nConfigDropdownItem);
			((GodotObject)nConfigDropdownItem).Connect(SignalName.Selected, Callable.From<NDropdownItem>((Action<NDropdownItem>)OnDropdownItemSelected), 0u);
			nConfigDropdownItem.Init(i);
			if (i == _currentDisplayIndex)
			{
				((NDropdown)this)._currentOptionLabel.SetTextAutoSize(nConfigDropdownItem.Data.Text);
			}
		}
		((Node)((NDropdown)this)._dropdownItems).GetParent<NDropdownContainer>().RefreshLayout();
		((CanvasItem)((NDropdown)this)._dropdownContainer).VisibilityChanged += delegate
		{
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			((CanvasItem)((NDropdown)this)._dropdownContainer).TopLevel = ((CanvasItem)((NDropdown)this)._dropdownContainer).Visible;
			((NDropdown)this)._dropdownContainer.GlobalPosition = ((Control)this).GlobalPosition + new Vector2(0f, ((Control)this).Size.Y);
			if (_currentDisplayIndex >= 0 && _currentDisplayIndex < _items.Count)
			{
				NConfigDropdownItem childOrNull = ((Node)((NDropdown)this)._dropdownItems).GetChildOrNull<NConfigDropdownItem>(_currentDisplayIndex, false);
				if (childOrNull != null)
				{
					NodeUtil.TryGrabFocus((Control)(object)childOrNull);
				}
			}
		};
	}

	private void OnDropdownItemSelected(NDropdownItem nDropdownItem)
	{
		if (nDropdownItem is NConfigDropdownItem nConfigDropdownItem)
		{
			((NDropdown)this).CloseDropdown();
			((NDropdown)this)._currentOptionLabel.SetTextAutoSize(nConfigDropdownItem.Data.Text);
			_currentDisplayIndex = nConfigDropdownItem.DisplayIndex;
			nConfigDropdownItem.Data.OnSet();
		}
	}

	public override void _ExitTree()
	{
		((Node)this)._ExitTree();
		if (_config != null)
		{
			_config.OnConfigReloaded -= SetFromProperty;
		}
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
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		return new List<MethodInfo>(5)
		{
			new MethodInfo(MethodName.SetFromProperty, new PropertyInfo((Type)0, StringName.op_Implicit(""), (PropertyHint)0, "", (PropertyUsageFlags)6, false), (MethodFlags)1, (List<PropertyInfo>)null, (List<Variant>)null),
			new MethodInfo(MethodName._Process, new PropertyInfo((Type)0, StringName.op_Implicit(""), (PropertyHint)0, "", (PropertyUsageFlags)6, false), (MethodFlags)1, new List<PropertyInfo>
			{
				new PropertyInfo((Type)3, StringName.op_Implicit("delta"), (PropertyHint)0, "", (PropertyUsageFlags)6, false)
			}, (List<Variant>)null),
			new MethodInfo(MethodName._Ready, new PropertyInfo((Type)0, StringName.op_Implicit(""), (PropertyHint)0, "", (PropertyUsageFlags)6, false), (MethodFlags)1, (List<PropertyInfo>)null, (List<Variant>)null),
			new MethodInfo(MethodName.OnDropdownItemSelected, new PropertyInfo((Type)0, StringName.op_Implicit(""), (PropertyHint)0, "", (PropertyUsageFlags)6, false), (MethodFlags)1, new List<PropertyInfo>
			{
				new PropertyInfo((Type)24, StringName.op_Implicit("nDropdownItem"), (PropertyHint)0, "", (PropertyUsageFlags)6, new StringName("Control"), false)
			}, (List<Variant>)null),
			new MethodInfo(MethodName._ExitTree, new PropertyInfo((Type)0, StringName.op_Implicit(""), (PropertyHint)0, "", (PropertyUsageFlags)6, false), (MethodFlags)1, (List<PropertyInfo>)null, (List<Variant>)null)
		};
	}

	/// <inheritdoc />
	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override bool InvokeGodotClassMethod(in godot_string_name method, NativeVariantPtrArgs args, out godot_variant ret)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		if ((ref method) == MethodName.SetFromProperty && ((NativeVariantPtrArgs)(ref args)).Count == 0)
		{
			SetFromProperty();
			ret = default(godot_variant);
			return true;
		}
		if ((ref method) == MethodName._Process && ((NativeVariantPtrArgs)(ref args)).Count == 1)
		{
			((Node)this)._Process(VariantUtils.ConvertTo<double>(ref ((NativeVariantPtrArgs)(ref args))[0]));
			ret = default(godot_variant);
			return true;
		}
		if ((ref method) == MethodName._Ready && ((NativeVariantPtrArgs)(ref args)).Count == 0)
		{
			((Node)this)._Ready();
			ret = default(godot_variant);
			return true;
		}
		if ((ref method) == MethodName.OnDropdownItemSelected && ((NativeVariantPtrArgs)(ref args)).Count == 1)
		{
			OnDropdownItemSelected(VariantUtils.ConvertTo<NDropdownItem>(ref ((NativeVariantPtrArgs)(ref args))[0]));
			ret = default(godot_variant);
			return true;
		}
		if ((ref method) == MethodName._ExitTree && ((NativeVariantPtrArgs)(ref args)).Count == 0)
		{
			((Node)this)._ExitTree();
			ret = default(godot_variant);
			return true;
		}
		return ((NSettingsDropdown)this).InvokeGodotClassMethod(ref method, args, ref ret);
	}

	/// <inheritdoc />
	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override bool HasGodotClassMethod(in godot_string_name method)
	{
		if ((ref method) == MethodName.SetFromProperty)
		{
			return true;
		}
		if ((ref method) == MethodName._Process)
		{
			return true;
		}
		if ((ref method) == MethodName._Ready)
		{
			return true;
		}
		if ((ref method) == MethodName.OnDropdownItemSelected)
		{
			return true;
		}
		if ((ref method) == MethodName._ExitTree)
		{
			return true;
		}
		return ((NSettingsDropdown)this).HasGodotClassMethod(ref method);
	}

	/// <inheritdoc />
	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override bool SetGodotClassPropertyValue(in godot_string_name name, in godot_variant value)
	{
		if ((ref name) == PropertyName._currentDisplayIndex)
		{
			_currentDisplayIndex = VariantUtils.ConvertTo<int>(ref value);
			return true;
		}
		if ((ref name) == PropertyName._lastGlobalY)
		{
			_lastGlobalY = VariantUtils.ConvertTo<float>(ref value);
			return true;
		}
		if ((ref name) == PropertyName._selfNodePath)
		{
			_selfNodePath = VariantUtils.ConvertTo<NodePath>(ref value);
			return true;
		}
		return ((NSettingsDropdown)this).SetGodotClassPropertyValue(ref name, ref value);
	}

	/// <inheritdoc />
	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override bool GetGodotClassPropertyValue(in godot_string_name name, out godot_variant value)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		if ((ref name) == PropertyName._currentDisplayIndex)
		{
			value = VariantUtils.CreateFrom<int>(ref _currentDisplayIndex);
			return true;
		}
		if ((ref name) == PropertyName._lastGlobalY)
		{
			value = VariantUtils.CreateFrom<float>(ref _lastGlobalY);
			return true;
		}
		if ((ref name) == PropertyName._selfNodePath)
		{
			value = VariantUtils.CreateFrom<NodePath>(ref _selfNodePath);
			return true;
		}
		return ((NSettingsDropdown)this).GetGodotClassPropertyValue(ref name, ref value);
	}

	/// <summary>
	/// Get the property information for all the properties declared in this class.
	/// This method is used by Godot to register the available properties in the editor.
	/// Do not call this method.
	/// </summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal static List<PropertyInfo> GetGodotPropertyList()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		return new List<PropertyInfo>
		{
			new PropertyInfo((Type)2, PropertyName._currentDisplayIndex, (PropertyHint)0, "", (PropertyUsageFlags)4096, false),
			new PropertyInfo((Type)3, PropertyName._lastGlobalY, (PropertyHint)0, "", (PropertyUsageFlags)4096, false),
			new PropertyInfo((Type)22, PropertyName._selfNodePath, (PropertyHint)0, "", (PropertyUsageFlags)4096, false)
		};
	}

	/// <inheritdoc />
	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override void SaveGodotObjectData(GodotSerializationInfo info)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		((NSettingsDropdown)this).SaveGodotObjectData(info);
		info.AddProperty(PropertyName._currentDisplayIndex, Variant.From<int>(ref _currentDisplayIndex));
		info.AddProperty(PropertyName._lastGlobalY, Variant.From<float>(ref _lastGlobalY));
		info.AddProperty(PropertyName._selfNodePath, Variant.From<NodePath>(ref _selfNodePath));
	}

	/// <inheritdoc />
	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override void RestoreGodotObjectData(GodotSerializationInfo info)
	{
		((NSettingsDropdown)this).RestoreGodotObjectData(info);
		Variant val = default(Variant);
		if (info.TryGetProperty(PropertyName._currentDisplayIndex, ref val))
		{
			_currentDisplayIndex = ((Variant)(ref val)).As<int>();
		}
		Variant val2 = default(Variant);
		if (info.TryGetProperty(PropertyName._lastGlobalY, ref val2))
		{
			_lastGlobalY = ((Variant)(ref val2)).As<float>();
		}
		Variant val3 = default(Variant);
		if (info.TryGetProperty(PropertyName._selfNodePath, ref val3))
		{
			_selfNodePath = ((Variant)(ref val3)).As<NodePath>();
		}
	}
}
