using System;

namespace BaseLib.Config;

/// <summary>
/// <para>Sets up conditional visibility for the marked property (or [ConfigButton] method). You can specify either a
/// property or a method as a target, and optionally specify Invert = true to hide the row if the condition is true.</para>
/// <para>If a property is specified, its value will be compared to the arguments passed to this attribute; if the
/// property value is equal to ANY argument, the row will be visible.<br />
/// For a boolean property, you can leave the arguments out, in which case the row will be visible
/// if the property is equal to true.</para>
/// <para>If you instead specify a method returning bool, the method will be executed, and its return value used to
/// decide the row's visibility.<br />
/// All arguments specified for the attribute will be injected to the method; in addition, you can specify arguments of
/// types <see cref="T:BaseLib.Config.ModConfig" />, <see cref="T:System.Reflection.PropertyInfo" /> (when annotating a property),
/// <see cref="T:System.Reflection.MethodInfo" /> (when annotating a method) and <see cref="T:System.Reflection.MemberInfo" />
/// (to support both with a single method) to inject information about the current row.<br />
/// You can combine these as you wish, e.g. bool MyMethod(PropertyInfo targetProp, int min, int max), and then specify
/// two integer values in the attribute.
/// </para>
/// </summary>
/// <param name="targetName">The property to compare against, or method to call. Use <c>nameof(PropOrMethodName)</c>.</param>
/// <param name="args">Optional arguments: see summary and examples.</param>
/// <example>
/// <b>Targeting a boolean property (argument optional, defaults to true):</b>
/// <code>
/// public static bool EnableCustomMusic { get; set; } = false;
///
/// [ConfigVisibleIf(nameof(EnableCustomMusic))]
/// [ConfigSlider(0, 100)]
/// public static float MusicVolume { get; set; } = 50;
/// </code>
///
/// <b>Targeting a property with multiple allowed arguments:</b>
/// <code>
/// public enum StartingBonusType { None, Tiny, Standard, Huge }
/// public static StartingBonusType StartingBonus { get; set; } = StartingBonusType.Standard;
///
/// // Visible if StartingBonus is Standard or Huge
/// [ConfigVisibleIf(nameof(StartingBonus), StartingBonusType.Standard, StartingBonusType.Huge)]
/// [ConfigSlider(0, 500)]
/// public static int BonusStartingGold { get; set; } = 0;
/// </code>
///
/// <b>Targeting a method with PropertyInfo auto-injection:</b>
/// <code>
/// [ConfigSlider(1, 5)]
/// public static int NumCustomColors { get; set; } = 1;
///
/// private static bool ShouldShowColorRow(PropertyInfo prop)
/// {
///     // Dynamically extract the slot number from property names like "CustomColor2"
///     if (int.TryParse(prop.Name.Replace("CustomColor", ""), out int index))
///         return NumCustomColors &gt;= index;
///     return false;
/// }
///
/// [ConfigVisibleIf(nameof(ShouldShowColorRow))]
/// public static Color CustomColor1 { get; set; }
///
/// [ConfigVisibleIf(nameof(ShouldShowColorRow))]
/// public static Color CustomColor2 { get; set; }
///
/// // ... etc.
/// </code>
///
/// <b>Targeting a method with explicitly injected arguments:</b>
/// <code>
/// [ConfigSlider(1, 5)]
/// public static int EliteCardRewardCount { get; set; } = 1;
///
/// private static bool IsRewardCountBetween(int min, int max)
/// {
///     return EliteCardRewardCount &gt;= min &amp;&amp; EliteCardRewardCount &lt;= max;
/// }
///
/// [ConfigVisibleIf(nameof(IsRewardCountBetween), 2, 5)]
/// public static bool WeightRewardsTowardsRare { get; set; } = false;
/// </code>
/// </example>
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
public class ConfigVisibleIfAttribute(string targetName, params object?[] args) : Attribute
{
	public string TargetName { get; } = targetName;

	public object?[] Args { get; } = args;

	/// <summary>
	/// If true, the visibility condition is inverted.
	/// (e.g., Hidden when the method returns true, or hidden when the property matches).
	/// </summary>
	public bool Invert { get; set; }
}
