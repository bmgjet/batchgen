using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Ionic.Zip;
using System.Security.Principal;

namespace batchgen
{
	public partial class Form1 : Form
	{

		MapServer myServer = null;
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

            textBox3.Text = RUSS.Properties.Settings.Default.MapLocation;
			textBox4.Text = RUSS.Properties.Settings.Default.MAPOUTPUTURL;
			maskedTextBox1.Text = RUSS.Properties.Settings.Default.MAPPort;
			checkBox1.Checked = RUSS.Properties.Settings.Default.MAPServer;
			StartFileList.Text = RUSS.Properties.Settings.Default.RustCOMBOBOX;
			MyIP = RUSS.Properties.Settings.Default.RCONIP;

			string mylocation = Application.ExecutablePath;
			if (mylocation.Contains(" "))
            {
				MessageBox.Show("SteamCMD will have issues if you have spaces in your file path." + Environment.NewLine + mylocation + Environment.NewLine + Environment.NewLine + "Please create a file structure with no spaces!" + Environment.NewLine + "Such as:" + Environment.NewLine + mylocation.Replace(" ", ""));
            }
			this.mapsizebox.Text = (RandomNumber(2, 7) * 500).ToString();
			this.mapseedtext.Text = RandomNumber(1, 10).ToString();

			this.mapPic.ImageLocation = "http://playrust.io/preview.jpg?level=Procedural%20Map&size=" + this.mapsizebox.Text + "&seed=" + this.mapseedtext.Text;
			label66.Text = "Size:" + mapsizebox.Text + " Seed:" + mapseedtext.Text;
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

			if (StartFileList.Text != "")
			{
				readbatinfo();
			}

		}

		
		private void button2_Click(object sender, EventArgs e)
		{
			if (!mapurlbox.Text.Contains(".map"))
            {
				MessageBox.Show("No map file selected please fill in MAP URL!");
				return;
            }

			if (mapurlbox.Text.Contains(".map?dl=0"))
			{
				DialogResult dialogResult = MessageBox.Show("?dl=0 url detected!" +Environment.NewLine + "Do you want to change this to dl=1", "URL WARNING", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					mapurlbox.Text = mapurlbox.Text.Replace(".map?dl=0", ".map?dl=1");
				}
			}


			bool flag = this.ServerVarsFinal.Text == "";
			if (flag)
			{

				this.Finaltext.Text = "RustDedicated.exe -batchmode +server.identity " + @"""" + this.CMidentitytext.Text + @"""" + " +server.hostname " + @"""" + this.CMservernametext.Text + @""" +levelurl " + @"""" + this.mapurlbox.Text + @"""" + " +server.maxplayers " + this.CMmaxplayertext.Text + @" +rcon.ip " + MyIP + " +rcon.port " + this.CMrconporttext.Text + " +server.port " + this.CMserverportext.Text + " +rcon.password " + @"""" + this.CMrconpasstext.Text + @"""" + " +server.description " + @"""" + this.CMserverdisctext.Text + @"""" + " +server.url " + @"""" + this.CMserverurltext.Text + @"""" + " +server.headerimage " + @"""" + this.CMserverpicturetext.Text + @"""" + " -logfile " + @"""" + this.LogLocation.Text + ".log" + @"""";
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
				this.checkrun.Enabled = false;
			}
		}

		
		private void timer1_Tick(object sender, EventArgs e)
		{
			updatelog();
		}

				
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

