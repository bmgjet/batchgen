using System;
using System.Windows.Forms;

namespace batchgen
{
	// Token: 0x02000004 RID: 4
	internal static class Program
	{
		// Token: 0x060000C5 RID: 197 RVA: 0x0001E769 File Offset: 0x0001C969
		[global::System.STAThread]
		private static void Main()
		{
			global::System.Windows.Forms.Application.EnableVisualStyles();
			global::System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
			global::System.Windows.Forms.Application.Run(new global::batchgen.Form1());
		}
	}
}
