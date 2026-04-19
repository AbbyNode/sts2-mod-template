using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using BaseLib.BaseLibScenes;
using Godot;
using Godot.Bridge;
using Godot.Collections;
using Godot.NativeInterop;

namespace BaseLib.Patches.Utils;

public class LogListener : Logger
{
	/// <summary>
	/// Cached StringNames for the methods contained in this class, for fast lookup.
	/// </summary>
	public class MethodName : MethodName
	{
		/// <summary>
		/// Cached name for the '_LogMessage' method.
		/// </summary>
		public static readonly StringName _LogMessage = StringName.op_Implicit("_LogMessage");

		/// <summary>
		/// Cached name for the '_LogError' method.
		/// </summary>
		public static readonly StringName _LogError = StringName.op_Implicit("_LogError");
	}

	/// <summary>
	/// Cached StringNames for the properties and fields contained in this class, for fast lookup.
	/// </summary>
	public class PropertyName : PropertyName
	{
	}

	/// <summary>
	/// Cached StringNames for the signals contained in this class, for fast lookup.
	/// </summary>
	public class SignalName : SignalName
	{
	}

	/// <remarks>
	/// Pattern:<br />
	/// <code>^(?:\\[(?&lt;level&gt;VERYDEBUG|LOAD|DEBUG|INFO|WARN|ERROR)\\]|(?&lt;level&gt;VERYDEBUG|LOAD|DEBUG|INFO|WARN(?:ING)?|ERROR)\\b:?)\\s*(?&lt;msg&gt;.*)</code><br />
	/// Options:<br />
	/// <code>RegexOptions.IgnoreCase | RegexOptions.Singleline</code><br />
	/// Explanation:<br />
	/// <code>
	/// ○ Match if at the beginning of the string.<br />
	/// ○ Match with 2 alternative expressions.<br />
	///     ○ Match a sequence of expressions.<br />
	///         ○ Match '['.<br />
	///         ○ "level" capture group.<br />
	///             ○ Match with 6 alternative expressions.<br />
	///                 ○ Match a sequence of expressions.<br />
	///                     ○ Match an empty string.<br />
	///                     ○ Match a character in the set [Ee].<br />
	///                     ○ Match a character in the set [Rr].<br />
	///                     ○ Match a character in the set [Yy].<br />
	///                     ○ Match a character in the set [Dd].<br />
	///                     ○ Match a character in the set [Ee].<br />
	///                     ○ Match a character in the set [Bb].<br />
	///                     ○ Match a character in the set [Uu].<br />
	///                     ○ Match a character in the set [Gg].<br />
	///                 ○ Match a sequence of expressions.<br />
	///                     ○ Match an empty string.<br />
	///                     ○ Match a character in the set [Oo].<br />
	///                     ○ Match a character in the set [Aa].<br />
	///                     ○ Match a character in the set [Dd].<br />
	///                 ○ Match a sequence of expressions.<br />
	///                     ○ Match an empty string.<br />
	///                     ○ Match a character in the set [Ee].<br />
	///                     ○ Match a character in the set [Bb].<br />
	///                     ○ Match a character in the set [Uu].<br />
	///                     ○ Match a character in the set [Gg].<br />
	///                 ○ Match a sequence of expressions.<br />
	///                     ○ Match an empty string.<br />
	///                     ○ Match a character in the set [Nn].<br />
	///                     ○ Match a character in the set [Ff].<br />
	///                     ○ Match a character in the set [Oo].<br />
	///                 ○ Match a sequence of expressions.<br />
	///                     ○ Match an empty string.<br />
	///                     ○ Match a character in the set [Aa].<br />
	///                     ○ Match a character in the set [Rr].<br />
	///                     ○ Match a character in the set [Nn].<br />
	///                 ○ Match a sequence of expressions.<br />
	///                     ○ Match an empty string.<br />
	///                     ○ Match a character in the set [Rr] exactly 2 times.<br />
	///                     ○ Match a character in the set [Oo].<br />
	///                     ○ Match a character in the set [Rr].<br />
	///         ○ Match ']'.<br />
	///     ○ Match a sequence of expressions.<br />
	///         ○ "level" capture group.<br />
	///             ○ Match with 6 alternative expressions.<br />
	///                 ○ Match a sequence of expressions.<br />
	///                     ○ Match a character in the set [Vv].<br />
	///                     ○ Match a character in the set [Ee].<br />
	///                     ○ Match a character in the set [Rr].<br />
	///                     ○ Match a character in the set [Yy].<br />
	///                     ○ Match a character in the set [Dd].<br />
	///                     ○ Match a character in the set [Ee].<br />
	///                     ○ Match a character in the set [Bb].<br />
	///                     ○ Match a character in the set [Uu].<br />
	///                     ○ Match a character in the set [Gg].<br />
	///                 ○ Match a sequence of expressions.<br />
	///                     ○ Match a character in the set [Ll].<br />
	///                     ○ Match a character in the set [Oo].<br />
	///                     ○ Match a character in the set [Aa].<br />
	///                     ○ Match a character in the set [Dd].<br />
	///                 ○ Match a sequence of expressions.<br />
	///                     ○ Match a character in the set [Dd].<br />
	///                     ○ Match a character in the set [Ee].<br />
	///                     ○ Match a character in the set [Bb].<br />
	///                     ○ Match a character in the set [Uu].<br />
	///                     ○ Match a character in the set [Gg].<br />
	///                 ○ Match a sequence of expressions.<br />
	///                     ○ Match a character in the set [Ii].<br />
	///                     ○ Match a character in the set [Nn].<br />
	///                     ○ Match a character in the set [Ff].<br />
	///                     ○ Match a character in the set [Oo].<br />
	///                 ○ Match a sequence of expressions.<br />
	///                     ○ Match a character in the set [Ww].<br />
	///                     ○ Match a character in the set [Aa].<br />
	///                     ○ Match a character in the set [Rr].<br />
	///                     ○ Match a character in the set [Nn].<br />
	///                     ○ Optional (greedy).<br />
	///                         ○ Match a character in the set [Ii].<br />
	///                         ○ Match a character in the set [Nn].<br />
	///                         ○ Match a character in the set [Gg].<br />
	///                 ○ Match a sequence of expressions.<br />
	///                     ○ Match a character in the set [Ee].<br />
	///                     ○ Match a character in the set [Rr] exactly 2 times.<br />
	///                     ○ Match a character in the set [Oo].<br />
	///                     ○ Match a character in the set [Rr].<br />
	///         ○ Match if at a word boundary.<br />
	///         ○ Match ':' greedily, optionally.<br />
	/// ○ Match a whitespace character greedily any number of times.<br />
	/// ○ "msg" capture group.<br />
	///     ○ Match any character atomically any number of times.<br />
	/// </code>
	/// </remarks>
	[GeneratedRegex("^(?:\\[(?<level>VERYDEBUG|LOAD|DEBUG|INFO|WARN|ERROR)\\]|(?<level>VERYDEBUG|LOAD|DEBUG|INFO|WARN(?:ING)?|ERROR)\\b:?)\\s*(?<msg>.*)", RegexOptions.IgnoreCase | RegexOptions.Singleline)]
	[GeneratedCode("System.Text.RegularExpressions.Generator", "9.0.14.6317")]
	private static Regex LogPrefixRegex => _003CRegexGenerator_g_003EF2510F4315406E63A39BEC1503FA28868C36343733B7483E5396C61FEAF06DCCD__LogPrefixRegex_8.Instance;

