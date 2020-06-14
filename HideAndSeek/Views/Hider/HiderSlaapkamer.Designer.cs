namespace HideAndSeek.Views
{
    partial class HiderSlaapkamer
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
            this.btnNorth = new System.Windows.Forms.Button();
            this.btn_East = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEndTurn
            // 
            this.btnEndTurn.Location = new System.Drawing.Point(356, 379);
            this.btnEndTurn.Name = "btnEndTurn";
            this.btnEndTurn.Size = new System.Drawing.Size(103, 50);
            this.btnEndTurn.TabIndex = 9;
            this.btnEndTurn.Text = "End turn";
            this.btnEndTurn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Location: Slaapkamer";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(125, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(551, 230);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnNorth
            // 
            this.btnNorth.Location = new System.Drawing.Point(220, 274);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(133, 68);
            this.btnNorth.TabIndex = 6;
            this.btnNorth.Text = "Go North";
            this.btnNorth.UseVisualStyleBackColor = true;
            this.btnNorth.Click += new System.EventHandler(this.btnUhal_Click);
            // 
            // btn_East
            // 
            this.btn_East.Location = new System.Drawing.Point(463, 274);
            this.btn_East.Name = "btn_East";
            this.btn_East.Size = new System.Drawing.Size(133, 68);
            this.btn_East.TabIndex = 5;
            this.btn_East.Text = "Go East";
            this.btn_East.UseVisualStyleBackColor = true;
            this.btn_East.Click += new System.EventHandler(this.btn_WoonNorth_Click);
            // 
            // HiderSlaapkamer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEndTurn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNorth);
            this.Controls.Add(this.btn_East);
            this.Name = "HiderSlaapkamer";
            this.Text = "HiderSlaapkamer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEndTurn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Button btn_East;
    }
}