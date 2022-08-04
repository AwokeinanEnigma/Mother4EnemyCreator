using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Spriteman.Properties
{
	// Token: 0x0200000E RID: 14
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00008176 File Offset: 0x00006376
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x04000083 RID: 131
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
