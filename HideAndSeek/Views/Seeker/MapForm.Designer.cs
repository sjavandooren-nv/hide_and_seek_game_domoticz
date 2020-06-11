namespace HideAndSeek.Views
{
	partial class MapForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapForm));
			this.imgMap = new System.Windows.Forms.PictureBox();
			this.btnChoose = new System.Windows.Forms.Button();
			this.btnReturn = new System.Windows.Forms.Button();
			this.lblTimer = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.imgMap)).BeginInit();
			this.SuspendLayout();
			// 
			// imgMap
			// 
			this.imgMap.Image = ((System.Drawing.Image)(resources.GetObject("imgMap.Image")));
			this.imgMap.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgMap.InitialImage")));
			this.imgMap.Location = new System.Drawing.Point(245, 16);
			this.imgMap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.imgMap.Name = "imgMap";
			this.imgMap.Size = new System.Drawing.Size(524, 646);
			this.imgMap.TabIndex = 0;
			this.imgMap.TabStop = false;
			// 
			// btnChoose
			// 
			this.btnChoose.Enabled = false;
			this.btnChoose.Location = new System.Drawing.Point(25, 597);
			this.btnChoose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnChoose.Name = "btnChoose";
			this.btnChoose.Size = new System.Drawing.Size(189, 49);
			this.btnChoose.TabIndex = 1;
			this.btnChoose.Text = "Choose Room";
			this.btnChoose.UseVisualStyleBackColor = true;
			this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
			// 
			// btnReturn
			// 
			this.btnReturn.Location = new System.Drawing.Point(27, 16);
			this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnReturn.Name = "btnReturn";
			this.btnReturn.Size = new System.Drawing.Size(140, 43);
			this.btnReturn.TabIndex = 2;
			this.btnReturn.Text = "Return";
			this.btnReturn.UseVisualStyleBackColor = true;
			this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
			// 
			// lblTimer
			// 
			this.lblTimer.AutoSize = true;
			this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTimer.Location = new System.Drawing.Point(17, 85);
			this.lblTimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTimer.Name = "lblTimer";
			this.lblTimer.Size = new System.Drawing.Size(182, 48);
			this.lblTimer.TabIndex = 3;
			this.lblTimer.Text = "00:00:00";
			// 
			// MapForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(791, 674);
			this.Controls.Add(this.lblTimer);
			this.Controls.Add(this.btnReturn);
			this.Controls.Add(this.btnChoose);
			this.Controls.Add(this.imgMap);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "MapForm";
			this.Text = "MapForm";
			((System.ComponentModel.ISupportInitialize)(this.imgMap)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox imgMap;
		private System.Windows.Forms.Button btnChoose;
		private System.Windows.Forms.Button btnReturn;
		private System.Windows.Forms.Label lblTimer;
	}
}