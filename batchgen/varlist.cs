namespace RUSS
{
	class varlist
	{
		public static string[] servervars(string SearchVar)
		{
			string varvar = "";
			string varvalue = "";
			switch(SearchVar)
            {
				case "rcon.web":
					varvar = "rcon.web";
					varvalue = "1";
					break;
				case "aithinkmanager.framebudgetms":
					varvar = "aithinkmanager.framebudgetms";
					varvalue = "2.5";
					break;
				case "generate_paths":
					varvar = "generate_paths";
					varvalue = "True";
					break;
				case "decayminutes":
					varvar = "decayminutes";
					varvalue = "180";
					break;
				case "bear.population":
					varvar = "bear.population";
					varvalue = "2";
					break;
				case "spinfrequencyseconds":
					varvar = "spinfrequencyseconds";
					varvalue = "45";
					break;
				case "boar.population":
					varvar = "boar.population";
					varvalue = "5";
					break;
				case "egress_duration_minutes":
					varvar = "egress_duration_minutes";
					varvalue = "10";
					break;
				case "event_duration_minutes":
					varvar = "event_duration_minutes";
					varvalue = "50";
					break;
				case "event_enabled":
					varvar = "event_enabled";
					varvalue = "True";
					break;
				case "loot_round_spacing_minutes":
					varvar = "loot_round_spacing_minutes";
					varvalue = "10";
					break;
				case "loot_rounds":
					varvar = "loot_rounds";
					varvalue = "3";
					break;
				case "chicken.population":
					varvar = "chicken.population";
					varvalue = "3";
					break;
				case "clothloddist":
					varvar = "clothloddist";
					varvalue = "20";
					break;
				case "nav_carve_height":
					varvar = "nav_carve_height";
					varvalue = "2";
					break;
				case "nav_carve_min_base_size":
					varvar = "nav_carve_min_base_size";
					varvalue = "2";
					break;
				case "nav_carve_min_building_blocks_to_apply_optimization":
					varvar = "nav_carve_min_building_blocks_to_apply_optimization";
					varvalue = "25";
					break;
				case "nav_carve_size_multiplier":
					varvar = "nav_carve_size_multiplier";
					varvalue = "4";
					break;
				case "nav_carve_use_building_optimization":
					varvar = "nav_carve_use_building_optimization";
					varvalue = "False";
					break;
				case "npc_alertness_drain_rate":
					varvar = "npc_alertness_drain_rate";
					varvalue = "0.01";
					break;
				case "npc_alertness_to_aim_modifier":
					varvar = "npc_alertness_to_aim_modifier";
					varvalue = "0.5";
					break;
				case "npc_alertness_zero_detection_mod":
					varvar = "npc_alertness_zero_detection_mod";
					varvalue = "0.5";
					break;
				case "npc_cover_compromised_cooldown":
					varvar = "npc_cover_compromised_cooldown";
					varvalue = "10";
					break;
				case "npc_cover_info_tick_rate_multiplier":
					varvar = "npc_cover_info_tick_rate_multiplier";
					varvalue = "20";
					break;
				case "npc_cover_path_vs_straight_dist_max_diff":
					varvar = "npc_cover_path_vs_straight_dist_max_diff";
					varvalue = "2";
					break;
				case "npc_cover_use_path_distance":
					varvar = "npc_cover_use_path_distance";
					varvalue = "True";
					break;
				case "npc_deliberate_hit_randomizer":
					varvar = "npc_deliberate_hit_randomizer";
					varvalue = "0.85";
					break;
				case "npc_deliberate_miss_offset_multiplier":
					varvar = "npc_deliberate_miss_offset_multiplier";
					varvalue = "1.25";
					break;
				case "npc_deliberate_miss_to_hit_alignment_time":
					varvar = "npc_deliberate_miss_to_hit_alignment_time";
					varvalue = "1.5";
					break;
				case "npc_door_trigger_size":
					varvar = "npc_door_trigger_size";
					varvalue = "1.5";
					break;
				case "npc_enable":
					varvar = "npc_enable";
					varvalue = "True";
					break;
				case "npc_families_no_hurt":
					varvar = "npc_families_no_hurt";
					varvalue = "True";
					break;
				case "npc_gun_noise_silencer_modifier":
					varvar = "npc_gun_noise_silencer_modifier";
					varvalue = "0.15";
					break;
				case "npc_htn_player_base_damage_modifier":
					varvar = "npc_htn_player_base_damage_modifier";
					varvalue = "1.15";
					break;
				case "npc_htn_player_frustration_threshold":
					varvar = "npc_htn_player_frustration_threshold";
					varvalue = "3";
					break;
				case "npc_ignore_chairs":
					varvar = "npc_ignore_chairs";
					varvalue = "True";
					break;
				case "npc_junkpile_a_spawn_chance":
					varvar = "npc_junkpile_a_spawn_chance";
					varvalue = "0.1";
					break;
				case "npc_junkpile_dist_aggro_gate":
					varvar = "npc_junkpile_dist_aggro_gate";
					varvalue = "8";
					break;
				case "npc_junkpile_g_spawn_chance":
					varvar = "npc_junkpile_g_spawn_chance";
					varvalue = "0.1";
					break;
				case "npc_max_junkpile_count":
					varvar = "npc_max_junkpile_count";
					varvalue = "30";
					break;
				case "npc_max_population_military_tunnels":
					varvar = "npc_max_population_military_tunnels";
					varvalue = "3";
					break;
				case "npc_max_roam_multiplier":
					varvar = "npc_max_roam_multiplier";
					varvalue = "3";
					break;
				case "npc_only_hurt_active_target_in_safezone":
					varvar = "npc_only_hurt_active_target_in_safezone";
					varvalue = "True";
					break;
				case "npc_patrol_point_cooldown":
					varvar = "npc_patrol_point_cooldown";
					varvalue = "5";
					break;
				case "npc_reasoning_system_tick_rate_multiplier":
					varvar = "npc_reasoning_system_tick_rate_multiplier";
					varvalue = "1";
					break;
				case "npc_respawn_delay_max_military_tunnels":
					varvar = "npc_respawn_delay_max_military_tunnels";
					varvalue = "1920";
					break;
				case "npc_respawn_delay_min_military_tunnels":
					varvar = "npc_respawn_delay_min_military_tunnels";
					varvalue = "480";
					break;
				case "npc_sensory_system_tick_rate_multiplier":
					varvar = "npc_sensory_system_tick_rate_multiplier";
					varvalue = "5";
					break;
				case "npc_spawn_on_cargo_ship":
					varvar = "npc_spawn_on_cargo_ship";
					varvalue = "True";
					break;
				case "npc_spawn_per_tick_max_military_tunnels":
					varvar = "npc_spawn_per_tick_max_military_tunnels";
					varvalue = "1";
					break;
				case "npc_spawn_per_tick_min_military_tunnels":
					varvar = "npc_spawn_per_tick_min_military_tunnels";
					varvalue = "1";
					break;
				case "npc_speed_crouch_run":
					varvar = "npc_speed_crouch_run";
					varvalue = "0.25";
					break;
				case "npc_speed_crouch_walk":
					varvar = "npc_speed_crouch_walk";
					varvalue = "0.1";
					break;
				case "npc_speed_run":
					varvar = "npc_speed_run";
					varvalue = "0.4";
					break;
				case "npc_speed_sprint":
					varvar = "npc_speed_sprint";
					varvalue = "1";
					break;
				case "npc_speed_walk":
					varvar = "npc_speed_walk";
					varvalue = "0.18";
					break;
				case "npc_use_new_aim_system":
					varvar = "npc_use_new_aim_system";
					varvalue = "True";
					break;
				case "npc_use_thrown_weapons":
					varvar = "npc_use_thrown_weapons";
					varvalue = "True";
					break;
				case "npc_valid_aim_cone":
					varvar = "npc_valid_aim_cone";
					varvalue = "0.8";
					break;
				case "npc_valid_mounted_aim_cone":
					varvar = "npc_valid_mounted_aim_cone";
					varvalue = "0.92";
					break;
				case "ocean_patrol_path_iterations":
					varvar = "ocean_patrol_path_iterations";
					varvalue = "100000";
					break;
				case "think":
					varvar = "think";
					varvalue = "True";
					break;
				case "sensetime":
					varvar = "sensetime";
					varvalue = "1";
					break;
				case "ai.tickrate":
					varvar = "ai.tickrate";
					varvalue = "5";
					break;
				case "admincheat":
					varvar = "admincheat";
					varvalue = "True";
					break;
				case "debuglevel":
					varvar = "debuglevel";
					varvalue = "1";
					break;
				case "enforcementlevel":
					varvar = "enforcementlevel";
					varvalue = "1";
					break;
				case "eye_clientframes":
					varvar = "eye_clientframes";
					varvalue = "2";
					break;
				case "eye_forgiveness":
					varvar = "eye_forgiveness";
					varvalue = "0.5";
					break;
				case "eye_penalty":
					varvar = "eye_penalty";
					varvalue = "0";
					break;
				case "eye_protection":
					varvar = "eye_protection";
					varvalue = "2";
					break;
				case "eye_serverframes":
					varvar = "eye_serverframes";
					varvalue = "2";
					break;
				case "flyhack_extrusion":
					varvar = "flyhack_extrusion";
					varvalue = "2";
					break;
				case "flyhack_forgiveness_horizontal":
					varvar = "flyhack_forgiveness_horizontal";
					varvalue = "2015";
					break;
				case "flyhack_forgiveness_vertical":
					varvar = "flyhack_forgiveness_vertical";
					varvalue = "1.5";
					break;
				case "flyhack_margin":
					varvar = "flyhack_margin";
					varvalue = "0.05";
					break;
				case "flyhack_maxsteps":
					varvar = "flyhack_maxsteps";
					varvalue = "15";
					break;
				case "flyhack_penalty":
					varvar = "flyhack_penalty";
					varvalue = "100";
					break;
				case "flyhack_protection":
					varvar = "flyhack_protection";
					varvalue = "3";
					break;
				case "flyhack_reject":
					varvar = "flyhack_reject";
					varvalue = "False";
					break;
				case "flyhack_stepsize":
					varvar = "flyhack_stepsize";
					varvalue = "0.1";
					break;
				case "forceposition":
					varvar = "forceposition";
					varvalue = "True";
					break;
				case "maxdeltatime":
					varvar = "maxdeltatime";
					varvalue = "1";
					break;
				case "maxdesync":
					varvar = "maxdesync";
					varvalue = "1";
					break;
				case "maxviolation":
					varvar = "maxviolation";
					varvalue = "100";
					break;
				case "melee_clientframes":
					varvar = "melee_clientframes";
					varvalue = "2";
					break;
				case "melee_forgiveness":
					varvar = "melee_forgiveness";
					varvalue = "0.5";
					break;
				case "melee_penalty":
					varvar = "melee_penalty";
					varvalue = "0";
					break;
				case "melee_protection":
					varvar = "melee_protection";
					varvalue = "3";
					break;
				case "melee_serverframes":
					varvar = "melee_serverframes";
					varvalue = "2";
					break;
				case "modelstate":
					varvar = "modelstate";
					varvalue = "True";
					break;
				case "noclip_backtracking":
					varvar = "noclip_backtracking";
					varvalue = "0.01";
					break;
				case "noclip_margin":
					varvar = "noclip_margin";
					varvalue = "0.09";
					break;
				case "noclip_maxsteps":
					varvar = "noclip_maxsteps";
					varvalue = "15";
					break;
				case "noclip_penalty":
					varvar = "noclip_penalty";
					varvalue = "0";
					break;
				case "noclip_protection":
					varvar = "noclip_protection";
					varvalue = "3";
					break;
				case "noclip_reject":
					varvar = "noclip_reject";
					varvalue = "True";
					break;
				case "noclip_stepsize":
					varvar = "noclip_stepsize";
					varvalue = "0.1";
					break;
				case "objectplacement":
					varvar = "objectplacement";
					varvalue = "True";
					break;
				case "projectile_clientframes":
					varvar = "projectile_clientframes";
					varvalue = "2";
					break;
				case "projectile_forgiveness":
					varvar = "projectile_forgiveness";
					varvalue = "0.5";
					break;
				case "projectile_penalty":
					varvar = "projectile_penalty";
					varvalue = "0";
					break;
				case "projectile_protection":
					varvar = "projectile_protection";
					varvalue = "5";
					break;
				case "projectile_serverframes":
					varvar = "projectile_serverframes";
					varvalue = "2";
					break;
				case "projectile_trajectory_horizontal":
					varvar = "projectile_trajectory_horizontal";
					varvalue = "1";
					break;
				case "projectile_trajectory_vertical":
					varvar = "projectile_trajectory_vertical";
					varvalue = "1";
					break;
				case "relaxationpause":
					varvar = "relaxationpause";
					varvalue = "10";
					break;
				case "relaxationrate":
					varvar = "relaxationrate";
					varvalue = "0.1";
					break;
				case "speedhack_forgiveness":
					varvar = "speedhack_forgiveness";
					varvalue = "2";
					break;
				case "speedhack_penalty":
					varvar = "speedhack_penalty";
					varvalue = "0";
					break;
				case "speedhack_protection":
					varvar = "speedhack_protection";
					varvalue = "2";
					break;
				case "speedhack_reject":
					varvar = "speedhack_reject";
					varvalue = "True";
					break;
				case "speedhack_slopespeed":
					varvar = "speedhack_slopespeed";
					varvalue = "10";
					break;
				case "userlevel":
					varvar = "userlevel";
					varvalue = "2";
					break;
				case "batching.verbose":
					varvar = "batching.verbose";
					varvalue = "0";
					break;
				case "bradley.enabled":
					varvar = "bradley.enabled";
					varvalue = "True";
					break;
				case "respawndelayminutes":
					varvar = "respawndelayminutes";
					varvalue = "60";
					break;
				case "respawndelayvariance":
					varvar = "respawndelayvariance";
					varvalue = "1";
					break;
				case "chat.enabled":
					varvar = "chat.enabled";
					varvalue = "True";
					break;
				case "cserverlog":
					varvar = "serverlog";
					varvalue = "True";
					break;
				case "frameminutes":
					varvar = "frameminutes";
					varvalue = "30";
					break;
				case "instant":
					varvar = "instant";
					varvalue = "False";
					break;
				case "callbacks":
					varvar = "callbacks";
					varvalue = "False";
					break;
				case "checktriggers":
					varvar = "checktriggers";
					varvalue = "False";
					break;
				case "disablecondition":
					varvar = "disablecondition";
					varvalue = "False";
					break;
				case "bracket_0_blockcount":
					varvar = "bracket_0_blockcount";
					varvalue = "15";
					break;
				case "bracket_0_costfraction":
					varvar = "bracket_0_costfraction";
					varvalue = "0.1";
					break;
				case "bracket_1_blockcount":
					varvar = "bracket_1_blockcount";
					varvalue = "50";
					break;
				case "bracket_1_costfraction":
					varvar = "bracket_1_costfraction";
					varvalue = "0.15";
					break;
				case "bracket_2_blockcount":
					varvar = "bracket_2_blockcount";
					varvalue = "125";
					break;
				case "bracket_2_costfraction":
					varvar = "bracket_2_costfraction";
					varvalue = "0.2";
					break;
				case "bracket_3_blockcount":
					varvar = "bracket_3_blockcount";
					varvalue = "200";
					break;
				case "bracket_3_costfraction":
					varvar = "bracket_3_costfraction";
					varvalue = "0.333";
					break;
				case "decay.debug":
					varvar = "decay.debug";
					varvalue = "False";
					break;
				case "delay_metal":
					varvar = "delay_metal";
					varvalue = "0";
					break;
				case "delay_override":
					varvar = "delay_override";
					varvalue = "0";
					break;
				case "delay_stone":
					varvar = "delay_stone";
					varvalue = "0";
					break;
				case "delay_toptier":
					varvar = "delay_toptier";
					varvalue = "0";
					break;
				case "delay_twig":
					varvar = "delay_twig";
					varvalue = "0";
					break;
				case "delay_wood":
					varvar = "delay_wood";
					varvalue = "0";
					break;
				case "duration_metal":
					varvar = "duration_metal";
					varvalue = "8";
					break;
				case "duration_override":
					varvar = "duration_override";
					varvalue = "0";
					break;
				case "duration_stone":
					varvar = "duration_stone";
					varvalue = "5";
					break;
				case "duration_toptier":
					varvar = "duration_toptier";
					varvalue = "12";
					break;
				case "duration_twig":
					varvar = "duration_twig";
					varvalue = "1";
					break;
				case "duration_wood":
					varvar = "duration_wood";
					varvalue = "3";
					break;
				case "outside_test_range":
					varvar = "outside_test_range";
					varvalue = "50";
					break;
				case "scale":
					varvar = "scale";
					varvalue = "1";
					break;
				case "tick":
					varvar = "tick";
					varvalue = "600";
					break;
				case "upkeep":
					varvar = "upkeep";
					varvalue = "True";
					break;
				case "upkeep_grief_protection":
					varvar = "upkeep_grief_protection";
					varvalue = "1440";
					break;
				case "upkeep_heal_scale":
					varvar = "upkeep_heal_scale";
					varvalue = "1";
					break;
				case "upkeep_inside_decay_scale":
					varvar = "upkeep_inside_decay_scale";
					varvalue = "0.1";
					break;
				case "upkeep_period_minutes":
					varvar = "upkeep_period_minutes";
					varvalue = "1440";
					break;
				case "progresstime":
					varvar = "progresstime";
					varvalue = "False";
					break;
				case "gc.enabled":
					varvar = "gc.enabled";
					varvalue = "True";
					break;
				case "incremental_enabled":
					varvar = "incremental_enabled";
					varvalue = "True";
					break;
				case "incremental_milliseconds":
					varvar = "incremental_milliseconds";
					varvalue = "3";
					break;
				case "developer":
					varvar = "developer";
					varvalue = "0";
					break;
				case "maxthreads":
					varvar = "maxthreads";
					varvalue = "8";
					break;
				case "timewarning":
					varvar = "timewarning";
					varvalue = "False";
					break;
				case "halloween.enabled":
					varvar = "halloween.enabled";
					varvalue = "False";
					break;
				case "murdererpopulation":
					varvar = "murdererpopulation";
					varvalue = "0";
					break;
				case "scarecrow_beancan_vs_player_dmg_modifier":
					varvar = "scarecrow_beancan_vs_player_dmg_modifier";
					varvalue = "0.1";
					break;
				case "scarecrow_body_dmg_modifier":
					varvar = "scarecrow_body_dmg_modifier";
					varvalue = "0.25";
					break;
				case "scarecrow_chase_stopping_distance":
					varvar = "scarecrow_chase_stopping_distance";
					varvalue = "0.5";
					break;
				case "scarecrow_throw_beancan_global_delay":
					varvar = "scarecrow_throw_beancan_global_delay";
					varvalue = "8";
					break;
				case "scarecrowpopulation":
					varvar = "scarecrowpopulation";
					varvalue = "0";
					break;
				case "scarecrows_throw_beancans":
					varvar = "scarecrows_throw_beancans";
					varvalue = "True";
					break;
				case "visdebug":
					varvar = "visdebug";
					varvalue = "False";
					break;
				case "bulletaccuracy":
					varvar = "bulletaccuracy";
					varvalue = "2";
					break;
				case "bulletdamagescale":
					varvar = "bulletdamagescale";
					varvalue = "1";
					break;
				case "guns":
					varvar = "guns";
					varvalue = "1";
					break;
				case "lifetimeminutes":
					varvar = "lifetimeminutes";
					varvalue = "15";
					break;
				case "autosynctransforms":
					varvar = "autosynctransforms";
					varvalue = "True";
					break;
				case "batchsynctransforms":
					varvar = "batchsynctransforms";
					varvalue = "True";
					break;
				case "bouncethreshold":
					varvar = "bouncethreshold";
					varvalue = "2";
					break;
				case "droppedmode":
					varvar = "droppedmode";
					varvalue = "2";
					break;
				case "gravity":
					varvar = "gravity";
					varvalue = "1";
					break;
				case "minsteps":
					varvar = "minsteps";
					varvalue = "8";
					break;
				case "sendeffects":
					varvar = "sendeffects";
					varvalue = "True";
					break;
				case "sleepthreshold":
					varvar = "sleepthreshold";
					varvalue = "0.005";
					break;
				case "solveriterationcount":
					varvar = "solveriterationcount";
					varvalue = "3";
					break;
				case "steps":
					varvar = "steps";
					varvalue = "16";
					break;
				case "tickrate_cl":
					varvar = "tickrate_cl";
					varvalue = "20";
					break;
				case "tickrate_sv":
					varvar = "tickrate_sv";
					varvalue = "16";
					break;
				case "pool.debug":
					varvar = "pool.debug";
					varvalue = "False";
					break;
				case "pool.enabled":
					varvar = "pool.enabled";
					varvalue = "True";
					break;
				case "mode":
					varvar = "mode";
					varvalue = "2";
					break;
				case "hostileduration":
					varvar = "hostileduration";
					varvalue = "120";
					break;
				case "targetall":
					varvar = "targetall";
					varvalue = "False";
					break;
				case "arrowarmor":
					varvar = "arrowarmor";
					varvalue = "1";
					break;
				case "arrowdamage":
					varvar = "arrowdamage";
					varvalue = "1";
					break;
				case "authtimeout":
					varvar = "authtimeout";
					varvalue = "60";
					break;
				case "bleedingarmor":
					varvar = "bleedingarmor";
					varvalue = "1";
					break;
				case "bleedingdamage":
					varvar = "bleedingdamage";
					varvalue = "1";
					break;
				case "bulletarmor":
					varvar = "bulletarmor";
					varvalue = "1";
					break;
				case "bulletdamage":
					varvar = "bulletdamage";
					varvalue = "1";
					break;
				case "cinematic":
					varvar = "cinematic";
					varvalue = "False";
					break;
				case "combatlogdelay":
					varvar = "combatlogdelay";
					varvalue = "10";
					break;
				case "combatlogsize":
					varvar = "combatlogsize";
					varvalue = "30";
					break;
				case "compression":
					varvar = "compression";
					varvalue = "False";
					break;
				case "corpsedespawn":
					varvar = "corpsedespawn";
					varvalue = "300";
					break;
				case "corpses":
					varvar = "corpses";
					varvalue = "True";
					break;
				case "cycletime":
					varvar = "cycletime";
					varvalue = "500";
					break;
				case "debrisdespawn":
					varvar = "debrisdespawn";
					varvalue = "30";
					break;
				case "dropitems":
					varvar = "dropitems";
					varvalue = "False";
					break;
				case "encryption":
					varvar = "encryption";
					varvalue = "2";
					break;
				case "entitybatchsize":
					varvar = "entitybatchsize";
					varvalue = "100";
					break;
				case "entitybatchtime":
					varvar = "entitybatchtime";
					varvalue = "1";
					break;
				case "entityrate":
					varvar = "entityrate";
					varvalue = "16";
					break;
				case "events":
					varvar = "events";
					varvalue = "True";
					break;
				case "globalchat":
					varvar = "globalchat";
					varvalue = "True";
					break;
				case "idlekick":
					varvar = "idlekick";
					varvalue = "30";
					break;
				case "idlekickadmins":
					varvar = "idlekickadmins";
					varvalue = "0";
					break;
				case "idlekickmode":
					varvar = "idlekickmode";
					varvalue = "1";
					break;
				case "ipqueriespermin":
					varvar = "ipqueriespermin";
					varvalue = "30";
					break;
				case "itemdespawn":
					varvar = "itemdespawn";
					varvalue = "300";
					break;
				case "maxcommandpacketsize":
					varvar = "maxcommandpacketsize";
					varvalue = "1000000";
					break;
				case "maxcommandspersecond":
					varvar = "maxcommandspersecond";
					varvalue = "100";
					break;
				case "maxpacketsize":
					varvar = "maxpacketsize";
					varvalue = "5000000";
					break;
				case "maxpacketspersecond":
					varvar = "maxpacketspersecond";
					varvalue = "1500";
					break;
				case "maxreceivetime":
					varvar = "maxreceivetime";
					varvalue = "20";
					break;
				case "maxrpcspersecond":
					varvar = "maxrpcspersecond";
					varvalue = "200";
					break;
				case "maxtickspersecond":
					varvar = "maxtickspersecond";
					varvalue = "300";
					break;
				case "maxunack":
					varvar = "maxunack";
					varvalue = "4";
					break;
				case "meleearmor":
					varvar = "meleearmor";
					varvalue = "1";
					break;
				case "meleedamage":
					varvar = "meleedamage";
					varvalue = "1";
					break;
				case "metabolismtick":
					varvar = "metabolismtick";
					varvalue = "1";
					break;
				case "netcache":
					varvar = "netcache";
					varvalue = "True";
					break;
				case "netcachesize":
					varvar = "netcachesize";
					varvalue = "0";
					break;
				case "official":
					varvar = "official";
					varvalue = "False";
					break;
				case "plantlightdetection":
					varvar = "plantlightdetection";
					varvalue = "True";
					break;
				case "planttick":
					varvar = "planttick";
					varvalue = "60";
					break;
				case "planttickscale":
					varvar = "planttickscale";
					varvalue = "1";
					break;
				case "playerserverfall":
					varvar = "playerserverfall";
					varvalue = "True";
					break;
				case "playertimeout":
					varvar = "playertimeout";
					varvalue = "60";
					break;
				case "pve":
					varvar = "pve";
					varvalue = "False";
					break;
				case "respawnresetrange":
					varvar = "respawnresetrange";
					varvalue = "50";
					break;
				case "savecachesize":
					varvar = "savecachesize";
					varvalue = "1881";
					break;
				case "saveinterval":
					varvar = "saveinterval";
					varvalue = "600";
					break;
				case "schematime":
					varvar = "schematime";
					varvalue = "1800";
					break;
				case "secure":
					varvar = "secure";
					varvalue = "True";
					break;
				case "showholstereditems":
					varvar = "showholstereditems";
					varvalue = "True";
					break;
				case "stability":
					varvar = "stability";
					varvalue = "True";
					break;
				case "updatebatchspawn":
					varvar = "updatebatchspawn";
					varvalue = "1024";
					break;
				case "max_density":
					varvar = "max_density";
					varvalue = "1";
					break;
				case "max_rate":
					varvar = "max_rate";
					varvalue = "1";
					break;
				case "min_density":
					varvar = "min_density";
					varvalue = "0.5";
					break;
				case "min_rate":
					varvar = "min_rate";
					varvalue = "0.5";
					break;
				case "player_base":
					varvar = "player_base";
					varvalue = "100";
					break;
				case "player_scale":
					varvar = "player_scale";
					varvalue = "2";
					break;
				case "respawn_groups":
					varvar = "respawn_groups";
					varvalue = "True";
					break;
				case "respawn_individuals":
					varvar = "respawn_individuals";
					varvalue = "True";
					break;
				case "respawn_populations":
					varvar = "respawn_populations";
					varvalue = "True";
					break;
				case "tick_individuals":
					varvar = "tick_individuals";
					varvalue = "300";
					break;
				case "tick_populations":
					varvar = "tick_populations";
					varvalue = "60";
					break;
				case "accuracy":
					varvar = "accuracy";
					varvalue = "0.001";
					break;
				case "collapse":
					varvar = "collapse";
					varvalue = "0.05";
					break;
				case "stabilityqueue":
					varvar = "stabilityqueue";
					varvalue = "9";
					break;
				case "strikes":
					varvar = "strikes";
					varvalue = "10";
					break;
				case "surroundingsqueue":
					varvar = "surroundingsqueue";
					varvalue = "3";
					break;
				case "stability.verbose":
					varvar = "stability.verbose";
					varvalue = "0";
					break;
				case "fixeddelta":
					varvar = "fixeddelta";
					varvalue = "0.0625";
					break;
				case "maxdelta":
					varvar = "maxdelta";
					varvalue = "0.125";
					break;
				case "pausewhileloading":
					varvar = "pausewhileloading";
					varvalue = "True";
					break;
				case "timescale":
					varvar = "timescale";
					varvalue = "1";
					break;
				case "global_broadcast":
					varvar = "global_broadcast";
					varvalue = "False";
					break;
				case "boat_corpse_seconds":
					varvar = "boat_corpse_seconds";
					varvalue = "300";
					break;
				case "attack":
					varvar = "attack";
					varvalue = "False";
					break;
				case "damage":
					varvar = "damage";
					varvalue = "False";
					break;
				case "hitboxes":
					varvar = "hitboxes";
					varvalue = "False";
					break;
				case "lineofsight":
					varvar = "lineofsight";
					varvalue = "False";
					break;
				case "protection":
					varvar = "protection";
					varvalue = "False";
					break;
				case "sense":
					varvar = "sense";
					varvalue = "False";
					break;
				case "triggers":
					varvar = "triggers";
					varvalue = "False";
					break;
				case "weakspots":
					varvar = "weakspots";
					varvalue = "False";
					break;
				case "cache":
					varvar = "cache";
					varvalue = "True";
					break;
				case "xmas.enabled":
					varvar = "xmas.enabled";
					varvalue = "False";
					break;
				case "giftsperplayer":
					varvar = "giftsperplayer";
					varvalue = "2";
					break;
				case "spawnattempts":
					varvar = "spawnattempts";
					varvalue = "5";
					break;
				case "spawnrange":
					varvar = "spawnrange";
					varvalue = "49";
					break;
				case "print":
					varvar = "print";
					varvalue = "True";
					break;
				case "web":
					varvar = "web";
					varvalue = "True";
					break;
				case "decayseconds":
					varvar = "decayseconds";
					varvalue = "7200";
					break;
				case "requiredhackseconds":
					varvar = "requiredhackseconds";
					varvalue = "900";
					break;
				case "horse.population":
					varvar = "horse.population";
					varvalue = "0";
					break;
				case "hotairballoon.population":
					varvar = "hotairballoon.population";
					varvalue = "1";
					break;
				case "serviceceiling":
					varvar = "serviceceiling";
					varvalue = "200";
					break;
				case "hotairballoon.outsidedecayminutes":
					varvar = "hotairballoon.outsidedecayminutes";
					varvalue = "180";
					break;
				case "backtracking":
					varvar = "backtracking";
					varvalue = "8";
					break;
				case "ioentity.framebudgetms":
					varvar = "ioentity.framebudgetms";
					varvalue = "1";
					break;
				case "responsetime":
					varvar = "responsetime";
					varvalue = "0.1";
					break;
				case "minicopter.outsidedecayminutes":
					varvar = "minicopter.outsidedecayminutes";
					varvalue = "240";
					break;
				case "minicopter.population":
					varvar = "minicopter.population";
					varvalue = "1";
					break;
				case "motorrowboat.outsidedecayminutes":
					varvar = "motorrowboat.outsidedecayminutes";
					varvalue = "180";
					break;
				case "motorrowboat.population":
					varvar = "motorrowboat.population";
					varvalue = "4";
					break;
				case "sleeperhostiledelay":
					varvar = "sleeperhostiledelay";
					varvalue = "1200";
					break;
				case "forcebirthday":
					varvar = "forcebirthday";
					varvalue = "False";
					break;
				case "maxteamsize":
					varvar = "maxteamsize";
					varvalue = "8";
					break;
				case "rhibpopulation":
					varvar = "rhibpopulation";
					varvalue = "1";
					break;
				case "ridablehorse.population":
					varvar = "ridablehorse.population";
					varvalue = "4";
					break;
				case "ai_dormant":
					varvar = "ai_dormant";
					varvalue = "True";
					break;
				case "ai_dormant_max_wakeup_per_tick":
					varvar = "ai_dormant_max_wakeup_per_tick";
					varvalue = "30";
					break;
				case "ai_htn_animal_tick_budget":
					varvar = "ai_htn_animal_tick_budget";
					varvalue = "4";
					break;
				case "ai_htn_player_junkpile_tick_budget":
					varvar = "ai_htn_player_junkpile_tick_budget";
					varvalue = "4";
					break;
				case "ai_htn_player_tick_budget":
					varvar = "ai_htn_player_tick_budget";
					varvalue = "4";
					break;
				case "ai_htn_use_agency_tick":
					varvar = "ai_htn_use_agency_tick";
					varvalue = "True";
					break;
				case "ai_to_player_distance_wakeup_range":
					varvar = "ai_to_player_distance_wakeup_range";
					varvalue = "160";
					break;
				case "nav_disable":
					varvar = "nav_disable";
					varvalue = "False";
					break;
				case "nav_obstacles_carve_state":
					varvar = "nav_obstacles_carve_state";
					varvalue = "2";
					break;
				case "nav_wait":
					varvar = "nav_wait";
					varvalue = "True";
					break;
				case "pathfindingiterationsperframe":
					varvar = "pathfindingiterationsperframe";
					varvalue = "100";
					break;
				case "cover_point_sample_step_height":
					varvar = "cover_point_sample_step_height";
					varvalue = "2";
					break;
				case "cover_point_sample_step_size":
					varvar = "cover_point_sample_step_size";
					varvalue = "6";
					break;
				case "alltarget":
					varvar = "alltarget";
					varvalue = "False";
					break;
				case "staticrepairseconds":
					varvar = "staticrepairseconds";
					varvalue = "1200";
					break;
				case "altitudeaboveterrain":
					varvar = "altitudeaboveterrain";
					varvalue = "50";
					break;
				case "desiredaltitude":
					varvar = "desiredaltitude";
					varvalue = "60";
					break;
				case "stag.population":
					varvar = "stag.population";
					varvalue = "3";
					break;
				case "wolf.population":
					varvar = "wolf.population";
					varvalue = "2";
					break;
				case "zombie.population":
					varvar = "zombie.population";
					varvalue = "0";
					break;
				case "radiation":
					varvar = "radiation";
					varvalue = "True";
					break;
			}
			return new string[]
			{
				varvar,
				varvalue
			};
		}
	}
}
