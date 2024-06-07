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

    public partial class AfterGame : Form
    {
        public AfterGame()
        {
            InitializeComponent();
            score.Text = Form1.kills.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < Application.OpenForms.Count; i++)
            {
                Application.OpenForms[i].Close();
            }
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < Application.OpenForms.Count; i++)
            {
                Application.OpenForms[i].Close();
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkBlue;
            button1.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Black;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.DarkBlue;
            button2.ForeColor = Color.White;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
            button2.ForeColor = Color.Black;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.DarkBlue;
            button3.ForeColor = Color.White;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.White;
            button3.ForeColor = Color.Black;
        }
    }
}
