using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace batchgen.Properties
{
	// Token: 0x02000006 RID: 6
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
	[CompilerGenerated]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000EA RID: 234 RVA: 0x0001EDF8 File Offset: 0x0001CFF8
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x04000197 RID: 407
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
