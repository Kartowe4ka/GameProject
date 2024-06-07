namespace Main_Project
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bulletsText = new System.Windows.Forms.Label();
            this.killsText = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.playerBox = new System.Windows.Forms.PictureBox();
            this.StartGame = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.recordText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(835, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bullets";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "KILLs";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bulletsText
            // 
            this.bulletsText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bulletsText.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bulletsText.ForeColor = System.Drawing.Color.White;
            this.bulletsText.Location = new System.Drawing.Point(835, 27);
            this.bulletsText.Name = "bulletsText";
            this.bulletsText.Size = new System.Drawing.Size(64, 24);
            this.bulletsText.TabIndex = 2;
            this.bulletsText.Text = "label3";
            this.bulletsText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // killsText
            // 
            this.killsText.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.killsText.ForeColor = System.Drawing.Color.White;
            this.killsText.Location = new System.Drawing.Point(82, 27);
            this.killsText.Name = "killsText";
            this.killsText.Size = new System.Drawing.Size(64, 24);
            this.killsText.TabIndex = 3;
            this.killsText.Text = "label4";
            this.killsText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(359, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "HEALTH";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(343, 27);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(296, 24);
            this.progressBar1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Main_Project.Properties.Resources.rl;
            this.pictureBox1.Location = new System.Drawing.Point(493, 249);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 50);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "robot";
            // 
            // playerBox
            // 
            this.playerBox.BackColor = System.Drawing.Color.Transparent;
            this.playerBox.Image = global::Main_Project.Properties.Resources.mr;
            this.playerBox.Location = new System.Drawing.Point(105, 249);
            this.playerBox.Name = "playerBox";
            this.playerBox.Size = new System.Drawing.Size(58, 50);
            this.playerBox.TabIndex = 7;
            this.playerBox.TabStop = false;
            this.playerBox.Tag = "player";
            // 
            // StartGame
            // 
            this.StartGame.Enabled = true;
            this.StartGame.Interval = 10;
            this.StartGame.Tick += new System.EventHandler(this.StartGame_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.recordText);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bulletsText);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.killsText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 597);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 60);
            this.panel1.TabIndex = 8;
            // 
            // recordText
            // 
            this.recordText.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordText.ForeColor = System.Drawing.Color.White;
            this.recordText.Location = new System.Drawing.Point(82, 3);
            this.recordText.Name = "recordText";
            this.recordText.Size = new System.Drawing.Size(64, 24);
            this.recordText.TabIndex = 7;
            this.recordText.Text = "label4";
            this.recordText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Record";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(980, 657);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.playerBox);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUnpress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label bulletsText;
        private System.Windows.Forms.Label killsText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox playerBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label recordText;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Timer StartGame;
    }
}

