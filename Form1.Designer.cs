namespace FlappyBirdClone
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbBird = new System.Windows.Forms.PictureBox();
            this.pbPipeTop = new System.Windows.Forms.PictureBox();
            this.pbPipeBottom = new System.Windows.Forms.PictureBox();
            this.pbGround = new System.Windows.Forms.PictureBox();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBird
            // 
            this.pbBird.BackColor = System.Drawing.Color.Transparent;
            this.pbBird.Location = new System.Drawing.Point(100, 200);
            this.pbBird.Name = "pbBird";
            this.pbBird.Size = new System.Drawing.Size(50, 36);
            this.pbBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBird.TabIndex = 0;
            this.pbBird.TabStop = false;
            // 
            // pbPipeTop
            // 
            this.pbPipeTop.BackColor = System.Drawing.Color.Transparent;
            this.pbPipeTop.Location = new System.Drawing.Point(600, -150);
            this.pbPipeTop.Name = "pbPipeTop";
            this.pbPipeTop.Size = new System.Drawing.Size(80, 400);
            this.pbPipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPipeTop.TabIndex = 1;
            this.pbPipeTop.TabStop = false;
            // 
            // pbPipeBottom
            // 
            this.pbPipeBottom.BackColor = System.Drawing.Color.Transparent;
            this.pbPipeBottom.Location = new System.Drawing.Point(600, 400);
            this.pbPipeBottom.Name = "pbPipeBottom";
            this.pbPipeBottom.Size = new System.Drawing.Size(80, 400);
            this.pbPipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPipeBottom.TabIndex = 2;
            this.pbPipeBottom.TabStop = false;
            // 
            // pbGround
            // 
            this.pbGround.BackColor = System.Drawing.Color.Transparent;
            this.pbGround.Location = new System.Drawing.Point(0, 500);
            this.pbGround.Name = "pbGround";
            this.pbGround.Size = new System.Drawing.Size(800, 100);
            this.pbGround.TabIndex = 3;
            this.pbGround.TabStop = false;
            // 
            // timerGame
            // 
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(20, 20);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(142, 45);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pbBird);
            this.Controls.Add(this.pbPipeTop);
            this.Controls.Add(this.pbPipeBottom);
            this.Controls.Add(this.pbGround);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird Clone";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBird;
        private System.Windows.Forms.PictureBox pbPipeTop;
        private System.Windows.Forms.PictureBox pbPipeBottom;
        private System.Windows.Forms.PictureBox pbGround;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.Label lblScore;
    }
}
