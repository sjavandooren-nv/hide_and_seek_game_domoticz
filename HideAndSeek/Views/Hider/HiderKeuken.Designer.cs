namespace HideAndSeek.Views
{
    partial class HiderKeuken
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
            this.btnEndTurn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSouth = new System.Windows.Forms.Button();
            this.btn_East = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.timerKeuken = new System.Windows.Forms.Timer(this.components);
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
            this.label1.Location = new System.Drawing.Point(353, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Location: Keuken";
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
            this.btnSouth.Location = new System.Drawing.Point(220, 274);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(133, 68);
            this.btnSouth.TabIndex = 11;
            this.btnSouth.Text = "Go South";
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.Click += new System.EventHandler(this.btnUhal_Click);
            // 
            // btn_East
            // 
            this.btn_East.Location = new System.Drawing.Point(463, 274);
            this.btn_East.Name = "btn_East";
            this.btn_East.Size = new System.Drawing.Size(133, 68);
            this.btn_East.TabIndex = 10;
            this.btn_East.Text = "Go East";
            this.btn_East.UseVisualStyleBackColor = true;
            this.btn_East.Click += new System.EventHandler(this.btn_WoonNorth_Click);
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
            this.timerLabel.Click += new System.EventHandler(this.timerLabel_Click);
            // 
            // timerKeuken
            // 
            this.timerKeuken.Enabled = true;
            this.timerKeuken.Interval = 1000;
            this.timerKeuken.Tick += new System.EventHandler(this.timerKeuken_Tick);
            // 
            // HiderKeuken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.btnEndTurn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSouth);
            this.Controls.Add(this.btn_East);
            this.Name = "HiderKeuken";
            this.Text = "HiderKeuken";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEndTurn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btn_East;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Timer timerKeuken;
    }
}