using System.IO;

namespace batchgen
{
	internal static class Program
	{
		[global::System.STAThread]
		private static void Main()
		{
			if (!File.Exists("DotNetZip.dll"))
			{
				File.WriteAllBytes("DotNetZip.dll", RUSS.Properties.Resources.DotNetZip);
			}

			global::System.Windows.Forms.Application.EnableVisualStyles();
			global::System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
			global::System.Windows.Forms.Application.Run(new global::batchgen.Form1());
		}
	}
}
