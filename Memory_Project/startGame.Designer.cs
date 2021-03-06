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
            this.menuStripSettings = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x6MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x4MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonMultiplayer
            // 
            this.buttonMultiplayer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonMultiplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiplayer.Location = new System.Drawing.Point(405, 41);
            this.buttonMultiplayer.Name = "buttonMultiplayer";
            this.buttonMultiplayer.Size = new System.Drawing.Size(85, 23);
            this.buttonMultiplayer.TabIndex = 0;
            this.buttonMultiplayer.Text = "Multiplayer";
            this.buttonMultiplayer.UseVisualStyleBackColor = false;
            this.buttonMultiplayer.Click += new System.EventHandler(this.buttonMultiplayer_Click);
            // 
            // buttonLeaderboard
            // 
            this.buttonLeaderboard.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLeaderboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLeaderboard.Location = new System.Drawing.Point(405, 70);
            this.buttonLeaderboard.Name = "buttonLeaderboard";
            this.buttonLeaderboard.Size = new System.Drawing.Size(85, 23);
            this.buttonLeaderboard.TabIndex = 1;
            this.buttonLeaderboard.Text = "Leaderboard";
            this.buttonLeaderboard.UseVisualStyleBackColor = false;
            this.buttonLeaderboard.Click += new System.EventHandler(this.buttonLeaderboard_Click);
            // 
            // buttonSingleplayer
            // 
            this.buttonSingleplayer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSingleplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSingleplayer.Location = new System.Drawing.Point(405, 12);
            this.buttonSingleplayer.Name = "buttonSingleplayer";
            this.buttonSingleplayer.Size = new System.Drawing.Size(85, 23);
            this.buttonSingleplayer.TabIndex = 2;
            this.buttonSingleplayer.Text = "Singleplayer";
            this.buttonSingleplayer.UseVisualStyleBackColor = false;
            this.buttonSingleplayer.Click += new System.EventHandler(this.buttonSingleplayer_Click);
            // 
            // menuStripSettings
            // 
            this.menuStripSettings.BackColor = System.Drawing.Color.Transparent;
            this.menuStripSettings.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStripSettings.Location = new System.Drawing.Point(0, 0);
            this.menuStripSettings.Name = "menuStripSettings";
            this.menuStripSettings.Size = new System.Drawing.Size(521, 24);
            this.menuStripSettings.TabIndex = 3;
            this.menuStripSettings.Text = "Settings";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.decksToolStripMenuItem,
            this.sizeToolStripMenuItem});
            this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // decksToolStripMenuItem
            // 
            this.decksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.musicToolStripMenuItem,
            this.memeToolStripMenuItem});
            this.decksToolStripMenuItem.Name = "decksToolStripMenuItem";
            this.decksToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.decksToolStripMenuItem.Text = "Decks";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gameToolStripMenuItem.Text = "Game";
            this.gameToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // musicToolStripMenuItem
            // 
            this.musicToolStripMenuItem.Name = "musicToolStripMenuItem";
            this.musicToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.musicToolStripMenuItem.Text = "Music";
            this.musicToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // memeToolStripMenuItem
            // 
            this.memeToolStripMenuItem.Name = "memeToolStripMenuItem";
            this.memeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.memeToolStripMenuItem.Text = "Meme";
            this.memeToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // sizeToolStripMenuItem
            // 
            this.sizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x6MenuItem,
            this.x4MenuItem});
            this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sizeToolStripMenuItem.Text = "Size";
            // 
            // x6MenuItem
            // 
            this.x6MenuItem.Name = "x6MenuItem";
            this.x6MenuItem.Size = new System.Drawing.Size(152, 22);
            this.x6MenuItem.Text = "6x6";
            this.x6MenuItem.Click += new System.EventHandler(this.ToolStripMenuItem2_Click);
            // 
            // x4MenuItem
            // 
            this.x4MenuItem.Name = "x4MenuItem";
            this.x4MenuItem.Size = new System.Drawing.Size(152, 22);
            this.x4MenuItem.Text = "4x4";
            this.x4MenuItem.Click += new System.EventHandler(this.ToolStripMenuItem2_Click);
            // 
            // startGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Memory_Project.Properties.Resources.Achtergrond2;
            this.ClientSize = new System.Drawing.Size(521, 511);
            this.Controls.Add(this.buttonSingleplayer);
            this.Controls.Add(this.buttonLeaderboard);
            this.Controls.Add(this.buttonMultiplayer);
            this.Controls.Add(this.menuStripSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripSettings;
            this.MaximizeBox = false;
            this.Name = "startGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory Game";
            this.menuStripSettings.ResumeLayout(false);
            this.menuStripSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMultiplayer;
        private System.Windows.Forms.Button buttonLeaderboard;
        private System.Windows.Forms.Button buttonSingleplayer;
        private System.Windows.Forms.MenuStrip menuStripSettings;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x6MenuItem;
        private System.Windows.Forms.ToolStripMenuItem x4MenuItem;
    }
}

