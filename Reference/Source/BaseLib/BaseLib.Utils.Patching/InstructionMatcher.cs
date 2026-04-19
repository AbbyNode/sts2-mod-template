using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using BaseLib.Extensions;
using HarmonyLib;

namespace BaseLib.Utils.Patching;

/// <summary>
/// Matches a consecutive list of instructions, requiring a matching opcode and operand.
/// If the operand to check for is null, it will be ignored and only the opcode will need to match.
/// </summary>
public class InstructionMatcher : IMatcher
{
	private class InstructionMatch
	{
		private readonly object? _operand;

		public Func<object?>? OperandFunc { get; set; }

		public Predicate<object?>? OperandMatchPredicate { get; set; }

		public string? StoreOperandKey { get; set; }

		public OpCode[] Opcodes { get; }

		public object? Operand
		{
			get
			{
				return OperandFunc?.Invoke() ?? _operand;
			}
			private init
			{
				_operand = value;
			}
		}

		public InstructionMatch(OpCode opcode, object? operand = null)
		{
			Opcodes = new OpCode[1] { opcode };
			Operand = operand;
		}

		public InstructionMatch(OpCode[] opcodes)
		{
			Opcodes = opcodes;
			Operand = null;
		}

		public bool OperandMatch(CodeInstruction matchTest)
		{
			Predicate<object?>? operandMatchPredicate = OperandMatchPredicate;
			if (operandMatchPredicate == null || operandMatchPredicate(matchTest.operand))
			{
				if (Operand != null && !object.Equals(ComparisonOperand(matchTest), Operand))
				{
					return object.Equals(matchTest.operand, Operand);
				}
				return true;
			}
			return false;
		}

		private object ComparisonOperand(CodeInstruction codeInstruction)
		{
			if (codeInstruction.operand is LocalBuilder localBuilder)
			{
				return localBuilder.LocalIndex;
			}
			return codeInstruction.operand;
		}

		public bool OpcodeMatch(CodeInstruction matchTest)
		{
			return Enumerable.Contains(Opcodes, matchTest.opcode);
		}

		public override string ToString()
		{
			return "[" + Opcodes.AsReadable() + "] " + ((OperandMatchPredicate != null) ? "Operand Predicate" : Operand?.ToString());
		}
	}

	private readonly List<InstructionMatch> _target = new List<InstructionMatch>();

	private readonly Dictionary<string, object?> _operandDict = new Dictionary<string, object>();

	/// <summary>
	/// Matches a consecutive list of instructions, requiring a matching opcode and operand.
	/// If the operand to check for is null, it will be ignored and only the opcode will need to match.
	/// </summary>
	public InstructionMatcher()
	{
	}

	public bool Match(List<string> log, List<CodeInstruction> code, int startIndex, out int matchStart, out int matchEnd)
	{
		log.Add("Starting InstructionMatcher");
		matchStart = startIndex;
		matchEnd = matchStart;
		int num = 0;
		for (int i = startIndex; i < code.Count; i++)
		{
			InstructionMatch instructionMatch = _target[num];
			CodeInstruction val = code[i];
			if (instructionMatch.OpcodeMatch(val))
			{
				if (instructionMatch.OperandMatch(val))
				{
					log.Add($"Instruction match {val}");
					if (instructionMatch.StoreOperandKey != null)
					{
						log.Add($"Stored operand {instructionMatch.StoreOperandKey}:{val.operand}");
						_operandDict[instructionMatch.StoreOperandKey] = val.operand;
					}
					num++;
					if (num >= _target.Count)
					{
						matchEnd = i + 1;
						matchStart = matchEnd - _target.Count;
						return true;
					}
					continue;
				}
				log.Add($"Opcode match but operand mismatch {code[i].opcode} | [{code[i].operand?.GetType() ?? null}]{code[i].operand} vs {_target[num].Operand}");
			}
			if (num > 0)
			{
				log.Add($"Match ended, opcodes do not match ({code[i].opcode}, {_target[num].Opcodes})");
				num = 0;
			}
		}
		return false;
	}

