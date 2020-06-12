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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapForm));
			this.imgMap = new System.Windows.Forms.PictureBox();
			this.btnChoose = new System.Windows.Forms.Button();
			this.btnReturn = new System.Windows.Forms.Button();
			this.lblTimer = new System.Windows.Forms.Label();
			this.btnKitchen = new System.Windows.Forms.Button();
			this.btnLivingRoomMiddle = new System.Windows.Forms.Button();
			this.btnBedroom = new System.Windows.Forms.Button();
			this.btnLivingRoomSouth = new System.Windows.Forms.Button();
			this.btnUHall = new System.Windows.Forms.Button();
			this.btnEntryHall = new System.Windows.Forms.Button();
			this.btnLivingRoomNorth = new System.Windows.Forms.Button();
			this.btnCloset = new System.Windows.Forms.Button();
			this.Timer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.imgMap)).BeginInit();
			this.SuspendLayout();
			// 
			// imgMap
			// 
			this.imgMap.Image = ((System.Drawing.Image)(resources.GetObject("imgMap.Image")));
			this.imgMap.InitialImage = null;
			this.imgMap.Location = new System.Drawing.Point(184, 13);
			this.imgMap.Name = "imgMap";
			this.imgMap.Size = new System.Drawing.Size(524, 640);
			this.imgMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgMap.TabIndex = 0;
			this.imgMap.TabStop = false;
			// 
			// btnChoose
			// 
			this.btnChoose.Enabled = false;
			this.btnChoose.Location = new System.Drawing.Point(20, 612);
			this.btnChoose.Name = "btnChoose";
			this.btnChoose.Size = new System.Drawing.Size(142, 40);
			this.btnChoose.TabIndex = 1;
			this.btnChoose.Text = "Choose Room";
			this.btnChoose.UseVisualStyleBackColor = true;
			this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
			// 
			// btnReturn
			// 
			this.btnReturn.Location = new System.Drawing.Point(20, 13);
			this.btnReturn.Name = "btnReturn";
			this.btnReturn.Size = new System.Drawing.Size(105, 35);
			this.btnReturn.TabIndex = 2;
			this.btnReturn.Text = "Return";
			this.btnReturn.UseVisualStyleBackColor = true;
			this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
			// 
			// lblTimer
			// 
			this.lblTimer.AutoSize = true;
			this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTimer.Location = new System.Drawing.Point(10, 70);
			this.lblTimer.Name = "lblTimer";
			this.lblTimer.Size = new System.Drawing.Size(168, 39);
			this.lblTimer.TabIndex = 3;
			this.lblTimer.Text = "00:00.000";
			// 
			// btnKitchen
			// 
			this.btnKitchen.Location = new System.Drawing.Point(242, 229);
			this.btnKitchen.Name = "btnKitchen";
			this.btnKitchen.Size = new System.Drawing.Size(88, 40);
			this.btnKitchen.TabIndex = 4;
			this.btnKitchen.Text = "Keuken";
			this.btnKitchen.UseVisualStyleBackColor = true;
			this.btnKitchen.Click += new System.EventHandler(this.btnKitchen_Click);
			// 
			// btnLivingRoomMiddle
			// 
			this.btnLivingRoomMiddle.Location = new System.Drawing.Point(379, 229);
			this.btnLivingRoomMiddle.Name = "btnLivingRoomMiddle";
			this.btnLivingRoomMiddle.Size = new System.Drawing.Size(88, 40);
			this.btnLivingRoomMiddle.TabIndex = 5;
			this.btnLivingRoomMiddle.Text = "Woonkamer midden";
			this.btnLivingRoomMiddle.UseVisualStyleBackColor = true;
			this.btnLivingRoomMiddle.Click += new System.EventHandler(this.btnLivingRoomMiddle_Click);
			// 
			// btnBedroom
			// 
			this.btnBedroom.Location = new System.Drawing.Point(312, 375);
			this.btnBedroom.Name = "btnBedroom";
			this.btnBedroom.Size = new System.Drawing.Size(88, 40);
			this.btnBedroom.TabIndex = 6;
			this.btnBedroom.Text = "Slaapkamer";
			this.btnBedroom.UseVisualStyleBackColor = true;
			this.btnBedroom.Click += new System.EventHandler(this.btnBedroom_Click);
			// 
			// btnLivingRoomSouth
			// 
			this.btnLivingRoomSouth.Location = new System.Drawing.Point(433, 516);
			this.btnLivingRoomSouth.Name = "btnLivingRoomSouth";
			this.btnLivingRoomSouth.Size = new System.Drawing.Size(88, 40);
			this.btnLivingRoomSouth.TabIndex = 7;
			this.btnLivingRoomSouth.Text = "Woonkamer Zuid";
			this.btnLivingRoomSouth.UseVisualStyleBackColor = true;
			this.btnLivingRoomSouth.Click += new System.EventHandler(this.btnLivingRoomSouth_Click);
			// 
			// btnUHall
			// 
			this.btnUHall.Location = new System.Drawing.Point(433, 404);
			this.btnUHall.Name = "btnUHall";
			this.btnUHall.Size = new System.Drawing.Size(88, 40);
			this.btnUHall.TabIndex = 8;
			this.btnUHall.Text = "U-gang";
			this.btnUHall.UseVisualStyleBackColor = true;
			this.btnUHall.Click += new System.EventHandler(this.btnUHall_Click);
			// 
			// btnEntryHall
			// 
			this.btnEntryHall.Location = new System.Drawing.Point(509, 280);
			this.btnEntryHall.Name = "btnEntryHall";
			this.btnEntryHall.Size = new System.Drawing.Size(88, 40);
			this.btnEntryHall.TabIndex = 9;
			this.btnEntryHall.Text = "Ingangshal";
			this.btnEntryHall.UseVisualStyleBackColor = true;
			this.btnEntryHall.Click += new System.EventHandler(this.btnEntryHall_Click);
			// 
			// btnLivingRoomNorth
			// 
			this.btnLivingRoomNorth.Location = new System.Drawing.Point(478, 85);
			this.btnLivingRoomNorth.Name = "btnLivingRoomNorth";
			this.btnLivingRoomNorth.Size = new System.Drawing.Size(88, 40);
			this.btnLivingRoomNorth.TabIndex = 10;
			this.btnLivingRoomNorth.Text = "Woonkamer Noord";
			this.btnLivingRoomNorth.UseVisualStyleBackColor = true;
			this.btnLivingRoomNorth.Click += new System.EventHandler(this.btnLivingRoomNorth_Click);
			// 
			// btnCloset
			// 
			this.btnCloset.Location = new System.Drawing.Point(384, 85);
			this.btnCloset.Name = "btnCloset";
			this.btnCloset.Size = new System.Drawing.Size(88, 40);
			this.btnCloset.TabIndex = 11;
			this.btnCloset.Text = "Inloopkast";
			this.btnCloset.UseVisualStyleBackColor = true;
			this.btnCloset.Click += new System.EventHandler(this.btnCloset_Click);
			// 
			// Timer
			// 
			this.Timer.Interval = 1;
			this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
			// 
			// MapForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(719, 664);
			this.Controls.Add(this.btnCloset);
			this.Controls.Add(this.btnLivingRoomNorth);
			this.Controls.Add(this.btnEntryHall);
			this.Controls.Add(this.btnUHall);
			this.Controls.Add(this.btnLivingRoomSouth);
			this.Controls.Add(this.btnBedroom);
			this.Controls.Add(this.btnLivingRoomMiddle);
			this.Controls.Add(this.btnKitchen);
			this.Controls.Add(this.lblTimer);
			this.Controls.Add(this.btnReturn);
			this.Controls.Add(this.btnChoose);
			this.Controls.Add(this.imgMap);
			this.Name = "MapForm";
			this.Text = "MapForm";
			this.Load += new System.EventHandler(this.MapForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.imgMap)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox imgMap;
		private System.Windows.Forms.Button btnChoose;
		private System.Windows.Forms.Button btnReturn;
		private System.Windows.Forms.Label lblTimer;
		private System.Windows.Forms.Button btnKitchen;
		private System.Windows.Forms.Button btnLivingRoomMiddle;
		private System.Windows.Forms.Button btnBedroom;
		private System.Windows.Forms.Button btnLivingRoomSouth;
		private System.Windows.Forms.Button btnUHall;
		private System.Windows.Forms.Button btnEntryHall;
		private System.Windows.Forms.Button btnLivingRoomNorth;
		private System.Windows.Forms.Button btnCloset;
		private System.Windows.Forms.Timer Timer;
	}
}