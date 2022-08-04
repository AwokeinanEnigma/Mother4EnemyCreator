using System;

namespace JetBrains.Annotations
{
	// Token: 0x02000003 RID: 3
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Delegate, AllowMultiple = false, Inherited = true)]
	internal sealed class CanBeNullAttribute : Attribute
	{
	}
}
