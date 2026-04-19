using System;
using System.Runtime.CompilerServices;
using Sentry;

namespace MegaCrit.Sts2.Core.Debug;

public static class SentryService
{
	public static extern bool IsEnabled
	{
		[CompilerGenerated]
		get;
	}

	public static extern string SessionId { get; }

	public static extern void Initialize();

	public static extern void SetUserContext(string uniqueId);

	public static extern void SetPlatformBranch(string? branch);

	public static extern void AddBreadcrumb(string message, string category = "app", BreadcrumbLevel level = (BreadcrumbLevel)0);

	public static extern void CaptureException(Exception ex);

	public static extern void CaptureException(Exception ex, Action<Scope> configureScope);

	public static extern void CaptureMessage(string message, SentryLevel level = (SentryLevel)1);

	public static extern void SetTag(string key, string value);

	public static extern void SetExtra(string key, object value);

	public static extern void InitializeForTesting();

	public static extern void Shutdown();
}
