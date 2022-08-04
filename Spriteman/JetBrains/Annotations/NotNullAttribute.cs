using System;

namespace JetBrains.Annotations
{
	// Token: 0x02000004 RID: 4
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Delegate, AllowMultiple = false, Inherited = true)]
	internal sealed class NotNullAttribute : Attribute
	{
	}
}
