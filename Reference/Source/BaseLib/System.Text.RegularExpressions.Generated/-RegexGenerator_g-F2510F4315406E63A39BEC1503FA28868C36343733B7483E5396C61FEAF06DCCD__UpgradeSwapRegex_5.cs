using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace System.Text.RegularExpressions.Generated;

[GeneratedCode("System.Text.RegularExpressions.Generator", "9.0.14.6317")]
[SkipLocalsInit]
internal sealed class _003CRegexGenerator_g_003EF2510F4315406E63A39BEC1503FA28868C36343733B7483E5396C61FEAF06DCCD__UpgradeSwapRegex_5 : Regex
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
				if (num <= inputSpan.Length - 3)
				{
					int num2 = inputSpan.Slice(num).IndexOfAny('+', '-');
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
				int start2 = 0;
				int start3 = 0;
				int capturePosition = 0;
				int capturePosition2 = 0;
				int num5 = 0;
				int num6 = 0;
				int num7 = 0;
				int num8 = 0;
				int num9 = 0;
				int pos = 0;
				int num10 = 0;
				ReadOnlySpan<char> readOnlySpan = inputSpan.Slice(num);
				num4 = num;
				num3 = Crawlpos();
				if (!readOnlySpan.IsEmpty && readOnlySpan[0] == '-')
				{
					num++;
					readOnlySpan = inputSpan.Slice(num);
					start2 = num;
					if (!readOnlySpan.IsEmpty && readOnlySpan[0] != '\n')
					{
						num++;
						readOnlySpan = inputSpan.Slice(num);
						num6 = num;
						goto IL_0128;
					}
				}
				goto IL_016b;
				IL_00a4:
				UncaptureUntil(capturePosition);
				if (_003CRegexGenerator_g_003EF2510F4315406E63A39BEC1503FA28868C36343733B7483E5396C61FEAF06DCCD__Utilities.s_hasTimeout)
				{
					CheckTimeout();
				}
				num = num6;
				readOnlySpan = inputSpan.Slice(num);
				if (!readOnlySpan.IsEmpty && readOnlySpan[0] != '\n')
				{
					num++;
					readOnlySpan = inputSpan.Slice(num);
					num6 = readOnlySpan.IndexOfAny('\n', '-');
					if ((uint)num6 < (uint)readOnlySpan.Length && readOnlySpan[num6] != '\n')
					{
						num += num6;
						readOnlySpan = inputSpan.Slice(num);
						num6 = num;
						goto IL_0128;
					}
				}
				goto IL_016b;
				IL_02ce:
				while (true)
				{
					int num11 = pos;
					num10 = pos;
					num9 = 0;
					while (true)
					{
						_003CRegexGenerator_g_003EF2510F4315406E63A39BEC1503FA28868C36343733B7483E5396C61FEAF06DCCD__Utilities.StackPush(ref runstack, ref pos, Crawlpos(), num);
						num9++;
						if (!readOnlySpan.IsEmpty && readOnlySpan[0] == '+')
						{
							num++;
							readOnlySpan = inputSpan.Slice(num);
							int num12 = num;
							if (!readOnlySpan.IsEmpty && readOnlySpan[0] != '\n')
							{
								num++;
								readOnlySpan = inputSpan.Slice(num);
								num8 = num;
								while (true)
								{
									num5 = Crawlpos();
									_003CRegexGenerator_g_003EF2510F4315406E63A39BEC1503FA28868C36343733B7483E5396C61FEAF06DCCD__Utilities.StackPush(ref runstack, ref pos, num8, num5);
									Capture(3, num12, num);
									_003CRegexGenerator_g_003EF2510F4315406E63A39BEC1503FA28868C36343733B7483E5396C61FEAF06DCCD__Utilities.StackPush(ref runstack, ref pos, num12);
									if (!readOnlySpan.IsEmpty && readOnlySpan[0] == '+')
									{
										break;
									}
									num12 = runstack[--pos];
									_003CRegexGenerator_g_003EF2510F4315406E63A39BEC1503FA28868C36343733B7483E5396C61FEAF06DCCD__Utilities.StackPop(runstack, ref pos, out num5, out num8);
									UncaptureUntil(num5);
									if (_003CRegexGenerator_g_003EF2510F4315406E63A39BEC1503FA28868C36343733B7483E5396C61FEAF06DCCD__Utilities.s_hasTimeout)
									{
										CheckTimeout();
									}
									num = num8;
									readOnlySpan = inputSpan.Slice(num);
									if (!readOnlySpan.IsEmpty && readOnlySpan[0] != '\n')
									{
										num++;
										readOnlySpan = inputSpan.Slice(num);
										num8 = readOnlySpan.IndexOfAny('\n', '+');
										if ((uint)num8 < (uint)readOnlySpan.Length && readOnlySpan[num8] != '\n')
										{
											num += num8;
											readOnlySpan = inputSpan.Slice(num);
											num8 = num;
											continue;
										}
									}
									goto IL_0467;
								}
								num++;
								readOnlySpan = inputSpan.Slice(num);
								if (num9 == 0)
								{
									continue;
								}
								goto IL_04a1;
							}
						}
						goto IL_0467;
						IL_0467:
						if (--num9 < 0)
						{
							break;
						}
						num = runstack[--pos];
						UncaptureUntil(runstack[--pos]);
						readOnlySpan = inputSpan.Slice(num);
						goto IL_04a1;
						IL_04a1:
						pos = num10;
						pos = num11;
						runtextpos = num;
						Capture(0, start, num);
						return true;
					}
					if (_003CRegexGenerator_g_003EF2510F4315406E63A39BEC1503FA28868C36343733B7483E5396C61FEAF06DCCD__Utilities.s_hasTimeout)
					{
						CheckTimeout();
					}
					if (num2 == 0)
					{
						break;
					}
					if (num2 != 1)
					{
						continue;
					}
					goto IL_01e4;
				}
				goto IL_00a4;
				IL_01e4:
				UncaptureUntil(capturePosition2);
				if (_003CRegexGenerator_g_003EF2510F4315406E63A39BEC1503FA28868C36343733B7483E5396C61FEAF06DCCD__Utilities.s_hasTimeout)
				{
					CheckTimeout();
				}
				num = num7;
				readOnlySpan = inputSpan.Slice(num);
				if (readOnlySpan.IsEmpty || readOnlySpan[0] == '\n')
				{
					UncaptureUntil(0);
					return false;
				}
				num++;
				readOnlySpan = inputSpan.Slice(num);
				num7 = readOnlySpan.IndexOfAny('\n', '+');
				if ((uint)num7 >= (uint)readOnlySpan.Length || readOnlySpan[num7] == '\n')
				{
					UncaptureUntil(0);
					return false;
				}
				num += num7;
				readOnlySpan = inputSpan.Slice(num);
				num7 = num;
				goto IL_0274;
				IL_0274:
				capturePosition2 = Crawlpos();
				Capture(2, start3, num);
				if (readOnlySpan.IsEmpty || readOnlySpan[0] != '+')
				{
					goto IL_01e4;
				}
				num2 = 1;
				num++;
				readOnlySpan = inputSpan.Slice(num);
				goto IL_02ce;
				IL_0128:
				capturePosition = Crawlpos();
				Capture(1, start2, num);
				if (readOnlySpan.IsEmpty || readOnlySpan[0] != '-')
				{
					goto IL_00a4;
				}
				num2 = 0;
				num++;
				readOnlySpan = inputSpan.Slice(num);
				goto IL_02ce;
				IL_016b:
				num = num4;
				readOnlySpan = inputSpan.Slice(num);
				UncaptureUntil(num3);
				if (readOnlySpan.IsEmpty || readOnlySpan[0] != '+')
				{
					UncaptureUntil(0);
					return false;
				}
				num++;
				readOnlySpan = inputSpan.Slice(num);
				start3 = num;
				if (readOnlySpan.IsEmpty || readOnlySpan[0] == '\n')
				{
					UncaptureUntil(0);
					return false;
				}
				num++;
				readOnlySpan = inputSpan.Slice(num);
				num7 = num;
				goto IL_0274;
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				void UncaptureUntil(int num13)
				{
					while (Crawlpos() > num13)
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

	internal static readonly _003CRegexGenerator_g_003EF2510F4315406E63A39BEC1503FA28868C36343733B7483E5396C61FEAF06DCCD__UpgradeSwapRegex_5 Instance = new _003CRegexGenerator_g_003EF2510F4315406E63A39BEC1503FA28868C36343733B7483E5396C61FEAF06DCCD__UpgradeSwapRegex_5();

	private _003CRegexGenerator_g_003EF2510F4315406E63A39BEC1503FA28868C36343733B7483E5396C61FEAF06DCCD__UpgradeSwapRegex_5()
	{
		pattern = "(?:(?:-(.+?)-)|(?:\\+(.+?)\\+))(?:\\+(.+?)\\+)?";
		roptions = RegexOptions.None;
		Regex.ValidateMatchTimeout(_003CRegexGenerator_g_003EF2510F4315406E63A39BEC1503FA28868C36343733B7483E5396C61FEAF06DCCD__Utilities.s_defaultTimeout);
		internalMatchTimeout = _003CRegexGenerator_g_003EF2510F4315406E63A39BEC1503FA28868C36343733B7483E5396C61FEAF06DCCD__Utilities.s_defaultTimeout;
		factory = new RunnerFactory();
		capsize = 4;
	}
}
