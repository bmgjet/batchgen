using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace batchgen
{
    public partial class Form2 : Form
    {

        public string pluginsfol = "RustServerFiles\\oxide\\plugins\\";
        public string pluginscfg = "RustServerFiles\\oxide\\config\\";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            bool exists = System.IO.Directory.Exists(pluginsfol);

            if (!exists)
            {
                System.IO.Directory.CreateDirectory(pluginsfol);
            }

            foreach (string file in Directory.GetFiles(pluginsfol, "*.cs").Where(item => item.EndsWith(".cs")))
            {

                string[] lines = System.IO.File.ReadAllLines(file);
                bool foundata = false;
                bool foundata2 = false;
                string pluginname = "";
                string pluginversion = "";
                string plugincreator = "";
                string plugindescription = "";


                foreach (string data in lines)
                {


                    if (data.Contains("[Info("))
                    {
                        string[] decode = data.TrimStart().TrimEnd().Split(new string[] { @""", " }, StringSplitOptions.None);

                        pluginname = decode[0].Substring(7);
                        plugincreator = decode[1].Substring(1);
                        pluginversion = decode[2].Substring(1, decode[2].Length - 1).Replace(@""")]", "");
                        foundata2 = true;
                    }
                    else if (data.Contains("[Description("))
                    {
                        plugindescription = data.TrimStart().TrimEnd().Substring(14, data.Length - 21);
                        foundata = true;
                    }

                    if (foundata && foundata2)
                    {
                        //found all data end for each loop.
                        break;
                    }
                }
                if (foundata || foundata2)
                {
                    this.ServerVars.Rows.Add(new object[]
                    {
                        pluginname,
                        plugincreator,
                        pluginversion,
                        plugindescription,
                        file
                    });
                    foundata = false;
                    foundata2 = false;
                    pluginname = "";
                    pluginversion = "";
                    plugincreator = "";
                    plugindescription = "";
                }

            }
        }

        private void addpluginbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Plugins (*.cs)|*.cs";
            dialog.Title = "Please select an Plugin file.";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string[] lines = System.IO.File.ReadAllLines(dialog.FileName);
                bool foundata = false;
                bool foundata2 = false;
                string filepath = dialog.FileName;
                string pluginname = "";
                string pluginversion = "";
                string plugincreator = "";
                string plugindescription = "";


                foreach (string data in lines)
                {


                    if (data.Contains("[Info("))
                    {
                        string[] decode = data.TrimStart().TrimEnd().Split(new string[] { @""", " }, StringSplitOptions.None);

                        pluginname = decode[0].Substring(7);
                        plugincreator = decode[1].Substring(1);
                        pluginversion = decode[2].Substring(1, decode[2].Length - 1).Replace(@""")]", "");
                        foundata2 = true;
                    }
                    else if (data.Contains("[Description("))
                    {
                        plugindescription = data.TrimStart().TrimEnd().Substring(14, data.Length - 21);
                        foundata = true;
                    }

                    if (foundata && foundata2)
                    {
                        DialogResult dialogResult = MessageBox.Show("Do you want to add this plugin?" + Environment.NewLine + "Plugin name: " + pluginname + Environment.NewLine + "Author: " + plugincreator + Environment.NewLine + "Version: " + pluginversion + Environment.NewLine + plugindescription, "Add plugin:", MessageBoxButtons.YesNo);

                        if (dialogResult == DialogResult.Yes)
                        {
                            string[] pluginpath = filepath.Split('\\');
                            string newpluginpath = pluginsfol + pluginpath[pluginpath.Length -1];
                            try
                            {
                                File.Copy(filepath, newpluginpath);
                                this.ServerVars.Rows.Add(new object[]
                                {
                                pluginname,
                                plugincreator,
                                pluginversion,
                                plugindescription,
                                newpluginpath
                                });
                            }
                            catch(Exception er)
                            {
                                MessageBox.Show("Error: " + er.ToString().Split(new[] { "at" }, StringSplitOptions.None)[0]);
                            }
                            return;
                        }
                        else
                        {
                            return;
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pluginname = (string)ServerVars.CurrentRow.Cells[0].Value;
            string pluginversion = (string)ServerVars.CurrentRow.Cells[2].Value;
            string pluginpath = (string)ServerVars.CurrentRow.Cells[4].Value;

            DialogResult dialogResult = MessageBox.Show("Do you want to remove this plugin?" + Environment.NewLine + "Plugin name: " + pluginname + Environment.NewLine + "Plugin version: " + pluginversion + Environment.NewLine + pluginpath, "Remove Plugin:", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    File.Delete(pluginpath);
                    foreach (DataGridViewRow row in ServerVars.SelectedRows)
                    {
                        ServerVars.Rows.RemoveAt(row.Index);
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show("Error: " + er.ToString().Split(new[] { " at " }, StringSplitOptions.None)[0]);
                }
            }

        }

        private void ServerVars_DoubleClick(object sender, EventArgs e)
        {
            string pluginname = (string)ServerVars.CurrentRow.Cells[0].Value;
            string pluginversion = (string)ServerVars.CurrentRow.Cells[2].Value;
            string pluginpath = (string)ServerVars.CurrentRow.Cells[4].Value;
            string[] plugint = (pluginpath).Split('\\');
            string newpluginname = plugint[plugint.Length - 1];
            pluginpath = pluginscfg + newpluginname.Substring(0, newpluginname.Length - 3) + ".json";


            DialogResult dialogResult = MessageBox.Show("Do you want to edit this plugin config?" + Environment.NewLine + "Plugin name: " + pluginname + Environment.NewLine + "Plugin version: " + pluginversion + Environment.NewLine + pluginpath, "Config Plugin:", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    string[] tempdata = File.ReadAllLines(pluginpath);
                    Form3 plugins = new Form3(tempdata, pluginpath, newpluginname);
                    plugins.StartPosition = FormStartPosition.CenterScreen;
                    plugins.ShowDialog();
                }
                catch (Exception er)
                {
                    MessageBox.Show("Error: " + er.ToString().Split(new[] { " at " }, StringSplitOptions.None)[0]);
                }
            }
        }
    }
}
