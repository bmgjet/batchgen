﻿namespace batchgen
{
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

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
            this.writtenGuidesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToHostYourOwnRustDedicatedServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToHostARustServerInLinuxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripSeparator();
            this.hostARustDedicatedServerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.populateYourRustServerWithThese6TipsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.howToCreateAPrivateRustServerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.howToInstallUmodOxideToAServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rustServerPerformanceTipsAndTricksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rustAdminRconControlPlayerManagmentServerStatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rustEditCreateAndEditMapsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fortifyCreateAndDesignBasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripSeparator();
            this.browseMapsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripSeparator();
            this.resetSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setRconIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.wipeMapOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.wipeServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.fILELOCATIONSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.serverFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSSRFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.steamCMDFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pluginsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripSeparator();
            this.downloadOxideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripSeparator();
            this.browseFreePluginsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem29 = new System.Windows.Forms.ToolStripSeparator();
            this.installUmodToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
            this.pluginManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.label66 = new System.Windows.Forms.Label();
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
            this.BARREN = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
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
            this.custom = new System.Windows.Forms.TabPage();
            this.button15 = new System.Windows.Forms.Button();
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button18 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.label37 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.button17 = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.serverup = new System.Windows.Forms.Timer(this.components);
            this.betaParamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.BARREN.SuspendLayout();
            this.custom.SuspendLayout();
            this.Hapis.SuspendLayout();
            this.CRAGGY.SuspendLayout();
            this.SAVAS.SuspendLayout();
            this.KOTH.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.delay.Interval = 2000;
            this.delay.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.serverOptionsToolStripMenuItem,
            this.pluginsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1680, 42);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.videoTutorialsToolStripMenuItem,
            this.writtenGuidesToolStripMenuItem,
            this.programsToolStripMenuItem1,
            this.toolStripMenuItem13,
            this.browseMapsToolStripMenuItem,
            this.toolStripMenuItem14,
            this.resetSettingsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(85, 36);
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
            this.videoTutorialsToolStripMenuItem.Size = new System.Drawing.Size(309, 44);
            this.videoTutorialsToolStripMenuItem.Text = "Video Tutorials";
            // 
            // fullHostingTutorialsPlaylistToolStripMenuItem
            // 
            this.fullHostingTutorialsPlaylistToolStripMenuItem.Name = "fullHostingTutorialsPlaylistToolStripMenuItem";
            this.fullHostingTutorialsPlaylistToolStripMenuItem.Size = new System.Drawing.Size(658, 44);
            this.fullHostingTutorialsPlaylistToolStripMenuItem.Text = "Full Hosting Tutorials Playlist";
            this.fullHostingTutorialsPlaylistToolStripMenuItem.Click += new System.EventHandler(this.fullHostingTutorialsPlaylistToolStripMenuItem_Click);
            // 
            // toolStripMenuItem25
            // 
            this.toolStripMenuItem25.Name = "toolStripMenuItem25";
            this.toolStripMenuItem25.Size = new System.Drawing.Size(655, 6);
            // 
            // howToHostYourOwnRustServerManuallyToolStripMenuItem
            // 
            this.howToHostYourOwnRustServerManuallyToolStripMenuItem.Name = "howToHostYourOwnRustServerManuallyToolStripMenuItem";
            this.howToHostYourOwnRustServerManuallyToolStripMenuItem.Size = new System.Drawing.Size(658, 44);
            this.howToHostYourOwnRustServerManuallyToolStripMenuItem.Text = "#1 How To Host your own Rust Server Manually";
            this.howToHostYourOwnRustServerManuallyToolStripMenuItem.Click += new System.EventHandler(this.howToHostYourOwnRustServerManuallyToolStripMenuItem_Click);
            // 
            // howToInstallOxideWorkWithPluginsToolStripMenuItem
            // 
            this.howToInstallOxideWorkWithPluginsToolStripMenuItem.Name = "howToInstallOxideWorkWithPluginsToolStripMenuItem";
            this.howToInstallOxideWorkWithPluginsToolStripMenuItem.Size = new System.Drawing.Size(658, 44);
            this.howToInstallOxideWorkWithPluginsToolStripMenuItem.Text = "#2 How To Install Oxide And Work With Plugins";
            this.howToInstallOxideWorkWithPluginsToolStripMenuItem.Click += new System.EventHandler(this.howToInstallOxideWorkWithPluginsToolStripMenuItem_Click);
            // 
            // howToPortForwardToolStripMenuItem
            // 
            this.howToPortForwardToolStripMenuItem.Name = "howToPortForwardToolStripMenuItem";
            this.howToPortForwardToolStripMenuItem.Size = new System.Drawing.Size(658, 44);
            this.howToPortForwardToolStripMenuItem.Text = "#3 How To Port Forward - Make it Public";
            this.howToPortForwardToolStripMenuItem.Click += new System.EventHandler(this.howToPortForwardToolStripMenuItem_Click);
            // 
            // toolStripMenuItem28
            // 
            this.toolStripMenuItem28.Name = "toolStripMenuItem28";
            this.toolStripMenuItem28.Size = new System.Drawing.Size(655, 6);
            // 
            // mostBeginnerMistakesQuestionsToolStripMenuItem
            // 
            this.mostBeginnerMistakesQuestionsToolStripMenuItem.Name = "mostBeginnerMistakesQuestionsToolStripMenuItem";
            this.mostBeginnerMistakesQuestionsToolStripMenuItem.Size = new System.Drawing.Size(658, 44);
            this.mostBeginnerMistakesQuestionsToolStripMenuItem.Text = "15 Most Mistakes / Questions";
            this.mostBeginnerMistakesQuestionsToolStripMenuItem.Click += new System.EventHandler(this.mostBeginnerMistakesQuestionsToolStripMenuItem_Click);
            // 
            // writtenGuidesToolStripMenuItem
            // 
            this.writtenGuidesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToHostYourOwnRustDedicatedServerToolStripMenuItem,
            this.howToHostARustServerInLinuxToolStripMenuItem,
            this.toolStripMenuItem15,
            this.hostARustDedicatedServerToolStripMenuItem1,
            this.populateYourRustServerWithThese6TipsToolStripMenuItem1,
            this.howToCreateAPrivateRustServerToolStripMenuItem1,
            this.howToInstallUmodOxideToAServerToolStripMenuItem,
            this.rustServerPerformanceTipsAndTricksToolStripMenuItem});
            this.writtenGuidesToolStripMenuItem.Name = "writtenGuidesToolStripMenuItem";
            this.writtenGuidesToolStripMenuItem.Size = new System.Drawing.Size(309, 44);
            this.writtenGuidesToolStripMenuItem.Text = "Written Guides";
            // 
            // howToHostYourOwnRustDedicatedServerToolStripMenuItem
            // 
            this.howToHostYourOwnRustDedicatedServerToolStripMenuItem.Name = "howToHostYourOwnRustDedicatedServerToolStripMenuItem";
            this.howToHostYourOwnRustDedicatedServerToolStripMenuItem.Size = new System.Drawing.Size(636, 44);
            this.howToHostYourOwnRustDedicatedServerToolStripMenuItem.Text = "How to: Host your own Rust Dedicated Server";
            this.howToHostYourOwnRustDedicatedServerToolStripMenuItem.Click += new System.EventHandler(this.howToolStripMenuItem_Click);
            // 
            // howToHostARustServerInLinuxToolStripMenuItem
            // 
            this.howToHostARustServerInLinuxToolStripMenuItem.Name = "howToHostARustServerInLinuxToolStripMenuItem";
            this.howToHostARustServerInLinuxToolStripMenuItem.Size = new System.Drawing.Size(636, 44);
            this.howToHostARustServerInLinuxToolStripMenuItem.Text = "How to host a Rust Server in Linux";
            this.howToHostARustServerInLinuxToolStripMenuItem.Click += new System.EventHandler(this.httpswwwrustafiedcomhowtohostarustserverinlinuxToolStripMenuItem_Click);
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(633, 6);
            // 
            // hostARustDedicatedServerToolStripMenuItem1
            // 
            this.hostARustDedicatedServerToolStripMenuItem1.Name = "hostARustDedicatedServerToolStripMenuItem1";
            this.hostARustDedicatedServerToolStripMenuItem1.Size = new System.Drawing.Size(636, 44);
            this.hostARustDedicatedServerToolStripMenuItem1.Text = "Host A Rust Dedicated Server";
            this.hostARustDedicatedServerToolStripMenuItem1.Click += new System.EventHandler(this.hostARUSTDedicatedServerToolStripMenuItem_Click);
            // 
            // populateYourRustServerWithThese6TipsToolStripMenuItem1
            // 
            this.populateYourRustServerWithThese6TipsToolStripMenuItem1.Name = "populateYourRustServerWithThese6TipsToolStripMenuItem1";
            this.populateYourRustServerWithThese6TipsToolStripMenuItem1.Size = new System.Drawing.Size(636, 44);
            this.populateYourRustServerWithThese6TipsToolStripMenuItem1.Text = "Populate Your Rust Server with these 6 tips";
            this.populateYourRustServerWithThese6TipsToolStripMenuItem1.Click += new System.EventHandler(this.populateYourRUSTServerWithThese6TipsToolStripMenuItem_Click);
            // 
            // howToCreateAPrivateRustServerToolStripMenuItem1
            // 
            this.howToCreateAPrivateRustServerToolStripMenuItem1.Name = "howToCreateAPrivateRustServerToolStripMenuItem1";
            this.howToCreateAPrivateRustServerToolStripMenuItem1.Size = new System.Drawing.Size(636, 44);
            this.howToCreateAPrivateRustServerToolStripMenuItem1.Text = "How to create a private Rust server";
            this.howToCreateAPrivateRustServerToolStripMenuItem1.Click += new System.EventHandler(this.howToCreateAPrivateRUSTServerToolStripMenuItem_Click);
            // 
            // howToInstallUmodOxideToAServerToolStripMenuItem
            // 
            this.howToInstallUmodOxideToAServerToolStripMenuItem.Name = "howToInstallUmodOxideToAServerToolStripMenuItem";
            this.howToInstallUmodOxideToAServerToolStripMenuItem.Size = new System.Drawing.Size(636, 44);
            this.howToInstallUmodOxideToAServerToolStripMenuItem.Text = "How to install Umod (Oxide) to a server";
            this.howToInstallUmodOxideToAServerToolStripMenuItem.Click += new System.EventHandler(this.howToInstallUModOxideToARUSTServerToolStripMenuItem_Click);
            // 
            // rustServerPerformanceTipsAndTricksToolStripMenuItem
            // 
            this.rustServerPerformanceTipsAndTricksToolStripMenuItem.Name = "rustServerPerformanceTipsAndTricksToolStripMenuItem";
            this.rustServerPerformanceTipsAndTricksToolStripMenuItem.Size = new System.Drawing.Size(636, 44);
            this.rustServerPerformanceTipsAndTricksToolStripMenuItem.Text = "Rust Server performance, tips and tricks";
            this.rustServerPerformanceTipsAndTricksToolStripMenuItem.Click += new System.EventHandler(this.rUSTServerPerformanceHintsAndTipsToolStripMenuItem_Click);
            // 
            // programsToolStripMenuItem1
            // 
            this.programsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rustAdminRconControlPlayerManagmentServerStatsToolStripMenuItem,
            this.rustEditCreateAndEditMapsToolStripMenuItem,
            this.fortifyCreateAndDesignBasesToolStripMenuItem});
            this.programsToolStripMenuItem1.Name = "programsToolStripMenuItem1";
            this.programsToolStripMenuItem1.Size = new System.Drawing.Size(309, 44);
            this.programsToolStripMenuItem1.Text = "Programs";
            // 
            // rustAdminRconControlPlayerManagmentServerStatsToolStripMenuItem
            // 
            this.rustAdminRconControlPlayerManagmentServerStatsToolStripMenuItem.Name = "rustAdminRconControlPlayerManagmentServerStatsToolStripMenuItem";
            this.rustAdminRconControlPlayerManagmentServerStatsToolStripMenuItem.Size = new System.Drawing.Size(787, 44);
            this.rustAdminRconControlPlayerManagmentServerStatsToolStripMenuItem.Text = "Rust admin - Rcon control | player managment | server stats";
            this.rustAdminRconControlPlayerManagmentServerStatsToolStripMenuItem.Click += new System.EventHandler(this.rustAdminToolStripMenuItem_Click);
            // 
            // rustEditCreateAndEditMapsToolStripMenuItem
            // 
            this.rustEditCreateAndEditMapsToolStripMenuItem.Name = "rustEditCreateAndEditMapsToolStripMenuItem";
            this.rustEditCreateAndEditMapsToolStripMenuItem.Size = new System.Drawing.Size(787, 44);
            this.rustEditCreateAndEditMapsToolStripMenuItem.Text = "Rust edit - Create and edit maps";
            this.rustEditCreateAndEditMapsToolStripMenuItem.Click += new System.EventHandler(this.rustEditToolStripMenuItem_Click);
            // 
            // fortifyCreateAndDesignBasesToolStripMenuItem
            // 
            this.fortifyCreateAndDesignBasesToolStripMenuItem.Name = "fortifyCreateAndDesignBasesToolStripMenuItem";
            this.fortifyCreateAndDesignBasesToolStripMenuItem.Size = new System.Drawing.Size(787, 44);
            this.fortifyCreateAndDesignBasesToolStripMenuItem.Text = "Fortify - Create and design bases";
            this.fortifyCreateAndDesignBasesToolStripMenuItem.Click += new System.EventHandler(this.fortifyCreateAndDesignBaseCanBeCopiedFromOrPastedIntoRustToolStripMenuItem_Click);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(306, 6);
            // 
            // browseMapsToolStripMenuItem
            // 
            this.browseMapsToolStripMenuItem.Name = "browseMapsToolStripMenuItem";
            this.browseMapsToolStripMenuItem.Size = new System.Drawing.Size(309, 44);
            this.browseMapsToolStripMenuItem.Text = "Browse Maps";
            this.browseMapsToolStripMenuItem.Click += new System.EventHandler(this.chooseAMapToolStripMenuItem_Click);
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(306, 6);
            // 
            // resetSettingsToolStripMenuItem
            // 
            this.resetSettingsToolStripMenuItem.Name = "resetSettingsToolStripMenuItem";
            this.resetSettingsToolStripMenuItem.Size = new System.Drawing.Size(309, 44);
            this.resetSettingsToolStripMenuItem.Text = "Reset Settings";
            this.resetSettingsToolStripMenuItem.Click += new System.EventHandler(this.resetSettingsToolStripMenuItem_Click);
            // 
            // serverOptionsToolStripMenuItem
            // 
            this.serverOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAdminToolStripMenuItem,
            this.setRconIPToolStripMenuItem,
            this.betaParamsToolStripMenuItem,
            this.updateServerToolStripMenuItem,
            this.toolStripMenuItem1,
            this.wipeMapOnlyToolStripMenuItem,
            this.toolStripMenuItem6,
            this.wipeServerToolStripMenuItem,
            this.toolStripMenuItem7,
            this.fILELOCATIONSToolStripMenuItem});
            this.serverOptionsToolStripMenuItem.Name = "serverOptionsToolStripMenuItem";
            this.serverOptionsToolStripMenuItem.Size = new System.Drawing.Size(193, 38);
            this.serverOptionsToolStripMenuItem.Text = "Server Options";
            // 
            // addAdminToolStripMenuItem
            // 
            this.addAdminToolStripMenuItem.Name = "addAdminToolStripMenuItem";
            this.addAdminToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.addAdminToolStripMenuItem.Text = "Add Admin";
            this.addAdminToolStripMenuItem.Click += new System.EventHandler(this.addAdminToolStripMenuItem_Click);
            // 
            // setRconIPToolStripMenuItem
            // 
            this.setRconIPToolStripMenuItem.Name = "setRconIPToolStripMenuItem";
            this.setRconIPToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.setRconIPToolStripMenuItem.Text = "Set Rcon IP";
            this.setRconIPToolStripMenuItem.Click += new System.EventHandler(this.setRconIPToolStripMenuItem_Click);
            // 
            // updateServerToolStripMenuItem
            // 
            this.updateServerToolStripMenuItem.Name = "updateServerToolStripMenuItem";
            this.updateServerToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.updateServerToolStripMenuItem.Text = "Update Server";
            this.updateServerToolStripMenuItem.Click += new System.EventHandler(this.UpdateServerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(356, 6);
            // 
            // wipeMapOnlyToolStripMenuItem
            // 
            this.wipeMapOnlyToolStripMenuItem.Name = "wipeMapOnlyToolStripMenuItem";
            this.wipeMapOnlyToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.wipeMapOnlyToolStripMenuItem.Text = "Wipe Map Only";
            this.wipeMapOnlyToolStripMenuItem.Click += new System.EventHandler(this.wipeMapOnlyToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(356, 6);
            // 
            // wipeServerToolStripMenuItem
            // 
            this.wipeServerToolStripMenuItem.Name = "wipeServerToolStripMenuItem";
            this.wipeServerToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.wipeServerToolStripMenuItem.Text = "Full Wipe Server";
            this.wipeServerToolStripMenuItem.Click += new System.EventHandler(this.wipeServerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(356, 6);
            // 
            // fILELOCATIONSToolStripMenuItem
            // 
            this.fILELOCATIONSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startFileToolStripMenuItem1,
            this.updateFileToolStripMenuItem1,
            this.toolStripMenuItem8,
            this.serverFilesToolStripMenuItem,
            this.uSSRFolderToolStripMenuItem,
            this.toolStripMenuItem9,
            this.steamCMDFolderToolStripMenuItem});
            this.fILELOCATIONSToolStripMenuItem.Name = "fILELOCATIONSToolStripMenuItem";
            this.fILELOCATIONSToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.fILELOCATIONSToolStripMenuItem.Text = "FILE LOCATIONS";
            // 
            // startFileToolStripMenuItem1
            // 
            this.startFileToolStripMenuItem1.Name = "startFileToolStripMenuItem1";
            this.startFileToolStripMenuItem1.Size = new System.Drawing.Size(350, 44);
            this.startFileToolStripMenuItem1.Text = "Start File";
            this.startFileToolStripMenuItem1.Click += new System.EventHandler(this.StartFileToolStripMenuItem_Click);
            // 
            // updateFileToolStripMenuItem1
            // 
            this.updateFileToolStripMenuItem1.Name = "updateFileToolStripMenuItem1";
            this.updateFileToolStripMenuItem1.Size = new System.Drawing.Size(350, 44);
            this.updateFileToolStripMenuItem1.Text = "Update File";
            this.updateFileToolStripMenuItem1.Click += new System.EventHandler(this.UpdateFIleToolStripMenuItem_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(347, 6);
            // 
            // serverFilesToolStripMenuItem
            // 
            this.serverFilesToolStripMenuItem.Name = "serverFilesToolStripMenuItem";
            this.serverFilesToolStripMenuItem.Size = new System.Drawing.Size(350, 44);
            this.serverFilesToolStripMenuItem.Text = "Server Files";
            this.serverFilesToolStripMenuItem.Click += new System.EventHandler(this.ServerFilesFolderToolStripMenuItem_Click);
            // 
            // uSSRFolderToolStripMenuItem
            // 
            this.uSSRFolderToolStripMenuItem.Name = "uSSRFolderToolStripMenuItem";
            this.uSSRFolderToolStripMenuItem.Size = new System.Drawing.Size(350, 44);
            this.uSSRFolderToolStripMenuItem.Text = "USSR Folder";
            this.uSSRFolderToolStripMenuItem.Click += new System.EventHandler(this.ServerFolderToolStripMenuItem_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(347, 6);
            // 
            // steamCMDFolderToolStripMenuItem
            // 
            this.steamCMDFolderToolStripMenuItem.Name = "steamCMDFolderToolStripMenuItem";
            this.steamCMDFolderToolStripMenuItem.Size = new System.Drawing.Size(350, 44);
            this.steamCMDFolderToolStripMenuItem.Text = "Steam CMD Folder";
            this.steamCMDFolderToolStripMenuItem.Click += new System.EventHandler(this.SteamCMDToolStripMenuItem1_Click);
            // 
            // pluginsToolStripMenuItem
            // 
            this.pluginsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainSiteToolStripMenuItem,
            this.toolStripMenuItem11,
            this.downloadOxideToolStripMenuItem,
            this.toolStripMenuItem18,
            this.browseFreePluginsToolStripMenuItem,
            this.toolStripMenuItem29,
            this.installUmodToolStripMenuItem1,
            this.toolStripMenuItem10,
            this.pluginManagerToolStripMenuItem});
            this.pluginsToolStripMenuItem.Name = "pluginsToolStripMenuItem";
            this.pluginsToolStripMenuItem.Size = new System.Drawing.Size(112, 36);
            this.pluginsToolStripMenuItem.Text = "Plugins";
            // 
            // mainSiteToolStripMenuItem
            // 
            this.mainSiteToolStripMenuItem.Name = "mainSiteToolStripMenuItem";
            this.mainSiteToolStripMenuItem.Size = new System.Drawing.Size(384, 44);
            this.mainSiteToolStripMenuItem.Text = "Main Site";
            this.mainSiteToolStripMenuItem.Click += new System.EventHandler(this.mainSiteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(381, 6);
            // 
            // downloadOxideToolStripMenuItem
            // 
            this.downloadOxideToolStripMenuItem.Name = "downloadOxideToolStripMenuItem";
            this.downloadOxideToolStripMenuItem.Size = new System.Drawing.Size(384, 44);
            this.downloadOxideToolStripMenuItem.Text = "Oxide Download Page";
            this.downloadOxideToolStripMenuItem.Click += new System.EventHandler(this.downloadOxideToolStripMenuItem_Click);
            // 
            // toolStripMenuItem18
            // 
            this.toolStripMenuItem18.Name = "toolStripMenuItem18";
            this.toolStripMenuItem18.Size = new System.Drawing.Size(381, 6);
            // 
            // browseFreePluginsToolStripMenuItem
            // 
            this.browseFreePluginsToolStripMenuItem.Name = "browseFreePluginsToolStripMenuItem";
            this.browseFreePluginsToolStripMenuItem.Size = new System.Drawing.Size(384, 44);
            this.browseFreePluginsToolStripMenuItem.Text = "Browse Free Plugins";
            this.browseFreePluginsToolStripMenuItem.Click += new System.EventHandler(this.browseFreePluginsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem29
            // 
            this.toolStripMenuItem29.Name = "toolStripMenuItem29";
            this.toolStripMenuItem29.Size = new System.Drawing.Size(381, 6);
            // 
            // installUmodToolStripMenuItem1
            // 
            this.installUmodToolStripMenuItem1.Name = "installUmodToolStripMenuItem1";
            this.installUmodToolStripMenuItem1.Size = new System.Drawing.Size(384, 44);
            this.installUmodToolStripMenuItem1.Text = "Install Umod";
            this.installUmodToolStripMenuItem1.Click += new System.EventHandler(this.DownloadInstallToolStripMenuItem_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(381, 6);
            // 
            // pluginManagerToolStripMenuItem
            // 
            this.pluginManagerToolStripMenuItem.Name = "pluginManagerToolStripMenuItem";
            this.pluginManagerToolStripMenuItem.Size = new System.Drawing.Size(384, 44);
            this.pluginManagerToolStripMenuItem.Text = "Plugin Manager";
            this.pluginManagerToolStripMenuItem.Click += new System.EventHandler(this.pluginManagerToolStripMenuItem_Click);
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
            this.maintab.Location = new System.Drawing.Point(8, 39);
            this.maintab.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.maintab.Name = "maintab";
            this.maintab.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.maintab.Size = new System.Drawing.Size(3442, 1843);
            this.maintab.TabIndex = 0;
            this.maintab.Text = "Server Setup";
            // 
            // CheckDll
            // 
            this.CheckDll.Location = new System.Drawing.Point(3112, 423);
            this.CheckDll.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CheckDll.Name = "CheckDll";
            this.CheckDll.Size = new System.Drawing.Size(196, 32);
            this.CheckDll.TabIndex = 31;
            // 
            // hasspace
            // 
            this.hasspace.Location = new System.Drawing.Point(3034, 269);
            this.hasspace.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.hasspace.Name = "hasspace";
            this.hasspace.Size = new System.Drawing.Size(314, 32);
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
            this.panel6.Location = new System.Drawing.Point(954, 12);
            this.panel6.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(708, 758);
            this.panel6.TabIndex = 2;
            // 
            // LockedLbl2
            // 
            this.LockedLbl2.AutoSize = true;
            this.LockedLbl2.BackColor = System.Drawing.Color.Transparent;
            this.LockedLbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LockedLbl2.ForeColor = System.Drawing.Color.Red;
            this.LockedLbl2.Location = new System.Drawing.Point(28, 296);
            this.LockedLbl2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LockedLbl2.Name = "LockedLbl2";
            this.LockedLbl2.Size = new System.Drawing.Size(609, 48);
            this.LockedLbl2.TabIndex = 34;
            this.LockedLbl2.Text = "ADD OR CLEAR TO UNLOCK";
            // 
            // LockedLbl
            // 
            this.LockedLbl.AutoSize = true;
            this.LockedLbl.BackColor = System.Drawing.Color.Transparent;
            this.LockedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LockedLbl.ForeColor = System.Drawing.Color.Red;
            this.LockedLbl.Location = new System.Drawing.Point(186, 221);
            this.LockedLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LockedLbl.Name = "LockedLbl";
            this.LockedLbl.Size = new System.Drawing.Size(329, 79);
            this.LockedLbl.TabIndex = 34;
            this.LockedLbl.Text = "LOCKED";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.SearchVar);
            this.panel7.Controls.Add(this.button6);
            this.panel7.Controls.Add(this.label48);
            this.panel7.Location = new System.Drawing.Point(4, 619);
            this.panel7.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(690, 119);
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
            "zombie.population",
            "rcon.web"});
            this.SearchVar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SearchVar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SearchVar.Location = new System.Drawing.Point(4, 65);
            this.SearchVar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SearchVar.Name = "SearchVar";
            this.SearchVar.Size = new System.Drawing.Size(460, 32);
            this.SearchVar.TabIndex = 34;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(480, 63);
            this.button6.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 38);
            this.button6.TabIndex = 31;
            this.button6.Text = "SELECT";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click_1);
            // 
            // label48
            // 
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label48.Location = new System.Drawing.Point(2, 0);
            this.label48.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(688, 54);
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
            this.panel2.Location = new System.Drawing.Point(4, 410);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 194);
            this.panel2.TabIndex = 32;
            // 
            // BTNadd
            // 
            this.BTNadd.Location = new System.Drawing.Point(268, 140);
            this.BTNadd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BTNadd.Name = "BTNadd";
            this.BTNadd.Size = new System.Drawing.Size(200, 44);
            this.BTNadd.TabIndex = 2;
            this.BTNadd.Text = "ADD";
            this.BTNadd.UseVisualStyleBackColor = true;
            this.BTNadd.Click += new System.EventHandler(this.BTNadd_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(480, 140);
            this.btnclear.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(200, 44);
            this.btnclear.TabIndex = 2;
            this.btnclear.Text = "CLEAR";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.Btnclear_Click_1);
            // 
            // varvalue
            // 
            this.varvalue.Location = new System.Drawing.Point(480, 92);
            this.varvalue.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.varvalue.Name = "varvalue";
            this.varvalue.Size = new System.Drawing.Size(196, 32);
            this.varvalue.TabIndex = 1;
            // 
            // varvar
            // 
            this.varvar.Location = new System.Drawing.Point(2, 92);
            this.varvar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.varvar.Name = "varvar";
            this.varvar.Size = new System.Drawing.Size(462, 32);
            this.varvar.TabIndex = 1;
            // 
            // label30
            // 
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label30.Location = new System.Drawing.Point(480, 50);
            this.label30.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(200, 54);
            this.label30.TabIndex = 0;
            this.label30.Text = "VALUE";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label28.Location = new System.Drawing.Point(6, 50);
            this.label28.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(462, 54);
            this.label28.TabIndex = 0;
            this.label28.Text = "VARIABLE";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Location = new System.Drawing.Point(-2, -4);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(692, 54);
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
            this.ServerVars.Location = new System.Drawing.Point(-4, -4);
            this.ServerVars.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ServerVars.Name = "ServerVars";
            this.ServerVars.RowHeadersWidth = 92;
            this.ServerVars.Size = new System.Drawing.Size(714, 367);
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
            this.BtnCLLearVars.Location = new System.Drawing.Point(548, 363);
            this.BtnCLLearVars.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnCLLearVars.Name = "BtnCLLearVars";
            this.BtnCLLearVars.Size = new System.Drawing.Size(150, 44);
            this.BtnCLLearVars.TabIndex = 31;
            this.BtnCLLearVars.Text = "CLEAR";
            this.BtnCLLearVars.UseVisualStyleBackColor = true;
            this.BtnCLLearVars.Click += new System.EventHandler(this.BtnCLLearVars_Click);
            // 
            // BtnCompleteVars
            // 
            this.BtnCompleteVars.Location = new System.Drawing.Point(4, 363);
            this.BtnCompleteVars.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnCompleteVars.Name = "BtnCompleteVars";
            this.BtnCompleteVars.Size = new System.Drawing.Size(150, 44);
            this.BtnCompleteVars.TabIndex = 31;
            this.BtnCompleteVars.Text = "DONE";
            this.BtnCompleteVars.UseVisualStyleBackColor = true;
            this.BtnCompleteVars.Click += new System.EventHandler(this.BtnCompleteVars_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(276, 363);
            this.button12.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(150, 44);
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
            this.panel5.Location = new System.Drawing.Point(8, 12);
            this.panel5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(908, 177);
            this.panel5.TabIndex = 17;
            // 
            // infolabel
            // 
            this.infolabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.infolabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infolabel.ForeColor = System.Drawing.SystemColors.Window;
            this.infolabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.infolabel.Location = new System.Drawing.Point(-4, 75);
            this.infolabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.infolabel.Name = "infolabel";
            this.infolabel.Size = new System.Drawing.Size(912, 98);
            this.infolabel.TabIndex = 1;
            this.infolabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label47
            // 
            this.label47.BackColor = System.Drawing.Color.Transparent;
            this.label47.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.ForeColor = System.Drawing.SystemColors.Control;
            this.label47.Location = new System.Drawing.Point(-6, 6);
            this.label47.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(908, 62);
            this.label47.TabIndex = 0;
            this.label47.Text = "PROGRESS";
            this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServerVarsFinal
            // 
            this.ServerVarsFinal.Location = new System.Drawing.Point(928, 1635);
            this.ServerVarsFinal.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ServerVarsFinal.Multiline = true;
            this.ServerVarsFinal.Name = "ServerVarsFinal";
            this.ServerVarsFinal.Size = new System.Drawing.Size(1206, 144);
            this.ServerVarsFinal.TabIndex = 29;
            // 
            // panel12
            // 
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel12.Controls.Add(this.BtnStart);
            this.panel12.Controls.Add(this.StartFileList);
            this.panel12.Controls.Add(this.label68);
            this.panel12.Location = new System.Drawing.Point(14, 1244);
            this.panel12.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(902, 133);
            this.panel12.TabIndex = 28;
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(732, 67);
            this.BtnStart.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(140, 44);
            this.BtnStart.TabIndex = 3;
            this.BtnStart.Text = "START";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // StartFileList
            // 
            this.StartFileList.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RUSS.Properties.Settings.Default, "RustCOMBOBOX", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.StartFileList.FormattingEnabled = true;
            this.StartFileList.Location = new System.Drawing.Point(10, 69);
            this.StartFileList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.StartFileList.Name = "StartFileList";
            this.StartFileList.Size = new System.Drawing.Size(696, 34);
            this.StartFileList.TabIndex = 2;
            this.StartFileList.Text = global::RUSS.Properties.Settings.Default.RustCOMBOBOX;
            this.StartFileList.SelectedIndexChanged += new System.EventHandler(this.StartFileList_SelectedIndexChanged);
            this.StartFileList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StartFileList_MouseClick);
            // 
            // label68
            // 
            this.label68.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label68.ForeColor = System.Drawing.SystemColors.Control;
            this.label68.Location = new System.Drawing.Point(90, 0);
            this.label68.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(714, 48);
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
            this.panel9.Location = new System.Drawing.Point(1692, 12);
            this.panel9.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1084, 1535);
            this.panel9.TabIndex = 27;
            // 
            // PreviewDesc
            // 
            this.PreviewDesc.BackColor = System.Drawing.Color.Transparent;
            this.PreviewDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviewDesc.ForeColor = System.Drawing.SystemColors.Control;
            this.PreviewDesc.Location = new System.Drawing.Point(20, 1073);
            this.PreviewDesc.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PreviewDesc.Name = "PreviewDesc";
            this.PreviewDesc.Size = new System.Drawing.Size(1030, 313);
            this.PreviewDesc.TabIndex = 4;
            this.PreviewDesc.Text = "Ted Pommes is.... \\namazing";
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Green;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.ForeColor = System.Drawing.SystemColors.Control;
            this.button11.Location = new System.Drawing.Point(730, 1413);
            this.button11.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(320, 100);
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
            this.BtnRefreshbrowser.Location = new System.Drawing.Point(464, 1413);
            this.BtnRefreshbrowser.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnRefreshbrowser.Name = "BtnRefreshbrowser";
            this.BtnRefreshbrowser.Size = new System.Drawing.Size(254, 100);
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
            this.BtnViewPage.Location = new System.Drawing.Point(26, 1412);
            this.BtnViewPage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnViewPage.Name = "BtnViewPage";
            this.BtnViewPage.Size = new System.Drawing.Size(296, 100);
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
            this.panel13.Location = new System.Drawing.Point(4, 6);
            this.panel13.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1064, 533);
            this.panel13.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 81);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1044, 439);
            this.textBox1.TabIndex = 1;
            // 
            // label83
            // 
            this.label83.BackColor = System.Drawing.Color.Transparent;
            this.label83.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label83.ForeColor = System.Drawing.SystemColors.Control;
            this.label83.Location = new System.Drawing.Point(2, 4);
            this.label83.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(1058, 62);
            this.label83.TabIndex = 0;
            this.label83.Text = "STEAMCMD PROGRESS";
            this.label83.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label42
            // 
            this.label42.BackColor = System.Drawing.Color.Transparent;
            this.label42.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.SystemColors.Control;
            this.label42.Location = new System.Drawing.Point(694, 975);
            this.label42.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(60, 62);
            this.label42.TabIndex = 0;
            this.label42.Text = "-";
            this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FakeMS
            // 
            this.FakeMS.BackColor = System.Drawing.Color.Transparent;
            this.FakeMS.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakeMS.ForeColor = System.Drawing.SystemColors.Control;
            this.FakeMS.Location = new System.Drawing.Point(738, 975);
            this.FakeMS.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.FakeMS.Name = "FakeMS";
            this.FakeMS.Size = new System.Drawing.Size(120, 62);
            this.FakeMS.TabIndex = 0;
            this.FakeMS.Text = "10ms";
            this.FakeMS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MaxPlayersPrev
            // 
            this.MaxPlayersPrev.BackColor = System.Drawing.Color.Transparent;
            this.MaxPlayersPrev.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxPlayersPrev.ForeColor = System.Drawing.SystemColors.Control;
            this.MaxPlayersPrev.Location = new System.Drawing.Point(546, 975);
            this.MaxPlayersPrev.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.MaxPlayersPrev.Name = "MaxPlayersPrev";
            this.MaxPlayersPrev.Size = new System.Drawing.Size(158, 62);
            this.MaxPlayersPrev.TabIndex = 0;
            this.MaxPlayersPrev.Text = "50/50";
            this.MaxPlayersPrev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mapTypeprev
            // 
            this.mapTypeprev.BackColor = System.Drawing.Color.Transparent;
            this.mapTypeprev.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapTypeprev.ForeColor = System.Drawing.SystemColors.Control;
            this.mapTypeprev.Location = new System.Drawing.Point(194, 975);
            this.mapTypeprev.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.mapTypeprev.Name = "mapTypeprev";
            this.mapTypeprev.Size = new System.Drawing.Size(298, 62);
            this.mapTypeprev.TabIndex = 0;
            this.mapTypeprev.Text = "Procedural Map";
            this.mapTypeprev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label38
            // 
            this.label38.BackColor = System.Drawing.Color.Transparent;
            this.label38.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.SystemColors.Control;
            this.label38.Location = new System.Drawing.Point(486, 975);
            this.label38.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(62, 62);
            this.label38.TabIndex = 0;
            this.label38.Text = "-";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serverTitle
            // 
            this.serverTitle.BackColor = System.Drawing.Color.Transparent;
            this.serverTitle.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.serverTitle.Location = new System.Drawing.Point(26, 925);
            this.serverTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.serverTitle.Name = "serverTitle";
            this.serverTitle.Size = new System.Drawing.Size(1024, 62);
            this.serverTitle.TabIndex = 0;
            this.serverTitle.Text = "Snitzel";
            this.serverTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BannerServer
            // 
            this.BannerServer.Location = new System.Drawing.Point(26, 571);
            this.BannerServer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BannerServer.Name = "BannerServer";
            this.BannerServer.Size = new System.Drawing.Size(512, 256);
            this.BannerServer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BannerServer.TabIndex = 1;
            this.BannerServer.TabStop = false;
            // 
            // PreviewPic
            // 
            this.PreviewPic.Location = new System.Drawing.Point(10, 558);
            this.PreviewPic.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PreviewPic.Name = "PreviewPic";
            this.PreviewPic.Size = new System.Drawing.Size(529, 501);
            this.PreviewPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PreviewPic.TabIndex = 0;
            this.PreviewPic.TabStop = false;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(2810, 542);
            this.button10.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(212, 67);
            this.button10.TabIndex = 26;
            this.button10.Text = "start server";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(2808, 423);
            this.progressBar2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(202, 44);
            this.progressBar2.TabIndex = 25;
            // 
            // label43
            // 
            this.label43.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.SystemColors.Control;
            this.label43.Location = new System.Drawing.Point(482, 1554);
            this.label43.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(204, 48);
            this.label43.TabIndex = 0;
            this.label43.Text = "TWITCH";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label81
            // 
            this.label81.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label81.ForeColor = System.Drawing.SystemColors.Control;
            this.label81.Location = new System.Drawing.Point(722, 1554);
            this.label81.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(204, 48);
            this.label81.TabIndex = 0;
            this.label81.Text = "YOUTUBE";
            this.label81.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(2808, 321);
            this.button9.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(202, 100);
            this.button9.TabIndex = 24;
            this.button9.Text = "DOWNLOAD OXIDE";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.DownloadOxide_Click);
            // 
            // label80
            // 
            this.label80.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label80.ForeColor = System.Drawing.SystemColors.Control;
            this.label80.Location = new System.Drawing.Point(250, 1554);
            this.label80.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(204, 48);
            this.label80.TabIndex = 0;
            this.label80.Text = "TWITTER";
            this.label80.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label78
            // 
            this.label78.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label78.ForeColor = System.Drawing.SystemColors.Control;
            this.label78.Location = new System.Drawing.Point(18, 1554);
            this.label78.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(204, 48);
            this.label78.TabIndex = 0;
            this.label78.Text = "DISCORD";
            this.label78.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label66);
            this.panel4.Controls.Add(this.RefreshSmall);
            this.panel4.Controls.Add(this.mapinfolab);
            this.panel4.Controls.Add(this.mapPic);
            this.panel4.Location = new System.Drawing.Point(954, 798);
            this.panel4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(710, 566);
            this.panel4.TabIndex = 16;
            // 
            // label66
            // 
            this.label66.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label66.ForeColor = System.Drawing.SystemColors.Control;
            this.label66.Location = new System.Drawing.Point(8, 10);
            this.label66.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(690, 25);
            this.label66.TabIndex = 4;
            this.label66.Text = "ProcGen Map";
            this.label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RefreshSmall
            // 
            this.RefreshSmall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RefreshSmall.BackgroundImage")));
            this.RefreshSmall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RefreshSmall.Location = new System.Drawing.Point(646, 504);
            this.RefreshSmall.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RefreshSmall.Name = "RefreshSmall";
            this.RefreshSmall.Size = new System.Drawing.Size(48, 46);
            this.RefreshSmall.TabIndex = 3;
            this.RefreshSmall.UseVisualStyleBackColor = true;
            this.RefreshSmall.Click += new System.EventHandler(this.RefreshSmall_Click);
            // 
            // mapinfolab
            // 
            this.mapinfolab.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapinfolab.ForeColor = System.Drawing.SystemColors.Control;
            this.mapinfolab.Location = new System.Drawing.Point(10, 527);
            this.mapinfolab.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.mapinfolab.Name = "mapinfolab";
            this.mapinfolab.Size = new System.Drawing.Size(690, 25);
            this.mapinfolab.TabIndex = 2;
            this.mapinfolab.Text = "ProcGen Map";
            this.mapinfolab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mapPic
            // 
            this.mapPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mapPic.Location = new System.Drawing.Point(4, 2);
            this.mapPic.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.mapPic.Name = "mapPic";
            this.mapPic.Size = new System.Drawing.Size(696, 554);
            this.mapPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mapPic.TabIndex = 0;
            this.mapPic.TabStop = false;
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(2794, 1554);
            this.test.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.test.Multiline = true;
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(380, 123);
            this.test.TabIndex = 23;
            // 
            // parametersbox
            // 
            this.parametersbox.Location = new System.Drawing.Point(2808, 271);
            this.parametersbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.parametersbox.Name = "parametersbox";
            this.parametersbox.Size = new System.Drawing.Size(210, 32);
            this.parametersbox.TabIndex = 21;
            // 
            // deditextbox
            // 
            this.deditextbox.Location = new System.Drawing.Point(2794, 1115);
            this.deditextbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.deditextbox.Multiline = true;
            this.deditextbox.Name = "deditextbox";
            this.deditextbox.Size = new System.Drawing.Size(366, 154);
            this.deditextbox.TabIndex = 15;
            // 
            // loglog
            // 
            this.loglog.Location = new System.Drawing.Point(2808, 492);
            this.loglog.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.loglog.Name = "loglog";
            this.loglog.Size = new System.Drawing.Size(196, 32);
            this.loglog.TabIndex = 9;
            this.loglog.Text = "\\logs";
            // 
            // quibox
            // 
            this.quibox.Location = new System.Drawing.Point(2808, 219);
            this.quibox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.quibox.Name = "quibox";
            this.quibox.Size = new System.Drawing.Size(196, 32);
            this.quibox.TabIndex = 9;
            this.quibox.Text = "\"";
            // 
            // slashbox
            // 
            this.slashbox.Location = new System.Drawing.Point(2810, 169);
            this.slashbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.slashbox.Name = "slashbox";
            this.slashbox.Size = new System.Drawing.Size(196, 32);
            this.slashbox.TabIndex = 9;
            this.slashbox.Text = "\\";
            // 
            // steamcmdbox
            // 
            this.steamcmdbox.Location = new System.Drawing.Point(2810, 67);
            this.steamcmdbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.steamcmdbox.Name = "steamcmdbox";
            this.steamcmdbox.Size = new System.Drawing.Size(196, 32);
            this.steamcmdbox.TabIndex = 8;
            this.steamcmdbox.Text = "\\steamcmd";
            // 
            // serbat
            // 
            this.serbat.Location = new System.Drawing.Point(2810, 117);
            this.serbat.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.serbat.Name = "serbat";
            this.serbat.Size = new System.Drawing.Size(196, 32);
            this.serbat.TabIndex = 8;
            this.serbat.Text = "\\server.bat";
            // 
            // Finaltext
            // 
            this.Finaltext.Location = new System.Drawing.Point(2794, 1285);
            this.Finaltext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Finaltext.Multiline = true;
            this.Finaltext.Name = "Finaltext";
            this.Finaltext.Size = new System.Drawing.Size(366, 202);
            this.Finaltext.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(2794, 1490);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 44);
            this.button2.TabIndex = 22;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2808, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 44);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
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
            this.panel3.Location = new System.Drawing.Point(8, 206);
            this.panel3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(910, 229);
            this.panel3.TabIndex = 13;
            // 
            // RdioStaging
            // 
            this.RdioStaging.AutoSize = true;
            this.RdioStaging.Location = new System.Drawing.Point(556, 108);
            this.RdioStaging.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RdioStaging.Name = "RdioStaging";
            this.RdioStaging.Size = new System.Drawing.Size(283, 30);
            this.RdioStaging.TabIndex = 14;
            this.RdioStaging.Text = "Staging Branch Server";
            this.RdioStaging.UseVisualStyleBackColor = true;
            // 
            // RdioNormal
            // 
            this.RdioNormal.AutoSize = true;
            this.RdioNormal.Checked = true;
            this.RdioNormal.Location = new System.Drawing.Point(556, 69);
            this.RdioNormal.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RdioNormal.Name = "RdioNormal";
            this.RdioNormal.Size = new System.Drawing.Size(197, 30);
            this.RdioNormal.TabIndex = 14;
            this.RdioNormal.TabStop = true;
            this.RdioNormal.Text = "Normal Server";
            this.RdioNormal.UseVisualStyleBackColor = true;
            // 
            // steamcmdIns
            // 
            this.steamcmdIns.Location = new System.Drawing.Point(276, 69);
            this.steamcmdIns.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.steamcmdIns.Name = "steamcmdIns";
            this.steamcmdIns.Size = new System.Drawing.Size(244, 71);
            this.steamcmdIns.TabIndex = 10;
            this.steamcmdIns.Text = "DOWNLOAD SERVER FILES";
            this.steamcmdIns.UseVisualStyleBackColor = true;
            this.steamcmdIns.Click += new System.EventHandler(this.DownloadSteamCMD_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(4, 175);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(898, 44);
            this.progressBar1.TabIndex = 11;
            // 
            // label29
            // 
            this.label29.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label29.Location = new System.Drawing.Point(-4, -4);
            this.label29.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(914, 67);
            this.label29.TabIndex = 1;
            this.label29.Text = "RUST SERVER FILES";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // da
            // 
            this.da.Controls.Add(this.procgen);
            this.da.Controls.Add(this.BARREN);
            this.da.Controls.Add(this.custom);
            this.da.Controls.Add(this.Hapis);
            this.da.Controls.Add(this.CRAGGY);
            this.da.Controls.Add(this.SAVAS);
            this.da.Controls.Add(this.KOTH);
            this.da.Location = new System.Drawing.Point(8, 450);
            this.da.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.da.Name = "da";
            this.da.SelectedIndex = 0;
            this.da.Size = new System.Drawing.Size(914, 783);
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
            this.procgen.Location = new System.Drawing.Point(8, 40);
            this.procgen.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.procgen.Name = "procgen";
            this.procgen.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.procgen.Size = new System.Drawing.Size(898, 735);
            this.procgen.TabIndex = 0;
            this.procgen.Text = "PROCGEN";
            // 
            // genbtn
            // 
            this.genbtn.Location = new System.Drawing.Point(296, 640);
            this.genbtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.genbtn.Name = "genbtn";
            this.genbtn.Size = new System.Drawing.Size(590, 62);
            this.genbtn.TabIndex = 4;
            this.genbtn.Text = "GENERATE START FILE";
            this.genbtn.UseVisualStyleBackColor = true;
            this.genbtn.Click += new System.EventHandler(this.genbtn_Click);
            // 
            // mapseedtext
            // 
            this.mapseedtext.Location = new System.Drawing.Point(296, 592);
            this.mapseedtext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.mapseedtext.Name = "mapseedtext";
            this.mapseedtext.Size = new System.Drawing.Size(586, 32);
            this.mapseedtext.TabIndex = 2;
            this.mapseedtext.Text = "2";
            this.mapseedtext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mapseedtext_KeyPress);
            // 
            // mapsizebox
            // 
            this.mapsizebox.Location = new System.Drawing.Point(300, 542);
            this.mapsizebox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.mapsizebox.MaxLength = 4;
            this.mapsizebox.Name = "mapsizebox";
            this.mapsizebox.Size = new System.Drawing.Size(584, 32);
            this.mapsizebox.TabIndex = 2;
            this.mapsizebox.Text = "3000";
            this.mapsizebox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mapsizebox_KeyPress);
            this.mapsizebox.Validating += new System.ComponentModel.CancelEventHandler(this.BAmapsizebox_Validating);
            // 
            // maxplayertext
            // 
            this.maxplayertext.Location = new System.Drawing.Point(298, 492);
            this.maxplayertext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.maxplayertext.MaxLength = 3;
            this.maxplayertext.Name = "maxplayertext";
            this.maxplayertext.Size = new System.Drawing.Size(584, 32);
            this.maxplayertext.TabIndex = 2;
            this.maxplayertext.Text = "10";
            this.maxplayertext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maxplayertext_KeyPress);
            // 
            // serverdisctext
            // 
            this.serverdisctext.Location = new System.Drawing.Point(298, 442);
            this.serverdisctext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.serverdisctext.Name = "serverdisctext";
            this.serverdisctext.Size = new System.Drawing.Size(584, 32);
            this.serverdisctext.TabIndex = 2;
            this.serverdisctext.Text = "Ted Pommes is.... \\namazing";
            // 
            // serverurltext
            // 
            this.serverurltext.Location = new System.Drawing.Point(298, 392);
            this.serverurltext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.serverurltext.Name = "serverurltext";
            this.serverurltext.Size = new System.Drawing.Size(584, 32);
            this.serverurltext.TabIndex = 2;
            this.serverurltext.Text = "https://discord.gg/DPKWPr4";
            // 
            // serverpicturetext
            // 
            this.serverpicturetext.Location = new System.Drawing.Point(298, 342);
            this.serverpicturetext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.serverpicturetext.Name = "serverpicturetext";
            this.serverpicturetext.Size = new System.Drawing.Size(584, 32);
            this.serverpicturetext.TabIndex = 2;
            this.serverpicturetext.Text = "https://i.imgur.com/sqGFVW9.png";
            // 
            // rconpasstext
            // 
            this.rconpasstext.Location = new System.Drawing.Point(298, 292);
            this.rconpasstext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rconpasstext.Name = "rconpasstext";
            this.rconpasstext.Size = new System.Drawing.Size(584, 32);
            this.rconpasstext.TabIndex = 2;
            this.rconpasstext.Text = "123456seven";
            // 
            // rconporttext
            // 
            this.rconporttext.Location = new System.Drawing.Point(298, 242);
            this.rconporttext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rconporttext.MaxLength = 5;
            this.rconporttext.Name = "rconporttext";
            this.rconporttext.Size = new System.Drawing.Size(584, 32);
            this.rconporttext.TabIndex = 4;
            this.rconporttext.Text = "28016";
            this.rconporttext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rconporttext_KeyPress);
            // 
            // serverporttext
            // 
            this.serverporttext.Location = new System.Drawing.Point(298, 192);
            this.serverporttext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.serverporttext.MaxLength = 5;
            this.serverporttext.Name = "serverporttext";
            this.serverporttext.Size = new System.Drawing.Size(584, 32);
            this.serverporttext.TabIndex = 3;
            this.serverporttext.Text = "28015";
            this.serverporttext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.serverporttext_KeyPress);
            // 
            // servernametext
            // 
            this.servernametext.Location = new System.Drawing.Point(298, 142);
            this.servernametext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.servernametext.Name = "servernametext";
            this.servernametext.Size = new System.Drawing.Size(584, 32);
            this.servernametext.TabIndex = 2;
            this.servernametext.Text = "Snitzel";
            this.servernametext.TextChanged += new System.EventHandler(this.servernametext_TextChanged);
            // 
            // identitytext
            // 
            this.identitytext.Location = new System.Drawing.Point(298, 92);
            this.identitytext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.identitytext.Name = "identitytext";
            this.identitytext.Size = new System.Drawing.Size(584, 32);
            this.identitytext.TabIndex = 1;
            this.identitytext.Text = "ProcGen";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(132, 598);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 26);
            this.label13.TabIndex = 1;
            this.label13.Text = "MAP SEED";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(138, 548);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 26);
            this.label12.TabIndex = 1;
            this.label12.Text = "MAP SIZE";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(98, 498);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(186, 26);
            this.label11.TabIndex = 1;
            this.label11.Text = "MAX PLAYERS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(-2, 448);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(289, 26);
            this.label10.TabIndex = 1;
            this.label10.Text = "SERVER DISCRIPTION";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(52, 398);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(232, 26);
            this.label9.TabIndex = 1;
            this.label9.Text = "SERVER WEBSITE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(58, 348);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(226, 26);
            this.label8.TabIndex = 1;
            this.label8.Text = "SERVER PICTURE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 298);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 26);
            this.label6.TabIndex = 1;
            this.label6.Text = "RCON PASSWORD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(130, 248);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "RCON PORT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "SERVER PORT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "SERVER NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "SERVER IDENTITY";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(880, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROCGEN MAP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BARREN
            // 
            this.BARREN.BackColor = System.Drawing.Color.CadetBlue;
            this.BARREN.Controls.Add(this.button4);
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
            this.BARREN.Location = new System.Drawing.Point(8, 40);
            this.BARREN.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BARREN.Name = "BARREN";
            this.BARREN.Size = new System.Drawing.Size(898, 735);
            this.BARREN.TabIndex = 3;
            this.BARREN.Text = "BARREN";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(296, 640);
            this.button4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(590, 62);
            this.button4.TabIndex = 66;
            this.button4.Text = "GENERATE START FILE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // BAidentitytext
            // 
            this.BAidentitytext.Location = new System.Drawing.Point(298, 92);
            this.BAidentitytext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BAidentitytext.Name = "BAidentitytext";
            this.BAidentitytext.Size = new System.Drawing.Size(584, 32);
            this.BAidentitytext.TabIndex = 65;
            this.BAidentitytext.Text = "Barren";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(44, 98);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(239, 26);
            this.label15.TabIndex = 64;
            this.label15.Text = "SERVER IDENTITY";
            // 
            // BAmapseedtext
            // 
            this.BAmapseedtext.Location = new System.Drawing.Point(296, 592);
            this.BAmapseedtext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BAmapseedtext.Name = "BAmapseedtext";
            this.BAmapseedtext.Size = new System.Drawing.Size(586, 32);
            this.BAmapseedtext.TabIndex = 63;
            this.BAmapseedtext.Text = "2";
            this.BAmapseedtext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mapseedtext_KeyPress);
            // 
            // BAmapsizebox
            // 
            this.BAmapsizebox.Location = new System.Drawing.Point(300, 542);
            this.BAmapsizebox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BAmapsizebox.MaxLength = 4;
            this.BAmapsizebox.Name = "BAmapsizebox";
            this.BAmapsizebox.Size = new System.Drawing.Size(584, 32);
            this.BAmapsizebox.TabIndex = 62;
            this.BAmapsizebox.Text = "3000";
            this.BAmapsizebox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mapsizebox_KeyPress);
            this.BAmapsizebox.Validating += new System.ComponentModel.CancelEventHandler(this.BAmapsizebox_Validating);
            // 
            // BAmaxplayertext
            // 
            this.BAmaxplayertext.Location = new System.Drawing.Point(298, 492);
            this.BAmaxplayertext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BAmaxplayertext.MaxLength = 3;
            this.BAmaxplayertext.Name = "BAmaxplayertext";
            this.BAmaxplayertext.Size = new System.Drawing.Size(584, 32);
            this.BAmaxplayertext.TabIndex = 61;
            this.BAmaxplayertext.Text = "10";
            this.BAmaxplayertext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maxplayertext_KeyPress);
            // 
            // BAserverdisctext
            // 
            this.BAserverdisctext.Location = new System.Drawing.Point(298, 442);
            this.BAserverdisctext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BAserverdisctext.Name = "BAserverdisctext";
            this.BAserverdisctext.Size = new System.Drawing.Size(584, 32);
            this.BAserverdisctext.TabIndex = 60;
            this.BAserverdisctext.Text = "Ted Pommes is.... \\namazing";
            // 
            // BAserverurltext
            // 
            this.BAserverurltext.Location = new System.Drawing.Point(298, 392);
            this.BAserverurltext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BAserverurltext.Name = "BAserverurltext";
            this.BAserverurltext.Size = new System.Drawing.Size(584, 32);
            this.BAserverurltext.TabIndex = 59;
            this.BAserverurltext.Text = "https://discord.gg/DPKWPr4";
            // 
            // BAserverpicturetext
            // 
            this.BAserverpicturetext.Location = new System.Drawing.Point(298, 342);
            this.BAserverpicturetext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BAserverpicturetext.Name = "BAserverpicturetext";
            this.BAserverpicturetext.Size = new System.Drawing.Size(584, 32);
            this.BAserverpicturetext.TabIndex = 58;
            this.BAserverpicturetext.Text = "https://i.imgur.com/sqGFVW9.png";
            // 
            // BArconpasstext
            // 
            this.BArconpasstext.Location = new System.Drawing.Point(298, 292);
            this.BArconpasstext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BArconpasstext.Name = "BArconpasstext";
            this.BArconpasstext.Size = new System.Drawing.Size(584, 32);
            this.BArconpasstext.TabIndex = 57;
            this.BArconpasstext.Text = "123456seven";
            // 
            // BArconporttext
            // 
            this.BArconporttext.Location = new System.Drawing.Point(298, 242);
            this.BArconporttext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BArconporttext.MaxLength = 5;
            this.BArconporttext.Name = "BArconporttext";
            this.BArconporttext.Size = new System.Drawing.Size(584, 32);
            this.BArconporttext.TabIndex = 56;
            this.BArconporttext.Text = "28016";
            this.BArconporttext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rconporttext_KeyPress);
            // 
            // BAserverportext
            // 
            this.BAserverportext.Location = new System.Drawing.Point(298, 192);
            this.BAserverportext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BAserverportext.MaxLength = 5;
            this.BAserverportext.Name = "BAserverportext";
            this.BAserverportext.Size = new System.Drawing.Size(584, 32);
            this.BAserverportext.TabIndex = 55;
            this.BAserverportext.Text = "28015";
            this.BAserverportext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.serverporttext_KeyPress);
            // 
            // BAservernametext
            // 
            this.BAservernametext.Location = new System.Drawing.Point(298, 142);
            this.BAservernametext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BAservernametext.Name = "BAservernametext";
            this.BAservernametext.Size = new System.Drawing.Size(584, 32);
            this.BAservernametext.TabIndex = 54;
            this.BAservernametext.Text = "Snitzel";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(132, 598);
            this.label44.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(138, 26);
            this.label44.TabIndex = 51;
            this.label44.Text = "MAP SEED";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.Location = new System.Drawing.Point(138, 548);
            this.label55.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(132, 26);
            this.label55.TabIndex = 50;
            this.label55.Text = "MAP SIZE";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.Location = new System.Drawing.Point(98, 498);
            this.label58.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(186, 26);
            this.label58.TabIndex = 49;
            this.label58.Text = "MAX PLAYERS";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.Location = new System.Drawing.Point(-2, 448);
            this.label59.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(289, 26);
            this.label59.TabIndex = 48;
            this.label59.Text = "SERVER DISCRIPTION";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.Location = new System.Drawing.Point(52, 398);
            this.label60.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(232, 26);
            this.label60.TabIndex = 47;
            this.label60.Text = "SERVER WEBSITE";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.Location = new System.Drawing.Point(58, 348);
            this.label61.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(226, 26);
            this.label61.TabIndex = 46;
            this.label61.Text = "SERVER PICTURE";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.Location = new System.Drawing.Point(54, 298);
            this.label62.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(235, 26);
            this.label62.TabIndex = 45;
            this.label62.Text = "RCON PASSWORD";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.Location = new System.Drawing.Point(130, 248);
            this.label63.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(158, 26);
            this.label63.TabIndex = 44;
            this.label63.Text = "RCON PORT";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.Location = new System.Drawing.Point(102, 198);
            this.label64.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(184, 26);
            this.label64.TabIndex = 43;
            this.label64.Text = "SERVER PORT";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.Location = new System.Drawing.Point(96, 148);
            this.label65.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(189, 26);
            this.label65.TabIndex = 42;
            this.label65.Text = "SERVER NAME";
            // 
            // label67
            // 
            this.label67.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold);
            this.label67.Location = new System.Drawing.Point(12, 6);
            this.label67.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(880, 63);
            this.label67.TabIndex = 41;
            this.label67.Text = "BARREN MAP";
            this.label67.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // custom
            // 
            this.custom.BackColor = System.Drawing.Color.CadetBlue;
            this.custom.Controls.Add(this.button15);
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
            this.custom.Location = new System.Drawing.Point(8, 40);
            this.custom.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.custom.Name = "custom";
            this.custom.Size = new System.Drawing.Size(898, 735);
            this.custom.TabIndex = 1;
            this.custom.Text = "CUSTOM MAP";
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(300, 596);
            this.button15.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(592, 62);
            this.button15.TabIndex = 31;
            this.button15.Text = "Local Only Map";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // BTNbatchCustom
            // 
            this.BTNbatchCustom.Location = new System.Drawing.Point(300, 660);
            this.BTNbatchCustom.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BTNbatchCustom.Name = "BTNbatchCustom";
            this.BTNbatchCustom.Size = new System.Drawing.Size(592, 62);
            this.BTNbatchCustom.TabIndex = 30;
            this.BTNbatchCustom.Text = "GENERATE START FILE";
            this.BTNbatchCustom.UseVisualStyleBackColor = true;
            this.BTNbatchCustom.Click += new System.EventHandler(this.button2_Click);
            // 
            // mapurlbox
            // 
            this.mapurlbox.Location = new System.Drawing.Point(298, 554);
            this.mapurlbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.mapurlbox.Name = "mapurlbox";
            this.mapurlbox.Size = new System.Drawing.Size(588, 32);
            this.mapurlbox.TabIndex = 27;
            // 
            // CMmaxplayertext
            // 
            this.CMmaxplayertext.Location = new System.Drawing.Point(298, 504);
            this.CMmaxplayertext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CMmaxplayertext.MaxLength = 3;
            this.CMmaxplayertext.Name = "CMmaxplayertext";
            this.CMmaxplayertext.Size = new System.Drawing.Size(588, 32);
            this.CMmaxplayertext.TabIndex = 25;
            this.CMmaxplayertext.Text = "10";
            this.CMmaxplayertext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maxplayertext_KeyPress);
            // 
            // CMserverdisctext
            // 
            this.CMserverdisctext.Location = new System.Drawing.Point(298, 454);
            this.CMserverdisctext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CMserverdisctext.Name = "CMserverdisctext";
            this.CMserverdisctext.Size = new System.Drawing.Size(588, 32);
            this.CMserverdisctext.TabIndex = 24;
            this.CMserverdisctext.Text = "Ted Pommes is.... \\namazing";
            // 
            // CMserverurltext
            // 
            this.CMserverurltext.Location = new System.Drawing.Point(298, 404);
            this.CMserverurltext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CMserverurltext.Name = "CMserverurltext";
            this.CMserverurltext.Size = new System.Drawing.Size(588, 32);
            this.CMserverurltext.TabIndex = 23;
            this.CMserverurltext.Text = "https://discord.gg/DPKWPr4";
            // 
            // CMserverpicturetext
            // 
            this.CMserverpicturetext.Location = new System.Drawing.Point(298, 354);
            this.CMserverpicturetext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CMserverpicturetext.Name = "CMserverpicturetext";
            this.CMserverpicturetext.Size = new System.Drawing.Size(588, 32);
            this.CMserverpicturetext.TabIndex = 22;
            this.CMserverpicturetext.Text = "https://i.imgur.com/sqGFVW9.png";
            // 
            // CMrconpasstext
            // 
            this.CMrconpasstext.Location = new System.Drawing.Point(298, 304);
            this.CMrconpasstext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CMrconpasstext.Name = "CMrconpasstext";
            this.CMrconpasstext.Size = new System.Drawing.Size(588, 32);
            this.CMrconpasstext.TabIndex = 21;
            this.CMrconpasstext.Text = "123456seven";
            // 
            // CMrconporttext
            // 
            this.CMrconporttext.Location = new System.Drawing.Point(298, 254);
            this.CMrconporttext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CMrconporttext.MaxLength = 5;
            this.CMrconporttext.Name = "CMrconporttext";
            this.CMrconporttext.Size = new System.Drawing.Size(588, 32);
            this.CMrconporttext.TabIndex = 20;
            this.CMrconporttext.Text = "28016";
            this.CMrconporttext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rconporttext_KeyPress);
            // 
            // CMserverportext
            // 
            this.CMserverportext.Location = new System.Drawing.Point(298, 204);
            this.CMserverportext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CMserverportext.MaxLength = 5;
            this.CMserverportext.Name = "CMserverportext";
            this.CMserverportext.Size = new System.Drawing.Size(588, 32);
            this.CMserverportext.TabIndex = 19;
            this.CMserverportext.Text = "28015";
            this.CMserverportext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.serverporttext_KeyPress);
            // 
            // CMservernametext
            // 
            this.CMservernametext.Location = new System.Drawing.Point(298, 154);
            this.CMservernametext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CMservernametext.Name = "CMservernametext";
            this.CMservernametext.Size = new System.Drawing.Size(588, 32);
            this.CMservernametext.TabIndex = 28;
            this.CMservernametext.Text = "Snitzel";
            // 
            // CMidentitytext
            // 
            this.CMidentitytext.Location = new System.Drawing.Point(296, 106);
            this.CMidentitytext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CMidentitytext.Name = "CMidentitytext";
            this.CMidentitytext.Size = new System.Drawing.Size(588, 32);
            this.CMidentitytext.TabIndex = 18;
            this.CMidentitytext.Text = "CustomMap";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(160, 560);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(123, 26);
            this.label16.TabIndex = 15;
            this.label16.Text = "MAP URL";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(98, 510);
            this.label18.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(186, 26);
            this.label18.TabIndex = 13;
            this.label18.Text = "MAX PLAYERS";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(-2, 460);
            this.label19.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(289, 26);
            this.label19.TabIndex = 12;
            this.label19.Text = "SERVER DISCRIPTION";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(52, 410);
            this.label20.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(232, 26);
            this.label20.TabIndex = 11;
            this.label20.Text = "SERVER WEBSITE";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(58, 360);
            this.label21.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(226, 26);
            this.label21.TabIndex = 10;
            this.label21.Text = "SERVER PICTURE";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(54, 310);
            this.label22.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(235, 26);
            this.label22.TabIndex = 9;
            this.label22.Text = "RCON PASSWORD";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(130, 260);
            this.label23.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(158, 26);
            this.label23.TabIndex = 8;
            this.label23.Text = "RCON PORT";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(102, 210);
            this.label24.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(184, 26);
            this.label24.TabIndex = 7;
            this.label24.Text = "SERVER PORT";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(96, 160);
            this.label25.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(189, 26);
            this.label25.TabIndex = 6;
            this.label25.Text = "SERVER NAME";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(42, 112);
            this.label26.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(239, 26);
            this.label26.TabIndex = 17;
            this.label26.Text = "SERVER IDENTITY";
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold);
            this.label27.Location = new System.Drawing.Point(12, 6);
            this.label27.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(886, 62);
            this.label27.TabIndex = 5;
            this.label27.Text = "CUSTOM MAP";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Hapis.Location = new System.Drawing.Point(8, 40);
            this.Hapis.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Hapis.Name = "Hapis";
            this.Hapis.Size = new System.Drawing.Size(898, 735);
            this.Hapis.TabIndex = 2;
            this.Hapis.Text = "HAPIS";
            // 
            // HAidentitytext
            // 
            this.HAidentitytext.Location = new System.Drawing.Point(296, 106);
            this.HAidentitytext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.HAidentitytext.Name = "HAidentitytext";
            this.HAidentitytext.Size = new System.Drawing.Size(588, 32);
            this.HAidentitytext.TabIndex = 42;
            this.HAidentitytext.Text = "HapisIsland";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 112);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 26);
            this.label7.TabIndex = 41;
            this.label7.Text = "SERVER IDENTITY";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(296, 554);
            this.button3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(588, 71);
            this.button3.TabIndex = 39;
            this.button3.Text = "GENERATE START FILE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // HPmaxplayertext
            // 
            this.HPmaxplayertext.Location = new System.Drawing.Point(298, 504);
            this.HPmaxplayertext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.HPmaxplayertext.MaxLength = 3;
            this.HPmaxplayertext.Name = "HPmaxplayertext";
            this.HPmaxplayertext.Size = new System.Drawing.Size(588, 32);
            this.HPmaxplayertext.TabIndex = 34;
            this.HPmaxplayertext.Text = "10";
            this.HPmaxplayertext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maxplayertext_KeyPress);
            // 
            // HPserverdisctext
            // 
            this.HPserverdisctext.Location = new System.Drawing.Point(298, 454);
            this.HPserverdisctext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.HPserverdisctext.Name = "HPserverdisctext";
            this.HPserverdisctext.Size = new System.Drawing.Size(588, 32);
            this.HPserverdisctext.TabIndex = 33;
            this.HPserverdisctext.Text = "Ted Pommes is.... \\namazing";
            // 
            // HPserverurltext
            // 
            this.HPserverurltext.Location = new System.Drawing.Point(298, 404);
            this.HPserverurltext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.HPserverurltext.Name = "HPserverurltext";
            this.HPserverurltext.Size = new System.Drawing.Size(588, 32);
            this.HPserverurltext.TabIndex = 32;
            this.HPserverurltext.Text = "https://discord.gg/DPKWPr4";
            // 
            // HPserverpicturetext
            // 
            this.HPserverpicturetext.Location = new System.Drawing.Point(298, 354);
            this.HPserverpicturetext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.HPserverpicturetext.Name = "HPserverpicturetext";
            this.HPserverpicturetext.Size = new System.Drawing.Size(588, 32);
            this.HPserverpicturetext.TabIndex = 31;
            this.HPserverpicturetext.Text = "https://i.imgur.com/sqGFVW9.png";
            // 
            // HPrconpasstext
            // 
            this.HPrconpasstext.Location = new System.Drawing.Point(298, 304);
            this.HPrconpasstext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.HPrconpasstext.Name = "HPrconpasstext";
            this.HPrconpasstext.Size = new System.Drawing.Size(588, 32);
            this.HPrconpasstext.TabIndex = 30;
            this.HPrconpasstext.Text = "123456seven";
            // 
            // HPrconporttext
            // 
            this.HPrconporttext.Location = new System.Drawing.Point(298, 254);
            this.HPrconporttext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.HPrconporttext.MaxLength = 5;
            this.HPrconporttext.Name = "HPrconporttext";
            this.HPrconporttext.Size = new System.Drawing.Size(588, 32);
            this.HPrconporttext.TabIndex = 29;
            this.HPrconporttext.Text = "28016";
            this.HPrconporttext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rconporttext_KeyPress);
            // 
            // HPserverportext
            // 
            this.HPserverportext.Location = new System.Drawing.Point(298, 204);
            this.HPserverportext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.HPserverportext.MaxLength = 5;
            this.HPserverportext.Name = "HPserverportext";
            this.HPserverportext.Size = new System.Drawing.Size(588, 32);
            this.HPserverportext.TabIndex = 28;
            this.HPserverportext.Text = "28015";
            this.HPserverportext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.serverporttext_KeyPress);
            // 
            // HPservernametext
            // 
            this.HPservernametext.Location = new System.Drawing.Point(298, 154);
            this.HPservernametext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.HPservernametext.Name = "HPservernametext";
            this.HPservernametext.Size = new System.Drawing.Size(588, 32);
            this.HPservernametext.TabIndex = 37;
            this.HPservernametext.Text = "Snitzel";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(98, 510);
            this.label45.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(186, 26);
            this.label45.TabIndex = 22;
            this.label45.Text = "MAX PLAYERS";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(-2, 460);
            this.label46.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(289, 26);
            this.label46.TabIndex = 21;
            this.label46.Text = "SERVER DISCRIPTION";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(52, 410);
            this.label49.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(232, 26);
            this.label49.TabIndex = 20;
            this.label49.Text = "SERVER WEBSITE";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(58, 360);
            this.label50.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(226, 26);
            this.label50.TabIndex = 19;
            this.label50.Text = "SERVER PICTURE";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(54, 310);
            this.label51.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(235, 26);
            this.label51.TabIndex = 18;
            this.label51.Text = "RCON PASSWORD";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(130, 260);
            this.label52.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(158, 26);
            this.label52.TabIndex = 17;
            this.label52.Text = "RCON PORT";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.Location = new System.Drawing.Point(102, 210);
            this.label53.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(184, 26);
            this.label53.TabIndex = 16;
            this.label53.Text = "SERVER PORT";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.Location = new System.Drawing.Point(96, 160);
            this.label54.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(189, 26);
            this.label54.TabIndex = 15;
            this.label54.Text = "SERVER NAME";
            // 
            // label56
            // 
            this.label56.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold);
            this.label56.Location = new System.Drawing.Point(12, 6);
            this.label56.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(888, 63);
            this.label56.TabIndex = 14;
            this.label56.Text = "HAPIS ISLAND";
            this.label56.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.CRAGGY.Location = new System.Drawing.Point(8, 40);
            this.CRAGGY.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CRAGGY.Name = "CRAGGY";
            this.CRAGGY.Size = new System.Drawing.Size(898, 735);
            this.CRAGGY.TabIndex = 4;
            this.CRAGGY.Text = "CRAGGY";
            // 
            // CRidentitytext
            // 
            this.CRidentitytext.Location = new System.Drawing.Point(296, 106);
            this.CRidentitytext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CRidentitytext.Name = "CRidentitytext";
            this.CRidentitytext.Size = new System.Drawing.Size(588, 32);
            this.CRidentitytext.TabIndex = 63;
            this.CRidentitytext.Text = "Craggy";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(42, 112);
            this.label36.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(239, 26);
            this.label36.TabIndex = 62;
            this.label36.Text = "SERVER IDENTITY";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(296, 554);
            this.button5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(588, 71);
            this.button5.TabIndex = 60;
            this.button5.Text = "GENERATE START FILE";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // CRmaxplayertext
            // 
            this.CRmaxplayertext.Location = new System.Drawing.Point(298, 504);
            this.CRmaxplayertext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CRmaxplayertext.MaxLength = 3;
            this.CRmaxplayertext.Name = "CRmaxplayertext";
            this.CRmaxplayertext.Size = new System.Drawing.Size(588, 32);
            this.CRmaxplayertext.TabIndex = 57;
            this.CRmaxplayertext.Text = "10";
            this.CRmaxplayertext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maxplayertext_KeyPress);
            // 
            // CRserverdisctext
            // 
            this.CRserverdisctext.Location = new System.Drawing.Point(298, 454);
            this.CRserverdisctext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CRserverdisctext.Name = "CRserverdisctext";
            this.CRserverdisctext.Size = new System.Drawing.Size(588, 32);
            this.CRserverdisctext.TabIndex = 56;
            this.CRserverdisctext.Text = "Ted Pommes is.... \\namazing";
            // 
            // CRserverurltext
            // 
            this.CRserverurltext.Location = new System.Drawing.Point(298, 404);
            this.CRserverurltext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CRserverurltext.Name = "CRserverurltext";
            this.CRserverurltext.Size = new System.Drawing.Size(588, 32);
            this.CRserverurltext.TabIndex = 55;
            this.CRserverurltext.Text = "https://discord.gg/DPKWPr4";
            // 
            // CRserverpicturetext
            // 
            this.CRserverpicturetext.Location = new System.Drawing.Point(298, 354);
            this.CRserverpicturetext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CRserverpicturetext.Name = "CRserverpicturetext";
            this.CRserverpicturetext.Size = new System.Drawing.Size(588, 32);
            this.CRserverpicturetext.TabIndex = 54;
            this.CRserverpicturetext.Text = "https://i.imgur.com/sqGFVW9.png";
            // 
            // CRrconpasstext
            // 
            this.CRrconpasstext.Location = new System.Drawing.Point(298, 304);
            this.CRrconpasstext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CRrconpasstext.Name = "CRrconpasstext";
            this.CRrconpasstext.Size = new System.Drawing.Size(588, 32);
            this.CRrconpasstext.TabIndex = 53;
            this.CRrconpasstext.Text = "123456seven";
            // 
            // CRrconporttext
            // 
            this.CRrconporttext.Location = new System.Drawing.Point(298, 254);
            this.CRrconporttext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CRrconporttext.MaxLength = 5;
            this.CRrconporttext.Name = "CRrconporttext";
            this.CRrconporttext.Size = new System.Drawing.Size(588, 32);
            this.CRrconporttext.TabIndex = 52;
            this.CRrconporttext.Text = "28016";
            this.CRrconporttext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rconporttext_KeyPress);
            // 
            // CRserverportext
            // 
            this.CRserverportext.Location = new System.Drawing.Point(298, 204);
            this.CRserverportext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CRserverportext.MaxLength = 5;
            this.CRserverportext.Name = "CRserverportext";
            this.CRserverportext.Size = new System.Drawing.Size(588, 32);
            this.CRserverportext.TabIndex = 51;
            this.CRserverportext.Text = "28015";
            this.CRserverportext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.serverporttext_KeyPress);
            // 
            // CRservernametext
            // 
            this.CRservernametext.Location = new System.Drawing.Point(298, 154);
            this.CRservernametext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CRservernametext.Name = "CRservernametext";
            this.CRservernametext.Size = new System.Drawing.Size(588, 32);
            this.CRservernametext.TabIndex = 58;
            this.CRservernametext.Text = "Snitzel";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label69.Location = new System.Drawing.Point(98, 510);
            this.label69.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(186, 26);
            this.label69.TabIndex = 49;
            this.label69.Text = "MAX PLAYERS";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label70.Location = new System.Drawing.Point(-2, 460);
            this.label70.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(289, 26);
            this.label70.TabIndex = 48;
            this.label70.Text = "SERVER DISCRIPTION";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label71.Location = new System.Drawing.Point(52, 410);
            this.label71.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(232, 26);
            this.label71.TabIndex = 47;
            this.label71.Text = "SERVER WEBSITE";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label72.Location = new System.Drawing.Point(58, 360);
            this.label72.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(226, 26);
            this.label72.TabIndex = 46;
            this.label72.Text = "SERVER PICTURE";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label73.Location = new System.Drawing.Point(54, 310);
            this.label73.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(235, 26);
            this.label73.TabIndex = 45;
            this.label73.Text = "RCON PASSWORD";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label74.Location = new System.Drawing.Point(130, 260);
            this.label74.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(158, 26);
            this.label74.TabIndex = 44;
            this.label74.Text = "RCON PORT";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label75.Location = new System.Drawing.Point(102, 210);
            this.label75.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(184, 26);
            this.label75.TabIndex = 43;
            this.label75.Text = "SERVER PORT";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label76.Location = new System.Drawing.Point(96, 160);
            this.label76.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(189, 26);
            this.label76.TabIndex = 42;
            this.label76.Text = "SERVER NAME";
            // 
            // label77
            // 
            this.label77.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold);
            this.label77.Location = new System.Drawing.Point(12, 6);
            this.label77.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(876, 63);
            this.label77.TabIndex = 41;
            this.label77.Text = "CRAGGY  ISLAND";
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
            this.SAVAS.Location = new System.Drawing.Point(8, 40);
            this.SAVAS.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SAVAS.Name = "SAVAS";
            this.SAVAS.Size = new System.Drawing.Size(898, 735);
            this.SAVAS.TabIndex = 5;
            this.SAVAS.Text = "SAVAS";
            // 
            // SAidentitytext
            // 
            this.SAidentitytext.Location = new System.Drawing.Point(296, 106);
            this.SAidentitytext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SAidentitytext.Name = "SAidentitytext";
            this.SAidentitytext.Size = new System.Drawing.Size(588, 32);
            this.SAidentitytext.TabIndex = 63;
            this.SAidentitytext.Text = "Savas";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(42, 112);
            this.label39.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(239, 26);
            this.label39.TabIndex = 62;
            this.label39.Text = "SERVER IDENTITY";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(296, 554);
            this.button7.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(588, 71);
            this.button7.TabIndex = 60;
            this.button7.Text = "GENERATE START FILE";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // SAmaxplayertext
            // 
            this.SAmaxplayertext.Location = new System.Drawing.Point(298, 504);
            this.SAmaxplayertext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SAmaxplayertext.MaxLength = 3;
            this.SAmaxplayertext.Name = "SAmaxplayertext";
            this.SAmaxplayertext.Size = new System.Drawing.Size(588, 32);
            this.SAmaxplayertext.TabIndex = 57;
            this.SAmaxplayertext.Text = "10";
            this.SAmaxplayertext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maxplayertext_KeyPress);
            // 
            // SAserverdisctext
            // 
            this.SAserverdisctext.Location = new System.Drawing.Point(298, 454);
            this.SAserverdisctext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SAserverdisctext.Name = "SAserverdisctext";
            this.SAserverdisctext.Size = new System.Drawing.Size(588, 32);
            this.SAserverdisctext.TabIndex = 56;
            this.SAserverdisctext.Text = "Ted Pommes is.... \\namazing";
            // 
            // SAserverurltext
            // 
            this.SAserverurltext.Location = new System.Drawing.Point(298, 404);
            this.SAserverurltext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SAserverurltext.Name = "SAserverurltext";
            this.SAserverurltext.Size = new System.Drawing.Size(588, 32);
            this.SAserverurltext.TabIndex = 55;
            this.SAserverurltext.Text = "https://discord.gg/DPKWPr4";
            // 
            // SAserverpicturetext
            // 
            this.SAserverpicturetext.Location = new System.Drawing.Point(298, 354);
            this.SAserverpicturetext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SAserverpicturetext.Name = "SAserverpicturetext";
            this.SAserverpicturetext.Size = new System.Drawing.Size(588, 32);
            this.SAserverpicturetext.TabIndex = 54;
            this.SAserverpicturetext.Text = "https://i.imgur.com/sqGFVW9.png";
            // 
            // SArconpasstext
            // 
            this.SArconpasstext.Location = new System.Drawing.Point(298, 304);
            this.SArconpasstext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SArconpasstext.Name = "SArconpasstext";
            this.SArconpasstext.Size = new System.Drawing.Size(588, 32);
            this.SArconpasstext.TabIndex = 53;
            this.SArconpasstext.Text = "123456seven";
            // 
            // SArconporttext
            // 
            this.SArconporttext.Location = new System.Drawing.Point(298, 254);
            this.SArconporttext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SArconporttext.MaxLength = 5;
            this.SArconporttext.Name = "SArconporttext";
            this.SArconporttext.Size = new System.Drawing.Size(588, 32);
            this.SArconporttext.TabIndex = 52;
            this.SArconporttext.Text = "28016";
            this.SArconporttext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rconporttext_KeyPress);
            // 
            // SAserverportext
            // 
            this.SAserverportext.Location = new System.Drawing.Point(298, 204);
            this.SAserverportext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SAserverportext.MaxLength = 5;
            this.SAserverportext.Name = "SAserverportext";
            this.SAserverportext.Size = new System.Drawing.Size(588, 32);
            this.SAserverportext.TabIndex = 51;
            this.SAserverportext.Text = "28015";
            this.SAserverportext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.serverporttext_KeyPress);
            // 
            // SAservernametext
            // 
            this.SAservernametext.Location = new System.Drawing.Point(298, 154);
            this.SAservernametext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SAservernametext.Name = "SAservernametext";
            this.SAservernametext.Size = new System.Drawing.Size(588, 32);
            this.SAservernametext.TabIndex = 58;
            this.SAservernametext.Text = "Snitzel";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label84.Location = new System.Drawing.Point(98, 510);
            this.label84.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(186, 26);
            this.label84.TabIndex = 49;
            this.label84.Text = "MAX PLAYERS";
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label85.Location = new System.Drawing.Point(-2, 460);
            this.label85.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(289, 26);
            this.label85.TabIndex = 48;
            this.label85.Text = "SERVER DISCRIPTION";
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label86.Location = new System.Drawing.Point(52, 410);
            this.label86.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(232, 26);
            this.label86.TabIndex = 47;
            this.label86.Text = "SERVER WEBSITE";
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label87.Location = new System.Drawing.Point(58, 360);
            this.label87.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(226, 26);
            this.label87.TabIndex = 46;
            this.label87.Text = "SERVER PICTURE";
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label88.Location = new System.Drawing.Point(54, 310);
            this.label88.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(235, 26);
            this.label88.TabIndex = 45;
            this.label88.Text = "RCON PASSWORD";
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label89.Location = new System.Drawing.Point(130, 260);
            this.label89.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(158, 26);
            this.label89.TabIndex = 44;
            this.label89.Text = "RCON PORT";
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label90.Location = new System.Drawing.Point(102, 210);
            this.label90.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(184, 26);
            this.label90.TabIndex = 43;
            this.label90.Text = "SERVER PORT";
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label91.Location = new System.Drawing.Point(96, 160);
            this.label91.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(189, 26);
            this.label91.TabIndex = 42;
            this.label91.Text = "SERVER NAME";
            // 
            // label92
            // 
            this.label92.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold);
            this.label92.Location = new System.Drawing.Point(12, 6);
            this.label92.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(888, 63);
            this.label92.TabIndex = 41;
            this.label92.Text = "SAVAS ISLAND";
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
            this.KOTH.Location = new System.Drawing.Point(8, 40);
            this.KOTH.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.KOTH.Name = "KOTH";
            this.KOTH.Size = new System.Drawing.Size(898, 735);
            this.KOTH.TabIndex = 6;
            this.KOTH.Text = "KOTH";
            // 
            // KOidentitytext
            // 
            this.KOidentitytext.Location = new System.Drawing.Point(296, 106);
            this.KOidentitytext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.KOidentitytext.Name = "KOidentitytext";
            this.KOidentitytext.Size = new System.Drawing.Size(588, 32);
            this.KOidentitytext.TabIndex = 63;
            this.KOidentitytext.Text = "SavasKOTH";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(42, 112);
            this.label40.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(239, 26);
            this.label40.TabIndex = 62;
            this.label40.Text = "SERVER IDENTITY";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(296, 554);
            this.button8.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(588, 71);
            this.button8.TabIndex = 60;
            this.button8.Text = "GENERATE START FILE";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // KOmaxplayertext
            // 
            this.KOmaxplayertext.Location = new System.Drawing.Point(298, 504);
            this.KOmaxplayertext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.KOmaxplayertext.MaxLength = 3;
            this.KOmaxplayertext.Name = "KOmaxplayertext";
            this.KOmaxplayertext.Size = new System.Drawing.Size(588, 32);
            this.KOmaxplayertext.TabIndex = 57;
            this.KOmaxplayertext.Text = "10";
            this.KOmaxplayertext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maxplayertext_KeyPress);
            // 
            // KOserverdisctext
            // 
            this.KOserverdisctext.Location = new System.Drawing.Point(298, 454);
            this.KOserverdisctext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.KOserverdisctext.Name = "KOserverdisctext";
            this.KOserverdisctext.Size = new System.Drawing.Size(588, 32);
            this.KOserverdisctext.TabIndex = 56;
            this.KOserverdisctext.Text = "Ted Pommes is.... \\namazing";
            // 
            // KOserverurltext
            // 
            this.KOserverurltext.Location = new System.Drawing.Point(298, 404);
            this.KOserverurltext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.KOserverurltext.Name = "KOserverurltext";
            this.KOserverurltext.Size = new System.Drawing.Size(588, 32);
            this.KOserverurltext.TabIndex = 55;
            this.KOserverurltext.Text = "https://discord.gg/DPKWPr4";
            // 
            // KOserverpicturetext
            // 
            this.KOserverpicturetext.Location = new System.Drawing.Point(298, 354);
            this.KOserverpicturetext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.KOserverpicturetext.Name = "KOserverpicturetext";
            this.KOserverpicturetext.Size = new System.Drawing.Size(588, 32);
            this.KOserverpicturetext.TabIndex = 54;
            this.KOserverpicturetext.Text = "https://i.imgur.com/sqGFVW9.png";
            // 
            // KOrconpasstext
            // 
            this.KOrconpasstext.Location = new System.Drawing.Point(298, 304);
            this.KOrconpasstext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.KOrconpasstext.Name = "KOrconpasstext";
            this.KOrconpasstext.Size = new System.Drawing.Size(588, 32);
            this.KOrconpasstext.TabIndex = 53;
            this.KOrconpasstext.Text = "123456seven";
            // 
            // KOrconporttext
            // 
            this.KOrconporttext.Location = new System.Drawing.Point(298, 254);
            this.KOrconporttext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.KOrconporttext.MaxLength = 5;
            this.KOrconporttext.Name = "KOrconporttext";
            this.KOrconporttext.Size = new System.Drawing.Size(588, 32);
            this.KOrconporttext.TabIndex = 52;
            this.KOrconporttext.Text = "28016";
            this.KOrconporttext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rconporttext_KeyPress);
            // 
            // KOserverportext
            // 
            this.KOserverportext.Location = new System.Drawing.Point(298, 204);
            this.KOserverportext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.KOserverportext.MaxLength = 5;
            this.KOserverportext.Name = "KOserverportext";
            this.KOserverportext.Size = new System.Drawing.Size(588, 32);
            this.KOserverportext.TabIndex = 51;
            this.KOserverportext.Text = "28015";
            this.KOserverportext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.serverporttext_KeyPress);
            // 
            // KOservernametext
            // 
            this.KOservernametext.Location = new System.Drawing.Point(298, 154);
            this.KOservernametext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.KOservernametext.Name = "KOservernametext";
            this.KOservernametext.Size = new System.Drawing.Size(588, 32);
            this.KOservernametext.TabIndex = 58;
            this.KOservernametext.Text = "Snitzel";
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label95.Location = new System.Drawing.Point(98, 510);
            this.label95.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(186, 26);
            this.label95.TabIndex = 49;
            this.label95.Text = "MAX PLAYERS";
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label96.Location = new System.Drawing.Point(-2, 460);
            this.label96.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(289, 26);
            this.label96.TabIndex = 48;
            this.label96.Text = "SERVER DISCRIPTION";
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label97.Location = new System.Drawing.Point(52, 410);
            this.label97.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(232, 26);
            this.label97.TabIndex = 47;
            this.label97.Text = "SERVER WEBSITE";
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label98.Location = new System.Drawing.Point(58, 360);
            this.label98.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(226, 26);
            this.label98.TabIndex = 46;
            this.label98.Text = "SERVER PICTURE";
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label99.Location = new System.Drawing.Point(54, 310);
            this.label99.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(235, 26);
            this.label99.TabIndex = 45;
            this.label99.Text = "RCON PASSWORD";
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label100.Location = new System.Drawing.Point(130, 260);
            this.label100.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(158, 26);
            this.label100.TabIndex = 44;
            this.label100.Text = "RCON PORT";
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label101.Location = new System.Drawing.Point(102, 210);
            this.label101.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(184, 26);
            this.label101.TabIndex = 43;
            this.label101.Text = "SERVER PORT";
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label102.Location = new System.Drawing.Point(96, 160);
            this.label102.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(189, 26);
            this.label102.TabIndex = 42;
            this.label102.Text = "SERVER NAME";
            // 
            // label103
            // 
            this.label103.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold);
            this.label103.Location = new System.Drawing.Point(12, 6);
            this.label103.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(888, 63);
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
            this.panel1.Location = new System.Drawing.Point(2782, 633);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 469);
            this.panel1.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label14.Location = new System.Drawing.Point(132, 12);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(277, 26);
            this.label14.TabIndex = 1;
            this.label14.Text = "BAT FILE DIRECTORY";
            // 
            // LogLocation
            // 
            this.LogLocation.Location = new System.Drawing.Point(26, 423);
            this.LogLocation.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.LogLocation.Name = "LogLocation";
            this.LogLocation.Size = new System.Drawing.Size(568, 32);
            this.LogLocation.TabIndex = 0;
            // 
            // dedicateddirectory
            // 
            this.dedicateddirectory.Location = new System.Drawing.Point(26, 371);
            this.dedicateddirectory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dedicateddirectory.Name = "dedicateddirectory";
            this.dedicateddirectory.Size = new System.Drawing.Size(568, 32);
            this.dedicateddirectory.TabIndex = 0;
            // 
            // servfilesdirectory
            // 
            this.servfilesdirectory.Location = new System.Drawing.Point(26, 321);
            this.servfilesdirectory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.servfilesdirectory.Name = "servfilesdirectory";
            this.servfilesdirectory.Size = new System.Drawing.Size(568, 32);
            this.servfilesdirectory.TabIndex = 0;
            // 
            // cmdbatdirstaging
            // 
            this.cmdbatdirstaging.Location = new System.Drawing.Point(16, 217);
            this.cmdbatdirstaging.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmdbatdirstaging.Name = "cmdbatdirstaging";
            this.cmdbatdirstaging.Size = new System.Drawing.Size(568, 32);
            this.cmdbatdirstaging.TabIndex = 0;
            // 
            // cmdbatdir
            // 
            this.cmdbatdir.Location = new System.Drawing.Point(16, 167);
            this.cmdbatdir.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmdbatdir.Name = "cmdbatdir";
            this.cmdbatdir.Size = new System.Drawing.Size(568, 32);
            this.cmdbatdir.TabIndex = 0;
            // 
            // CMDDirectorybox
            // 
            this.CMDDirectorybox.Location = new System.Drawing.Point(16, 117);
            this.CMDDirectorybox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CMDDirectorybox.Name = "CMDDirectorybox";
            this.CMDDirectorybox.Size = new System.Drawing.Size(626, 32);
            this.CMDDirectorybox.TabIndex = 0;
            // 
            // serverdirectorytext
            // 
            this.serverdirectorytext.Location = new System.Drawing.Point(18, 42);
            this.serverdirectorytext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.serverdirectorytext.Name = "serverdirectorytext";
            this.serverdirectorytext.Size = new System.Drawing.Size(568, 32);
            this.serverdirectorytext.TabIndex = 0;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label34.Location = new System.Drawing.Point(148, 288);
            this.label34.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(246, 26);
            this.label34.TabIndex = 1;
            this.label34.Text = "serv files directory";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label33.Location = new System.Drawing.Point(172, 87);
            this.label33.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(183, 26);
            this.label33.TabIndex = 1;
            this.label33.Text = "cmd directory";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.maintab);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-8, 42);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(3458, 1890);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage1.Size = new System.Drawing.Size(3442, 1843);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Server Log";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 12);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.12535F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.874652F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1674, 1381);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(6, 6);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox2.MaxLength = 2000;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(1662, 1301);
            this.textBox2.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.button14, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button13, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 1319);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1662, 56);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // button14
            // 
            this.button14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button14.Location = new System.Drawing.Point(1536, 6);
            this.button14.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(120, 44);
            this.button14.TabIndex = 3;
            this.button14.Text = "Clear";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button13.Location = new System.Drawing.Point(6, 6);
            this.button13.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(120, 44);
            this.button13.TabIndex = 2;
            this.button13.Text = "Refresh";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.label41);
            this.tabPage2.Controls.Add(this.label57);
            this.tabPage2.Controls.Add(this.linkLabel1);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label37);
            this.tabPage2.Controls.Add(this.label35);
            this.tabPage2.Controls.Add(this.button17);
            this.tabPage2.Controls.Add(this.label32);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(3442, 1843);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Map File Server";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox5.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox5.Location = new System.Drawing.Point(228, 477);
            this.textBox5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(1222, 542);
            this.textBox5.TabIndex = 22;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(230, 1158);
            this.label41.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(975, 216);
            this.label41.TabIndex = 21;
            this.label41.Text = resources.GetString("label41.Text");
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold);
            this.label57.Location = new System.Drawing.Point(218, 1029);
            this.label57.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(322, 71);
            this.label57.TabIndex = 20;
            this.label57.Text = "MAP URL";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(1274, 427);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(183, 25);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Port Forword Test";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.button18);
            this.groupBox1.Controls.Add(this.button16);
            this.groupBox1.Location = new System.Drawing.Point(230, 265);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(1226, 154);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings:";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = global::RUSS.Properties.Settings.Default.LimitWhite;
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::RUSS.Properties.Settings.Default, "LimitWhite", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox2.Location = new System.Drawing.Point(254, 92);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(320, 29);
            this.checkBox2.TabIndex = 14;
            this.checkBox2.Text = "Limit Downloads To Whitelist";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RUSS.Properties.Settings.Default, "MAPPort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.maskedTextBox1.Location = new System.Drawing.Point(88, 42);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.maskedTextBox1.Mask = "0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(130, 31);
            this.maskedTextBox1.TabIndex = 11;
            this.maskedTextBox1.Text = global::RUSS.Properties.Settings.Default.MAPPort;
            this.maskedTextBox1.Validated += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label31
            // 
            this.label31.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(18, 48);
            this.label31.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(57, 25);
            this.label31.TabIndex = 10;
            this.label31.Text = "Port:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = global::RUSS.Properties.Settings.Default.MAPServer;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::RUSS.Properties.Settings.Default, "MAPServer", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox1.Location = new System.Drawing.Point(254, 48);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(385, 29);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Auto Start/Stop With RustDedicated";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(1010, 37);
            this.button18.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(208, 96);
            this.button18.TabIndex = 9;
            this.button18.Text = "Stop Map Server";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click_1);
            // 
            // button16
            // 
            this.button16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button16.Location = new System.Drawing.Point(728, 37);
            this.button16.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(208, 96);
            this.button16.TabIndex = 8;
            this.button16.Text = "Start Map Server";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click_1);
            // 
            // label37
            // 
            this.label37.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(224, 162);
            this.label37.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(105, 25);
            this.label37.TabIndex = 16;
            this.label37.Text = "MAP File:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold);
            this.label35.Location = new System.Drawing.Point(518, 48);
            this.label35.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(545, 71);
            this.label35.TabIndex = 15;
            this.label35.Text = "MAP File Server";
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(1240, 212);
            this.button17.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(216, 37);
            this.button17.TabIndex = 12;
            this.button17.Text = "Select";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // label32
            // 
            this.label32.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(224, 427);
            this.label32.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(147, 25);
            this.label32.TabIndex = 14;
            this.label32.Text = "Status: Offline";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RUSS.Properties.Settings.Default, "MAPOUTPUTURL", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox4.Location = new System.Drawing.Point(230, 1106);
            this.textBox4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(1222, 31);
            this.textBox4.TabIndex = 19;
            this.textBox4.Text = global::RUSS.Properties.Settings.Default.MAPOUTPUTURL;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RUSS.Properties.Settings.Default, "MapLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox3.Location = new System.Drawing.Point(340, 162);
            this.textBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(1112, 31);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = global::RUSS.Properties.Settings.Default.MapLocation;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // serverup
            // 
            this.serverup.Enabled = true;
            this.serverup.Interval = 2000;
            this.serverup.Tick += new System.EventHandler(this.serverup_Tick);
            // 
            // betaParamsToolStripMenuItem
            // 
            this.betaParamsToolStripMenuItem.Name = "betaParamsToolStripMenuItem";
            this.betaParamsToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.betaParamsToolStripMenuItem.Text = "Beta Params";
            this.betaParamsToolStripMenuItem.Click += new System.EventHandler(this.betaParamsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1680, 1477);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rust Ultimate Server Setup V1.0";
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
            this.BARREN.ResumeLayout(false);
            this.BARREN.PerformLayout();
            this.custom.ResumeLayout(false);
            this.custom.PerformLayout();
            this.Hapis.ResumeLayout(false);
            this.Hapis.PerformLayout();
            this.CRAGGY.ResumeLayout(false);
            this.CRAGGY.PerformLayout();
            this.SAVAS.ResumeLayout(false);
            this.SAVAS.PerformLayout();
            this.KOTH.ResumeLayout(false);
            this.KOTH.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private global::System.ComponentModel.IContainer components = null;

		private global::System.Windows.Forms.Timer checkrun;

		private global::System.Windows.Forms.Timer delay;

		private global::System.Windows.Forms.MenuStrip menuStrip1;

		private global::System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;

		private global::System.Windows.Forms.ToolStripMenuItem videoTutorialsToolStripMenuItem;

		private global::System.Windows.Forms.ToolStripMenuItem fullHostingTutorialsPlaylistToolStripMenuItem;

		private global::System.Windows.Forms.ToolStripMenuItem howToHostYourOwnRustServerManuallyToolStripMenuItem;

		private global::System.Windows.Forms.ToolStripMenuItem howToInstallOxideWorkWithPluginsToolStripMenuItem;

		private global::System.Windows.Forms.ToolStripMenuItem howToPortForwardToolStripMenuItem;

		private global::System.Windows.Forms.ToolStripMenuItem pluginsToolStripMenuItem;

		private global::System.Windows.Forms.ToolStripMenuItem mainSiteToolStripMenuItem;

		private global::System.Windows.Forms.ToolStripMenuItem browseFreePluginsToolStripMenuItem;

		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem11;

		private global::System.Windows.Forms.ToolStripMenuItem downloadOxideToolStripMenuItem;

		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem18;

		private global::System.Windows.Forms.ImageList imageList1;

		private global::System.Windows.Forms.TabPage maintab;

		private global::System.Windows.Forms.ProgressBar progressBar2;

		private global::System.Windows.Forms.Button button9;

		private global::System.Windows.Forms.Panel panel4;

		private global::System.Windows.Forms.Label label81;

		private global::System.Windows.Forms.Label label80;

		private global::System.Windows.Forms.Label label78;

		private global::System.Windows.Forms.TextBox test;

		private global::System.Windows.Forms.TextBox parametersbox;

		private global::System.Windows.Forms.TextBox deditextbox;

		private global::System.Windows.Forms.TextBox loglog;

		private global::System.Windows.Forms.TextBox quibox;

		private global::System.Windows.Forms.TextBox slashbox;

		private global::System.Windows.Forms.TextBox steamcmdbox;

		private global::System.Windows.Forms.TextBox serbat;

		private global::System.Windows.Forms.TextBox Finaltext;

		private global::System.Windows.Forms.Button button2;

		private global::System.Windows.Forms.Panel panel5;

		private global::System.Windows.Forms.Label infolabel;

		private global::System.Windows.Forms.Label label47;

		private global::System.Windows.Forms.Button button1;

		private global::System.Windows.Forms.Panel panel3;

		private global::System.Windows.Forms.Label label29;

		private global::System.Windows.Forms.ProgressBar progressBar1;

		private global::System.Windows.Forms.Button steamcmdIns;

		private global::System.Windows.Forms.TabControl da;

		private global::System.Windows.Forms.TabPage procgen;

		private global::System.Windows.Forms.Button genbtn;

		private global::System.Windows.Forms.TextBox mapseedtext;

		private global::System.Windows.Forms.TextBox mapsizebox;

		private global::System.Windows.Forms.TextBox maxplayertext;

		private global::System.Windows.Forms.TextBox serverdisctext;

		private global::System.Windows.Forms.TextBox serverurltext;

		private global::System.Windows.Forms.TextBox serverpicturetext;

		private global::System.Windows.Forms.TextBox rconpasstext;

		private global::System.Windows.Forms.TextBox rconporttext;

		private global::System.Windows.Forms.TextBox serverporttext;

		private global::System.Windows.Forms.TextBox servernametext;

		private global::System.Windows.Forms.TextBox identitytext;

		private global::System.Windows.Forms.Label label13;

		private global::System.Windows.Forms.Label label12;

		private global::System.Windows.Forms.Label label11;

		private global::System.Windows.Forms.Label label10;

		private global::System.Windows.Forms.Label label9;

		private global::System.Windows.Forms.Label label8;

		private global::System.Windows.Forms.Label label6;

		private global::System.Windows.Forms.Label label5;

		private global::System.Windows.Forms.Label label4;

		private global::System.Windows.Forms.Label label3;

		private global::System.Windows.Forms.Label label2;

		private global::System.Windows.Forms.Label label1;

		private global::System.Windows.Forms.TabPage custom;

		private global::System.Windows.Forms.Button BTNbatchCustom;

		private global::System.Windows.Forms.TextBox mapurlbox;

		private global::System.Windows.Forms.TextBox CMmaxplayertext;

		private global::System.Windows.Forms.TextBox CMserverdisctext;

		private global::System.Windows.Forms.TextBox CMserverurltext;

		private global::System.Windows.Forms.TextBox CMserverpicturetext;

		private global::System.Windows.Forms.TextBox CMrconpasstext;

		private global::System.Windows.Forms.TextBox CMrconporttext;

		private global::System.Windows.Forms.TextBox CMserverportext;

		private global::System.Windows.Forms.TextBox CMservernametext;

		private global::System.Windows.Forms.TextBox CMidentitytext;

		private global::System.Windows.Forms.Label label16;

		private global::System.Windows.Forms.Label label18;

		private global::System.Windows.Forms.Label label19;

		private global::System.Windows.Forms.Label label20;

		private global::System.Windows.Forms.Label label21;

		private global::System.Windows.Forms.Label label22;

		private global::System.Windows.Forms.Label label23;

		private global::System.Windows.Forms.Label label24;

		private global::System.Windows.Forms.Label label25;

		private global::System.Windows.Forms.Label label26;

		private global::System.Windows.Forms.Label label27;

		private global::System.Windows.Forms.TabPage Hapis;

		private global::System.Windows.Forms.TextBox HAidentitytext;

		private global::System.Windows.Forms.Label label7;

		private global::System.Windows.Forms.Button button3;

		private global::System.Windows.Forms.TextBox HPmaxplayertext;

		private global::System.Windows.Forms.TextBox HPserverdisctext;

		private global::System.Windows.Forms.TextBox HPserverurltext;

		private global::System.Windows.Forms.TextBox HPserverpicturetext;

		private global::System.Windows.Forms.TextBox HPrconpasstext;

		private global::System.Windows.Forms.TextBox HPrconporttext;

		private global::System.Windows.Forms.TextBox HPserverportext;

		private global::System.Windows.Forms.TextBox HPservernametext;

		private global::System.Windows.Forms.Label label45;

		private global::System.Windows.Forms.Label label46;

		private global::System.Windows.Forms.Label label49;

		private global::System.Windows.Forms.Label label50;

		private global::System.Windows.Forms.Label label51;

		private global::System.Windows.Forms.Label label52;

		private global::System.Windows.Forms.Label label53;

		private global::System.Windows.Forms.Label label54;

		private global::System.Windows.Forms.Label label56;

		private global::System.Windows.Forms.TabPage BARREN;

		private global::System.Windows.Forms.TextBox BAidentitytext;

		private global::System.Windows.Forms.Label label15;

		private global::System.Windows.Forms.TextBox BAmapseedtext;

		private global::System.Windows.Forms.TextBox BAmapsizebox;

		private global::System.Windows.Forms.TextBox BAmaxplayertext;

		private global::System.Windows.Forms.TextBox BAserverdisctext;

		private global::System.Windows.Forms.TextBox BAserverurltext;

		private global::System.Windows.Forms.TextBox BAserverpicturetext;

		private global::System.Windows.Forms.TextBox BArconpasstext;

		private global::System.Windows.Forms.TextBox BArconporttext;

		private global::System.Windows.Forms.TextBox BAserverportext;

		private global::System.Windows.Forms.TextBox BAservernametext;

		private global::System.Windows.Forms.Label label44;

		private global::System.Windows.Forms.Label label55;

		private global::System.Windows.Forms.Label label58;

		private global::System.Windows.Forms.Label label59;

		private global::System.Windows.Forms.Label label60;

		private global::System.Windows.Forms.Label label61;

		private global::System.Windows.Forms.Label label62;

		private global::System.Windows.Forms.Label label63;

		private global::System.Windows.Forms.Label label64;

		private global::System.Windows.Forms.Label label65;

		private global::System.Windows.Forms.Label label67;

		private global::System.Windows.Forms.TabPage CRAGGY;

		private global::System.Windows.Forms.TextBox CRidentitytext;

		private global::System.Windows.Forms.Label label36;

		private global::System.Windows.Forms.Button button5;

		private global::System.Windows.Forms.TextBox CRmaxplayertext;

		private global::System.Windows.Forms.TextBox CRserverdisctext;

		private global::System.Windows.Forms.TextBox CRserverurltext;

		private global::System.Windows.Forms.TextBox CRserverpicturetext;

		private global::System.Windows.Forms.TextBox CRrconpasstext;

		private global::System.Windows.Forms.TextBox CRrconporttext;

		private global::System.Windows.Forms.TextBox CRserverportext;

		private global::System.Windows.Forms.TextBox CRservernametext;

		private global::System.Windows.Forms.Label label69;

		private global::System.Windows.Forms.Label label70;

		private global::System.Windows.Forms.Label label71;

		private global::System.Windows.Forms.Label label72;

		private global::System.Windows.Forms.Label label73;

		private global::System.Windows.Forms.Label label74;

		private global::System.Windows.Forms.Label label75;

		private global::System.Windows.Forms.Label label76;

		private global::System.Windows.Forms.Label label77;

		private global::System.Windows.Forms.TabPage SAVAS;

		private global::System.Windows.Forms.TextBox SAidentitytext;

		private global::System.Windows.Forms.Label label39;

		private global::System.Windows.Forms.Button button7;

		private global::System.Windows.Forms.TextBox SAmaxplayertext;

		private global::System.Windows.Forms.TextBox SAserverdisctext;

		private global::System.Windows.Forms.TextBox SAserverurltext;

		private global::System.Windows.Forms.TextBox SAserverpicturetext;

		private global::System.Windows.Forms.TextBox SArconpasstext;

		private global::System.Windows.Forms.TextBox SArconporttext;

		private global::System.Windows.Forms.TextBox SAserverportext;

		private global::System.Windows.Forms.TextBox SAservernametext;

		private global::System.Windows.Forms.Label label84;

		private global::System.Windows.Forms.Label label85;

		private global::System.Windows.Forms.Label label86;

		private global::System.Windows.Forms.Label label87;

		private global::System.Windows.Forms.Label label88;

		private global::System.Windows.Forms.Label label89;

		private global::System.Windows.Forms.Label label90;

		private global::System.Windows.Forms.Label label91;

		private global::System.Windows.Forms.Label label92;

		private global::System.Windows.Forms.TabPage KOTH;

		private global::System.Windows.Forms.TextBox KOidentitytext;

		private global::System.Windows.Forms.Label label40;

		private global::System.Windows.Forms.Button button8;

		private global::System.Windows.Forms.TextBox KOmaxplayertext;

		private global::System.Windows.Forms.TextBox KOserverdisctext;

		private global::System.Windows.Forms.TextBox KOserverurltext;

		private global::System.Windows.Forms.TextBox KOserverpicturetext;

		private global::System.Windows.Forms.TextBox KOrconpasstext;

		private global::System.Windows.Forms.TextBox KOrconporttext;

		private global::System.Windows.Forms.TextBox KOserverportext;

		private global::System.Windows.Forms.TextBox KOservernametext;

		private global::System.Windows.Forms.Label label95;

		private global::System.Windows.Forms.Label label96;

		private global::System.Windows.Forms.Label label97;

		private global::System.Windows.Forms.Label label98;

		private global::System.Windows.Forms.Label label99;

		private global::System.Windows.Forms.Label label100;

		private global::System.Windows.Forms.Label label101;

		private global::System.Windows.Forms.Label label102;

		private global::System.Windows.Forms.Label label103;

		private global::System.Windows.Forms.Panel panel1;

		private global::System.Windows.Forms.Label label14;

		private global::System.Windows.Forms.TextBox LogLocation;

		private global::System.Windows.Forms.TextBox dedicateddirectory;

		private global::System.Windows.Forms.TextBox servfilesdirectory;

		private global::System.Windows.Forms.TextBox cmdbatdir;

		private global::System.Windows.Forms.TextBox CMDDirectorybox;

		private global::System.Windows.Forms.TextBox serverdirectorytext;

		private global::System.Windows.Forms.Label label34;

		private global::System.Windows.Forms.Label label33;

		private global::System.Windows.Forms.TabControl tabControl1;

		private global::System.Windows.Forms.Button button10;

		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem25;

		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem28;

		private global::System.Windows.Forms.ToolStripMenuItem mostBeginnerMistakesQuestionsToolStripMenuItem;

		private global::System.Windows.Forms.Panel panel9;

		private global::System.Windows.Forms.PictureBox PreviewPic;

		private global::System.Windows.Forms.PictureBox BannerServer;

		private global::System.Windows.Forms.Label serverTitle;

		private global::System.Windows.Forms.Label label42;

		private global::System.Windows.Forms.Label label38;

		private global::System.Windows.Forms.Label mapTypeprev;

		private global::System.Windows.Forms.Label MaxPlayersPrev;

		private global::System.Windows.Forms.Label FakeMS;

		private global::System.Windows.Forms.Label label43;

		private global::System.Windows.Forms.PictureBox mapPic;

		private global::System.Windows.Forms.Panel panel12;

		private global::System.Windows.Forms.Label label68;

		private global::System.Windows.Forms.Button BtnStart;

		private global::System.Windows.Forms.ComboBox StartFileList;

		private global::System.Windows.Forms.Panel panel13;

		private global::System.Windows.Forms.Button button11;

		private global::System.Windows.Forms.Button BtnRefreshbrowser;

		private global::System.Windows.Forms.Button BtnViewPage;

		private global::System.Windows.Forms.Label PreviewDesc;

		private global::System.Windows.Forms.Label label83;

		private global::System.Windows.Forms.Label mapinfolab;

		private global::System.Windows.Forms.TextBox textBox1;

		private global::System.Windows.Forms.RadioButton RdioStaging;

		private global::System.Windows.Forms.RadioButton RdioNormal;

		private global::System.Windows.Forms.TextBox cmdbatdirstaging;

		private global::System.Windows.Forms.Button RefreshSmall;

	    private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem29;

		private global::System.Windows.Forms.TextBox ServerVarsFinal;

		private global::System.Windows.Forms.ToolStripMenuItem serverOptionsToolStripMenuItem;

		private global::System.Windows.Forms.ToolStripMenuItem updateServerToolStripMenuItem;

		private global::System.Windows.Forms.DataGridView ServerVars;

		private global::System.Windows.Forms.Button BtnCLLearVars;

		private global::System.Windows.Forms.Button button12;

		private global::System.Windows.Forms.Button BtnCompleteVars;

		private global::System.Windows.Forms.Panel panel2;

		private global::System.Windows.Forms.Panel panel6;

		private global::System.Windows.Forms.Button BTNadd;

		private global::System.Windows.Forms.Button btnclear;

		private global::System.Windows.Forms.TextBox varvalue;

		private global::System.Windows.Forms.TextBox varvar;

		private global::System.Windows.Forms.Label label30;

		private global::System.Windows.Forms.Label label28;

		private global::System.Windows.Forms.Label label17;

		private global::System.Windows.Forms.Panel panel7;

		private global::System.Windows.Forms.Button button6;

		private global::System.Windows.Forms.Label label48;

		private global::System.Windows.Forms.TextBox SearchVar;

		private global::System.Windows.Forms.DataGridViewTextBoxColumn Variable;

		private global::System.Windows.Forms.DataGridViewTextBoxColumn Value;

		private global::System.Windows.Forms.Label LockedLbl;

		private global::System.Windows.Forms.Label LockedLbl2;

		private global::System.Windows.Forms.TextBox hasspace;

		private global::System.Windows.Forms.TextBox CheckDll;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wipeServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wipeMapOnlyToolStripMenuItem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem fILELOCATIONSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startFileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateFileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem serverFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSSRFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem steamCMDFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem installUmodToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem browseMapsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem pluginManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setRconIPToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Timer serverup;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem resetSettingsToolStripMenuItem;
        public System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ToolStripMenuItem writtenGuidesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToHostYourOwnRustDedicatedServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToHostARustServerInLinuxToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem15;
        private System.Windows.Forms.ToolStripMenuItem hostARustDedicatedServerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem populateYourRustServerWithThese6TipsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem howToCreateAPrivateRustServerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem howToInstallUmodOxideToAServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rustServerPerformanceTipsAndTricksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rustAdminRconControlPlayerManagmentServerStatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rustEditCreateAndEditMapsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fortifyCreateAndDesignBasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem betaParamsToolStripMenuItem;
    }
}
