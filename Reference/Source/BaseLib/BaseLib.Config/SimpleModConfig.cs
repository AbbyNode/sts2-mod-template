using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using BaseLib.Config.UI;
using BaseLib.Extensions;
using Godot;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Nodes.CommonUi;
using MegaCrit.Sts2.Core.Nodes.Multiplayer;
using MegaCrit.Sts2.addons.mega_text;

namespace BaseLib.Config;

public class SimpleModConfig : ModConfig
{
	private sealed class DividerTracker
	{
		private readonly List<(Control Divider, Control Upper, Control Lower)> _pairs = new List<(Control, Control, Control)>();

		private Control? _pendingDivider;

		private Control? _pendingUpperRow;

		public void CompletePending(Control lowerRow)
		{
			if (_pendingDivider != null)
			{
				_pairs.Add((_pendingDivider, _pendingUpperRow, lowerRow));
				_pendingDivider = null;
			}
		}

		public void AddPending(Control divider, Control upperRow)
		{
			_pendingDivider = divider;
			_pendingUpperRow = upperRow;
		}

		public void UpdateAll()
		{
			foreach (var (val, val2, val3) in _pairs)
			{
				((CanvasItem)val).Visible = ((CanvasItem)val2).Visible && ((CanvasItem)val3).Visible;
			}
		}
	}

	private sealed class SectionTracker
	{
		private readonly Dictionary<Control, List<Control>> _headerRows = new Dictionary<Control, List<Control>>();

		public Control? CurrentHeader { get; private set; }

		public string? CurrentSectionName { get; private set; }

		public void MaybeStartNew(string? sectionName, Func<string, bool, Control> createHeader, Control targetContainer)
		{
			if (sectionName != null && !(sectionName == CurrentSectionName))
			{
				CurrentSectionName = sectionName;
				CurrentHeader = createHeader(sectionName, ((Node)targetContainer).GetChildCount(false) == 0);
				_headerRows[CurrentHeader] = new List<Control>();
				((Node)targetContainer).AddChild((Node)(object)CurrentHeader, false, (InternalMode)0);
			}
		}

		public void RegisterRow(Control row)
		{
			if (CurrentHeader != null)
			{
				_headerRows[CurrentHeader].Add(row);
			}
		}

		public void UpdateHeaderVisibility(Control header)
		{
			((CanvasItem)header).Visible = _headerRows[header].Any((Control r) => ((CanvasItem)r).Visible);
		}

		public void UpdateAllHeaderVisibility()
		{
			foreach (var (header, _) in _headerRows)
			{
				UpdateHeaderVisibility(header);
			}
		}
	}

	/// <summary>
	/// Lists to keep track of handlers created in order to properly to dispose.
	/// </summary>
	protected readonly List<EventHandler> _configChangedHandlers = new List<EventHandler>();

	protected readonly List<Action> _configReloadedHandlers = new List<Action>();

	private static readonly NodePath selfNodePath = new NodePath(".");

	/// <summary>
	/// Auto-generate a UI from the properties used. Should be enough for the vast majority of mods,
	/// but you can also subclass SimpleModConfig and override this to get access to helpers like
	/// <see cref="M:BaseLib.Config.SimpleModConfig.CreateToggleOption(System.Reflection.PropertyInfo,System.Boolean)" /> (in addition to the raw Create*Control methods from ModConfig),
	/// without an auto-generated UI.
	/// </summary>
	public override void SetupConfigUI(Control optionContainer)
	{
		BaseLibMain.Logger.Info("Setting up SimpleModConfig " + GetType().FullName, 1);
		GenerateOptionsForAllProperties(optionContainer);
		AddRestoreDefaultsButton(optionContainer);
		SetupFocusNeighbors(optionContainer);
	}

