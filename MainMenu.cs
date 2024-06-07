using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Project
{
    public partial class MainMenu : Form
    {
        public static System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public MainMenu()
        {
            InitializeComponent();

            player.SoundLocation = "C:\\Users\\Александр\\source\\repos\\Main Project\\Resources\\background_sound.wav";
            player.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 gameForm = new Form1();
            gameForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Option soundOption = new Option();
            soundOption.Show();
        }
    }
}
