using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using RUSS.Properties;
using Ionic.Zip;

namespace batchgen
{
	public partial class Form1 : Form
	{
		public string lastModified;
		string MyIP = "127.0.0.1";
		public Form1()
		{
			this.InitializeComponent();
		}

		private static DialogResult ShowInputDialog(ref string input, string title)
		{
			System.Drawing.Size size = new System.Drawing.Size(200, 70);
			Form inputBox = new Form();

			inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			inputBox.ClientSize = size;
			inputBox.Text = title;
			inputBox.StartPosition = FormStartPosition.CenterParent;

			System.Windows.Forms.TextBox textBox = new TextBox();
			textBox.Size = new System.Drawing.Size(size.Width - 10, 23);
			textBox.Location = new System.Drawing.Point(5, 5);
			textBox.Text = input;
			inputBox.Controls.Add(textBox);

			Button okButton = new Button();
			okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			okButton.Name = "okButton";
			okButton.Size = new System.Drawing.Size(75, 23);
			okButton.Text = "&OK";
			okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
			inputBox.Controls.Add(okButton);

			Button cancelButton = new Button();
			cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			cancelButton.Name = "cancelButton";
			cancelButton.Size = new System.Drawing.Size(75, 23);
			cancelButton.Text = "&Cancel";
			cancelButton.Location = new System.Drawing.Point(size.Width - 80, 39);
			inputBox.Controls.Add(cancelButton);

			inputBox.AcceptButton = okButton;
			inputBox.CancelButton = cancelButton;

			DialogResult result = inputBox.ShowDialog();
			input = textBox.Text;
			return result;
		}


		private void genbtn_Click(object sender, EventArgs e)
		{
			Directory.CreateDirectory("RustServerFiles");
			bool flag = this.ServerVarsFinal.Text == "";
			if (flag)
			{
				this.Finaltext.Text = "RustDedicated.exe -batchmode +server.identity " +	@"""" + this.identitytext.Text + @"""" + 	" +server.hostname " + @"""" +	this.servernametext.Text + @""" +server.level ""Procedural Map""" + " +server.seed " + @"""" +	this.mapseedtext.Text + @"""" +	" +server.worldsize " + @"""" +	this.mapsizebox.Text + @"""" + " +server.maxplayers " + this.maxplayertext.Text + @" +rcon.ip " + MyIP + " +rcon.port " + this.rconporttext.Text + " +server.port " + this.serverporttext.Text + " +rcon.password " + @"""" + this.rconpasstext.Text +  @"""" + " +server.description " + @"""" + 	this.serverdisctext.Text + 	@"""" + " +server.url " + @"""" + 	this.serverurltext.Text + @"""" + 	" +server.headerimage " + @"""" + this.serverpicturetext.Text + @"""" +  " -logfile " + @"""" + this.LogLocation.Text +	".log" + @"""";
				
				this.serverdirectorytext.Text = string.Concat(new string[]
				{
					this.currentpath,
					this.slashbox.Text,
					"RustServerFiles",
					this.slashbox.Text,
					"Start Server File ",
					this.identitytext.Text,
					".bat"
				});
				File.WriteAllText(this.serverdirectorytext.Text, this.Finaltext.Text);
				this.infolabel.Text = "Start file generated - Start you server";
			}
			else
			{
				this.Finaltext.Text = this.Finaltext.Text = "RustDedicated.exe -batchmode +server.identity " + @"""" + this.identitytext.Text + @"""" + " +server.hostname " + @"""" + this.servernametext.Text + @""" +server.level ""Procedural Map""" + " +server.seed " + @"""" + this.mapseedtext.Text + @"""" + " +server.worldsize " + @"""" + this.mapsizebox.Text + @"""" + " +server.maxplayers "  + this.maxplayertext.Text + @" +rcon.ip " + MyIP + " +rcon.port " + this.rconporttext.Text + " +server.port " + this.serverporttext.Text + " +rcon.password " + @"""" + this.rconpasstext.Text + @"""" + " +server.description " + @"""" + this.serverdisctext.Text + @"""" + " +server.url " + @"""" + this.serverurltext.Text + @"""" + " +server.headerimage " + @"""" + this.serverpicturetext.Text + @"""" + " " + this.ServerVarsFinal.Text + "-logfile " + @"""" + this.LogLocation.Text + ".log" + @"""";
				
				this.serverdirectorytext.Text = string.Concat(new string[]
				{
					this.currentpath,
					this.slashbox.Text,
					"RustServerFiles",
					this.slashbox.Text,
					"Start Server File ",
					this.identitytext.Text,
					".bat"
				});
				File.WriteAllText(this.serverdirectorytext.Text, this.Finaltext.Text);
				this.infolabel.Text = "Start file generated - Start you server";
			}
		}

		private void DownloadFileAsync(string url, string downloadPath)
		{
			using (WebClient webClient = new WebClient())
			{
				webClient.DownloadProgressChanged += delegate(object sender, DownloadProgressChangedEventArgs e)
				{
					this.DownloadProgress(sender, e, downloadPath);
				};
				webClient.DownloadFileAsync(new Uri(url), downloadPath);
			}
		}

			private void DownloadProgress(object sender, DownloadProgressChangedEventArgs downloadArgs, string downloadPath)
		{
			if (downloadPath != null)
			{
				if (!(downloadPath == "steamcmd.zip"))
				{
					if (downloadPath == "oxide.zip")
					{
						this.progressBar1.Value = downloadArgs.ProgressPercentage;
					}
				}
				else
				{
					this.progressBar1.Value = downloadArgs.ProgressPercentage;
				}
			}
			bool flag = downloadArgs.ProgressPercentage == 100;
			if (flag)
			{
				this.OnDownloadFinished(downloadPath);
			}
		}

		private void OnDownloadFinished(string filePath)
		{
			if (filePath != null)
			{
				if (!(filePath == "steamcmd.zip"))
				{
					if (filePath == "oxide.zip")
					{
						Directory.CreateDirectory("RustServerFiles");
						Form1.UnZipFile(filePath, "RustServerFiles");
						Form1.downloadingOxide = false;
						this.infolabel.Text = "Installed Umod";
					}
				}
				else
				{
					Directory.CreateDirectory("steamcmd");
					Form1.UnZipFile(filePath, "steamcmd");
					this.infolabel.Text = "SteamCMD downloaded - Step 2 next";
					//this.label31.ForeColor = Color.Aqua;
					Directory.CreateDirectory("RustServerFiles");
					File.WriteAllText(this.cmdbatdir.Text, "steamcmd.exe +login anonymous +force_install_dir \"" + this.servfilesdirectory.Text + "\" +app_update 258550 +quit");
					Process.Start(this.CMDDirectorybox.Text, "steamcmd.exe +login anonymous +force_install_dir " + this.servfilesdirectory.Text + " +app_update 258550 +quit");
					this.infolabel.Text = "Downloading Server Files, wait for SteamCMD";
					Process[] processesByName = Process.GetProcessesByName("steamcmd");
					for (int i = 1; i < processesByName.Length; i++)
					{
						processesByName[i].Kill();
					}
					this.checkrun.Enabled = true;
					Form1.downloadingSteamCMD = false;
				}
			}
		}
		private static void UnZipFile(string zipPath, string extractFolder)
		{
			using (ZipFile zipFile = ZipFile.Read(zipPath))
			{
				foreach (ZipEntry zipEntry in zipFile)
				{
					try
					{
						zipEntry.Extract(extractFolder, ExtractExistingFileAction.OverwriteSilently);
					}
                    catch { }
				}
			}
		}

		private readonly Random _random = new Random();
		public int RandomNumber(int min, int max)
		{
			return _random.Next(min, max);
		}

		private void Form1_Load(object sender, EventArgs e)
		{

			string mylocation = Application.ExecutablePath;
			if (mylocation.Contains(" "))
            {
				MessageBox.Show("SteamCMD will have issues if you have spaces in your file path." + Environment.NewLine + mylocation + Environment.NewLine + Environment.NewLine + "Please create a file structure with no spaces!" + Environment.NewLine + "Such as:" + Environment.NewLine + mylocation.Replace(" ", ""));
            }
			this.mapsizebox.Text = (RandomNumber(2, 7) * 500).ToString();
			this.mapseedtext.Text = RandomNumber(1, 10).ToString();

			this.mapPic.ImageLocation = "http://playrust.io/preview.jpg?level=Procedural%20Map&size=" + this.mapsizebox.Text + "&seed=" + this.mapseedtext.Text;
			
			this.serverdirectorytext.Text = string.Concat(new string[]
				{
					this.currentpath,
					this.slashbox.Text,
					"RustServerFiles",
					this.slashbox.Text,
					this.identitytext.Text,
					".bat"
				});
				this.CMDDirectorybox.Text = this.currentpath + this.steamcmdbox.Text + this.slashbox.Text + "steamcmd.exe";
				this.servfilesdirectory.Text = this.currentpath + this.slashbox.Text + "RustServerFiles";
				this.cmdbatdir.Text = this.currentpath + this.steamcmdbox.Text + this.slashbox.Text + "update server.bat";
				this.cmdbatdirstaging.Text = this.currentpath + this.steamcmdbox.Text + this.slashbox.Text + "update staging server.bat";
				this.dedicateddirectory.Text = string.Concat(new string[]
				{
					this.currentpath,
					this.slashbox.Text,
					"RustServerFiles",
					this.slashbox.Text,
					"RustDedicated.exe"
				});
				this.LogLocation.Text = string.Concat(new string[]
				{
					this.currentpath,
					this.slashbox.Text,
					"RustServerFiles",
					this.slashbox.Text,
					"logs"
				});
				this.LockedLbl2.Visible = false;
				this.LockedLbl.Visible = false;
				this.LockedLbl2.Parent = this.ServerVars;
				this.LockedLbl.Parent = this.ServerVars;
				this.PreviewDesc.Parent = this.BannerServer;
				this.serverTitle.Parent = this.BannerServer;
				this.label38.Parent = this.BannerServer;
				this.label42.Parent = this.BannerServer;
				this.mapTypeprev.Parent = this.BannerServer;
				this.MaxPlayersPrev.Parent = this.BannerServer;
				this.FakeMS.Parent = this.BannerServer;

			servernametext.Text = Environment.UserName;
			CMservernametext.Text = Environment.UserName;
			BAservernametext.Text = Environment.UserName;
			CRservernametext.Text = Environment.UserName;
			SAservernametext.Text = Environment.UserName;
			HPservernametext.Text = Environment.UserName;
			KOservernametext.Text = Environment.UserName;
			serverTitle.Text = Environment.UserName;


			PreviewDesc.Text = "Rust Server Created By RUSS V1.0!";
			serverdisctext.Text = PreviewDesc.Text;
			CMserverdisctext.Text = PreviewDesc.Text;
			HPserverdisctext.Text = PreviewDesc.Text;
			BAserverdisctext.Text = PreviewDesc.Text;
			CRserverdisctext.Text = PreviewDesc.Text;
			SAserverdisctext.Text = PreviewDesc.Text;
			KOserverdisctext.Text = PreviewDesc.Text;

			string RandomPassword = RandomNumber(111111, 999999).ToString();

			rconpasstext.Text = RandomPassword;
			CMrconpasstext.Text = RandomPassword;
			HPrconpasstext.Text = RandomPassword;
			BArconpasstext.Text = RandomPassword;
			CRrconpasstext.Text = RandomPassword;
			SArconpasstext.Text = RandomPassword;
			KOrconpasstext.Text = RandomPassword;

			CMserverurltext.Text = "";
			HPserverurltext.Text = CMserverurltext.Text;
			BAserverurltext.Text = CMserverurltext.Text;
			CRserverurltext.Text = CMserverurltext.Text;
			SAserverurltext.Text = CMserverurltext.Text;
			KOserverurltext.Text = CMserverurltext.Text;
			serverurltext.Text = CMserverurltext.Text;



		}

		
		private void button2_Click(object sender, EventArgs e)
		{
			bool flag = this.ServerVarsFinal.Text == "";
			if (flag)
			{

				this.Finaltext.Text = "RustDedicated.exe -batchmode +server.identity " + @"""" + this.CMidentitytext.Text + @"""" + " +server.hostname " + @"""" + this.CMservernametext.Text + @""" +levelurl " + @"""" + this.mapurlbox.Text + @"""" + " +server.maxplayers " + this.CMmaxplayertext.Text + @" +rcon.ip " + MyIP + " +rcon.port " + this.CMrconporttext.Text + " +server.port " + this.CMserverportext.Text + " +rcon.password " + @"""" + this.CMrconpasstext.Text + @"""" + " +server.description " + @"""" + this.CMserverdisctext.Text + @"""" + " +server.url " + @"""" + this.CMserverurltext.Text + @"""" + " +server.headerimage " + @"""" + this.CMserverpicturetext.Text + @"""" + " -logfile " + @"""" + this.LogLocation.Text + ".log" + @"""";
				//this.Finaltext.Text = string.Concat(new string[]
				//{
				//	"RustDedicated.exe -batchmode +server.identity \"",
				//	this.CMidentitytext.Text,
				//	"\" +server.hostname \"",
				//	this.CMservernametext.Text,
				//	"\" +levelurl \"",
				//	this.mapurlbox.Text,
				//	"\" +server.maxplayers ",
				//	this.CMmaxplayertext.Text,
				//	" +rcon.ip 127.0.0.1 +rcon.port ",
				//	this.CMrconporttext.Text,
				//	" +server.port ",
				//	this.CMserverportext.Text,
				//	" +rcon.password \"",
				//	this.CMrconpasstext.Text,
				//	"\" +server.description \"",
				//	this.CMserverdisctext.Text,
				//	"\" +server.url \"",
				//	this.CMserverurltext.Text,
				//	"\" +server.headerimage \"",
				//	this.CMserverpicturetext.Text,
				//	"\" -logfile \"",
				//	this.LogLocation.Text,
				//	".log\""
				//});
				//this.deditextbox.Text = string.Concat(new string[]
				//{
				//	"+server.identity \"",
				//	this.CMidentitytext.Text,
				//	"\" +server.hostname \"",
				//	this.CMservernametext.Text,
				//	"\"  +rcon.ip 127.0.0.1 +rcon.port ",
				//	this.CMrconporttext.Text,
				//	" +rcon.password \"",
				//	this.CMrconpasstext.Text,
				//	"\" +server.description \"",
				//	this.CMserverdisctext.Text,
				//	"\" +server.url \"",
				//	this.CMserverurltext.Text,
				//	"\" +server.headerimage \"",
				//	this.CMserverpicturetext.Text,
				//	"\" -logfile\"",
				//	this.LogLocation.Text,
				//	".log\""
				//});
				this.serverdirectorytext.Text = string.Concat(new string[]
				{
					this.currentpath,
					this.slashbox.Text,
					"RustServerFiles",
					this.slashbox.Text,
					"Start Server File ",
					this.CMidentitytext.Text,
					".bat"
				});
				File.WriteAllText(this.serverdirectorytext.Text, this.Finaltext.Text);
				this.infolabel.Text = "Start file generated - Start you server";
			}
			else
			{
				this.Finaltext.Text = "RustDedicated.exe -batchmode +server.identity " + @"""" + this.CMidentitytext.Text + @"""" + " +server.hostname " + @"""" + this.CMservernametext.Text + @""" +levelurl " + @"""" + this.mapurlbox.Text + @"""" + " +server.maxplayers " + this.CMmaxplayertext.Text + @" +rcon.ip " + MyIP + " +rcon.port " + this.CMrconporttext.Text + " +server.port " + this.CMserverportext.Text + " +rcon.password " + @"""" + this.CMrconpasstext.Text + @"""" + " +server.description " + @"""" + this.CMserverdisctext.Text + @"""" + " +server.url " + @"""" + this.CMserverurltext.Text + @"""" + " +server.headerimage " + @"""" + this.CMserverpicturetext.Text + @""" " + this.ServerVarsFinal.Text +"-logfile " + @"""" + this.LogLocation.Text + ".log" + @"""";
				//this.Finaltext.Text = string.Concat(new string[]
				//{
				//	"RustDedicated.exe -batchmode +server.identity \"",
				//	this.CMidentitytext.Text,
				//	"\" +server.hostname \"",
				//	this.CMservernametext.Text,
				//	"\" +levelurl \"",
				//	this.mapurlbox.Text,
				//	"\" +server.maxplayers ",
				//	this.CMmaxplayertext.Text,
				//	" +rcon.ip 127.0.0.1 +rcon.port ",
				//	this.CMrconporttext.Text,
				//	" +server.port ",
				//	this.CMserverportext.Text,
				//	" +rcon.password \"",
				//	this.CMrconpasstext.Text,
				//	"\" +server.description \"",
				//	this.CMserverdisctext.Text,
				//	"\" +server.url \"",
				//	this.CMserverurltext.Text,
				//	"\" +server.headerimage \"",
				//	this.CMserverpicturetext.Text,
				//	"\" ",
				//	this.ServerVarsFinal.Text,
				//	" -logfile \"",
				//	this.LogLocation.Text,
				//	".log\""
				//});
				//this.deditextbox.Text = string.Concat(new string[]
				//{
				//	"+server.identity \"",
				//	this.CMidentitytext.Text,
				//	"\" +server.hostname \"",
				//	this.CMservernametext.Text,
				//	"\"  +rcon.ip 127.0.0.1 +rcon.port ",
				//	this.CMrconporttext.Text,
				//	" +rcon.password \"",
				//	this.CMrconpasstext.Text,
				//	"\" +server.description \"",
				//	this.CMserverdisctext.Text,
				//	"\" +server.url \"",
				//	this.CMserverurltext.Text,
				//	"\" +server.headerimage \"",
				//	this.CMserverpicturetext.Text,
				//	"\"-logfile\"",
				//	this.LogLocation.Text,
				//	".log\""
				//});
				this.serverdirectorytext.Text = string.Concat(new string[]
				{
					this.currentpath,
					this.slashbox.Text,
					"RustServerFiles",
					this.slashbox.Text,
					"Start Server File ",
					this.CMidentitytext.Text,
					".bat"
				});
				File.WriteAllText(this.serverdirectorytext.Text, this.Finaltext.Text);
				this.infolabel.Text = "Start file generated - Start you server";
			}
		}

	
		private void DownloadSteamCMD_Click(object sender, EventArgs e)
		{
			bool flag = !Form1.downloadingSteamCMD;
			if (flag)
			{
				this.infolabel.Text = "Downloading SteamCMD";
				this.DownloadFileAsync("https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip", "steamcmd.zip");
				Form1.downloadingSteamCMD = true;
			}
		}


		private void DownloadOxide_Click(object sender, EventArgs e)
		{
			bool flag = !Form1.downloadingOxide;
			if (flag)
			{
				this.infolabel.Text = "Downloading Umod";
				this.DownloadFileAsync("https://umod.org/games/rust/download", "Umod.zip");
				Form1.downloadingOxide = true;
			}
		}

		private void downloadserverbtn_Click(object sender, EventArgs e)
		{
			string path = this.currentpath;
			string name = new DirectoryInfo(path).Name;
			bool flag = this.hasspace.Text.Contains(" ");
			if (flag)
			{
				MessageBox.Show("You are Starting USSR! From a folder called: \"" + this.hasspace.Text + "\"\n\nSTEAMCMD cant download the files to the proper folder with a space in the folder name.\n \nPlease remove the space from the folder name, and run te program again. \n \nTed Pommes");
				base.Close();
			}
			else
			{
				MessageBox.Show("No emty");
			}
		}

		
		private void checkrun_Tick(object sender, EventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("steamcmd");
			bool flag = processesByName.Length == 0;
			if (flag)
			{
				this.infolabel.Text = "Download finished.";
				//this.label31.ForeColor = Color.Black;
				//this.label32.ForeColor = Color.Aqua;
				//this.label35.ForeColor = Color.Aqua;
				//this.label41.ForeColor = Color.Aqua;
				//this.label57.ForeColor = Color.Aqua;
				//this.label66.ForeColor = Color.Aqua;
				//this.label82.ForeColor = Color.Aqua;
				//this.label93.ForeColor = Color.Aqua;
				this.checkrun.Enabled = false;
			}
		}

		
		private void timer1_Tick(object sender, EventArgs e)
		{
			updatelog();
		}

		
		//private void openinstallbtn_Click(object sender, EventArgs e)
		//{
		//	Process.Start(this.currentpath + this.slashbox.Text + "steamcmd");
		//}

		
		private void button2_Click_1(object sender, EventArgs e)
		{
			Process process = Process.Start(new ProcessStartInfo("steamcmd")
			{
				UseShellExecute = false,
				RedirectStandardOutput = true,
				CreateNoWindow = true
			});
			process.StandardInput.WriteLine();
			process.StandardInput.WriteLine("exit");
			string text = process.StandardOutput.ReadToEnd();
			this.test.Text = text;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			bool flag = this.ServerVarsFinal.Text == "";
			if (flag)
			{

				this.Finaltext.Text = "RustDedicated.exe -batchmode +server.identity " + @"""" + this.HAidentitytext.Text + @"""" + " +server.hostname " + @"""" + this.HPservernametext.Text + @""" +server.level ""HapisIsland""" + " +server.seed " + @"""" + " +server.maxplayers " + this.HPmaxplayertext.Text + @" +rcon.ip " + MyIP + " +rcon.port " + this.HPrconporttext.Text + " +server.port " + this.HPserverportext.Text + " +rcon.password " + @"""" + this.HPrconpasstext.Text + @"""" + " +server.description " + @"""" + this.HPserverdisctext.Text + @"""" + " +server.url " + @"""" + this.HPserverurltext.Text + @"""" + " +server.headerimage " + @"""" + this.HPserverpicturetext.Text + @"""" + " -logfile " + @"""" + this.LogLocation.Text + ".log" + @"""";

				//this.Finaltext.Text = string.Concat(new string[]
				//{
				//	"RustDedicated.exe -batchmode +server.identity \"",
				//	this.HAidentitytext.Text,
				//	"\" +server.hostname \"",
				//	this.HPservernametext.Text,
				//	"\"+server.level \"HapisIsland\" +server.maxplayers ",
				//	this.HPmaxplayertext.Text,
				//	" +rcon.ip 127.0.0.1 +rcon.port ",
				//	this.HPrconporttext.Text,
				//	" +server.port ",
				//	this.HPserverportext.Text,
				//	" +rcon.password \"",
				//	this.HPrconpasstext.Text,
				//	"\" +server.description \"",
				//	this.HPserverdisctext.Text,
				//	"\" +server.url \"",
				//	this.HPserverurltext.Text,
				//	"\" +server.headerimage \"",
				//	this.HPserverpicturetext.Text,
				//	"\" -logfile \"",
				//	this.LogLocation.Text,
				//	".log\""
				//});
				//this.deditextbox.Text = string.Concat(new string[]
				//{
				//	"+server.identity \"hapis\" +server.hostname \"",
				//	this.HPservernametext.Text,
				//	"\"  +rcon.ip 127.0.0.1 +rcon.port ",
				//	this.HPrconporttext.Text,
				//	" +rcon.password \"",
				//	this.HPrconpasstext.Text,
				//	"\" +server.description \"",
				//	this.HPserverdisctext.Text,
				//	"\" +server.url \"",
				//	this.HPserverurltext.Text,
				//	"\" +server.headerimage \"",
				//	this.HPserverpicturetext.Text,
				//	"\" -logfile\"",
				//	this.LogLocation.Text,
				//	".log\""
				//});
				this.serverdirectorytext.Text = string.Concat(new string[]
				{
					this.currentpath,
					this.slashbox.Text,
					"RustServerFiles",
					this.slashbox.Text,
					"Start Server File ",
					this.HAidentitytext.Text,
					".bat"
				});
				File.WriteAllText(this.serverdirectorytext.Text, this.Finaltext.Text);
				this.infolabel.Text = "Start file generated - Start you server";
			}
			else
			{
				this.Finaltext.Text = "RustDedicated.exe -batchmode +server.identity " + @"""" + this.HAidentitytext.Text + @"""" + " +server.hostname " + @"""" + this.HPservernametext.Text + @""" +server.level ""HapisIsland""" + " +server.seed " + @"""" + " +server.maxplayers " + this.HPmaxplayertext.Text + @" +rcon.ip " + MyIP + " +rcon.port " + this.HPrconporttext.Text + " +server.port " + this.HPserverportext.Text + " +rcon.password " + @"""" + this.HPrconpasstext.Text + @"""" + " +server.description " + @"""" + this.HPserverdisctext.Text + @"""" + " +server.url " + @"""" + this.HPserverurltext.Text + @"""" + " +server.headerimage " + @"""" + this.HPserverpicturetext.Text + @""" " + this.ServerVarsFinal.Text + "-logfile " + @"""" + this.LogLocation.Text + ".log" + @"""";


				//this.Finaltext.Text = string.Concat(new string[]
				//{
				//	"RustDedicated.exe -batchmode +server.identity \"",
				//	this.HAidentitytext.Text,
				//	"\" +server.hostname \"",
				//	this.HPservernametext.Text,
				//	"\"+server.level \"HapisIsland\" +server.maxplayers ",
				//	this.HPmaxplayertext.Text,
				//	" +rcon.ip 127.0.0.1 +rcon.port ",
				//	this.HPrconporttext.Text,
				//	" +server.port ",
				//	this.HPserverportext.Text,
				//	" +rcon.password \"",
				//	this.HPrconpasstext.Text,
				//	"\" +server.description \"",
				//	this.HPserverdisctext.Text,
				//	"\" +server.url \"",
				//	this.HPserverurltext.Text,
				//	"\" +server.headerimage \"",
				//	this.HPserverpicturetext.Text,
				//	"\" ",
				//	this.ServerVarsFinal.Text,
				//	"-logfile \"",
				//	this.LogLocation.Text,
				//	".log\""
				//});
				//this.deditextbox.Text = string.Concat(new string[]
				//{
				//	"+server.identity \"hapis\" +server.hostname \"",
				//	this.HPservernametext.Text,
				//	"\"  +rcon.ip 127.0.0.1 +rcon.port ",
				//	this.HPrconporttext.Text,
				//	" +rcon.password \"",
				//	this.HPrconpasstext.Text,
				//	"\" +server.description \"",
				//	this.HPserverdisctext.Text,
				//	"\" +server.url \"",
				//	this.HPserverurltext.Text,
				//	"\" +server.headerimage \"",
				//	this.HPserverpicturetext.Text,
				//	"\" -logfile\"",
				//	this.LogLocation.Text,
				//	".log\""
				//});
				this.serverdirectorytext.Text = string.Concat(new string[]
				{
					this.currentpath,
					this.slashbox.Text,
					"RustServerFiles",
					this.slashbox.Text,
					"Start Server File ",
					this.HAidentitytext.Text,
					".bat"
				});
				File.WriteAllText(this.serverdirectorytext.Text, this.Finaltext.Text);
				this.infolabel.Text = "Start file generated - Start you server";
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			bool flag = this.ServerVarsFinal.Text == "";
			if (flag)
			{

				this.Finaltext.Text = "RustDedicated.exe -batchmode +server.identity " + @"""" + this.CRidentitytext.Text + @"""" + " +server.hostname " + @"""" + this.CRservernametext.Text + @""" +server.level ""CraggyIsland""" + " +server.seed " + @"""" + " +server.maxplayers " + this.CRmaxplayertext.Text + @" +rcon.ip " + MyIP + " +rcon.port " + this.CRrconporttext.Text + " +server.port " + this.CRserverportext.Text + " +rcon.password " + @"""" + this.CRrconpasstext.Text + @"""" + " +server.description " + @"""" + this.CRserverdisctext.Text + @"""" + " +server.url " + @"""" + this.CRserverurltext.Text + @"""" + " +server.headerimage " + @"""" + this.CRserverpicturetext.Text + @"""" + " -logfile " + @"""" + this.LogLocation.Text + ".log" + @"""";

				//this.Finaltext.Text = string.Concat(new string[]
				//{
				//	"RustDedicated.exe -batchmode +server.identity \"",
				//	this.CRidentitytext.Text,
				//	"\" +server.hostname \"",
				//	this.CRservernametext.Text,
				//	"\" +server.maxplayers ",
				//	this.CRmaxplayertext.Text,
				//	" +server.level \"CraggyIsland\" +rcon.ip 127.0.0.1 +rcon.port ",
				//	this.CRrconporttext.Text,
				//	" +server.port ",
				//	this.CRserverportext.Text,
				//	" +rcon.password \"",
				//	this.CRrconpasstext.Text,
				//	"\" +server.description \"",
				//	this.CRserverdisctext.Text,
				//	"\" +server.url \"",
				//	this.CRserverurltext.Text,
				//	"\" +server.headerimage \"",
				//	this.CRserverpicturetext.Text,
				//	"\" -logfile \"",
				//	this.LogLocation.Text,
				//	".log\""
				//});
				//this.deditextbox.Text = string.Concat(new string[]
				//{
				//	"+server.identity \"craggy\" +server.hostname \"",
				//	this.CRservernametext.Text,
				//	"\"  +rcon.ip 127.0.0.1 +rcon.port ",
				//	this.CRrconporttext.Text,
				//	" +server.level \"CraggyIsland\" +rcon.password ",
				//	this.CRrconpasstext.Text,
				//	" +server.description \"",
				//	this.CRserverdisctext.Text,
				//	"\" +server.url \"",
				//	this.CRserverurltext.Text,
				//	"\" +server.headerimage \"",
				//	this.CRserverpicturetext.Text,
				//	" -logfile\"",
				//	this.LogLocation.Text,
				//	".log\""
				//});
				this.serverdirectorytext.Text = string.Concat(new string[]
				{
					this.currentpath,
					this.slashbox.Text,
					"RustServerFiles",
					this.slashbox.Text,
					"Start Server File ",
					this.CRidentitytext.Text,
					".bat"
				});
				File.WriteAllText(this.serverdirectorytext.Text, this.Finaltext.Text);
				this.infolabel.Text = "Start file generated - Start you server";
			}
			else
			{
				this.Finaltext.Text = "RustDedicated.exe -batchmode +server.identity " + @"""" + this.CRidentitytext.Text + @"""" + " +server.hostname " + @"""" + this.CRservernametext.Text + @""" +server.level ""CraggyIsland""" + " +server.seed " + @"""" + " +server.maxplayers " + this.CRmaxplayertext.Text + @" +rcon.ip " + MyIP + " +rcon.port " + this.CRrconporttext.Text + " +server.port " + this.CRserverportext.Text + " +rcon.password " + @"""" + this.CRrconpasstext.Text + @"""" + " +server.description " + @"""" + this.CRserverdisctext.Text + @"""" + " +server.url " + @"""" + this.CRserverurltext.Text + @"""" + " +server.headerimage " + @"""" + this.CRserverpicturetext.Text + @""" " + this.ServerVarsFinal.Text + "-logfile " + @"""" + this.LogLocation.Text + ".log" + @"""";

				//this.Finaltext.Text = string.Concat(new string[]
				//{
				//	"RustDedicated.exe -batchmode +server.identity \"",
				//	this.CRidentitytext.Text,
				//	"\" +server.hostname \"",
				//	this.CRservernametext.Text,
				//	"\" +server.maxplayers ",
				//	this.CRmaxplayertext.Text,
				//	" +server.level \"CraggyIsland\" +rcon.ip 127.0.0.1 +rcon.port ",
				//	this.CRrconporttext.Text,
				//	" +server.port ",
				//	this.CRserverportext.Text,
				//	" +rcon.password \"",
				//	this.CRrconpasstext.Text,
				//	"\" +server.description \"",
				//	this.CRserverdisctext.Text,
				//	"\" +server.url \"",
				//	this.CRserverurltext.Text,
				//	"\" +server.headerimage \"",
				//	this.CRserverpicturetext.Text,
				//	"\" ",
				//	this.ServerVarsFinal.Text,
				//	"-logfile \"",
				//	this.LogLocation.Text,
				//	".log\""
				//});
				//this.deditextbox.Text = string.Concat(new string[]
				//{
				//	"+server.identity \"craggy\" +server.hostname \"",
				//	this.CRservernametext.Text,
				//	"\"  +rcon.ip 127.0.0.1 +rcon.port ",
				//	this.CRrconporttext.Text,
				//	" +server.level \"CraggyIsland\" +rcon.password ",
				//	this.CRrconpasstext.Text,
				//	" +server.description \"",
				//	this.CRserverdisctext.Text,
				//	"\" +server.url \"",
				//	this.CRserverurltext.Text,
				//	"\" +server.headerimage \"",
				//	this.CRserverpicturetext.Text,
				//	" -logfile\"",
				//	this.LogLocation.Text,
				//	".log\""
				//});
				this.serverdirectorytext.Text = string.Concat(new string[]
				{
					this.currentpath,
					this.slashbox.Text,
					"RustServerFiles",
					this.slashbox.Text,
					"Start Server File ",
					this.CRidentitytext.Text,
					".bat"
				});
				File.WriteAllText(this.serverdirectorytext.Text, this.Finaltext.Text);
				this.infolabel.Text = "Start file generated - Start you server";
			}
		}


		private void playRustIOToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("http://playrust.io/");
		}


