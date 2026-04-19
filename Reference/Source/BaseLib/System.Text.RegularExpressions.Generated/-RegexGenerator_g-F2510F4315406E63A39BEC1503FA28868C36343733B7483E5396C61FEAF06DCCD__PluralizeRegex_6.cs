using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace System.Text.RegularExpressions.Generated;

[GeneratedCode("System.Text.RegularExpressions.Generator", "9.0.14.6317")]
[SkipLocalsInit]
internal sealed class _003CRegexGenerator_g_003EF2510F4315406E63A39BEC1503FA28868C36343733B7483E5396C61FEAF06DCCD__PluralizeRegex_6 : Regex
{
	private sealed class RunnerFactory : RegexRunnerFactory
	{
		private sealed class Runner : RegexRunner
		{
			protected override void Scan(ReadOnlySpan<char> inputSpan)
			{
				while (TryFindNextPossibleStartingPosition(inputSpan) && !TryMatchAtCurrentPosition(inputSpan) && runtextpos != inputSpan.Length)
				{
					runtextpos++;
					if (_003CRegexGenerator_g_003EF2510F4315406E63A39BEC1503FA28868C36343733B7483E5396C61FEAF06DCCD__Utilities.s_hasTimeout)
					{
						CheckTimeout();
					}
				}
			}

			private bool TryFindNextPossibleStartingPosition(ReadOnlySpan<char> inputSpan)
			{
				int num = runtextpos;
				if (num <= inputSpan.Length - 6)
				{
					int num2 = inputSpan.Slice(num).IndexOf('{');
					if (num2 >= 0)
					{
						runtextpos = num + num2;
						return true;
					}
				}
				runtextpos = inputSpan.Length;
				return false;
			}

