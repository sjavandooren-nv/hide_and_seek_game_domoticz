﻿namespace HideAndSeek
{
	partial class SeekerMainForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.btnShowFloorplan = new System.Windows.Forms.Button();
			this.btnSettings = new System.Windows.Forms.Button();
			this.btnGameStats = new System.Windows.Forms.Button();
			this.btnStartGame = new System.Windows.Forms.Button();
			this.btnCameras = new System.Windows.Forms.Button();
			this.btnGameHistory = new System.Windows.Forms.Button();
			this.lblTimer = new System.Windows.Forms.Label();
			this.Timer = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(273, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(232, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "This is the main page of the Seeker";
			// 
			// btnShowFloorplan
			// 
			this.btnShowFloorplan.Enabled = false;
			this.btnShowFloorplan.Location = new System.Drawing.Point(168, 252);
			this.btnShowFloorplan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnShowFloorplan.Name = "btnShowFloorplan";
			this.btnShowFloorplan.Size = new System.Drawing.Size(147, 132);
			this.btnShowFloorplan.TabIndex = 1;
			this.btnShowFloorplan.Text = "Map";
			this.btnShowFloorplan.UseVisualStyleBackColor = true;
			this.btnShowFloorplan.Click += new System.EventHandler(this.btnShowFloorplan_Click);
			// 
			// btnSettings
			// 
			this.btnSettings.Enabled = false;
			this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnSettings.Location = new System.Drawing.Point(12, 122);
			this.btnSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSettings.Name = "btnSettings";
			this.btnSettings.Size = new System.Drawing.Size(75, 49);
			this.btnSettings.TabIndex = 2;
			this.btnSettings.Text = "Settings";
			this.btnSettings.UseVisualStyleBackColor = true;
			this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
			// 
			// btnGameStats
			// 
			this.btnGameStats.Enabled = false;
			this.btnGameStats.Location = new System.Drawing.Point(12, 12);
			this.btnGameStats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnGameStats.Name = "btnGameStats";
			this.btnGameStats.Size = new System.Drawing.Size(75, 49);
			this.btnGameStats.TabIndex = 3;
			this.btnGameStats.Text = "Game Statistics";
			this.btnGameStats.UseVisualStyleBackColor = true;
			this.btnGameStats.Click += new System.EventHandler(this.btnGameStats_Click);
			// 
			// btnStartGame
			// 
			this.btnStartGame.Location = new System.Drawing.Point(231, 111);
			this.btnStartGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnStartGame.Name = "btnStartGame";
			this.btnStartGame.Size = new System.Drawing.Size(320, 90);
			this.btnStartGame.TabIndex = 4;
			this.btnStartGame.Text = "Start Game";
			this.btnStartGame.UseVisualStyleBackColor = true;
			this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
			// 
			// btnCameras
			// 
			this.btnCameras.Enabled = false;
			this.btnCameras.Location = new System.Drawing.Point(483, 252);
			this.btnCameras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCameras.Name = "btnCameras";
			this.btnCameras.Size = new System.Drawing.Size(147, 132);
			this.btnCameras.TabIndex = 5;
			this.btnCameras.Text = "Camera\'s";
			this.btnCameras.UseVisualStyleBackColor = true;
			this.btnCameras.Click += new System.EventHandler(this.btnCameras_Click);
			// 
			// btnGameHistory
			// 
			this.btnGameHistory.Enabled = false;
			this.btnGameHistory.Location = new System.Drawing.Point(12, 66);
			this.btnGameHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnGameHistory.Name = "btnGameHistory";
			this.btnGameHistory.Size = new System.Drawing.Size(75, 49);
			this.btnGameHistory.TabIndex = 6;
			this.btnGameHistory.Text = "Game History";
			this.btnGameHistory.UseVisualStyleBackColor = true;
			this.btnGameHistory.Click += new System.EventHandler(this.btnGameHistory_Click);
			// 
			// lblTimer
			// 
			this.lblTimer.AutoSize = true;
			this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTimer.Location = new System.Drawing.Point(561, 14);
			this.lblTimer.Name = "lblTimer";
			this.lblTimer.Size = new System.Drawing.Size(205, 48);
			this.lblTimer.TabIndex = 7;
			this.lblTimer.Text = "00:00.000";
			// 
			// Timer
			// 
			this.Timer.Interval = 1;
			this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
			// 
			// SeekerMainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblTimer);
			this.Controls.Add(this.btnGameHistory);
			this.Controls.Add(this.btnCameras);
			this.Controls.Add(this.btnStartGame);
			this.Controls.Add(this.btnGameStats);
			this.Controls.Add(this.btnSettings);
			this.Controls.Add(this.btnShowFloorplan);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "SeekerMainForm";
			this.Text = "SeekerMainForm";
			this.Load += new System.EventHandler(this.SeekerMainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnShowFloorplan;
		private System.Windows.Forms.Button btnSettings;
		private System.Windows.Forms.Button btnGameStats;
		private System.Windows.Forms.Button btnStartGame;
		private System.Windows.Forms.Button btnCameras;
		private System.Windows.Forms.Button btnGameHistory;
		private System.Windows.Forms.Label lblTimer;
		private System.Windows.Forms.Timer Timer;
	}
}