		private void button6_Click(object sender, EventArgs e)
		{
			Directory.CreateDirectory("RustServerFiles");
			File.WriteAllText(this.cmdbatdir.Text, "steamcmd.exe +login anonymous +force_install_dir " + this.servfilesdirectory.Text + " +app_update 258550 +quit");
			Process.Start(this.CMDDirectorybox.Text, "steamcmd.exe +login anonymous +force_install_dir " + this.servfilesdirectory.Text + " +app_update 258550 +quit");
			this.infolabel.Text = "Downloading Server Files, wait for SteamCMD";
			Process[] processesByName = Process.GetProcessesByName("steamcmd");
			bool flag = processesByName.Length == 0;
			if (flag)
			{
				Process.Start(this.CMDDirectorybox.Text, "steamcmd.exe +login anonymous +force_install_dir " + this.servfilesdirectory.Text + " +app_update 258550 +quit");
			}
			else
			{
				this.checkrun.Enabled = true;
			}
		}

		
		private void button7_Click(object sender, EventArgs e)
		{
			bool flag = this.ServerVarsFinal.Text == "";
			if (flag)
			{

				this.Finaltext.Text = "RustDedicated.exe -batchmode +server.identity " + @"""" + this.SAidentitytext.Text + @"""" + " +server.hostname " + @"""" + this.SAservernametext.Text + @""" +server.level ""SavasIsland""" + " +server.seed " + @"""" + " +server.maxplayers " + this.SAmaxplayertext.Text + @" +rcon.ip " + MyIP + " +rcon.port " + this.SArconporttext.Text + " +server.port " + this.SAserverportext.Text + " +rcon.password " + @"""" + this.SArconpasstext.Text + @"""" + " +server.description " + @"""" + this.SAserverdisctext.Text + @"""" + " +server.url " + @"""" + this.SAserverurltext.Text + @"""" + " +server.headerimage " + @"""" + this.SAserverpicturetext.Text + @"""" + " -logfile " + @"""" + this.LogLocation.Text + ".log" + @"""";

				//this.Finaltext.Text = string.Concat(new string[]
				//{
				//	"RustDedicated.exe -batchmode +server.identity \"",
				//	this.SAidentitytext.Text,
				//	"\" +server.hostname \"",
				//	this.SAservernametext.Text,
				//	"\" +server.maxplayers ",
				//	this.SAmaxplayertext.Text,
				//	" +server.level \"SavasIsland\" +rcon.ip 127.0.0.1 +rcon.port ",
				//	this.SArconporttext.Text,
				//	" +server.port ",
				//	this.SAserverportext.Text,
				//	" +rcon.password \"",
				//	this.SArconpasstext.Text,
				//	"\" +server.description \"",
				//	this.SAserverdisctext.Text,
				//	"\" +server.url \"",
				//	this.SAserverurltext.Text,
				//	"\" +server.headerimage \"",
				//	this.SAserverpicturetext.Text,
				//	"\" -logfile \"",
				//	this.LogLocation.Text,
				//	".log\""
				//});
				//this.deditextbox.Text = string.Concat(new string[]
				//{
				//	"+server.identity \"SavasIsland\" +server.hostname \"",
				//	this.SAservernametext.Text,
				//	"\"  +rcon.ip 127.0.0.1 +rcon.port ",
				//	this.SArconporttext.Text,
				//	" +server.level \"SavasIsland\" +rcon.password ",
				//	this.SArconpasstext.Text,
				//	" +server.description \"",
				//	this.SAserverdisctext.Text,
				//	"\" +server.url \"",
				//	this.SAserverurltext.Text,
				//	"\" +server.headerimage \"",
				//	this.SAserverpicturetext.Text,
				//	" -logfile\"",
				//	this.LogLocation.Text,
				//	".log\""
				//});
				this.serverdirectorytext.Text = string.Concat(new string[]
				{
					this.currentpath,
					this.slashbox.Text,
					"RustServerFiles",
					this.slashbox.Text,
					"Start Server File ",
					this.SAidentitytext.Text,
					".bat"
				});
				File.WriteAllText(this.serverdirectorytext.Text, this.Finaltext.Text);
				this.infolabel.Text = "Start file generated - Start you server";
			}
			else
			{
				this.Finaltext.Text = "RustDedicated.exe -batchmode +server.identity " + @"""" + this.SAidentitytext.Text + @"""" + " +server.hostname " + @"""" + this.SAservernametext.Text + @""" +server.level ""SavasIsland""" + " +server.seed " + @"""" + " +server.maxplayers " + this.SAmaxplayertext.Text + @" +rcon.ip " + MyIP + " +rcon.port " + this.SArconporttext.Text + " +server.port " + this.SAserverportext.Text + " +rcon.password " + @"""" + this.SArconpasstext.Text + @"""" + " +server.description " + @"""" + this.SAserverdisctext.Text + @"""" + " +server.url " + @"""" + this.SAserverurltext.Text + @"""" + " +server.headerimage " + @"""" + this.SAserverpicturetext.Text + @""" " + this.ServerVarsFinal.Text + "-logfile " + @"""" + this.LogLocation.Text + ".log" + @"""";
				//this.Finaltext.Text = string.Concat(new string[]
				//{
				//	"RustDedicated.exe -batchmode +server.identity \"",
				//	this.SAidentitytext.Text,
				//	"\" +server.hostname \"",
				//	this.SAservernametext.Text,
				//	"\" +server.maxplayers ",
				//	this.SAmaxplayertext.Text,
				//	" +server.level \"SavasIsland\" +rcon.ip 127.0.0.1 +rcon.port ",
				//	this.SArconporttext.Text,
				//	" +server.port ",
				//	this.SAserverportext.Text,
				//	" +rcon.password \"",
				//	this.SArconpasstext.Text,
				//	"\" +server.description \"",
				//	this.SAserverdisctext.Text,
				//	"\" +server.url \"",
				//	this.SAserverurltext.Text,
				//	"\" +server.headerimage \"",
				//	this.SAserverpicturetext.Text,
				//	"\" ",
				//	this.ServerVarsFinal.Text,
				//	"-logfile \"",
				//	this.LogLocation.Text,
				//	".log\""
				//});
				//this.deditextbox.Text = string.Concat(new string[]
				//{
				//	"+server.identity \"SavasIsland\" +server.hostname \"",
				//	this.SAservernametext.Text,
				//	"\"  +rcon.ip 127.0.0.1 +rcon.port ",
				//	this.SArconporttext.Text,
				//	" +server.level \"SavasIsland\" +rcon.password ",
				//	this.SArconpasstext.Text,
				//	" +server.description \"",
				//	this.SAserverdisctext.Text,
				//	"\" +server.url \"",
				//	this.SAserverurltext.Text,
				//	"\" +server.headerimage \"",
				//	this.SAserverpicturetext.Text,
				//	" -logfile\"",
				//	this.LogLocation.Text,
				//	".log\""
				//});
				this.serverdirectorytext.Text = string.Concat(new string[]
				{
					this.currentpath,
					this.slashbox.Text,
					"RustServerFiles",
					this.slashbox.Text,
					"Start Server File ",
					this.SAidentitytext.Text,
					".bat"
				});
				File.WriteAllText(this.serverdirectorytext.Text, this.Finaltext.Text);
				this.infolabel.Text = "Start file generated - Start you server";
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000049B4 File Offset: 0x00002BB4
		private void button8_Click(object sender, EventArgs e)
		{
			bool flag = this.ServerVarsFinal.Text == "";
			if (flag)
			{
				this.Finaltext.Text = "RustDedicated.exe -batchmode +server.identity " + @"""" + this.KOidentitytext.Text + @"""" + " +server.hostname " + @"""" + this.KOservernametext.Text + @""" +server.level ""SavasIsland_koth""" + " +server.seed " + @"""" + " +server.maxplayers " + this.KOmaxplayertext.Text + @" +rcon.ip " + MyIP + " +rcon.port " + this.KOrconporttext.Text + " +server.port " + this.KOserverportext.Text + " +rcon.password " + @"""" + this.KOrconpasstext.Text + @"""" + " +server.description " + @"""" + this.KOserverdisctext.Text + @"""" + " +server.url " + @"""" + this.KOserverurltext.Text + @"""" + " +server.headerimage " + @"""" + this.KOserverpicturetext.Text + @"""" + " -logfile " + @"""" + this.LogLocation.Text + ".log" + @"""";

				//this.Finaltext.Text = string.Concat(new string[]
				//{
				//	"RustDedicated.exe -batchmode +server.identity \"",
				//	this.KOidentitytext.Text,
				//	"\" +server.hostname \"",
				//	this.KOservernametext.Text,
				//	"\" +server.maxplayers ",
				//	this.KOmaxplayertext.Text,
				//	" +server.level \"SavasIsland_koth\" +rcon.ip 127.0.0.1 +rcon.port ",
				//	this.KOrconporttext.Text,
				//	" +server.port ",
				//	this.KOserverportext.Text,
				//	" +rcon.password \"",
				//	this.KOrconpasstext.Text,
				//	"\" +server.description \"",
				//	this.KOserverdisctext.Text,
				//	"\" +server.url \"",
				//	this.KOserverurltext.Text,
				//	"\" +server.headerimage \"",
				//	this.KOserverpicturetext.Text,
				//	"\" -logfile \"",
				//	this.LogLocation.Text,
				//	".log\""
				//});
				//this.deditextbox.Text = string.Concat(new string[]
				//{
				//	"+server.identity \"SavasIsland_koth\" +server.hostname \"",
				//	this.KOservernametext.Text,
				//	"\"  +rcon.ip 127.0.0.1 +rcon.port ",
				//	this.KOrconporttext.Text,
				//	" +server.level \"SavasIsland_koth\" +rcon.password ",
				//	this.KOrconpasstext.Text,
				//	" +server.description \"",
				//	this.KOserverdisctext.Text,
				//	"\" +server.url \"",
				//	this.KOserverurltext.Text,
				//	"\" +server.headerimage \"",
				//	this.KOserverpicturetext.Text,
				//	" -logfile\"",
				//	this.LogLocation.Text,
				//	".log\""
				//});
				this.serverdirectorytext.Text = string.Concat(new string[]
				{
					this.currentpath,
					this.slashbox.Text,
					"RustServerFiles",
					this.slashbox.Text,
					"Start Server File ",
					this.KOidentitytext.Text,
					".bat"
				});
				File.WriteAllText(this.serverdirectorytext.Text, this.Finaltext.Text);
				this.infolabel.Text = "Start file generated - Start you server";
			}
			else
			{
				this.Finaltext.Text = "RustDedicated.exe -batchmode +server.identity " + @"""" + this.KOidentitytext.Text + @"""" + " +server.hostname " + @"""" + this.KOservernametext.Text + @""" +server.level ""SavasIsland_koth""" + " +server.seed " + @"""" + " +server.maxplayers " + this.KOmaxplayertext.Text + @" +rcon.ip " + MyIP + " +rcon.port " + this.KOrconporttext.Text + " +server.port " + this.KOserverportext.Text + " +rcon.password " + @"""" + this.KOrconpasstext.Text + @"""" + " +server.description " + @"""" + this.KOserverdisctext.Text + @"""" + " +server.url " + @"""" + this.KOserverurltext.Text + @"""" + " +server.headerimage " + @"""" + this.KOserverpicturetext.Text + @""" " + this.ServerVarsFinal.Text + "-logfile " + @"""" + this.LogLocation.Text + ".log" + @"""";

				//this.Finaltext.Text = string.Concat(new string[]
				//{
				//	"RustDedicated.exe -batchmode +server.identity \"",
				//	this.KOidentitytext.Text,
				//	"\" +server.hostname \"",
				//	this.KOservernametext.Text,
				//	"\" +server.maxplayers ",
				//	this.KOmaxplayertext.Text,
				//	" +server.level \"SavasIsland_koth\" +rcon.ip 127.0.0.1 +rcon.port ",
				//	this.KOrconporttext.Text,
				//	" +server.port ",
				//	this.KOserverportext.Text,
				//	" +rcon.password \"",
				//	this.KOrconpasstext.Text,
				//	"\" +server.description \"",
				//	this.KOserverdisctext.Text,
				//	"\" +server.url \"",
				//	this.KOserverurltext.Text,
				//	"\" +server.headerimage \"",
				//	this.KOserverpicturetext.Text,
				//	"\" ",
				//	this.ServerVarsFinal.Text,
				//	"-logfile \"",
				//	this.LogLocation.Text,
				//	".log\""
				//});
				//this.deditextbox.Text = string.Concat(new string[]
				//{
				//	"+server.identity \"SavasIsland_koth\" +server.hostname \"",
				//	this.KOservernametext.Text,
				//	"\"  +rcon.ip 127.0.0.1 +rcon.port ",
				//	this.KOrconporttext.Text,
				//	" +server.level \"SavasIsland_koth\" +rcon.password ",
				//	this.KOrconpasstext.Text,
				//	" +server.description \"",
				//	this.KOserverdisctext.Text,
				//	"\" +server.url \"",
				//	this.KOserverurltext.Text,
				//	"\" +server.headerimage \"",
				//	this.KOserverpicturetext.Text,
				//	" -logfile\"",
				//	this.LogLocation.Text,
				//	".log\""
				//});
				this.serverdirectorytext.Text = string.Concat(new string[]
				{
					this.currentpath,
					this.slashbox.Text,
					"RustServerFiles",
					this.slashbox.Text,
					"Start Server File ",
					this.KOidentitytext.Text,
					".bat"
				});
				File.WriteAllText(this.serverdirectorytext.Text, this.Finaltext.Text);
				this.infolabel.Text = "Start file generated - Start you server";
			}
		}

		private void fullHostingTutorialsPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("http://bit.ly/2OIfNGi");
		}

		private void rustAdminToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("http://bit.ly/2TjpsBV");
		}

		private void rustServerManagerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("http://bit.ly/33igRnv");
		}