	public override string ToString()
	{
		return "InstructionMatcher:\n" + _target.AsReadable("\n");
	}

	public InstructionMatcher OperandFromStore(string storeKey)
	{
		if (_target.Count == 0)
		{
			throw new InvalidOperationException("Cannot apply stored operand without adding any instructions");
		}
		List<InstructionMatch> target = _target;
		target[target.Count - 1].OperandFunc = () => _operandDict[storeKey];
		return this;
	}

	public InstructionMatcher StoreOperand(string storeKey)
	{
		if (_target.Count == 0)
		{
			throw new InvalidOperationException("Cannot store operand without adding any instructions");
		}
		List<InstructionMatch> target = _target;
		target[target.Count - 1].StoreOperandKey = storeKey;
		return this;
	}

	public InstructionMatcher PredicateMatch(Predicate<object?> operandCondition)
	{
		if (_target.Count == 0)
		{
			throw new InvalidOperationException("Cannot use predicate for operand without adding any instructions");
		}
		List<InstructionMatch> target = _target;
		target[target.Count - 1].OperandMatchPredicate = operandCondition;
		return this;
	}

	public InstructionMatcher opcode(OpCode opCode)
	{
		_target.Add(new InstructionMatch(opCode));
		return this;
	}

	public InstructionMatcher nop()
	{
		_target.Add(new InstructionMatch(OpCodes.Nop));
		return this;
	}

	public InstructionMatcher Break()
	{
		_target.Add(new InstructionMatch(OpCodes.Break));
		return this;
	}

	public InstructionMatcher ldarg_0()
	{
		_target.Add(new InstructionMatch(OpCodes.Ldarg_0));
		return this;
	}

	public InstructionMatcher ldarg_1()
	{
		_target.Add(new InstructionMatch(OpCodes.Ldarg_1));
		return this;
	}

	public InstructionMatcher ldarg_2()
	{
		_target.Add(new InstructionMatch(OpCodes.Ldarg_2));
		return this;
	}

	public InstructionMatcher ldarg_3()
	{
		_target.Add(new InstructionMatch(OpCodes.Ldarg_3));
		return this;
	}

	public InstructionMatcher ldloc_0()
	{
		_target.Add(new InstructionMatch(OpCodes.Ldloc_0));
		return this;
	}

	public InstructionMatcher ldloc_1()
	{
		_target.Add(new InstructionMatch(OpCodes.Ldloc_1));
		return this;
	}

	public InstructionMatcher ldloc_2()
	{
		_target.Add(new InstructionMatch(OpCodes.Ldloc_2));
		return this;
	}

	public InstructionMatcher ldloc_3()
	{
		_target.Add(new InstructionMatch(OpCodes.Ldloc_3));
		return this;
	}

	public InstructionMatcher stloc_any()
	{
		_target.Add(new InstructionMatch(new OpCode[6]
		{
			OpCodes.Stloc,
			OpCodes.Stloc_0,
			OpCodes.Stloc_1,
			OpCodes.Stloc_2,
			OpCodes.Stloc_3,
			OpCodes.Stloc_S
		}));
		return this;
	}

	public InstructionMatcher stloc_0()
	{
		_target.Add(new InstructionMatch(OpCodes.Stloc_0));
		return this;
	}

	public InstructionMatcher stloc_1()
	{
		_target.Add(new InstructionMatch(OpCodes.Stloc_1));
		return this;
	}

	public InstructionMatcher stloc_2()
	{
		_target.Add(new InstructionMatch(OpCodes.Stloc_2));
		return this;
	}

	public InstructionMatcher stloc_3()
	{
		_target.Add(new InstructionMatch(OpCodes.Stloc_3));
		return this;
	}

