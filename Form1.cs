using RoboShooter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Main_Project
{
    public partial class Form1 : Form
    {
        Stopwatch measure = new Stopwatch();

        public Stopwatch Watch { get { return measure; } }

        bool keyUp;
        bool keyDown;
        bool keyLeft;
        bool keyRight;
        string playerDirection = "right";

        bool gameOver = false;

        double health = 100;
        int playerSpeed = 5;
        int robotSpeed = 2;
        int bullets = 10;
        public static int kills = 0;
        static int recordKills = Math.Max(kills, Math.Max(recordKills, Properties.Settings.Default.Рекорд));
    
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void StartGame_Tick(object sender, EventArgs e)
        {
            bulletsText.Text = bullets.ToString();
            killsText.Text = kills.ToString();
            recordText.Text = recordKills.ToString();
            if (health > 1)
            {
                progressBar1.Value = Convert.ToInt32(health);
                progressBar1.ForeColor = Color.Green;
            }
            else
            {
                StartGame.Stop();
                playerBox.Image = Properties.Resources.blood;
                Properties.Settings.Default.Рекорд = recordKills;
                Properties.Settings.Default.Save();
                gameOver = true;
                AfterGame afterGame = new AfterGame();
                afterGame.Show();
                kills = 0;
            }

            if (health < 20) progressBar1.ForeColor = Color.Red;

            if (keyLeft && playerBox.Left > 0)
            {
                playerBox.Left -= playerSpeed;
            }

            if (keyRight && playerBox.Left + playerBox.Width < Width)
            {
                playerBox.Left += playerSpeed;
            }

            if (keyUp && playerBox.Top > 60)
            {
                playerBox.Top -= playerSpeed;
            }

            if (keyDown && playerBox.Top + playerBox.Height < Height - 110)
            {
                playerBox.Top += playerSpeed;
            }

            foreach (Control x in this.Controls)
            {
                //Если игрок встречается с боеприпасами
                if (x is PictureBox && x.Tag == "ammo")
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(playerBox.Bounds))
                    {
                        this.Controls.Remove(((PictureBox)x));
                        ((PictureBox)x).Dispose();
                        bullets += 7;
                    }
                }

                //Если игрок встречается с аптечкой
                if (x is PictureBox && x.Tag == "health")
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(playerBox.Bounds))
                    {
                        this.Controls.Remove(((PictureBox)x));
                        ((PictureBox)x).Dispose();
                        if (health <= 70) health += 30;
                        else health = 100;
                    }
                }

                //Если пули вылетят за границу окна, они пропадут
                if (x is PictureBox && x.Tag == "bullet")
                {
                    if (((PictureBox)x).Left < 1 || ((PictureBox)x).Left > 930 || ((PictureBox)x).Top < 10 || ((PictureBox)x).Top > 700)
                    {
                        this.Controls.Remove(((PictureBox)x));
                        ((PictureBox)x).Dispose();
                    }
                }

                //Поведение робота
                if (x is PictureBox && x.Tag == "robot")
                {

                    //Если игрок встретися с роботом, то он получит урон
                    if (((PictureBox)x).Bounds.IntersectsWith(playerBox.Bounds) && gameOver == false)
                    {
                        health -= 1;
                        playerBox.BackColor = Color.Red;
                    }
                    else
                    {
                        playerBox.BackColor = Color.Transparent;
                    }

                    //will allow the robots to move towards the player (just like the player keys above, it will change the robots direction and image)
                    if (((PictureBox)x).Left > playerBox.Left)
                    {
                        ((PictureBox)x).Left -= robotSpeed;
                        ((PictureBox)x).Image = Properties.Resources.rl;
                    }

                    if (((PictureBox)x).Top > playerBox.Top)
                    {
                        ((PictureBox)x).Top -= robotSpeed;
                        ((PictureBox)x).Image = Properties.Resources.ru;
                    }

                    if (((PictureBox)x).Left < playerBox.Left)
                    {
                        ((PictureBox)x).Left += robotSpeed;
                        ((PictureBox)x).Image = Properties.Resources.rr;
                    }

                    if (((PictureBox)x).Top < playerBox.Top)
                    {
                        ((PictureBox)x).Top += robotSpeed;
                        ((PictureBox)x).Image = Properties.Resources.rd;
                    }
                }


                //if our player hits the robot with our bullets, then the robots is killed and more are spawned
                foreach (Control j in this.Controls)
                {
                    if ((j is PictureBox && j.Tag == "bullet") && (x is PictureBox && x.Tag == "robot"))
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            //up our kill streak 
                            kills++;
                            recordKills = Math.Max(kills, recordKills);
                            //removes the robot(x) and the ammo(j)
                            this.Controls.Remove(j);
                            j.Dispose();
                            this.Controls.Remove(x);
                            x.Dispose();
                            //spawns more robots
                            SpawnRobots();
                            if (kills % 10 == 0)
                            {
                                SpawnHealth();
                            }
                        }
                    }
                }
            }
        }

        private void SpawnEquipment()
        {
            PictureBox ammo = new PictureBox();
            ammo.BringToFront();
            ammo.Image = Properties.Resources.ammo;
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.BackColor = Color.Transparent;
            ammo.Left = random.Next(10, Width - 300);
            ammo.Top = random.Next(50, Height - 300);
            ammo.Tag = "ammo";

            //adds the controls needed to pick it up and dispose of it above
            this.Controls.Add(ammo);
            playerBox.BringToFront();
        }

        private void SpawnHealth()
        {
            PictureBox health = new PictureBox();
            health.BringToFront();
            health.Image = Properties.Resources.Health_Box;
            health.SizeMode = PictureBoxSizeMode.AutoSize;
            health.BackColor = Color.Transparent;
            health.Left = random.Next(10, Width - 300);
            health.Top = random.Next(50, Height - 300);
            health.Tag = "health";

            //adds the controls needed to pick it up and dispose of it above
            this.Controls.Add(health);
            playerBox.BringToFront();
        }

        private void SpawnRobots()
        {
            PictureBox robots = new PictureBox();
            robots.Tag = "robot";
            robots.Image = Properties.Resources.rl;
            robots.Left = random.Next(0, Width);
            robots.Top = random.Next(0, Height - 120);
            robots.SizeMode = PictureBoxSizeMode.AutoSize;
            robots.BackColor = Color.Transparent;
            this.Controls.Add(robots);
            playerBox.BringToFront();
            robots.BringToFront();
        }

        private void Shoot(string direction)
        {
            bullet shoot = new bullet();
            shoot.direction = direction;
            shoot.bulletLeft = playerBox.Left + (playerBox.Width / 2);
            shoot.bulletTop = playerBox.Top + (playerBox.Height / 2);
            shoot.spawnBullets(this);
        }

        private void KeyPress(object sender, KeyEventArgs e)
        {
            if (gameOver) return;

            if (e.KeyCode == Keys.D)
            {
                keyRight = true;
                playerDirection = "right";
                playerBox.Image = Properties.Resources.mr;
            }

            if (e.KeyCode == Keys.A)
            {
                keyLeft = true;
                playerDirection = "left";
                playerBox.Image = Properties.Resources.ml;
            }

            if (e.KeyCode == Keys.W)
            {
                keyUp = true;
                playerDirection = "up";
                playerBox.Image = Properties.Resources.mu;
            }

            if (e.KeyCode == Keys.S)
            {
                keyDown = true;
                playerDirection = "down";
                playerBox.Image = Properties.Resources.md;
            }

            if (e.KeyCode == Keys.Space && bullets > 0)
            {
                //reduce ammo and shoots in the direction the  player faces
                bullets--;
                Shoot(playerDirection);

                //spawn ammo boxes if ammo is low (defined later)
                if (bullets < 3)
                {
                    SpawnEquipment();
                }
            }

            if (e.KeyCode == Keys.Escape)
            {
                StartGame.Stop();
                Game_menu gameMenu = new Game_menu(this.StartGame);
                gameMenu.Show();
                
            }

        }

        private void KeyUnpress(object sender, KeyEventArgs e)
        {
            if (gameOver)
            {
                return;
            }

            if (e.KeyCode == Keys.A)
            {
                keyLeft = false;
            }

            if (e.KeyCode == Keys.D)
            {
                keyRight = false;
            }

            if (e.KeyCode == Keys.S)
            {
                keyDown = false;
            }

            if (e.KeyCode == Keys.W)
            {
                keyUp = false;
            }
        }
    }
}