	protected void AddRestoreDefaultsButton(Control optionContainer)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		NConfigButton nConfigButton = CreateRawButtonControl(ModConfig.GetBaseLibLabelText("RestoreDefaultsButton"), async delegate
		{
			try
			{
				await ConfirmRestoreDefaults();
			}
			catch (Exception ex)
			{
				ModConfigLogger.Error("Unable to show restore confirmation dialog: " + ex.Message);
			}
		});
		((Control)nConfigButton).CustomMinimumSize = new Vector2(360f, ((Control)nConfigButton).CustomMinimumSize.Y);
		nConfigButton.SetColor(Color.FromHtml((ReadOnlySpan<char>)"#b03f3f"));
		CenterContainer val = new CenterContainer();
		((Control)val).CustomMinimumSize = new Vector2(0f, 128f);
		((Node)val).AddChild((Node)(object)nConfigButton, false, (InternalMode)0);
		((Node)optionContainer).AddChild((Node)(object)val, false, (InternalMode)0);
	}

	public async Task ConfirmRestoreDefaults()
	{
		NGenericPopup val = NGenericPopup.Create();
		if (val != null && NModalContainer.Instance != null)
		{
			NModalContainer.Instance.Add((Node)(object)val, true);
			if (await val.WaitForConfirmation(new LocString("settings_ui", "BASELIB-RESTORE_MODCONFIG_CONFIRMATION.body"), new LocString("settings_ui", "BASELIB-RESTORE_MODCONFIG_CONFIRMATION.header"), new LocString("main_menu_ui", "GENERIC_POPUP.cancel"), new LocString("main_menu_ui", "GENERIC_POPUP.confirm")))
			{
				RestoreDefaultsNoConfirm();
			}
		}
	}

	/// <inheritdoc cref="M:BaseLib.Config.SimpleModConfig.CreateStandardOption(System.Func{System.Reflection.PropertyInfo,Godot.Control},System.Reflection.PropertyInfo,System.Boolean)" />
	protected NConfigOptionRow CreateToggleOption(PropertyInfo property, bool addHoverTip = false)
	{
		return CreateStandardOption(base.CreateRawTickboxControl, property, addHoverTip);
	}

	/// <inheritdoc cref="M:BaseLib.Config.SimpleModConfig.CreateStandardOption(System.Func{System.Reflection.PropertyInfo,Godot.Control},System.Reflection.PropertyInfo,System.Boolean)" />
	protected NConfigOptionRow CreateSliderOption(PropertyInfo property, bool addHoverTip = false)
	{
		return CreateStandardOption(base.CreateRawSliderControl, property, addHoverTip);
	}

	/// <inheritdoc cref="M:BaseLib.Config.SimpleModConfig.CreateStandardOption(System.Func{System.Reflection.PropertyInfo,Godot.Control},System.Reflection.PropertyInfo,System.Boolean)" />
	protected NConfigOptionRow CreateDropdownOption(PropertyInfo property, bool addHoverTip = false)
	{
		return CreateStandardOption(base.CreateRawDropdownControl, property, addHoverTip);
	}

	/// <inheritdoc cref="M:BaseLib.Config.SimpleModConfig.CreateStandardOption(System.Func{System.Reflection.PropertyInfo,Godot.Control},System.Reflection.PropertyInfo,System.Boolean)" />
	protected NConfigOptionRow CreateLineEditOption(PropertyInfo property, bool addHoverTip = false)
	{
		return CreateStandardOption(base.CreateRawLineEditControl, property, addHoverTip);
	}

	/// <inheritdoc cref="M:BaseLib.Config.SimpleModConfig.CreateStandardOption(System.Func{System.Reflection.PropertyInfo,Godot.Control},System.Reflection.PropertyInfo,System.Boolean)" />
	protected NConfigOptionRow CreateColorPickerOption(PropertyInfo property, bool addHoverTip = false)
	{
		return CreateStandardOption(base.CreateRawColorPickerControl, property, addHoverTip);
	}

	/// <summary>
	/// Creates a button that can be mapped to perform any action.
	/// </summary>
	/// <param name="rowLabelKey">LocString key for the row label (shown where setting names are shown).</param>
	/// <param name="buttonLabelKey">LocString key for the button's label text.</param>
	/// <param name="onPressed">Action to perform when clicked/pressed.</param>
	/// <param name="addHoverTip">If true, generates a localized hover tip; the localization key name is based on rowLabelKey.</param>
	protected NConfigOptionRow CreateButton(string rowLabelKey, string buttonLabelKey, Action onPressed, bool addHoverTip = false)
	{
		NConfigButton nConfigButton = CreateRawButtonControl(GetLabelText(buttonLabelKey), onPressed);
		MegaRichTextLabel label = ModConfig.CreateRawLabelControl(GetLabelText(rowLabelKey), 28);
		NConfigOptionRow nConfigOptionRow = new NConfigOptionRow(base.ModPrefix, rowLabelKey, (Control)(object)label, (Control)(object)nConfigButton);
		((Control)(object)nConfigButton).ClearFocusNeighbors();
		if (addHoverTip)
		{
			nConfigOptionRow.AddHoverTip();
		}
		return nConfigOptionRow;
	}

	/// <summary>
	/// Creates a layout-ready section header row.
	/// </summary>
	protected MarginContainer CreateSectionHeader(string labelName, bool alignToTop = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		MarginContainer val = new MarginContainer
		{
			Name = StringName.op_Implicit("Container_" + labelName.Replace(" ", ""))
		};
		((Control)val).AddThemeConstantOverride(StringName.op_Implicit("margin_left"), 24);
		((Control)val).AddThemeConstantOverride(StringName.op_Implicit("margin_right"), 24);
		((Control)val).MouseFilter = (MouseFilterEnum)2;
		((Control)val).FocusMode = (FocusModeEnum)0;
		MegaRichTextLabel val2 = ModConfig.CreateRawLabelControl("[center][b]" + GetLabelText(labelName) + "[/b][/center]", 40);
		((Node)val2).Name = StringName.op_Implicit("SectionLabel_" + labelName.Replace(" ", ""));
		((Control)val2).CustomMinimumSize = new Vector2(0f, 64f);
		if (alignToTop)
		{
			((RichTextLabel)val2).VerticalAlignment = (VerticalAlignment)0;
		}
		((Node)val).AddChild((Node)(object)val2, false, (InternalMode)0);
		return val;
	}

	/// <summary>
	/// <para>Creates a standard configuration row containing a label and an option control. It has default margins
	/// and optionally a hover tip (see <see cref="M:BaseLib.Config.UI.NConfigOptionRow.AddHoverTip" /> for requirements).</para>
	/// <para>You likely only need to call this if you create a custom control and want to use the default font/margin
	/// settings for it.</para>
	/// </summary>
	/// <param name="controlCreator" />
	/// <param name="property">The property this option represents.</param>
	/// <param name="addHoverTip">If true, automatically attaches a localized tooltip.</param>
	/// <returns>A fully configured <see cref="T:BaseLib.Config.UI.NConfigOptionRow" />, ready to insert with AddChild.</returns>
	protected NConfigOptionRow CreateStandardOption(Func<PropertyInfo, Control> controlCreator, PropertyInfo property, bool addHoverTip = false)
	{
		Control val = controlCreator(property);
		MegaRichTextLabel label = ModConfig.CreateRawLabelControl(GetLabelText(property.Name), 28);
		NConfigOptionRow nConfigOptionRow = new NConfigOptionRow(base.ModPrefix, property.Name, (Control)(object)label, val);
		val.ClearFocusNeighbors();
		if (addHoverTip)
		{
			nConfigOptionRow.AddHoverTip();
		}
		return nConfigOptionRow;
	}

	/// <summary>
	/// Auto-generates a UI row from a property, including a hover tip if [ConfigHoverTip] is specified.<br />
	/// Properties with [ConfigHideinUI] will NOT be ignored, so you can use this to manually create them if you wish.
	/// </summary>
	/// <exception cref="T:System.NotSupportedException">Thrown for non-supported property types.</exception>
	protected NConfigOptionRow GenerateOptionFromProperty(PropertyInfo property)
	{
		Type propertyType = property.PropertyType;
		bool flag = property.GetCustomAttribute<ConfigColorPickerAttribute>() != null;
		NConfigOptionRow nConfigOptionRow;
		if (propertyType == typeof(bool))
		{
			nConfigOptionRow = CreateToggleOption(property);
		}
		else if (propertyType == typeof(Color) || (propertyType == typeof(string) && flag))
		{
			nConfigOptionRow = CreateColorPickerOption(property);
		}
		else if (propertyType == typeof(string))
		{
			nConfigOptionRow = CreateLineEditOption(property);
		}
		else if (Enumerable.Contains(NConfigSlider.SupportedTypes, propertyType))
		{
			nConfigOptionRow = CreateSliderOption(property);
		}
		else
		{
			if (!propertyType.IsEnum)
			{
				throw new NotSupportedException("Type " + propertyType.FullName + " is not supported by SimpleModConfig.");
			}
			nConfigOptionRow = CreateDropdownOption(property);
		}
		AddHoverTipToOptionRowIfEnabled(nConfigOptionRow, property);
		return nConfigOptionRow;
	}

	/// <summary>
	/// Auto-generates a button row from a method marked with [ConfigButton], including a hover tip if [ConfigHoverTip]
	/// is specified.<br />
	/// Methods with [ConfigHideinUI] will NOT be ignored, so you can use this to manually create buttons for them
	/// if you wish.
	/// </summary>
	/// <exception cref="T:System.NotSupportedException">Thrown if [ConfigButton] is missing.</exception>
	protected NConfigOptionRow GenerateButtonRowFromMethod(MethodInfo method)
	{
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		ConfigButtonAttribute configButtonAttribute = method.GetCustomAttribute<ConfigButtonAttribute>() ?? throw new ArgumentException("GenerateOptionFromMethod called on " + method.Name + " but it lacks a [ConfigButton] attribute.");
		ParameterInfo[] parameters = method.GetParameters();
		foreach (ParameterInfo param in parameters)
		{
			ResolveButtonArgument(param, null);
		}
		NConfigOptionRow optionRow = null;
		Action onPressed = delegate
		{
			try
			{
				object[] parameters2 = (from param2 in method.GetParameters()
					select ResolveButtonArgument(param2, optionRow)).ToArray();
				method.Invoke(method.IsStatic ? null : this, parameters2);
			}
			catch (Exception value)
			{
				BaseLibMain.Logger.Error($"Error executing [ConfigButton] method {method.Name}:\n{value}", 1);
			}
			ConfigReloaded();
			ModConfig.ShowAndClearPendingErrors();
		};
		optionRow = CreateButton(method.Name, configButtonAttribute.ButtonLabelKey, onPressed);
		if (optionRow.SettingControl is NConfigButton nConfigButton)
		{
			nConfigButton.SetColor(Color.FromHtml((ReadOnlySpan<char>)configButtonAttribute.Color));
		}
		AddHoverTipToOptionRowIfEnabled(optionRow, method);
		return optionRow;
	}

	protected object ResolveButtonArgument(ParameterInfo param, NConfigOptionRow? optionRow)
	{
		Type parameterType = param.ParameterType;
		if (typeof(ModConfig).IsAssignableFrom(parameterType))
		{
			return this;
		}
		if (parameterType == typeof(NConfigOptionRow))
		{
			return optionRow;
		}
		if (parameterType == typeof(NConfigButton))
		{
			return optionRow?.SettingControl;
		}
		throw new ArgumentException($"Unsupported parameter type '{parameterType.Name}' for method {param.Member.Name}.");
	}

	protected void AddHoverTipToOptionRowIfEnabled(NConfigOptionRow row, MemberInfo member)
	{
		ConfigHoverTipAttribute? customAttribute = member.GetCustomAttribute<ConfigHoverTipAttribute>();
		bool flag = GetType().GetCustomAttribute<ConfigHoverTipsByDefaultAttribute>() != null;
		if (customAttribute?.Enabled ?? flag)
		{
			row.AddHoverTip();
		}
	}

	/// <summary>
	/// <para>Auto-generate option rows for all properties in this SimpleModConfig. Runs by default, so that a subclass
	/// only needs to add its config properties, and nothing more, to get a reasonable UI.</para>
	/// Properties marked with [ConfigHideInUI] will be ignored. Properties marked with [ConfigIgnore] won't even make
	/// it to this method.<br />
	/// Methods marked with [ConfigButton] will generate buttons.
	/// </summary>
	/// <param name="targetContainer">Container where the generated options are inserted.</param>
	protected void GenerateOptionsForAllProperties(Control targetContainer)
	{
		SectionTracker sections = new SectionTracker();
		DividerTracker dividers = new DividerTracker();
		List<MemberInfo> filteredMembers = GetFilteredMembers(GetType());
		for (int i = 0; i < filteredMembers.Count; i++)
		{
			MemberInfo memberInfo = filteredMembers[i];
			MemberInfo memberInfo2 = ((i < filteredMembers.Count - 1) ? filteredMembers[i + 1] : null);
			string sectionName = memberInfo.GetCustomAttribute<ConfigSectionAttribute>()?.Name;
			sections.MaybeStartNew(sectionName, CreateSectionHeader, targetContainer);
			NConfigOptionRow nConfigOptionRow2;
			try
			{
				NConfigOptionRow nConfigOptionRow;
				if (!(memberInfo is PropertyInfo property))
				{
					if (!(memberInfo is MethodInfo method))
					{
						throw new UnreachableException("Invalid type that should have been filtered out");
					}
					nConfigOptionRow = GenerateButtonRowFromMethod(method);
				}
				else
				{
					nConfigOptionRow = GenerateOptionFromProperty(property);
				}
				nConfigOptionRow2 = nConfigOptionRow;
			}
			catch (NotSupportedException ex)
			{
				BaseLibMain.Logger.Error("Not creating UI for unsupported property '" + memberInfo.Name + "': " + ex.Message, 1);
				continue;
			}
			((Node)targetContainer).AddChild((Node)(object)nConfigOptionRow2, false, (InternalMode)0);
			dividers.CompletePending((Control)(object)nConfigOptionRow2);
			sections.RegisterRow((Control)(object)nConfigOptionRow2);
			Action rowVisibilityUpdater = BuildVisibilityUpdater(memberInfo, (Control)(object)nConfigOptionRow2);
			Action triggerVisibilityUpdate = null;
			if (rowVisibilityUpdater != null)
			{
				Control headerForThisRow = sections.CurrentHeader;
				triggerVisibilityUpdate = delegate
				{
					rowVisibilityUpdater();
					dividers.UpdateAll();
					if (headerForThisRow != null)
					{
						sections.UpdateHeaderVisibility(headerForThisRow);
					}
				};
				EventHandler eventHandler = delegate
				{
					triggerVisibilityUpdate();
				};
				base.ConfigChanged += eventHandler;
				base.OnConfigReloaded += triggerVisibilityUpdate;
				_configChangedHandlers.Add(eventHandler);
				_configReloadedHandlers.Add(triggerVisibilityUpdate);
			}
			string text = memberInfo2?.GetCustomAttribute<ConfigSectionAttribute>()?.Name;
			bool flag = text == null || text == sections.CurrentSectionName;
			if (memberInfo2 != null && flag)
			{
				ColorRect val = ModConfig.CreateDividerControl();
				((Node)targetContainer).AddChild((Node)(object)val, false, (InternalMode)0);
				dividers.AddPending((Control)(object)val, (Control)(object)nConfigOptionRow2);
			}
			triggerVisibilityUpdate?.Invoke();
		}
		sections.UpdateAllHeaderVisibility();
		dividers.UpdateAll();
	}

	/// <summary>
	/// Connects the first focusable control on each row (each optionContainer child) to each other, for controller
	/// (and keyboard) navigation.<br />
	/// You can run this if you've added or modified controls in some way, to ensure navigation doesn't skip over
	/// controls, which can happen when Godot tries to guess which control is "next" or "previous" when you navigate.
	/// </summary>
	/// <param name="optionContainer">The optionContainer passed to your SetupConfigUI method</param>
	public static void SetupFocusNeighbors(Control optionContainer)
	{
		List<Control> list = (from c in ((IEnumerable)((Node)optionContainer).GetChildren(false)).OfType<Control>()
			select ((Node?)(object)c).FindFirstFocusable()).OfType<Control>().ToList();
		if (list.Count == 0)
		{
			return;
		}
		for (int num = 0; num < list.Count; num++)
		{
			Control val = list[num];
			Control obj;
			if (num != 0)
			{
				obj = list[num - 1];
			}
			else
			{
				obj = list[list.Count - 1];
			}
			Control val2 = obj;
			Control val3 = ((num == list.Count - 1) ? list[0] : list[num + 1]);
			if (val.FocusNeighborTop.IsEmpty)
			{
				val.FocusNeighborTop = ((Node)val2).GetPath();
			}
			if (val.FocusNeighborBottom.IsEmpty)
			{
				val.FocusNeighborBottom = ((Node)val3).GetPath();
			}
			if (val.FocusNeighborLeft.IsEmpty)
			{
				val.FocusNeighborLeft = selfNodePath;
			}
			if (val.FocusNeighborRight.IsEmpty)
			{
				val.FocusNeighborRight = selfNodePath;
			}
		}
	}

	private List<MemberInfo> GetFilteredMembers(Type type)
	{
		return type.GetMembers(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).Where(IsVisibleMember).OrderBy(GetSourceOrder)
			.ToList();
		static int GetSourceOrder(MemberInfo member)
		{
			if (!(member is MethodInfo { MetadataToken: var metadataToken }))
			{
				if (member is PropertyInfo propertyInfo)
				{
					return propertyInfo.GetMethod?.MetadataToken ?? propertyInfo.SetMethod?.MetadataToken ?? 0;
				}
				return 0;
			}
			return metadataToken;
		}
		bool IsVisibleMember(MemberInfo member)
		{
			if (member is PropertyInfo propertyInfo)
			{
				return ConfigProperties.Contains(propertyInfo) && propertyInfo.GetCustomAttribute<ConfigHideInUI>() == null;
			}
			if (member is MethodInfo element)
			{
				return element.GetCustomAttribute<ConfigButtonAttribute>() != null;
			}
			return false;
		}
	}

	private Action? BuildVisibilityUpdater(MemberInfo member, Control newRow)
	{
		ConfigVisibleIfAttribute customAttribute = member.GetCustomAttribute<ConfigVisibleIfAttribute>();
		if (customAttribute == null)
		{
			return null;
		}
		Func<bool> condition = BuildVisibilityCondition(customAttribute, member);
		if (condition == null)
		{
			return null;
		}
		return delegate
		{
			((CanvasItem)newRow).Visible = condition();
		};
	}

	private Func<bool>? BuildVisibilityCondition(ConfigVisibleIfAttribute visibleIf, MemberInfo annotatedMember)
	{
		PropertyInfo property = GetType().GetProperty(visibleIf.TargetName, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		if (property != null)
		{
			if (visibleIf.Args.Length != 0 || property.PropertyType == typeof(bool))
			{
				return BuildPropertyCondition(property, visibleIf, annotatedMember);
			}
			BaseLibMain.Logger.Error($"[ConfigVisibleIf] on '{annotatedMember.Name}': property '{visibleIf.TargetName}' is not a bool; at least one value to compare against is required.", 1);
			return null;
		}
		MethodInfo method = GetType().GetMethod(visibleIf.TargetName, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		if (method != null && method.ReturnType == typeof(bool))
		{
			return BuildMethodCondition(method, visibleIf, annotatedMember);
		}
		BaseLibMain.Logger.Error($"[ConfigVisibleIf] on '{annotatedMember.Name}': no valid property or boolean method named '{visibleIf.TargetName}' found on {GetType().Name}.", 1);
		return null;
	}

	private static Func<bool>? BuildPropertyCondition(PropertyInfo prop, ConfigVisibleIfAttribute visibleIf, MemberInfo annotatedMember)
	{
		object?[] convertedArgs = Array.Empty<object>();
		if (visibleIf.Args.Length != 0)
		{
			Type propType = prop.PropertyType;
			try
			{
				convertedArgs = visibleIf.Args.Select((object arg) => (arg != null) ? ((!propType.IsEnum) ? Convert.ChangeType(arg, propType) : Enum.ToObject(propType, arg)) : null).ToArray();
			}
			catch (Exception ex)
			{
				BaseLibMain.Logger.Error($"[ConfigVisibleIf] on '{annotatedMember.Name}': could not convert arguments to '{propType.Name}': {ex.Message}", 1);
				return null;
			}
		}
		return delegate
		{
			object value = prop.GetValue(null);
			bool flag = ((value == null) ? convertedArgs.Any((object a) => a == null) : ((convertedArgs.Length != 0) ? convertedArgs.Any(value.Equals) : (value is bool && (bool)value)));
			return (!visibleIf.Invert) ? flag : (!flag);
		};
	}

	private Func<bool> BuildMethodCondition(MethodInfo method, ConfigVisibleIfAttribute visibleIf, MemberInfo annotatedMember)
	{
		Queue<object?> argsQueue = new Queue<object>(visibleIf.Args);
		object[] preResolvedArgs = (from param in method.GetParameters()
			select ResolveVisibilityMethodArgument(param, annotatedMember, argsQueue)).ToArray();
		return delegate
		{
			try
			{
				bool flag = (bool)method.Invoke(method.IsStatic ? null : this, preResolvedArgs);
				return visibleIf.Invert ? (!flag) : flag;
			}
			catch (Exception value)
			{
				BaseLibMain.Logger.Error($"[ConfigVisibleIf] error invoking '{method.Name}':\n{value}", 1);
				return true;
			}
		};
	}

	/// Resolves arguments for [ConfigVisibleIf] target methods. Auto-injects some types when requested, and injects
	/// all arguments given to the attribute.
	protected object? ResolveVisibilityMethodArgument(ParameterInfo param, MemberInfo memberInfo, Queue<object?> argsQueue)
	{
		Type parameterType = param.ParameterType;
		if (typeof(ModConfig).IsAssignableFrom(parameterType))
		{
			return this;
		}
		if (parameterType == typeof(MemberInfo))
		{
			return memberInfo;
		}
		if (parameterType == typeof(PropertyInfo))
		{
			if (memberInfo is PropertyInfo result)
			{
				return result;
			}
			throw new ArgumentException($"Visibility method '{param.Member.Name}' asks for a PropertyInfo, but was applied to a Button ('{memberInfo.Name}'). Change the parameter to " + "MemberInfo to support both.");
		}
		if (parameterType == typeof(MethodInfo))
		{
			if (memberInfo is MethodInfo result2)
			{
				return result2;
			}
			throw new ArgumentException($"Visibility method '{param.Member.Name}' asks for a MethodInfo, but was applied to a Property ('{memberInfo.Name}'). Change the parameter to " + "MemberInfo to support both.");
		}
		if (!argsQueue.TryDequeue(out object result3))
		{
			throw new ArgumentException($"Method '{param.Member.Name}' requires more arguments than provided in the [ConfigVisibleIf] attribute, and parameter '{param.Name}' is not an auto-injectable type.");
		}
		try
		{
			return (result3 != null) ? Convert.ChangeType(result3, parameterType) : null;
		}
		catch (Exception innerException)
		{
			throw new ArgumentException($"Cannot convert [ConfigVisibleIf] argument '{result3}' to expected type '{parameterType.Name}' for method {param.Member.Name}.", innerException);
		}
	}

	public void ClearUIEventHandlers()
	{
		foreach (EventHandler configChangedHandler in _configChangedHandlers)
		{
			base.ConfigChanged -= configChangedHandler;
		}
		foreach (Action configReloadedHandler in _configReloadedHandlers)
		{
			base.OnConfigReloaded -= configReloadedHandler;
		}
		_configChangedHandlers.Clear();
		_configReloadedHandlers.Clear();
	}
}