	public InstructionMatcher ldloc_s(int index)
	{
		_target.Add(new InstructionMatch(OpCodes.Ldloc_S, index));
		return this;
	}

	public InstructionMatcher ldloc_s()
	{
		_target.Add(new InstructionMatch(OpCodes.Ldloc_S));
		return this;
	}

	public InstructionMatcher ldloca_s(int index)
	{
		_target.Add(new InstructionMatch(OpCodes.Ldloca_S, index));
		return this;
	}

	public InstructionMatcher stloc_s(int index)
	{
		_target.Add(new InstructionMatch(OpCodes.Stloc_S, index));
		return this;
	}

	public InstructionMatcher stloc_s()
	{
		_target.Add(new InstructionMatch(OpCodes.Stloc_S));
		return this;
	}

	public InstructionMatcher ldnull()
	{
		_target.Add(new InstructionMatch(OpCodes.Ldnull));
		return this;
	}

	public InstructionMatcher ldc_i4_m1()
	{
		_target.Add(new InstructionMatch(OpCodes.Ldc_I4_M1));
		return this;
	}

	public InstructionMatcher ldc_i4_0()
	{
		_target.Add(new InstructionMatch(OpCodes.Ldc_I4_0));
		return this;
	}

	public InstructionMatcher ldc_i4_1()
	{
		_target.Add(new InstructionMatch(OpCodes.Ldc_I4_1));
		return this;
	}

	public InstructionMatcher ldc_i4_2()
	{
		_target.Add(new InstructionMatch(OpCodes.Ldc_I4_2));
		return this;
	}

	public InstructionMatcher ldc_i4_3()
	{
		_target.Add(new InstructionMatch(OpCodes.Ldc_I4_3));
		return this;
	}

	public InstructionMatcher ldc_i4_4()
	{
		_target.Add(new InstructionMatch(OpCodes.Ldc_I4_4));
		return this;
	}

	public InstructionMatcher ldc_i4_5()
	{
		_target.Add(new InstructionMatch(OpCodes.Ldc_I4_5));
		return this;
	}

	public InstructionMatcher ldc_i4_6()
	{
		_target.Add(new InstructionMatch(OpCodes.Ldc_I4_6));
		return this;
	}

	public InstructionMatcher ldc_i4_7()
	{
		_target.Add(new InstructionMatch(OpCodes.Ldc_I4_7));
		return this;
	}

	public InstructionMatcher ldc_i4_8()
	{
		_target.Add(new InstructionMatch(OpCodes.Ldc_I4_8));
		return this;
	}

	public InstructionMatcher dup()
	{
		_target.Add(new InstructionMatch(OpCodes.Dup));
		return this;
	}

	public InstructionMatcher pop()
	{
		_target.Add(new InstructionMatch(OpCodes.Pop));
		return this;
	}

	public InstructionMatcher call(Type declaringType, string methodName, Type[]? parameters = null, Type[]? generics = null)
	{
		return call(AccessTools.Method(declaringType, methodName, parameters, generics));
	}

	public InstructionMatcher call(MethodInfo? method)
	{
		_target.Add(new InstructionMatch(OpCodes.Call, method));
		return this;
	}

	public InstructionMatcher ret()
	{
		_target.Add(new InstructionMatch(OpCodes.Ret));
		return this;
	}

	public InstructionMatcher br_s(Label label)
	{
		_target.Add(new InstructionMatch(OpCodes.Br_S, label));
		return this;
	}

	public InstructionMatcher br_s()
	{
		_target.Add(new InstructionMatch(OpCodes.Br_S));
		return this;
	}

	public InstructionMatcher brfalse_s(Label label)
	{
		_target.Add(new InstructionMatch(OpCodes.Brfalse_S, label));
		return this;
	}

	public InstructionMatcher brfalse_s()
	{
		_target.Add(new InstructionMatch(OpCodes.Brfalse_S));
		return this;
	}

