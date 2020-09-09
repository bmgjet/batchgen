namespace batchgen
{
	// Token: 0x02000003 RID: 3
	public partial class AddVarForm : global::System.Windows.Forms.Form
	{
		// Token: 0x060000C3 RID: 195 RVA: 0x0001CAC0 File Offset: 0x0001ACC0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0001CAF8 File Offset: 0x0001ACF8
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddVarForm));
            this.varvar = new System.Windows.Forms.TextBox();
            this.varvalue = new System.Windows.Forms.TextBox();
            this.BTNadd = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchVar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.ServerVars = new System.Windows.Forms.DataGridView();
            this.Variable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchVarBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.VarInfoLab = new System.Windows.Forms.Label();
            this.BtnCompleteVars = new System.Windows.Forms.Button();
            this.BtnListVarsSite = new System.Windows.Forms.Button();
            this.BtnCLLearVars = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServerVars)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // varvar
            // 
            this.varvar.Location = new System.Drawing.Point(5, 61);
            this.varvar.Name = "varvar";
            this.varvar.Size = new System.Drawing.Size(270, 20);
            this.varvar.TabIndex = 0;
            // 
            // varvalue
            // 
            this.varvalue.Location = new System.Drawing.Point(281, 61);
            this.varvalue.Name = "varvalue";
            this.varvalue.Size = new System.Drawing.Size(156, 20);
            this.varvalue.TabIndex = 0;
            // 
            // BTNadd
            // 
            this.BTNadd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNadd.Location = new System.Drawing.Point(281, 87);
            this.BTNadd.Name = "BTNadd";
            this.BTNadd.Size = new System.Drawing.Size(75, 23);
            this.BTNadd.TabIndex = 1;
            this.BTNadd.Text = "ADD";
            this.BTNadd.UseVisualStyleBackColor = true;
            this.BTNadd.Click += new System.EventHandler(this.BTNadd_Click);
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(362, 87);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 1;
            this.btncancel.Text = "CANCEL";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.Btncancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(5, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "VARIABLE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(278, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "VALUE:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(5, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Example: server.radiation True";
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
            this.SearchVar.Location = new System.Drawing.Point(1, 33);
            this.SearchVar.Name = "SearchVar";
            this.SearchVar.Size = new System.Drawing.Size(270, 20);
            this.SearchVar.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Above";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.varvar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.varvalue);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BTNadd);
            this.panel1.Controls.Add(this.btncancel);
            this.panel1.Location = new System.Drawing.Point(2, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 116);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(2, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(439, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "ADD SERVER VARIABLE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.SearchVar);
            this.panel2.Location = new System.Drawing.Point(2, 340);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 64);
            this.panel2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(0, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(439, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "SEARCH SERVER VARIABLE";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServerVars
            // 
            this.ServerVars.AllowUserToAddRows = false;
            this.ServerVars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ServerVars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServerVars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Variable,
            this.Value});
            this.ServerVars.Location = new System.Drawing.Point(2, 2);
            this.ServerVars.Name = "ServerVars";
            this.ServerVars.Size = new System.Drawing.Size(443, 170);
            this.ServerVars.TabIndex = 6;
            // 
            // Variable
            // 
            this.Variable.HeaderText = "Variable";
            this.Variable.Name = "Variable";
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            // 
            // SearchVarBox
            // 
            this.SearchVarBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SearchVarBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SearchVarBox.Location = new System.Drawing.Point(3, 54);
            this.SearchVarBox.Name = "SearchVarBox";
            this.SearchVarBox.Size = new System.Drawing.Size(270, 20);
            this.SearchVarBox.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Indigo;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.VarInfoLab);
            this.panel3.Location = new System.Drawing.Point(2, 430);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(443, 132);
            this.panel3.TabIndex = 7;
            // 
            // VarInfoLab
            // 
            this.VarInfoLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VarInfoLab.ForeColor = System.Drawing.SystemColors.Control;
            this.VarInfoLab.Location = new System.Drawing.Point(-2, 0);
            this.VarInfoLab.Name = "VarInfoLab";
            this.VarInfoLab.Size = new System.Drawing.Size(441, 130);
            this.VarInfoLab.TabIndex = 0;
            this.VarInfoLab.Text = "Information about the server Vars will be displayed here.";
            this.VarInfoLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnCompleteVars
            // 
            this.BtnCompleteVars.Location = new System.Drawing.Point(2, 178);
            this.BtnCompleteVars.Name = "BtnCompleteVars";
            this.BtnCompleteVars.Size = new System.Drawing.Size(75, 33);
            this.BtnCompleteVars.TabIndex = 8;
            this.BtnCompleteVars.Text = "COMPLETE";
            this.BtnCompleteVars.UseVisualStyleBackColor = true;
            this.BtnCompleteVars.Click += new System.EventHandler(this.BtnCompleteVars_Click);
            // 
            // BtnListVarsSite
            // 
            this.BtnListVarsSite.Location = new System.Drawing.Point(160, 179);
            this.BtnListVarsSite.Name = "BtnListVarsSite";
            this.BtnListVarsSite.Size = new System.Drawing.Size(119, 33);
            this.BtnListVarsSite.TabIndex = 8;
            this.BtnListVarsSite.Text = "Open Full Var List";
            this.BtnListVarsSite.UseVisualStyleBackColor = true;
            this.BtnListVarsSite.Click += new System.EventHandler(this.BtnClearVars_Click);
            // 
            // BtnCLLearVars
            // 
            this.BtnCLLearVars.Location = new System.Drawing.Point(368, 178);
            this.BtnCLLearVars.Name = "BtnCLLearVars";
            this.BtnCLLearVars.Size = new System.Drawing.Size(75, 33);
            this.BtnCLLearVars.TabIndex = 8;
            this.BtnCLLearVars.Text = "CLEAR";
            this.BtnCLLearVars.UseVisualStyleBackColor = true;
            this.BtnCLLearVars.Click += new System.EventHandler(this.Button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(492, 64);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 193);
            this.textBox1.TabIndex = 9;
            // 
            // AddVarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(890, 565);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnCLLearVars);
            this.Controls.Add(this.BtnCompleteVars);
            this.Controls.Add(this.BtnListVarsSite);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ServerVars);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddVarForm";
            this.Text = "Add Custom Server Variable";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServerVars)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x0400017D RID: 381
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400017E RID: 382
		private global::System.Windows.Forms.TextBox varvar;

		// Token: 0x0400017F RID: 383
		private global::System.Windows.Forms.TextBox varvalue;

		// Token: 0x04000180 RID: 384
		private global::System.Windows.Forms.Button BTNadd;

		// Token: 0x04000181 RID: 385
		private global::System.Windows.Forms.Button btncancel;

		// Token: 0x04000182 RID: 386
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000183 RID: 387
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000184 RID: 388
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000185 RID: 389
		private global::System.Windows.Forms.TextBox SearchVar;

		// Token: 0x04000186 RID: 390
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000187 RID: 391
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000188 RID: 392
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000189 RID: 393
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x0400018A RID: 394
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400018B RID: 395
		private global::System.Windows.Forms.DataGridView ServerVars;

		// Token: 0x0400018C RID: 396
		private global::System.Windows.Forms.TextBox SearchVarBox;

		// Token: 0x0400018D RID: 397
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Variable;

		// Token: 0x0400018E RID: 398
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Value;

		// Token: 0x0400018F RID: 399
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x04000190 RID: 400
		private global::System.Windows.Forms.Label VarInfoLab;

		// Token: 0x04000191 RID: 401
		private global::System.Windows.Forms.Button BtnCompleteVars;

		// Token: 0x04000192 RID: 402
		private global::System.Windows.Forms.Button BtnListVarsSite;

		// Token: 0x04000193 RID: 403
		private global::System.Windows.Forms.Button BtnCLLearVars;

		// Token: 0x04000194 RID: 404
		private global::System.Windows.Forms.TextBox textBox1;
	}
}
