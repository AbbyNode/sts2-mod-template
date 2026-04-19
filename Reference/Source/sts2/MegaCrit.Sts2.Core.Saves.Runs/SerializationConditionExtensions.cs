using System.Reflection;

namespace MegaCrit.Sts2.Core.Saves.Runs;

public static class SerializationConditionExtensions
{
	public static extern bool ShouldSerialize(this SerializationCondition condition, object? candidate, MemberInfo memberInfo);
}