	public InstructionMatcher brtrue_s(Label label)
	{
		_target.Add(new InstructionMatch(OpCodes.Brtrue_S, label));
		return this;
	}

	public InstructionMatcher brtrue_s()
	{
		_target.Add(new InstructionMatch(OpCodes.Brtrue_S));
		return this;
	}

	public InstructionMatcher beq_s(Label label)
	{
		_target.Add(new InstructionMatch(OpCodes.Beq_S, label));
		return this;
	}

	public InstructionMatcher beq_s()
	{
		_target.Add(new InstructionMatch(OpCodes.Beq_S));
		return this;
	}

	public InstructionMatcher ble_un_s(Label label)
	{
		_target.Add(new InstructionMatch(OpCodes.Ble_Un_S, label));
		return this;
	}

	public InstructionMatcher ble_un_s()
	{
		_target.Add(new InstructionMatch(OpCodes.Ble_Un_S));
		return this;
	}

	public InstructionMatcher br(Label label)
	{
		_target.Add(new InstructionMatch(OpCodes.Br, label));
		return this;
	}

	public InstructionMatcher br()
	{
		_target.Add(new InstructionMatch(OpCodes.Br));
		return this;
	}

	public InstructionMatcher switch_()
	{
		_target.Add(new InstructionMatch(OpCodes.Switch));
		return this;
	}

	public InstructionMatcher add()
	{
		_target.Add(new InstructionMatch(OpCodes.Add));
		return this;
	}

	public InstructionMatcher sub()
	{
		_target.Add(new InstructionMatch(OpCodes.Sub));
		return this;
	}

	public InstructionMatcher mul()
	{
		_target.Add(new InstructionMatch(OpCodes.Mul));
		return this;
	}

	public InstructionMatcher div()
	{
		_target.Add(new InstructionMatch(OpCodes.Div));
		return this;
	}

	public InstructionMatcher callvirt(Type declaringType, string methodName, Type[]? parameters = null, Type[]? generics = null)
	{
		return callvirt(AccessTools.Method(declaringType, methodName, parameters, generics));
	}

	public InstructionMatcher callvirt(MethodInfo? method)
	{
		_target.Add(new InstructionMatch(OpCodes.Callvirt, method));
		return this;
	}

	public InstructionMatcher newobj(ConstructorInfo? constructor)
	{
		_target.Add(new InstructionMatch(OpCodes.Newobj, constructor));
		return this;
	}

	public InstructionMatcher ldfld(Type declaringType, string fieldName)
	{
		return ldfld(AccessTools.Field(declaringType, fieldName));
	}

	public InstructionMatcher ldfld(FieldInfo? field)
	{
		_target.Add(new InstructionMatch(OpCodes.Ldfld, field));
		return this;
	}

	public InstructionMatcher stfld(Type declaringType, string fieldName)
	{
		return stfld(AccessTools.Field(declaringType, fieldName));
	}

	public InstructionMatcher stfld(FieldInfo? field)
	{
		_target.Add(new InstructionMatch(OpCodes.Stfld, field));
		return this;
	}

	public InstructionMatcher stsfld(FieldInfo? field)
	{
		_target.Add(new InstructionMatch(OpCodes.Stsfld, field));
		return this;
	}

	public InstructionMatcher newarr(Type? type)
	{
		_target.Add(new InstructionMatch(OpCodes.Newarr, type));
		return this;
	}

	public InstructionMatcher stelem_ref()
	{
		_target.Add(new InstructionMatch(OpCodes.Stelem_Ref));
		return this;
	}

	public InstructionMatcher unbox_any(object param)
	{
		_target.Add(new InstructionMatch(OpCodes.Unbox_Any, param));
		return this;
	}

	public InstructionMatcher unbox_any()
	{
		_target.Add(new InstructionMatch(OpCodes.Unbox_Any));
		return this;
	}
}
