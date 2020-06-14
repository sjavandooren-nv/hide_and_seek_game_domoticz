namespace HideAndSeek.Views
{
	partial class HiderMainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnHiderPlay = new System.Windows.Forms.Button();
            this.btnFloorPlanHider = new System.Windows.Forms.Button();
            this.btnGameHistory = new System.Windows.Forms.Button();
            this.btnShowStats = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "This is the main page of the Hider";
            // 
            // btnHiderPlay
            // 
            this.btnHiderPlay.Location = new System.Drawing.Point(247, 79);
            this.btnHiderPlay.Name = "btnHiderPlay";
            this.btnHiderPlay.Size = new System.Drawing.Size(87, 23);
            this.btnHiderPlay.TabIndex = 1;
            this.btnHiderPlay.Text = "Play";
            this.btnHiderPlay.UseVisualStyleBackColor = true;
            this.btnHiderPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFloorPlanHider
            // 
            this.btnFloorPlanHider.Location = new System.Drawing.Point(247, 108);
            this.btnFloorPlanHider.Name = "btnFloorPlanHider";
            this.btnFloorPlanHider.Size = new System.Drawing.Size(87, 23);
            this.btnFloorPlanHider.TabIndex = 2;
            this.btnFloorPlanHider.Text = "Floor Plan";
            this.btnFloorPlanHider.UseVisualStyleBackColor = true;
            this.btnFloorPlanHider.Click += new System.EventHandler(this.btnFloorPlanHider_Click);
            // 
            // btnGameHistory
            // 
            this.btnGameHistory.Location = new System.Drawing.Point(247, 193);
            this.btnGameHistory.Name = "btnGameHistory";
            this.btnGameHistory.Size = new System.Drawing.Size(87, 23);
            this.btnGameHistory.TabIndex = 3;
            this.btnGameHistory.Text = "Game History";
            this.btnGameHistory.UseVisualStyleBackColor = true;
            this.btnGameHistory.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnShowStats
            // 
            this.btnShowStats.Location = new System.Drawing.Point(247, 222);
            this.btnShowStats.Name = "btnShowStats";
            this.btnShowStats.Size = new System.Drawing.Size(87, 23);
            this.btnShowStats.TabIndex = 4;
            this.btnShowStats.Text = "Show Stats";
            this.btnShowStats.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(501, 331);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // HiderMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShowStats);
            this.Controls.Add(this.btnGameHistory);
            this.Controls.Add(this.btnFloorPlanHider);
            this.Controls.Add(this.btnHiderPlay);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HiderMainForm";
            this.Text = "HiderMainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHiderPlay;
        private System.Windows.Forms.Button btnFloorPlanHider;
        private System.Windows.Forms.Button btnGameHistory;
        private System.Windows.Forms.Button btnShowStats;
        private System.Windows.Forms.Button btnExit;
    }
}