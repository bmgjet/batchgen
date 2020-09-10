using System;
using System.Windows.Forms;
using System.IO;

namespace batchgen
{
    public partial class Form3 : Form
    {
        public string Fpath = "";
        public string Pname = "";
        public Form3(string[] cfgdata, string filepath, string pluginname)
        {
            
            InitializeComponent();
            foreach(string data in cfgdata)
            {
                textBox1.Text += data + Environment.NewLine;
            }
            Pname = pluginname;
            Fpath = filepath;
            label1.Text = "File Path: " + filepath;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("This will overwrite the config file with your changes."+Environment.NewLine + "Are you sure you want to overwrite the file?" + Environment.NewLine + Environment.NewLine + "Call /oxide.reload "+ Pname.Substring(0, Pname.Length - 3) + " for changes to take effect!", "Overwrite File:", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                File.WriteAllText(Fpath, textBox1.Text);
            }

                this.Close();
        }
    }
}
