namespace HideAndSeek.Views
{
    partial class HiderPlayForm
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
            this.btn_North = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEndTurn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_North
            // 
            this.btn_North.Location = new System.Drawing.Point(470, 283);
            this.btn_North.Name = "btn_North";
            this.btn_North.Size = new System.Drawing.Size(133, 68);
            this.btn_North.TabIndex = 0;
            this.btn_North.Text = "Go North";
            this.btn_North.UseVisualStyleBackColor = true;
            this.btn_North.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSouth
            // 
            this.btnSouth.Location = new System.Drawing.Point(227, 283);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(133, 68);
            this.btnSouth.TabIndex = 1;
            this.btnSouth.Text = "Go South";
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(132, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(551, 230);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Location: Ingangshal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnEndTurn
            // 
            this.btnEndTurn.Location = new System.Drawing.Point(363, 388);
            this.btnEndTurn.Name = "btnEndTurn";
            this.btnEndTurn.Size = new System.Drawing.Size(103, 50);
            this.btnEndTurn.TabIndex = 4;
            this.btnEndTurn.Text = "End turn";
            this.btnEndTurn.UseVisualStyleBackColor = true;
            this.btnEndTurn.Click += new System.EventHandler(this.btnEndTurn_Click);
            // 
            // HiderPlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEndTurn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSouth);
            this.Controls.Add(this.btn_North);
            this.Name = "HiderPlayForm";
            this.Text = "Ingangshal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_North;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEndTurn;
    }
}