		private void rustEditToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("http://bit.ly/2ZJn5e2");
		}


		private void steamCMDToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("http://bit.ly/2KGuqVA");
		}


		private void playRustcomToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("http://bit.ly/2MYacJJ");
		}


		private void battleMetricsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("http://bit.ly/2YSufvh");
		}


		private void corrosionHourToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("http://bit.ly/2ZMdoM2");
		}


		private void rustopiaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("http://bit.ly/2OLylp4");
		}


		private void umodToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("http://bit.ly/2M5CYZf");
		}


		private void chaoscodeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("http://bit.ly/2Kp8ZJF");
		}

		private void howToHostYourOwnRustServerManuallyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("http://bit.ly/2KyDUlp");
		}

		private void howToInstallOxideWorkWithPluginsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("http://bit.ly/2OMn6wD");
		}

		private void howToPortForwardToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("http://bit.ly/31vlyZl");
		}

		private void chooseAMapToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("http://bit.ly/2TkrxgP");
		}


		private void mainSiteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("http://bit.ly/2OKbSc1");
		}


		private void browseFreePluginsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("http://bit.ly/2KnC1sT");
		}

		private void downloadOxideToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("http://bit.ly/2M5CYZf");
		}

		private void fortifyCreateAndDesignBaseCanBeCopiedFromOrPastedIntoRustToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("http://bit.ly/2Kouydc");
		}


		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void button10_Click(object sender, EventArgs e)
		{
			Process.Start(new ProcessStartInfo(this.serverdirectorytext.Text)
			{
				WorkingDirectory = this.currentpath + "\\RustServerFiles"
			});
		}


		private void rustLabsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("http://bit.ly/31tuHBT");
		}


		private void howToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("http://bit.ly/2GVKEJ3");
		}


		private void httpswwwrustafiedcomhowtohostarustserverinlinuxToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("http://bit.ly/2ThAqrv");
		}


		private void hostARUSTDedicatedServerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("http://bit.ly/2MNkMTC");
		}


		private void populateYourRUSTServerWithThese6TipsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("http://bit.ly/2YUYqpD");
		}


		private void howToCreateAPrivateRUSTServerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("http://bit.ly/33i6a4B");
		}


		private void howToInstallUModOxideToARUSTServerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("http://bit.ly/2YSD9cj");
		}

		private void rUSTServerPerformanceHintsAndTipsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("http://bit.ly/2KlHJLX");
		}


		private void mostBeginnerMistakesQuestionsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("http://bit.ly/2MNMxv9");
		}


		private void servernametext_TextChanged(object sender, EventArgs e)
		{
			this.serverTitle.Text = this.servernametext.Text;
		}

		
		private void BtnStart_Click(object sender, EventArgs e)
		{

			if (BtnStart.Text == "START")
			{
				try
				{
					string fileName = this.StartFileList.Items[this.StartFileList.SelectedIndex].ToString();
					Process.Start(new ProcessStartInfo(fileName)
					{
						WorkingDirectory = this.currentpath + "\\RustServerFiles"
					});
					this.infolabel.Text = "Server Started";
					StartFileList.Enabled = false;
					serverup.Enabled = true;
					BtnStart.Enabled = false;
				}
				catch
				{
				}
			}
			else
            {
				try
				{
					BtnStart.Enabled = false;
					Process[] proc = Process.GetProcessesByName("RustDedicated");
					proc[0].Kill();
				}
				catch
				{ }
			}
        }

		
		private void BtnRefreshbrowser_Click(object sender, EventArgs e)
		{
			this.BannerServer.ImageLocation = this.serverpicturetext.Text;
			this.serverTitle.Parent = this.BannerServer;
			this.label38.Parent = this.BannerServer;
			this.label42.Parent = this.BannerServer;
			this.mapTypeprev.Parent = this.BannerServer;
			this.MaxPlayersPrev.Parent = this.BannerServer;
			this.FakeMS.Parent = this.BannerServer;
			this.BannerServer.SendToBack();
			this.PreviewPic.SendToBack();
			this.serverTitle.BringToFront();
			bool flag = this.da.SelectedTab == this.da.TabPages["procgen"];
			if (flag)
			{
				this.mapPic.ImageLocation = "http://playrust.io/preview.jpg?level=Procedural%20Map&size=" + this.mapsizebox.Text + "&seed=" + this.mapseedtext.Text;
				this.mapinfolab.Text = "ProcGen Map";
			}
			else
			{
				bool flag2 = this.da.SelectedTab == this.da.TabPages["Hapis"];
				if (flag2)
				{
					this.mapPic.ImageLocation = "https://vignette.wikia.nocookie.net/play-rust/images/4/47/HapisIsland.jpg/revision/latest/scale-to-width-down/180?cb=20150910033411";
					this.mapinfolab.Text = "Hapis Island";
				}
				else
				{
					bool flag3 = this.da.SelectedTab == this.da.TabPages["SAVAS"];
					if (flag3)
					{
						this.mapPic.ImageLocation = "https://vignette.wikia.nocookie.net/play-rust/images/6/64/Savas_Island_diagram.jpg/revision/latest/scale-to-width-down/310?cb=20151001214728";
						this.mapinfolab.Text = "Savas Island";
					}
					else
					{
						bool flag4 = this.da.SelectedTab == this.da.TabPages["KOTH"];
						if (flag4)
						{
							this.mapPic.ImageLocation = "https://vignette.wikia.nocookie.net/play-rust/images/6/64/Savas_Island_diagram.jpg/revision/latest/scale-to-width-down/310?cb=20151001214728";
							this.mapinfolab.Text = "Savas King Of The Hill";
						}
						else
						{
							bool flag5 = this.da.SelectedTab == this.da.TabPages["BARREN"];
							if (flag5)
							{
								this.mapPic.ImageLocation = "http://playrust.io/preview.jpg?level=Barren&size=" + this.BAmapsizebox.Text + "&seed=" + this.BAmapseedtext.Text;
								this.mapinfolab.Text = "Barren ProcGen";
							}
							else
							{
								bool flag6 = this.da.SelectedTab == this.da.TabPages["custom"];
								if (flag6)
								{
									this.mapPic.ImageLocation = "https://user-images.githubusercontent.com/24848110/33519396-7e56363c-d79d-11e7-969b-09782f5ccbab.png";
									this.mapinfolab.Text = "Custom Map Preview Not Supported";
								}
								else
								{
									bool flag7 = this.da.SelectedTab == this.da.TabPages["CRAGGY"];
									if (flag7)
									{
										this.mapPic.ImageLocation = "https://i.imgur.com/rSYtxoR.jpg";
										this.mapinfolab.Text = "Craggy Island";
									}
								}
							}
						}
					}
				}
			}
		}

		private void Button11_Click(object sender, EventArgs e)
		{
			Directory.CreateDirectory("RustServerFiles");
			File.WriteAllText(this.cmdbatdir.Text, "steamcmd.exe +login anonymous +force_install_dir " + this.servfilesdirectory.Text + " +app_update 258550 +quit");
			Process process = Process.Start(new ProcessStartInfo(this.CMDDirectorybox.Text, "+login anonymous +force_install_dir " + this.servfilesdirectory.Text + " +app_update 258550 +quit")
			{
				UseShellExecute = false,
				RedirectStandardOutput = true
			});
			Process[] processesByName = Process.GetProcessesByName("steamcmd");
			bool flag = processesByName.Length == 0;
			if (flag)
			{
				Process.Start(this.CMDDirectorybox.Text, "steamcmd.exe +login anonymous +force_install_dir " + this.servfilesdirectory.Text + " +app_update 258550 +quit");
			}
			else
			{
				this.checkrun.Enabled = true;
			}
			string text = process.StandardOutput.ReadToEnd();
			this.textBox1.Text = text;
		}

		
		private void RefreshSmall_Click(object sender, EventArgs e)
		{
			bool flag = this.da.SelectedTab == this.da.TabPages["procgen"];
			if (flag)
			{
				this.mapPic.ImageLocation = "http://playrust.io/preview.jpg?level=Procedural%20Map&size=" + this.mapsizebox.Text + "&seed=" + this.mapseedtext.Text;
				this.mapinfolab.Text = "ProcGen Map";
			}
			else
			{
				bool flag2 = this.da.SelectedTab == this.da.TabPages["Hapis"];
				if (flag2)
				{
					this.mapPic.ImageLocation = "https://vignette.wikia.nocookie.net/play-rust/images/4/47/HapisIsland.jpg/revision/latest/scale-to-width-down/180?cb=20150910033411";
					this.mapinfolab.Text = "Hapis Island";
				}
				else
				{
					bool flag3 = this.da.SelectedTab == this.da.TabPages["SAVAS"];
					if (flag3)
					{
						this.mapPic.ImageLocation = "https://vignette.wikia.nocookie.net/play-rust/images/6/64/Savas_Island_diagram.jpg/revision/latest/scale-to-width-down/310?cb=20151001214728";
						this.mapinfolab.Text = "Savas Island";
					}
					else
					{
						bool flag4 = this.da.SelectedTab == this.da.TabPages["KOTH"];
						if (flag4)
						{
							this.mapPic.ImageLocation = "https://vignette.wikia.nocookie.net/play-rust/images/6/64/Savas_Island_diagram.jpg/revision/latest/scale-to-width-down/310?cb=20151001214728";
							this.mapinfolab.Text = "Savas King Of The Hill";
						}
						else
						{
							bool flag5 = this.da.SelectedTab == this.da.TabPages["BARREN"];
							if (flag5)
							{
								this.mapPic.ImageLocation = "http://playrust.io/preview.jpg?level=Barren&size=" + this.BAmapsizebox.Text + "&seed=" + this.BAmapseedtext.Text;
								this.mapinfolab.Text = "Barren ProcGen";
							}
							else
							{
								bool flag6 = this.da.SelectedTab == this.da.TabPages["custom"];
								if (flag6)
								{
									this.mapPic.ImageLocation = "https://user-images.githubusercontent.com/24848110/33519396-7e56363c-d79d-11e7-969b-09782f5ccbab.png";
									this.mapinfolab.Text = "Custom Map Preview Not Supported";
								}
								else
								{
									bool flag7 = this.da.SelectedTab == this.da.TabPages["CRAGGY"];
									if (flag7)
									{
										this.mapPic.ImageLocation = "https://i.imgur.com/rSYtxoR.jpg";
										this.mapinfolab.Text = "Craggy Island";
									}
								}
							}
						}
					}
				}
			}
		}


		//private void TryToolStripMenuItem_Click(object sender, EventArgs e)
		//{
		//	bool flag = !Form1.downloadingOxide;
		//	if (flag)
		//	{
		//		this.infolabel.Text = "Downloading Umod";
		//		this.DownloadFileAsync("https://umod.org/games/rust/download", "oxide.zip");
		//		Form1.downloadingOxide = true;
		//	}
		//}

		
		private void DownloadInstallToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = !Form1.downloadingOxide;
			if (flag)
			{
				this.infolabel.Text = "Downloading Umod";
				this.DownloadFileAsync("https://umod.org/games/rust/download", "oxide.zip");
				Form1.downloadingOxide = true;
			}
		}

		
		private void UpdateFIleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start(this.currentpath + this.slashbox.Text + "steamcmd");
		}

		
		private void StartFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("Explorer.exe", this.servfilesdirectory.Text);
		}


		private void UpdateServerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Directory.CreateDirectory("RustServerFiles");
			File.WriteAllText(this.cmdbatdir.Text, "steamcmd.exe +login anonymous +force_install_dir " + this.servfilesdirectory.Text + " +app_update 258550 +quit");
			Process.Start(this.CMDDirectorybox.Text, "steamcmd.exe +login anonymous +force_install_dir " + this.servfilesdirectory.Text + " +app_update 258550 +quit");
			this.infolabel.Text = "Downloading Server Files, wait for SteamCMD";
			Process[] processesByName = Process.GetProcessesByName("steamcmd");
			bool flag = processesByName.Length == 0;
			if (flag)
			{
				Process.Start(this.CMDDirectorybox.Text, "steamcmd.exe +login anonymous +force_install_dir " + this.servfilesdirectory.Text + " +app_update 258550 +quit");
			}
			else
			{
				this.checkrun.Enabled = true;
			}
		}

		
		private void Button6_Click_1(object sender, EventArgs e)
		{
			bool flag = this.SearchVar.Text == "aithinkmanager.framebudgetms";
			if (flag)
			{
				this.varvar.Text = "aithinkmanager.framebudgetms";
				this.varvalue.Text = "2.5";
			}
			else
			{
				bool flag2 = this.SearchVar.Text == "generate_paths";
				if (flag2)
				{
					this.varvar.Text = "generate_paths";
					this.varvalue.Text = "True";
				}
				else
				{
					bool flag3 = this.SearchVar.Text == "decayminutes";
					if (flag3)
					{
						this.varvar.Text = "decayminutes";
						this.varvalue.Text = "180";
					}
					else
					{
						bool flag4 = this.SearchVar.Text == "bear.population";
						if (flag4)
						{
							this.varvar.Text = "bear.population";
							this.varvalue.Text = "2";
						}
						else
						{
							bool flag5 = this.SearchVar.Text == "spinfrequencyseconds";
							if (flag5)
							{
								this.varvar.Text = "spinfrequencyseconds";
								this.varvalue.Text = "45";
							}
							else
							{
								bool flag6 = this.SearchVar.Text == "boar.population";
								if (flag6)
								{
									this.varvar.Text = "boar.population";
									this.varvalue.Text = "5";
								}
								else
								{
									bool flag7 = this.SearchVar.Text == "egress_duration_minutes";
									if (flag7)
									{
										this.varvar.Text = "egress_duration_minutes";
										this.varvalue.Text = "10";
									}
									else
									{
										bool flag8 = this.SearchVar.Text == "event_duration_minutes";
										if (flag8)
										{
											this.varvar.Text = "event_duration_minutes";
											this.varvalue.Text = "50";
										}
										else
										{
											bool flag9 = this.SearchVar.Text == "event_enabled";
											if (flag9)
											{
												this.varvar.Text = "event_enabled";
												this.varvalue.Text = "True";
											}
											else
											{
												bool flag10 = this.SearchVar.Text == "loot_round_spacing_minutes";
												if (flag10)
												{
													this.varvar.Text = "loot_round_spacing_minutes";
													this.varvalue.Text = "10";
												}
												else
												{
													bool flag11 = this.SearchVar.Text == "loot_rounds";
													if (flag11)
													{
														this.varvar.Text = "loot_rounds";
														this.varvalue.Text = "3";
													}
													else
													{
														bool flag12 = this.SearchVar.Text == "chicken.population";
														if (flag12)
														{
															this.varvar.Text = "chicken.population";
															this.varvalue.Text = "3";
														}
														else
														{
															bool flag13 = this.SearchVar.Text == "clothloddist";
															if (flag13)
															{
																this.varvar.Text = "clothloddist";
																this.varvalue.Text = "20";
															}
															else
															{
																bool flag14 = this.SearchVar.Text == "nav_carve_height";
																if (flag14)
																{
																	this.varvar.Text = "nav_carve_height";
																	this.varvalue.Text = "2";
																}
																else
																{
																	bool flag15 = this.SearchVar.Text == "nav_carve_min_base_size";
																	if (flag15)
																	{
																		this.varvar.Text = "nav_carve_min_base_size";
																		this.varvalue.Text = "2";
																	}
																	else
																	{
																		bool flag16 = this.SearchVar.Text == "nav_carve_min_building_blocks_to_apply_optimization";
																		if (flag16)
																		{
																			this.varvar.Text = "nav_carve_min_building_blocks_to_apply_optimization";
																			this.varvalue.Text = "25";
																		}
																		else
																		{
																			bool flag17 = this.SearchVar.Text == "nav_carve_size_multiplier";
																			if (flag17)
																			{
																				this.varvar.Text = "nav_carve_size_multiplier";
																				this.varvalue.Text = "4";
																			}
																			else
																			{
																				bool flag18 = this.SearchVar.Text == "nav_carve_use_building_optimization";
																				if (flag18)
																				{
																					this.varvar.Text = "nav_carve_use_building_optimization";
																					this.varvalue.Text = "False";
																				}
																				else
																				{
																					bool flag19 = this.SearchVar.Text == "npc_alertness_drain_rate";
																					if (flag19)
																					{
																						this.varvar.Text = "npc_alertness_drain_rate";
																						this.varvalue.Text = "0.01";
																					}
																					else
																					{
																						bool flag20 = this.SearchVar.Text == "npc_alertness_to_aim_modifier";
																						if (flag20)
																						{
																							this.varvar.Text = "npc_alertness_to_aim_modifier";
																							this.varvalue.Text = "0.5";
																						}
																						else
																						{
																							bool flag21 = this.SearchVar.Text == "npc_alertness_zero_detection_mod";
																							if (flag21)
																							{
																								this.varvar.Text = "npc_alertness_zero_detection_mod";
																								this.varvalue.Text = "0.5";
																							}
																							else
																							{
																								bool flag22 = this.SearchVar.Text == "npc_cover_compromised_cooldown";
																								if (flag22)
																								{
																									this.varvar.Text = "npc_cover_compromised_cooldown";
																									this.varvalue.Text = "10";
																								}
																								else
																								{
																									bool flag23 = this.SearchVar.Text == "npc_cover_info_tick_rate_multiplier";
																									if (flag23)
																									{
																										this.varvar.Text = "npc_cover_info_tick_rate_multiplier";
																										this.varvalue.Text = "20";
																									}
																									else
																									{
																										bool flag24 = this.SearchVar.Text == "npc_cover_path_vs_straight_dist_max_diff";
																										if (flag24)
																										{
																											this.varvar.Text = "npc_cover_path_vs_straight_dist_max_diff";
																											this.varvalue.Text = "2";
																										}
																										else
																										{
																											bool flag25 = this.SearchVar.Text == "npc_cover_use_path_distance";
																											if (flag25)
																											{
																												this.varvar.Text = "npc_cover_use_path_distance";
																												this.varvalue.Text = "True";
																											}
																											else
																											{
																												bool flag26 = this.SearchVar.Text == "npc_deliberate_hit_randomizer";
																												if (flag26)
																												{
																													this.varvar.Text = "npc_deliberate_hit_randomizer";
																													this.varvalue.Text = "0.85";
																												}
																												else
																												{
																													bool flag27 = this.SearchVar.Text == "npc_deliberate_miss_offset_multiplier";
																													if (flag27)
																													{
																														this.varvar.Text = "npc_deliberate_miss_offset_multiplier";
																														this.varvalue.Text = "1.25";
																													}
																													else
																													{
																														bool flag28 = this.SearchVar.Text == "npc_deliberate_miss_to_hit_alignment_time";
																														if (flag28)
																														{
																															this.varvar.Text = "npc_deliberate_miss_to_hit_alignment_time";
																															this.varvalue.Text = "1.5";
																														}
																														else
																														{
																															bool flag29 = this.SearchVar.Text == "npc_door_trigger_size";
																															if (flag29)
																															{
																																this.varvar.Text = "npc_door_trigger_size";
																																this.varvalue.Text = "1.5";
																															}
																															else
																															{
																																bool flag30 = this.SearchVar.Text == "npc_enable";
																																if (flag30)
																																{
																																	this.varvar.Text = "npc_enable";
																																	this.varvalue.Text = "True";
																																}
																																else
																																{
																																	bool flag31 = this.SearchVar.Text == "npc_families_no_hurt";
																																	if (flag31)
																																	{
																																		this.varvar.Text = "npc_families_no_hurt";
																																		this.varvalue.Text = "True";
																																	}
																																	else
																																	{
																																		bool flag32 = this.SearchVar.Text == "npc_gun_noise_silencer_modifier";
																																		if (flag32)
																																		{
																																			this.varvar.Text = "npc_gun_noise_silencer_modifier";
																																			this.varvalue.Text = "0.15";
																																		}
																																		else
																																		{
																																			bool flag33 = this.SearchVar.Text == "npc_htn_player_base_damage_modifier";
																																			if (flag33)
																																			{
																																				this.varvar.Text = "npc_htn_player_base_damage_modifier";
																																				this.varvalue.Text = "1.15";
																																			}
																																			else
																																			{
																																				bool flag34 = this.SearchVar.Text == "npc_htn_player_frustration_threshold";
																																				if (flag34)
																																				{
																																					this.varvar.Text = "npc_htn_player_frustration_threshold";
																																					this.varvalue.Text = "3";
																																				}
																																				else
																																				{
																																					bool flag35 = this.SearchVar.Text == "npc_ignore_chairs";
																																					if (flag35)
																																					{
																																						this.varvar.Text = "npc_ignore_chairs";
																																						this.varvalue.Text = "True";
																																					}
																																					else
																																					{
																																						bool flag36 = this.SearchVar.Text == "npc_junkpile_a_spawn_chance";
																																						if (flag36)
																																						{
																																							this.varvar.Text = "npc_junkpile_a_spawn_chance";
																																							this.varvalue.Text = "0.1";
																																						}
																																						else
																																						{
																																							bool flag37 = this.SearchVar.Text == "npc_junkpile_dist_aggro_gate";
																																							if (flag37)
																																							{
																																								this.varvar.Text = "npc_junkpile_dist_aggro_gate";
																																								this.varvalue.Text = "8";
																																							}
																																							else
																																							{
																																								bool flag38 = this.SearchVar.Text == "npc_junkpile_g_spawn_chance";
																																								if (flag38)
																																								{
																																									this.varvar.Text = "npc_junkpile_g_spawn_chance";
																																									this.varvalue.Text = "0.1";
																																								}
																																								else
																																								{
																																									bool flag39 = this.SearchVar.Text == "npc_max_junkpile_count";
																																									if (flag39)
																																									{
																																										this.varvar.Text = "npc_max_junkpile_count";
																																										this.varvalue.Text = "30";
																																									}
																																									else
																																									{
																																										bool flag40 = this.SearchVar.Text == "npc_max_population_military_tunnels";
																																										if (flag40)
																																										{
																																											this.varvar.Text = "npc_max_population_military_tunnels";
																																											this.varvalue.Text = "3";
																																										}
																																										else
																																										{
																																											bool flag41 = this.SearchVar.Text == "npc_max_roam_multiplier";
																																											if (flag41)
																																											{
																																												this.varvar.Text = "npc_max_roam_multiplier";
																																												this.varvalue.Text = "3";
																																											}
																																											else
																																											{
																																												bool flag42 = this.SearchVar.Text == "npc_only_hurt_active_target_in_safezone";
																																												if (flag42)
																																												{
																																													this.varvar.Text = "npc_only_hurt_active_target_in_safezone";
																																													this.varvalue.Text = "True";
																																												}
																																												else
																																												{
																																													bool flag43 = this.SearchVar.Text == "npc_patrol_point_cooldown";
																																													if (flag43)
																																													{
																																														this.varvar.Text = "npc_patrol_point_cooldown";
																																														this.varvalue.Text = "5";
																																													}
																																													else
																																													{
																																														bool flag44 = this.SearchVar.Text == "npc_reasoning_system_tick_rate_multiplier";
																																														if (flag44)
																																														{
																																															this.varvar.Text = "npc_reasoning_system_tick_rate_multiplier";
																																															this.varvalue.Text = "1";
																																														}
																																														else
																																														{
																																															bool flag45 = this.SearchVar.Text == "npc_respawn_delay_max_military_tunnels";
																																															if (flag45)
																																															{
																																																this.varvar.Text = "npc_respawn_delay_max_military_tunnels";
																																																this.varvalue.Text = "1920";
																																															}
																																															else
																																															{
																																																bool flag46 = this.SearchVar.Text == "npc_respawn_delay_min_military_tunnels";
																																																if (flag46)
																																																{
																																																	this.varvar.Text = "npc_respawn_delay_min_military_tunnels";
																																																	this.varvalue.Text = "480";
																																																}
																																																else
																																																{
																																																	bool flag47 = this.SearchVar.Text == "npc_sensory_system_tick_rate_multiplier";
																																																	if (flag47)
																																																	{
																																																		this.varvar.Text = "npc_sensory_system_tick_rate_multiplier";
																																																		this.varvalue.Text = "5";
																																																	}
																																																	else
																																																	{
																																																		bool flag48 = this.SearchVar.Text == "npc_spawn_on_cargo_ship";
																																																		if (flag48)
																																																		{
																																																			this.varvar.Text = "npc_spawn_on_cargo_ship";
																																																			this.varvalue.Text = "True";
																																																		}
																																																		else
																																																		{
																																																			bool flag49 = this.SearchVar.Text == "npc_spawn_per_tick_max_military_tunnels";
																																																			if (flag49)
																																																			{
																																																				this.varvar.Text = "npc_spawn_per_tick_max_military_tunnels";
																																																				this.varvalue.Text = "1";
																																																			}
																																																			else
																																																			{
																																																				bool flag50 = this.SearchVar.Text == "npc_spawn_per_tick_min_military_tunnels";
																																																				if (flag50)
																																																				{
																																																					this.varvar.Text = "npc_spawn_per_tick_min_military_tunnels";
																																																					this.varvalue.Text = "1";
																																																				}
																																																				else
																																																				{
																																																					bool flag51 = this.SearchVar.Text == "npc_speed_crouch_run";
																																																					if (flag51)
																																																					{
																																																						this.varvar.Text = "npc_speed_crouch_run";
																																																						this.varvalue.Text = "0.25";
																																																					}
																																																					else
																																																					{
																																																						bool flag52 = this.SearchVar.Text == "npc_speed_crouch_walk";
																																																						if (flag52)
																																																						{
																																																							this.varvar.Text = "npc_speed_crouch_walk";
																																																							this.varvalue.Text = "0.1";
																																																						}
																																																						else
																																																						{
																																																							bool flag53 = this.SearchVar.Text == "clothloddist";
																																																							if (flag53)
																																																							{
																																																								this.varvar.Text = "clothloddist";
																																																								this.varvalue.Text = "20";
																																																							}
																																																							else
																																																							{
																																																								bool flag54 = this.SearchVar.Text == "npc_speed_run";
																																																								if (flag54)
																																																								{
																																																									this.varvar.Text = "npc_speed_run";
																																																									this.varvalue.Text = "0.4";
																																																								}
																																																								else
																																																								{
																																																									bool flag55 = this.SearchVar.Text == "npc_speed_sprint";
																																																									if (flag55)
																																																									{
																																																										this.varvar.Text = "npc_speed_sprint";
																																																										this.varvalue.Text = "1";
																																																									}
																																																									else
																																																									{
																																																										bool flag56 = this.SearchVar.Text == "npc_speed_walk";
																																																										if (flag56)
																																																										{
																																																											this.varvar.Text = "npc_speed_walk";
																																																											this.varvalue.Text = "0.18";
																																																										}
																																																										else
																																																										{
																																																											bool flag57 = this.SearchVar.Text == "npc_use_new_aim_system";
																																																											if (flag57)
																																																											{
																																																												this.varvar.Text = "npc_use_new_aim_system";
																																																												this.varvalue.Text = "True";
																																																											}
																																																											else
																																																											{
																																																												bool flag58 = this.SearchVar.Text == "npc_use_thrown_weapons";
																																																												if (flag58)
																																																												{
																																																													this.varvar.Text = "npc_use_thrown_weapons";
																																																													this.varvalue.Text = "True";
																																																												}
																																																												else
																																																												{
																																																													bool flag59 = this.SearchVar.Text == "npc_valid_aim_cone";
																																																													if (flag59)
																																																													{
																																																														this.varvar.Text = "npc_valid_aim_cone";
																																																														this.varvalue.Text = "0.8";
																																																													}
																																																													else
																																																													{
																																																														bool flag60 = this.SearchVar.Text == "npc_valid_mounted_aim_cone";
																																																														if (flag60)
																																																														{
																																																															this.varvar.Text = "npc_valid_mounted_aim_cone";
																																																															this.varvalue.Text = "0.92";
																																																														}
																																																														else
																																																														{
																																																															bool flag61 = this.SearchVar.Text == "ocean_patrol_path_iterations";
																																																															if (flag61)
																																																															{
																																																																this.varvar.Text = "ocean_patrol_path_iterations";
																																																																this.varvalue.Text = "100000";
																																																															}
																																																															else
																																																															{
																																																																bool flag62 = this.SearchVar.Text == "think";
																																																																if (flag62)
																																																																{
																																																																	this.varvar.Text = "think";
																																																																	this.varvalue.Text = "True";
																																																																}
																																																																else
																																																																{
																																																																	bool flag63 = this.SearchVar.Text == "sensetime";
																																																																	if (flag63)
																																																																	{
																																																																		this.varvar.Text = "sensetime";
																																																																		this.varvalue.Text = "1";
																																																																	}
																																																																	else
																																																																	{
																																																																		bool flag64 = this.SearchVar.Text == "ai.tickrate";
																																																																		if (flag64)
																																																																		{
																																																																			this.varvar.Text = "ai.tickrate";
																																																																			this.varvalue.Text = "5";
																																																																		}
																																																																		else
																																																																		{
																																																																			bool flag65 = this.SearchVar.Text == "admincheat";
																																																																			if (flag65)
																																																																			{
																																																																				this.varvar.Text = "admincheat";
																																																																				this.varvalue.Text = "True";
																																																																			}
																																																																			else
																																																																			{
																																																																				bool flag66 = this.SearchVar.Text == "debuglevel";
																																																																				if (flag66)
																																																																				{
																																																																					this.varvar.Text = "debuglevel";
																																																																					this.varvalue.Text = "1";
																																																																				}
																																																																				else
																																																																				{
																																																																					bool flag67 = this.SearchVar.Text == "enforcementlevel";
																																																																					if (flag67)
																																																																					{
																																																																						this.varvar.Text = "enforcementlevel";
																																																																						this.varvalue.Text = "1";
																																																																					}
																																																																					else
																																																																					{
																																																																						bool flag68 = this.SearchVar.Text == "eye_clientframes";
																																																																						if (flag68)
																																																																						{
																																																																							this.varvar.Text = "eye_clientframes";
																																																																							this.varvalue.Text = "2";
																																																																						}
																																																																						else
																																																																						{
																																																																							bool flag69 = this.SearchVar.Text == "eye_forgiveness";
																																																																							if (flag69)
																																																																							{
																																																																								this.varvar.Text = "eye_forgiveness";
																																																																								this.varvalue.Text = "0.5";
																																																																							}
																																																																							else
																																																																							{
																																																																								bool flag70 = this.SearchVar.Text == "eye_penalty";
																																																																								if (flag70)
																																																																								{
																																																																									this.varvar.Text = "eye_penalty";
																																																																									this.varvalue.Text = "0";
																																																																								}
																																																																								else
																																																																								{
																																																																									bool flag71 = this.SearchVar.Text == "eye_protection";
																																																																									if (flag71)
																																																																									{
																																																																										this.varvar.Text = "eye_protection";
																																																																										this.varvalue.Text = "2";
																																																																									}
																																																																									else
																																																																									{
																																																																										bool flag72 = this.SearchVar.Text == "eye_serverframes";
																																																																										if (flag72)
																																																																										{
																																																																											this.varvar.Text = "eye_serverframes";
																																																																											this.varvalue.Text = "2";
																																																																										}
																																																																										else
																																																																										{
																																																																											bool flag73 = this.SearchVar.Text == "flyhack_extrusion";
																																																																											if (flag73)
																																																																											{
																																																																												this.varvar.Text = "flyhack_extrusion";
																																																																												this.varvalue.Text = "2";
																																																																											}
																																																																											else
																																																																											{
																																																																												bool flag74 = this.SearchVar.Text == "flyhack_forgiveness_horizontal";
																																																																												if (flag74)
																																																																												{
																																																																													this.varvar.Text = "flyhack_forgiveness_horizontal";
																																																																													this.varvalue.Text = "2015";
																																																																												}
																																																																												else
																																																																												{
																																																																													bool flag75 = this.SearchVar.Text == "flyhack_forgiveness_vertical";
																																																																													if (flag75)
																																																																													{
																																																																														this.varvar.Text = "flyhack_forgiveness_vertical";
																																																																														this.varvalue.Text = "1.5";
																																																																													}
																																																																													else
																																																																													{
																																																																														bool flag76 = this.SearchVar.Text == "flyhack_margin";
																																																																														if (flag76)
																																																																														{
																																																																															this.varvar.Text = "flyhack_margin";
																																																																															this.varvalue.Text = "0.05";
																																																																														}
																																																																														else
																																																																														{
																																																																															bool flag77 = this.SearchVar.Text == "flyhack_maxsteps";
																																																																															if (flag77)
																																																																															{
																																																																																this.varvar.Text = "flyhack_maxsteps";
																																																																																this.varvalue.Text = "15";
																																																																															}
																																																																															else
																																																																															{
																																																																																bool flag78 = this.SearchVar.Text == "flyhack_penalty";
																																																																																if (flag78)
																																																																																{
																																																																																	this.varvar.Text = "flyhack_penalty";
																																																																																	this.varvalue.Text = "100";
																																																																																}
																																																																																else
																																																																																{
																																																																																	bool flag79 = this.SearchVar.Text == "flyhack_protection";
																																																																																	if (flag79)
																																																																																	{
																																																																																		this.varvar.Text = "flyhack_protection";
																																																																																		this.varvalue.Text = "3";
																																																																																	}
																																																																																	else
																																																																																	{
																																																																																		bool flag80 = this.SearchVar.Text == "flyhack_reject";
																																																																																		if (flag80)
																																																																																		{
																																																																																			this.varvar.Text = "flyhack_reject";
																																																																																			this.varvalue.Text = "False";
																																																																																		}
																																																																																		else
																																																																																		{
																																																																																			bool flag81 = this.SearchVar.Text == "flyhack_stepsize";
																																																																																			if (flag81)
																																																																																			{
																																																																																				this.varvar.Text = "flyhack_stepsize";
																																																																																				this.varvalue.Text = "0.1";
																																																																																			}
																																																																																			else
																																																																																			{
																																																																																				bool flag82 = this.SearchVar.Text == "forceposition";
																																																																																				if (flag82)
																																																																																				{
																																																																																					this.varvar.Text = "forceposition";
																																																																																					this.varvalue.Text = "True";
																																																																																				}
																																																																																				else
																																																																																				{
																																																																																					bool flag83 = this.SearchVar.Text == "maxdeltatime";
																																																																																					if (flag83)
																																																																																					{
																																																																																						this.varvar.Text = "maxdeltatime";
																																																																																						this.varvalue.Text = "1";
																																																																																					}
																																																																																					else
																																																																																					{
																																																																																						bool flag84 = this.SearchVar.Text == "maxdesync";
																																																																																						if (flag84)
																																																																																						{
																																																																																							this.varvar.Text = "maxdesync";
																																																																																							this.varvalue.Text = "1";
																																																																																						}
																																																																																						else
																																																																																						{
																																																																																							bool flag85 = this.SearchVar.Text == "maxviolation";
																																																																																							if (flag85)
																																																																																							{
																																																																																								this.varvar.Text = "maxviolation";
																																																																																								this.varvalue.Text = "100";
																																																																																							}
																																																																																							else
																																																																																							{
																																																																																								bool flag86 = this.SearchVar.Text == "melee_clientframes";
																																																																																								if (flag86)
																																																																																								{
																																																																																									this.varvar.Text = "melee_clientframes";
																																																																																									this.varvalue.Text = "2";
																																																																																								}
																																																																																								else
																																																																																								{
																																																																																									bool flag87 = this.SearchVar.Text == "melee_forgiveness";
																																																																																									if (flag87)
																																																																																									{
																																																																																										this.varvar.Text = "melee_forgiveness";
																																																																																										this.varvalue.Text = "0.5";
																																																																																									}
																																																																																									else
																																																																																									{
																																																																																										bool flag88 = this.SearchVar.Text == "melee_penalty";
																																																																																										if (flag88)
																																																																																										{
																																																																																											this.varvar.Text = "melee_penalty";
																																																																																											this.varvalue.Text = "0";
																																																																																										}
																																																																																										else
																																																																																										{
																																																																																											bool flag89 = this.SearchVar.Text == "melee_protection";
																																																																																											if (flag89)
																																																																																											{
																																																																																												this.varvar.Text = "melee_protection";
																																																																																												this.varvalue.Text = "3";
																																																																																											}
																																																																																											else
																																																																																											{
																																																																																												bool flag90 = this.SearchVar.Text == "melee_serverframes";
																																																																																												if (flag90)
																																																																																												{
																																																																																													this.varvar.Text = "melee_serverframes";
																																																																																													this.varvalue.Text = "2";
																																																																																												}
																																																																																												else
																																																																																												{
																																																																																													bool flag91 = this.SearchVar.Text == "modelstate";
																																																																																													if (flag91)
																																																																																													{
																																																																																														this.varvar.Text = "modelstate";
																																																																																														this.varvalue.Text = "True";
																																																																																													}
																																																																																													else
																																																																																													{
																																																																																														bool flag92 = this.SearchVar.Text == "noclip_backtracking";
																																																																																														if (flag92)
																																																																																														{
																																																																																															this.varvar.Text = "noclip_backtracking";
																																																																																															this.varvalue.Text = "0.01";
																																																																																														}
																																																																																														else
																																																																																														{
																																																																																															bool flag93 = this.SearchVar.Text == "noclip_margin";
																																																																																															if (flag93)
																																																																																															{
																																																																																																this.varvar.Text = "noclip_margin";
																																																																																																this.varvalue.Text = "0.09";
																																																																																															}
																																																																																															else
																																																																																															{
																																																																																																bool flag94 = this.SearchVar.Text == "noclip_maxsteps";
																																																																																																if (flag94)
																																																																																																{
																																																																																																	this.varvar.Text = "noclip_maxsteps";
																																																																																																	this.varvalue.Text = "15";
																																																																																																}
																																																																																																else
																																																																																																{
																																																																																																	bool flag95 = this.SearchVar.Text == "noclip_penalty";
																																																																																																	if (flag95)
																																																																																																	{
																																																																																																		this.varvar.Text = "noclip_penalty";
																																																																																																		this.varvalue.Text = "0";
																																																																																																	}
																																																																																																	else
																																																																																																	{
																																																																																																		bool flag96 = this.SearchVar.Text == "noclip_protection";
																																																																																																		if (flag96)
																																																																																																		{
																																																																																																			this.varvar.Text = "noclip_protection";
																																																																																																			this.varvalue.Text = "3";
																																																																																																		}
																																																																																																		else
																																																																																																		{
																																																																																																			bool flag97 = this.SearchVar.Text == "noclip_reject";
																																																																																																			if (flag97)
																																																																																																			{
																																																																																																				this.varvar.Text = "noclip_reject";
																																																																																																				this.varvalue.Text = "True";
																																																																																																			}
																																																																																																			else
																																																																																																			{
																																																																																																				bool flag98 = this.SearchVar.Text == "noclip_stepsize";
																																																																																																				if (flag98)
																																																																																																				{
																																																																																																					this.varvar.Text = "noclip_stepsize";
																																																																																																					this.varvalue.Text = "0.1";
																																																																																																				}
																																																																																																				else
																																																																																																				{
																																																																																																					bool flag99 = this.SearchVar.Text == "objectplacement";
																																																																																																					if (flag99)
																																																																																																					{
																																																																																																						this.varvar.Text = "objectplacement";
																																																																																																						this.varvalue.Text = "True";
																																																																																																					}
																																																																																																					else
																																																																																																					{
																																																																																																						bool flag100 = this.SearchVar.Text == "projectile_clientframes";
																																																																																																						if (flag100)
																																																																																																						{
																																																																																																							this.varvar.Text = "projectile_clientframes";
																																																																																																							this.varvalue.Text = "2";
																																																																																																						}
																																																																																																						else
																																																																																																						{
																																																																																																							bool flag101 = this.SearchVar.Text == "projectile_forgiveness";
																																																																																																							if (flag101)
																																																																																																							{
																																																																																																								this.varvar.Text = "projectile_forgiveness";
																																																																																																								this.varvalue.Text = "0.5";
																																																																																																							}
																																																																																																							else
																																																																																																							{
																																																																																																								bool flag102 = this.SearchVar.Text == "projectile_penalty";
																																																																																																								if (flag102)
																																																																																																								{
																																																																																																									this.varvar.Text = "projectile_penalty";
																																																																																																									this.varvalue.Text = "0";
																																																																																																								}
																																																																																																								else
																																																																																																								{
																																																																																																									bool flag103 = this.SearchVar.Text == "projectile_protection";
																																																																																																									if (flag103)
																																																																																																									{
																																																																																																										this.varvar.Text = "projectile_protection";
																																																																																																										this.varvalue.Text = "5";
																																																																																																									}
																																																																																																									else
																																																																																																									{
																																																																																																										bool flag104 = this.SearchVar.Text == "projectile_serverframes";
																																																																																																										if (flag104)
																																																																																																										{
																																																																																																											this.varvar.Text = "projectile_serverframes";
																																																																																																											this.varvalue.Text = "2";
																																																																																																										}
																																																																																																										else
																																																																																																										{
																																																																																																											bool flag105 = this.SearchVar.Text == "projectile_trajectory_horizontal";
																																																																																																											if (flag105)
																																																																																																											{
																																																																																																												this.varvar.Text = "projectile_trajectory_horizontal";
																																																																																																												this.varvalue.Text = "1";
																																																																																																											}
																																																																																																											else
																																																																																																											{
																																																																																																												bool flag106 = this.SearchVar.Text == "projectile_trajectory_vertical";
																																																																																																												if (flag106)
																																																																																																												{
																																																																																																													this.varvar.Text = "projectile_trajectory_vertical";
																																																																																																													this.varvalue.Text = "1";
																																																																																																												}
																																																																																																												else
																																																																																																												{
																																																																																																													bool flag107 = this.SearchVar.Text == "relaxationpause";
																																																																																																													if (flag107)
																																																																																																													{
																																																																																																														this.varvar.Text = "relaxationpause";
																																																																																																														this.varvalue.Text = "10";
																																																																																																													}
																																																																																																													else
																																																																																																													{
																																																																																																														bool flag108 = this.SearchVar.Text == "relaxationrate";
																																																																																																														if (flag108)
																																																																																																														{
																																																																																																															this.varvar.Text = "relaxationrate";
																																																																																																															this.varvalue.Text = "0.1";
																																																																																																														}
																																																																																																														else
																																																																																																														{
																																																																																																															bool flag109 = this.SearchVar.Text == "speedhack_forgiveness";
																																																																																																															if (flag109)
																																																																																																															{
																																																																																																																this.varvar.Text = "speedhack_forgiveness";
																																																																																																																this.varvalue.Text = "2";
																																																																																																															}
																																																																																																															else
																																																																																																															{
																																																																																																																bool flag110 = this.SearchVar.Text == "speedhack_penalty";
																																																																																																																if (flag110)
																																																																																																																{
																																																																																																																	this.varvar.Text = "speedhack_penalty";
																																																																																																																	this.varvalue.Text = "0";
																																																																																																																}
																																																																																																																else
																																																																																																																{
																																																																																																																	bool flag111 = this.SearchVar.Text == "speedhack_protection";
																																																																																																																	if (flag111)
																																																																																																																	{
																																																																																																																		this.varvar.Text = "speedhack_protection";
																																																																																																																		this.varvalue.Text = "2";
																																																																																																																	}
																																																																																																																	else
																																																																																																																	{
																																																																																																																		bool flag112 = this.SearchVar.Text == "speedhack_reject";
																																																																																																																		if (flag112)
																																																																																																																		{
																																																																																																																			this.varvar.Text = "speedhack_reject";
																																																																																																																			this.varvalue.Text = "True";
																																																																																																																		}
																																																																																																																		else
																																																																																																																		{
																																																																																																																			bool flag113 = this.SearchVar.Text == "speedhack_slopespeed";
																																																																																																																			if (flag113)
																																																																																																																			{
																																																																																																																				this.varvar.Text = "speedhack_slopespeed";
																																																																																																																				this.varvalue.Text = "10";
																																																																																																																			}
																																																																																																																			else
																																																																																																																			{
																																																																																																																				bool flag114 = this.SearchVar.Text == "userlevel";
																																																																																																																				if (flag114)
																																																																																																																				{
																																																																																																																					this.varvar.Text = "userlevel";
																																																																																																																					this.varvalue.Text = "2";
																																																																																																																				}
																																																																																																																				else
																																																																																																																				{
																																																																																																																					bool flag115 = this.SearchVar.Text == "batching.verbose";
																																																																																																																					if (flag115)
																																																																																																																					{
																																																																																																																						this.varvar.Text = "batching.verbose";
																																																																																																																						this.varvalue.Text = "0";
																																																																																																																					}
																																																																																																																					else
																																																																																																																					{
																																																																																																																						bool flag116 = this.SearchVar.Text == "bradley.enabled";
																																																																																																																						if (flag116)
																																																																																																																						{
																																																																																																																							this.varvar.Text = "bradley.enabled";
																																																																																																																							this.varvalue.Text = "True";
																																																																																																																						}
																																																																																																																						else
																																																																																																																						{
																																																																																																																							bool flag117 = this.SearchVar.Text == "respawndelayminutes";
																																																																																																																							if (flag117)
																																																																																																																							{
																																																																																																																								this.varvar.Text = "respawndelayminutes";
																																																																																																																								this.varvalue.Text = "60";
																																																																																																																							}
																																																																																																																							else
																																																																																																																							{
																																																																																																																								bool flag118 = this.SearchVar.Text == "respawndelayvariance";
																																																																																																																								if (flag118)
																																																																																																																								{
																																																																																																																									this.varvar.Text = "respawndelayvariance";
																																																																																																																									this.varvalue.Text = "1";
																																																																																																																								}
																																																																																																																								else
																																																																																																																								{
																																																																																																																									bool flag119 = this.SearchVar.Text == "chat.enabled";
																																																																																																																									if (flag119)
																																																																																																																									{
																																																																																																																										this.varvar.Text = "chat.enabled";
																																																																																																																										this.varvalue.Text = "True";
																																																																																																																									}
																																																																																																																									else
																																																																																																																									{
																																																																																																																										bool flag120 = this.SearchVar.Text == "cserverlog";
																																																																																																																										if (flag120)
																																																																																																																										{
																																																																																																																											this.varvar.Text = "serverlog";
																																																																																																																											this.varvalue.Text = "True";
																																																																																																																										}
																																																																																																																										else
																																																																																																																										{
																																																																																																																											bool flag121 = this.SearchVar.Text == "frameminutes";
																																																																																																																											if (flag121)
																																																																																																																											{
																																																																																																																												this.varvar.Text = "frameminutes";
																																																																																																																												this.varvalue.Text = "30";
																																																																																																																											}
																																																																																																																											else
																																																																																																																											{
																																																																																																																												bool flag122 = this.SearchVar.Text == "instant";
																																																																																																																												if (flag122)
																																																																																																																												{
																																																																																																																													this.varvar.Text = "instant";
																																																																																																																													this.varvalue.Text = "False";
																																																																																																																												}
																																																																																																																												else
																																																																																																																												{
																																																																																																																													bool flag123 = this.SearchVar.Text == "callbacks";
																																																																																																																													if (flag123)
																																																																																																																													{
																																																																																																																														this.varvar.Text = "callbacks";
																																																																																																																														this.varvalue.Text = "False";
																																																																																																																													}
																																																																																																																													else
																																																																																																																													{
																																																																																																																														bool flag124 = this.SearchVar.Text == "checktriggers";
																																																																																																																														if (flag124)
																																																																																																																														{
																																																																																																																															this.varvar.Text = "checktriggers";
																																																																																																																															this.varvalue.Text = "False";
																																																																																																																														}
																																																																																																																														else
																																																																																																																														{
																																																																																																																															bool flag125 = this.SearchVar.Text == "disablecondition";
																																																																																																																															if (flag125)
																																																																																																																															{
																																																																																																																																this.varvar.Text = "disablecondition";
																																																																																																																																this.varvalue.Text = "False";
																																																																																																																															}
																																																																																																																															else
																																																																																																																															{
																																																																																																																																bool flag126 = this.SearchVar.Text == "bracket_0_blockcount";
																																																																																																																																if (flag126)
																																																																																																																																{
																																																																																																																																	this.varvar.Text = "bracket_0_blockcount";
																																																																																																																																	this.varvalue.Text = "15";
																																																																																																																																}
																																																																																																																																else
																																																																																																																																{
																																																																																																																																	bool flag127 = this.SearchVar.Text == "bracket_0_costfraction";
																																																																																																																																	if (flag127)
																																																																																																																																	{
																																																																																																																																		this.varvar.Text = "bracket_0_costfraction";
																																																																																																																																		this.varvalue.Text = "0.1";
																																																																																																																																	}
																																																																																																																																	else
																																																																																																																																	{
																																																																																																																																		bool flag128 = this.SearchVar.Text == "bracket_1_blockcount";
																																																																																																																																		if (flag128)
																																																																																																																																		{
																																																																																																																																			this.varvar.Text = "bracket_1_blockcount";
																																																																																																																																			this.varvalue.Text = "50";
																																																																																																																																		}
																																																																																																																																		else
																																																																																																																																		{
																																																																																																																																			bool flag129 = this.SearchVar.Text == "bracket_1_costfraction";
																																																																																																																																			if (flag129)
																																																																																																																																			{
																																																																																																																																				this.varvar.Text = "bracket_1_costfraction";
																																																																																																																																				this.varvalue.Text = "0.15";
																																																																																																																																			}
																																																																																																																																			else
																																																																																																																																			{
																																																																																																																																				bool flag130 = this.SearchVar.Text == "bracket_2_blockcount";
																																																																																																																																				if (flag130)
																																																																																																																																				{
																																																																																																																																					this.varvar.Text = "bracket_2_blockcount";
																																																																																																																																					this.varvalue.Text = "125";
																																																																																																																																				}
																																																																																																																																				else
																																																																																																																																				{
																																																																																																																																					bool flag131 = this.SearchVar.Text == "bracket_2_costfraction";
																																																																																																																																					if (flag131)
																																																																																																																																					{
																																																																																																																																						this.varvar.Text = "bracket_2_costfraction";
																																																																																																																																						this.varvalue.Text = "0.2";
																																																																																																																																					}
																																																																																																																																					else
																																																																																																																																					{
																																																																																																																																						bool flag132 = this.SearchVar.Text == "bracket_3_blockcount";
																																																																																																																																						if (flag132)
																																																																																																																																						{
																																																																																																																																							this.varvar.Text = "bracket_3_blockcount";
																																																																																																																																							this.varvalue.Text = "200";
																																																																																																																																						}
																																																																																																																																						else
																																																																																																																																						{
																																																																																																																																							bool flag133 = this.SearchVar.Text == "bracket_3_costfraction";
																																																																																																																																							if (flag133)
																																																																																																																																							{
																																																																																																																																								this.varvar.Text = "bracket_3_costfraction";
																																																																																																																																								this.varvalue.Text = "0.333";
																																																																																																																																							}
																																																																																																																																							else
																																																																																																																																							{
																																																																																																																																								bool flag134 = this.SearchVar.Text == "decay.debug";
																																																																																																																																								if (flag134)
																																																																																																																																								{
																																																																																																																																									this.varvar.Text = "decay.debug";
																																																																																																																																									this.varvalue.Text = "False";
																																																																																																																																								}
																																																																																																																																								else
																																																																																																																																								{
																																																																																																																																									bool flag135 = this.SearchVar.Text == "delay_metal";
																																																																																																																																									if (flag135)
																																																																																																																																									{
																																																																																																																																										this.varvar.Text = "delay_metal";
																																																																																																																																										this.varvalue.Text = "0";
																																																																																																																																									}
																																																																																																																																									else
																																																																																																																																									{
																																																																																																																																										bool flag136 = this.SearchVar.Text == "delay_override";
																																																																																																																																										if (flag136)
																																																																																																																																										{
																																																																																																																																											this.varvar.Text = "delay_override";
																																																																																																																																											this.varvalue.Text = "0";
																																																																																																																																										}
																																																																																																																																										else
																																																																																																																																										{
																																																																																																																																											bool flag137 = this.SearchVar.Text == "delay_stone";
																																																																																																																																											if (flag137)
																																																																																																																																											{
																																																																																																																																												this.varvar.Text = "delay_stone";
																																																																																																																																												this.varvalue.Text = "0";
																																																																																																																																											}
																																																																																																																																											else
																																																																																																																																											{
																																																																																																																																												bool flag138 = this.SearchVar.Text == "delay_toptier";
																																																																																																																																												if (flag138)
																																																																																																																																												{
																																																																																																																																													this.varvar.Text = "delay_toptier";
																																																																																																																																													this.varvalue.Text = "0";
																																																																																																																																												}
																																																																																																																																												else
																																																																																																																																												{
																																																																																																																																													bool flag139 = this.SearchVar.Text == "delay_twig";
																																																																																																																																													if (flag139)
																																																																																																																																													{
																																																																																																																																														this.varvar.Text = "delay_twig";
																																																																																																																																														this.varvalue.Text = "0";
																																																																																																																																													}
																																																																																																																																													else
																																																																																																																																													{
																																																																																																																																														bool flag140 = this.SearchVar.Text == "delay_wood";
																																																																																																																																														if (flag140)
																																																																																																																																														{
																																																																																																																																															this.varvar.Text = "delay_wood";
																																																																																																																																															this.varvalue.Text = "0";
																																																																																																																																														}
																																																																																																																																														else
																																																																																																																																														{
																																																																																																																																															bool flag141 = this.SearchVar.Text == "duration_metal";
																																																																																																																																															if (flag141)
																																																																																																																																															{
																																																																																																																																																this.varvar.Text = "duration_metal";
																																																																																																																																																this.varvalue.Text = "8";
																																																																																																																																															}
																																																																																																																																															else
																																																																																																																																															{
																																																																																																																																																bool flag142 = this.SearchVar.Text == "duration_override";
																																																																																																																																																if (flag142)
																																																																																																																																																{
																																																																																																																																																	this.varvar.Text = "duration_override";
																																																																																																																																																	this.varvalue.Text = "0";
																																																																																																																																																}
																																																																																																																																																else
																																																																																																																																																{
																																																																																																																																																	bool flag143 = this.SearchVar.Text == "duration_stone";
																																																																																																																																																	if (flag143)
																																																																																																																																																	{
																																																																																																																																																		this.varvar.Text = "duration_stone";
																																																																																																																																																		this.varvalue.Text = "5";
																																																																																																																																																	}
																																																																																																																																																	else
																																																																																																																																																	{
																																																																																																																																																		bool flag144 = this.SearchVar.Text == "duration_toptier";
																																																																																																																																																		if (flag144)
																																																																																																																																																		{
																																																																																																																																																			this.varvar.Text = "duration_toptier";
																																																																																																																																																			this.varvalue.Text = "12";
																																																																																																																																																		}
																																																																																																																																																		else
																																																																																																																																																		{
																																																																																																																																																			bool flag145 = this.SearchVar.Text == "duration_twig";
																																																																																																																																																			if (flag145)
																																																																																																																																																			{
																																																																																																																																																				this.varvar.Text = "duration_twig";
																																																																																																																																																				this.varvalue.Text = "1";
																																																																																																																																																			}
																																																																																																																																																			else
																																																																																																																																																			{
																																																																																																																																																				bool flag146 = this.SearchVar.Text == "duration_wood";
																																																																																																																																																				if (flag146)
																																																																																																																																																				{
																																																																																																																																																					this.varvar.Text = "duration_wood";
																																																																																																																																																					this.varvalue.Text = "3";
																																																																																																																																																				}
																																																																																																																																																				else
																																																																																																																																																				{
																																																																																																																																																					bool flag147 = this.SearchVar.Text == "outside_test_range";
																																																																																																																																																					if (flag147)
																																																																																																																																																					{
																																																																																																																																																						this.varvar.Text = "outside_test_range";
																																																																																																																																																						this.varvalue.Text = "50";
																																																																																																																																																					}
																																																																																																																																																					else
																																																																																																																																																					{
																																																																																																																																																						bool flag148 = this.SearchVar.Text == "scale";
																																																																																																																																																						if (flag148)
																																																																																																																																																						{
																																																																																																																																																							this.varvar.Text = "scale";
																																																																																																																																																							this.varvalue.Text = "1";
																																																																																																																																																						}
																																																																																																																																																						else
																																																																																																																																																						{
																																																																																																																																																							bool flag149 = this.SearchVar.Text == "tick";
																																																																																																																																																							if (flag149)
																																																																																																																																																							{
																																																																																																																																																								this.varvar.Text = "tick";
																																																																																																																																																								this.varvalue.Text = "600";
																																																																																																																																																							}
																																																																																																																																																							else
																																																																																																																																																							{
																																																																																																																																																								bool flag150 = this.SearchVar.Text == "upkeep";
																																																																																																																																																								if (flag150)
																																																																																																																																																								{
																																																																																																																																																									this.varvar.Text = "upkeep";
																																																																																																																																																									this.varvalue.Text = "True";
																																																																																																																																																								}
																																																																																																																																																								else
																																																																																																																																																								{
																																																																																																																																																									bool flag151 = this.SearchVar.Text == "upkeep_grief_protection";
																																																																																																																																																									if (flag151)
																																																																																																																																																									{
																																																																																																																																																										this.varvar.Text = "upkeep_grief_protection";
																																																																																																																																																										this.varvalue.Text = "1440";
																																																																																																																																																									}
																																																																																																																																																									else
																																																																																																																																																									{
																																																																																																																																																										bool flag152 = this.SearchVar.Text == "upkeep_heal_scale";
																																																																																																																																																										if (flag152)
																																																																																																																																																										{
																																																																																																																																																											this.varvar.Text = "upkeep_heal_scale";
																																																																																																																																																											this.varvalue.Text = "1";
																																																																																																																																																										}
																																																																																																																																																										else
																																																																																																																																																										{
																																																																																																																																																											bool flag153 = this.SearchVar.Text == "upkeep_inside_decay_scale";
																																																																																																																																																											if (flag153)
																																																																																																																																																											{
																																																																																																																																																												this.varvar.Text = "upkeep_inside_decay_scale";
																																																																																																																																																												this.varvalue.Text = "0.1";
																																																																																																																																																											}
																																																																																																																																																											else
																																																																																																																																																											{
																																																																																																																																																												bool flag154 = this.SearchVar.Text == "upkeep_period_minutes";
																																																																																																																																																												if (flag154)
																																																																																																																																																												{
																																																																																																																																																													this.varvar.Text = "upkeep_period_minutes";
																																																																																																																																																													this.varvalue.Text = "1440";
																																																																																																																																																												}
																																																																																																																																																												else
																																																																																																																																																												{
																																																																																																																																																													bool flag155 = this.SearchVar.Text == "progresstime";
																																																																																																																																																													if (flag155)
																																																																																																																																																													{
																																																																																																																																																														this.varvar.Text = "progresstime";
																																																																																																																																																														this.varvalue.Text = "False";
																																																																																																																																																													}
																																																																																																																																																													else
																																																																																																																																																													{
																																																																																																																																																														bool flag156 = this.SearchVar.Text == "gc.enabled";
																																																																																																																																																														if (flag156)
																																																																																																																																																														{
																																																																																																																																																															this.varvar.Text = "gc.enabled";
																																																																																																																																																															this.varvalue.Text = "True";
																																																																																																																																																														}
																																																																																																																																																														else
																																																																																																																																																														{
																																																																																																																																																															bool flag157 = this.SearchVar.Text == "incremental_enabled";
																																																																																																																																																															if (flag157)
																																																																																																																																																															{
																																																																																																																																																																this.varvar.Text = "incremental_enabled";
																																																																																																																																																																this.varvalue.Text = "True";
																																																																																																																																																															}
																																																																																																																																																															else
																																																																																																																																																															{
																																																																																																																																																																bool flag158 = this.SearchVar.Text == "incremental_milliseconds";
																																																																																																																																																																if (flag158)
																																																																																																																																																																{
																																																																																																																																																																	this.varvar.Text = "incremental_milliseconds";
																																																																																																																																																																	this.varvalue.Text = "3";
																																																																																																																																																																}
																																																																																																																																																																else
																																																																																																																																																																{
																																																																																																																																																																	bool flag159 = this.SearchVar.Text == "developer";
																																																																																																																																																																	if (flag159)
																																																																																																																																																																	{
																																																																																																																																																																		this.varvar.Text = "developer";
																																																																																																																																																																		this.varvalue.Text = "0";
																																																																																																																																																																	}
																																																																																																																																																																	else
																																																																																																																																																																	{
																																																																																																																																																																		bool flag160 = this.SearchVar.Text == "maxthreads";
																																																																																																																																																																		if (flag160)
																																																																																																																																																																		{
																																																																																																																																																																			this.varvar.Text = "maxthreads";
																																																																																																																																																																			this.varvalue.Text = "8";
																																																																																																																																																																		}
																																																																																																																																																																		else
																																																																																																																																																																		{
																																																																																																																																																																			bool flag161 = this.SearchVar.Text == "timewarning";
																																																																																																																																																																			if (flag161)
																																																																																																																																																																			{
																																																																																																																																																																				this.varvar.Text = "timewarning";
																																																																																																																																																																				this.varvalue.Text = "False";
																																																																																																																																																																			}
																																																																																																																																																																			else
																																																																																																																																																																			{
																																																																																																																																																																				bool flag162 = this.SearchVar.Text == "halloween.enabled";
																																																																																																																																																																				if (flag162)
																																																																																																																																																																				{
																																																																																																																																																																					this.varvar.Text = "halloween.enabled";
																																																																																																																																																																					this.varvalue.Text = "False";
																																																																																																																																																																				}
																																																																																																																																																																				else
																																																																																																																																																																				{
																																																																																																																																																																					bool flag163 = this.SearchVar.Text == "murdererpopulation";
																																																																																																																																																																					if (flag163)
																																																																																																																																																																					{
																																																																																																																																																																						this.varvar.Text = "murdererpopulation";
																																																																																																																																																																						this.varvalue.Text = "0";
																																																																																																																																																																					}
																																																																																																																																																																					else
																																																																																																																																																																					{
																																																																																																																																																																						bool flag164 = this.SearchVar.Text == "scarecrow_beancan_vs_player_dmg_modifier";
																																																																																																																																																																						if (flag164)
																																																																																																																																																																						{
																																																																																																																																																																							this.varvar.Text = "scarecrow_beancan_vs_player_dmg_modifier";
																																																																																																																																																																							this.varvalue.Text = "0.1";
																																																																																																																																																																						}
																																																																																																																																																																						else
																																																																																																																																																																						{
																																																																																																																																																																							bool flag165 = this.SearchVar.Text == "scarecrow_body_dmg_modifier";
																																																																																																																																																																							if (flag165)
																																																																																																																																																																							{
																																																																																																																																																																								this.varvar.Text = "scarecrow_body_dmg_modifier";
																																																																																																																																																																								this.varvalue.Text = "0.25";
																																																																																																																																																																							}
																																																																																																																																																																							else
																																																																																																																																																																							{
																																																																																																																																																																								bool flag166 = this.SearchVar.Text == "scarecrow_chase_stopping_distance";
																																																																																																																																																																								if (flag166)
																																																																																																																																																																								{
																																																																																																																																																																									this.varvar.Text = "scarecrow_chase_stopping_distance";
																																																																																																																																																																									this.varvalue.Text = "0.5";
																																																																																																																																																																								}
																																																																																																																																																																								else
																																																																																																																																																																								{
																																																																																																																																																																									bool flag167 = this.SearchVar.Text == "scarecrow_throw_beancan_global_delay";
																																																																																																																																																																									if (flag167)
																																																																																																																																																																									{
																																																																																																																																																																										this.varvar.Text = "scarecrow_throw_beancan_global_delay";
																																																																																																																																																																										this.varvalue.Text = "8";
																																																																																																																																																																									}
																																																																																																																																																																									else
																																																																																																																																																																									{
																																																																																																																																																																										bool flag168 = this.SearchVar.Text == "scarecrowpopulation";
																																																																																																																																																																										if (flag168)
																																																																																																																																																																										{
																																																																																																																																																																											this.varvar.Text = "scarecrowpopulation";
																																																																																																																																																																											this.varvalue.Text = "0";
																																																																																																																																																																										}
																																																																																																																																																																										else
																																																																																																																																																																										{
																																																																																																																																																																											bool flag169 = this.SearchVar.Text == "scarecrows_throw_beancans";
																																																																																																																																																																											if (flag169)
																																																																																																																																																																											{
																																																																																																																																																																												this.varvar.Text = "scarecrows_throw_beancans";
																																																																																																																																																																												this.varvalue.Text = "True";
																																																																																																																																																																											}
																																																																																																																																																																											else
																																																																																																																																																																											{
																																																																																																																																																																												bool flag170 = this.SearchVar.Text == "visdebug";
																																																																																																																																																																												if (flag170)
																																																																																																																																																																												{
																																																																																																																																																																													this.varvar.Text = "visdebug";
																																																																																																																																																																													this.varvalue.Text = "False";
																																																																																																																																																																												}
																																																																																																																																																																												else
																																																																																																																																																																												{
																																																																																																																																																																													bool flag171 = this.SearchVar.Text == "bulletaccuracy";
																																																																																																																																																																													if (flag171)
																																																																																																																																																																													{
																																																																																																																																																																														this.varvar.Text = "bulletaccuracy";
																																																																																																																																																																														this.varvalue.Text = "2";
																																																																																																																																																																													}
																																																																																																																																																																													else
																																																																																																																																																																													{
																																																																																																																																																																														bool flag172 = this.SearchVar.Text == "bulletdamagescale";
																																																																																																																																																																														if (flag172)
																																																																																																																																																																														{
																																																																																																																																																																															this.varvar.Text = "bulletdamagescale";
																																																																																																																																																																															this.varvalue.Text = "1";
																																																																																																																																																																														}
																																																																																																																																																																														else
																																																																																																																																																																														{
																																																																																																																																																																															bool flag173 = this.SearchVar.Text == "guns";
																																																																																																																																																																															if (flag173)
																																																																																																																																																																															{
																																																																																																																																																																																this.varvar.Text = "guns";
																																																																																																																																																																																this.varvalue.Text = "1";
																																																																																																																																																																															}
																																																																																																																																																																															else
																																																																																																																																																																															{
																																																																																																																																																																																bool flag174 = this.SearchVar.Text == "lifetimeminutes";
																																																																																																																																																																																if (flag174)
																																																																																																																																																																																{
																																																																																																																																																																																	this.varvar.Text = "lifetimeminutes";
																																																																																																																																																																																	this.varvalue.Text = "15";
																																																																																																																																																																																}
																																																																																																																																																																																else
																																																																																																																																																																																{
																																																																																																																																																																																	bool flag175 = this.SearchVar.Text == "autosynctransforms";
																																																																																																																																																																																	if (flag175)
																																																																																																																																																																																	{
																																																																																																																																																																																		this.varvar.Text = "autosynctransforms";
																																																																																																																																																																																		this.varvalue.Text = "True";
																																																																																																																																																																																	}
																																																																																																																																																																																	else
																																																																																																																																																																																	{
																																																																																																																																																																																		bool flag176 = this.SearchVar.Text == "batchsynctransforms";
																																																																																																																																																																																		if (flag176)
																																																																																																																																																																																		{
																																																																																																																																																																																			this.varvar.Text = "batchsynctransforms";
																																																																																																																																																																																			this.varvalue.Text = "True";
																																																																																																																																																																																		}
																																																																																																																																																																																		else
																																																																																																																																																																																		{
																																																																																																																																																																																			bool flag177 = this.SearchVar.Text == "bouncethreshold";
																																																																																																																																																																																			if (flag177)
																																																																																																																																																																																			{
																																																																																																																																																																																				this.varvar.Text = "bouncethreshold";
																																																																																																																																																																																				this.varvalue.Text = "2";
																																																																																																																																																																																			}
																																																																																																																																																																																			else
																																																																																																																																																																																			{
																																																																																																																																																																																				bool flag178 = this.SearchVar.Text == "droppedmode";
																																																																																																																																																																																				if (flag178)
																																																																																																																																																																																				{
																																																																																																																																																																																					this.varvar.Text = "droppedmode";
																																																																																																																																																																																					this.varvalue.Text = "2";
																																																																																																																																																																																				}
																																																																																																																																																																																				else
																																																																																																																																																																																				{
																																																																																																																																																																																					bool flag179 = this.SearchVar.Text == "gravity";
																																																																																																																																																																																					if (flag179)
																																																																																																																																																																																					{
																																																																																																																																																																																						this.varvar.Text = "gravity";
																																																																																																																																																																																						this.varvalue.Text = "1";
																																																																																																																																																																																					}
																																																																																																																																																																																					else
																																																																																																																																																																																					{
																																																																																																																																																																																						bool flag180 = this.SearchVar.Text == "minsteps";
																																																																																																																																																																																						if (flag180)
																																																																																																																																																																																						{
																																																																																																																																																																																							this.varvar.Text = "minsteps";
																																																																																																																																																																																							this.varvalue.Text = "8";
																																																																																																																																																																																						}
																																																																																																																																																																																						else
																																																																																																																																																																																						{
																																																																																																																																																																																							bool flag181 = this.SearchVar.Text == "sendeffects";
																																																																																																																																																																																							if (flag181)
																																																																																																																																																																																							{
																																																																																																																																																																																								this.varvar.Text = "sendeffects";
																																																																																																																																																																																								this.varvalue.Text = "True";
																																																																																																																																																																																							}
																																																																																																																																																																																							else
																																																																																																																																																																																							{
																																																																																																																																																																																								bool flag182 = this.SearchVar.Text == "sleepthreshold";
																																																																																																																																																																																								if (flag182)
																																																																																																																																																																																								{
																																																																																																																																																																																									this.varvar.Text = "sleepthreshold";
																																																																																																																																																																																									this.varvalue.Text = "0.005";
																																																																																																																																																																																								}
																																																																																																																																																																																								else
																																																																																																																																																																																								{
																																																																																																																																																																																									bool flag183 = this.SearchVar.Text == "solveriterationcount";
																																																																																																																																																																																									if (flag183)
																																																																																																																																																																																									{
																																																																																																																																																																																										this.varvar.Text = "solveriterationcount";
																																																																																																																																																																																										this.varvalue.Text = "3";
																																																																																																																																																																																									}
																																																																																																																																																																																									else
																																																																																																																																																																																									{
																																																																																																																																																																																										bool flag184 = this.SearchVar.Text == "steps";
																																																																																																																																																																																										if (flag184)
																																																																																																																																																																																										{
																																																																																																																																																																																											this.varvar.Text = "steps";
																																																																																																																																																																																											this.varvalue.Text = "16";
																																																																																																																																																																																										}
																																																																																																																																																																																										else
																																																																																																																																																																																										{
																																																																																																																																																																																											bool flag185 = this.SearchVar.Text == "tickrate_cl";
																																																																																																																																																																																											if (flag185)
																																																																																																																																																																																											{
																																																																																																																																																																																												this.varvar.Text = "tickrate_cl";
																																																																																																																																																																																												this.varvalue.Text = "20";
																																																																																																																																																																																											}
																																																																																																																																																																																											else
																																																																																																																																																																																											{
																																																																																																																																																																																												bool flag186 = this.SearchVar.Text == "tickrate_sv";
																																																																																																																																																																																												if (flag186)
																																																																																																																																																																																												{
																																																																																																																																																																																													this.varvar.Text = "tickrate_sv";
																																																																																																																																																																																													this.varvalue.Text = "16";
																																																																																																																																																																																												}
																																																																																																																																																																																												else
																																																																																																																																																																																												{
																																																																																																																																																																																													bool flag187 = this.SearchVar.Text == "pool.debug";
																																																																																																																																																																																													if (flag187)
																																																																																																																																																																																													{
																																																																																																																																																																																														this.varvar.Text = "pool.debug";
																																																																																																																																																																																														this.varvalue.Text = "False";
																																																																																																																																																																																													}
																																																																																																																																																																																													else
																																																																																																																																																																																													{
																																																																																																																																																																																														bool flag188 = this.SearchVar.Text == "pool.enabled";
																																																																																																																																																																																														if (flag188)
																																																																																																																																																																																														{
																																																																																																																																																																																															this.varvar.Text = "pool.enabled";
																																																																																																																																																																																															this.varvalue.Text = "True";
																																																																																																																																																																																														}
																																																																																																																																																																																														else
																																																																																																																																																																																														{
																																																																																																																																																																																															bool flag189 = this.SearchVar.Text == "mode";
																																																																																																																																																																																															if (flag189)
																																																																																																																																																																																															{
																																																																																																																																																																																																this.varvar.Text = "mode";
																																																																																																																																																																																																this.varvalue.Text = "2";
																																																																																																																																																																																															}
																																																																																																																																																																																															else
																																																																																																																																																																																															{
																																																																																																																																																																																																bool flag190 = this.SearchVar.Text == "hostileduration";
																																																																																																																																																																																																if (flag190)
																																																																																																																																																																																																{
																																																																																																																																																																																																	this.varvar.Text = "hostileduration";
																																																																																																																																																																																																	this.varvalue.Text = "120";
																																																																																																																																																																																																}
																																																																																																																																																																																																else
																																																																																																																																																																																																{
																																																																																																																																																																																																	bool flag191 = this.SearchVar.Text == "targetall";
																																																																																																																																																																																																	if (flag191)
																																																																																																																																																																																																	{
																																																																																																																																																																																																		this.varvar.Text = "targetall";
																																																																																																																																																																																																		this.varvalue.Text = "False";
																																																																																																																																																																																																	}
																																																																																																																																																																																																	else
																																																																																																																																																																																																	{
																																																																																																																																																																																																		bool flag192 = this.SearchVar.Text == "arrowarmor";
																																																																																																																																																																																																		if (flag192)
																																																																																																																																																																																																		{
																																																																																																																																																																																																			this.varvar.Text = "arrowarmor";
																																																																																																																																																																																																			this.varvalue.Text = "1";
																																																																																																																																																																																																		}
																																																																																																																																																																																																		else
																																																																																																																																																																																																		{
																																																																																																																																																																																																			bool flag193 = this.SearchVar.Text == "arrowdamage";
																																																																																																																																																																																																			if (flag193)
																																																																																																																																																																																																			{
																																																																																																																																																																																																				this.varvar.Text = "arrowdamage";
																																																																																																																																																																																																				this.varvalue.Text = "1";
																																																																																																																																																																																																			}
																																																																																																																																																																																																			else
																																																																																																																																																																																																			{
																																																																																																																																																																																																				bool flag194 = this.SearchVar.Text == "authtimeout";
																																																																																																																																																																																																				if (flag194)
																																																																																																																																																																																																				{
																																																																																																																																																																																																					this.varvar.Text = "authtimeout";
																																																																																																																																																																																																					this.varvalue.Text = "60";
																																																																																																																																																																																																				}
																																																																																																																																																																																																				else
																																																																																																																																																																																																				{
																																																																																																																																																																																																					bool flag195 = this.SearchVar.Text == "bleedingarmor";
																																																																																																																																																																																																					if (flag195)
																																																																																																																																																																																																					{
																																																																																																																																																																																																						this.varvar.Text = "bleedingarmor";
																																																																																																																																																																																																						this.varvalue.Text = "1";
																																																																																																																																																																																																					}
																																																																																																																																																																																																					else
																																																																																																																																																																																																					{
																																																																																																																																																																																																						bool flag196 = this.SearchVar.Text == "bleedingdamage";
																																																																																																																																																																																																						if (flag196)
																																																																																																																																																																																																						{
																																																																																																																																																																																																							this.varvar.Text = "bleedingdamage";
																																																																																																																																																																																																							this.varvalue.Text = "1";
																																																																																																																																																																																																						}
																																																																																																																																																																																																						else
																																																																																																																																																																																																						{
																																																																																																																																																																																																							bool flag197 = this.SearchVar.Text == "bulletarmor";
																																																																																																																																																																																																							if (flag197)
																																																																																																																																																																																																							{
																																																																																																																																																																																																								this.varvar.Text = "bulletarmor";
																																																																																																																																																																																																								this.varvalue.Text = "1";
																																																																																																																																																																																																							}
																																																																																																																																																																																																							else
																																																																																																																																																																																																							{
																																																																																																																																																																																																								bool flag198 = this.SearchVar.Text == "bulletdamage";
																																																																																																																																																																																																								if (flag198)
																																																																																																																																																																																																								{
																																																																																																																																																																																																									this.varvar.Text = "bulletdamage";
																																																																																																																																																																																																									this.varvalue.Text = "1";
																																																																																																																																																																																																								}
																																																																																																																																																																																																								else
																																																																																																																																																																																																								{
																																																																																																																																																																																																									bool flag199 = this.SearchVar.Text == "cinematic";
																																																																																																																																																																																																									if (flag199)
																																																																																																																																																																																																									{
																																																																																																																																																																																																										this.varvar.Text = "cinematic";
																																																																																																																																																																																																										this.varvalue.Text = "False";
																																																																																																																																																																																																									}
																																																																																																																																																																																																									else
																																																																																																																																																																																																									{
																																																																																																																																																																																																										bool flag200 = this.SearchVar.Text == "combatlogdelay";
																																																																																																																																																																																																										if (flag200)
																																																																																																																																																																																																										{
																																																																																																																																																																																																											this.varvar.Text = "combatlogdelay";
																																																																																																																																																																																																											this.varvalue.Text = "10";
																																																																																																																																																																																																										}
																																																																																																																																																																																																										else
																																																																																																																																																																																																										{
																																																																																																																																																																																																											bool flag201 = this.SearchVar.Text == "combatlogsize";
																																																																																																																																																																																																											if (flag201)
																																																																																																																																																																																																											{
																																																																																																																																																																																																												this.varvar.Text = "combatlogsize";
																																																																																																																																																																																																												this.varvalue.Text = "30";
																																																																																																																																																																																																											}
																																																																																																																																																																																																											else
																																																																																																																																																																																																											{
																																																																																																																																																																																																												bool flag202 = this.SearchVar.Text == "compression";
																																																																																																																																																																																																												if (flag202)
																																																																																																																																																																																																												{
																																																																																																																																																																																																													this.varvar.Text = "compression";
																																																																																																																																																																																																													this.varvalue.Text = "False";
																																																																																																																																																																																																												}
																																																																																																																																																																																																												else
																																																																																																																																																																																																												{
																																																																																																																																																																																																													bool flag203 = this.SearchVar.Text == "corpsedespawn";
																																																																																																																																																																																																													if (flag203)
																																																																																																																																																																																																													{
																																																																																																																																																																																																														this.varvar.Text = "corpsedespawn";
																																																																																																																																																																																																														this.varvalue.Text = "300";
																																																																																																																																																																																																													}
																																																																																																																																																																																																													else
																																																																																																																																																																																																													{
																																																																																																																																																																																																														bool flag204 = this.SearchVar.Text == "corpses";
																																																																																																																																																																																																														if (flag204)
																																																																																																																																																																																																														{
																																																																																																																																																																																																															this.varvar.Text = "corpses";
																																																																																																																																																																																																															this.varvalue.Text = "True";
																																																																																																																																																																																																														}
																																																																																																																																																																																																														else
																																																																																																																																																																																																														{
																																																																																																																																																																																																															bool flag205 = this.SearchVar.Text == "cycletime";
																																																																																																																																																																																																															if (flag205)
																																																																																																																																																																																																															{
																																																																																																																																																																																																																this.varvar.Text = "cycletime";
																																																																																																																																																																																																																this.varvalue.Text = "500";
																																																																																																																																																																																																															}
																																																																																																																																																																																																															else
																																																																																																																																																																																																															{
																																																																																																																																																																																																																bool flag206 = this.SearchVar.Text == "debrisdespawn";
																																																																																																																																																																																																																if (flag206)
																																																																																																																																																																																																																{
																																																																																																																																																																																																																	this.varvar.Text = "debrisdespawn";
																																																																																																																																																																																																																	this.varvalue.Text = "30";
																																																																																																																																																																																																																}
																																																																																																																																																																																																																else
																																																																																																																																																																																																																{
																																																																																																																																																																																																																	bool flag207 = this.SearchVar.Text == "dropitems";
																																																																																																																																																																																																																	if (flag207)
																																																																																																																																																																																																																	{
																																																																																																																																																																																																																		this.varvar.Text = "dropitems";
																																																																																																																																																																																																																		this.varvalue.Text = "False";
																																																																																																																																																																																																																	}
																																																																																																																																																																																																																	else
																																																																																																																																																																																																																	{
																																																																																																																																																																																																																		bool flag208 = this.SearchVar.Text == "encryption";
																																																																																																																																																																																																																		if (flag208)
																																																																																																																																																																																																																		{
																																																																																																																																																																																																																			this.varvar.Text = "encryption";
																																																																																																																																																																																																																			this.varvalue.Text = "2";
																																																																																																																																																																																																																		}
																																																																																																																																																																																																																		else
																																																																																																																																																																																																																		{
																																																																																																																																																																																																																			bool flag209 = this.SearchVar.Text == "entitybatchsize";
																																																																																																																																																																																																																			if (flag209)
																																																																																																																																																																																																																			{
																																																																																																																																																																																																																				this.varvar.Text = "entitybatchsize";
																																																																																																																																																																																																																				this.varvalue.Text = "100";
																																																																																																																																																																																																																			}
																																																																																																																																																																																																																			else
																																																																																																																																																																																																																			{
																																																																																																																																																																																																																				bool flag210 = this.SearchVar.Text == "entitybatchtime";
																																																																																																																																																																																																																				if (flag210)
																																																																																																																																																																																																																				{
																																																																																																																																																																																																																					this.varvar.Text = "entitybatchtime";
																																																																																																																																																																																																																					this.varvalue.Text = "1";
																																																																																																																																																																																																																				}
																																																																																																																																																																																																																				else
																																																																																																																																																																																																																				{
																																																																																																																																																																																																																					bool flag211 = this.SearchVar.Text == "entityrate";
																																																																																																																																																																																																																					if (flag211)
																																																																																																																																																																																																																					{
																																																																																																																																																																																																																						this.varvar.Text = "entityrate";
																																																																																																																																																																																																																						this.varvalue.Text = "16";
																																																																																																																																																																																																																					}
																																																																																																																																																																																																																					else
																																																																																																																																																																																																																					{
																																																																																																																																																																																																																						bool flag212 = this.SearchVar.Text == "events";
																																																																																																																																																																																																																						if (flag212)
																																																																																																																																																																																																																						{
																																																																																																																																																																																																																							this.varvar.Text = "events";
																																																																																																																																																																																																																							this.varvalue.Text = "True";
																																																																																																																																																																																																																						}
																																																																																																																																																																																																																						else
																																																																																																																																																																																																																						{
																																																																																																																																																																																																																							bool flag213 = this.SearchVar.Text == "globalchat";
																																																																																																																																																																																																																							if (flag213)
																																																																																																																																																																																																																							{
																																																																																																																																																																																																																								this.varvar.Text = "globalchat";
																																																																																																																																																																																																																								this.varvalue.Text = "True";
																																																																																																																																																																																																																							}
																																																																																																																																																																																																																							else
																																																																																																																																																																																																																							{
																																																																																																																																																																																																																								bool flag214 = this.SearchVar.Text == "idlekick";
																																																																																																																																																																																																																								if (flag214)
																																																																																																																																																																																																																								{
																																																																																																																																																																																																																									this.varvar.Text = "idlekick";
																																																																																																																																																																																																																									this.varvalue.Text = "30";
																																																																																																																																																																																																																								}
																																																																																																																																																																																																																								else
																																																																																																																																																																																																																								{
																																																																																																																																																																																																																									bool flag215 = this.SearchVar.Text == "idlekickadmins";
																																																																																																																																																																																																																									if (flag215)
																																																																																																																																																																																																																									{
																																																																																																																																																																																																																										this.varvar.Text = "idlekickadmins";
																																																																																																																																																																																																																										this.varvalue.Text = "0";
																																																																																																																																																																																																																									}
																																																																																																																																																																																																																									else
																																																																																																																																																																																																																									{
																																																																																																																																																																																																																										bool flag216 = this.SearchVar.Text == "idlekickmode";
																																																																																																																																																																																																																										if (flag216)
																																																																																																																																																																																																																										{
																																																																																																																																																																																																																											this.varvar.Text = "idlekickmode";
																																																																																																																																																																																																																											this.varvalue.Text = "1";
																																																																																																																																																																																																																										}
																																																																																																																																																																																																																										else
																																																																																																																																																																																																																										{
																																																																																																																																																																																																																											bool flag217 = this.SearchVar.Text == "ipqueriespermin";
																																																																																																																																																																																																																											if (flag217)
																																																																																																																																																																																																																											{
																																																																																																																																																																																																																												this.varvar.Text = "ipqueriespermin";
																																																																																																																																																																																																																												this.varvalue.Text = "30";
																																																																																																																																																																																																																											}
																																																																																																																																																																																																																											else
																																																																																																																																																																																																																											{
																																																																																																																																																																																																																												bool flag218 = this.SearchVar.Text == "itemdespawn";
																																																																																																																																																																																																																												if (flag218)
																																																																																																																																																																																																																												{
																																																																																																																																																																																																																													this.varvar.Text = "itemdespawn";
																																																																																																																																																																																																																													this.varvalue.Text = "300";
																																																																																																																																																																																																																												}
																																																																																																																																																																																																																												else
																																																																																																																																																																																																																												{
																																																																																																																																																																																																																													bool flag219 = this.SearchVar.Text == "maxcommandpacketsize";
																																																																																																																																																																																																																													if (flag219)
																																																																																																																																																																																																																													{
																																																																																																																																																																																																																														this.varvar.Text = "maxcommandpacketsize";
																																																																																																																																																																																																																														this.varvalue.Text = "1000000";
																																																																																																																																																																																																																													}
																																																																																																																																																																																																																													else
																																																																																																																																																																																																																													{
																																																																																																																																																																																																																														bool flag220 = this.SearchVar.Text == "maxcommandspersecond";
																																																																																																																																																																																																																														if (flag220)
																																																																																																																																																																																																																														{
																																																																																																																																																																																																																															this.varvar.Text = "maxcommandspersecond";
																																																																																																																																																																																																																															this.varvalue.Text = "100";
																																																																																																																																																																																																																														}
																																																																																																																																																																																																																														else
																																																																																																																																																																																																																														{
																																																																																																																																																																																																																															bool flag221 = this.SearchVar.Text == "maxpacketsize";
																																																																																																																																																																																																																															if (flag221)
																																																																																																																																																																																																																															{
																																																																																																																																																																																																																																this.varvar.Text = "maxpacketsize";
																																																																																																																																																																																																																																this.varvalue.Text = "5000000";
																																																																																																																																																																																																																															}
																																																																																																																																																																																																																															else
																																																																																																																																																																																																																															{
																																																																																																																																																																																																																																bool flag222 = this.SearchVar.Text == "maxpacketspersecond";
																																																																																																																																																																																																																																if (flag222)
																																																																																																																																																																																																																																{
																																																																																																																																																																																																																																	this.varvar.Text = "maxpacketspersecond";
																																																																																																																																																																																																																																	this.varvalue.Text = "1500";
																																																																																																																																																																																																																																}
																																																																																																																																																																																																																																else
																																																																																																																																																																																																																																{
																																																																																																																																																																																																																																	bool flag223 = this.SearchVar.Text == "maxreceivetime";
																																																																																																																																																																																																																																	if (flag223)
																																																																																																																																																																																																																																	{
																																																																																																																																																																																																																																		this.varvar.Text = "maxreceivetime";
																																																																																																																																																																																																																																		this.varvalue.Text = "20";
																																																																																																																																																																																																																																	}
																																																																																																																																																																																																																																	else
																																																																																																																																																																																																																																	{
																																																																																																																																																																																																																																		bool flag224 = this.SearchVar.Text == "maxrpcspersecond";
																																																																																																																																																																																																																																		if (flag224)
																																																																																																																																																																																																																																		{
																																																																																																																																																																																																																																			this.varvar.Text = "maxrpcspersecond";
																																																																																																																																																																																																																																			this.varvalue.Text = "200";
																																																																																																																																																																																																																																		}
																																																																																																																																																																																																																																		else
																																																																																																																																																																																																																																		{
																																																																																																																																																																																																																																			bool flag225 = this.SearchVar.Text == "maxtickspersecond";
																																																																																																																																																																																																																																			if (flag225)
																																																																																																																																																																																																																																			{
																																																																																																																																																																																																																																				this.varvar.Text = "maxtickspersecond";
																																																																																																																																																																																																																																				this.varvalue.Text = "300";
																																																																																																																																																																																																																																			}
																																																																																																																																																																																																																																			else
																																																																																																																																																																																																																																			{
																																																																																																																																																																																																																																				bool flag226 = this.SearchVar.Text == "maxunack";
																																																																																																																																																																																																																																				if (flag226)
																																																																																																																																																																																																																																				{
																																																																																																																																																																																																																																					this.varvar.Text = "maxunack";
																																																																																																																																																																																																																																					this.varvalue.Text = "4";
																																																																																																																																																																																																																																				}
																																																																																																																																																																																																																																				else
																																																																																																																																																																																																																																				{
																																																																																																																																																																																																																																					bool flag227 = this.SearchVar.Text == "meleearmor";
																																																																																																																																																																																																																																					if (flag227)
																																																																																																																																																																																																																																					{
																																																																																																																																																																																																																																						this.varvar.Text = "meleearmor";
																																																																																																																																																																																																																																						this.varvalue.Text = "1";
																																																																																																																																																																																																																																					}
																																																																																																																																																																																																																																					else
																																																																																																																																																																																																																																					{
																																																																																																																																																																																																																																						bool flag228 = this.SearchVar.Text == "meleedamage";
																																																																																																																																																																																																																																						if (flag228)
																																																																																																																																																																																																																																						{
																																																																																																																																																																																																																																							this.varvar.Text = "meleedamage";
																																																																																																																																																																																																																																							this.varvalue.Text = "1";
																																																																																																																																																																																																																																						}
																																																																																																																																																																																																																																						else
																																																																																																																																																																																																																																						{
																																																																																																																																																																																																																																							bool flag229 = this.SearchVar.Text == "metabolismtick";
																																																																																																																																																																																																																																							if (flag229)
																																																																																																																																																																																																																																							{
																																																																																																																																																																																																																																								this.varvar.Text = "metabolismtick";
																																																																																																																																																																																																																																								this.varvalue.Text = "1";
																																																																																																																																																																																																																																							}
																																																																																																																																																																																																																																							else
																																																																																																																																																																																																																																							{
																																																																																																																																																																																																																																								bool flag230 = this.SearchVar.Text == "netcache";
																																																																																																																																																																																																																																								if (flag230)
																																																																																																																																																																																																																																								{
																																																																																																																																																																																																																																									this.varvar.Text = "netcache";
																																																																																																																																																																																																																																									this.varvalue.Text = "True";
																																																																																																																																																																																																																																								}
																																																																																																																																																																																																																																								else
																																																																																																																																																																																																																																								{
																																																																																																																																																																																																																																									bool flag231 = this.SearchVar.Text == "netcachesize";
																																																																																																																																																																																																																																									if (flag231)
																																																																																																																																																																																																																																									{
																																																																																																																																																																																																																																										this.varvar.Text = "netcachesize";
																																																																																																																																																																																																																																										this.varvalue.Text = "0";
																																																																																																																																																																																																																																									}
																																																																																																																																																																																																																																									else
																																																																																																																																																																																																																																									{
																																																																																																																																																																																																																																										bool flag232 = this.SearchVar.Text == "official";
																																																																																																																																																																																																																																										if (flag232)
																																																																																																																																																																																																																																										{
																																																																																																																																																																																																																																											this.varvar.Text = "official";
																																																																																																																																																																																																																																											this.varvalue.Text = "False";
																																																																																																																																																																																																																																										}
																																																																																																																																																																																																																																										else
																																																																																																																																																																																																																																										{
																																																																																																																																																																																																																																											bool flag233 = this.SearchVar.Text == "plantlightdetection";
																																																																																																																																																																																																																																											if (flag233)
																																																																																																																																																																																																																																											{
																																																																																																																																																																																																																																												this.varvar.Text = "plantlightdetection";
																																																																																																																																																																																																																																												this.varvalue.Text = "True";
																																																																																																																																																																																																																																											}
																																																																																																																																																																																																																																											else
																																																																																																																																																																																																																																											{
																																																																																																																																																																																																																																												bool flag234 = this.SearchVar.Text == "planttick";
																																																																																																																																																																																																																																												if (flag234)
																																																																																																																																																																																																																																												{
																																																																																																																																																																																																																																													this.varvar.Text = "planttick";
																																																																																																																																																																																																																																													this.varvalue.Text = "60";
																																																																																																																																																																																																																																												}
																																																																																																																																																																																																																																												else
																																																																																																																																																																																																																																												{
																																																																																																																																																																																																																																													bool flag235 = this.SearchVar.Text == "planttickscale";
																																																																																																																																																																																																																																													if (flag235)
																																																																																																																																																																																																																																													{
																																																																																																																																																																																																																																														this.varvar.Text = "planttickscale";
																																																																																																																																																																																																																																														this.varvalue.Text = "1";
																																																																																																																																																																																																																																													}
																																																																																																																																																																																																																																													else
																																																																																																																																																																																																																																													{
																																																																																																																																																																																																																																														bool flag236 = this.SearchVar.Text == "playerserverfall";
																																																																																																																																																																																																																																														if (flag236)
																																																																																																																																																																																																																																														{
																																																																																																																																																																																																																																															this.varvar.Text = "playerserverfall";
																																																																																																																																																																																																																																															this.varvalue.Text = "True";
																																																																																																																																																																																																																																														}
																																																																																																																																																																																																																																														else
																																																																																																																																																																																																																																														{
																																																																																																																																																																																																																																															bool flag237 = this.SearchVar.Text == "playertimeout";
																																																																																																																																																																																																																																															if (flag237)
																																																																																																																																																																																																																																															{
																																																																																																																																																																																																																																																this.varvar.Text = "playertimeout";
																																																																																																																																																																																																																																																this.varvalue.Text = "60";
																																																																																																																																																																																																																																															}
																																																																																																																																																																																																																																															else
																																																																																																																																																																																																																																															{
																																																																																																																																																																																																																																																bool flag238 = this.SearchVar.Text == "pve";
																																																																																																																																																																																																																																																if (flag238)
																																																																																																																																																																																																																																																{
																																																																																																																																																																																																																																																	this.varvar.Text = "pve";
																																																																																																																																																																																																																																																	this.varvalue.Text = "False";
																																																																																																																																																																																																																																																}
																																																																																																																																																																																																																																																else
																																																																																																																																																																																																																																																{
																																																																																																																																																																																																																																																	bool flag239 = this.SearchVar.Text == "respawnresetrange";
																																																																																																																																																																																																																																																	if (flag239)
																																																																																																																																																																																																																																																	{
																																																																																																																																																																																																																																																		this.varvar.Text = "respawnresetrange";
																																																																																																																																																																																																																																																		this.varvalue.Text = "50";
																																																																																																																																																																																																																																																	}
																																																																																																																																																																																																																																																	else
																																																																																																																																																																																																																																																	{
																																																																																																																																																																																																																																																		bool flag240 = this.SearchVar.Text == "savecachesize";
																																																																																																																																																																																																																																																		if (flag240)
																																																																																																																																																																																																																																																		{
																																																																																																																																																																																																																																																			this.varvar.Text = "savecachesize";
																																																																																																																																																																																																																																																			this.varvalue.Text = "1881";
																																																																																																																																																																																																																																																		}
																																																																																																																																																																																																																																																		else
																																																																																																																																																																																																																																																		{
																																																																																																																																																																																																																																																			bool flag241 = this.SearchVar.Text == "saveinterval";
																																																																																																																																																																																																																																																			if (flag241)
																																																																																																																																																																																																																																																			{
																																																																																																																																																																																																																																																				this.varvar.Text = "saveinterval";
																																																																																																																																																																																																																																																				this.varvalue.Text = "600";
																																																																																																																																																																																																																																																			}
																																																																																																																																																																																																																																																			else
																																																																																																																																																																																																																																																			{
																																																																																																																																																																																																																																																				bool flag242 = this.SearchVar.Text == "schematime";
																																																																																																																																																																																																																																																				if (flag242)
																																																																																																																																																																																																																																																				{
																																																																																																																																																																																																																																																					this.varvar.Text = "schematime";
																																																																																																																																																																																																																																																					this.varvalue.Text = "1800";
																																																																																																																																																																																																																																																				}
																																																																																																																																																																																																																																																				else
																																																																																																																																																																																																																																																				{
																																																																																																																																																																																																																																																					bool flag243 = this.SearchVar.Text == "secure";
																																																																																																																																																																																																																																																					if (flag243)
																																																																																																																																																																																																																																																					{
																																																																																																																																																																																																																																																						this.varvar.Text = "secure";
																																																																																																																																																																																																																																																						this.varvalue.Text = "True";
																																																																																																																																																																																																																																																					}
																																																																																																																																																																																																																																																					else
																																																																																																																																																																																																																																																					{
																																																																																																																																																																																																																																																						bool flag244 = this.SearchVar.Text == "showholstereditems";
																																																																																																																																																																																																																																																						if (flag244)
																																																																																																																																																																																																																																																						{
																																																																																																																																																																																																																																																							this.varvar.Text = "showholstereditems";
																																																																																																																																																																																																																																																							this.varvalue.Text = "True";
																																																																																																																																																																																																																																																						}
																																																																																																																																																																																																																																																						else
																																																																																																																																																																																																																																																						{
																																																																																																																																																																																																																																																							bool flag245 = this.SearchVar.Text == "stability";
																																																																																																																																																																																																																																																							if (flag245)
																																																																																																																																																																																																																																																							{
																																																																																																																																																																																																																																																								this.varvar.Text = "stability";
																																																																																																																																																																																																																																																								this.varvalue.Text = "True";
																																																																																																																																																																																																																																																							}
																																																																																																																																																																																																																																																							else
																																																																																																																																																																																																																																																							{
																																																																																																																																																																																																																																																								bool flag246 = this.SearchVar.Text == "updatebatchspawn";
																																																																																																																																																																																																																																																								if (flag246)
																																																																																																																																																																																																																																																								{
																																																																																																																																																																																																																																																									this.varvar.Text = "updatebatchspawn";
																																																																																																																																																																																																																																																									this.varvalue.Text = "1024";
																																																																																																																																																																																																																																																								}
																																																																																																																																																																																																																																																								else
																																																																																																																																																																																																																																																								{
																																																																																																																																																																																																																																																									bool flag247 = this.SearchVar.Text == "max_density";
																																																																																																																																																																																																																																																									if (flag247)
																																																																																																																																																																																																																																																									{
																																																																																																																																																																																																																																																										this.varvar.Text = "max_density";
																																																																																																																																																																																																																																																										this.varvalue.Text = "1";
																																																																																																																																																																																																																																																									}
																																																																																																																																																																																																																																																									else
																																																																																																																																																																																																																																																									{
																																																																																																																																																																																																																																																										bool flag248 = this.SearchVar.Text == "max_rate";
																																																																																																																																																																																																																																																										if (flag248)
																																																																																																																																																																																																																																																										{
																																																																																																																																																																																																																																																											this.varvar.Text = "max_rate";
																																																																																																																																																																																																																																																											this.varvalue.Text = "1";
																																																																																																																																																																																																																																																										}
																																																																																																																																																																																																																																																										else
																																																																																																																																																																																																																																																										{
																																																																																																																																																																																																																																																											bool flag249 = this.SearchVar.Text == "min_density";
																																																																																																																																																																																																																																																											if (flag249)
																																																																																																																																																																																																																																																											{
																																																																																																																																																																																																																																																												this.varvar.Text = "min_density";
																																																																																																																																																																																																																																																												this.varvalue.Text = "0.5";
																																																																																																																																																																																																																																																											}
																																																																																																																																																																																																																																																											else
																																																																																																																																																																																																																																																											{
																																																																																																																																																																																																																																																												bool flag250 = this.SearchVar.Text == "min_rate";
																																																																																																																																																																																																																																																												if (flag250)
																																																																																																																																																																																																																																																												{
																																																																																																																																																																																																																																																													this.varvar.Text = "min_rate";
																																																																																																																																																																																																																																																													this.varvalue.Text = "0.5";
																																																																																																																																																																																																																																																												}
																																																																																																																																																																																																																																																												else
																																																																																																																																																																																																																																																												{
																																																																																																																																																																																																																																																													bool flag251 = this.SearchVar.Text == "player_base";
																																																																																																																																																																																																																																																													if (flag251)
																																																																																																																																																																																																																																																													{
																																																																																																																																																																																																																																																														this.varvar.Text = "player_base";
																																																																																																																																																																																																																																																														this.varvalue.Text = "100";
																																																																																																																																																																																																																																																													}
																																																																																																																																																																																																																																																													else
																																																																																																																																																																																																																																																													{
																																																																																																																																																																																																																																																														bool flag252 = this.SearchVar.Text == "player_scale";
																																																																																																																																																																																																																																																														if (flag252)
																																																																																																																																																																																																																																																														{
																																																																																																																																																																																																																																																															this.varvar.Text = "player_scale";
																																																																																																																																																																																																																																																															this.varvalue.Text = "2";
																																																																																																																																																																																																																																																														}
																																																																																																																																																																																																																																																														else
																																																																																																																																																																																																																																																														{
																																																																																																																																																																																																																																																															bool flag253 = this.SearchVar.Text == "respawn_groups";
																																																																																																																																																																																																																																																															if (flag253)
																																																																																																																																																																																																																																																															{
																																																																																																																																																																																																																																																																this.varvar.Text = "respawn_groups";
																																																																																																																																																																																																																																																																this.varvalue.Text = "True";
																																																																																																																																																																																																																																																															}
																																																																																																																																																																																																																																																															else
																																																																																																																																																																																																																																																															{
																																																																																																																																																																																																																																																																bool flag254 = this.SearchVar.Text == "respawn_individuals";
																																																																																																																																																																																																																																																																if (flag254)
																																																																																																																																																																																																																																																																{
																																																																																																																																																																																																																																																																	this.varvar.Text = "respawn_individuals";
																																																																																																																																																																																																																																																																	this.varvalue.Text = "True";
																																																																																																																																																																																																																																																																}
																																																																																																																																																																																																																																																																else
																																																																																																																																																																																																																																																																{
																																																																																																																																																																																																																																																																	bool flag255 = this.SearchVar.Text == "respawn_populations";
																																																																																																																																																																																																																																																																	if (flag255)
																																																																																																																																																																																																																																																																	{
																																																																																																																																																																																																																																																																		this.varvar.Text = "respawn_populations";
																																																																																																																																																																																																																																																																		this.varvalue.Text = "True";
																																																																																																																																																																																																																																																																	}
																																																																																																																																																																																																																																																																	else
																																																																																																																																																																																																																																																																	{
																																																																																																																																																																																																																																																																		bool flag256 = this.SearchVar.Text == "tick_individuals";
																																																																																																																																																																																																																																																																		if (flag256)
																																																																																																																																																																																																																																																																		{
																																																																																																																																																																																																																																																																			this.varvar.Text = "tick_individuals";
																																																																																																																																																																																																																																																																			this.varvalue.Text = "300";
																																																																																																																																																																																																																																																																		}
																																																																																																																																																																																																																																																																		else
																																																																																																																																																																																																																																																																		{
																																																																																																																																																																																																																																																																			bool flag257 = this.SearchVar.Text == "tick_populations";
																																																																																																																																																																																																																																																																			if (flag257)
																																																																																																																																																																																																																																																																			{
																																																																																																																																																																																																																																																																				this.varvar.Text = "tick_populations";
																																																																																																																																																																																																																																																																				this.varvalue.Text = "60";
																																																																																																																																																																																																																																																																			}
																																																																																																																																																																																																																																																																			else
																																																																																																																																																																																																																																																																			{
																																																																																																																																																																																																																																																																				bool flag258 = this.SearchVar.Text == "accuracy";
																																																																																																																																																																																																																																																																				if (flag258)
																																																																																																																																																																																																																																																																				{
																																																																																																																																																																																																																																																																					this.varvar.Text = "accuracy";
																																																																																																																																																																																																																																																																					this.varvalue.Text = "0.001";
																																																																																																																																																																																																																																																																				}
																																																																																																																																																																																																																																																																				else
																																																																																																																																																																																																																																																																				{
																																																																																																																																																																																																																																																																					bool flag259 = this.SearchVar.Text == "collapse";
																																																																																																																																																																																																																																																																					if (flag259)
																																																																																																																																																																																																																																																																					{
																																																																																																																																																																																																																																																																						this.varvar.Text = "collapse";
																																																																																																																																																																																																																																																																						this.varvalue.Text = "0.05";
																																																																																																																																																																																																																																																																					}
																																																																																																																																																																																																																																																																					else
																																																																																																																																																																																																																																																																					{
																																																																																																																																																																																																																																																																						bool flag260 = this.SearchVar.Text == "stabilityqueue";
																																																																																																																																																																																																																																																																						if (flag260)
																																																																																																																																																																																																																																																																						{
																																																																																																																																																																																																																																																																							this.varvar.Text = "stabilityqueue";
																																																																																																																																																																																																																																																																							this.varvalue.Text = "9";
																																																																																																																																																																																																																																																																						}
																																																																																																																																																																																																																																																																						else
																																																																																																																																																																																																																																																																						{
																																																																																																																																																																																																																																																																							bool flag261 = this.SearchVar.Text == "strikes";
																																																																																																																																																																																																																																																																							if (flag261)
																																																																																																																																																																																																																																																																							{
																																																																																																																																																																																																																																																																								this.varvar.Text = "strikes";
																																																																																																																																																																																																																																																																								this.varvalue.Text = "10";
																																																																																																																																																																																																																																																																							}
																																																																																																																																																																																																																																																																							else
																																																																																																																																																																																																																																																																							{
																																																																																																																																																																																																																																																																								bool flag262 = this.SearchVar.Text == "surroundingsqueue";
																																																																																																																																																																																																																																																																								if (flag262)
																																																																																																																																																																																																																																																																								{
																																																																																																																																																																																																																																																																									this.varvar.Text = "surroundingsqueue";
																																																																																																																																																																																																																																																																									this.varvalue.Text = "3";
																																																																																																																																																																																																																																																																								}
																																																																																																																																																																																																																																																																								else
																																																																																																																																																																																																																																																																								{
																																																																																																																																																																																																																																																																									bool flag263 = this.SearchVar.Text == "stability.verbose";
																																																																																																																																																																																																																																																																									if (flag263)
																																																																																																																																																																																																																																																																									{
																																																																																																																																																																																																																																																																										this.varvar.Text = "stability.verbose";
																																																																																																																																																																																																																																																																										this.varvalue.Text = "0";
																																																																																																																																																																																																																																																																									}
																																																																																																																																																																																																																																																																									else
																																																																																																																																																																																																																																																																									{
																																																																																																																																																																																																																																																																										bool flag264 = this.SearchVar.Text == "fixeddelta";
																																																																																																																																																																																																																																																																										if (flag264)
																																																																																																																																																																																																																																																																										{
																																																																																																																																																																																																																																																																											this.varvar.Text = "fixeddelta";
																																																																																																																																																																																																																																																																											this.varvalue.Text = "0.0625";
																																																																																																																																																																																																																																																																										}
																																																																																																																																																																																																																																																																										else
																																																																																																																																																																																																																																																																										{
																																																																																																																																																																																																																																																																											bool flag265 = this.SearchVar.Text == "maxdelta";
																																																																																																																																																																																																																																																																											if (flag265)
																																																																																																																																																																																																																																																																											{
																																																																																																																																																																																																																																																																												this.varvar.Text = "maxdelta";
																																																																																																																																																																																																																																																																												this.varvalue.Text = "0.125";
																																																																																																																																																																																																																																																																											}
																																																																																																																																																																																																																																																																											else
																																																																																																																																																																																																																																																																											{
																																																																																																																																																																																																																																																																												bool flag266 = this.SearchVar.Text == "pausewhileloading";
																																																																																																																																																																																																																																																																												if (flag266)
																																																																																																																																																																																																																																																																												{
																																																																																																																																																																																																																																																																													this.varvar.Text = "pausewhileloading";
																																																																																																																																																																																																																																																																													this.varvalue.Text = "True";
																																																																																																																																																																																																																																																																												}
																																																																																																																																																																																																																																																																												else
																																																																																																																																																																																																																																																																												{
																																																																																																																																																																																																																																																																													bool flag267 = this.SearchVar.Text == "timescale";
																																																																																																																																																																																																																																																																													if (flag267)
																																																																																																																																																																																																																																																																													{
																																																																																																																																																																																																																																																																														this.varvar.Text = "timescale";
																																																																																																																																																																																																																																																																														this.varvalue.Text = "1";
																																																																																																																																																																																																																																																																													}
																																																																																																																																																																																																																																																																													else
																																																																																																																																																																																																																																																																													{
																																																																																																																																																																																																																																																																														bool flag268 = this.SearchVar.Text == "global_broadcast";
																																																																																																																																																																																																																																																																														if (flag268)
																																																																																																																																																																																																																																																																														{
																																																																																																																																																																																																																																																																															this.varvar.Text = "global_broadcast";
																																																																																																																																																																																																																																																																															this.varvalue.Text = "False";
																																																																																																																																																																																																																																																																														}
																																																																																																																																																																																																																																																																														else
																																																																																																																																																																																																																																																																														{
																																																																																																																																																																																																																																																																															bool flag269 = this.SearchVar.Text == "boat_corpse_seconds";
																																																																																																																																																																																																																																																																															if (flag269)
																																																																																																																																																																																																																																																																															{
																																																																																																																																																																																																																																																																																this.varvar.Text = "boat_corpse_seconds";
																																																																																																																																																																																																																																																																																this.varvalue.Text = "300";
																																																																																																																																																																																																																																																																															}
																																																																																																																																																																																																																																																																															else
																																																																																																																																																																																																																																																																															{
																																																																																																																																																																																																																																																																																bool flag270 = this.SearchVar.Text == "attack";
																																																																																																																																																																																																																																																																																if (flag270)
																																																																																																																																																																																																																																																																																{
																																																																																																																																																																																																																																																																																	this.varvar.Text = "attack";
																																																																																																																																																																																																																																																																																	this.varvalue.Text = "False";
																																																																																																																																																																																																																																																																																}
																																																																																																																																																																																																																																																																																else
																																																																																																																																																																																																																																																																																{
																																																																																																																																																																																																																																																																																	bool flag271 = this.SearchVar.Text == "damage";
																																																																																																																																																																																																																																																																																	if (flag271)
																																																																																																																																																																																																																																																																																	{
																																																																																																																																																																																																																																																																																		this.varvar.Text = "damage";
																																																																																																																																																																																																																																																																																		this.varvalue.Text = "False";
																																																																																																																																																																																																																																																																																	}
																																																																																																																																																																																																																																																																																	else
																																																																																																																																																																																																																																																																																	{
																																																																																																																																																																																																																																																																																		bool flag272 = this.SearchVar.Text == "hitboxes";
																																																																																																																																																																																																																																																																																		if (flag272)
																																																																																																																																																																																																																																																																																		{
																																																																																																																																																																																																																																																																																			this.varvar.Text = "hitboxes";
																																																																																																																																																																																																																																																																																			this.varvalue.Text = "False";
																																																																																																																																																																																																																																																																																		}
																																																																																																																																																																																																																																																																																		else
																																																																																																																																																																																																																																																																																		{
																																																																																																																																																																																																																																																																																			bool flag273 = this.SearchVar.Text == "lineofsight";
																																																																																																																																																																																																																																																																																			if (flag273)
																																																																																																																																																																																																																																																																																			{
																																																																																																																																																																																																																																																																																				this.varvar.Text = "lineofsight";
																																																																																																																																																																																																																																																																																				this.varvalue.Text = "False";
																																																																																																																																																																																																																																																																																			}
																																																																																																																																																																																																																																																																																			else
																																																																																																																																																																																																																																																																																			{
																																																																																																																																																																																																																																																																																				bool flag274 = this.SearchVar.Text == "protection";
																																																																																																																																																																																																																																																																																				if (flag274)
																																																																																																																																																																																																																																																																																				{
																																																																																																																																																																																																																																																																																					this.varvar.Text = "protection";
																																																																																																																																																																																																																																																																																					this.varvalue.Text = "False";
																																																																																																																																																																																																																																																																																				}
																																																																																																																																																																																																																																																																																				else
																																																																																																																																																																																																																																																																																				{
																																																																																																																																																																																																																																																																																					bool flag275 = this.SearchVar.Text == "sense";
																																																																																																																																																																																																																																																																																					if (flag275)
																																																																																																																																																																																																																																																																																					{
																																																																																																																																																																																																																																																																																						this.varvar.Text = "sense";
																																																																																																																																																																																																																																																																																						this.varvalue.Text = "False";
																																																																																																																																																																																																																																																																																					}
																																																																																																																																																																																																																																																																																					else
																																																																																																																																																																																																																																																																																					{
																																																																																																																																																																																																																																																																																						bool flag276 = this.SearchVar.Text == "triggers";
																																																																																																																																																																																																																																																																																						if (flag276)
																																																																																																																																																																																																																																																																																						{
																																																																																																																																																																																																																																																																																							this.varvar.Text = "triggers";
																																																																																																																																																																																																																																																																																							this.varvalue.Text = "False";
																																																																																																																																																																																																																																																																																						}
																																																																																																																																																																																																																																																																																						else
																																																																																																																																																																																																																																																																																						{
																																																																																																																																																																																																																																																																																							bool flag277 = this.SearchVar.Text == "weakspots";
																																																																																																																																																																																																																																																																																							if (flag277)
																																																																																																																																																																																																																																																																																							{
																																																																																																																																																																																																																																																																																								this.varvar.Text = "weakspots";
																																																																																																																																																																																																																																																																																								this.varvalue.Text = "False";
																																																																																																																																																																																																																																																																																							}
																																																																																																																																																																																																																																																																																							else
																																																																																																																																																																																																																																																																																							{
																																																																																																																																																																																																																																																																																								bool flag278 = this.SearchVar.Text == "cache";
																																																																																																																																																																																																																																																																																								if (flag278)
																																																																																																																																																																																																																																																																																								{
																																																																																																																																																																																																																																																																																									this.varvar.Text = "cache";
																																																																																																																																																																																																																																																																																									this.varvalue.Text = "True";
																																																																																																																																																																																																																																																																																								}
																																																																																																																																																																																																																																																																																								else
																																																																																																																																																																																																																																																																																								{
																																																																																																																																																																																																																																																																																									bool flag279 = this.SearchVar.Text == "xmas.enabled";
																																																																																																																																																																																																																																																																																									if (flag279)
																																																																																																																																																																																																																																																																																									{
																																																																																																																																																																																																																																																																																										this.varvar.Text = "xmas.enabled";
																																																																																																																																																																																																																																																																																										this.varvalue.Text = "False";
																																																																																																																																																																																																																																																																																									}
																																																																																																																																																																																																																																																																																									else
																																																																																																																																																																																																																																																																																									{
																																																																																																																																																																																																																																																																																										bool flag280 = this.SearchVar.Text == "giftsperplayer";
																																																																																																																																																																																																																																																																																										if (flag280)
																																																																																																																																																																																																																																																																																										{
																																																																																																																																																																																																																																																																																											this.varvar.Text = "giftsperplayer";
																																																																																																																																																																																																																																																																																											this.varvalue.Text = "2";
																																																																																																																																																																																																																																																																																										}
																																																																																																																																																																																																																																																																																										else
																																																																																																																																																																																																																																																																																										{
																																																																																																																																																																																																																																																																																											bool flag281 = this.SearchVar.Text == "spawnattempts";
																																																																																																																																																																																																																																																																																											if (flag281)
																																																																																																																																																																																																																																																																																											{
																																																																																																																																																																																																																																																																																												this.varvar.Text = "spawnattempts";
																																																																																																																																																																																																																																																																																												this.varvalue.Text = "5";
																																																																																																																																																																																																																																																																																											}
																																																																																																																																																																																																																																																																																											else
																																																																																																																																																																																																																																																																																											{
																																																																																																																																																																																																																																																																																												bool flag282 = this.SearchVar.Text == "spawnrange";
																																																																																																																																																																																																																																																																																												if (flag282)
																																																																																																																																																																																																																																																																																												{
																																																																																																																																																																																																																																																																																													this.varvar.Text = "spawnrange";
																																																																																																																																																																																																																																																																																													this.varvalue.Text = "49";
																																																																																																																																																																																																																																																																																												}
																																																																																																																																																																																																																																																																																												else
																																																																																																																																																																																																																																																																																												{
																																																																																																																																																																																																																																																																																													bool flag283 = this.SearchVar.Text == "print";
																																																																																																																																																																																																																																																																																													if (flag283)
																																																																																																																																																																																																																																																																																													{
																																																																																																																																																																																																																																																																																														this.varvar.Text = "print";
																																																																																																																																																																																																																																																																																														this.varvalue.Text = "True";
																																																																																																																																																																																																																																																																																													}
																																																																																																																																																																																																																																																																																													else
																																																																																																																																																																																																																																																																																													{
																																																																																																																																																																																																																																																																																														bool flag284 = this.SearchVar.Text == "web";
																																																																																																																																																																																																																																																																																														if (flag284)
																																																																																																																																																																																																																																																																																														{
																																																																																																																																																																																																																																																																																															this.varvar.Text = "web";
																																																																																																																																																																																																																																																																																															this.varvalue.Text = "True";
																																																																																																																																																																																																																																																																																														}
																																																																																																																																																																																																																																																																																														else
																																																																																																																																																																																																																																																																																														{
																																																																																																																																																																																																																																																																																															bool flag285 = this.SearchVar.Text == "decayseconds";
																																																																																																																																																																																																																																																																																															if (flag285)
																																																																																																																																																																																																																																																																																															{
																																																																																																																																																																																																																																																																																																this.varvar.Text = "decayseconds";
																																																																																																																																																																																																																																																																																																this.varvalue.Text = "7200";
																																																																																																																																																																																																																																																																																															}
																																																																																																																																																																																																																																																																																															else
																																																																																																																																																																																																																																																																																															{
																																																																																																																																																																																																																																																																																																bool flag286 = this.SearchVar.Text == "requiredhackseconds";
																																																																																																																																																																																																																																																																																																if (flag286)
																																																																																																																																																																																																																																																																																																{
																																																																																																																																																																																																																																																																																																	this.varvar.Text = "requiredhackseconds";
																																																																																																																																																																																																																																																																																																	this.varvalue.Text = "900";
																																																																																																																																																																																																																																																																																																}
																																																																																																																																																																																																																																																																																																else
																																																																																																																																																																																																																																																																																																{
																																																																																																																																																																																																																																																																																																	bool flag287 = this.SearchVar.Text == "horse.population";
																																																																																																																																																																																																																																																																																																	if (flag287)
																																																																																																																																																																																																																																																																																																	{
																																																																																																																																																																																																																																																																																																		this.varvar.Text = "horse.population";
																																																																																																																																																																																																																																																																																																		this.varvalue.Text = "0";
																																																																																																																																																																																																																																																																																																	}
																																																																																																																																																																																																																																																																																																	else
																																																																																																																																																																																																																																																																																																	{
																																																																																																																																																																																																																																																																																																		bool flag288 = this.SearchVar.Text == "hotairballoon.population";
																																																																																																																																																																																																																																																																																																		if (flag288)
																																																																																																																																																																																																																																																																																																		{
																																																																																																																																																																																																																																																																																																			this.varvar.Text = "hotairballoon.population";
																																																																																																																																																																																																																																																																																																			this.varvalue.Text = "1";
																																																																																																																																																																																																																																																																																																		}
																																																																																																																																																																																																																																																																																																		else
																																																																																																																																																																																																																																																																																																		{
																																																																																																																																																																																																																																																																																																			bool flag289 = this.SearchVar.Text == "serviceceiling";
																																																																																																																																																																																																																																																																																																			if (flag289)
																																																																																																																																																																																																																																																																																																			{
																																																																																																																																																																																																																																																																																																				this.varvar.Text = "serviceceiling";
																																																																																																																																																																																																																																																																																																				this.varvalue.Text = "200";
																																																																																																																																																																																																																																																																																																			}
																																																																																																																																																																																																																																																																																																			else
																																																																																																																																																																																																																																																																																																			{
																																																																																																																																																																																																																																																																																																				bool flag290 = this.SearchVar.Text == "hotairballoon.outsidedecayminutes";
																																																																																																																																																																																																																																																																																																				if (flag290)
																																																																																																																																																																																																																																																																																																				{
																																																																																																																																																																																																																																																																																																					this.varvar.Text = "hotairballoon.outsidedecayminutes";
																																																																																																																																																																																																																																																																																																					this.varvalue.Text = "180";
																																																																																																																																																																																																																																																																																																				}
																																																																																																																																																																																																																																																																																																				else
																																																																																																																																																																																																																																																																																																				{
																																																																																																																																																																																																																																																																																																					bool flag291 = this.SearchVar.Text == "backtracking";
																																																																																																																																																																																																																																																																																																					if (flag291)
																																																																																																																																																																																																																																																																																																					{
																																																																																																																																																																																																																																																																																																						this.varvar.Text = "backtracking";
																																																																																																																																																																																																																																																																																																						this.varvalue.Text = "8";
																																																																																																																																																																																																																																																																																																					}
																																																																																																																																																																																																																																																																																																					else
																																																																																																																																																																																																																																																																																																					{
																																																																																																																																																																																																																																																																																																						bool flag292 = this.SearchVar.Text == "ioentity.framebudgetms";
																																																																																																																																																																																																																																																																																																						if (flag292)
																																																																																																																																																																																																																																																																																																						{
																																																																																																																																																																																																																																																																																																							this.varvar.Text = "ioentity.framebudgetms";
																																																																																																																																																																																																																																																																																																							this.varvalue.Text = "1";
																																																																																																																																																																																																																																																																																																						}
																																																																																																																																																																																																																																																																																																						else
																																																																																																																																																																																																																																																																																																						{
																																																																																																																																																																																																																																																																																																							bool flag293 = this.SearchVar.Text == "responsetime";
																																																																																																																																																																																																																																																																																																							if (flag293)
																																																																																																																																																																																																																																																																																																							{
																																																																																																																																																																																																																																																																																																								this.varvar.Text = "responsetime";
																																																																																																																																																																																																																																																																																																								this.varvalue.Text = "0.1";
																																																																																																																																																																																																																																																																																																							}
																																																																																																																																																																																																																																																																																																							else
																																																																																																																																																																																																																																																																																																							{
																																																																																																																																																																																																																																																																																																								bool flag294 = this.SearchVar.Text == "minicopter.outsidedecayminutes";
																																																																																																																																																																																																																																																																																																								if (flag294)
																																																																																																																																																																																																																																																																																																								{
																																																																																																																																																																																																																																																																																																									this.varvar.Text = "minicopter.outsidedecayminutes";
																																																																																																																																																																																																																																																																																																									this.varvalue.Text = "240";
																																																																																																																																																																																																																																																																																																								}
																																																																																																																																																																																																																																																																																																								else
																																																																																																																																																																																																																																																																																																								{
																																																																																																																																																																																																																																																																																																									bool flag295 = this.SearchVar.Text == "minicopter.population";
																																																																																																																																																																																																																																																																																																									if (flag295)
																																																																																																																																																																																																																																																																																																									{
																																																																																																																																																																																																																																																																																																										this.varvar.Text = "minicopter.population";
																																																																																																																																																																																																																																																																																																										this.varvalue.Text = "1";
																																																																																																																																																																																																																																																																																																									}
																																																																																																																																																																																																																																																																																																									else
																																																																																																																																																																																																																																																																																																									{
																																																																																																																																																																																																																																																																																																										bool flag296 = this.SearchVar.Text == "motorrowboat.outsidedecayminutes";
																																																																																																																																																																																																																																																																																																										if (flag296)
																																																																																																																																																																																																																																																																																																										{
																																																																																																																																																																																																																																																																																																											this.varvar.Text = "motorrowboat.outsidedecayminutes";
																																																																																																																																																																																																																																																																																																											this.varvalue.Text = "180";
																																																																																																																																																																																																																																																																																																										}
																																																																																																																																																																																																																																																																																																										else
																																																																																																																																																																																																																																																																																																										{
																																																																																																																																																																																																																																																																																																											bool flag297 = this.SearchVar.Text == "motorrowboat.population";
																																																																																																																																																																																																																																																																																																											if (flag297)
																																																																																																																																																																																																																																																																																																											{
																																																																																																																																																																																																																																																																																																												this.varvar.Text = "motorrowboat.population";
																																																																																																																																																																																																																																																																																																												this.varvalue.Text = "4";
																																																																																																																																																																																																																																																																																																											}
																																																																																																																																																																																																																																																																																																											else
																																																																																																																																																																																																																																																																																																											{
																																																																																																																																																																																																																																																																																																												bool flag298 = this.SearchVar.Text == "sleeperhostiledelay";
																																																																																																																																																																																																																																																																																																												if (flag298)
																																																																																																																																																																																																																																																																																																												{
																																																																																																																																																																																																																																																																																																													this.varvar.Text = "sleeperhostiledelay";
																																																																																																																																																																																																																																																																																																													this.varvalue.Text = "1200";
																																																																																																																																																																																																																																																																																																												}
																																																																																																																																																																																																																																																																																																												else
																																																																																																																																																																																																																																																																																																												{
																																																																																																																																																																																																																																																																																																													bool flag299 = this.SearchVar.Text == "forcebirthday";
																																																																																																																																																																																																																																																																																																													if (flag299)
																																																																																																																																																																																																																																																																																																													{
																																																																																																																																																																																																																																																																																																														this.varvar.Text = "forcebirthday";
																																																																																																																																																																																																																																																																																																														this.varvalue.Text = "False";
																																																																																																																																																																																																																																																																																																													}
																																																																																																																																																																																																																																																																																																													else
																																																																																																																																																																																																																																																																																																													{
																																																																																																																																																																																																																																																																																																														bool flag300 = this.SearchVar.Text == "maxteamsize";
																																																																																																																																																																																																																																																																																																														if (flag300)
																																																																																																																																																																																																																																																																																																														{
																																																																																																																																																																																																																																																																																																															this.varvar.Text = "maxteamsize";
																																																																																																																																																																																																																																																																																																															this.varvalue.Text = "8";
																																																																																																																																																																																																																																																																																																														}
																																																																																																																																																																																																																																																																																																														else
																																																																																																																																																																																																																																																																																																														{
																																																																																																																																																																																																																																																																																																															bool flag301 = this.SearchVar.Text == "rhibpopulation";
																																																																																																																																																																																																																																																																																																															if (flag301)
																																																																																																																																																																																																																																																																																																															{
																																																																																																																																																																																																																																																																																																																this.varvar.Text = "rhibpopulation";
																																																																																																																																																																																																																																																																																																																this.varvalue.Text = "1";
																																																																																																																																																																																																																																																																																																															}
																																																																																																																																																																																																																																																																																																															else
																																																																																																																																																																																																																																																																																																															{
																																																																																																																																																																																																																																																																																																																bool flag302 = this.SearchVar.Text == "ridablehorse.population";
																																																																																																																																																																																																																																																																																																																if (flag302)
																																																																																																																																																																																																																																																																																																																{
																																																																																																																																																																																																																																																																																																																	this.varvar.Text = "ridablehorse.population";
																																																																																																																																																																																																																																																																																																																	this.varvalue.Text = "4";
																																																																																																																																																																																																																																																																																																																}
																																																																																																																																																																																																																																																																																																																else
																																																																																																																																																																																																																																																																																																																{
																																																																																																																																																																																																																																																																																																																	bool flag303 = this.SearchVar.Text == "ai_dormant";
																																																																																																																																																																																																																																																																																																																	if (flag303)
																																																																																																																																																																																																																																																																																																																	{
																																																																																																																																																																																																																																																																																																																		this.varvar.Text = "ai_dormant";
																																																																																																																																																																																																																																																																																																																		this.varvalue.Text = "True";
																																																																																																																																																																																																																																																																																																																	}
																																																																																																																																																																																																																																																																																																																	else
																																																																																																																																																																																																																																																																																																																	{
																																																																																																																																																																																																																																																																																																																		bool flag304 = this.SearchVar.Text == "ai_dormant_max_wakeup_per_tick";
																																																																																																																																																																																																																																																																																																																		if (flag304)
																																																																																																																																																																																																																																																																																																																		{
																																																																																																																																																																																																																																																																																																																			this.varvar.Text = "ai_dormant_max_wakeup_per_tick";
																																																																																																																																																																																																																																																																																																																			this.varvalue.Text = "30";
																																																																																																																																																																																																																																																																																																																		}
																																																																																																																																																																																																																																																																																																																		else
																																																																																																																																																																																																																																																																																																																		{
																																																																																																																																																																																																																																																																																																																			bool flag305 = this.SearchVar.Text == "ai_htn_animal_tick_budget";
																																																																																																																																																																																																																																																																																																																			if (flag305)
																																																																																																																																																																																																																																																																																																																			{
																																																																																																																																																																																																																																																																																																																				this.varvar.Text = "ai_htn_animal_tick_budget";
																																																																																																																																																																																																																																																																																																																				this.varvalue.Text = "4";
																																																																																																																																																																																																																																																																																																																			}
																																																																																																																																																																																																																																																																																																																			else
																																																																																																																																																																																																																																																																																																																			{
																																																																																																																																																																																																																																																																																																																				bool flag306 = this.SearchVar.Text == "ai_htn_player_junkpile_tick_budget";
																																																																																																																																																																																																																																																																																																																				if (flag306)
																																																																																																																																																																																																																																																																																																																				{
																																																																																																																																																																																																																																																																																																																					this.varvar.Text = "ai_htn_player_junkpile_tick_budget";
																																																																																																																																																																																																																																																																																																																					this.varvalue.Text = "4";
																																																																																																																																																																																																																																																																																																																				}
																																																																																																																																																																																																																																																																																																																				else
																																																																																																																																																																																																																																																																																																																				{
																																																																																																																																																																																																																																																																																																																					bool flag307 = this.SearchVar.Text == "ai_htn_player_tick_budget";
																																																																																																																																																																																																																																																																																																																					if (flag307)
																																																																																																																																																																																																																																																																																																																					{
																																																																																																																																																																																																																																																																																																																						this.varvar.Text = "ai_htn_player_tick_budget";
																																																																																																																																																																																																																																																																																																																						this.varvalue.Text = "4";
																																																																																																																																																																																																																																																																																																																					}
																																																																																																																																																																																																																																																																																																																					else
																																																																																																																																																																																																																																																																																																																					{
																																																																																																																																																																																																																																																																																																																						bool flag308 = this.SearchVar.Text == "ai_htn_player_tick_budget";
																																																																																																																																																																																																																																																																																																																						if (flag308)
																																																																																																																																																																																																																																																																																																																						{
																																																																																																																																																																																																																																																																																																																							this.varvar.Text = "ai_htn_player_tick_budget";
																																																																																																																																																																																																																																																																																																																							this.varvalue.Text = "4";
																																																																																																																																																																																																																																																																																																																						}
																																																																																																																																																																																																																																																																																																																						else
																																																																																																																																																																																																																																																																																																																						{
																																																																																																																																																																																																																																																																																																																							bool flag309 = this.SearchVar.Text == "ai_htn_use_agency_tick";
																																																																																																																																																																																																																																																																																																																							if (flag309)
																																																																																																																																																																																																																																																																																																																							{
																																																																																																																																																																																																																																																																																																																								this.varvar.Text = "ai_htn_use_agency_tick";
																																																																																																																																																																																																																																																																																																																								this.varvalue.Text = "True";
																																																																																																																																																																																																																																																																																																																							}
																																																																																																																																																																																																																																																																																																																							else
																																																																																																																																																																																																																																																																																																																							{
																																																																																																																																																																																																																																																																																																																								bool flag310 = this.SearchVar.Text == "ai_to_player_distance_wakeup_range";
																																																																																																																																																																																																																																																																																																																								if (flag310)
																																																																																																																																																																																																																																																																																																																								{
																																																																																																																																																																																																																																																																																																																									this.varvar.Text = "ai_to_player_distance_wakeup_range";
																																																																																																																																																																																																																																																																																																																									this.varvalue.Text = "160";
																																																																																																																																																																																																																																																																																																																								}
																																																																																																																																																																																																																																																																																																																								else
																																																																																																																																																																																																																																																																																																																								{
																																																																																																																																																																																																																																																																																																																									bool flag311 = this.SearchVar.Text == "nav_disable";
																																																																																																																																																																																																																																																																																																																									if (flag311)
																																																																																																																																																																																																																																																																																																																									{
																																																																																																																																																																																																																																																																																																																										this.varvar.Text = "nav_disable";
																																																																																																																																																																																																																																																																																																																										this.varvalue.Text = "False";
																																																																																																																																																																																																																																																																																																																									}
																																																																																																																																																																																																																																																																																																																									else
																																																																																																																																																																																																																																																																																																																									{
																																																																																																																																																																																																																																																																																																																										bool flag312 = this.SearchVar.Text == "nav_obstacles_carve_state";
																																																																																																																																																																																																																																																																																																																										if (flag312)
																																																																																																																																																																																																																																																																																																																										{
																																																																																																																																																																																																																																																																																																																											this.varvar.Text = "nav_obstacles_carve_state";
																																																																																																																																																																																																																																																																																																																											this.varvalue.Text = "2";
																																																																																																																																																																																																																																																																																																																										}
																																																																																																																																																																																																																																																																																																																										else
																																																																																																																																																																																																																																																																																																																										{
																																																																																																																																																																																																																																																																																																																											bool flag313 = this.SearchVar.Text == "nav_wait";
																																																																																																																																																																																																																																																																																																																											if (flag313)
																																																																																																																																																																																																																																																																																																																											{
																																																																																																																																																																																																																																																																																																																												this.varvar.Text = "nav_wait";
																																																																																																																																																																																																																																																																																																																												this.varvalue.Text = "True";
																																																																																																																																																																																																																																																																																																																											}
																																																																																																																																																																																																																																																																																																																											else
																																																																																																																																																																																																																																																																																																																											{
																																																																																																																																																																																																																																																																																																																												bool flag314 = this.SearchVar.Text == "pathfindingiterationsperframe";
																																																																																																																																																																																																																																																																																																																												if (flag314)
																																																																																																																																																																																																																																																																																																																												{
																																																																																																																																																																																																																																																																																																																													this.varvar.Text = "pathfindingiterationsperframe";
																																																																																																																																																																																																																																																																																																																													this.varvalue.Text = "100";
																																																																																																																																																																																																																																																																																																																												}
																																																																																																																																																																																																																																																																																																																												else
																																																																																																																																																																																																																																																																																																																												{
																																																																																																																																																																																																																																																																																																																													bool flag315 = this.SearchVar.Text == "cover_point_sample_step_height";
																																																																																																																																																																																																																																																																																																																													if (flag315)
																																																																																																																																																																																																																																																																																																																													{
																																																																																																																																																																																																																																																																																																																														this.varvar.Text = "cover_point_sample_step_height";
																																																																																																																																																																																																																																																																																																																														this.varvalue.Text = "2";
																																																																																																																																																																																																																																																																																																																													}
																																																																																																																																																																																																																																																																																																																													else
																																																																																																																																																																																																																																																																																																																													{
																																																																																																																																																																																																																																																																																																																														bool flag316 = this.SearchVar.Text == "cover_point_sample_step_size";
																																																																																																																																																																																																																																																																																																																														if (flag316)
																																																																																																																																																																																																																																																																																																																														{
																																																																																																																																																																																																																																																																																																																															this.varvar.Text = "cover_point_sample_step_size";
																																																																																																																																																																																																																																																																																																																															this.varvalue.Text = "6";
																																																																																																																																																																																																																																																																																																																														}
																																																																																																																																																																																																																																																																																																																														else
																																																																																																																																																																																																																																																																																																																														{
																																																																																																																																																																																																																																																																																																																															bool flag317 = this.SearchVar.Text == "cover_point_sample_step_size";
																																																																																																																																																																																																																																																																																																																															if (flag317)
																																																																																																																																																																																																																																																																																																																															{
																																																																																																																																																																																																																																																																																																																																this.varvar.Text = "cover_point_sample_step_size";
																																																																																																																																																																																																																																																																																																																																this.varvalue.Text = "6";
																																																																																																																																																																																																																																																																																																																															}
																																																																																																																																																																																																																																																																																																																															else
																																																																																																																																																																																																																																																																																																																															{
																																																																																																																																																																																																																																																																																																																																bool flag318 = this.SearchVar.Text == "alltarget";
																																																																																																																																																																																																																																																																																																																																if (flag318)
																																																																																																																																																																																																																																																																																																																																{
																																																																																																																																																																																																																																																																																																																																	this.varvar.Text = "alltarget";
																																																																																																																																																																																																																																																																																																																																	this.varvalue.Text = "False";
																																																																																																																																																																																																																																																																																																																																}
																																																																																																																																																																																																																																																																																																																																else
																																																																																																																																																																																																																																																																																																																																{
																																																																																																																																																																																																																																																																																																																																	bool flag319 = this.SearchVar.Text == "staticrepairseconds";
																																																																																																																																																																																																																																																																																																																																	if (flag319)
																																																																																																																																																																																																																																																																																																																																	{
																																																																																																																																																																																																																																																																																																																																		this.varvar.Text = "staticrepairseconds";
																																																																																																																																																																																																																																																																																																																																		this.varvalue.Text = "1200";
																																																																																																																																																																																																																																																																																																																																	}
																																																																																																																																																																																																																																																																																																																																	else
																																																																																																																																																																																																																																																																																																																																	{
																																																																																																																																																																																																																																																																																																																																		bool flag320 = this.SearchVar.Text == "altitudeaboveterrain";
																																																																																																																																																																																																																																																																																																																																		if (flag320)
																																																																																																																																																																																																																																																																																																																																		{
																																																																																																																																																																																																																																																																																																																																			this.varvar.Text = "altitudeaboveterrain";
																																																																																																																																																																																																																																																																																																																																			this.varvalue.Text = "50";
																																																																																																																																																																																																																																																																																																																																		}
																																																																																																																																																																																																																																																																																																																																		else
																																																																																																																																																																																																																																																																																																																																		{
																																																																																																																																																																																																																																																																																																																																			bool flag321 = this.SearchVar.Text == "desiredaltitude";
																																																																																																																																																																																																																																																																																																																																			if (flag321)
																																																																																																																																																																																																																																																																																																																																			{
																																																																																																																																																																																																																																																																																																																																				this.varvar.Text = "desiredaltitude";
																																																																																																																																																																																																																																																																																																																																				this.varvalue.Text = "60";
																																																																																																																																																																																																																																																																																																																																			}
																																																																																																																																																																																																																																																																																																																																			else
																																																																																																																																																																																																																																																																																																																																			{
																																																																																																																																																																																																																																																																																																																																				bool flag322 = this.SearchVar.Text == "stag.population";
																																																																																																																																																																																																																																																																																																																																				if (flag322)
																																																																																																																																																																																																																																																																																																																																				{
																																																																																																																																																																																																																																																																																																																																					this.varvar.Text = "stag.population";
																																																																																																																																																																																																																																																																																																																																					this.varvalue.Text = "3";
																																																																																																																																																																																																																																																																																																																																				}
																																																																																																																																																																																																																																																																																																																																				else
																																																																																																																																																																																																																																																																																																																																				{
																																																																																																																																																																																																																																																																																																																																					bool flag323 = this.SearchVar.Text == "wolf.population";
																																																																																																																																																																																																																																																																																																																																					if (flag323)
																																																																																																																																																																																																																																																																																																																																					{
																																																																																																																																																																																																																																																																																																																																						this.varvar.Text = "wolf.population";
																																																																																																																																																																																																																																																																																																																																						this.varvalue.Text = "2";
																																																																																																																																																																																																																																																																																																																																					}
																																																																																																																																																																																																																																																																																																																																					else
																																																																																																																																																																																																																																																																																																																																					{
																																																																																																																																																																																																																																																																																																																																						bool flag324 = this.SearchVar.Text == "zombie.population";
																																																																																																																																																																																																																																																																																																																																						if (flag324)
																																																																																																																																																																																																																																																																																																																																						{
																																																																																																																																																																																																																																																																																																																																							this.varvar.Text = "zombie.population";
																																																																																																																																																																																																																																																																																																																																							this.varvalue.Text = "0";
																																																																																																																																																																																																																																																																																																																																						}
																																																																																																																																																																																																																																																																																																																																						else
																																																																																																																																																																																																																																																																																																																																						{
																																																																																																																																																																																																																																																																																																																																							bool flag325 = this.SearchVar.Text == "radiation";
																																																																																																																																																																																																																																																																																																																																							if (flag325)
																																																																																																																																																																																																																																																																																																																																							{
																																																																																																																																																																																																																																																																																																																																								this.varvar.Text = "radiation";
																																																																																																																																																																																																																																																																																																																																								this.varvalue.Text = "True";
																																																																																																																																																																																																																																																																																																																																							}
																																																																																																																																																																																																																																																																																																																																						}
																																																																																																																																																																																																																																																																																																																																					}
																																																																																																																																																																																																																																																																																																																																				}
																																																																																																																																																																																																																																																																																																																																			}
																																																																																																																																																																																																																																																																																																																																		}
																																																																																																																																																																																																																																																																																																																																	}
																																																																																																																																																																																																																																																																																																																																}
																																																																																																																																																																																																																																																																																																																															}
																																																																																																																																																																																																																																																																																																																														}
																																																																																																																																																																																																																																																																																																																													}
																																																																																																																																																																																																																																																																																																																												}
																																																																																																																																																																																																																																																																																																																											}
																																																																																																																																																																																																																																																																																																																										}
																																																																																																																																																																																																																																																																																																																									}
																																																																																																																																																																																																																																																																																																																								}
																																																																																																																																																																																																																																																																																																																							}
																																																																																																																																																																																																																																																																																																																						}
																																																																																																																																																																																																																																																																																																																					}
																																																																																																																																																																																																																																																																																																																				}
																																																																																																																																																																																																																																																																																																																			}
																																																																																																																																																																																																																																																																																																																		}
																																																																																																																																																																																																																																																																																																																	}
																																																																																																																																																																																																																																																																																																																}
																																																																																																																																																																																																																																																																																																															}
																																																																																																																																																																																																																																																																																																														}
																																																																																																																																																																																																																																																																																																													}
																																																																																																																																																																																																																																																																																																												}
																																																																																																																																																																																																																																																																																																											}
																																																																																																																																																																																																																																																																																																										}
																																																																																																																																																																																																																																																																																																									}
																																																																																																																																																																																																																																																																																																								}
																																																																																																																																																																																																																																																																																																							}
																																																																																																																																																																																																																																																																																																						}
																																																																																																																																																																																																																																																																																																					}
																																																																																																																																																																																																																																																																																																				}
																																																																																																																																																																																																																																																																																																			}
																																																																																																																																																																																																																																																																																																		}
																																																																																																																																																																																																																																																																																																	}
																																																																																																																																																																																																																																																																																																}
																																																																																																																																																																																																																																																																																															}
																																																																																																																																																																																																																																																																																														}
																																																																																																																																																																																																																																																																																													}
																																																																																																																																																																																																																																																																																												}
																																																																																																																																																																																																																																																																																											}
																																																																																																																																																																																																																																																																																										}
																																																																																																																																																																																																																																																																																									}
																																																																																																																																																																																																																																																																																								}
																																																																																																																																																																																																																																																																																							}
																																																																																																																																																																																																																																																																																						}
																																																																																																																																																																																																																																																																																					}
																																																																																																																																																																																																																																																																																				}
																																																																																																																																																																																																																																																																																			}
																																																																																																																																																																																																																																																																																		}
																																																																																																																																																																																																																																																																																	}
																																																																																																																																																																																																																																																																																}
																																																																																																																																																																																																																																																																															}
																																																																																																																																																																																																																																																																														}
																																																																																																																																																																																																																																																																													}
																																																																																																																																																																																																																																																																												}
																																																																																																																																																																																																																																																																											}
																																																																																																																																																																																																																																																																										}
																																																																																																																																																																																																																																																																									}
																																																																																																																																																																																																																																																																								}
																																																																																																																																																																																																																																																																							}
																																																																																																																																																																																																																																																																						}
																																																																																																																																																																																																																																																																					}
																																																																																																																																																																																																																																																																				}
																																																																																																																																																																																																																																																																			}
																																																																																																																																																																																																																																																																		}
																																																																																																																																																																																																																																																																	}
																																																																																																																																																																																																																																																																}
																																																																																																																																																																																																																																																															}
																																																																																																																																																																																																																																																														}
																																																																																																																																																																																																																																																													}
																																																																																																																																																																																																																																																												}
																																																																																																																																																																																																																																																											}
																																																																																																																																																																																																																																																										}
																																																																																																																																																																																																																																																									}
																																																																																																																																																																																																																																																								}
																																																																																																																																																																																																																																																							}
																																																																																																																																																																																																																																																						}
																																																																																																																																																																																																																																																					}
																																																																																																																																																																																																																																																				}
																																																																																																																																																																																																																																																			}
																																																																																																																																																																																																																																																		}
																																																																																																																																																																																																																																																	}
																																																																																																																																																																																																																																																}
																																																																																																																																																																																																																																															}
																																																																																																																																																																																																																																														}
																																																																																																																																																																																																																																													}
																																																																																																																																																																																																																																												}
																																																																																																																																																																																																																																											}
																																																																																																																																																																																																																																										}
																																																																																																																																																																																																																																									}
																																																																																																																																																																																																																																								}
																																																																																																																																																																																																																																							}
																																																																																																																																																																																																																																						}
																																																																																																																																																																																																																																					}
																																																																																																																																																																																																																																				}
																																																																																																																																																																																																																																			}
																																																																																																																																																																																																																																		}
																																																																																																																																																																																																																																	}
																																																																																																																																																																																																																																}
																																																																																																																																																																																																																															}
																																																																																																																																																																																																																														}
																																																																																																																																																																																																																													}
																																																																																																																																																																																																																												}
																																																																																																																																																																																																																											}
																																																																																																																																																																																																																										}
																																																																																																																																																																																																																									}
																																																																																																																																																																																																																								}
																																																																																																																																																																																																																							}
																																																																																																																																																																																																																						}
																																																																																																																																																																																																																					}
																																																																																																																																																																																																																				}
																																																																																																																																																																																																																			}
																																																																																																																																																																																																																		}
																																																																																																																																																																																																																	}
																																																																																																																																																																																																																}
																																																																																																																																																																																																															}
																																																																																																																																																																																																														}
																																																																																																																																																																																																													}
																																																																																																																																																																																																												}
																																																																																																																																																																																																											}
																																																																																																																																																																																																										}
																																																																																																																																																																																																									}
																																																																																																																																																																																																								}
																																																																																																																																																																																																							}
																																																																																																																																																																																																						}
																																																																																																																																																																																																					}
																																																																																																																																																																																																				}
																																																																																																																																																																																																			}
																																																																																																																																																																																																		}
																																																																																																																																																																																																	}
																																																																																																																																																																																																}
																																																																																																																																																																																															}
																																																																																																																																																																																														}
																																																																																																																																																																																													}
																																																																																																																																																																																												}
																																																																																																																																																																																											}
																																																																																																																																																																																										}
																																																																																																																																																																																									}
																																																																																																																																																																																								}
																																																																																																																																																																																							}
																																																																																																																																																																																						}
																																																																																																																																																																																					}
																																																																																																																																																																																				}
																																																																																																																																																																																			}
																																																																																																																																																																																		}
																																																																																																																																																																																	}
																																																																																																																																																																																}
																																																																																																																																																																															}
																																																																																																																																																																														}
																																																																																																																																																																													}
																																																																																																																																																																												}
																																																																																																																																																																											}
																																																																																																																																																																										}
																																																																																																																																																																									}
																																																																																																																																																																								}
																																																																																																																																																																							}
																																																																																																																																																																						}
																																																																																																																																																																					}
																																																																																																																																																																				}
																																																																																																																																																																			}
																																																																																																																																																																		}
																																																																																																																																																																	}
																																																																																																																																																																}
																																																																																																																																																															}
																																																																																																																																																														}
																																																																																																																																																													}
																																																																																																																																																												}
																																																																																																																																																											}
																																																																																																																																																										}
																																																																																																																																																									}
																																																																																																																																																								}
																																																																																																																																																							}
																																																																																																																																																						}
																																																																																																																																																					}
																																																																																																																																																				}
																																																																																																																																																			}
																																																																																																																																																		}
																																																																																																																																																	}
																																																																																																																																																}
																																																																																																																																															}
																																																																																																																																														}
																																																																																																																																													}
																																																																																																																																												}
																																																																																																																																											}
																																																																																																																																										}
																																																																																																																																									}
																																																																																																																																								}
																																																																																																																																							}
																																																																																																																																						}
																																																																																																																																					}
																																																																																																																																				}
																																																																																																																																			}
																																																																																																																																		}
																																																																																																																																	}
																																																																																																																																}
																																																																																																																															}
																																																																																																																														}
																																																																																																																													}
																																																																																																																												}
																																																																																																																											}
																																																																																																																										}
																																																																																																																									}
																																																																																																																								}
																																																																																																																							}
																																																																																																																						}
																																																																																																																					}
																																																																																																																				}
																																																																																																																			}
																																																																																																																		}
																																																																																																																	}
																																																																																																																}
																																																																																																															}
																																																																																																														}
																																																																																																													}
																																																																																																												}
																																																																																																											}
																																																																																																										}
																																																																																																									}
																																																																																																								}
																																																																																																							}
																																																																																																						}
																																																																																																					}
																																																																																																				}
																																																																																																			}
																																																																																																		}
																																																																																																	}
																																																																																																}
																																																																																															}
																																																																																														}
																																																																																													}
																																																																																												}
																																																																																											}
																																																																																										}
																																																																																									}
																																																																																								}
																																																																																							}
																																																																																						}
																																																																																					}
																																																																																				}
																																																																																			}
																																																																																		}
																																																																																	}
																																																																																}
																																																																															}
																																																																														}
																																																																													}
																																																																												}
																																																																											}
																																																																										}
																																																																									}
																																																																								}
																																																																							}
																																																																						}
																																																																					}
																																																																				}
																																																																			}
																																																																		}
																																																																	}
																																																																}
																																																															}
																																																														}
																																																													}
																																																												}
																																																											}
																																																										}
																																																									}
																																																								}
																																																							}
																																																						}
																																																					}
																																																				}
																																																			}
																																																		}
																																																	}
																																																}
																																															}
																																														}
																																													}
																																												}
																																											}
																																										}
																																									}
																																								}
																																							}
																																						}
																																					}
																																				}
																																			}
																																		}
																																	}
																																}
																															}
																														}
																													}
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			this.SearchVar.Clear();
		}


		private void BTNadd_Click(object sender, EventArgs e)
		{
			this.LockedLbl2.Visible = false;
			this.LockedLbl.Visible = false;
			this.ServerVarsFinal.Text = "";
			this.ServerVars.Rows.Add(new object[]
			{
				this.varvar.Text,
				this.varvalue.Text
			});
			this.varvar.Clear();
			this.varvalue.Clear();
		}


		private void Btnclear_Click_1(object sender, EventArgs e)
		{
			this.varvar.Clear();
			this.varvalue.Clear();
		}


		private void BtnCLLearVars_Click(object sender, EventArgs e)
		{
			this.ServerVars.Rows.Clear();
			this.LockedLbl2.Visible = false;
			this.LockedLbl.Visible = false;
		}


		private void Button12_Click_1(object sender, EventArgs e)
		{
			Process.Start("http://bit.ly/2TflLgq");
		}


		private void BtnCompleteVars_Click(object sender, EventArgs e)
		{
			this.ServerVarsFinal.Text = "";
			foreach (object obj in ((IEnumerable)this.ServerVars.Rows))
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				for (int i = 0; i < dataGridViewRow.Cells.Count; i++)
				{
					int num = i;
					int num2 = num;
					if (num2 != 0)
					{
						if (num2 == 1)
						{
							this.ServerVarsFinal.Text = this.ServerVarsFinal.Text + "\"" + dataGridViewRow.Cells[i].Value.ToString() + "\" ";
						}
					}
					else
					{
						this.ServerVarsFinal.Text = this.ServerVarsFinal.Text + "+" + dataGridViewRow.Cells[i].Value.ToString() + " ";
					}
				}
			}
			this.LockedLbl.ForeColor = Color.Red;
			this.LockedLbl2.ForeColor = Color.Red;
			this.LockedLbl2.Visible = true;
			this.LockedLbl.Visible = true;
			this.ServerVars.Enabled = false;
		}


		private void StartFileList_MouseClick(object sender, MouseEventArgs e)
		{
			this.StartFileList.Items.Clear();
			try
			{
				foreach (string text in Directory.GetFiles(this.servfilesdirectory.Text))
				{
					bool flag = text.Contains(".bat");
					if (flag)
					{
						this.StartFileList.Items.Add(Path.GetFileName(text));
					}
				}
			}
            catch
            {
				MessageBox.Show("Could not find Rust Server Files!");
            }
		}


		private void ServerFolderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("Explorer.exe", this.currentpath);
		}


		private void ServerFilesFolderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("Explorer.exe", this.servfilesdirectory.Text);
		}


		private void SteamCMDToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Process.Start("Explorer.exe", this.currentpath + this.steamcmdbox.Text);
		}

		private string Cleanupbat(string data)
        {
			data = data.Replace(@"""", "");
			data = data.Replace(@"\", "");
			data = data.TrimEnd().TrimStart();
			return data;
        }


		private void StartFileList_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				string filen = StartFileList.Text;
				string text = System.IO.File.ReadAllText(@"RustServerFiles\\" + filen);

				//load in bat file.
				string Identity = "";
				string Hostname = "";
				string Level = "";
				string Seed = "";
				string Worldsize = "";
				string Maxplayers = "";
				string RconIP = "";
				string RconPort = "";
				string ServerPort = "";
				string Password = "";
				string Description = "";
				string URL = "";
				string Headerimage = "";


				string[] perams = text.Split(new string[] { "+server." }, System.StringSplitOptions.RemoveEmptyEntries);

				for (int i = 0; i < perams.Length; i++)
				{
					perams[i] = "+" + perams[i];
				}


				foreach (string peramtest in perams)
				{

					if (peramtest.Contains(@"+identity "))
					{
						Identity = Cleanupbat(peramtest.Replace(@"+identity ", ""));
					}

					else if (peramtest.Contains(@"+hostname "))
					{
						Hostname = Cleanupbat(peramtest.Replace(@"+hostname ", ""));
						if (Hostname.Contains("+levelurl"))
                        {
							string[] customm = Hostname.Split(new string[] { " +levelurl" }, StringSplitOptions.None);
							Hostname = customm[0];
							Level = customm[1].TrimStart();
						}
					}
					else if (peramtest.Contains(@"+level "))
					{
						Level = peramtest.Remove(peramtest.Length - 2);
						Level = Level.Replace(@"+level", "");
						Level = Level.Replace(@"""", "");
						Level = Level.Replace(@"\", "");
						Level = Level.Trim();

					}
					else if (peramtest.Contains(@"+seed "))
					{
						Seed = Cleanupbat(peramtest.Replace(@"+seed ", ""));
					}
					else if (peramtest.Contains(@"+worldsize "))
					{
						Worldsize = Cleanupbat(peramtest.Replace(@"+worldsize ", ""));
					}
					else if (peramtest.Contains(@"+maxplayers "))
					{
						string[] peramsplitter = peramtest.Split(new string[] { "+rcon." }, System.StringSplitOptions.RemoveEmptyEntries);

						foreach (string ps in peramsplitter)
						{
							if (ps.Contains("+maxplayers "))
							{
								Maxplayers = ps.Replace("+maxplayers ", "");
								Maxplayers = Maxplayers.TrimEnd();
							}
							else if (ps.Contains("ip "))
							{
								RconIP = ps.Replace("ip ", "");
								RconIP = RconIP.TrimEnd();
							}
							else if (ps.Contains("port "))
							{
								RconPort = ps.Replace("port ", "");
								RconPort = RconPort.TrimEnd();
							}
						}

					}
					else if (peramtest.Contains(@"+port "))
					{
						string[] peramsplitter = peramtest.Split(new string[] { "+rcon." }, System.StringSplitOptions.RemoveEmptyEntries);

						foreach (string ps in peramsplitter)
						{
							if (ps.Contains("+port "))
							{
								ServerPort = ps.Replace("+port ", "");
								ServerPort = ServerPort.TrimEnd();

							}
							else if (ps.Contains("password "))
							{
								Password = Cleanupbat(ps.Replace("password ", ""));
							}
						}

					}
					else if (peramtest.Contains(@"+description "))
					{
						Description = peramtest.Replace(@"+description ", "");
						Description = Description.Replace(@"""", "");
						Description = Description.Replace(@"\", "");
						Description = Description.Trim();
					}
					else if (peramtest.Contains(@"+url "))
					{
						URL = peramtest.Substring(6, peramtest.Length - 8);



					}
					else if (peramtest.Contains(@"+headerimage "))
					{

						string[] peramsplitter = peramtest.Split(new string[] { " " }, System.StringSplitOptions.RemoveEmptyEntries);
						Headerimage = peramsplitter[1].Substring(1, peramsplitter[1].Length - 2);

						string varname = "";
						string varvalue = "";

						this.ServerVarsFinal.Text = "";
						BtnCLLearVars_Click(null, null);
						for (int i = 2; i < peramsplitter.Length - 2; i++)
                        {
							if (!peramsplitter[i].Contains("-logfile") && !peramsplitter[i].Contains("logs.log"))
							{
								varname = peramsplitter[i].Replace("+", "");
								i++;
								varvalue = peramsplitter[i].Substring(1, peramsplitter[i].Length - 2);
								this.ServerVars.Rows.Add(new object[]
								{
								varname,
								varvalue
								});
							}
						}
						if (varname != "")
						{
							BtnCompleteVars_Click(null, null);
						}

					}
				}
				MyIP = RconIP;
				switch (Level)
				{
					case "Procedural Map":
						da.SelectedIndex = 0;
						identitytext.Text = Identity;
						servernametext.Text = Hostname;
						serverporttext.Text = ServerPort;
						rconporttext.Text = RconPort;
						rconpasstext.Text = Password;
						serverpicturetext.Text = Headerimage;
						serverurltext.Text = URL;
						serverdisctext.Text = Description;
						maxplayertext.Text = Maxplayers;
						mapsizebox.Text = Worldsize;
						mapseedtext.Text = Seed;
						break;
					case "Barren":
						da.SelectedIndex = 1;
						BAidentitytext.Text = Identity;
						BAservernametext.Text = Hostname;
						BAserverportext.Text = ServerPort;
						BArconporttext.Text = RconPort;
						BArconpasstext.Text = Password;
						BAserverpicturetext.Text = Headerimage;
						BAserverurltext.Text = URL;
						BAserverdisctext.Text = Description;
						BAmaxplayertext.Text = Maxplayers;
						BAmapsizebox.Text = Worldsize;
						BAmapseedtext.Text = Seed;
						break;
					case "HapisIsland":
						da.SelectedIndex = 3;
						HAidentitytext.Text = Identity;
						HPservernametext.Text = Hostname;
						HPserverportext.Text = ServerPort;
						HPrconporttext.Text = RconPort;
						HPrconpasstext.Text = Password;
						HPserverpicturetext.Text = Headerimage;
						HPserverurltext.Text = URL;
						HPserverdisctext.Text = Description;
						HPmaxplayertext.Text = Maxplayers;
						break;
					case "CraggyIsland":
						da.SelectedIndex = 4;
						CRidentitytext.Text = Identity;
						CRservernametext.Text = Hostname;
						CRserverportext.Text = ServerPort;
						CRrconporttext.Text = RconPort;
						CRrconpasstext.Text = Password;
						CRserverpicturetext.Text = Headerimage;
						CRserverurltext.Text = URL;
						CRserverdisctext.Text = Description;
						CRmaxplayertext.Text = Maxplayers;
						break;
					case "SavasIsland":
						da.SelectedIndex = 5;
						SAidentitytext.Text = Identity;
						SAservernametext.Text = Hostname;
						SAserverportext.Text = ServerPort;
						SArconporttext.Text = RconPort;
						SArconpasstext.Text = Password;
						SAserverpicturetext.Text = Headerimage;
						SAserverurltext.Text = URL;
						SAserverdisctext.Text = Description;
						SAmaxplayertext.Text = Maxplayers;
						break;
					case "SavasIsland_koth":
						da.SelectedIndex = 6;
						KOidentitytext.Text = Identity;
						KOservernametext.Text = Hostname;
						KOserverportext.Text = ServerPort;
						KOrconporttext.Text = RconPort;
						KOrconpasstext.Text = Password;
						KOserverpicturetext.Text = Headerimage;
						KOserverurltext.Text = URL;
						KOserverdisctext.Text = Description;
						KOmaxplayertext.Text = Maxplayers;
						break;
					default:
						da.SelectedIndex = 2;
						CMidentitytext.Text = Identity;
						CMservernametext.Text = Hostname;
						CMserverportext.Text = ServerPort;
						CMrconporttext.Text = RconPort;
						CMrconpasstext.Text = Password;
						CMserverpicturetext.Text = Headerimage;
						CMserverurltext.Text = URL;
						CMserverdisctext.Text = Description;
						CMmaxplayertext.Text = Maxplayers;
						mapurlbox.Text = Level;
						break;
				}
			}
			catch
            {
				MessageBox.Show("Error reading settings from selected .bat");
            }
		}


		private void BtnViewPage_Click(object sender, EventArgs e)
		{
			Process.Start(this.serverurltext.Text);
		}


		private const string steamCMDUrl = "https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip";
		private const string oxideUrl = "https://umod.org/games/rust/download";
		private static bool downloadingSteamCMD = false;
		private static bool downloadingOxide = false;
		private string currentpath = Directory.GetCurrentDirectory();
		public string SetValueForVar = "";

        
        private void addAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
				try
				{
					string[] subdirectoryEntries = Directory.GetDirectories("RustServerFiles\\server\\");
					foreach (string serverfolder in subdirectoryEntries)
					{
						DialogResult dialogResult2 = MessageBox.Show("Found " + serverfolder.Substring(23) + " do you want to add a admin to this server?", "Add Admin", MessageBoxButtons.YesNo);
						if (dialogResult2 == DialogResult.Yes)
						{
						string streamid = "";
						string input = "76000000000000000";
						if (ShowInputDialog(ref input, "Steam ID:") == DialogResult.OK)
						{
							streamid = input;

							if (streamid.Length == 17)
							{

								string subPath = "cfg";
                                bool exists = System.IO.Directory.Exists(serverfolder + "\\" + (subPath));


								if (!exists)
								{ 
									System.IO.Directory.CreateDirectory(serverfolder + "\\" + (subPath));
								}

								using (StreamWriter sw = File.AppendText(serverfolder + "\\" + subPath + "\\users.cfg"))
								{
									sw.WriteLine(@"ownerid " + streamid + @" """" """"");
								}
								MessageBox.Show("Restart server for it to take effect!");
							}
							else
                            {
								MessageBox.Show("Steam ID needs to be 17 digits in length");
                            }
						}
					}
					}
				 }
				catch
				{
                MessageBox.Show("Error finding server folder!");
                return;
				}
        }


        private void button4_Click_1(object sender, EventArgs e)
        {
			bool flag = this.ServerVarsFinal.Text == "";
			if (flag)
			{

				this.Finaltext.Text = "RustDedicated.exe -batchmode +server.identity " + @"""" + this.BAidentitytext.Text + @"""" + " +server.hostname " + @"""" + this.BAservernametext.Text + @""" +server.level ""Barren""" + " +server.seed " + @"""" + this.BAmapseedtext.Text + @"""" + " +server.worldsize " + @"""" + this.BAmapsizebox.Text + @"""" + " +server.maxplayers " + this.BAmaxplayertext.Text + @" +rcon.ip " + MyIP + " +rcon.port " + this.BArconporttext.Text + " +server.port " + this.BAserverportext.Text + " +rcon.password " + @"""" + this.BArconpasstext.Text + @"""" + " +server.description " + @"""" + this.BAserverdisctext.Text + @"""" + " +server.url " + @"""" + this.BAserverurltext.Text + @"""" + " +server.headerimage " + @"""" + this.BAserverpicturetext.Text + @"""" + " -logfile " + @"""" + this.LogLocation.Text + ".log" + @"""";

				//this.Finaltext.Text = string.Concat(new string[]
				//{
				//	"RustDedicated.exe -batchmode +server.identity \"",
				//	this.BAidentitytext.Text,
				//	"\" +server.hostname \"",
				//	this.BAservernametext.Text,
				//	"\" +server.level \"Barren\" +server.seed ",
				//	this.BAmapseedtext.Text,
				//	" +server.worldsize ",
				//	this.BAmapsizebox.Text,
				//	" +server.maxplayers ",
				//	this.BAmaxplayertext.Text,
				//	" +rcon.ip 127.0.0.1 +rcon.port ",
				//	this.BArconporttext.Text,
				//	" +server.port ",
				//	this.BAserverportext.Text,
				//	" +rcon.password \"",
				//	this.BArconpasstext.Text,
				//	"\" +server.description \"",
				//	this.BAserverdisctext.Text,
				//	"\" +server.url \"",
				//	this.BAserverurltext.Text,
				//	"\" +server.headerimage \"",
				//	this.BAserverpicturetext.Text,
				//	"\" -logfile \"",
				//	this.LogLocation.Text,
				//	".log\""
				//});
				//this.deditextbox.Text = string.Concat(new string[]
				//{
				//	"+server.identity \"barren\" +server.hostname \"",
				//	this.BAservernametext.Text,
				//	"\" +server.level \"barren\" +server.seed ",
				//	this.BAmapseedtext.Text,
				//	" +server.worldsize ",
				//	this.mapsizebox.Text,
				//	" +rcon.ip 127.0.0.1 +rcon.port ",
				//	this.BArconporttext.Text,
				//	" +rcon.password ",
				//	this.BArconpasstext.Text,
				//	" +server.description \"",
				//	this.BAserverdisctext.Text,
				//	"\" +server.url \"",
				//	this.BAserverurltext.Text,
				//	"\" +server.headerimage \"",
				//	this.BArconpasstext.Text,
				//	"\" -logfile\"",
				//	this.LogLocation.Text,
				//	".log\""
				//});
				this.serverdirectorytext.Text = string.Concat(new string[]
				{
					this.currentpath,
					this.slashbox.Text,
					"RustServerFiles",
					this.slashbox.Text,
					"Start Server File ",
					this.BAidentitytext.Text,
					".bat"
				});
				File.WriteAllText(this.serverdirectorytext.Text, this.Finaltext.Text);
				this.infolabel.Text = "Start file generated - Start you server";
			}
			else
			{
				this.Finaltext.Text = this.Finaltext.Text = "RustDedicated.exe -batchmode +server.identity " + @"""" + this.BAidentitytext.Text + @"""" + " +server.hostname " + @"""" + this.BAservernametext.Text + @""" +server.level ""Barren""" + " +server.seed " + @"""" + this.BAmapseedtext.Text + @"""" + " +server.worldsize " + @"""" + this.BAmapsizebox.Text + @"""" + " +server.maxplayers " + this.BAmaxplayertext.Text + @" +rcon.ip " + MyIP + " +rcon.port " + this.BArconporttext.Text + " +server.port " + this.BAserverportext.Text + " +rcon.password " + @"""" + this.BArconpasstext.Text + @"""" + " +server.description " + @"""" + this.BAserverdisctext.Text + @"""" + " +server.url " + @"""" + this.BAserverurltext.Text + @"""" + " +server.headerimage " + @"""" + this.BAserverpicturetext.Text + @"""" + " " + this.ServerVarsFinal.Text + "-logfile " + @"""" + this.LogLocation.Text + ".log" + @"""";

				//this.Finaltext.Text = string.Concat(new string[]
				//{
				//	"RustDedicated.exe -batchmode +server.identity \"",
				//	this.BAidentitytext.Text,
				//	"\" +server.hostname \"",
				//	this.BAservernametext.Text,
				//	"\" +server.level \"Barren\" +server.seed ",
				//	this.BAmapseedtext.Text,
				//	" +server.worldsize ",
				//	this.BAmapsizebox.Text,
				//	" +server.maxplayers ",
				//	this.BAmaxplayertext.Text,
				//	" +rcon.ip 127.0.0.1 +rcon.port ",
				//	this.BArconporttext.Text,
				//	" +server.port ",
				//	this.BAserverportext.Text,
				//	" +rcon.password \"",
				//	this.BArconpasstext.Text,
				//	"\" +server.description \"",
				//	this.BAserverdisctext.Text,
				//	"\" +server.url \"",
				//	this.BAserverurltext.Text,
				//	"\" +server.headerimage \"",
				//	this.BAserverpicturetext.Text,
				//	"\" ",
				//	this.ServerVarsFinal.Text,
				//	"-logfile \"",
				//	this.LogLocation.Text,
				//	".log\""
				//});
				//this.deditextbox.Text = string.Concat(new string[]
				//{
				//	"+server.identity \"barren\" +server.hostname \"",
				//	this.BAservernametext.Text,
				//	"\" +server.level \"barren\" +server.seed ",
				//	this.BAmapseedtext.Text,
				//	" +server.worldsize ",
				//	this.mapsizebox.Text,
				//	" +rcon.ip 127.0.0.1 +rcon.port ",
				//	this.BArconporttext.Text,
				//	" +rcon.password ",
				//	this.BArconpasstext.Text,
				//	" +server.description \"",
				//	this.BAserverdisctext.Text,
				//	"\" +server.url \"",
				//	this.BAserverurltext.Text,
				//	"\" +server.headerimage \"",
				//	this.BAserverpicturetext.Text,
				//	"\" -logfile\"",
				//	this.LogLocation.Text,
				//	".log\""
				//});
				this.serverdirectorytext.Text = string.Concat(new string[]
				{
					this.currentpath,
					this.slashbox.Text,
					"RustServerFiles",
					this.slashbox.Text,
					"Start Server File ",
					this.BAidentitytext.Text,
					".bat"
				});
				File.WriteAllText(this.serverdirectorytext.Text, this.Finaltext.Text);
				this.infolabel.Text = "Start file generated - Start you server";
			}
		}

        private void serverporttext_KeyPress(object sender, KeyPressEventArgs e)
        {
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
			(e.KeyChar != '.'))
			{
				e.Handled = true;
			}
		}

        private void rconporttext_KeyPress(object sender, KeyPressEventArgs e)
        {
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
			(e.KeyChar != '.'))
			{
				e.Handled = true;
			}
		}

        private void maxplayertext_KeyPress(object sender, KeyPressEventArgs e)
        {
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
			(e.KeyChar != '.'))
			{
				e.Handled = true;
			}
		}

        private void mapsizebox_KeyPress(object sender, KeyPressEventArgs e)
        {
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
			(e.KeyChar != '.'))
			{
				e.Handled = true;
			}
		}

        private void mapseedtext_KeyPress(object sender, KeyPressEventArgs e)
        {
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
			(e.KeyChar != '.'))
			{
				e.Handled = true;
			}
		}


        private void BAmapsizebox_Validating(object sender, CancelEventArgs e)
        {
			try
			{
				if (int.Parse(BAmapsizebox.Text) < 1000 || int.Parse(BAmapsizebox.Text) > 8000)
				{
					MessageBox.Show("Map size has to be between 1000 and 8000");
				}
				if (int.Parse(mapsizebox.Text) < 1000 || int.Parse(mapsizebox.Text) > 8000)
				{
					MessageBox.Show("Map size has to be between 1000 and 8000");
				}

			}
			catch
			{ }
		}

        private void setRconIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
			string input = MyIP;
			if (ShowInputDialog(ref input, "Rcon IP:") == DialogResult.OK)
			{
				MyIP = input;
			}
		}

        private void wipeMapOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
			DialogResult dialogResult = MessageBox.Show("Do you want to wipe the Map only?", "Wipe Map", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				try
				{
					string[] subdirectoryEntries = Directory.GetDirectories("RustServerFiles\\server\\");
					foreach (string serverfolder in subdirectoryEntries)
					{
						DialogResult dialogResult2 = MessageBox.Show("Found " + serverfolder.Substring(23) + " Wipe this map?", "Wipe Map", MessageBoxButtons.YesNo);
						if (dialogResult2 == DialogResult.Yes)
						{
							foreach (string file in Directory.GetFiles(serverfolder, "*.id").Where(item => item.EndsWith(".id")))
							{
								try
								{
									File.Delete(file);
								}
								catch
                                {
									MessageBox.Show("Failed to delete " + file);
                                }
							}
							foreach (string file in Directory.GetFiles(serverfolder, "*.map").Where(item => item.EndsWith(".map")))
							{
								try
								{
									File.Delete(file);
								}
								catch
								{
									MessageBox.Show("Failed to delete " + file);
								}
							}
							foreach (string file in Directory.GetFiles(serverfolder, "*.sav").Where(item => item.EndsWith(".sav")))
							{
								try
								{
									File.Delete(file);
								}
								catch
								{
									MessageBox.Show("Failed to delete " + file);
								}
							}
						}
					}
				}
				catch
				{
						MessageBox.Show("Error finding server folder!");
						return;
				}

			}

		}

        private void wipeServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
			DialogResult dialogResult = MessageBox.Show("Do you want to wipe the server", "Wipe server", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				try
				{
					string[] subdirectoryEntries = Directory.GetDirectories("RustServerFiles\\server\\");
					foreach (string serverfolder in subdirectoryEntries)
					{
						DialogResult dialogResult2 = MessageBox.Show("Found " + serverfolder.Substring(23) + " Wipe this server?", "Wipe server", MessageBoxButtons.YesNo);
						if (dialogResult2 == DialogResult.Yes)
						{
							foreach (string file in Directory.GetFiles(serverfolder, "*.id").Where(item => item.EndsWith(".id")))
							{
								try
								{
									File.Delete(file);
								}
								catch
								{
									MessageBox.Show("Failed to delete " + file);
								}
							}
							foreach (string file in Directory.GetFiles(serverfolder, "*.map").Where(item => item.EndsWith(".map")))
							{
								try
								{
									File.Delete(file);
								}
								catch
								{
									MessageBox.Show("Failed to delete " + file);
								}
							}
							foreach (string file in Directory.GetFiles(serverfolder, "*.sav").Where(item => item.EndsWith(".sav")))
							{
								try
								{
									File.Delete(file);
								}
								catch
								{
									MessageBox.Show("Failed to delete " + file);
								}
							}
							foreach (string file in Directory.GetFiles(serverfolder, "*.db").Where(item => item.EndsWith(".db")))
							{
								try
								{
									File.Delete(file);
								}
								catch
								{
									MessageBox.Show("Failed to delete " + file);
								}
							}
							foreach (string file in Directory.GetFiles(serverfolder, "*.txt").Where(item => item.EndsWith(".txt")))
							{
								try
								{
									File.Delete(file);
								}
								catch
								{
									MessageBox.Show("Failed to delete " + file);
								}
							}
						}
					}
				}
				catch
				{
					MessageBox.Show("Error finding server folder!");
					return;
				}

			}
		}

        private void pluginManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Form2 plugins = new Form2(); 
			plugins.StartPosition = FormStartPosition.CenterScreen;
			plugins.ShowDialog(); 
		}


        private void button14_Click(object sender, EventArgs e)
        {
			try
			{
				File.Delete("RustServerFiles\\logs.log");
			}
			catch { }
			textBox2.Text = "";
		}

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
			if (tabControl1.SelectedIndex == 1)
            {
				this.delay.Enabled = true;
			}
			else
            {
				this.delay.Enabled = false;
			}
		}

        private void button13_Click_1(object sender, EventArgs e)
        {
			updatelog();
		}

		const int EM_LINESCROLL = 0x00B6;
		[DllImport("user32.dll")]
		static extern int SetScrollPos(IntPtr hWnd, int nBar,
							   int nPos, bool bRedraw);
		[DllImport("user32.dll")]
		static extern int SendMessage(IntPtr hWnd, int wMsg,
									   int wParam, int lParam);

		[DllImport("user32.dll")]
		static extern int GetScrollPos(IntPtr hWnd, int nBar);

		private void updatelog()
        {
			//try
			//{
			if (GetScrollPos(textBox2.Handle, 1) == 0)
			{
				var checkchange = System.IO.File.GetLastWriteTime("RustServerFiles\\logs.log");
				if (lastModified != checkchange.ToString())
				{
					lastModified = checkchange.ToString();
					string temp = "";
					using (FileStream stream = File.Open("RustServerFiles\\logs.log", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
					{
						using (StreamReader reader = new StreamReader(stream))
						{
							temp = reader.ReadToEnd();
						}
					}
					string[] lines = temp.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

					textBox2.Text = "";
					for (int i = lines.Length - 1; i > 0; i--)
					{
						textBox2.Text += lines[i].ToString() + Environment.NewLine;
					}
				}
			}
			//}

			//         catch { }
		}

		private void serverup_Tick(object sender, EventArgs e)
        {

			if (BtnStart.Enabled == false)
            {
				BtnStart.Enabled = true;
			}

			Process[] pname = Process.GetProcessesByName("RustDedicated");
			if (pname.Length == 0)
			{
				BtnStart.Text = "START";
				StartFileList.Enabled = true;
				serverup.Enabled = false;
				label68.Text = "START YOUR SERVER";
				infolabel.Text = "Server not running.";
			}
			else
			{
				if (BtnStart.Text != "STOP")
				{
					BtnStart.Text = "STOP";
					StartFileList.Enabled = false;
					label68.Text = "SERVER RUNNING";
				}
			}


		}
    }
}
