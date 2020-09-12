using System.IO;
using System.Security.Principal;
using System.Windows.Forms;

namespace batchgen
{
	internal static class Program
	{
		[global::System.STAThread]
		private static void Main()
		{

			if (!IsAdministrator())
			{
				MessageBox.Show("Program needs to be ran as Admin");
				Application.Exit();
				return;
			}

			if (!File.Exists("DotNetZip.dll"))
			{
				File.WriteAllBytes("DotNetZip.dll", RUSS.Properties.Resources.DotNetZip);
			}

			if (!File.Exists("RUSS.exe.config"))
			{
				File.WriteAllText("RUSS.exe.config", RUSS.Properties.Resources.RUSS_exe);
			}

			if (!Directory.Exists("RustServerFiles"))
			{
				Directory.CreateDirectory("RustServerFiles");
			}

			global::System.Windows.Forms.Application.EnableVisualStyles();
			global::System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
			global::System.Windows.Forms.Application.Run(new global::batchgen.Form1());
		}

		public static bool IsAdministrator()
		{
			using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
			{
				WindowsPrincipal principal = new WindowsPrincipal(identity);
				return principal.IsInRole(WindowsBuiltInRole.Administrator);
			}
		}


}
}
