﻿namespace Memory_Project
{
    partial class startGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startGame));
            this.buttonMultiplayer = new System.Windows.Forms.Button();
            this.buttonLeaderboard = new System.Windows.Forms.Button();
            this.buttonSingleplayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMultiplayer
            // 
            this.buttonMultiplayer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonMultiplayer.Location = new System.Drawing.Point(580, 69);
            this.buttonMultiplayer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonMultiplayer.Name = "buttonMultiplayer";
            this.buttonMultiplayer.Size = new System.Drawing.Size(112, 35);
            this.buttonMultiplayer.TabIndex = 0;
            this.buttonMultiplayer.Text = "Multiplayer";
            this.buttonMultiplayer.UseVisualStyleBackColor = false;
            this.buttonMultiplayer.Click += new System.EventHandler(this.buttonMultiplayer_Click);
            // 
            // buttonLeaderboard
            // 
            this.buttonLeaderboard.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLeaderboard.Location = new System.Drawing.Point(580, 114);
            this.buttonLeaderboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLeaderboard.Name = "buttonLeaderboard";
            this.buttonLeaderboard.Size = new System.Drawing.Size(112, 35);
            this.buttonLeaderboard.TabIndex = 1;
            this.buttonLeaderboard.Text = "Leaderboard";
            this.buttonLeaderboard.UseVisualStyleBackColor = false;
            // 
            // buttonSingleplayer
            // 
            this.buttonSingleplayer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSingleplayer.Location = new System.Drawing.Point(580, 24);
            this.buttonSingleplayer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSingleplayer.Name = "buttonSingleplayer";
            this.buttonSingleplayer.Size = new System.Drawing.Size(112, 35);
            this.buttonSingleplayer.TabIndex = 2;
            this.buttonSingleplayer.Text = "Singleplayer";
            this.buttonSingleplayer.UseVisualStyleBackColor = false;
            this.buttonSingleplayer.Click += new System.EventHandler(this.buttonSingleplayer_Click);
            // 
            // startGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Memory_Project.Properties.Resources.startFormBG;
            this.ClientSize = new System.Drawing.Size(764, 786);
            this.Controls.Add(this.buttonSingleplayer);
            this.Controls.Add(this.buttonLeaderboard);
            this.Controls.Add(this.buttonMultiplayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "startGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMultiplayer;
        private System.Windows.Forms.Button buttonLeaderboard;
        private System.Windows.Forms.Button buttonSingleplayer;
    }
}

