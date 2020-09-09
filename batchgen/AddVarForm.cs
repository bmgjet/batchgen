using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace batchgen
{
	// Token: 0x02000003 RID: 3
	public partial class AddVarForm : Form
	{
		// Token: 0x060000BC RID: 188 RVA: 0x0001A539 File Offset: 0x00018739
		public AddVarForm()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0001A551 File Offset: 0x00018751
		private void BTNadd_Click(object sender, EventArgs e)
		{
			this.ServerVars.Rows.Add(new object[]
			{
				this.varvar.Text,
				this.varvalue.Text
			});
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0001A588 File Offset: 0x00018788
		private void Button1_Click(object sender, EventArgs e)
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
																																																																																																																										bool flag120 = this.SearchVar.Text == "clothloddist";
																																																																																																																										if (flag120)
																																																																																																																										{
																																																																																																																											this.varvar.Text = "clothloddist";
																																																																																																																											this.varvalue.Text = "20";
																																																																																																																										}
																																																																																																																										else
																																																																																																																										{
																																																																																																																											bool flag121 = this.SearchVar.Text == "clothloddist";
																																																																																																																											if (flag121)
																																																																																																																											{
																																																																																																																												this.varvar.Text = "clothloddist";
																																																																																																																												this.varvalue.Text = "20";
																																																																																																																											}
																																																																																																																											else
																																																																																																																											{
																																																																																																																												bool flag122 = this.SearchVar.Text == "clothloddist";
																																																																																																																												if (flag122)
																																																																																																																												{
																																																																																																																													this.varvar.Text = "clothloddist";
																																																																																																																													this.varvalue.Text = "20";
																																																																																																																												}
																																																																																																																												else
																																																																																																																												{
																																																																																																																													bool flag123 = this.SearchVar.Text == "clothloddist";
																																																																																																																													if (flag123)
																																																																																																																													{
																																																																																																																														this.varvar.Text = "clothloddist";
																																																																																																																														this.varvalue.Text = "20";
																																																																																																																													}
																																																																																																																													else
																																																																																																																													{
																																																																																																																														bool flag124 = this.SearchVar.Text == "clothloddist";
																																																																																																																														if (flag124)
																																																																																																																														{
																																																																																																																															this.varvar.Text = "clothloddist";
																																																																																																																															this.varvalue.Text = "20";
																																																																																																																														}
																																																																																																																														else
																																																																																																																														{
																																																																																																																															bool flag125 = this.SearchVar.Text == "clothloddist";
																																																																																																																															if (flag125)
																																																																																																																															{
																																																																																																																																this.varvar.Text = "clothloddist";
																																																																																																																																this.varvalue.Text = "20";
																																																																																																																															}
																																																																																																																															else
																																																																																																																															{
																																																																																																																																bool flag126 = this.SearchVar.Text == "clothloddist";
																																																																																																																																if (flag126)
																																																																																																																																{
																																																																																																																																	this.varvar.Text = "clothloddist";
																																																																																																																																	this.varvalue.Text = "20";
																																																																																																																																}
																																																																																																																																else
																																																																																																																																{
																																																																																																																																	bool flag127 = this.SearchVar.Text == "clothloddist";
																																																																																																																																	if (flag127)
																																																																																																																																	{
																																																																																																																																		this.varvar.Text = "clothloddist";
																																																																																																																																		this.varvalue.Text = "20";
																																																																																																																																	}
																																																																																																																																	else
																																																																																																																																	{
																																																																																																																																		bool flag128 = this.SearchVar.Text == "clothloddist";
																																																																																																																																		if (flag128)
																																																																																																																																		{
																																																																																																																																			this.varvar.Text = "clothloddist";
																																																																																																																																			this.varvalue.Text = "20";
																																																																																																																																		}
																																																																																																																																		else
																																																																																																																																		{
																																																																																																																																			bool flag129 = this.SearchVar.Text == "clothloddist";
																																																																																																																																			if (flag129)
																																																																																																																																			{
																																																																																																																																				this.varvar.Text = "clothloddist";
																																																																																																																																				this.varvalue.Text = "20";
																																																																																																																																			}
																																																																																																																																			else
																																																																																																																																			{
																																																																																																																																				bool flag130 = this.SearchVar.Text == "clothloddist";
																																																																																																																																				if (flag130)
																																																																																																																																				{
																																																																																																																																					this.varvar.Text = "clothloddist";
																																																																																																																																					this.varvalue.Text = "20";
																																																																																																																																				}
																																																																																																																																				else
																																																																																																																																				{
																																																																																																																																					bool flag131 = this.SearchVar.Text == "clothloddist";
																																																																																																																																					if (flag131)
																																																																																																																																					{
																																																																																																																																						this.varvar.Text = "clothloddist";
																																																																																																																																						this.varvalue.Text = "20";
																																																																																																																																					}
																																																																																																																																					else
																																																																																																																																					{
																																																																																																																																						bool flag132 = this.SearchVar.Text == "clothloddist";
																																																																																																																																						if (flag132)
																																																																																																																																						{
																																																																																																																																							this.varvar.Text = "clothloddist";
																																																																																																																																							this.varvalue.Text = "20";
																																																																																																																																						}
																																																																																																																																						else
																																																																																																																																						{
																																																																																																																																							bool flag133 = this.SearchVar.Text == "clothloddist";
																																																																																																																																							if (flag133)
																																																																																																																																							{
																																																																																																																																								this.varvar.Text = "clothloddist";
																																																																																																																																								this.varvalue.Text = "20";
																																																																																																																																							}
																																																																																																																																							else
																																																																																																																																							{
																																																																																																																																								bool flag134 = this.SearchVar.Text == "clothloddist";
																																																																																																																																								if (flag134)
																																																																																																																																								{
																																																																																																																																									this.varvar.Text = "clothloddist";
																																																																																																																																									this.varvalue.Text = "20";
																																																																																																																																								}
																																																																																																																																								else
																																																																																																																																								{
																																																																																																																																									bool flag135 = this.SearchVar.Text == "clothloddist";
																																																																																																																																									if (flag135)
																																																																																																																																									{
																																																																																																																																										this.varvar.Text = "clothloddist";
																																																																																																																																										this.varvalue.Text = "20";
																																																																																																																																									}
																																																																																																																																									else
																																																																																																																																									{
																																																																																																																																										bool flag136 = this.SearchVar.Text == "clothloddist";
																																																																																																																																										if (flag136)
																																																																																																																																										{
																																																																																																																																											this.varvar.Text = "clothloddist";
																																																																																																																																											this.varvalue.Text = "20";
																																																																																																																																										}
																																																																																																																																									}
																																																																																																																																								}
																																																																																																																																							}
																																																																																																																																						}
																																																																																																																																					}
																																																																																																																																				}
																																																																																																																																			}
																																																																																																																																		}
																																																																																																																																	}
																																																																																																																																}
																																																																																																																															}
																																																																																																																														}
																																																																																																																													}
																																																																																																																												}
																																																																																																																											}
																																																																																																																										}
																																																																																																																									}
																																																																																																																								}
																																																																																																																							}
																																																																																																																						}
																																																																																																																					}
																																																																																																																				}
																																																																																																																			}
																																																																																																																		}
																																																																																																																	}
																																																																																																																}
																																																																																																															}
																																																																																																														}
																																																																																																													}
																																																																																																												}
																																																																																																											}
																																																																																																										}
																																																																																																									}
																																																																																																								}
																																																																																																							}
																																																																																																						}
																																																																																																					}
																																																																																																				}
																																																																																																			}
																																																																																																		}
																																																																																																	}
																																																																																																}
																																																																																															}
																																																																																														}
																																																																																													}
																																																																																												}
																																																																																											}
																																																																																										}
																																																																																									}
																																																																																								}
																																																																																							}
																																																																																						}
																																																																																					}
																																																																																				}
																																																																																			}
																																																																																		}
																																																																																	}
																																																																																}
																																																																															}
																																																																														}
																																																																													}
																																																																												}
																																																																											}
																																																																										}
																																																																									}
																																																																								}
																																																																							}
																																																																						}
																																																																					}
																																																																				}
																																																																			}
																																																																		}
																																																																	}
																																																																}
																																																															}
																																																														}
																																																													}
																																																												}
																																																											}
																																																										}
																																																									}
																																																								}
																																																							}
																																																						}
																																																					}
																																																				}
																																																			}
																																																		}
																																																	}
																																																}
																																															}
																																														}
																																													}
																																												}
																																											}
																																										}
																																									}
																																								}
																																							}
																																						}
																																					}
																																				}
																																			}
																																		}
																																	}
																																}
																															}
																														}
																													}
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0001C9A6 File Offset: 0x0001ABA6
		private void BtnClearVars_Click(object sender, EventArgs e)
		{
			Process.Start("https://rustserverowners.com/server-variables/full-rust-server-convar-list/");
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0001C9B4 File Offset: 0x0001ABB4
		private void Button2_Click(object sender, EventArgs e)
		{
			this.ServerVars.Rows.Clear();
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0001C9C8 File Offset: 0x0001ABC8
		private void BtnCompleteVars_Click(object sender, EventArgs e)
		{
			foreach (object obj in ((IEnumerable)this.ServerVars.Rows))
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				foreach (object obj2 in dataGridViewRow.Cells)
				{
					DataGridViewCell dataGridViewCell = (DataGridViewCell)obj2;
					this.textBox1.Text = this.textBox1.Text + " \"" + dataGridViewCell.Value.ToString() + "\" ";
				}
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0001CAA4 File Offset: 0x0001ACA4
		private void Btncancel_Click(object sender, EventArgs e)
		{
			this.varvar.Clear();
			this.varvalue.Clear();
		}
	}
}
