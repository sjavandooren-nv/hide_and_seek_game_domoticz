﻿namespace HideAndSeek.Views
{
    partial class HiderWoonSouth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HiderWoonSouth));
            this.btnEndTurn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNorth = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEndTurn
            // 
            this.btnEndTurn.Location = new System.Drawing.Point(356, 379);
            this.btnEndTurn.Name = "btnEndTurn";
            this.btnEndTurn.Size = new System.Drawing.Size(103, 50);
            this.btnEndTurn.TabIndex = 14;
            this.btnEndTurn.Text = "End turn";
            this.btnEndTurn.UseVisualStyleBackColor = true;
            this.btnEndTurn.Click += new System.EventHandler(this.btnEndTurn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Location: Woonruimte South";
            // 
            // btnNorth
            // 
            this.btnNorth.Location = new System.Drawing.Point(341, 274);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(133, 68);
            this.btnNorth.TabIndex = 11;
            this.btnNorth.Text = "Go North";
            this.btnNorth.UseVisualStyleBackColor = true;
            this.btnNorth.Click += new System.EventHandler(this.btnUhal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(614, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Time spent:";
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Location = new System.Drawing.Point(682, 379);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(0, 13);
            this.timerLabel.TabIndex = 15;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // HiderWoonSouth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.btnEndTurn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNorth);
            this.Name = "HiderWoonSouth";
            this.Text = "HiderWoonSouth";
            this.Load += new System.EventHandler(this.HiderWoonSouth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEndTurn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}