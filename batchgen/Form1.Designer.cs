﻿namespace batchgen
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x060000B9 RID: 185 RVA: 0x0000B78C File Offset: 0x0000998C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000B7C4 File Offset: 0x000099C4
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.checkrun = new System.Windows.Forms.Timer(this.components);
            this.delay = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoTutorialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullHostingTutorialsPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem25 = new System.Windows.Forms.ToolStripSeparator();
            this.howToHostYourOwnRustServerManuallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToInstallOxideWorkWithPluginsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToPortForwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem28 = new System.Windows.Forms.ToolStripSeparator();
            this.mostBeginnerMistakesQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.socialMediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rustAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rustServerManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rustEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.steamCMDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fortifyCreateAndDesignBaseCanBeCopiedFromOrPastedIntoRustToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripSeparator();
            this.sitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playRustIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.playRustcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.battleMetricsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.corrosionHourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rustopiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.umodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chaoscodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.rustLabsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripSeparator();
            this.guidesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.httpswwwrustafiedcomhowtohostarustserverinlinuxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem22 = new System.Windows.Forms.ToolStripSeparator();
            this.hostARUSTDedicatedServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.populateYourRUSTServerWithThese6TipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToCreateAPrivateRUSTServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToInstallUModOxideToARUSTServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rUSTServerPerformanceHintsAndTipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pluginsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripSeparator();
            this.downloadOxideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripSeparator();
            this.browseFreePluginsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem29 = new System.Windows.Forms.ToolStripSeparator();
            this.chooseAMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem20 = new System.Windows.Forms.ToolStripMenuItem();
            this.startFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateFIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
            this.serverFilesFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.steamCMDToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.installUmodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadInstallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintab = new System.Windows.Forms.TabPage();
            this.CheckDll = new System.Windows.Forms.TextBox();
            this.hasspace = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.LockedLbl2 = new System.Windows.Forms.Label();
            this.LockedLbl = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.SearchVar = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label48 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTNadd = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.varvalue = new System.Windows.Forms.TextBox();
            this.varvar = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.ServerVars = new System.Windows.Forms.DataGridView();
            this.Variable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnCLLearVars = new System.Windows.Forms.Button();
            this.BtnCompleteVars = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.infolabel = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.ServerVarsFinal = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.BtnStart = new System.Windows.Forms.Button();
            this.StartFileList = new System.Windows.Forms.ComboBox();
            this.label68 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.PreviewDesc = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.BtnRefreshbrowser = new System.Windows.Forms.Button();
            this.BtnViewPage = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label83 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.FakeMS = new System.Windows.Forms.Label();
            this.MaxPlayersPrev = new System.Windows.Forms.Label();
            this.mapTypeprev = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.serverTitle = new System.Windows.Forms.Label();
            this.BannerServer = new System.Windows.Forms.PictureBox();
            this.PreviewPic = new System.Windows.Forms.PictureBox();
            this.button10 = new System.Windows.Forms.Button();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label43 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.label80 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.RefreshSmall = new System.Windows.Forms.Button();
            this.mapinfolab = new System.Windows.Forms.Label();
            this.mapPic = new System.Windows.Forms.PictureBox();
            this.test = new System.Windows.Forms.TextBox();
            this.parametersbox = new System.Windows.Forms.TextBox();
            this.deditextbox = new System.Windows.Forms.TextBox();
            this.loglog = new System.Windows.Forms.TextBox();
            this.quibox = new System.Windows.Forms.TextBox();
            this.slashbox = new System.Windows.Forms.TextBox();
            this.steamcmdbox = new System.Windows.Forms.TextBox();
            this.serbat = new System.Windows.Forms.TextBox();
            this.Finaltext = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RdioStaging = new System.Windows.Forms.RadioButton();
            this.RdioNormal = new System.Windows.Forms.RadioButton();
            this.steamcmdIns = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label29 = new System.Windows.Forms.Label();
            this.da = new System.Windows.Forms.TabControl();
            this.procgen = new System.Windows.Forms.TabPage();
            this.genbtn = new System.Windows.Forms.Button();
            this.mapseedtext = new System.Windows.Forms.TextBox();
            this.mapsizebox = new System.Windows.Forms.TextBox();
            this.maxplayertext = new System.Windows.Forms.TextBox();
            this.serverdisctext = new System.Windows.Forms.TextBox();
            this.serverurltext = new System.Windows.Forms.TextBox();
            this.serverpicturetext = new System.Windows.Forms.TextBox();
            this.rconpasstext = new System.Windows.Forms.TextBox();
            this.rconporttext = new System.Windows.Forms.TextBox();
            this.serverporttext = new System.Windows.Forms.TextBox();
            this.servernametext = new System.Windows.Forms.TextBox();
            this.identitytext = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.custom = new System.Windows.Forms.TabPage();
            this.BTNbatchCustom = new System.Windows.Forms.Button();
            this.mapurlbox = new System.Windows.Forms.TextBox();
            this.CMmaxplayertext = new System.Windows.Forms.TextBox();
            this.CMserverdisctext = new System.Windows.Forms.TextBox();
            this.CMserverurltext = new System.Windows.Forms.TextBox();
            this.CMserverpicturetext = new System.Windows.Forms.TextBox();
            this.CMrconpasstext = new System.Windows.Forms.TextBox();
            this.CMrconporttext = new System.Windows.Forms.TextBox();
            this.CMserverportext = new System.Windows.Forms.TextBox();
            this.CMservernametext = new System.Windows.Forms.TextBox();
            this.CMidentitytext = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.Hapis = new System.Windows.Forms.TabPage();
            this.HAidentitytext = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.HPmaxplayertext = new System.Windows.Forms.TextBox();
            this.HPserverdisctext = new System.Windows.Forms.TextBox();
            this.HPserverurltext = new System.Windows.Forms.TextBox();
            this.HPserverpicturetext = new System.Windows.Forms.TextBox();
            this.HPrconpasstext = new System.Windows.Forms.TextBox();
            this.HPrconporttext = new System.Windows.Forms.TextBox();
            this.HPserverportext = new System.Windows.Forms.TextBox();
            this.HPservernametext = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.BARREN = new System.Windows.Forms.TabPage();
            this.BAidentitytext = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.BAmapseedtext = new System.Windows.Forms.TextBox();
            this.BAmapsizebox = new System.Windows.Forms.TextBox();
            this.BAmaxplayertext = new System.Windows.Forms.TextBox();
            this.BAserverdisctext = new System.Windows.Forms.TextBox();
            this.BAserverurltext = new System.Windows.Forms.TextBox();
            this.BAserverpicturetext = new System.Windows.Forms.TextBox();
            this.BArconpasstext = new System.Windows.Forms.TextBox();
            this.BArconporttext = new System.Windows.Forms.TextBox();
            this.BAserverportext = new System.Windows.Forms.TextBox();
            this.BAservernametext = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.CRAGGY = new System.Windows.Forms.TabPage();
            this.CRidentitytext = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.CRmaxplayertext = new System.Windows.Forms.TextBox();
            this.CRserverdisctext = new System.Windows.Forms.TextBox();
            this.CRserverurltext = new System.Windows.Forms.TextBox();
            this.CRserverpicturetext = new System.Windows.Forms.TextBox();
            this.CRrconpasstext = new System.Windows.Forms.TextBox();
            this.CRrconporttext = new System.Windows.Forms.TextBox();
            this.CRserverportext = new System.Windows.Forms.TextBox();
            this.CRservernametext = new System.Windows.Forms.TextBox();
            this.label69 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.SAVAS = new System.Windows.Forms.TabPage();
            this.SAidentitytext = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.SAmaxplayertext = new System.Windows.Forms.TextBox();
            this.SAserverdisctext = new System.Windows.Forms.TextBox();
            this.SAserverurltext = new System.Windows.Forms.TextBox();
            this.SAserverpicturetext = new System.Windows.Forms.TextBox();
            this.SArconpasstext = new System.Windows.Forms.TextBox();
            this.SArconporttext = new System.Windows.Forms.TextBox();
            this.SAserverportext = new System.Windows.Forms.TextBox();
            this.SAservernametext = new System.Windows.Forms.TextBox();
            this.label84 = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.label92 = new System.Windows.Forms.Label();
            this.KOTH = new System.Windows.Forms.TabPage();
            this.KOidentitytext = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.KOmaxplayertext = new System.Windows.Forms.TextBox();
            this.KOserverdisctext = new System.Windows.Forms.TextBox();
            this.KOserverurltext = new System.Windows.Forms.TextBox();
            this.KOserverpicturetext = new System.Windows.Forms.TextBox();
            this.KOrconpasstext = new System.Windows.Forms.TextBox();
            this.KOrconporttext = new System.Windows.Forms.TextBox();
            this.KOserverportext = new System.Windows.Forms.TextBox();
            this.KOservernametext = new System.Windows.Forms.TextBox();
            this.label95 = new System.Windows.Forms.Label();
            this.label96 = new System.Windows.Forms.Label();
            this.label97 = new System.Windows.Forms.Label();
            this.label98 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.label101 = new System.Windows.Forms.Label();
            this.label102 = new System.Windows.Forms.Label();
            this.label103 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.LogLocation = new System.Windows.Forms.TextBox();
            this.dedicateddirectory = new System.Windows.Forms.TextBox();
            this.servfilesdirectory = new System.Windows.Forms.TextBox();
            this.cmdbatdirstaging = new System.Windows.Forms.TextBox();
            this.cmdbatdir = new System.Windows.Forms.TextBox();
            this.CMDDirectorybox = new System.Windows.Forms.TextBox();
            this.serverdirectorytext = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.maintab.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServerVars)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BannerServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPic)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapPic)).BeginInit();
            this.panel3.SuspendLayout();
            this.da.SuspendLayout();
            this.procgen.SuspendLayout();
            this.custom.SuspendLayout();
            this.Hapis.SuspendLayout();
            this.BARREN.SuspendLayout();
            this.CRAGGY.SuspendLayout();
            this.SAVAS.SuspendLayout();
            this.KOTH.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // checkrun
            // 
            this.checkrun.Interval = 500;
            this.checkrun.Tick += new System.EventHandler(this.checkrun_Tick);
            // 
            // delay
            // 
            this.delay.Interval = 500;
            this.delay.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.serverOptionsToolStripMenuItem,
            this.socialMediaToolStripMenuItem,
            this.pluginsToolStripMenuItem,
            this.chooseAMapToolStripMenuItem,
            this.toolStripMenuItem20,
            this.installUmodToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(840, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.videoTutorialsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // videoTutorialsToolStripMenuItem
            // 
            this.videoTutorialsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullHostingTutorialsPlaylistToolStripMenuItem,
            this.toolStripMenuItem25,
            this.howToHostYourOwnRustServerManuallyToolStripMenuItem,
            this.howToInstallOxideWorkWithPluginsToolStripMenuItem,
            this.howToPortForwardToolStripMenuItem,
            this.toolStripMenuItem28,
            this.mostBeginnerMistakesQuestionsToolStripMenuItem});
            this.videoTutorialsToolStripMenuItem.Name = "videoTutorialsToolStripMenuItem";
            this.videoTutorialsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.videoTutorialsToolStripMenuItem.Text = "Video Tutorials";
            // 
            // fullHostingTutorialsPlaylistToolStripMenuItem
            // 
            this.fullHostingTutorialsPlaylistToolStripMenuItem.Name = "fullHostingTutorialsPlaylistToolStripMenuItem";
            this.fullHostingTutorialsPlaylistToolStripMenuItem.Size = new System.Drawing.Size(324, 22);
            this.fullHostingTutorialsPlaylistToolStripMenuItem.Text = "Full Hosting Tutorials Playlist";
            this.fullHostingTutorialsPlaylistToolStripMenuItem.Click += new System.EventHandler(this.fullHostingTutorialsPlaylistToolStripMenuItem_Click);
            // 
            // toolStripMenuItem25
            // 
            this.toolStripMenuItem25.Name = "toolStripMenuItem25";
            this.toolStripMenuItem25.Size = new System.Drawing.Size(321, 6);
            // 
            // howToHostYourOwnRustServerManuallyToolStripMenuItem
            // 
            this.howToHostYourOwnRustServerManuallyToolStripMenuItem.Name = "howToHostYourOwnRustServerManuallyToolStripMenuItem";
            this.howToHostYourOwnRustServerManuallyToolStripMenuItem.Size = new System.Drawing.Size(324, 22);
            this.howToHostYourOwnRustServerManuallyToolStripMenuItem.Text = "#1 How To Host your own Rust Server Manually";
            this.howToHostYourOwnRustServerManuallyToolStripMenuItem.Click += new System.EventHandler(this.howToHostYourOwnRustServerManuallyToolStripMenuItem_Click);
            // 
            // howToInstallOxideWorkWithPluginsToolStripMenuItem
            // 
            this.howToInstallOxideWorkWithPluginsToolStripMenuItem.Name = "howToInstallOxideWorkWithPluginsToolStripMenuItem";
            this.howToInstallOxideWorkWithPluginsToolStripMenuItem.Size = new System.Drawing.Size(324, 22);
            this.howToInstallOxideWorkWithPluginsToolStripMenuItem.Text = "#2 How To Install Oxide And Work With Plugins";
            this.howToInstallOxideWorkWithPluginsToolStripMenuItem.Click += new System.EventHandler(this.howToInstallOxideWorkWithPluginsToolStripMenuItem_Click);
            // 
            // howToPortForwardToolStripMenuItem
            // 
            this.howToPortForwardToolStripMenuItem.Name = "howToPortForwardToolStripMenuItem";
            this.howToPortForwardToolStripMenuItem.Size = new System.Drawing.Size(324, 22);
            this.howToPortForwardToolStripMenuItem.Text = "#3 How To Port Forward - Make it Public";
            this.howToPortForwardToolStripMenuItem.Click += new System.EventHandler(this.howToPortForwardToolStripMenuItem_Click);
            // 
            // toolStripMenuItem28
            // 
            this.toolStripMenuItem28.Name = "toolStripMenuItem28";
            this.toolStripMenuItem28.Size = new System.Drawing.Size(321, 6);
            // 
            // mostBeginnerMistakesQuestionsToolStripMenuItem
            // 
            this.mostBeginnerMistakesQuestionsToolStripMenuItem.Name = "mostBeginnerMistakesQuestionsToolStripMenuItem";
            this.mostBeginnerMistakesQuestionsToolStripMenuItem.Size = new System.Drawing.Size(324, 22);
            this.mostBeginnerMistakesQuestionsToolStripMenuItem.Text = "15 Most Mistakes / Questions";
            this.mostBeginnerMistakesQuestionsToolStripMenuItem.Click += new System.EventHandler(this.mostBeginnerMistakesQuestionsToolStripMenuItem_Click);
            // 
            // serverOptionsToolStripMenuItem
            // 
            this.serverOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateServerToolStripMenuItem});
            this.serverOptionsToolStripMenuItem.Name = "serverOptionsToolStripMenuItem";
            this.serverOptionsToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.serverOptionsToolStripMenuItem.Text = "Server Options";
            // 
            // updateServerToolStripMenuItem
            // 
            this.updateServerToolStripMenuItem.Name = "updateServerToolStripMenuItem";
            this.updateServerToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.updateServerToolStripMenuItem.Text = "Update Server";
            this.updateServerToolStripMenuItem.Click += new System.EventHandler(this.UpdateServerToolStripMenuItem_Click);
            // 
            // socialMediaToolStripMenuItem
            // 
            this.socialMediaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programsToolStripMenuItem,
            this.toolStripMenuItem12,
            this.sitesToolStripMenuItem,
            this.toolStripMenuItem16,
            this.guidesToolStripMenuItem});
            this.socialMediaToolStripMenuItem.Name = "socialMediaToolStripMenuItem";
            this.socialMediaToolStripMenuItem.Size = new System.Drawing.Size(52, 22);
            this.socialMediaToolStripMenuItem.Text = "Useful";
            this.socialMediaToolStripMenuItem.Click += new System.EventHandler(this.socialMediaToolStripMenuItem_Click);
            // 
            // programsToolStripMenuItem
            // 
            this.programsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rustAdminToolStripMenuItem,
            this.rustServerManagerToolStripMenuItem,
            this.rustEditToolStripMenuItem,
            this.steamCMDToolStripMenuItem,
            this.fortifyCreateAndDesignBaseCanBeCopiedFromOrPastedIntoRustToolStripMenuItem});
            this.programsToolStripMenuItem.Name = "programsToolStripMenuItem";
            this.programsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.programsToolStripMenuItem.Text = "Programs";
            // 
            // rustAdminToolStripMenuItem
            // 
            this.rustAdminToolStripMenuItem.Name = "rustAdminToolStripMenuItem";
            this.rustAdminToolStripMenuItem.Size = new System.Drawing.Size(531, 22);
            this.rustAdminToolStripMenuItem.Text = "Rust Admin --- RCON control | player management | server stats | must have";
            this.rustAdminToolStripMenuItem.Click += new System.EventHandler(this.rustAdminToolStripMenuItem_Click);
            // 
            // rustServerManagerToolStripMenuItem
            // 
            this.rustServerManagerToolStripMenuItem.Name = "rustServerManagerToolStripMenuItem";
            this.rustServerManagerToolStripMenuItem.Size = new System.Drawing.Size(531, 22);
            this.rustServerManagerToolStripMenuItem.Text = "Rust Server Manager ---  Setup Your Server |  Manage Plugins | Control Multiple S" +
    "ervers";
            this.rustServerManagerToolStripMenuItem.Click += new System.EventHandler(this.rustServerManagerToolStripMenuItem_Click);
            // 
            // rustEditToolStripMenuItem
            // 
            this.rustEditToolStripMenuItem.Name = "rustEditToolStripMenuItem";
            this.rustEditToolStripMenuItem.Size = new System.Drawing.Size(531, 22);
            this.rustEditToolStripMenuItem.Text = "RustEdit --- Create And Edit Maps";
            this.rustEditToolStripMenuItem.Click += new System.EventHandler(this.rustEditToolStripMenuItem_Click);
            // 
            // steamCMDToolStripMenuItem
            // 
            this.steamCMDToolStripMenuItem.Name = "steamCMDToolStripMenuItem";
            this.steamCMDToolStripMenuItem.Size = new System.Drawing.Size(531, 22);
            this.steamCMDToolStripMenuItem.Text = "SteamCMD --- Is Used For Downloading And Updating Your Server";
            this.steamCMDToolStripMenuItem.Click += new System.EventHandler(this.steamCMDToolStripMenuItem_Click);
            // 
            // fortifyCreateAndDesignBaseCanBeCopiedFromOrPastedIntoRustToolStripMenuItem
            // 
            this.fortifyCreateAndDesignBaseCanBeCopiedFromOrPastedIntoRustToolStripMenuItem.Name = "fortifyCreateAndDesignBaseCanBeCopiedFromOrPastedIntoRustToolStripMenuItem";
            this.fortifyCreateAndDesignBaseCanBeCopiedFromOrPastedIntoRustToolStripMenuItem.Size = new System.Drawing.Size(531, 22);
            this.fortifyCreateAndDesignBaseCanBeCopiedFromOrPastedIntoRustToolStripMenuItem.Text = "Fortify - Create and design base - can be copied  from  or pasted into rust";
            this.fortifyCreateAndDesignBaseCanBeCopiedFromOrPastedIntoRustToolStripMenuItem.Click += new System.EventHandler(this.fortifyCreateAndDesignBaseCanBeCopiedFromOrPastedIntoRustToolStripMenuItem_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(152, 6);
            // 
            // sitesToolStripMenuItem
            // 
            this.sitesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playRustIOToolStripMenuItem,
            this.toolStripMenuItem2,
            this.playRustcomToolStripMenuItem,
            this.battleMetricsToolStripMenuItem,
            this.toolStripMenuItem4,
            this.corrosionHourToolStripMenuItem,
            this.rustopiaToolStripMenuItem,
            this.toolStripMenuItem3,
            this.umodToolStripMenuItem,
            this.chaoscodeToolStripMenuItem,
            this.toolStripMenuItem5,
            this.rustLabsToolStripMenuItem});
            this.sitesToolStripMenuItem.Name = "sitesToolStripMenuItem";
            this.sitesToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.sitesToolStripMenuItem.Text = "RUST WEBSITES";
            // 
            // playRustIOToolStripMenuItem
            // 
            this.playRustIOToolStripMenuItem.Name = "playRustIOToolStripMenuItem";
            this.playRustIOToolStripMenuItem.Size = new System.Drawing.Size(540, 22);
            this.playRustIOToolStripMenuItem.Text = "Play Rust.IO --- Lookup maps of active servers | Choose a map for your server";
            this.playRustIOToolStripMenuItem.Click += new System.EventHandler(this.playRustIOToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(537, 6);
            // 
            // playRustcomToolStripMenuItem
            // 
            this.playRustcomToolStripMenuItem.Name = "playRustcomToolStripMenuItem";
            this.playRustcomToolStripMenuItem.Size = new System.Drawing.Size(540, 22);
            this.playRustcomToolStripMenuItem.Text = "Play Rust.com --- Official website for rust |  DevBlogs | Community Posts";
            this.playRustcomToolStripMenuItem.Click += new System.EventHandler(this.playRustcomToolStripMenuItem_Click);
            // 
            // battleMetricsToolStripMenuItem
            // 
            this.battleMetricsToolStripMenuItem.Name = "battleMetricsToolStripMenuItem";
            this.battleMetricsToolStripMenuItem.Size = new System.Drawing.Size(540, 22);
            this.battleMetricsToolStripMenuItem.Text = "Battle Metrics --- Lookup Stats of active servers | Best Web Rcon (Paid)";
            this.battleMetricsToolStripMenuItem.Click += new System.EventHandler(this.battleMetricsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(537, 6);
            // 
            // corrosionHourToolStripMenuItem
            // 
            this.corrosionHourToolStripMenuItem.Name = "corrosionHourToolStripMenuItem";
            this.corrosionHourToolStripMenuItem.Size = new System.Drawing.Size(540, 22);
            this.corrosionHourToolStripMenuItem.Text = "Corrosion Hour --- Information | Update Posts | Guides";
            this.corrosionHourToolStripMenuItem.Click += new System.EventHandler(this.corrosionHourToolStripMenuItem_Click);
            // 
            // rustopiaToolStripMenuItem
            // 
            this.rustopiaToolStripMenuItem.Name = "rustopiaToolStripMenuItem";
            this.rustopiaToolStripMenuItem.Size = new System.Drawing.Size(540, 22);
            this.rustopiaToolStripMenuItem.Text = "Rustafied --- Information | Update Posts | Guides";
            this.rustopiaToolStripMenuItem.Click += new System.EventHandler(this.rustopiaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(537, 6);
            // 
            // umodToolStripMenuItem
            // 
            this.umodToolStripMenuItem.Name = "umodToolStripMenuItem";
            this.umodToolStripMenuItem.Size = new System.Drawing.Size(540, 22);
            this.umodToolStripMenuItem.Text = "Umod --- Official Framwork For Rust Plugins | Download plugins | Get Help";
            this.umodToolStripMenuItem.Click += new System.EventHandler(this.umodToolStripMenuItem_Click);
            // 
            // chaoscodeToolStripMenuItem
            // 
            this.chaoscodeToolStripMenuItem.Name = "chaoscodeToolStripMenuItem";
            this.chaoscodeToolStripMenuItem.Size = new System.Drawing.Size(540, 22);
            this.chaoscodeToolStripMenuItem.Text = "Chaos Code --- Paid Plugins ";
            this.chaoscodeToolStripMenuItem.Click += new System.EventHandler(this.chaoscodeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(537, 6);
            // 
            // rustLabsToolStripMenuItem
            // 
            this.rustLabsToolStripMenuItem.Name = "rustLabsToolStripMenuItem";
            this.rustLabsToolStripMenuItem.Size = new System.Drawing.Size(540, 22);
            this.rustLabsToolStripMenuItem.Text = "RustLabs --- reliable database with statistical information for items and game me" +
    "chanics";
            this.rustLabsToolStripMenuItem.Click += new System.EventHandler(this.rustLabsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(152, 6);
            // 
            // guidesToolStripMenuItem
            // 
            this.guidesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToolStripMenuItem,
            this.httpswwwrustafiedcomhowtohostarustserverinlinuxToolStripMenuItem,
            this.toolStripMenuItem22,
            this.hostARUSTDedicatedServerToolStripMenuItem,
            this.populateYourRUSTServerWithThese6TipsToolStripMenuItem,
            this.howToCreateAPrivateRUSTServerToolStripMenuItem,
            this.howToInstallUModOxideToARUSTServerToolStripMenuItem,
            this.rUSTServerPerformanceHintsAndTipsToolStripMenuItem});
            this.guidesToolStripMenuItem.Name = "guidesToolStripMenuItem";
            this.guidesToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.guidesToolStripMenuItem.Text = "Written Guides";
            // 
            // howToolStripMenuItem
            // 
            this.howToolStripMenuItem.Name = "howToolStripMenuItem";
            this.howToolStripMenuItem.Size = new System.Drawing.Size(314, 22);
            this.howToolStripMenuItem.Text = "How to: Host your own Rust Dedicated Server";
            this.howToolStripMenuItem.Click += new System.EventHandler(this.howToolStripMenuItem_Click);
            // 
            // httpswwwrustafiedcomhowtohostarustserverinlinuxToolStripMenuItem
            // 
            this.httpswwwrustafiedcomhowtohostarustserverinlinuxToolStripMenuItem.Name = "httpswwwrustafiedcomhowtohostarustserverinlinuxToolStripMenuItem";
            this.httpswwwrustafiedcomhowtohostarustserverinlinuxToolStripMenuItem.Size = new System.Drawing.Size(314, 22);
            this.httpswwwrustafiedcomhowtohostarustserverinlinuxToolStripMenuItem.Text = "How to host a Rust server in Linux";
            this.httpswwwrustafiedcomhowtohostarustserverinlinuxToolStripMenuItem.Click += new System.EventHandler(this.httpswwwrustafiedcomhowtohostarustserverinlinuxToolStripMenuItem_Click);
            // 
            // toolStripMenuItem22
            // 
            this.toolStripMenuItem22.Name = "toolStripMenuItem22";
            this.toolStripMenuItem22.Size = new System.Drawing.Size(311, 6);
            // 
            // hostARUSTDedicatedServerToolStripMenuItem
            // 
            this.hostARUSTDedicatedServerToolStripMenuItem.Name = "hostARUSTDedicatedServerToolStripMenuItem";
            this.hostARUSTDedicatedServerToolStripMenuItem.Size = new System.Drawing.Size(314, 22);
            this.hostARUSTDedicatedServerToolStripMenuItem.Text = "Host a RUST Dedicated Server";
            this.hostARUSTDedicatedServerToolStripMenuItem.Click += new System.EventHandler(this.hostARUSTDedicatedServerToolStripMenuItem_Click);
            // 
            // populateYourRUSTServerWithThese6TipsToolStripMenuItem
            // 
            this.populateYourRUSTServerWithThese6TipsToolStripMenuItem.Name = "populateYourRUSTServerWithThese6TipsToolStripMenuItem";
            this.populateYourRUSTServerWithThese6TipsToolStripMenuItem.Size = new System.Drawing.Size(314, 22);
            this.populateYourRUSTServerWithThese6TipsToolStripMenuItem.Text = "Populate Your RUST Server with these 6 Tips";
            this.populateYourRUSTServerWithThese6TipsToolStripMenuItem.Click += new System.EventHandler(this.populateYourRUSTServerWithThese6TipsToolStripMenuItem_Click);
            // 
            // howToCreateAPrivateRUSTServerToolStripMenuItem
            // 
            this.howToCreateAPrivateRUSTServerToolStripMenuItem.Name = "howToCreateAPrivateRUSTServerToolStripMenuItem";
            this.howToCreateAPrivateRUSTServerToolStripMenuItem.Size = new System.Drawing.Size(314, 22);
            this.howToCreateAPrivateRUSTServerToolStripMenuItem.Text = "How To Create a Private RUST Server";
            this.howToCreateAPrivateRUSTServerToolStripMenuItem.Click += new System.EventHandler(this.howToCreateAPrivateRUSTServerToolStripMenuItem_Click);
            // 
            // howToInstallUModOxideToARUSTServerToolStripMenuItem
            // 
            this.howToInstallUModOxideToARUSTServerToolStripMenuItem.Name = "howToInstallUModOxideToARUSTServerToolStripMenuItem";
            this.howToInstallUModOxideToARUSTServerToolStripMenuItem.Size = new System.Drawing.Size(314, 22);
            this.howToInstallUModOxideToARUSTServerToolStripMenuItem.Text = "How to Install uMod (Oxide) to a RUST Server";
            this.howToInstallUModOxideToARUSTServerToolStripMenuItem.Click += new System.EventHandler(this.howToInstallUModOxideToARUSTServerToolStripMenuItem_Click);
            // 
            // rUSTServerPerformanceHintsAndTipsToolStripMenuItem
            // 
            this.rUSTServerPerformanceHintsAndTipsToolStripMenuItem.Name = "rUSTServerPerformanceHintsAndTipsToolStripMenuItem";
            this.rUSTServerPerformanceHintsAndTipsToolStripMenuItem.Size = new System.Drawing.Size(314, 22);
            this.rUSTServerPerformanceHintsAndTipsToolStripMenuItem.Text = "RUST Server Performance, Hints and Tips";
            this.rUSTServerPerformanceHintsAndTipsToolStripMenuItem.Click += new System.EventHandler(this.rUSTServerPerformanceHintsAndTipsToolStripMenuItem_Click);
            // 
            // pluginsToolStripMenuItem
            // 
            this.pluginsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainSiteToolStripMenuItem,
            this.toolStripMenuItem11,
            this.downloadOxideToolStripMenuItem,
            this.toolStripMenuItem18,
            this.browseFreePluginsToolStripMenuItem,
            this.toolStripMenuItem29});
            this.pluginsToolStripMenuItem.Name = "pluginsToolStripMenuItem";
            this.pluginsToolStripMenuItem.Size = new System.Drawing.Size(58, 22);
            this.pluginsToolStripMenuItem.Text = "Plugins";
            // 
            // mainSiteToolStripMenuItem
            // 
            this.mainSiteToolStripMenuItem.Name = "mainSiteToolStripMenuItem";
            this.mainSiteToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.mainSiteToolStripMenuItem.Text = "Main Site";
            this.mainSiteToolStripMenuItem.Click += new System.EventHandler(this.mainSiteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(188, 6);
            // 
            // downloadOxideToolStripMenuItem
            // 
            this.downloadOxideToolStripMenuItem.Name = "downloadOxideToolStripMenuItem";
            this.downloadOxideToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.downloadOxideToolStripMenuItem.Text = "Oxide Download Page";
            this.downloadOxideToolStripMenuItem.Click += new System.EventHandler(this.downloadOxideToolStripMenuItem_Click);
            // 
            // toolStripMenuItem18
            // 
            this.toolStripMenuItem18.Name = "toolStripMenuItem18";
            this.toolStripMenuItem18.Size = new System.Drawing.Size(188, 6);
            // 
            // browseFreePluginsToolStripMenuItem
            // 
            this.browseFreePluginsToolStripMenuItem.Name = "browseFreePluginsToolStripMenuItem";
            this.browseFreePluginsToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.browseFreePluginsToolStripMenuItem.Text = "Browse Free Plugins";
            this.browseFreePluginsToolStripMenuItem.Click += new System.EventHandler(this.browseFreePluginsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem29
            // 
            this.toolStripMenuItem29.Name = "toolStripMenuItem29";
            this.toolStripMenuItem29.Size = new System.Drawing.Size(188, 6);
            // 
            // chooseAMapToolStripMenuItem
            // 
            this.chooseAMapToolStripMenuItem.Name = "chooseAMapToolStripMenuItem";
            this.chooseAMapToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.chooseAMapToolStripMenuItem.Text = "Choose Map";
            this.chooseAMapToolStripMenuItem.Click += new System.EventHandler(this.chooseAMapToolStripMenuItem_Click);
            // 
            // toolStripMenuItem20
            // 
            this.toolStripMenuItem20.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startFileToolStripMenuItem,
            this.updateFIleToolStripMenuItem,
            this.toolStripMenuItem10,
            this.serverFilesFolderToolStripMenuItem,
            this.serverFolderToolStripMenuItem,
            this.steamCMDToolStripMenuItem1});
            this.toolStripMenuItem20.Name = "toolStripMenuItem20";
            this.toolStripMenuItem20.Size = new System.Drawing.Size(106, 22);
            this.toolStripMenuItem20.Text = "FILE LOCATIONS";
            this.toolStripMenuItem20.Click += new System.EventHandler(this.ToolStripMenuItem20_Click);
            // 
            // startFileToolStripMenuItem
            // 
            this.startFileToolStripMenuItem.Name = "startFileToolStripMenuItem";
            this.startFileToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.startFileToolStripMenuItem.Text = "Start File";
            this.startFileToolStripMenuItem.Click += new System.EventHandler(this.StartFileToolStripMenuItem_Click);
            // 
            // updateFIleToolStripMenuItem
            // 
            this.updateFIleToolStripMenuItem.Name = "updateFIleToolStripMenuItem";
            this.updateFIleToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.updateFIleToolStripMenuItem.Text = "Update FIle ";
            this.updateFIleToolStripMenuItem.Click += new System.EventHandler(this.UpdateFIleToolStripMenuItem_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(170, 6);
            // 
            // serverFilesFolderToolStripMenuItem
            // 
            this.serverFilesFolderToolStripMenuItem.Name = "serverFilesFolderToolStripMenuItem";
            this.serverFilesFolderToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.serverFilesFolderToolStripMenuItem.Text = "Server Files Folder";
            this.serverFilesFolderToolStripMenuItem.Click += new System.EventHandler(this.ServerFilesFolderToolStripMenuItem_Click);
            // 
            // serverFolderToolStripMenuItem
            // 
            this.serverFolderToolStripMenuItem.Name = "serverFolderToolStripMenuItem";
            this.serverFolderToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.serverFolderToolStripMenuItem.Text = "USSR! Folder";
            this.serverFolderToolStripMenuItem.Click += new System.EventHandler(this.ServerFolderToolStripMenuItem_Click);
            // 
            // steamCMDToolStripMenuItem1
            // 
            this.steamCMDToolStripMenuItem1.Name = "steamCMDToolStripMenuItem1";
            this.steamCMDToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.steamCMDToolStripMenuItem1.Text = "Steam CMD Folder";
            this.steamCMDToolStripMenuItem1.Click += new System.EventHandler(this.SteamCMDToolStripMenuItem1_Click);
            // 
            // installUmodToolStripMenuItem
            // 
            this.installUmodToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadInstallToolStripMenuItem});
            this.installUmodToolStripMenuItem.Name = "installUmodToolStripMenuItem";
            this.installUmodToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.installUmodToolStripMenuItem.Text = "Install Umod";
            // 
            // downloadInstallToolStripMenuItem
            // 
            this.downloadInstallToolStripMenuItem.Name = "downloadInstallToolStripMenuItem";
            this.downloadInstallToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.downloadInstallToolStripMenuItem.Text = "Download & Install";
            this.downloadInstallToolStripMenuItem.Click += new System.EventHandler(this.DownloadInstallToolStripMenuItem_Click);
            // 
            // maintab
            // 
            this.maintab.AccessibleName = "";
            this.maintab.BackColor = System.Drawing.Color.Black;
            this.maintab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.maintab.Controls.Add(this.CheckDll);
            this.maintab.Controls.Add(this.hasspace);
            this.maintab.Controls.Add(this.panel6);
            this.maintab.Controls.Add(this.panel5);
            this.maintab.Controls.Add(this.ServerVarsFinal);
            this.maintab.Controls.Add(this.panel12);
            this.maintab.Controls.Add(this.panel9);
            this.maintab.Controls.Add(this.button10);
            this.maintab.Controls.Add(this.progressBar2);
            this.maintab.Controls.Add(this.label43);
            this.maintab.Controls.Add(this.label81);
            this.maintab.Controls.Add(this.button9);
            this.maintab.Controls.Add(this.label80);
            this.maintab.Controls.Add(this.label78);
            this.maintab.Controls.Add(this.panel4);
            this.maintab.Controls.Add(this.test);
            this.maintab.Controls.Add(this.parametersbox);
            this.maintab.Controls.Add(this.deditextbox);
            this.maintab.Controls.Add(this.loglog);
            this.maintab.Controls.Add(this.quibox);
            this.maintab.Controls.Add(this.slashbox);
            this.maintab.Controls.Add(this.steamcmdbox);
            this.maintab.Controls.Add(this.serbat);
            this.maintab.Controls.Add(this.Finaltext);
            this.maintab.Controls.Add(this.button2);
            this.maintab.Controls.Add(this.button1);
            this.maintab.Controls.Add(this.panel3);
            this.maintab.Controls.Add(this.da);
            this.maintab.Controls.Add(this.panel1);
            this.maintab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintab.Location = new System.Drawing.Point(4, 22);
            this.maintab.Name = "maintab";
            this.maintab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.maintab.Size = new System.Drawing.Size(1721, 957);
            this.maintab.TabIndex = 0;
            this.maintab.Text = "Server Setup";
            this.maintab.Click += new System.EventHandler(this.maintab_Click);
            // 
            // CheckDll
            // 
            this.CheckDll.Location = new System.Drawing.Point(1556, 220);
            this.CheckDll.Name = "CheckDll";
            this.CheckDll.Size = new System.Drawing.Size(100, 20);
            this.CheckDll.TabIndex = 31;
            // 
            // hasspace
            // 
            this.hasspace.Location = new System.Drawing.Point(1517, 140);
            this.hasspace.Name = "hasspace";
            this.hasspace.Size = new System.Drawing.Size(159, 20);
            this.hasspace.TabIndex = 30;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.LockedLbl2);
            this.panel6.Controls.Add(this.LockedLbl);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Controls.Add(this.ServerVars);
            this.panel6.Controls.Add(this.BtnCLLearVars);
            this.panel6.Controls.Add(this.BtnCompleteVars);
            this.panel6.Controls.Add(this.button12);
            this.panel6.Location = new System.Drawing.Point(477, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(356, 396);
            this.panel6.TabIndex = 2;
            // 
            // LockedLbl2
            // 
            this.LockedLbl2.AutoSize = true;
            this.LockedLbl2.BackColor = System.Drawing.Color.Transparent;
            this.LockedLbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LockedLbl2.ForeColor = System.Drawing.Color.Red;
            this.LockedLbl2.Location = new System.Drawing.Point(14, 154);
            this.LockedLbl2.Name = "LockedLbl2";
            this.LockedLbl2.Size = new System.Drawing.Size(319, 25);
            this.LockedLbl2.TabIndex = 34;
            this.LockedLbl2.Text = "ADD OR CLEAR TO UNLOCK";
            this.LockedLbl2.Click += new System.EventHandler(this.LockedLbl2_Click);
            // 
            // LockedLbl
            // 
            this.LockedLbl.AutoSize = true;
            this.LockedLbl.BackColor = System.Drawing.Color.Transparent;
            this.LockedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LockedLbl.ForeColor = System.Drawing.Color.Red;
            this.LockedLbl.Location = new System.Drawing.Point(93, 115);
            this.LockedLbl.Name = "LockedLbl";
            this.LockedLbl.Size = new System.Drawing.Size(165, 39);
            this.LockedLbl.TabIndex = 34;
            this.LockedLbl.Text = "LOCKED";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.SearchVar);
            this.panel7.Controls.Add(this.button6);
            this.panel7.Controls.Add(this.label48);
            this.panel7.Location = new System.Drawing.Point(2, 322);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(347, 64);
            this.panel7.TabIndex = 33;
            // 
            // SearchVar
            // 
            this.SearchVar.AutoCompleteCustomSource.AddRange(new string[] {
            "aithinkmanager.framebudgetms",
            "generate_paths",
            "decayminutes",
            "bear.population",
            "spinfrequencyseconds",
            "boar.population",
            "egress_duration_minutes",
            "event_duration_minutes",
            "event_enabled",
            "loot_round_spacing_minutes",
            "loot_rounds",
            "chicken.population",
            "clothloddist",
            "animal_ignore_food",
            "frametime",
            "ignoreplayers",
            "move",
            "nav_carve_height",
            "nav_carve_min_base_size",
            "nav_carve_min_building_blocks_to_apply_optimization",
            "nav_carve_size_multiplier",
            "nav_carve_use_building_optimization",
            "npc_alertness_drain_rate",
            "npc_alertness_to_aim_modifier",
            "npc_alertness_zero_detection_mod",
            "npc_cover_compromised_cooldown",
            "npc_cover_info_tick_rate_multiplier",
            "npc_cover_path_vs_straight_dist_max_diff",
            "npc_cover_use_path_distance",
            "npc_deliberate_hit_randomizer",
            "npc_deliberate_miss_offset_multiplier",
            "npc_deliberate_miss_to_hit_alignment_time",
            "npc_door_trigger_size",
            "npc_enable",
            "npc_families_no_hurt",
            "npc_gun_noise_silencer_modifier",
            "npc_htn_player_base_damage_modifier",
            "npc_htn_player_frustration_threshold",
            "npc_ignore_chairs",
            "npc_junkpile_a_spawn_chance",
            "npc_junkpile_dist_aggro_gate",
            "npc_junkpile_g_spawn_chance",
            "npc_max_junkpile_count",
            "npc_max_population_military_tunnels",
            "npc_max_roam_multiplier",
            "npc_only_hurt_active_target_in_safezone",
            "npc_patrol_point_cooldown",
            "npc_reasoning_system_tick_rate_multiplier",
            "npc_respawn_delay_max_military_tunnels",
            "npc_respawn_delay_min_military_tunnels",
            "npc_sensory_system_tick_rate_multiplier",
            "npc_spawn_on_cargo_ship",
            "npc_spawn_per_tick_max_military_tunnels",
            "npc_spawn_per_tick_min_military_tunnels",
            "npc_speed_crouch_run",
            "npc_speed_crouch_walk",
            "npc_speed_run",
            "npc_speed_sprint",
            "npc_speed_walk",
            "npc_use_new_aim_system",
            "npc_use_thrown_weapons",
            "npc_valid_aim_cone",
            "npc_valid_mounted_aim_cone",
            "ocean_patrol_path_iterations",
            "sensetime",
            "think",
            "ai.tickrate",
            "admincheat",
            "debuglevel",
            "enforcementlevel",
            "eye_clientframes",
            "eye_forgiveness",
            "eye_penalty",
            "eye_protection",
            "eye_serverframes",
            "flyhack_extrusion",
            "flyhack_forgiveness_horizontal",
            "flyhack_forgiveness_vertical",
            "flyhack_margin",
            "flyhack_maxsteps",
            "flyhack_penalty",
            "flyhack_protection",
            "flyhack_reject",
            "flyhack_stepsize",
            "forceposition",
            "maxdeltatime",
            "maxdesync",
            "maxviolation",
            "melee_clientframes",
            "melee_forgiveness",
            "melee_penalty",
            "melee_protection",
            "melee_serverframes",
            "modelstate",
            "noclip_backtracking",
            "noclip_margin",
            "noclip_maxsteps",
            "noclip_penalty",
            "noclip_protection",
            "noclip_reject",
            "noclip_stepsize",
            "objectplacement",
            "projectile_clientframes",
            "projectile_forgiveness",
            "projectile_penalty",
            "projectile_protection",
            "projectile_serverframes",
            "projectile_trajectory_horizontal",
            "projectile_trajectory_vertical",
            "relaxationpause",
            "relaxationrate",
            "reporting",
            "speedhack_forgiveness",
            "speedhack_penalty",
            "speedhack_protection",
            "speedhack_reject",
            "speedhack_slopespeed",
            "userlevel",
            "batching.verbose",
            "bradley.enabled",
            "quickrespawn",
            "respawndelayminutes",
            "respawndelayvariance",
            "chat.enabled",
            "serverlog",
            "frameminutes",
            "instant",
            "callbacks",
            "checktriggers",
            "disablecondition",
            "bracket_0_blockcount",
            "bracket_0_costfraction",
            "bracket_1_blockcount",
            "bracket_1_costfraction",
            "bracket_2_blockcount",
            "bracket_2_costfraction",
            "bracket_3_blockcount",
            "bracket_3_costfraction",
            "decay.debug",
            "delay_metal",
            "delay_override",
            "delay_stone",
            "delay_toptier",
            "delay_twig",
            "delay_wood",
            "duration_metal",
            "duration_override",
            "duration_stone",
            "duration_toptier",
            "duration_twig",
            "duration_wood",
            "outside_test_range",
            "scale",
            "tick",
            "upkeep",
            "upkeep_grief_protection",
            "upkeep_heal_scale",
            "upkeep_inside_decay_scale",
            "upkeep_period_minutes",
            "progresstime",
            "gc.enabled",
            "incremental_enabled",
            "incremental_milliseconds",
            "developer",
            "maxthreads",
            "halloween.enabled",
            "murdererpopulation",
            "scarecrow_beancan_vs_player_dmg_modifier",
            "scarecrow_body_dmg_modifier",
            "scarecrow_chase_stopping_distance",
            "scarecrow_throw_beancan_global_delay",
            "scarecrowpopulation",
            "scarecrows_throw_beancans",
            "visdebug",
            "bulletaccuracy",
            "bulletdamagescale",
            "guns",
            "lifetimeminutes",
            "autosynctransforms",
            "batchsynctransforms",
            "bouncethreshold",
            "droppedmode",
            "gravity",
            "minsteps",
            "sendeffects",
            "sleepthreshold",
            "solveriterationcount",
            "steps",
            "tickrate_cl",
            "tickrate_sv",
            "pool.debug",
            "pool.enabled",
            "mode",
            "hostileduration",
            "targetall",
            "arrowarmor",
            "arrowdamage",
            "authtimeout",
            "bleedingarmor",
            "bleedingdamage",
            "bulletarmor",
            "bulletdamage",
            "cinematic",
            "combatlogdelay",
            "combatlogsize",
            "compression",
            "corpsedespawn",
            "corpses",
            "cycletime",
            "debrisdespawn",
            "dropitems",
            "encryption",
            "entitybatchsizea",
            "entitybatchtime",
            "entityrate",
            "events",
            "globalchat",
            "ipqueriespermin",
            "itemdespawn",
            "maxcommandpacketsize",
            "maxcommandspersecond",
            "maxpacketsize",
            "maxpacketspersecond",
            "maxreceivetime",
            "maxrpcspersecond",
            "maxtickspersecond",
            "maxunack",
            "meleearmor",
            "meleedamage",
            "metabolismtick",
            "netcache",
            "netcachesize",
            "netlog",
            "official",
            "plantlightdetection",
            "planttick",
            "planttickscale",
            "playerserverfall",
            "playertimeout",
            "pve",
            "queriespersecond",
            "radiation",
            "respawnresetrange",
            "savecachesize",
            "saveinterval",
            "schematime",
            "secure",
            "showholstereditems",
            "stability",
            "server.tickrate",
            "woundingenabled",
            "max_density",
            "max_rate",
            "min_density",
            "min_rate",
            "player_scale",
            "respawn_groups",
            "respawn_individuals",
            "respawn_populations",
            "tick_individuals",
            "tick_populations",
            "accuracy",
            "collapse",
            "stabilityqueue",
            "strikes",
            "surroundingsqueue",
            "stability.verbose",
            "fixeddelta",
            "maxdelta",
            "pausewhileloading",
            "timescale",
            "global_broadcast",
            "boat_corpse_seconds",
            "attack",
            "damage",
            "hitboxes",
            "lineofsight",
            "protection",
            "sense",
            "triggers",
            "weakspots",
            "xmas.enabled",
            "cache",
            "print",
            "web",
            "decayseconds",
            "requiredhackseconds",
            "horse.population",
            "hotairballoon.outsidedecayminutes",
            "hotairballoon.population",
            "serviceceiling",
            "backtracking",
            "ioentity.framebudgetms",
            "responsetime",
            "minicopter.outsidedecayminutes",
            "minicopter.population",
            "motorrowboat.outsidedecayminutes",
            "motorrowboat.population",
            "sleeperhostiledelay",
            "forcebirthday",
            "maxteamsize",
            "rhibpopulation",
            "ridablehorse.population",
            "ai_dormant",
            "ai_dormant_max_wakeup_per_tick",
            "ai_htn_animal_tick_budget",
            "ai_htn_player_junkpile_tick_budget",
            "ai_htn_player_tick_budget",
            "ai_htn_use_agency_tick",
            "ai_to_player_distance_wakeup_range",
            "nav_disable",
            "nav_obstacles_carve_state",
            "nav_wait",
            "pathfindingiterationsperframe",
            "cover_point_sample_step_height",
            "cover_point_sample_step_size",
            "alltarget",
            "staticrepairseconds",
            "altitudeaboveterrain",
            "desiredaltitude",
            "stag.population",
            "wolf.population",
            "zombie.population"});
            this.SearchVar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SearchVar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SearchVar.Location = new System.Drawing.Point(2, 34);
            this.SearchVar.Name = "SearchVar";
            this.SearchVar.Size = new System.Drawing.Size(232, 20);
            this.SearchVar.TabIndex = 34;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(240, 33);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 20);
            this.button6.TabIndex = 31;
            this.button6.Text = "SELECT";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click_1);
            // 
            // label48
            // 
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label48.Location = new System.Drawing.Point(1, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(344, 28);
            this.label48.TabIndex = 0;
            this.label48.Text = "SEARCH SERVER VARIABLE";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.BTNadd);
            this.panel2.Controls.Add(this.btnclear);
            this.panel2.Controls.Add(this.varvalue);
            this.panel2.Controls.Add(this.varvar);
            this.panel2.Controls.Add(this.label30);
            this.panel2.Controls.Add(this.label28);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Location = new System.Drawing.Point(2, 213);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 103);
            this.panel2.TabIndex = 32;
            // 
            // BTNadd
            // 
            this.BTNadd.Location = new System.Drawing.Point(134, 73);
            this.BTNadd.Name = "BTNadd";
            this.BTNadd.Size = new System.Drawing.Size(100, 23);
            this.BTNadd.TabIndex = 2;
            this.BTNadd.Text = "ADD";
            this.BTNadd.UseVisualStyleBackColor = true;
            this.BTNadd.Click += new System.EventHandler(this.BTNadd_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(240, 73);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(100, 23);
            this.btnclear.TabIndex = 2;
            this.btnclear.Text = "CLEAR";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.Btnclear_Click_1);
            // 
            // varvalue
            // 
            this.varvalue.Location = new System.Drawing.Point(240, 48);
            this.varvalue.Name = "varvalue";
            this.varvalue.Size = new System.Drawing.Size(100, 20);
            this.varvalue.TabIndex = 1;
            // 
            // varvar
            // 
            this.varvar.Location = new System.Drawing.Point(1, 48);
            this.varvar.Name = "varvar";
            this.varvar.Size = new System.Drawing.Size(233, 20);
            this.varvar.TabIndex = 1;
            // 
            // label30
            // 
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label30.Location = new System.Drawing.Point(240, 26);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(100, 28);
            this.label30.TabIndex = 0;
            this.label30.Text = "VALUE";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label28.Location = new System.Drawing.Point(3, 26);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(231, 28);
            this.label28.TabIndex = 0;
            this.label28.Text = "VARIABLE";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Location = new System.Drawing.Point(-1, -2);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(346, 28);
            this.label17.TabIndex = 0;
            this.label17.Text = "ADD SERVER VARIABLE";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServerVars
            // 
            this.ServerVars.AllowUserToAddRows = false;
            this.ServerVars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ServerVars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServerVars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Variable,
            this.Value});
            this.ServerVars.Location = new System.Drawing.Point(-2, -2);
            this.ServerVars.Name = "ServerVars";
            this.ServerVars.RowHeadersWidth = 92;
            this.ServerVars.Size = new System.Drawing.Size(357, 191);
            this.ServerVars.TabIndex = 30;
            // 
            // Variable
            // 
            this.Variable.HeaderText = "Variable";
            this.Variable.MinimumWidth = 11;
            this.Variable.Name = "Variable";
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.MinimumWidth = 11;
            this.Value.Name = "Value";
            // 
            // BtnCLLearVars
            // 
            this.BtnCLLearVars.Location = new System.Drawing.Point(274, 189);
            this.BtnCLLearVars.Name = "BtnCLLearVars";
            this.BtnCLLearVars.Size = new System.Drawing.Size(75, 23);
            this.BtnCLLearVars.TabIndex = 31;
            this.BtnCLLearVars.Text = "CLEAR";
            this.BtnCLLearVars.UseVisualStyleBackColor = true;
            this.BtnCLLearVars.Click += new System.EventHandler(this.BtnCLLearVars_Click);
            // 
            // BtnCompleteVars
            // 
            this.BtnCompleteVars.Location = new System.Drawing.Point(2, 189);
            this.BtnCompleteVars.Name = "BtnCompleteVars";
            this.BtnCompleteVars.Size = new System.Drawing.Size(75, 23);
            this.BtnCompleteVars.TabIndex = 31;
            this.BtnCompleteVars.Text = "DONE";
            this.BtnCompleteVars.UseVisualStyleBackColor = true;
            this.BtnCompleteVars.Click += new System.EventHandler(this.BtnCompleteVars_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(138, 189);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 31;
            this.button12.Text = "Full List";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Button12_Click_1);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SteelBlue;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.infolabel);
            this.panel5.Controls.Add(this.label47);
            this.panel5.Location = new System.Drawing.Point(4, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(456, 94);
            this.panel5.TabIndex = 17;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // infolabel
            // 
            this.infolabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.infolabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infolabel.ForeColor = System.Drawing.SystemColors.Window;
            this.infolabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.infolabel.Location = new System.Drawing.Point(-2, 39);
            this.infolabel.Name = "infolabel";
            this.infolabel.Size = new System.Drawing.Size(456, 51);
            this.infolabel.TabIndex = 1;
            this.infolabel.Text = "Start by downloading SteamCMD";
            this.infolabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.infolabel.Click += new System.EventHandler(this.infolabel_Click);
            // 
            // label47
            // 
            this.label47.BackColor = System.Drawing.Color.Transparent;
            this.label47.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.ForeColor = System.Drawing.SystemColors.Control;
            this.label47.Location = new System.Drawing.Point(-3, 3);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(454, 32);
            this.label47.TabIndex = 0;
            this.label47.Text = "PROGRESS";
            this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServerVarsFinal
            // 
            this.ServerVarsFinal.Location = new System.Drawing.Point(464, 850);
            this.ServerVarsFinal.Multiline = true;
            this.ServerVarsFinal.Name = "ServerVarsFinal";
            this.ServerVarsFinal.Size = new System.Drawing.Size(605, 77);
            this.ServerVarsFinal.TabIndex = 29;
            // 
            // panel12
            // 
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel12.Controls.Add(this.BtnStart);
            this.panel12.Controls.Add(this.StartFileList);
            this.panel12.Controls.Add(this.label68);
            this.panel12.Location = new System.Drawing.Point(7, 647);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(453, 71);
            this.panel12.TabIndex = 28;
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(366, 35);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(70, 23);
            this.BtnStart.TabIndex = 3;
            this.BtnStart.Text = "START";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // StartFileList
            // 
            this.StartFileList.FormattingEnabled = true;
            this.StartFileList.Location = new System.Drawing.Point(5, 36);
            this.StartFileList.Name = "StartFileList";
            this.StartFileList.Size = new System.Drawing.Size(350, 21);
            this.StartFileList.TabIndex = 2;
            this.StartFileList.SelectedIndexChanged += new System.EventHandler(this.StartFileList_SelectedIndexChanged);
            this.StartFileList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StartFileList_MouseClick);
            // 
            // label68
            // 
            this.label68.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label68.ForeColor = System.Drawing.SystemColors.Control;
            this.label68.Location = new System.Drawing.Point(45, 0);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(357, 25);
            this.label68.TabIndex = 0;
            this.label68.Text = "START YOUR SERVER";
            this.label68.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel9.Controls.Add(this.PreviewDesc);
            this.panel9.Controls.Add(this.button11);
            this.panel9.Controls.Add(this.BtnRefreshbrowser);
            this.panel9.Controls.Add(this.BtnViewPage);
            this.panel9.Controls.Add(this.panel13);
            this.panel9.Controls.Add(this.label42);
            this.panel9.Controls.Add(this.FakeMS);
            this.panel9.Controls.Add(this.MaxPlayersPrev);
            this.panel9.Controls.Add(this.mapTypeprev);
            this.panel9.Controls.Add(this.label38);
            this.panel9.Controls.Add(this.serverTitle);
            this.panel9.Controls.Add(this.BannerServer);
            this.panel9.Controls.Add(this.PreviewPic);
            this.panel9.Location = new System.Drawing.Point(846, 6);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(544, 800);
            this.panel9.TabIndex = 27;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint_2);
            // 
            // PreviewDesc
            // 
            this.PreviewDesc.BackColor = System.Drawing.Color.Transparent;
            this.PreviewDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviewDesc.ForeColor = System.Drawing.SystemColors.Control;
            this.PreviewDesc.Location = new System.Drawing.Point(10, 558);
            this.PreviewDesc.Name = "PreviewDesc";
            this.PreviewDesc.Size = new System.Drawing.Size(515, 163);
            this.PreviewDesc.TabIndex = 4;
            this.PreviewDesc.Text = "Ted Pommes is.... \\namazing";
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Green;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.ForeColor = System.Drawing.SystemColors.Control;
            this.button11.Location = new System.Drawing.Point(365, 735);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(160, 52);
            this.button11.TabIndex = 3;
            this.button11.Text = "JOIN SERVER";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.Button11_Click);
            // 
            // BtnRefreshbrowser
            // 
            this.BtnRefreshbrowser.BackColor = System.Drawing.Color.Gray;
            this.BtnRefreshbrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefreshbrowser.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnRefreshbrowser.Location = new System.Drawing.Point(232, 735);
            this.BtnRefreshbrowser.Name = "BtnRefreshbrowser";
            this.BtnRefreshbrowser.Size = new System.Drawing.Size(127, 52);
            this.BtnRefreshbrowser.TabIndex = 3;
            this.BtnRefreshbrowser.Text = "REFRESH";
            this.BtnRefreshbrowser.UseVisualStyleBackColor = false;
            this.BtnRefreshbrowser.Click += new System.EventHandler(this.BtnRefreshbrowser_Click);
            // 
            // BtnViewPage
            // 
            this.BtnViewPage.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnViewPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnViewPage.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnViewPage.Location = new System.Drawing.Point(13, 734);
            this.BtnViewPage.Name = "BtnViewPage";
            this.BtnViewPage.Size = new System.Drawing.Size(148, 52);
            this.BtnViewPage.TabIndex = 3;
            this.BtnViewPage.Text = "VIEW WEBPAGE";
            this.BtnViewPage.UseVisualStyleBackColor = false;
            this.BtnViewPage.Click += new System.EventHandler(this.BtnViewPage_Click);
            // 
            // panel13
            // 
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel13.Controls.Add(this.textBox1);
            this.panel13.Controls.Add(this.label83);
            this.panel13.Location = new System.Drawing.Point(2, 3);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(534, 279);
            this.panel13.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 42);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(524, 230);
            this.textBox1.TabIndex = 1;
            // 
            // label83
            // 
            this.label83.BackColor = System.Drawing.Color.Transparent;
            this.label83.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label83.ForeColor = System.Drawing.SystemColors.Control;
            this.label83.Location = new System.Drawing.Point(1, 2);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(529, 32);
            this.label83.TabIndex = 0;
            this.label83.Text = "STEAMCMD PROGRESS";
            this.label83.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label42
            // 
            this.label42.BackColor = System.Drawing.Color.Transparent;
            this.label42.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.SystemColors.Control;
            this.label42.Location = new System.Drawing.Point(347, 507);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(30, 32);
            this.label42.TabIndex = 0;
            this.label42.Text = "-";
            this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label42.Click += new System.EventHandler(this.label38_Click_1);
            // 
            // FakeMS
            // 
            this.FakeMS.BackColor = System.Drawing.Color.Transparent;
            this.FakeMS.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakeMS.ForeColor = System.Drawing.SystemColors.Control;
            this.FakeMS.Location = new System.Drawing.Point(369, 507);
            this.FakeMS.Name = "FakeMS";
            this.FakeMS.Size = new System.Drawing.Size(60, 32);
            this.FakeMS.TabIndex = 0;
            this.FakeMS.Text = "10ms";
            this.FakeMS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FakeMS.Click += new System.EventHandler(this.label38_Click_1);
            // 
            // MaxPlayersPrev
            // 
            this.MaxPlayersPrev.BackColor = System.Drawing.Color.Transparent;
            this.MaxPlayersPrev.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxPlayersPrev.ForeColor = System.Drawing.SystemColors.Control;
            this.MaxPlayersPrev.Location = new System.Drawing.Point(273, 507);
            this.MaxPlayersPrev.Name = "MaxPlayersPrev";
            this.MaxPlayersPrev.Size = new System.Drawing.Size(79, 32);
            this.MaxPlayersPrev.TabIndex = 0;
            this.MaxPlayersPrev.Text = "50/50";
            this.MaxPlayersPrev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MaxPlayersPrev.Click += new System.EventHandler(this.label38_Click_1);
            // 
            // mapTypeprev
            // 
            this.mapTypeprev.BackColor = System.Drawing.Color.Transparent;
            this.mapTypeprev.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapTypeprev.ForeColor = System.Drawing.SystemColors.Control;
            this.mapTypeprev.Location = new System.Drawing.Point(97, 507);
            this.mapTypeprev.Name = "mapTypeprev";
            this.mapTypeprev.Size = new System.Drawing.Size(149, 32);
            this.mapTypeprev.TabIndex = 0;
            this.mapTypeprev.Text = "Procedural Map";
            this.mapTypeprev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mapTypeprev.Click += new System.EventHandler(this.label38_Click_1);
            // 
            // label38
            // 
            this.label38.BackColor = System.Drawing.Color.Transparent;
            this.label38.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.SystemColors.Control;
            this.label38.Location = new System.Drawing.Point(243, 507);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(31, 32);
            this.label38.TabIndex = 0;
            this.label38.Text = "-";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label38.Click += new System.EventHandler(this.label38_Click_1);
            // 
            // serverTitle
            // 
            this.serverTitle.BackColor = System.Drawing.Color.Transparent;
            this.serverTitle.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.serverTitle.Location = new System.Drawing.Point(13, 481);
            this.serverTitle.Name = "serverTitle";
            this.serverTitle.Size = new System.Drawing.Size(512, 32);
            this.serverTitle.TabIndex = 0;
            this.serverTitle.Text = "Snitzel";
            this.serverTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.serverTitle.Click += new System.EventHandler(this.label38_Click_1);
            // 
            // BannerServer
            // 
            this.BannerServer.Location = new System.Drawing.Point(13, 297);
            this.BannerServer.Name = "BannerServer";
            this.BannerServer.Size = new System.Drawing.Size(512, 256);
            this.BannerServer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BannerServer.TabIndex = 1;
            this.BannerServer.TabStop = false;
            // 
            // PreviewPic
            // 
            this.PreviewPic.Location = new System.Drawing.Point(5, 290);
            this.PreviewPic.Name = "PreviewPic";
            this.PreviewPic.Size = new System.Drawing.Size(529, 501);
            this.PreviewPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PreviewPic.TabIndex = 0;
            this.PreviewPic.TabStop = false;
            this.PreviewPic.Click += new System.EventHandler(this.PreviewPic_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(1405, 282);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(106, 35);
            this.button10.TabIndex = 26;
            this.button10.Text = "start server";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(1404, 220);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(101, 23);
            this.progressBar2.TabIndex = 25;
            this.progressBar2.Click += new System.EventHandler(this.progressBar2_Click);
            // 
            // label43
            // 
            this.label43.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.SystemColors.Control;
            this.label43.Location = new System.Drawing.Point(241, 808);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(102, 25);
            this.label43.TabIndex = 0;
            this.label43.Text = "TWITCH";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label43.Click += new System.EventHandler(this.label81_Click);
            // 
            // label81
            // 
            this.label81.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label81.ForeColor = System.Drawing.SystemColors.Control;
            this.label81.Location = new System.Drawing.Point(361, 808);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(102, 25);
            this.label81.TabIndex = 0;
            this.label81.Text = "YOUTUBE";
            this.label81.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label81.Click += new System.EventHandler(this.label81_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1404, 167);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(101, 52);
            this.button9.TabIndex = 24;
            this.button9.Text = "DOWNLOAD OXIDE";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.DownloadOxide_Click);
            // 
            // label80
            // 
            this.label80.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label80.ForeColor = System.Drawing.SystemColors.Control;
            this.label80.Location = new System.Drawing.Point(125, 808);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(102, 25);
            this.label80.TabIndex = 0;
            this.label80.Text = "TWITTER";
            this.label80.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label78
            // 
            this.label78.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label78.ForeColor = System.Drawing.SystemColors.Control;
            this.label78.Location = new System.Drawing.Point(9, 808);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(102, 25);
            this.label78.TabIndex = 0;
            this.label78.Text = "DISCORD";
            this.label78.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.RefreshSmall);
            this.panel4.Controls.Add(this.mapinfolab);
            this.panel4.Controls.Add(this.mapPic);
            this.panel4.Location = new System.Drawing.Point(477, 415);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(357, 296);
            this.panel4.TabIndex = 16;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // RefreshSmall
            // 
            this.RefreshSmall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RefreshSmall.BackgroundImage")));
            this.RefreshSmall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RefreshSmall.Location = new System.Drawing.Point(320, 259);
            this.RefreshSmall.Name = "RefreshSmall";
            this.RefreshSmall.Size = new System.Drawing.Size(31, 30);
            this.RefreshSmall.TabIndex = 3;
            this.RefreshSmall.UseVisualStyleBackColor = true;
            this.RefreshSmall.Click += new System.EventHandler(this.RefreshSmall_Click);
            // 
            // mapinfolab
            // 
            this.mapinfolab.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapinfolab.ForeColor = System.Drawing.SystemColors.Control;
            this.mapinfolab.Location = new System.Drawing.Point(5, 274);
            this.mapinfolab.Name = "mapinfolab";
            this.mapinfolab.Size = new System.Drawing.Size(345, 13);
            this.mapinfolab.TabIndex = 2;
            this.mapinfolab.Text = "ProcGen Map";
            this.mapinfolab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mapPic
            // 
            this.mapPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mapPic.Location = new System.Drawing.Point(2, 1);
            this.mapPic.Name = "mapPic";
            this.mapPic.Size = new System.Drawing.Size(350, 290);
            this.mapPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mapPic.TabIndex = 0;
            this.mapPic.TabStop = false;
            this.mapPic.Click += new System.EventHandler(this.mapPic_Click);
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(1397, 808);
            this.test.Multiline = true;
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(192, 66);
            this.test.TabIndex = 23;
            // 
            // parametersbox
            // 
            this.parametersbox.Location = new System.Drawing.Point(1404, 141);
            this.parametersbox.Name = "parametersbox";
            this.parametersbox.Size = new System.Drawing.Size(107, 20);
            this.parametersbox.TabIndex = 21;
            this.parametersbox.TextChanged += new System.EventHandler(this.parametersbox_TextChanged);
            // 
            // deditextbox
            // 
            this.deditextbox.Location = new System.Drawing.Point(1397, 580);
            this.deditextbox.Multiline = true;
            this.deditextbox.Name = "deditextbox";
            this.deditextbox.Size = new System.Drawing.Size(185, 82);
            this.deditextbox.TabIndex = 15;
            // 
            // loglog
            // 
            this.loglog.Location = new System.Drawing.Point(1404, 256);
            this.loglog.Name = "loglog";
            this.loglog.Size = new System.Drawing.Size(100, 20);
            this.loglog.TabIndex = 9;
            this.loglog.Text = "\\logs";
            this.loglog.TextChanged += new System.EventHandler(this.loglog_TextChanged);
            // 
            // quibox
            // 
            this.quibox.Location = new System.Drawing.Point(1404, 114);
            this.quibox.Name = "quibox";
            this.quibox.Size = new System.Drawing.Size(100, 20);
            this.quibox.TabIndex = 9;
            this.quibox.Text = "\"";
            // 
            // slashbox
            // 
            this.slashbox.Location = new System.Drawing.Point(1405, 88);
            this.slashbox.Name = "slashbox";
            this.slashbox.Size = new System.Drawing.Size(100, 20);
            this.slashbox.TabIndex = 9;
            this.slashbox.Text = "\\";
            // 
            // steamcmdbox
            // 
            this.steamcmdbox.Location = new System.Drawing.Point(1405, 35);
            this.steamcmdbox.Name = "steamcmdbox";
            this.steamcmdbox.Size = new System.Drawing.Size(100, 20);
            this.steamcmdbox.TabIndex = 8;
            this.steamcmdbox.Text = "\\steamcmd";
            // 
            // serbat
            // 
            this.serbat.Location = new System.Drawing.Point(1405, 61);
            this.serbat.Name = "serbat";
            this.serbat.Size = new System.Drawing.Size(100, 20);
            this.serbat.TabIndex = 8;
            this.serbat.Text = "\\server.bat";
            // 
            // Finaltext
            // 
            this.Finaltext.Location = new System.Drawing.Point(1397, 668);
            this.Finaltext.Multiline = true;
            this.Finaltext.Name = "Finaltext";
            this.Finaltext.Size = new System.Drawing.Size(185, 107);
            this.Finaltext.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1397, 775);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1404, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CadetBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.RdioStaging);
            this.panel3.Controls.Add(this.RdioNormal);
            this.panel3.Controls.Add(this.steamcmdIns);
            this.panel3.Controls.Add(this.progressBar1);
            this.panel3.Controls.Add(this.label29);
            this.panel3.Location = new System.Drawing.Point(4, 107);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(457, 121);
            this.panel3.TabIndex = 13;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // RdioStaging
            // 
            this.RdioStaging.AutoSize = true;
            this.RdioStaging.Location = new System.Drawing.Point(278, 56);
            this.RdioStaging.Name = "RdioStaging";
            this.RdioStaging.Size = new System.Drawing.Size(153, 17);
            this.RdioStaging.TabIndex = 14;
            this.RdioStaging.Text = "Staging Branch Server";
            this.RdioStaging.UseVisualStyleBackColor = true;
            // 
            // RdioNormal
            // 
            this.RdioNormal.AutoSize = true;
            this.RdioNormal.Checked = true;
            this.RdioNormal.Location = new System.Drawing.Point(278, 36);
            this.RdioNormal.Name = "RdioNormal";
            this.RdioNormal.Size = new System.Drawing.Size(105, 17);
            this.RdioNormal.TabIndex = 14;
            this.RdioNormal.TabStop = true;
            this.RdioNormal.Text = "Normal Server";
            this.RdioNormal.UseVisualStyleBackColor = true;
            // 
            // steamcmdIns
            // 
            this.steamcmdIns.Location = new System.Drawing.Point(138, 36);
            this.steamcmdIns.Name = "steamcmdIns";
            this.steamcmdIns.Size = new System.Drawing.Size(122, 37);
            this.steamcmdIns.TabIndex = 10;
            this.steamcmdIns.Text = "DOWNLOAD SERVER FILES";
            this.steamcmdIns.UseVisualStyleBackColor = true;
            this.steamcmdIns.Click += new System.EventHandler(this.DownloadSteamCMD_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(2, 91);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(449, 23);
            this.progressBar1.TabIndex = 11;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label29
            // 
            this.label29.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label29.Location = new System.Drawing.Point(-2, -2);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(457, 35);
            this.label29.TabIndex = 1;
            this.label29.Text = "RUST SERVER FILES";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // da
            // 
            this.da.Controls.Add(this.procgen);
            this.da.Controls.Add(this.custom);
            this.da.Controls.Add(this.Hapis);
            this.da.Controls.Add(this.BARREN);
            this.da.Controls.Add(this.CRAGGY);
            this.da.Controls.Add(this.SAVAS);
            this.da.Controls.Add(this.KOTH);
            this.da.Location = new System.Drawing.Point(4, 234);
            this.da.Name = "da";
            this.da.SelectedIndex = 0;
            this.da.Size = new System.Drawing.Size(457, 407);
            this.da.TabIndex = 0;
            // 
            // procgen
            // 
            this.procgen.BackColor = System.Drawing.Color.CadetBlue;
            this.procgen.Controls.Add(this.genbtn);
            this.procgen.Controls.Add(this.mapseedtext);
            this.procgen.Controls.Add(this.mapsizebox);
            this.procgen.Controls.Add(this.maxplayertext);
            this.procgen.Controls.Add(this.serverdisctext);
            this.procgen.Controls.Add(this.serverurltext);
            this.procgen.Controls.Add(this.serverpicturetext);
            this.procgen.Controls.Add(this.rconpasstext);
            this.procgen.Controls.Add(this.rconporttext);
            this.procgen.Controls.Add(this.serverporttext);
            this.procgen.Controls.Add(this.servernametext);
            this.procgen.Controls.Add(this.identitytext);
            this.procgen.Controls.Add(this.label13);
            this.procgen.Controls.Add(this.label12);
            this.procgen.Controls.Add(this.label11);
            this.procgen.Controls.Add(this.label10);
            this.procgen.Controls.Add(this.label9);
            this.procgen.Controls.Add(this.label8);
            this.procgen.Controls.Add(this.label6);
            this.procgen.Controls.Add(this.label5);
            this.procgen.Controls.Add(this.label4);
            this.procgen.Controls.Add(this.label3);
            this.procgen.Controls.Add(this.label2);
            this.procgen.Controls.Add(this.label1);
            this.procgen.Location = new System.Drawing.Point(4, 22);
            this.procgen.Name = "procgen";
            this.procgen.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.procgen.Size = new System.Drawing.Size(449, 381);
            this.procgen.TabIndex = 0;
            this.procgen.Text = "PROCGEN";
            this.procgen.Click += new System.EventHandler(this.procgen_Click);
            // 
            // genbtn
            // 
            this.genbtn.Location = new System.Drawing.Point(148, 333);
            this.genbtn.Name = "genbtn";
            this.genbtn.Size = new System.Drawing.Size(295, 32);
            this.genbtn.TabIndex = 4;
            this.genbtn.Text = "GENERATE START FILE";
            this.genbtn.UseVisualStyleBackColor = true;
            this.genbtn.Click += new System.EventHandler(this.genbtn_Click);
            // 
            // mapseedtext
            // 
            this.mapseedtext.Location = new System.Drawing.Point(148, 308);
            this.mapseedtext.Name = "mapseedtext";
            this.mapseedtext.Size = new System.Drawing.Size(295, 20);
            this.mapseedtext.TabIndex = 2;
            this.mapseedtext.Text = "2";
            // 
            // mapsizebox
            // 
            this.mapsizebox.Location = new System.Drawing.Point(150, 282);
            this.mapsizebox.Name = "mapsizebox";
            this.mapsizebox.Size = new System.Drawing.Size(294, 20);
            this.mapsizebox.TabIndex = 2;
            this.mapsizebox.Text = "3000";
            // 
            // maxplayertext
            // 
            this.maxplayertext.Location = new System.Drawing.Point(149, 256);
            this.maxplayertext.Name = "maxplayertext";
            this.maxplayertext.Size = new System.Drawing.Size(294, 20);
            this.maxplayertext.TabIndex = 2;
            this.maxplayertext.Text = "10";
            this.maxplayertext.TextChanged += new System.EventHandler(this.maxplayertext_TextChanged);
            // 
            // serverdisctext
            // 
            this.serverdisctext.Location = new System.Drawing.Point(149, 230);
            this.serverdisctext.Name = "serverdisctext";
            this.serverdisctext.Size = new System.Drawing.Size(294, 20);
            this.serverdisctext.TabIndex = 2;
            this.serverdisctext.Text = "Ted Pommes is.... \\namazing";
            // 
            // serverurltext
            // 
            this.serverurltext.Location = new System.Drawing.Point(149, 204);
            this.serverurltext.Name = "serverurltext";
            this.serverurltext.Size = new System.Drawing.Size(294, 20);
            this.serverurltext.TabIndex = 2;
            this.serverurltext.Text = "https://discord.gg/DPKWPr4";
            // 
            // serverpicturetext
            // 
            this.serverpicturetext.Location = new System.Drawing.Point(149, 178);
            this.serverpicturetext.Name = "serverpicturetext";
            this.serverpicturetext.Size = new System.Drawing.Size(294, 20);
            this.serverpicturetext.TabIndex = 2;
            this.serverpicturetext.Text = "https://i.imgur.com/sqGFVW9.png";
            this.serverpicturetext.TextChanged += new System.EventHandler(this.serverpicturetext_TextChanged);
            // 
            // rconpasstext
            // 
            this.rconpasstext.Location = new System.Drawing.Point(149, 152);
            this.rconpasstext.Name = "rconpasstext";
            this.rconpasstext.Size = new System.Drawing.Size(294, 20);
            this.rconpasstext.TabIndex = 2;
            this.rconpasstext.Text = "123456seven";
            // 
            // rconporttext
            // 
            this.rconporttext.Location = new System.Drawing.Point(149, 126);
            this.rconporttext.Name = "rconporttext";
            this.rconporttext.Size = new System.Drawing.Size(294, 20);
            this.rconporttext.TabIndex = 4;
            this.rconporttext.Text = "28016";
            // 
            // serverporttext
            // 
            this.serverporttext.Location = new System.Drawing.Point(149, 100);
            this.serverporttext.Name = "serverporttext";
            this.serverporttext.Size = new System.Drawing.Size(294, 20);
            this.serverporttext.TabIndex = 3;
            this.serverporttext.Text = "28015";
            // 
            // servernametext
            // 
            this.servernametext.Location = new System.Drawing.Point(149, 74);
            this.servernametext.Name = "servernametext";
            this.servernametext.Size = new System.Drawing.Size(294, 20);
            this.servernametext.TabIndex = 2;
            this.servernametext.Text = "Snitzel";
            this.servernametext.TextChanged += new System.EventHandler(this.servernametext_TextChanged);
            // 
            // identitytext
            // 
            this.identitytext.Location = new System.Drawing.Point(149, 48);
            this.identitytext.Name = "identitytext";
            this.identitytext.Size = new System.Drawing.Size(294, 20);
            this.identitytext.TabIndex = 1;
            this.identitytext.Text = "ProcGen";
            this.identitytext.TextChanged += new System.EventHandler(this.identitytext_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(66, 311);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "MAP SEED";
            this.label13.Click += new System.EventHandler(this.label3_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(69, 285);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "MAP SIZE";
            this.label12.Click += new System.EventHandler(this.label3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(49, 259);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "MAX PLAYERS";
            this.label11.Click += new System.EventHandler(this.label3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(-1, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "SERVER DISCRIPTION";
            this.label10.Click += new System.EventHandler(this.label3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "SERVER WEBSITE";
            this.label9.Click += new System.EventHandler(this.label3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "SERVER PICTURE";
            this.label8.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "RCON PASSWORD";
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "RCON PORT";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "SERVER PORT";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "SERVER NAME";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SERVER IDENTITY";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROCGEN MAP GENERATOR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // custom
            // 
            this.custom.BackColor = System.Drawing.Color.CadetBlue;
            this.custom.Controls.Add(this.BTNbatchCustom);
            this.custom.Controls.Add(this.mapurlbox);
            this.custom.Controls.Add(this.CMmaxplayertext);
            this.custom.Controls.Add(this.CMserverdisctext);
            this.custom.Controls.Add(this.CMserverurltext);
            this.custom.Controls.Add(this.CMserverpicturetext);
            this.custom.Controls.Add(this.CMrconpasstext);
            this.custom.Controls.Add(this.CMrconporttext);
            this.custom.Controls.Add(this.CMserverportext);
            this.custom.Controls.Add(this.CMservernametext);
            this.custom.Controls.Add(this.CMidentitytext);
            this.custom.Controls.Add(this.label16);
            this.custom.Controls.Add(this.label18);
            this.custom.Controls.Add(this.label19);
            this.custom.Controls.Add(this.label20);
            this.custom.Controls.Add(this.label21);
            this.custom.Controls.Add(this.label22);
            this.custom.Controls.Add(this.label23);
            this.custom.Controls.Add(this.label24);
            this.custom.Controls.Add(this.label25);
            this.custom.Controls.Add(this.label26);
            this.custom.Controls.Add(this.label27);
            this.custom.Location = new System.Drawing.Point(4, 22);
            this.custom.Name = "custom";
            this.custom.Size = new System.Drawing.Size(449, 381);
            this.custom.TabIndex = 1;
            this.custom.Text = "CUSTOM MAP";
            // 
            // BTNbatchCustom
            // 
            this.BTNbatchCustom.Location = new System.Drawing.Point(150, 321);
            this.BTNbatchCustom.Name = "BTNbatchCustom";
            this.BTNbatchCustom.Size = new System.Drawing.Size(296, 32);
            this.BTNbatchCustom.TabIndex = 30;
            this.BTNbatchCustom.Text = "GENERATE START FILE";
            this.BTNbatchCustom.UseVisualStyleBackColor = true;
            this.BTNbatchCustom.Click += new System.EventHandler(this.button2_Click);
            // 
            // mapurlbox
            // 
            this.mapurlbox.Location = new System.Drawing.Point(150, 295);
            this.mapurlbox.Name = "mapurlbox";
            this.mapurlbox.Size = new System.Drawing.Size(294, 20);
            this.mapurlbox.TabIndex = 27;
            this.mapurlbox.Text = "https://www.dropbox.com/s/vvl3nynh9vzhthn/1kbuildprac2019.map?dl=1";
            this.mapurlbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // CMmaxplayertext
            // 
            this.CMmaxplayertext.Location = new System.Drawing.Point(150, 269);
            this.CMmaxplayertext.Name = "CMmaxplayertext";
            this.CMmaxplayertext.Size = new System.Drawing.Size(294, 20);
            this.CMmaxplayertext.TabIndex = 25;
            this.CMmaxplayertext.Text = "10";
            this.CMmaxplayertext.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // CMserverdisctext
            // 
            this.CMserverdisctext.Location = new System.Drawing.Point(150, 243);
            this.CMserverdisctext.Name = "CMserverdisctext";
            this.CMserverdisctext.Size = new System.Drawing.Size(294, 20);
            this.CMserverdisctext.TabIndex = 24;
            this.CMserverdisctext.Text = "Ted Pommes is.... \\namazing";
            this.CMserverdisctext.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // CMserverurltext
            // 
            this.CMserverurltext.Location = new System.Drawing.Point(150, 217);
            this.CMserverurltext.Name = "CMserverurltext";
            this.CMserverurltext.Size = new System.Drawing.Size(294, 20);
            this.CMserverurltext.TabIndex = 23;
            this.CMserverurltext.Text = "https://discord.gg/DPKWPr4";
            this.CMserverurltext.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // CMserverpicturetext
            // 
            this.CMserverpicturetext.Location = new System.Drawing.Point(148, 191);
            this.CMserverpicturetext.Name = "CMserverpicturetext";
            this.CMserverpicturetext.Size = new System.Drawing.Size(294, 20);
            this.CMserverpicturetext.TabIndex = 22;
            this.CMserverpicturetext.Text = "https://i.imgur.com/sqGFVW9.png";
            this.CMserverpicturetext.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // CMrconpasstext
            // 
            this.CMrconpasstext.Location = new System.Drawing.Point(148, 165);
            this.CMrconpasstext.Name = "CMrconpasstext";
            this.CMrconpasstext.Size = new System.Drawing.Size(294, 20);
            this.CMrconpasstext.TabIndex = 21;
            this.CMrconpasstext.Text = "123456seven";
            this.CMrconpasstext.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // CMrconporttext
            // 
            this.CMrconporttext.Location = new System.Drawing.Point(148, 139);
            this.CMrconporttext.Name = "CMrconporttext";
            this.CMrconporttext.Size = new System.Drawing.Size(294, 20);
            this.CMrconporttext.TabIndex = 20;
            this.CMrconporttext.Text = "28016";
            this.CMrconporttext.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // CMserverportext
            // 
            this.CMserverportext.Location = new System.Drawing.Point(148, 113);
            this.CMserverportext.Name = "CMserverportext";
            this.CMserverportext.Size = new System.Drawing.Size(294, 20);
            this.CMserverportext.TabIndex = 19;
            this.CMserverportext.Text = "28015";
            this.CMserverportext.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // CMservernametext
            // 
            this.CMservernametext.Location = new System.Drawing.Point(148, 87);
            this.CMservernametext.Name = "CMservernametext";
            this.CMservernametext.Size = new System.Drawing.Size(294, 20);
            this.CMservernametext.TabIndex = 28;
            this.CMservernametext.Text = "Snitzel";
            this.CMservernametext.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // CMidentitytext
            // 
            this.CMidentitytext.Location = new System.Drawing.Point(147, 61);
            this.CMidentitytext.Name = "CMidentitytext";
            this.CMidentitytext.Size = new System.Drawing.Size(294, 20);
            this.CMidentitytext.TabIndex = 18;
            this.CMidentitytext.Text = "CustomMap";
            this.CMidentitytext.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(82, 298);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "MAP URL";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(50, 272);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(94, 13);
            this.label18.TabIndex = 13;
            this.label18.Text = "MAX PLAYERS";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(0, 246);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(144, 13);
            this.label19.TabIndex = 12;
            this.label19.Text = "SERVER DISCRIPTION";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(27, 220);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(117, 13);
            this.label20.TabIndex = 11;
            this.label20.Text = "SERVER WEBSITE";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(28, 194);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(114, 13);
            this.label21.TabIndex = 10;
            this.label21.Text = "SERVER PICTURE";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(26, 168);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(116, 13);
            this.label22.TabIndex = 9;
            this.label22.Text = "RCON PASSWORD";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(64, 142);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(78, 13);
            this.label23.TabIndex = 8;
            this.label23.Text = "RCON PORT";
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(50, 116);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(92, 13);
            this.label24.TabIndex = 7;
            this.label24.Text = "SERVER PORT";
            this.label24.Click += new System.EventHandler(this.label24_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(47, 90);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(95, 13);
            this.label25.TabIndex = 6;
            this.label25.Text = "SERVER NAME";
            this.label25.Click += new System.EventHandler(this.label25_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(20, 64);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(121, 13);
            this.label26.TabIndex = 17;
            this.label26.Text = "SERVER IDENTITY";
            this.label26.Click += new System.EventHandler(this.label26_Click);
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(6, 3);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(443, 32);
            this.label27.TabIndex = 5;
            this.label27.Text = "CUSTOM MAP GENERATOR";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label27.Click += new System.EventHandler(this.label27_Click);
            // 
            // Hapis
            // 
            this.Hapis.BackColor = System.Drawing.Color.CadetBlue;
            this.Hapis.Controls.Add(this.HAidentitytext);
            this.Hapis.Controls.Add(this.label7);
            this.Hapis.Controls.Add(this.button3);
            this.Hapis.Controls.Add(this.HPmaxplayertext);
            this.Hapis.Controls.Add(this.HPserverdisctext);
            this.Hapis.Controls.Add(this.HPserverurltext);
            this.Hapis.Controls.Add(this.HPserverpicturetext);
            this.Hapis.Controls.Add(this.HPrconpasstext);
            this.Hapis.Controls.Add(this.HPrconporttext);
            this.Hapis.Controls.Add(this.HPserverportext);
            this.Hapis.Controls.Add(this.HPservernametext);
            this.Hapis.Controls.Add(this.label45);
            this.Hapis.Controls.Add(this.label46);
            this.Hapis.Controls.Add(this.label49);
            this.Hapis.Controls.Add(this.label50);
            this.Hapis.Controls.Add(this.label51);
            this.Hapis.Controls.Add(this.label52);
            this.Hapis.Controls.Add(this.label53);
            this.Hapis.Controls.Add(this.label54);
            this.Hapis.Controls.Add(this.label56);
            this.Hapis.Location = new System.Drawing.Point(4, 22);
            this.Hapis.Name = "Hapis";
            this.Hapis.Size = new System.Drawing.Size(449, 381);
            this.Hapis.TabIndex = 2;
            this.Hapis.Text = "HAPIS";
            this.Hapis.Click += new System.EventHandler(this.Hapis_Click);
            // 
            // HAidentitytext
            // 
            this.HAidentitytext.Location = new System.Drawing.Point(148, 60);
            this.HAidentitytext.Name = "HAidentitytext";
            this.HAidentitytext.Size = new System.Drawing.Size(294, 20);
            this.HAidentitytext.TabIndex = 42;
            this.HAidentitytext.Text = "HapisIsland";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "SERVER IDENTITY";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(148, 292);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(296, 37);
            this.button3.TabIndex = 39;
            this.button3.Text = "GENERATE START FILE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // HPmaxplayertext
            // 
            this.HPmaxplayertext.Location = new System.Drawing.Point(148, 266);
            this.HPmaxplayertext.Name = "HPmaxplayertext";
            this.HPmaxplayertext.Size = new System.Drawing.Size(296, 20);
            this.HPmaxplayertext.TabIndex = 34;
            this.HPmaxplayertext.Text = "10";
            // 
            // HPserverdisctext
            // 
            this.HPserverdisctext.Location = new System.Drawing.Point(148, 240);
            this.HPserverdisctext.Name = "HPserverdisctext";
            this.HPserverdisctext.Size = new System.Drawing.Size(296, 20);
            this.HPserverdisctext.TabIndex = 33;
            this.HPserverdisctext.Text = "Ted Pommes is.... \\namazing";
            // 
            // HPserverurltext
            // 
            this.HPserverurltext.Location = new System.Drawing.Point(148, 214);
            this.HPserverurltext.Name = "HPserverurltext";
            this.HPserverurltext.Size = new System.Drawing.Size(296, 20);
            this.HPserverurltext.TabIndex = 32;
            this.HPserverurltext.Text = "https://discord.gg/DPKWPr4";
            // 
            // HPserverpicturetext
            // 
            this.HPserverpicturetext.Location = new System.Drawing.Point(148, 188);
            this.HPserverpicturetext.Name = "HPserverpicturetext";
            this.HPserverpicturetext.Size = new System.Drawing.Size(296, 20);
            this.HPserverpicturetext.TabIndex = 31;
            this.HPserverpicturetext.Text = "https://i.imgur.com/sqGFVW9.png";
            // 
            // HPrconpasstext
            // 
            this.HPrconpasstext.Location = new System.Drawing.Point(148, 162);
            this.HPrconpasstext.Name = "HPrconpasstext";
            this.HPrconpasstext.Size = new System.Drawing.Size(296, 20);
            this.HPrconpasstext.TabIndex = 30;
            this.HPrconpasstext.Text = "123456seven";
            // 
            // HPrconporttext
            // 
            this.HPrconporttext.Location = new System.Drawing.Point(148, 136);
            this.HPrconporttext.Name = "HPrconporttext";
            this.HPrconporttext.Size = new System.Drawing.Size(296, 20);
            this.HPrconporttext.TabIndex = 29;
            this.HPrconporttext.Text = "28016";
            // 
            // HPserverportext
            // 
            this.HPserverportext.Location = new System.Drawing.Point(148, 110);
            this.HPserverportext.Name = "HPserverportext";
            this.HPserverportext.Size = new System.Drawing.Size(296, 20);
            this.HPserverportext.TabIndex = 28;
            this.HPserverportext.Text = "28015";
            // 
            // HPservernametext
            // 
            this.HPservernametext.Location = new System.Drawing.Point(148, 84);
            this.HPservernametext.Name = "HPservernametext";
            this.HPservernametext.Size = new System.Drawing.Size(296, 20);
            this.HPservernametext.TabIndex = 37;
            this.HPservernametext.Text = "Snitzel";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(48, 269);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(94, 13);
            this.label45.TabIndex = 22;
            this.label45.Text = "MAX PLAYERS";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(-2, 243);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(144, 13);
            this.label46.TabIndex = 21;
            this.label46.Text = "SERVER DISCRIPTION";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(25, 217);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(117, 13);
            this.label49.TabIndex = 20;
            this.label49.Text = "SERVER WEBSITE";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(28, 191);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(114, 13);
            this.label50.TabIndex = 19;
            this.label50.Text = "SERVER PICTURE";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(26, 165);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(116, 13);
            this.label51.TabIndex = 18;
            this.label51.Text = "RCON PASSWORD";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(64, 139);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(78, 13);
            this.label52.TabIndex = 17;
            this.label52.Text = "RCON PORT";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.Location = new System.Drawing.Point(50, 113);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(92, 13);
            this.label53.TabIndex = 16;
            this.label53.Text = "SERVER PORT";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.Location = new System.Drawing.Point(47, 87);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(95, 13);
            this.label54.TabIndex = 15;
            this.label54.Text = "SERVER NAME";
            // 
            // label56
            // 
            this.label56.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.Location = new System.Drawing.Point(6, 3);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(444, 33);
            this.label56.TabIndex = 14;
            this.label56.Text = "HAPIS ISLAND GENERATOR";
            this.label56.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BARREN
            // 
            this.BARREN.BackColor = System.Drawing.Color.CadetBlue;
            this.BARREN.Controls.Add(this.BAidentitytext);
            this.BARREN.Controls.Add(this.label15);
            this.BARREN.Controls.Add(this.BAmapseedtext);
            this.BARREN.Controls.Add(this.BAmapsizebox);
            this.BARREN.Controls.Add(this.BAmaxplayertext);
            this.BARREN.Controls.Add(this.BAserverdisctext);
            this.BARREN.Controls.Add(this.BAserverurltext);
            this.BARREN.Controls.Add(this.BAserverpicturetext);
            this.BARREN.Controls.Add(this.BArconpasstext);
            this.BARREN.Controls.Add(this.BArconporttext);
            this.BARREN.Controls.Add(this.BAserverportext);
            this.BARREN.Controls.Add(this.BAservernametext);
            this.BARREN.Controls.Add(this.label44);
            this.BARREN.Controls.Add(this.label55);
            this.BARREN.Controls.Add(this.label58);
            this.BARREN.Controls.Add(this.label59);
            this.BARREN.Controls.Add(this.label60);
            this.BARREN.Controls.Add(this.label61);
            this.BARREN.Controls.Add(this.label62);
            this.BARREN.Controls.Add(this.label63);
            this.BARREN.Controls.Add(this.label64);
            this.BARREN.Controls.Add(this.label65);
            this.BARREN.Controls.Add(this.label67);
            this.BARREN.Controls.Add(this.button4);
            this.BARREN.Location = new System.Drawing.Point(4, 22);
            this.BARREN.Name = "BARREN";
            this.BARREN.Size = new System.Drawing.Size(449, 381);
            this.BARREN.TabIndex = 3;
            this.BARREN.Text = "BARREN";
            // 
            // BAidentitytext
            // 
            this.BAidentitytext.Location = new System.Drawing.Point(148, 38);
            this.BAidentitytext.Name = "BAidentitytext";
            this.BAidentitytext.Size = new System.Drawing.Size(294, 20);
            this.BAidentitytext.TabIndex = 65;
            this.BAidentitytext.Text = "Barren";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(21, 41);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 13);
            this.label15.TabIndex = 64;
            this.label15.Text = "SERVER IDENTITY";
            // 
            // BAmapseedtext
            // 
            this.BAmapseedtext.Location = new System.Drawing.Point(147, 298);
            this.BAmapseedtext.Name = "BAmapseedtext";
            this.BAmapseedtext.Size = new System.Drawing.Size(295, 20);
            this.BAmapseedtext.TabIndex = 63;
            this.BAmapseedtext.Text = "2";
            // 
            // BAmapsizebox
            // 
            this.BAmapsizebox.Location = new System.Drawing.Point(149, 272);
            this.BAmapsizebox.Name = "BAmapsizebox";
            this.BAmapsizebox.Size = new System.Drawing.Size(294, 20);
            this.BAmapsizebox.TabIndex = 62;
            this.BAmapsizebox.Text = "3000";
            // 
            // BAmaxplayertext
            // 
            this.BAmaxplayertext.Location = new System.Drawing.Point(148, 246);
            this.BAmaxplayertext.Name = "BAmaxplayertext";
            this.BAmaxplayertext.Size = new System.Drawing.Size(294, 20);
            this.BAmaxplayertext.TabIndex = 61;
            this.BAmaxplayertext.Text = "10";
            // 
            // BAserverdisctext
            // 
            this.BAserverdisctext.Location = new System.Drawing.Point(148, 220);
            this.BAserverdisctext.Name = "BAserverdisctext";
            this.BAserverdisctext.Size = new System.Drawing.Size(294, 20);
            this.BAserverdisctext.TabIndex = 60;
            this.BAserverdisctext.Text = "Ted Pommes is.... \\namazing";
            // 
            // BAserverurltext
            // 
            this.BAserverurltext.Location = new System.Drawing.Point(148, 194);
            this.BAserverurltext.Name = "BAserverurltext";
            this.BAserverurltext.Size = new System.Drawing.Size(294, 20);
            this.BAserverurltext.TabIndex = 59;
            this.BAserverurltext.Text = "https://discord.gg/DPKWPr4";
            // 
            // BAserverpicturetext
            // 
            this.BAserverpicturetext.Location = new System.Drawing.Point(148, 168);
            this.BAserverpicturetext.Name = "BAserverpicturetext";
            this.BAserverpicturetext.Size = new System.Drawing.Size(294, 20);
            this.BAserverpicturetext.TabIndex = 58;
            this.BAserverpicturetext.Text = "https://i.imgur.com/sqGFVW9.png";
            // 
            // BArconpasstext
            // 
            this.BArconpasstext.Location = new System.Drawing.Point(148, 142);
            this.BArconpasstext.Name = "BArconpasstext";
            this.BArconpasstext.Size = new System.Drawing.Size(294, 20);
            this.BArconpasstext.TabIndex = 57;
            this.BArconpasstext.Text = "123456seven";
            // 
            // BArconporttext
            // 
            this.BArconporttext.Location = new System.Drawing.Point(148, 116);
            this.BArconporttext.Name = "BArconporttext";
            this.BArconporttext.Size = new System.Drawing.Size(294, 20);
            this.BArconporttext.TabIndex = 56;
            this.BArconporttext.Text = "28016";
            // 
            // BAserverportext
            // 
            this.BAserverportext.Location = new System.Drawing.Point(148, 90);
            this.BAserverportext.Name = "BAserverportext";
            this.BAserverportext.Size = new System.Drawing.Size(294, 20);
            this.BAserverportext.TabIndex = 55;
            this.BAserverportext.Text = "28015";
            // 
            // BAservernametext
            // 
            this.BAservernametext.Location = new System.Drawing.Point(148, 64);
            this.BAservernametext.Name = "BAservernametext";
            this.BAservernametext.Size = new System.Drawing.Size(294, 20);
            this.BAservernametext.TabIndex = 54;
            this.BAservernametext.Text = "Snitzel";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(65, 301);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(71, 13);
            this.label44.TabIndex = 51;
            this.label44.Text = "MAP SEED";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.Location = new System.Drawing.Point(68, 275);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(68, 13);
            this.label55.TabIndex = 50;
            this.label55.Text = "MAP SIZE";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.Location = new System.Drawing.Point(48, 249);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(94, 13);
            this.label58.TabIndex = 49;
            this.label58.Text = "MAX PLAYERS";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.Location = new System.Drawing.Point(-2, 223);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(144, 13);
            this.label59.TabIndex = 48;
            this.label59.Text = "SERVER DISCRIPTION";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.Location = new System.Drawing.Point(25, 197);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(117, 13);
            this.label60.TabIndex = 47;
            this.label60.Text = "SERVER WEBSITE";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.Location = new System.Drawing.Point(28, 171);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(114, 13);
            this.label61.TabIndex = 46;
            this.label61.Text = "SERVER PICTURE";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.Location = new System.Drawing.Point(26, 145);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(116, 13);
            this.label62.TabIndex = 45;
            this.label62.Text = "RCON PASSWORD";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.Location = new System.Drawing.Point(64, 119);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(78, 13);
            this.label63.TabIndex = 44;
            this.label63.Text = "RCON PORT";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.Location = new System.Drawing.Point(50, 93);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(92, 13);
            this.label64.TabIndex = 43;
            this.label64.Text = "SERVER PORT";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.Location = new System.Drawing.Point(47, 67);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(95, 13);
            this.label65.TabIndex = 42;
            this.label65.Text = "SERVER NAME";
            // 
            // label67
            // 
            this.label67.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label67.Location = new System.Drawing.Point(6, 3);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(440, 33);
            this.label67.TabIndex = 41;
            this.label67.Text = "PROCGEN MAP GENERATOR";
            this.label67.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(148, 324);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(298, 37);
            this.button4.TabIndex = 39;
            this.button4.Text = "GENERATE START FILE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // CRAGGY
            // 
            this.CRAGGY.BackColor = System.Drawing.Color.CadetBlue;
            this.CRAGGY.Controls.Add(this.CRidentitytext);
            this.CRAGGY.Controls.Add(this.label36);
            this.CRAGGY.Controls.Add(this.button5);
            this.CRAGGY.Controls.Add(this.CRmaxplayertext);
            this.CRAGGY.Controls.Add(this.CRserverdisctext);
            this.CRAGGY.Controls.Add(this.CRserverurltext);
            this.CRAGGY.Controls.Add(this.CRserverpicturetext);
            this.CRAGGY.Controls.Add(this.CRrconpasstext);
            this.CRAGGY.Controls.Add(this.CRrconporttext);
            this.CRAGGY.Controls.Add(this.CRserverportext);
            this.CRAGGY.Controls.Add(this.CRservernametext);
            this.CRAGGY.Controls.Add(this.label69);
            this.CRAGGY.Controls.Add(this.label70);
            this.CRAGGY.Controls.Add(this.label71);
            this.CRAGGY.Controls.Add(this.label72);
            this.CRAGGY.Controls.Add(this.label73);
            this.CRAGGY.Controls.Add(this.label74);
            this.CRAGGY.Controls.Add(this.label75);
            this.CRAGGY.Controls.Add(this.label76);
            this.CRAGGY.Controls.Add(this.label77);
            this.CRAGGY.Location = new System.Drawing.Point(4, 22);
            this.CRAGGY.Name = "CRAGGY";
            this.CRAGGY.Size = new System.Drawing.Size(449, 381);
            this.CRAGGY.TabIndex = 4;
            this.CRAGGY.Text = "CRAGGY";
            // 
            // CRidentitytext
            // 
            this.CRidentitytext.Location = new System.Drawing.Point(148, 55);
            this.CRidentitytext.Name = "CRidentitytext";
            this.CRidentitytext.Size = new System.Drawing.Size(298, 20);
            this.CRidentitytext.TabIndex = 63;
            this.CRidentitytext.Text = "Craggy";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(21, 58);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(121, 13);
            this.label36.TabIndex = 62;
            this.label36.Text = "SERVER IDENTITY";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(148, 288);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(294, 37);
            this.button5.TabIndex = 60;
            this.button5.Text = "GENERATE START FILE";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // CRmaxplayertext
            // 
            this.CRmaxplayertext.Location = new System.Drawing.Point(149, 262);
            this.CRmaxplayertext.Name = "CRmaxplayertext";
            this.CRmaxplayertext.Size = new System.Drawing.Size(296, 20);
            this.CRmaxplayertext.TabIndex = 57;
            this.CRmaxplayertext.Text = "10";
            // 
            // CRserverdisctext
            // 
            this.CRserverdisctext.Location = new System.Drawing.Point(149, 236);
            this.CRserverdisctext.Name = "CRserverdisctext";
            this.CRserverdisctext.Size = new System.Drawing.Size(296, 20);
            this.CRserverdisctext.TabIndex = 56;
            this.CRserverdisctext.Text = "Ted Pommes is.... \\namazing";
            // 
            // CRserverurltext
            // 
            this.CRserverurltext.Location = new System.Drawing.Point(149, 210);
            this.CRserverurltext.Name = "CRserverurltext";
            this.CRserverurltext.Size = new System.Drawing.Size(296, 20);
            this.CRserverurltext.TabIndex = 55;
            this.CRserverurltext.Text = "https://discord.gg/DPKWPr4";
            // 
            // CRserverpicturetext
            // 
            this.CRserverpicturetext.Location = new System.Drawing.Point(149, 184);
            this.CRserverpicturetext.Name = "CRserverpicturetext";
            this.CRserverpicturetext.Size = new System.Drawing.Size(296, 20);
            this.CRserverpicturetext.TabIndex = 54;
            this.CRserverpicturetext.Text = "https://i.imgur.com/sqGFVW9.png";
            // 
            // CRrconpasstext
            // 
            this.CRrconpasstext.Location = new System.Drawing.Point(149, 158);
            this.CRrconpasstext.Name = "CRrconpasstext";
            this.CRrconpasstext.Size = new System.Drawing.Size(296, 20);
            this.CRrconpasstext.TabIndex = 53;
            this.CRrconpasstext.Text = "123456seven";
            // 
            // CRrconporttext
            // 
            this.CRrconporttext.Location = new System.Drawing.Point(149, 132);
            this.CRrconporttext.Name = "CRrconporttext";
            this.CRrconporttext.Size = new System.Drawing.Size(296, 20);
            this.CRrconporttext.TabIndex = 52;
            this.CRrconporttext.Text = "28016";
            // 
            // CRserverportext
            // 
            this.CRserverportext.Location = new System.Drawing.Point(149, 106);
            this.CRserverportext.Name = "CRserverportext";
            this.CRserverportext.Size = new System.Drawing.Size(296, 20);
            this.CRserverportext.TabIndex = 51;
            this.CRserverportext.Text = "28015";
            // 
            // CRservernametext
            // 
            this.CRservernametext.Location = new System.Drawing.Point(149, 80);
            this.CRservernametext.Name = "CRservernametext";
            this.CRservernametext.Size = new System.Drawing.Size(296, 20);
            this.CRservernametext.TabIndex = 58;
            this.CRservernametext.Text = "Snitzel";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label69.Location = new System.Drawing.Point(49, 265);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(94, 13);
            this.label69.TabIndex = 49;
            this.label69.Text = "MAX PLAYERS";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label70.Location = new System.Drawing.Point(-1, 239);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(144, 13);
            this.label70.TabIndex = 48;
            this.label70.Text = "SERVER DISCRIPTION";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label71.Location = new System.Drawing.Point(26, 213);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(117, 13);
            this.label71.TabIndex = 47;
            this.label71.Text = "SERVER WEBSITE";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label72.Location = new System.Drawing.Point(29, 187);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(114, 13);
            this.label72.TabIndex = 46;
            this.label72.Text = "SERVER PICTURE";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label73.Location = new System.Drawing.Point(27, 161);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(116, 13);
            this.label73.TabIndex = 45;
            this.label73.Text = "RCON PASSWORD";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label74.Location = new System.Drawing.Point(65, 135);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(78, 13);
            this.label74.TabIndex = 44;
            this.label74.Text = "RCON PORT";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label75.Location = new System.Drawing.Point(51, 109);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(92, 13);
            this.label75.TabIndex = 43;
            this.label75.Text = "SERVER PORT";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label76.Location = new System.Drawing.Point(48, 83);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(95, 13);
            this.label76.TabIndex = 42;
            this.label76.Text = "SERVER NAME";
            // 
            // label77
            // 
            this.label77.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label77.Location = new System.Drawing.Point(6, 3);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(438, 33);
            this.label77.TabIndex = 41;
            this.label77.Text = "CRAGGY  ISLAND GENERATOR";
            this.label77.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SAVAS
            // 
            this.SAVAS.BackColor = System.Drawing.Color.CadetBlue;
            this.SAVAS.Controls.Add(this.SAidentitytext);
            this.SAVAS.Controls.Add(this.label39);
            this.SAVAS.Controls.Add(this.button7);
            this.SAVAS.Controls.Add(this.SAmaxplayertext);
            this.SAVAS.Controls.Add(this.SAserverdisctext);
            this.SAVAS.Controls.Add(this.SAserverurltext);
            this.SAVAS.Controls.Add(this.SAserverpicturetext);
            this.SAVAS.Controls.Add(this.SArconpasstext);
            this.SAVAS.Controls.Add(this.SArconporttext);
            this.SAVAS.Controls.Add(this.SAserverportext);
            this.SAVAS.Controls.Add(this.SAservernametext);
            this.SAVAS.Controls.Add(this.label84);
            this.SAVAS.Controls.Add(this.label85);
            this.SAVAS.Controls.Add(this.label86);
            this.SAVAS.Controls.Add(this.label87);
            this.SAVAS.Controls.Add(this.label88);
            this.SAVAS.Controls.Add(this.label89);
            this.SAVAS.Controls.Add(this.label90);
            this.SAVAS.Controls.Add(this.label91);
            this.SAVAS.Controls.Add(this.label92);
            this.SAVAS.Location = new System.Drawing.Point(4, 22);
            this.SAVAS.Name = "SAVAS";
            this.SAVAS.Size = new System.Drawing.Size(449, 381);
            this.SAVAS.TabIndex = 5;
            this.SAVAS.Text = "SAVAS";
            // 
            // SAidentitytext
            // 
            this.SAidentitytext.Location = new System.Drawing.Point(148, 55);
            this.SAidentitytext.Name = "SAidentitytext";
            this.SAidentitytext.Size = new System.Drawing.Size(298, 20);
            this.SAidentitytext.TabIndex = 63;
            this.SAidentitytext.Text = "Savas";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(21, 58);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(121, 13);
            this.label39.TabIndex = 62;
            this.label39.Text = "SERVER IDENTITY";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(148, 288);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(294, 37);
            this.button7.TabIndex = 60;
            this.button7.Text = "GENERATE START FILE";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // SAmaxplayertext
            // 
            this.SAmaxplayertext.Location = new System.Drawing.Point(149, 262);
            this.SAmaxplayertext.Name = "SAmaxplayertext";
            this.SAmaxplayertext.Size = new System.Drawing.Size(296, 20);
            this.SAmaxplayertext.TabIndex = 57;
            this.SAmaxplayertext.Text = "10";
            // 
            // SAserverdisctext
            // 
            this.SAserverdisctext.Location = new System.Drawing.Point(149, 236);
            this.SAserverdisctext.Name = "SAserverdisctext";
            this.SAserverdisctext.Size = new System.Drawing.Size(296, 20);
            this.SAserverdisctext.TabIndex = 56;
            this.SAserverdisctext.Text = "Ted Pommes is.... \\namazing";
            // 
            // SAserverurltext
            // 
            this.SAserverurltext.Location = new System.Drawing.Point(149, 210);
            this.SAserverurltext.Name = "SAserverurltext";
            this.SAserverurltext.Size = new System.Drawing.Size(296, 20);
            this.SAserverurltext.TabIndex = 55;
            this.SAserverurltext.Text = "https://discord.gg/DPKWPr4";
            // 
            // SAserverpicturetext
            // 
            this.SAserverpicturetext.Location = new System.Drawing.Point(149, 184);
            this.SAserverpicturetext.Name = "SAserverpicturetext";
            this.SAserverpicturetext.Size = new System.Drawing.Size(296, 20);
            this.SAserverpicturetext.TabIndex = 54;
            this.SAserverpicturetext.Text = "https://i.imgur.com/sqGFVW9.png";
            // 
            // SArconpasstext
            // 
            this.SArconpasstext.Location = new System.Drawing.Point(149, 158);
            this.SArconpasstext.Name = "SArconpasstext";
            this.SArconpasstext.Size = new System.Drawing.Size(296, 20);
            this.SArconpasstext.TabIndex = 53;
            this.SArconpasstext.Text = "123456seven";
            // 
            // SArconporttext
            // 
            this.SArconporttext.Location = new System.Drawing.Point(149, 132);
            this.SArconporttext.Name = "SArconporttext";
            this.SArconporttext.Size = new System.Drawing.Size(296, 20);
            this.SArconporttext.TabIndex = 52;
            this.SArconporttext.Text = "28016";
            // 
            // SAserverportext
            // 
            this.SAserverportext.Location = new System.Drawing.Point(149, 106);
            this.SAserverportext.Name = "SAserverportext";
            this.SAserverportext.Size = new System.Drawing.Size(296, 20);
            this.SAserverportext.TabIndex = 51;
            this.SAserverportext.Text = "28015";
            // 
            // SAservernametext
            // 
            this.SAservernametext.Location = new System.Drawing.Point(149, 80);
            this.SAservernametext.Name = "SAservernametext";
            this.SAservernametext.Size = new System.Drawing.Size(296, 20);
            this.SAservernametext.TabIndex = 58;
            this.SAservernametext.Text = "Snitzel";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label84.Location = new System.Drawing.Point(49, 265);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(94, 13);
            this.label84.TabIndex = 49;
            this.label84.Text = "MAX PLAYERS";
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label85.Location = new System.Drawing.Point(-1, 239);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(144, 13);
            this.label85.TabIndex = 48;
            this.label85.Text = "SERVER DISCRIPTION";
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label86.Location = new System.Drawing.Point(26, 213);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(117, 13);
            this.label86.TabIndex = 47;
            this.label86.Text = "SERVER WEBSITE";
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label87.Location = new System.Drawing.Point(29, 187);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(114, 13);
            this.label87.TabIndex = 46;
            this.label87.Text = "SERVER PICTURE";
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label88.Location = new System.Drawing.Point(27, 161);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(116, 13);
            this.label88.TabIndex = 45;
            this.label88.Text = "RCON PASSWORD";
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label89.Location = new System.Drawing.Point(65, 135);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(78, 13);
            this.label89.TabIndex = 44;
            this.label89.Text = "RCON PORT";
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label90.Location = new System.Drawing.Point(51, 109);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(92, 13);
            this.label90.TabIndex = 43;
            this.label90.Text = "SERVER PORT";
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label91.Location = new System.Drawing.Point(48, 83);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(95, 13);
            this.label91.TabIndex = 42;
            this.label91.Text = "SERVER NAME";
            // 
            // label92
            // 
            this.label92.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label92.Location = new System.Drawing.Point(6, 3);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(444, 33);
            this.label92.TabIndex = 41;
            this.label92.Text = "SAVAS ISLAND GENERATOR";
            this.label92.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KOTH
            // 
            this.KOTH.BackColor = System.Drawing.Color.CadetBlue;
            this.KOTH.Controls.Add(this.KOidentitytext);
            this.KOTH.Controls.Add(this.label40);
            this.KOTH.Controls.Add(this.button8);
            this.KOTH.Controls.Add(this.KOmaxplayertext);
            this.KOTH.Controls.Add(this.KOserverdisctext);
            this.KOTH.Controls.Add(this.KOserverurltext);
            this.KOTH.Controls.Add(this.KOserverpicturetext);
            this.KOTH.Controls.Add(this.KOrconpasstext);
            this.KOTH.Controls.Add(this.KOrconporttext);
            this.KOTH.Controls.Add(this.KOserverportext);
            this.KOTH.Controls.Add(this.KOservernametext);
            this.KOTH.Controls.Add(this.label95);
            this.KOTH.Controls.Add(this.label96);
            this.KOTH.Controls.Add(this.label97);
            this.KOTH.Controls.Add(this.label98);
            this.KOTH.Controls.Add(this.label99);
            this.KOTH.Controls.Add(this.label100);
            this.KOTH.Controls.Add(this.label101);
            this.KOTH.Controls.Add(this.label102);
            this.KOTH.Controls.Add(this.label103);
            this.KOTH.Location = new System.Drawing.Point(4, 22);
            this.KOTH.Name = "KOTH";
            this.KOTH.Size = new System.Drawing.Size(449, 381);
            this.KOTH.TabIndex = 6;
            this.KOTH.Text = "KOTH";
            // 
            // KOidentitytext
            // 
            this.KOidentitytext.Location = new System.Drawing.Point(148, 55);
            this.KOidentitytext.Name = "KOidentitytext";
            this.KOidentitytext.Size = new System.Drawing.Size(298, 20);
            this.KOidentitytext.TabIndex = 63;
            this.KOidentitytext.Text = "SavasKOTH";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(21, 58);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(121, 13);
            this.label40.TabIndex = 62;
            this.label40.Text = "SERVER IDENTITY";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(148, 288);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(294, 37);
            this.button8.TabIndex = 60;
            this.button8.Text = "GENERATE START FILE";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // KOmaxplayertext
            // 
            this.KOmaxplayertext.Location = new System.Drawing.Point(149, 262);
            this.KOmaxplayertext.Name = "KOmaxplayertext";
            this.KOmaxplayertext.Size = new System.Drawing.Size(296, 20);
            this.KOmaxplayertext.TabIndex = 57;
            this.KOmaxplayertext.Text = "10";
            // 
            // KOserverdisctext
            // 
            this.KOserverdisctext.Location = new System.Drawing.Point(149, 236);
            this.KOserverdisctext.Name = "KOserverdisctext";
            this.KOserverdisctext.Size = new System.Drawing.Size(296, 20);
            this.KOserverdisctext.TabIndex = 56;
            this.KOserverdisctext.Text = "Ted Pommes is.... \\namazing";
            // 
            // KOserverurltext
            // 
            this.KOserverurltext.Location = new System.Drawing.Point(149, 210);
            this.KOserverurltext.Name = "KOserverurltext";
            this.KOserverurltext.Size = new System.Drawing.Size(296, 20);
            this.KOserverurltext.TabIndex = 55;
            this.KOserverurltext.Text = "https://discord.gg/DPKWPr4";
            // 
            // KOserverpicturetext
            // 
            this.KOserverpicturetext.Location = new System.Drawing.Point(149, 184);
            this.KOserverpicturetext.Name = "KOserverpicturetext";
            this.KOserverpicturetext.Size = new System.Drawing.Size(296, 20);
            this.KOserverpicturetext.TabIndex = 54;
            this.KOserverpicturetext.Text = "https://i.imgur.com/sqGFVW9.png";
            // 
            // KOrconpasstext
            // 
            this.KOrconpasstext.Location = new System.Drawing.Point(149, 158);
            this.KOrconpasstext.Name = "KOrconpasstext";
            this.KOrconpasstext.Size = new System.Drawing.Size(296, 20);
            this.KOrconpasstext.TabIndex = 53;
            this.KOrconpasstext.Text = "123456seven";
            // 
            // KOrconporttext
            // 
            this.KOrconporttext.Location = new System.Drawing.Point(149, 132);
            this.KOrconporttext.Name = "KOrconporttext";
            this.KOrconporttext.Size = new System.Drawing.Size(296, 20);
            this.KOrconporttext.TabIndex = 52;
            this.KOrconporttext.Text = "28016";
            // 
            // KOserverportext
            // 
            this.KOserverportext.Location = new System.Drawing.Point(149, 106);
            this.KOserverportext.Name = "KOserverportext";
            this.KOserverportext.Size = new System.Drawing.Size(296, 20);
            this.KOserverportext.TabIndex = 51;
            this.KOserverportext.Text = "28015";
            // 
            // KOservernametext
            // 
            this.KOservernametext.Location = new System.Drawing.Point(149, 80);
            this.KOservernametext.Name = "KOservernametext";
            this.KOservernametext.Size = new System.Drawing.Size(296, 20);
            this.KOservernametext.TabIndex = 58;
            this.KOservernametext.Text = "Snitzel";
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label95.Location = new System.Drawing.Point(49, 265);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(94, 13);
            this.label95.TabIndex = 49;
            this.label95.Text = "MAX PLAYERS";
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label96.Location = new System.Drawing.Point(-1, 239);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(144, 13);
            this.label96.TabIndex = 48;
            this.label96.Text = "SERVER DISCRIPTION";
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label97.Location = new System.Drawing.Point(26, 213);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(117, 13);
            this.label97.TabIndex = 47;
            this.label97.Text = "SERVER WEBSITE";
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label98.Location = new System.Drawing.Point(29, 187);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(114, 13);
            this.label98.TabIndex = 46;
            this.label98.Text = "SERVER PICTURE";
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label99.Location = new System.Drawing.Point(27, 161);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(116, 13);
            this.label99.TabIndex = 45;
            this.label99.Text = "RCON PASSWORD";
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label100.Location = new System.Drawing.Point(65, 135);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(78, 13);
            this.label100.TabIndex = 44;
            this.label100.Text = "RCON PORT";
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label101.Location = new System.Drawing.Point(51, 109);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(92, 13);
            this.label101.TabIndex = 43;
            this.label101.Text = "SERVER PORT";
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label102.Location = new System.Drawing.Point(48, 83);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(95, 13);
            this.label102.TabIndex = 42;
            this.label102.Text = "SERVER NAME";
            // 
            // label103
            // 
            this.label103.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold);
            this.label103.Location = new System.Drawing.Point(6, 3);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(444, 33);
            this.label103.TabIndex = 41;
            this.label103.Text = "SAVAS KOTH ISLAND GENERATOR";
            this.label103.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.LogLocation);
            this.panel1.Controls.Add(this.dedicateddirectory);
            this.panel1.Controls.Add(this.servfilesdirectory);
            this.panel1.Controls.Add(this.cmdbatdirstaging);
            this.panel1.Controls.Add(this.cmdbatdir);
            this.panel1.Controls.Add(this.CMDDirectorybox);
            this.panel1.Controls.Add(this.serverdirectorytext);
            this.panel1.Controls.Add(this.label34);
            this.panel1.Controls.Add(this.label33);
            this.panel1.Location = new System.Drawing.Point(1391, 329);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 245);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label14.Location = new System.Drawing.Point(66, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(141, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "BAT FILE DIRECTORY";
            this.label14.Click += new System.EventHandler(this.label3_Click);
            // 
            // LogLocation
            // 
            this.LogLocation.Location = new System.Drawing.Point(13, 220);
            this.LogLocation.Name = "LogLocation";
            this.LogLocation.Size = new System.Drawing.Size(286, 20);
            this.LogLocation.TabIndex = 0;
            // 
            // dedicateddirectory
            // 
            this.dedicateddirectory.Location = new System.Drawing.Point(13, 193);
            this.dedicateddirectory.Name = "dedicateddirectory";
            this.dedicateddirectory.Size = new System.Drawing.Size(286, 20);
            this.dedicateddirectory.TabIndex = 0;
            // 
            // servfilesdirectory
            // 
            this.servfilesdirectory.Location = new System.Drawing.Point(13, 167);
            this.servfilesdirectory.Name = "servfilesdirectory";
            this.servfilesdirectory.Size = new System.Drawing.Size(286, 20);
            this.servfilesdirectory.TabIndex = 0;
            // 
            // cmdbatdirstaging
            // 
            this.cmdbatdirstaging.Location = new System.Drawing.Point(8, 113);
            this.cmdbatdirstaging.Name = "cmdbatdirstaging";
            this.cmdbatdirstaging.Size = new System.Drawing.Size(286, 20);
            this.cmdbatdirstaging.TabIndex = 0;
            // 
            // cmdbatdir
            // 
            this.cmdbatdir.Location = new System.Drawing.Point(8, 87);
            this.cmdbatdir.Name = "cmdbatdir";
            this.cmdbatdir.Size = new System.Drawing.Size(286, 20);
            this.cmdbatdir.TabIndex = 0;
            // 
            // CMDDirectorybox
            // 
            this.CMDDirectorybox.Location = new System.Drawing.Point(8, 61);
            this.CMDDirectorybox.Name = "CMDDirectorybox";
            this.CMDDirectorybox.Size = new System.Drawing.Size(315, 20);
            this.CMDDirectorybox.TabIndex = 0;
            // 
            // serverdirectorytext
            // 
            this.serverdirectorytext.Location = new System.Drawing.Point(9, 22);
            this.serverdirectorytext.Name = "serverdirectorytext";
            this.serverdirectorytext.Size = new System.Drawing.Size(286, 20);
            this.serverdirectorytext.TabIndex = 0;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label34.Location = new System.Drawing.Point(74, 150);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(132, 13);
            this.label34.TabIndex = 1;
            this.label34.Text = "serv files directory";
            this.label34.Click += new System.EventHandler(this.label3_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label33.Location = new System.Drawing.Point(86, 45);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(98, 13);
            this.label33.TabIndex = 1;
            this.label33.Text = "cmd directory";
            this.label33.Click += new System.EventHandler(this.label3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.maintab);
            this.tabControl1.Location = new System.Drawing.Point(-4, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1729, 983);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 768);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ultimate Server Setup Rust - USSR! V0.4 Fixed by BMGJET";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.maintab.ResumeLayout(false);
            this.maintab.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServerVars)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BannerServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPic)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mapPic)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.da.ResumeLayout(false);
            this.procgen.ResumeLayout(false);
            this.procgen.PerformLayout();
            this.custom.ResumeLayout(false);
            this.custom.PerformLayout();
            this.Hapis.ResumeLayout(false);
            this.Hapis.PerformLayout();
            this.BARREN.ResumeLayout(false);
            this.BARREN.PerformLayout();
            this.CRAGGY.ResumeLayout(false);
            this.CRAGGY.PerformLayout();
            this.SAVAS.ResumeLayout(false);
            this.SAVAS.PerformLayout();
            this.KOTH.ResumeLayout(false);
            this.KOTH.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x04000007 RID: 7
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.Timer checkrun;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.Timer delay;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.MenuStrip menuStrip1;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.ToolStripMenuItem socialMediaToolStripMenuItem;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.ToolStripMenuItem videoTutorialsToolStripMenuItem;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.ToolStripMenuItem fullHostingTutorialsPlaylistToolStripMenuItem;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.ToolStripMenuItem howToHostYourOwnRustServerManuallyToolStripMenuItem;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.ToolStripMenuItem howToInstallOxideWorkWithPluginsToolStripMenuItem;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.ToolStripMenuItem howToPortForwardToolStripMenuItem;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.ToolStripMenuItem programsToolStripMenuItem;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.ToolStripMenuItem rustAdminToolStripMenuItem;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.ToolStripMenuItem rustServerManagerToolStripMenuItem;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.ToolStripMenuItem rustEditToolStripMenuItem;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.ToolStripMenuItem steamCMDToolStripMenuItem;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.ToolStripMenuItem sitesToolStripMenuItem;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.ToolStripMenuItem playRustIOToolStripMenuItem;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.ToolStripMenuItem playRustcomToolStripMenuItem;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.ToolStripMenuItem battleMetricsToolStripMenuItem;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.ToolStripMenuItem corrosionHourToolStripMenuItem;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.ToolStripMenuItem rustopiaToolStripMenuItem;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.ToolStripMenuItem umodToolStripMenuItem;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.ToolStripMenuItem chaoscodeToolStripMenuItem;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;

		// Token: 0x0400003B RID: 59
		private global::System.Windows.Forms.ToolStripMenuItem chooseAMapToolStripMenuItem;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem12;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem16;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.ToolStripMenuItem pluginsToolStripMenuItem;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.ToolStripMenuItem mainSiteToolStripMenuItem;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.ToolStripMenuItem browseFreePluginsToolStripMenuItem;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem11;

		// Token: 0x04000048 RID: 72
		private global::System.Windows.Forms.ToolStripMenuItem downloadOxideToolStripMenuItem;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem18;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.ToolStripMenuItem fortifyCreateAndDesignBaseCanBeCopiedFromOrPastedIntoRustToolStripMenuItem;

		// Token: 0x0400004D RID: 77
		private global::System.Windows.Forms.ImageList imageList1;

		// Token: 0x0400004E RID: 78
		private global::System.Windows.Forms.TabPage maintab;

		// Token: 0x0400004F RID: 79
		private global::System.Windows.Forms.ProgressBar progressBar2;

		// Token: 0x04000050 RID: 80
		private global::System.Windows.Forms.Button button9;

		// Token: 0x04000051 RID: 81
		private global::System.Windows.Forms.Panel panel4;

		// Token: 0x04000054 RID: 84
		private global::System.Windows.Forms.Label label81;

		// Token: 0x04000056 RID: 86
		private global::System.Windows.Forms.Label label80;

		// Token: 0x04000057 RID: 87
		private global::System.Windows.Forms.Label label78;

		// Token: 0x04000058 RID: 88
		private global::System.Windows.Forms.TextBox test;

		// Token: 0x04000059 RID: 89
		private global::System.Windows.Forms.TextBox parametersbox;

		// Token: 0x0400005A RID: 90
		private global::System.Windows.Forms.TextBox deditextbox;

		// Token: 0x0400005B RID: 91
		private global::System.Windows.Forms.TextBox loglog;

		// Token: 0x0400005C RID: 92
		private global::System.Windows.Forms.TextBox quibox;

		// Token: 0x0400005D RID: 93
		private global::System.Windows.Forms.TextBox slashbox;

		// Token: 0x0400005E RID: 94
		private global::System.Windows.Forms.TextBox steamcmdbox;

		// Token: 0x0400005F RID: 95
		private global::System.Windows.Forms.TextBox serbat;

		// Token: 0x04000060 RID: 96
		private global::System.Windows.Forms.TextBox Finaltext;

		// Token: 0x04000061 RID: 97
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000065 RID: 101
		private global::System.Windows.Forms.Panel panel5;

		// Token: 0x04000066 RID: 102
		private global::System.Windows.Forms.Label infolabel;

		// Token: 0x04000067 RID: 103
		private global::System.Windows.Forms.Label label47;

		// Token: 0x04000068 RID: 104
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000069 RID: 105
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x0400006B RID: 107
		private global::System.Windows.Forms.Label label29;

		// Token: 0x0400006C RID: 108
		private global::System.Windows.Forms.ProgressBar progressBar1;

		// Token: 0x0400006D RID: 109
		private global::System.Windows.Forms.Button steamcmdIns;

		// Token: 0x0400006E RID: 110
		private global::System.Windows.Forms.TabControl da;

		// Token: 0x0400006F RID: 111
		private global::System.Windows.Forms.TabPage procgen;

		// Token: 0x04000071 RID: 113
		private global::System.Windows.Forms.Button genbtn;

		// Token: 0x04000072 RID: 114
		private global::System.Windows.Forms.TextBox mapseedtext;

		// Token: 0x04000073 RID: 115
		private global::System.Windows.Forms.TextBox mapsizebox;

		// Token: 0x04000074 RID: 116
		private global::System.Windows.Forms.TextBox maxplayertext;

		// Token: 0x04000075 RID: 117
		private global::System.Windows.Forms.TextBox serverdisctext;

		// Token: 0x04000076 RID: 118
		private global::System.Windows.Forms.TextBox serverurltext;

		// Token: 0x04000077 RID: 119
		private global::System.Windows.Forms.TextBox serverpicturetext;

		// Token: 0x04000078 RID: 120
		private global::System.Windows.Forms.TextBox rconpasstext;

		// Token: 0x04000079 RID: 121
		private global::System.Windows.Forms.TextBox rconporttext;

		// Token: 0x0400007A RID: 122
		private global::System.Windows.Forms.TextBox serverporttext;

		// Token: 0x0400007B RID: 123
		private global::System.Windows.Forms.TextBox servernametext;

		// Token: 0x0400007C RID: 124
		private global::System.Windows.Forms.TextBox identitytext;

		// Token: 0x0400007D RID: 125
		private global::System.Windows.Forms.Label label13;

		// Token: 0x0400007E RID: 126
		private global::System.Windows.Forms.Label label12;

		// Token: 0x0400007F RID: 127
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04000080 RID: 128
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04000081 RID: 129
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000082 RID: 130
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000083 RID: 131
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000084 RID: 132
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000085 RID: 133
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000086 RID: 134
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000087 RID: 135
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000088 RID: 136
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000089 RID: 137
		private global::System.Windows.Forms.TabPage custom;

		// Token: 0x0400008B RID: 139
		private global::System.Windows.Forms.Button BTNbatchCustom;

		// Token: 0x0400008C RID: 140
		private global::System.Windows.Forms.TextBox mapurlbox;

		// Token: 0x0400008D RID: 141
		private global::System.Windows.Forms.TextBox CMmaxplayertext;

		// Token: 0x0400008E RID: 142
		private global::System.Windows.Forms.TextBox CMserverdisctext;

		// Token: 0x0400008F RID: 143
		private global::System.Windows.Forms.TextBox CMserverurltext;

		// Token: 0x04000090 RID: 144
		private global::System.Windows.Forms.TextBox CMserverpicturetext;

		// Token: 0x04000091 RID: 145
		private global::System.Windows.Forms.TextBox CMrconpasstext;

		// Token: 0x04000092 RID: 146
		private global::System.Windows.Forms.TextBox CMrconporttext;

		// Token: 0x04000093 RID: 147
		private global::System.Windows.Forms.TextBox CMserverportext;

		// Token: 0x04000094 RID: 148
		private global::System.Windows.Forms.TextBox CMservernametext;

		// Token: 0x04000095 RID: 149
		private global::System.Windows.Forms.TextBox CMidentitytext;

		// Token: 0x04000096 RID: 150
		private global::System.Windows.Forms.Label label16;

		// Token: 0x04000097 RID: 151
		private global::System.Windows.Forms.Label label18;

		// Token: 0x04000098 RID: 152
		private global::System.Windows.Forms.Label label19;

		// Token: 0x04000099 RID: 153
		private global::System.Windows.Forms.Label label20;

		// Token: 0x0400009A RID: 154
		private global::System.Windows.Forms.Label label21;

		// Token: 0x0400009B RID: 155
		private global::System.Windows.Forms.Label label22;

		// Token: 0x0400009C RID: 156
		private global::System.Windows.Forms.Label label23;

		// Token: 0x0400009D RID: 157
		private global::System.Windows.Forms.Label label24;

		// Token: 0x0400009E RID: 158
		private global::System.Windows.Forms.Label label25;

		// Token: 0x0400009F RID: 159
		private global::System.Windows.Forms.Label label26;

		// Token: 0x040000A0 RID: 160
		private global::System.Windows.Forms.Label label27;

		// Token: 0x040000A1 RID: 161
		private global::System.Windows.Forms.TabPage Hapis;

		// Token: 0x040000A2 RID: 162
		private global::System.Windows.Forms.TextBox HAidentitytext;

		// Token: 0x040000A3 RID: 163
		private global::System.Windows.Forms.Label label7;

		// Token: 0x040000A5 RID: 165
		private global::System.Windows.Forms.Button button3;

		// Token: 0x040000A6 RID: 166
		private global::System.Windows.Forms.TextBox HPmaxplayertext;

		// Token: 0x040000A7 RID: 167
		private global::System.Windows.Forms.TextBox HPserverdisctext;

		// Token: 0x040000A8 RID: 168
		private global::System.Windows.Forms.TextBox HPserverurltext;

		// Token: 0x040000A9 RID: 169
		private global::System.Windows.Forms.TextBox HPserverpicturetext;

		// Token: 0x040000AA RID: 170
		private global::System.Windows.Forms.TextBox HPrconpasstext;

		// Token: 0x040000AB RID: 171
		private global::System.Windows.Forms.TextBox HPrconporttext;

		// Token: 0x040000AC RID: 172
		private global::System.Windows.Forms.TextBox HPserverportext;

		// Token: 0x040000AD RID: 173
		private global::System.Windows.Forms.TextBox HPservernametext;

		// Token: 0x040000AE RID: 174
		private global::System.Windows.Forms.Label label45;

		// Token: 0x040000AF RID: 175
		private global::System.Windows.Forms.Label label46;

		// Token: 0x040000B0 RID: 176
		private global::System.Windows.Forms.Label label49;

		// Token: 0x040000B1 RID: 177
		private global::System.Windows.Forms.Label label50;

		// Token: 0x040000B2 RID: 178
		private global::System.Windows.Forms.Label label51;

		// Token: 0x040000B3 RID: 179
		private global::System.Windows.Forms.Label label52;

		// Token: 0x040000B4 RID: 180
		private global::System.Windows.Forms.Label label53;

		// Token: 0x040000B5 RID: 181
		private global::System.Windows.Forms.Label label54;

		// Token: 0x040000B6 RID: 182
		private global::System.Windows.Forms.Label label56;

		// Token: 0x040000B7 RID: 183
		private global::System.Windows.Forms.TabPage BARREN;

		// Token: 0x040000B8 RID: 184
		private global::System.Windows.Forms.TextBox BAidentitytext;

		// Token: 0x040000B9 RID: 185
		private global::System.Windows.Forms.Label label15;

		// Token: 0x040000BA RID: 186
		private global::System.Windows.Forms.TextBox BAmapseedtext;

		// Token: 0x040000BB RID: 187
		private global::System.Windows.Forms.TextBox BAmapsizebox;

		// Token: 0x040000BC RID: 188
		private global::System.Windows.Forms.TextBox BAmaxplayertext;

		// Token: 0x040000BD RID: 189
		private global::System.Windows.Forms.TextBox BAserverdisctext;

		// Token: 0x040000BE RID: 190
		private global::System.Windows.Forms.TextBox BAserverurltext;

		// Token: 0x040000BF RID: 191
		private global::System.Windows.Forms.TextBox BAserverpicturetext;

		// Token: 0x040000C0 RID: 192
		private global::System.Windows.Forms.TextBox BArconpasstext;

		// Token: 0x040000C1 RID: 193
		private global::System.Windows.Forms.TextBox BArconporttext;

		// Token: 0x040000C2 RID: 194
		private global::System.Windows.Forms.TextBox BAserverportext;

		// Token: 0x040000C3 RID: 195
		private global::System.Windows.Forms.TextBox BAservernametext;

		// Token: 0x040000C4 RID: 196
		private global::System.Windows.Forms.Label label44;

		// Token: 0x040000C5 RID: 197
		private global::System.Windows.Forms.Label label55;

		// Token: 0x040000C6 RID: 198
		private global::System.Windows.Forms.Label label58;

		// Token: 0x040000C7 RID: 199
		private global::System.Windows.Forms.Label label59;

		// Token: 0x040000C8 RID: 200
		private global::System.Windows.Forms.Label label60;

		// Token: 0x040000C9 RID: 201
		private global::System.Windows.Forms.Label label61;

		// Token: 0x040000CA RID: 202
		private global::System.Windows.Forms.Label label62;

		// Token: 0x040000CB RID: 203
		private global::System.Windows.Forms.Label label63;

		// Token: 0x040000CC RID: 204
		private global::System.Windows.Forms.Label label64;

		// Token: 0x040000CD RID: 205
		private global::System.Windows.Forms.Label label65;

		// Token: 0x040000CE RID: 206
		private global::System.Windows.Forms.Label label67;

		// Token: 0x040000D0 RID: 208
		private global::System.Windows.Forms.Button button4;

		// Token: 0x040000D1 RID: 209
		private global::System.Windows.Forms.TabPage CRAGGY;

		// Token: 0x040000D2 RID: 210
		private global::System.Windows.Forms.TextBox CRidentitytext;

		// Token: 0x040000D3 RID: 211
		private global::System.Windows.Forms.Label label36;

		// Token: 0x040000D5 RID: 213
		private global::System.Windows.Forms.Button button5;

		// Token: 0x040000D6 RID: 214
		private global::System.Windows.Forms.TextBox CRmaxplayertext;

		// Token: 0x040000D7 RID: 215
		private global::System.Windows.Forms.TextBox CRserverdisctext;

		// Token: 0x040000D8 RID: 216
		private global::System.Windows.Forms.TextBox CRserverurltext;

		// Token: 0x040000D9 RID: 217
		private global::System.Windows.Forms.TextBox CRserverpicturetext;

		// Token: 0x040000DA RID: 218
		private global::System.Windows.Forms.TextBox CRrconpasstext;

		// Token: 0x040000DB RID: 219
		private global::System.Windows.Forms.TextBox CRrconporttext;

		// Token: 0x040000DC RID: 220
		private global::System.Windows.Forms.TextBox CRserverportext;

		// Token: 0x040000DD RID: 221
		private global::System.Windows.Forms.TextBox CRservernametext;

		// Token: 0x040000DE RID: 222
		private global::System.Windows.Forms.Label label69;

		// Token: 0x040000DF RID: 223
		private global::System.Windows.Forms.Label label70;

		// Token: 0x040000E0 RID: 224
		private global::System.Windows.Forms.Label label71;

		// Token: 0x040000E1 RID: 225
		private global::System.Windows.Forms.Label label72;

		// Token: 0x040000E2 RID: 226
		private global::System.Windows.Forms.Label label73;

		// Token: 0x040000E3 RID: 227
		private global::System.Windows.Forms.Label label74;

		// Token: 0x040000E4 RID: 228
		private global::System.Windows.Forms.Label label75;

		// Token: 0x040000E5 RID: 229
		private global::System.Windows.Forms.Label label76;

		// Token: 0x040000E6 RID: 230
		private global::System.Windows.Forms.Label label77;

		// Token: 0x040000E7 RID: 231
		private global::System.Windows.Forms.TabPage SAVAS;

		// Token: 0x040000E8 RID: 232
		private global::System.Windows.Forms.TextBox SAidentitytext;

		// Token: 0x040000E9 RID: 233
		private global::System.Windows.Forms.Label label39;

		// Token: 0x040000EB RID: 235
		private global::System.Windows.Forms.Button button7;

		// Token: 0x040000EC RID: 236
		private global::System.Windows.Forms.TextBox SAmaxplayertext;

		// Token: 0x040000ED RID: 237
		private global::System.Windows.Forms.TextBox SAserverdisctext;

		// Token: 0x040000EE RID: 238
		private global::System.Windows.Forms.TextBox SAserverurltext;

		// Token: 0x040000EF RID: 239
		private global::System.Windows.Forms.TextBox SAserverpicturetext;

		// Token: 0x040000F0 RID: 240
		private global::System.Windows.Forms.TextBox SArconpasstext;

		// Token: 0x040000F1 RID: 241
		private global::System.Windows.Forms.TextBox SArconporttext;

		// Token: 0x040000F2 RID: 242
		private global::System.Windows.Forms.TextBox SAserverportext;

		// Token: 0x040000F3 RID: 243
		private global::System.Windows.Forms.TextBox SAservernametext;

		// Token: 0x040000F4 RID: 244
		private global::System.Windows.Forms.Label label84;

		// Token: 0x040000F5 RID: 245
		private global::System.Windows.Forms.Label label85;

		// Token: 0x040000F6 RID: 246
		private global::System.Windows.Forms.Label label86;

		// Token: 0x040000F7 RID: 247
		private global::System.Windows.Forms.Label label87;

		// Token: 0x040000F8 RID: 248
		private global::System.Windows.Forms.Label label88;

		// Token: 0x040000F9 RID: 249
		private global::System.Windows.Forms.Label label89;

		// Token: 0x040000FA RID: 250
		private global::System.Windows.Forms.Label label90;

		// Token: 0x040000FB RID: 251
		private global::System.Windows.Forms.Label label91;

		// Token: 0x040000FC RID: 252
		private global::System.Windows.Forms.Label label92;

		// Token: 0x040000FD RID: 253
		private global::System.Windows.Forms.TabPage KOTH;

		// Token: 0x040000FE RID: 254
		private global::System.Windows.Forms.TextBox KOidentitytext;

		// Token: 0x040000FF RID: 255
		private global::System.Windows.Forms.Label label40;

		// Token: 0x04000101 RID: 257
		private global::System.Windows.Forms.Button button8;

		// Token: 0x04000102 RID: 258
		private global::System.Windows.Forms.TextBox KOmaxplayertext;

		// Token: 0x04000103 RID: 259
		private global::System.Windows.Forms.TextBox KOserverdisctext;

		// Token: 0x04000104 RID: 260
		private global::System.Windows.Forms.TextBox KOserverurltext;

		// Token: 0x04000105 RID: 261
		private global::System.Windows.Forms.TextBox KOserverpicturetext;

		// Token: 0x04000106 RID: 262
		private global::System.Windows.Forms.TextBox KOrconpasstext;

		// Token: 0x04000107 RID: 263
		private global::System.Windows.Forms.TextBox KOrconporttext;

		// Token: 0x04000108 RID: 264
		private global::System.Windows.Forms.TextBox KOserverportext;

		// Token: 0x04000109 RID: 265
		private global::System.Windows.Forms.TextBox KOservernametext;

		// Token: 0x0400010A RID: 266
		private global::System.Windows.Forms.Label label95;

		// Token: 0x0400010B RID: 267
		private global::System.Windows.Forms.Label label96;

		// Token: 0x0400010C RID: 268
		private global::System.Windows.Forms.Label label97;

		// Token: 0x0400010D RID: 269
		private global::System.Windows.Forms.Label label98;

		// Token: 0x0400010E RID: 270
		private global::System.Windows.Forms.Label label99;

		// Token: 0x0400010F RID: 271
		private global::System.Windows.Forms.Label label100;

		// Token: 0x04000110 RID: 272
		private global::System.Windows.Forms.Label label101;

		// Token: 0x04000111 RID: 273
		private global::System.Windows.Forms.Label label102;

		// Token: 0x04000112 RID: 274
		private global::System.Windows.Forms.Label label103;

		// Token: 0x04000113 RID: 275
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000114 RID: 276
		private global::System.Windows.Forms.Label label14;

		// Token: 0x04000115 RID: 277
		private global::System.Windows.Forms.TextBox LogLocation;

		// Token: 0x04000116 RID: 278
		private global::System.Windows.Forms.TextBox dedicateddirectory;

		// Token: 0x04000117 RID: 279
		private global::System.Windows.Forms.TextBox servfilesdirectory;

		// Token: 0x04000118 RID: 280
		private global::System.Windows.Forms.TextBox cmdbatdir;

		// Token: 0x04000119 RID: 281
		private global::System.Windows.Forms.TextBox CMDDirectorybox;

		// Token: 0x0400011A RID: 282
		private global::System.Windows.Forms.TextBox serverdirectorytext;

		// Token: 0x0400011B RID: 283
		private global::System.Windows.Forms.Label label34;

		// Token: 0x0400011C RID: 284
		private global::System.Windows.Forms.Label label33;

		// Token: 0x0400011D RID: 285
		private global::System.Windows.Forms.TabControl tabControl1;

		// Token: 0x0400011E RID: 286
		private global::System.Windows.Forms.Button button10;

		// Token: 0x0400011F RID: 287
		private global::System.Windows.Forms.ToolStripMenuItem guidesToolStripMenuItem;

		// Token: 0x04000120 RID: 288
		private global::System.Windows.Forms.ToolStripMenuItem rustLabsToolStripMenuItem;

		// Token: 0x04000121 RID: 289
		private global::System.Windows.Forms.ToolStripMenuItem howToolStripMenuItem;

		// Token: 0x04000122 RID: 290
		private global::System.Windows.Forms.ToolStripMenuItem httpswwwrustafiedcomhowtohostarustserverinlinuxToolStripMenuItem;

		// Token: 0x04000123 RID: 291
		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem22;

		// Token: 0x04000124 RID: 292
		private global::System.Windows.Forms.ToolStripMenuItem hostARUSTDedicatedServerToolStripMenuItem;

		// Token: 0x04000125 RID: 293
		private global::System.Windows.Forms.ToolStripMenuItem populateYourRUSTServerWithThese6TipsToolStripMenuItem;

		// Token: 0x04000126 RID: 294
		private global::System.Windows.Forms.ToolStripMenuItem howToCreateAPrivateRUSTServerToolStripMenuItem;

		// Token: 0x04000127 RID: 295
		private global::System.Windows.Forms.ToolStripMenuItem howToInstallUModOxideToARUSTServerToolStripMenuItem;

		// Token: 0x04000128 RID: 296
		private global::System.Windows.Forms.ToolStripMenuItem rUSTServerPerformanceHintsAndTipsToolStripMenuItem;

		// Token: 0x04000132 RID: 306
		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem25;

		// Token: 0x04000133 RID: 307
		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem28;

		// Token: 0x04000134 RID: 308
		private global::System.Windows.Forms.ToolStripMenuItem mostBeginnerMistakesQuestionsToolStripMenuItem;

		// Token: 0x04000135 RID: 309
		private global::System.Windows.Forms.Panel panel9;

		// Token: 0x04000136 RID: 310
		private global::System.Windows.Forms.PictureBox PreviewPic;

		// Token: 0x04000137 RID: 311
		private global::System.Windows.Forms.PictureBox BannerServer;

		// Token: 0x04000138 RID: 312
		private global::System.Windows.Forms.Label serverTitle;

		// Token: 0x04000139 RID: 313
		private global::System.Windows.Forms.Label label42;

		// Token: 0x0400013A RID: 314
		private global::System.Windows.Forms.Label label38;

		// Token: 0x0400013B RID: 315
		private global::System.Windows.Forms.Label mapTypeprev;

		// Token: 0x0400013C RID: 316
		private global::System.Windows.Forms.Label MaxPlayersPrev;

		// Token: 0x0400013D RID: 317
		private global::System.Windows.Forms.Label FakeMS;

		// Token: 0x0400013F RID: 319
		private global::System.Windows.Forms.Label label43;

		// Token: 0x04000140 RID: 320
		private global::System.Windows.Forms.PictureBox mapPic;

		// Token: 0x04000141 RID: 321
		private global::System.Windows.Forms.Panel panel12;

		// Token: 0x04000142 RID: 322
		private global::System.Windows.Forms.Label label68;

		// Token: 0x04000143 RID: 323
		private global::System.Windows.Forms.Button BtnStart;

		// Token: 0x04000144 RID: 324
		private global::System.Windows.Forms.ComboBox StartFileList;

		// Token: 0x04000145 RID: 325
		private global::System.Windows.Forms.Panel panel13;

		// Token: 0x04000146 RID: 326
		private global::System.Windows.Forms.Button button11;

		// Token: 0x04000147 RID: 327
		private global::System.Windows.Forms.Button BtnRefreshbrowser;

		// Token: 0x04000148 RID: 328
		private global::System.Windows.Forms.Button BtnViewPage;

		// Token: 0x04000149 RID: 329
		private global::System.Windows.Forms.Label PreviewDesc;

		// Token: 0x0400014A RID: 330
		private global::System.Windows.Forms.Label label83;

		// Token: 0x0400014B RID: 331
		private global::System.Windows.Forms.Label mapinfolab;

		// Token: 0x0400014C RID: 332
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x0400014D RID: 333
		private global::System.Windows.Forms.RadioButton RdioStaging;

		// Token: 0x0400014E RID: 334
		private global::System.Windows.Forms.RadioButton RdioNormal;

		// Token: 0x0400014F RID: 335
		private global::System.Windows.Forms.TextBox cmdbatdirstaging;

		// Token: 0x04000150 RID: 336
		private global::System.Windows.Forms.Button RefreshSmall;

		// Token: 0x04000151 RID: 337
		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem29;

		// Token: 0x04000152 RID: 338
		private global::System.Windows.Forms.ToolStripMenuItem installUmodToolStripMenuItem;

		// Token: 0x04000153 RID: 339
		private global::System.Windows.Forms.ToolStripMenuItem downloadInstallToolStripMenuItem;

		// Token: 0x0400015C RID: 348
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem20;

		// Token: 0x0400015D RID: 349
		private global::System.Windows.Forms.TextBox ServerVarsFinal;

		// Token: 0x0400015E RID: 350
		private global::System.Windows.Forms.ToolStripMenuItem startFileToolStripMenuItem;

		// Token: 0x0400015F RID: 351
		private global::System.Windows.Forms.ToolStripMenuItem updateFIleToolStripMenuItem;

		// Token: 0x04000160 RID: 352
		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem10;

		// Token: 0x04000161 RID: 353
		private global::System.Windows.Forms.ToolStripMenuItem serverFolderToolStripMenuItem;

		// Token: 0x04000162 RID: 354
		private global::System.Windows.Forms.ToolStripMenuItem steamCMDToolStripMenuItem1;

		// Token: 0x04000163 RID: 355
		private global::System.Windows.Forms.ToolStripMenuItem serverOptionsToolStripMenuItem;

		// Token: 0x04000164 RID: 356
		private global::System.Windows.Forms.ToolStripMenuItem updateServerToolStripMenuItem;

		// Token: 0x04000165 RID: 357
		private global::System.Windows.Forms.DataGridView ServerVars;

		// Token: 0x04000166 RID: 358
		private global::System.Windows.Forms.Button BtnCLLearVars;

		// Token: 0x04000167 RID: 359
		private global::System.Windows.Forms.Button button12;

		// Token: 0x04000168 RID: 360
		private global::System.Windows.Forms.Button BtnCompleteVars;

		// Token: 0x04000169 RID: 361
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x0400016A RID: 362
		private global::System.Windows.Forms.Panel panel6;

		// Token: 0x0400016B RID: 363
		private global::System.Windows.Forms.Button BTNadd;

		// Token: 0x0400016C RID: 364
		private global::System.Windows.Forms.Button btnclear;

		// Token: 0x0400016D RID: 365
		private global::System.Windows.Forms.TextBox varvalue;

		// Token: 0x0400016E RID: 366
		private global::System.Windows.Forms.TextBox varvar;

		// Token: 0x0400016F RID: 367
		private global::System.Windows.Forms.Label label30;

		// Token: 0x04000170 RID: 368
		private global::System.Windows.Forms.Label label28;

		// Token: 0x04000171 RID: 369
		private global::System.Windows.Forms.Label label17;

		// Token: 0x04000172 RID: 370
		private global::System.Windows.Forms.Panel panel7;

		// Token: 0x04000173 RID: 371
		private global::System.Windows.Forms.Button button6;

		// Token: 0x04000174 RID: 372
		private global::System.Windows.Forms.Label label48;

		// Token: 0x04000175 RID: 373
		private global::System.Windows.Forms.TextBox SearchVar;

		// Token: 0x04000176 RID: 374
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Variable;

		// Token: 0x04000177 RID: 375
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Value;

		// Token: 0x04000178 RID: 376
		private global::System.Windows.Forms.Label LockedLbl;

		// Token: 0x04000179 RID: 377
		private global::System.Windows.Forms.Label LockedLbl2;

		// Token: 0x0400017A RID: 378
		private global::System.Windows.Forms.TextBox hasspace;

		// Token: 0x0400017B RID: 379
		private global::System.Windows.Forms.ToolStripMenuItem serverFilesFolderToolStripMenuItem;

		// Token: 0x0400017C RID: 380
		private global::System.Windows.Forms.TextBox CheckDll;
    }
}