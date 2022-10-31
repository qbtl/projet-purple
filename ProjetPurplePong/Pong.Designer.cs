﻿namespace ProjetPurplePong
{
    partial class Pong
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
            this.Joueur1 = new System.Windows.Forms.PictureBox();
            this.Joueur2 = new System.Windows.Forms.PictureBox();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.ResponsiveInterface = new System.Windows.Forms.Timer(this.components);
            this.Scoreboard = new System.Windows.Forms.Label();
            this.UpdateScore = new System.Windows.Forms.Timer(this.components);
            this.BallMovement = new System.Windows.Forms.Timer(this.components);
            this.labelVictory = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Joueur1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Joueur2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            this.SuspendLayout();
            // 
            // Joueur1
            // 
            this.Joueur1.BackgroundImage = global::ProjetPurplePong.Properties.Resources.PlayerGraphics;
            this.Joueur1.Location = new System.Drawing.Point(12, 200);
            this.Joueur1.Name = "Joueur1";
            this.Joueur1.Size = new System.Drawing.Size(16, 72);
            this.Joueur1.TabIndex = 0;
            this.Joueur1.TabStop = false;
            // 
            // Joueur2
            // 
            this.Joueur2.BackgroundImage = global::ProjetPurplePong.Properties.Resources.PlayerGraphics;
            this.Joueur2.Location = new System.Drawing.Point(772, 200);
            this.Joueur2.Name = "Joueur2";
            this.Joueur2.Size = new System.Drawing.Size(16, 72);
            this.Joueur2.TabIndex = 1;
            this.Joueur2.TabStop = false;
            // 
            // Ball
            // 
            this.Ball.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ball.BackgroundImage = global::ProjetPurplePong.Properties.Resources.Ball;
            this.Ball.Location = new System.Drawing.Point(408, 242);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(13, 14);
            this.Ball.TabIndex = 2;
            this.Ball.TabStop = false;
            // 
            // ResponsiveInterface
            // 
            this.ResponsiveInterface.Enabled = true;
            this.ResponsiveInterface.Interval = 1;
            this.ResponsiveInterface.Tick += new System.EventHandler(this.ResponsiveInterface_Tick);
            // 
            // Scoreboard
            // 
            this.Scoreboard.AutoSize = true;
            this.Scoreboard.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Scoreboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scoreboard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Scoreboard.Location = new System.Drawing.Point(381, 9);
            this.Scoreboard.Name = "Scoreboard";
            this.Scoreboard.Size = new System.Drawing.Size(40, 20);
            this.Scoreboard.TabIndex = 3;
            this.Scoreboard.Text = "0          |          0";
            this.Scoreboard.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UpdateScore
            // 
            this.UpdateScore.Enabled = true;
            this.UpdateScore.Tick += new System.EventHandler(this.UpdateScore_Tick);
            // 
            // BallMovement
            // 
            this.BallMovement.Enabled = true;
            this.BallMovement.Interval = 1;
            this.BallMovement.Tick += new System.EventHandler(this.BallMovement_Tick);
            // 
            // labelVictory
            // 
            this.labelVictory.AutoSize = true;
            this.labelVictory.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelVictory.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVictory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelVictory.Location = new System.Drawing.Point(133, 146);
            this.labelVictory.Name = "labelVictory";
            this.labelVictory.Size = new System.Drawing.Size(558, 73);
            this.labelVictory.TabIndex = 4;
            this.labelVictory.Text = "Joueur 1 a gagné!";
            this.labelVictory.Visible = false;
            this.labelVictory.Click += new System.EventHandler(this.labelVictory_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(351, 242);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(93, 23);
            this.btnRestart.TabIndex = 5;
            this.btnRestart.Text = "Recommencer";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Visible = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // Pong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.labelVictory);
            this.Controls.Add(this.Scoreboard);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.Joueur2);
            this.Controls.Add(this.Joueur1);
            this.Name = "Pong";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Pong_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyPressed);
            ((System.ComponentModel.ISupportInitialize)(this.Joueur1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Joueur2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Joueur1;
        private System.Windows.Forms.PictureBox Joueur2;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Timer ResponsiveInterface;
        private System.Windows.Forms.Label Scoreboard;
        private System.Windows.Forms.Timer UpdateScore;
        private System.Windows.Forms.Timer BallMovement;
        private System.Windows.Forms.Label labelVictory;
        private System.Windows.Forms.Button btnRestart;
    }
}

