namespace HideAndSeek.Views
{
    partial class HiderUHal
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
            this.btnEndTurn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNW = new System.Windows.Forms.Button();
            this.btn_NE = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Location: U-hal";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(125, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(551, 230);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnNW
            // 
            this.btnNW.Location = new System.Drawing.Point(125, 274);
            this.btnNW.Name = "btnNW";
            this.btnNW.Size = new System.Drawing.Size(133, 68);
            this.btnNW.TabIndex = 11;
            this.btnNW.Text = "Go NorthWest";
            this.btnNW.UseVisualStyleBackColor = true;
            this.btnNW.Click += new System.EventHandler(this.btnUhal_Click);
            // 
            // btn_NE
            // 
            this.btn_NE.Location = new System.Drawing.Point(543, 274);
            this.btn_NE.Name = "btn_NE";
            this.btn_NE.Size = new System.Drawing.Size(133, 68);
            this.btn_NE.TabIndex = 10;
            this.btn_NE.Text = "Go NorthEast";
            this.btn_NE.UseVisualStyleBackColor = true;
            this.btn_NE.Click += new System.EventHandler(this.btn_WoonNorth_Click);
            // 
            // btnSouth
            // 
            this.btnSouth.Location = new System.Drawing.Point(404, 274);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(133, 68);
            this.btnSouth.TabIndex = 15;
            this.btnSouth.Text = "Go South";
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnWest
            // 
            this.btnWest.Location = new System.Drawing.Point(265, 274);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(133, 68);
            this.btnWest.TabIndex = 16;
            this.btnWest.Text = "Go West";
            this.btnWest.UseVisualStyleBackColor = true;
            this.btnWest.Click += new System.EventHandler(this.button2_Click);
            // 
            // HiderUHal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnWest);
            this.Controls.Add(this.btnSouth);
            this.Controls.Add(this.btnEndTurn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNW);
            this.Controls.Add(this.btn_NE);
            this.Name = "HiderUHal";
            this.Text = "HiderUHal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEndTurn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNW;
        private System.Windows.Forms.Button btn_NE;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btnWest;
    }
}