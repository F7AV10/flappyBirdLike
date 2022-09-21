
namespace flappyBird
{
    partial class passaroVoador
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.scoreText = new System.Windows.Forms.Label();
            this.labelNextScore = new System.Windows.Forms.Label();
            this.gameOverScreen = new System.Windows.Forms.PictureBox();
            this.playerColisor = new System.Windows.Forms.PictureBox();
            this.playerBird = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeTop2 = new System.Windows.Forms.PictureBox();
            this.pipeBottom2 = new System.Windows.Forms.PictureBox();
            this.pipeTop1 = new System.Windows.Forms.PictureBox();
            this.pipeBottom1 = new System.Windows.Forms.PictureBox();
            this.bgMontain2 = new System.Windows.Forms.PictureBox();
            this.bgMontain1 = new System.Windows.Forms.PictureBox();
            this.bgMontain3 = new System.Windows.Forms.PictureBox();
            this.bgFundo0 = new System.Windows.Forms.PictureBox();
            this.bgFundo1 = new System.Windows.Forms.PictureBox();
            this.bgFundo9 = new System.Windows.Forms.PictureBox();
            this.bgFundo8 = new System.Windows.Forms.PictureBox();
            this.bgFundo7 = new System.Windows.Forms.PictureBox();
            this.bgFundo6 = new System.Windows.Forms.PictureBox();
            this.bgFundo5 = new System.Windows.Forms.PictureBox();
            this.bgFundo4 = new System.Windows.Forms.PictureBox();
            this.bgFundo3 = new System.Windows.Forms.PictureBox();
            this.bgFundo2 = new System.Windows.Forms.PictureBox();
            this.bgNuvem3 = new System.Windows.Forms.PictureBox();
            this.bgNuvem2 = new System.Windows.Forms.PictureBox();
            this.bgNuvem1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gameOverScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerColisor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgMontain2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgMontain1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgMontain3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgFundo0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgFundo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgFundo9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgFundo8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgFundo7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgFundo6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgFundo5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgFundo4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgFundo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgFundo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgNuvem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgNuvem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgNuvem1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerGame
            // 
            this.timerGame.Enabled = true;
            this.timerGame.Interval = 20;
            this.timerGame.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.Transparent;
            this.scoreText.Font = new System.Drawing.Font("Comic Sans MS", 20F);
            this.scoreText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.scoreText.Location = new System.Drawing.Point(10, 426);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(124, 38);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Score: 0";
            // 
            // labelNextScore
            // 
            this.labelNextScore.AutoSize = true;
            this.labelNextScore.BackColor = System.Drawing.Color.Transparent;
            this.labelNextScore.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNextScore.Location = new System.Drawing.Point(197, 435);
            this.labelNextScore.Name = "labelNextScore";
            this.labelNextScore.Size = new System.Drawing.Size(146, 29);
            this.labelNextScore.TabIndex = 5;
            this.labelNextScore.Text = "NextScore: 0";
            this.labelNextScore.Visible = false;
            // 
            // gameOverScreen
            // 
            this.gameOverScreen.BackColor = System.Drawing.Color.Black;
            this.gameOverScreen.Location = new System.Drawing.Point(-16, -22);
            this.gameOverScreen.Name = "gameOverScreen";
            this.gameOverScreen.Size = new System.Drawing.Size(384, 513);
            this.gameOverScreen.TabIndex = 25;
            this.gameOverScreen.TabStop = false;
            this.gameOverScreen.Visible = false;
            // 
            // playerColisor
            // 
            this.playerColisor.BackColor = System.Drawing.Color.Red;
            this.playerColisor.Location = new System.Drawing.Point(100, 132);
            this.playerColisor.Name = "playerColisor";
            this.playerColisor.Size = new System.Drawing.Size(38, 36);
            this.playerColisor.TabIndex = 6;
            this.playerColisor.TabStop = false;
            this.playerColisor.Visible = false;
            // 
            // playerBird
            // 
            this.playerBird.BackColor = System.Drawing.Color.Transparent;
            this.playerBird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.playerBird.Image = global::flappyBird.Properties.Resources.bird;
            this.playerBird.InitialImage = global::flappyBird.Properties.Resources.bird;
            this.playerBird.Location = new System.Drawing.Point(84, 115);
            this.playerBird.Name = "playerBird";
            this.playerBird.Size = new System.Drawing.Size(71, 68);
            this.playerBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerBird.TabIndex = 0;
            this.playerBird.TabStop = false;
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.BurlyWood;
            this.ground.Location = new System.Drawing.Point(-6, 406);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(374, 77);
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // pipeTop2
            // 
            this.pipeTop2.BackColor = System.Drawing.Color.Transparent;
            this.pipeTop2.BackgroundImage = global::flappyBird.Properties.Resources.pipeBlue;
            this.pipeTop2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pipeTop2.Location = new System.Drawing.Point(565, -71);
            this.pipeTop2.Name = "pipeTop2";
            this.pipeTop2.Size = new System.Drawing.Size(63, 248);
            this.pipeTop2.TabIndex = 8;
            this.pipeTop2.TabStop = false;
            // 
            // pipeBottom2
            // 
            this.pipeBottom2.BackColor = System.Drawing.Color.Transparent;
            this.pipeBottom2.BackgroundImage = global::flappyBird.Properties.Resources.pipeRed;
            this.pipeBottom2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pipeBottom2.Location = new System.Drawing.Point(565, 334);
            this.pipeBottom2.Name = "pipeBottom2";
            this.pipeBottom2.Size = new System.Drawing.Size(63, 392);
            this.pipeBottom2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom2.TabIndex = 7;
            this.pipeBottom2.TabStop = false;
            // 
            // pipeTop1
            // 
            this.pipeTop1.BackColor = System.Drawing.Color.Transparent;
            this.pipeTop1.BackgroundImage = global::flappyBird.Properties.Resources.pipeBlue;
            this.pipeTop1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pipeTop1.InitialImage = global::flappyBird.Properties.Resources.pipeBlue;
            this.pipeTop1.Location = new System.Drawing.Point(320, -141);
            this.pipeTop1.Name = "pipeTop1";
            this.pipeTop1.Size = new System.Drawing.Size(63, 248);
            this.pipeTop1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop1.TabIndex = 1;
            this.pipeTop1.TabStop = false;
            // 
            // pipeBottom1
            // 
            this.pipeBottom1.BackColor = System.Drawing.Color.Transparent;
            this.pipeBottom1.BackgroundImage = global::flappyBird.Properties.Resources.pipeRed;
            this.pipeBottom1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pipeBottom1.InitialImage = global::flappyBird.Properties.Resources.pipeRed;
            this.pipeBottom1.Location = new System.Drawing.Point(320, 264);
            this.pipeBottom1.Name = "pipeBottom1";
            this.pipeBottom1.Size = new System.Drawing.Size(63, 392);
            this.pipeBottom1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pipeBottom1.TabIndex = 2;
            this.pipeBottom1.TabStop = false;
            // 
            // bgMontain2
            // 
            this.bgMontain2.BackColor = System.Drawing.Color.SeaGreen;
            this.bgMontain2.Location = new System.Drawing.Point(84, 264);
            this.bgMontain2.Name = "bgMontain2";
            this.bgMontain2.Size = new System.Drawing.Size(100, 349);
            this.bgMontain2.TabIndex = 10;
            this.bgMontain2.TabStop = false;
            // 
            // bgMontain1
            // 
            this.bgMontain1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bgMontain1.Location = new System.Drawing.Point(-6, 207);
            this.bgMontain1.Name = "bgMontain1";
            this.bgMontain1.Size = new System.Drawing.Size(100, 319);
            this.bgMontain1.TabIndex = 9;
            this.bgMontain1.TabStop = false;
            // 
            // bgMontain3
            // 
            this.bgMontain3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bgMontain3.Location = new System.Drawing.Point(243, 158);
            this.bgMontain3.Name = "bgMontain3";
            this.bgMontain3.Size = new System.Drawing.Size(100, 384);
            this.bgMontain3.TabIndex = 11;
            this.bgMontain3.TabStop = false;
            // 
            // bgFundo0
            // 
            this.bgFundo0.BackColor = System.Drawing.Color.MediumAquamarine;
            this.bgFundo0.Location = new System.Drawing.Point(-6, 348);
            this.bgFundo0.Name = "bgFundo0";
            this.bgFundo0.Size = new System.Drawing.Size(374, 77);
            this.bgFundo0.TabIndex = 12;
            this.bgFundo0.TabStop = false;
            // 
            // bgFundo1
            // 
            this.bgFundo1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.bgFundo1.Location = new System.Drawing.Point(-6, 311);
            this.bgFundo1.Name = "bgFundo1";
            this.bgFundo1.Size = new System.Drawing.Size(33, 46);
            this.bgFundo1.TabIndex = 21;
            this.bgFundo1.TabStop = false;
            // 
            // bgFundo9
            // 
            this.bgFundo9.BackColor = System.Drawing.Color.MediumAquamarine;
            this.bgFundo9.Location = new System.Drawing.Point(317, 280);
            this.bgFundo9.Name = "bgFundo9";
            this.bgFundo9.Size = new System.Drawing.Size(51, 77);
            this.bgFundo9.TabIndex = 20;
            this.bgFundo9.TabStop = false;
            // 
            // bgFundo8
            // 
            this.bgFundo8.BackColor = System.Drawing.Color.MediumAquamarine;
            this.bgFundo8.Location = new System.Drawing.Point(278, 311);
            this.bgFundo8.Name = "bgFundo8";
            this.bgFundo8.Size = new System.Drawing.Size(42, 46);
            this.bgFundo8.TabIndex = 19;
            this.bgFundo8.TabStop = false;
            // 
            // bgFundo7
            // 
            this.bgFundo7.BackColor = System.Drawing.Color.MediumAquamarine;
            this.bgFundo7.Location = new System.Drawing.Point(230, 290);
            this.bgFundo7.Name = "bgFundo7";
            this.bgFundo7.Size = new System.Drawing.Size(42, 67);
            this.bgFundo7.TabIndex = 18;
            this.bgFundo7.TabStop = false;
            // 
            // bgFundo6
            // 
            this.bgFundo6.BackColor = System.Drawing.Color.MediumAquamarine;
            this.bgFundo6.Location = new System.Drawing.Point(200, 321);
            this.bgFundo6.Name = "bgFundo6";
            this.bgFundo6.Size = new System.Drawing.Size(37, 36);
            this.bgFundo6.TabIndex = 17;
            this.bgFundo6.TabStop = false;
            // 
            // bgFundo5
            // 
            this.bgFundo5.BackColor = System.Drawing.Color.MediumAquamarine;
            this.bgFundo5.Location = new System.Drawing.Point(152, 290);
            this.bgFundo5.Name = "bgFundo5";
            this.bgFundo5.Size = new System.Drawing.Size(42, 67);
            this.bgFundo5.TabIndex = 16;
            this.bgFundo5.TabStop = false;
            // 
            // bgFundo4
            // 
            this.bgFundo4.BackColor = System.Drawing.Color.MediumAquamarine;
            this.bgFundo4.Location = new System.Drawing.Point(113, 280);
            this.bgFundo4.Name = "bgFundo4";
            this.bgFundo4.Size = new System.Drawing.Size(42, 77);
            this.bgFundo4.TabIndex = 15;
            this.bgFundo4.TabStop = false;
            // 
            // bgFundo3
            // 
            this.bgFundo3.BackColor = System.Drawing.Color.MediumAquamarine;
            this.bgFundo3.Location = new System.Drawing.Point(65, 311);
            this.bgFundo3.Name = "bgFundo3";
            this.bgFundo3.Size = new System.Drawing.Size(42, 46);
            this.bgFundo3.TabIndex = 14;
            this.bgFundo3.TabStop = false;
            // 
            // bgFundo2
            // 
            this.bgFundo2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.bgFundo2.Location = new System.Drawing.Point(17, 290);
            this.bgFundo2.Name = "bgFundo2";
            this.bgFundo2.Size = new System.Drawing.Size(42, 67);
            this.bgFundo2.TabIndex = 13;
            this.bgFundo2.TabStop = false;
            // 
            // bgNuvem3
            // 
            this.bgNuvem3.BackColor = System.Drawing.Color.Gainsboro;
            this.bgNuvem3.Location = new System.Drawing.Point(220, 132);
            this.bgNuvem3.Name = "bgNuvem3";
            this.bgNuvem3.Size = new System.Drawing.Size(111, 51);
            this.bgNuvem3.TabIndex = 24;
            this.bgNuvem3.TabStop = false;
            // 
            // bgNuvem2
            // 
            this.bgNuvem2.BackColor = System.Drawing.Color.Gainsboro;
            this.bgNuvem2.Location = new System.Drawing.Point(152, 21);
            this.bgNuvem2.Name = "bgNuvem2";
            this.bgNuvem2.Size = new System.Drawing.Size(143, 86);
            this.bgNuvem2.TabIndex = 23;
            this.bgNuvem2.TabStop = false;
            // 
            // bgNuvem1
            // 
            this.bgNuvem1.BackColor = System.Drawing.Color.Gainsboro;
            this.bgNuvem1.Location = new System.Drawing.Point(26, 174);
            this.bgNuvem1.Name = "bgNuvem1";
            this.bgNuvem1.Size = new System.Drawing.Size(100, 48);
            this.bgNuvem1.TabIndex = 22;
            this.bgNuvem1.TabStop = false;
            // 
            // passaroVoador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(353, 473);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.labelNextScore);
            this.Controls.Add(this.gameOverScreen);
            this.Controls.Add(this.playerColisor);
            this.Controls.Add(this.playerBird);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeTop2);
            this.Controls.Add(this.pipeBottom2);
            this.Controls.Add(this.pipeTop1);
            this.Controls.Add(this.pipeBottom1);
            this.Controls.Add(this.bgMontain2);
            this.Controls.Add(this.bgMontain1);
            this.Controls.Add(this.bgMontain3);
            this.Controls.Add(this.bgFundo0);
            this.Controls.Add(this.bgFundo1);
            this.Controls.Add(this.bgFundo9);
            this.Controls.Add(this.bgFundo8);
            this.Controls.Add(this.bgFundo7);
            this.Controls.Add(this.bgFundo6);
            this.Controls.Add(this.bgFundo5);
            this.Controls.Add(this.bgFundo4);
            this.Controls.Add(this.bgFundo3);
            this.Controls.Add(this.bgFundo2);
            this.Controls.Add(this.bgNuvem3);
            this.Controls.Add(this.bgNuvem2);
            this.Controls.Add(this.bgNuvem1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(369, 511);
            this.MinimumSize = new System.Drawing.Size(369, 511);
            this.Name = "passaroVoador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "flappyBird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsDown);
            ((System.ComponentModel.ISupportInitialize)(this.gameOverScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerColisor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgMontain2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgMontain1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgMontain3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgFundo0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgFundo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgFundo9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgFundo8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgFundo7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgFundo6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgFundo5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgFundo4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgFundo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgFundo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgNuvem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgNuvem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgNuvem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox playerBird;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.PictureBox pipeTop1;
        private System.Windows.Forms.PictureBox pipeBottom1;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Label labelNextScore;
        private System.Windows.Forms.PictureBox playerColisor;
        private System.Windows.Forms.PictureBox pipeBottom2;
        private System.Windows.Forms.PictureBox pipeTop2;
        private System.Windows.Forms.PictureBox bgMontain1;
        private System.Windows.Forms.PictureBox bgMontain2;
        private System.Windows.Forms.PictureBox bgMontain3;
        private System.Windows.Forms.PictureBox bgFundo0;
        private System.Windows.Forms.PictureBox bgFundo2;
        private System.Windows.Forms.PictureBox bgFundo3;
        private System.Windows.Forms.PictureBox bgFundo4;
        private System.Windows.Forms.PictureBox bgFundo5;
        private System.Windows.Forms.PictureBox bgFundo6;
        private System.Windows.Forms.PictureBox bgFundo7;
        private System.Windows.Forms.PictureBox bgFundo8;
        private System.Windows.Forms.PictureBox bgFundo9;
        private System.Windows.Forms.PictureBox bgFundo1;
        private System.Windows.Forms.PictureBox bgNuvem1;
        private System.Windows.Forms.PictureBox bgNuvem2;
        private System.Windows.Forms.PictureBox bgNuvem3;
        private System.Windows.Forms.PictureBox gameOverScreen;
    }
}

