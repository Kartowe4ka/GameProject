using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Project
{
    public partial class Option : Form
    {
        public Option()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MainMenu.player.Stop();
                pictureBox1.Image = Properties.Resources.sound_off_1;
            }
            else
            {
                MainMenu.player.Play();
                pictureBox1.Image = Properties.Resources.sound_on_1;
            }
        }


    }
}