		private void button8_Click(object sender, EventArgs e)
		{
			bool flag = this.ServerVarsFinal.Text == "";
			if (flag)
			{
				this.Finaltext.Text = "RustDedicated.exe -batchmode +server.identity " + @"""" + this.KOidentitytext.Text + @"""" + " +server.hostname " + @"""" + this.KOservernametext.Text + @""" +server.level ""SavasIsland_koth""" + " +server.seed " + @"""" + " +server.maxplayers " + this.KOmaxplayertext.Text + @" +rcon.ip " + MyIP + " +rcon.port " + this.KOrconporttext.Text + " +server.port " + this.KOserverportext.Text + " +rcon.password " + @"""" + this.KOrconpasstext.Text + @"""" + " +server.description " + @"""" + this.KOserverdisctext.Text + @"""" + " +server.url " + @"""" + this.KOserverurltext.Text + @"""" + " +server.headerimage " + @"""" + this.KOserverpicturetext.Text + @"""" + " -logfile " + @"""" + this.LogLocation.Text + ".log" + @"""";
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
			if (MapServer.Running)
            {
				myServer.Stop();
				myServer = null;
			}


			RUSS.Properties.Settings.Default.MapLocation = textBox3.Text;
			RUSS.Properties.Settings.Default.MAPOUTPUTURL = textBox4.Text;
			RUSS.Properties.Settings.Default.MAPPort = maskedTextBox1.Text;
			RUSS.Properties.Settings.Default.MAPServer = checkBox1.Checked;
			RUSS.Properties.Settings.Default.RustCOMBOBOX = StartFileList.Text;
			RUSS.Properties.Settings.Default.RCONIP = MyIP;
			RUSS.Properties.Settings.Default.Save();
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
				label66.Text = "Size:" + mapsizebox.Text + " Seed:" + mapseedtext.Text;
			}
			else
			{
				bool flag2 = this.da.SelectedTab == this.da.TabPages["Hapis"];
				if (flag2)
				{
					this.mapPic.ImageLocation = "https://vignette.wikia.nocookie.net/play-rust/images/4/47/HapisIsland.jpg/revision/latest/scale-to-width-down/180?cb=20150910033411";
					this.mapinfolab.Text = "Hapis Island";
					label66.Text = "Size:" + mapsizebox.Text + " Seed:" + mapseedtext.Text;
				}
				else
				{
					bool flag3 = this.da.SelectedTab == this.da.TabPages["SAVAS"];
					if (flag3)
					{
						this.mapPic.ImageLocation = "https://vignette.wikia.nocookie.net/play-rust/images/6/64/Savas_Island_diagram.jpg/revision/latest/scale-to-width-down/310?cb=20151001214728";
						this.mapinfolab.Text = "Savas Island";
						label66.Text = "";
					}
					else
					{
						bool flag4 = this.da.SelectedTab == this.da.TabPages["KOTH"];
						if (flag4)
						{
							this.mapPic.ImageLocation = "https://vignette.wikia.nocookie.net/play-rust/images/6/64/Savas_Island_diagram.jpg/revision/latest/scale-to-width-down/310?cb=20151001214728";
							this.mapinfolab.Text = "Savas King Of The Hill";
							label66.Text = "";
						}
						else
						{
							bool flag5 = this.da.SelectedTab == this.da.TabPages["BARREN"];
							if (flag5)
							{
								this.mapPic.ImageLocation = "http://playrust.io/preview.jpg?level=Barren&size=" + this.BAmapsizebox.Text + "&seed=" + this.BAmapseedtext.Text;
								this.mapinfolab.Text = "Barren ProcGen";
								label66.Text = "";
							}
							else
							{
								bool flag6 = this.da.SelectedTab == this.da.TabPages["custom"];
								if (flag6)
								{
									this.mapPic.ImageLocation = "https://user-images.githubusercontent.com/24848110/33519396-7e56363c-d79d-11e7-969b-09782f5ccbab.png";
									this.mapinfolab.Text = "Custom Map Preview Not Supported";
									label66.Text = "";
								}
								else
								{
									bool flag7 = this.da.SelectedTab == this.da.TabPages["CRAGGY"];
									if (flag7)
									{
										this.mapPic.ImageLocation = "https://i.imgur.com/rSYtxoR.jpg";
										this.mapinfolab.Text = "Craggy Island";
										label66.Text = "";
									}
								}
							}
						}
					}
				}
			}
		}

		
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
			string[] output = RUSS.varlist.servervars(this.SearchVar.Text);
			this.varvar.Text = output[0];
			this.varvalue.Text = output[1];
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
			data = data.TrimEnd().TrimStart();
			return data;
        }



		private void readbatinfo()
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


		private void StartFileList_SelectedIndexChanged(object sender, EventArgs e)
		{
			readbatinfo();
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
			try
			{
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
			}

			         catch { }
		}

		private void serverup_Tick(object sender, EventArgs e)
        {
			if (BtnStart.Enabled == false)
            {
				BtnStart.Enabled = true;
			}

			if (MapServer.Running)
            {
				label32.Text = "Status: Online";
				button16.Enabled = false;
				button18.Enabled = true;
				maskedTextBox1.Enabled = false;
				button17.Enabled = false;
			}
			else
            {
				label32.Text = "Status: Offline";
				button16.Enabled = true;
				button18.Enabled = false;
				maskedTextBox1.Enabled = true;
				button17.Enabled = true;
			}

			Process[] pname = Process.GetProcessesByName("RustDedicated");
			if (pname.Length == 0)
			{
				BtnStart.Text = "START";
				StartFileList.Enabled = true;
				label68.Text = "START YOUR SERVER";
				infolabel.Text = "Server not running.";
				if (checkBox1.Checked) //map server
				{
					button18_Click_1(null, null);
				}
			}
			else
			{
				if (BtnStart.Text != "STOP")
				{
					BtnStart.Text = "STOP";
					StartFileList.Enabled = false;
					label68.Text = "SERVER RUNNING";

					if(checkBox1.Checked) //map server
                    {
						button16_Click_1(null, null);
					}
				}
			}
		}

        private void button15_Click(object sender, EventArgs e)
        {
			OpenFileDialog theDialog = new OpenFileDialog();
			theDialog.Title = "Open Map File";
			theDialog.Filter = "Map|*.map";
			if (theDialog.ShowDialog() == DialogResult.OK)
			{
				mapurlbox.Text = @"File:\\" + theDialog.FileName;
			}
		}

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
			System.Diagnostics.Process.Start("https://www.yougetsignal.com/tools/open-ports/");
		}

        private void button16_Click_1(object sender, EventArgs e)
        {
			if (textBox3.Text.Contains(".map"))
			{
				if (myServer != null)
                {
					myServer.Stop();
					myServer = null;
				}
				button16.Enabled = false;
				myServer = new MapServer(textBox3.Text, int.Parse(maskedTextBox1.Text));
				serverup.Enabled = true;
				string[] temp = textBox3.Text.Split('\\');
				string externalip = new WebClient().DownloadString("http://icanhazip.com") + ":" + maskedTextBox1.Text;
				textBox4.Text = "http://" + externalip + "/" + temp[temp.Length - 1];

			}
			else
            {
				MessageBox.Show("No Map file selected!");
            }
		}

        private void button18_Click_1(object sender, EventArgs e)
        {
			if (myServer != null)
			{
				myServer.Stop();
				myServer = null;
			}
		}

        private void button17_Click(object sender, EventArgs e)
        {
			OpenFileDialog theDialog = new OpenFileDialog();
			theDialog.Title = "Open Map File";
			theDialog.Filter = "Map|*.map";
			if (theDialog.ShowDialog() == DialogResult.OK)
			{
				textBox3.Text = theDialog.FileName;
			}
		}

        private void resetSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
			DialogResult dialogResult = MessageBox.Show("This will reset the settings back to default, Do you want to proceed?", "Reset Settings", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				RUSS.Properties.Settings.Default.Reset();
				textBox3.Text = RUSS.Properties.Settings.Default.MapLocation;
				textBox4.Text = RUSS.Properties.Settings.Default.MAPOUTPUTURL;
				maskedTextBox1.Text = RUSS.Properties.Settings.Default.MAPPort;
				checkBox1.Checked = RUSS.Properties.Settings.Default.MAPServer;
				StartFileList.Text = RUSS.Properties.Settings.Default.RustCOMBOBOX;
				MyIP = RUSS.Properties.Settings.Default.RCONIP;
			}

		}
    }
}