	public override void _LogMessage(string message, bool error)
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		Match match = LogPrefixRegex.Match(message);
		string text;
		string text2;
		if (error)
		{
			text = "ERROR";
			text2 = (match.Success ? match.Groups["msg"].Value : message);
		}
		else if (match.Success)
		{
			text = match.Groups["level"].Value.ToUpperInvariant();
			if (text == "WARNING")
			{
				text = "WARN";
			}
			text2 = match.Groups["msg"].Value;
		}
		else
		{
			text = "INFO";
			text2 = message;
		}
		NLogWindow.AddLog("[" + text + "] " + text2);
		if (text == "ERROR")
		{
			Callable val = Callable.From((Action)NLogWindow.OpenOnErr);
			((Callable)(ref val)).CallDeferred(Array.Empty<Variant>());
		}
	}

	public override void _LogError(string function, string file, int line, string code, string rationale, bool editorNotify, int errorType, Array<ScriptBacktrace> scriptBacktraces)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		string value = ((object)(ErrorType)errorType/*cast due to .constrained prefix*/).ToString();
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = stringBuilder;
		StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(36, 6, stringBuilder);
		handler.AppendLiteral("[ERROR] Error occurred [");
		handler.AppendFormatted(value);
		handler.AppendLiteral("]: ");
		handler.AppendFormatted(rationale);
		handler.AppendLiteral("\n");
		handler.AppendFormatted(code);
		handler.AppendLiteral("\n");
		handler.AppendFormatted(file);
		handler.AppendLiteral(":");
		handler.AppendFormatted(line);
		handler.AppendLiteral(" @ ");
		handler.AppendFormatted(function);
		handler.AppendLiteral("()\n");
		StringBuilder stringBuilder3 = stringBuilder2.Append(ref handler);
		foreach (ScriptBacktrace scriptBacktrace in scriptBacktraces)
		{
			if (!scriptBacktrace.IsEmpty())
			{
				stringBuilder = stringBuilder3;
				StringBuilder stringBuilder4 = stringBuilder;
				handler = new StringBuilder.AppendInterpolatedStringHandler(0, 1, stringBuilder);
				handler.AppendFormatted(scriptBacktrace.Format(0, 4));
				stringBuilder4.Append(ref handler);
			}
		}
		NLogWindow.AddLog(stringBuilder3.ToString());
		Callable val = Callable.From((Action)NLogWindow.OpenOnErr);
		((Callable)(ref val)).CallDeferred(Array.Empty<Variant>());
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
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		return new List<MethodInfo>(2)
		{
			new MethodInfo(MethodName._LogMessage, new PropertyInfo((Type)0, StringName.op_Implicit(""), (PropertyHint)0, "", (PropertyUsageFlags)6, false), (MethodFlags)1, new List<PropertyInfo>
			{
				new PropertyInfo((Type)4, StringName.op_Implicit("message"), (PropertyHint)0, "", (PropertyUsageFlags)6, false),
				new PropertyInfo((Type)1, StringName.op_Implicit("error"), (PropertyHint)0, "", (PropertyUsageFlags)6, false)
			}, (List<Variant>)null),
			new MethodInfo(MethodName._LogError, new PropertyInfo((Type)0, StringName.op_Implicit(""), (PropertyHint)0, "", (PropertyUsageFlags)6, false), (MethodFlags)1, new List<PropertyInfo>
			{
				new PropertyInfo((Type)4, StringName.op_Implicit("function"), (PropertyHint)0, "", (PropertyUsageFlags)6, false),
				new PropertyInfo((Type)4, StringName.op_Implicit("file"), (PropertyHint)0, "", (PropertyUsageFlags)6, false),
				new PropertyInfo((Type)2, StringName.op_Implicit("line"), (PropertyHint)0, "", (PropertyUsageFlags)6, false),
				new PropertyInfo((Type)4, StringName.op_Implicit("code"), (PropertyHint)0, "", (PropertyUsageFlags)6, false),
				new PropertyInfo((Type)4, StringName.op_Implicit("rationale"), (PropertyHint)0, "", (PropertyUsageFlags)6, false),
				new PropertyInfo((Type)1, StringName.op_Implicit("editorNotify"), (PropertyHint)0, "", (PropertyUsageFlags)6, false),
				new PropertyInfo((Type)2, StringName.op_Implicit("errorType"), (PropertyHint)0, "", (PropertyUsageFlags)6, false),
				new PropertyInfo((Type)28, StringName.op_Implicit("scriptBacktraces"), (PropertyHint)0, "", (PropertyUsageFlags)6, false)
			}, (List<Variant>)null)
		};
	}

	/// <inheritdoc />
	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override bool InvokeGodotClassMethod(in godot_string_name method, NativeVariantPtrArgs args, out godot_variant ret)
	{
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		if ((ref method) == MethodName._LogMessage && ((NativeVariantPtrArgs)(ref args)).Count == 2)
		{
			((Logger)this)._LogMessage(VariantUtils.ConvertTo<string>(ref ((NativeVariantPtrArgs)(ref args))[0]), VariantUtils.ConvertTo<bool>(ref ((NativeVariantPtrArgs)(ref args))[1]));
			ret = default(godot_variant);
			return true;
		}
		if ((ref method) == MethodName._LogError && ((NativeVariantPtrArgs)(ref args)).Count == 8)
		{
			((Logger)this)._LogError(VariantUtils.ConvertTo<string>(ref ((NativeVariantPtrArgs)(ref args))[0]), VariantUtils.ConvertTo<string>(ref ((NativeVariantPtrArgs)(ref args))[1]), VariantUtils.ConvertTo<int>(ref ((NativeVariantPtrArgs)(ref args))[2]), VariantUtils.ConvertTo<string>(ref ((NativeVariantPtrArgs)(ref args))[3]), VariantUtils.ConvertTo<string>(ref ((NativeVariantPtrArgs)(ref args))[4]), VariantUtils.ConvertTo<bool>(ref ((NativeVariantPtrArgs)(ref args))[5]), VariantUtils.ConvertTo<int>(ref ((NativeVariantPtrArgs)(ref args))[6]), VariantUtils.ConvertToArray<ScriptBacktrace>(ref ((NativeVariantPtrArgs)(ref args))[7]));
			ret = default(godot_variant);
			return true;
		}
		return ((Logger)this).InvokeGodotClassMethod(ref method, args, ref ret);
	}

	/// <inheritdoc />
	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override bool HasGodotClassMethod(in godot_string_name method)
	{
		if ((ref method) == MethodName._LogMessage)
		{
			return true;
		}
		if ((ref method) == MethodName._LogError)
		{
			return true;
		}
		return ((Logger)this).HasGodotClassMethod(ref method);
	}

	/// <inheritdoc />
	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override void SaveGodotObjectData(GodotSerializationInfo info)
	{
		((GodotObject)this).SaveGodotObjectData(info);
	}

	/// <inheritdoc />
	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override void RestoreGodotObjectData(GodotSerializationInfo info)
	{
		((GodotObject)this).RestoreGodotObjectData(info);
	}
}