			private bool TryMatchAtCurrentPosition(ReadOnlySpan<char> inputSpan)
			{
				int num = runtextpos;
				int start = num;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				int num5 = 0;
				int arg = 0;
				int arg2 = 0;
				int num6 = 0;
				int num7 = 0;
				int num8 = 0;
				int num9 = 0;
				int num10 = 0;
				int num11 = 0;
				int num12 = 0;
				int pos = 0;
				ReadOnlySpan<char> span = inputSpan.Slice(num);
				num2 = num;
				if (span.IsEmpty || span[0] != '{')
				{
					UncaptureUntil(0);
					return false;
				}
				num++;
				span = inputSpan.Slice(num);
				Capture(1, num2, num);
				num3 = num;
				if (span.IsEmpty || span[0] == '{')
				{
					UncaptureUntil(0);
					return false;
				}
				num++;
				span = inputSpan.Slice(num);
				num9 = num;
				while (true)
				{
					num6 = Crawlpos();
					Capture(2, num3, num);
					num4 = num;
					num12 = 0;
					while (true)
					{
						_003CRegexGenerator_g_003EF2510F4315406E63A39BEC1503FA28868C36343733B7483E5396C61FEAF06DCCD__Utilities.StackPush(ref runstack, ref pos, Crawlpos(), num);
						num12++;
						if (!span.IsEmpty && span[0] == ':')
						{
							num++;
							span = inputSpan.Slice(num);
							arg = num;
							int num13 = span.IndexOf('\n');
							if (num13 < 0)
							{
								num13 = span.Length;
							}
							span = span.Slice(num13);
							num += num13;
							arg2 = num;
							goto IL_01cf;
						}
						goto IL_01ef;
						IL_01cf:
						_003CRegexGenerator_g_003EF2510F4315406E63A39BEC1503FA28868C36343733B7483E5396C61FEAF06DCCD__Utilities.StackPush(ref runstack, ref pos, arg, arg2, Crawlpos());
						if (num12 == 0)
						{
							continue;
						}
						goto IL_0244;
						IL_01ef:
						if (--num12 < 0)
						{
							break;
						}
						num = runstack[--pos];
						UncaptureUntil(runstack[--pos]);
						span = inputSpan.Slice(num);
						goto IL_0244;
						IL_0244:
						if (!span.IsEmpty && span[0] == '}')
						{
							num++;
							span = inputSpan.Slice(num);
							num10 = num;
							while (true)
							{
								num7 = Crawlpos();
								Capture(3, num4, num);
								if (!span.IsEmpty && span[0] == '(')
								{
									num++;
									span = inputSpan.Slice(num);
									num5 = num;
									if (!span.IsEmpty && span[0] != '\n')
									{
										num++;
										span = inputSpan.Slice(num);
										num11 = num;
										while (true)
										{
											num8 = Crawlpos();
											Capture(4, num5, num);
											if (span.IsEmpty || span[0] != ')')
											{
												UncaptureUntil(num8);
												if (_003CRegexGenerator_g_003EF2510F4315406E63A39BEC1503FA28868C36343733B7483E5396C61FEAF06DCCD__Utilities.s_hasTimeout)
												{
													CheckTimeout();
												}
												num = num11;
												span = inputSpan.Slice(num);
												if (span.IsEmpty || span[0] == '\n')
												{
													break;
												}
												num++;
												span = inputSpan.Slice(num);
												num11 = span.IndexOfAny('\n', ')');
												if ((uint)num11 >= (uint)span.Length || span[num11] == '\n')
												{
													break;
												}
												num += num11;
												span = inputSpan.Slice(num);
												num11 = num;
												continue;
											}
											Capture(0, start, runtextpos = num + 1);
											return true;
										}
									}
								}
								UncaptureUntil(num7);
								if (_003CRegexGenerator_g_003EF2510F4315406E63A39BEC1503FA28868C36343733B7483E5396C61FEAF06DCCD__Utilities.s_hasTimeout)
								{
									CheckTimeout();
								}
								num = num10;
								span = inputSpan.Slice(num);
								if (span.IsEmpty || span[0] == '\n')
								{
									break;
								}
								num++;
								span = inputSpan.Slice(num);
								num10 = span.IndexOfAny('\n', '(');
								if ((uint)num10 >= (uint)span.Length || span[num10] == '\n')
								{
									break;
								}
								num += num10;
								span = inputSpan.Slice(num);
								num10 = num;
							}
						}
						if (_003CRegexGenerator_g_003EF2510F4315406E63A39BEC1503FA28868C36343733B7483E5396C61FEAF06DCCD__Utilities.s_hasTimeout)
						{
							CheckTimeout();
						}
						if (num12 != 0)
						{
							UncaptureUntil(runstack[--pos]);
							_003CRegexGenerator_g_003EF2510F4315406E63A39BEC1503FA28868C36343733B7483E5396C61FEAF06DCCD__Utilities.StackPop(runstack, ref pos, out arg2, out arg);
							if (_003CRegexGenerator_g_003EF2510F4315406E63A39BEC1503FA28868C36343733B7483E5396C61FEAF06DCCD__Utilities.s_hasTimeout)
							{
								CheckTimeout();
							}
							if (arg < arg2)
							{
								num = --arg2;
								span = inputSpan.Slice(num);
								goto IL_01cf;
							}
							goto IL_01ef;
						}
						break;
					}
					UncaptureUntil(num6);
					if (_003CRegexGenerator_g_003EF2510F4315406E63A39BEC1503FA28868C36343733B7483E5396C61FEAF06DCCD__Utilities.s_hasTimeout)
					{
						CheckTimeout();
					}
					num = num9;
					span = inputSpan.Slice(num);
					if (span.IsEmpty || span[0] == '{')
					{
						break;
					}
					num++;
					span = inputSpan.Slice(num);
					num9 = num;
				}
				UncaptureUntil(0);
				return false;
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				void UncaptureUntil(int capturePosition)
				{
					while (Crawlpos() > capturePosition)
					{
						Uncapture();
					}
				}
			}
		}

		protected override RegexRunner CreateInstance()
		{
			return new Runner();
		}
	}

	internal static readonly _003CRegexGenerator_g_003EF2510F4315406E63A39BEC1503FA28868C36343733B7483E5396C61FEAF06DCCD__PluralizeRegex_6 Instance = new _003CRegexGenerator_g_003EF2510F4315406E63A39BEC1503FA28868C36343733B7483E5396C61FEAF06DCCD__PluralizeRegex_6();

	private _003CRegexGenerator_g_003EF2510F4315406E63A39BEC1503FA28868C36343733B7483E5396C61FEAF06DCCD__PluralizeRegex_6()
	{
		pattern = "({)([^{]+?)((?::.*)?}.*?)\\((.+?)\\)";
		roptions = RegexOptions.None;
		Regex.ValidateMatchTimeout(_003CRegexGenerator_g_003EF2510F4315406E63A39BEC1503FA28868C36343733B7483E5396C61FEAF06DCCD__Utilities.s_defaultTimeout);
		internalMatchTimeout = _003CRegexGenerator_g_003EF2510F4315406E63A39BEC1503FA28868C36343733B7483E5396C61FEAF06DCCD__Utilities.s_defaultTimeout;
		factory = new RunnerFactory();
		capsize = 5;
	}
}
