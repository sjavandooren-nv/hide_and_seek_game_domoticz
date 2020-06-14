namespace HideAndSeek.Views
{
    partial class HiderWoonMiddle
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
            this.btnSouth = new System.Windows.Forms.Button();
            this.btn_West = new System.Windows.Forms.Button();
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
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Location: Woonruimte Middle";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(125, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(551, 230);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnSouth
            // 
            this.btnSouth.Location = new System.Drawing.Point(458, 274);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(133, 68);
            this.btnSouth.TabIndex = 11;
            this.btnSouth.Text = "Go South";
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.Click += new System.EventHandler(this.btnUhal_Click);
            // 
            // btn_West
            // 
            this.btn_West.Location = new System.Drawing.Point(224, 274);
            this.btn_West.Name = "btn_West";
            this.btn_West.Size = new System.Drawing.Size(133, 68);
            this.btn_West.TabIndex = 10;
            this.btn_West.Text = "Go West";
            this.btn_West.UseVisualStyleBackColor = true;
            this.btn_West.Click += new System.EventHandler(this.btn_WoonNorth_Click);
            // 
            // HiderWoonMiddle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEndTurn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSouth);
            this.Controls.Add(this.btn_West);
            this.Name = "HiderWoonMiddle";
            this.Text = "HiderWoonMiddle";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEndTurn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btn_West;
    }
}