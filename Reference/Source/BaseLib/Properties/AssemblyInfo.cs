using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Security;
using System.Security.Permissions;
using BaseLib.BaseLibScenes;
using BaseLib.Config.UI;
using Godot;

[assembly: IgnoresAccessChecksTo("sts2")]
[assembly: AssemblyCompany("Alchyr")]
[assembly: AssemblyConfiguration("ExportRelease")]
[assembly: AssemblyDescription("Mod for Slay the Spire 2 providing utilities and features for other mods.")]
[assembly: AssemblyFileVersion("3.0.7.0")]
[assembly: AssemblyInformationalVersion("3.0.7+7501a4ce4c5d28144b1041c29d4f564d95c7d71c")]
[assembly: AssemblyProduct("BaseLib")]
[assembly: AssemblyTitle("BaseLib")]
[assembly: AssemblyMetadata("RepositoryUrl", "https://github.com/Alchyr/BaseLib-StS2")]
[assembly: AssemblyHasScripts(new Type[]
{
	typeof(NLogWindow),
	typeof(NConfigButton),
	typeof(NConfigColorPicker),
	typeof(NConfigDropdown),
	typeof(NConfigDropdownItem),
	typeof(NConfigLineEdit),
	typeof(NConfigOptionRow),
	typeof(NConfigSlider),
	typeof(NConfigTickbox),
	typeof(NModConfigSubmenu),
	typeof(NModListButton),
	typeof(NNativeScrollableContainer)
})]
[assembly: AssemblyVersion("3.0.7.0")]
