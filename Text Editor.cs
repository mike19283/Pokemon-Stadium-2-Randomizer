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

namespace Pokemon_Stadium_2_Randomizer
{
    public partial class Text_Editor : Form
    {
        public string fileText = "";
        public Text_Editor()
        {
            InitializeComponent();
            string[] file;
            try
            {
                file = File.ReadAllLines("Names.txt");
                fileText = String.Join("\n", file);
                richTextBox_namePool.Text = fileText;
            }
            catch
            {
                file = new string[0];
                File.WriteAllLines("Names.txt", file);
            }            
        }

        private void Text_Editor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (richTextBox_namePool.Text != fileText)
            {
                if (MessageBox.Show("Changes detected. Do you want to save?","Save?",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    fileText = richTextBox_namePool.Text;
                    var temp = richTextBox_namePool.Text.Split('\n');
                    File.WriteAllLines("Names.txt", temp);
                    MessageBox.Show("Saved");
                }
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            fileText = richTextBox_namePool.Text;
            var temp = richTextBox_namePool.Text.Split('\n');
            File.WriteAllLines("Names.txt", temp);
            MessageBox.Show("Saved");
        }
    }
}
