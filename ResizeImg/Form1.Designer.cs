namespace ResizeImg
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.TxtBoxLoad = new System.Windows.Forms.TextBox();
            this.TxtTotales = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelDone = new System.Windows.Forms.Label();
            this.TxtW = new System.Windows.Forms.TextBox();
            this.TxtH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ImgDone = new System.Windows.Forms.PictureBox();
            this.GoToGithub = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgDone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoToGithub)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.PeachPuff;
            this.BtnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStart.FlatAppearance.BorderSize = 2;
            this.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnStart.Location = new System.Drawing.Point(12, 56);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(447, 56);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.Text = "Start Resize";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnLoad
            // 
            this.BtnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoad.Location = new System.Drawing.Point(384, 10);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(75, 20);
            this.BtnLoad.TabIndex = 1;
            this.BtnLoad.Text = "Load ...";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // TxtBoxLoad
            // 
            this.TxtBoxLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxLoad.Location = new System.Drawing.Point(53, 12);
            this.TxtBoxLoad.Name = "TxtBoxLoad";
            this.TxtBoxLoad.Size = new System.Drawing.Size(325, 18);
            this.TxtBoxLoad.TabIndex = 2;
            this.TxtBoxLoad.Text = "Chose your folder ...";
            // 
            // TxtTotales
            // 
            this.TxtTotales.AutoSize = true;
            this.TxtTotales.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TxtTotales.Location = new System.Drawing.Point(258, 115);
            this.TxtTotales.Name = "TxtTotales";
            this.TxtTotales.Size = new System.Drawing.Size(16, 13);
            this.TxtTotales.TabIndex = 3;
            this.TxtTotales.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(193, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Totales files :";
            // 
            // LabelDone
            // 
            this.LabelDone.AutoSize = true;
            this.LabelDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDone.ForeColor = System.Drawing.Color.Maroon;
            this.LabelDone.Location = new System.Drawing.Point(362, 117);
            this.LabelDone.Name = "LabelDone";
            this.LabelDone.Size = new System.Drawing.Size(0, 13);
            this.LabelDone.TabIndex = 5;
            // 
            // TxtW
            // 
            this.TxtW.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtW.Location = new System.Drawing.Point(53, 33);
            this.TxtW.Name = "TxtW";
            this.TxtW.Size = new System.Drawing.Size(41, 18);
            this.TxtW.TabIndex = 6;
            this.TxtW.Text = "3200";
            // 
            // TxtH
            // 
            this.TxtH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtH.Location = new System.Drawing.Point(313, 33);
            this.TxtH.Name = "TxtH";
            this.TxtH.Size = new System.Drawing.Size(41, 18);
            this.TxtH.TabIndex = 7;
            this.TxtH.Text = "2200";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Width :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(266, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Height :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(12, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Path :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(354, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "px";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(94, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "px";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(2, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Copyright Abdessalam 2022.";
            // 
            // ImgDone
            // 
            this.ImgDone.Image = ((System.Drawing.Image)(resources.GetObject("ImgDone.Image")));
            this.ImgDone.Location = new System.Drawing.Point(395, 115);
            this.ImgDone.Name = "ImgDone";
            this.ImgDone.Size = new System.Drawing.Size(17, 16);
            this.ImgDone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgDone.TabIndex = 15;
            this.ImgDone.TabStop = false;
            this.ImgDone.Visible = false;
            // 
            // GoToGithub
            // 
            this.GoToGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoToGithub.Image = ((System.Drawing.Image)(resources.GetObject("GoToGithub.Image")));
            this.GoToGithub.Location = new System.Drawing.Point(448, 120);
            this.GoToGithub.Name = "GoToGithub";
            this.GoToGithub.Size = new System.Drawing.Size(17, 16);
            this.GoToGithub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GoToGithub.TabIndex = 16;
            this.GoToGithub.TabStop = false;
            this.GoToGithub.Click += new System.EventHandler(this.GoToGithub_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 140);
            this.Controls.Add(this.GoToGithub);
            this.Controls.Add(this.ImgDone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtH);
            this.Controls.Add(this.TxtW);
            this.Controls.Add(this.LabelDone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtTotales);
            this.Controls.Add(this.TxtBoxLoad);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resize images";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImgDone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoToGithub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.TextBox TxtBoxLoad;
        private System.Windows.Forms.Label TxtTotales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelDone;
        private System.Windows.Forms.TextBox TxtW;
        private System.Windows.Forms.TextBox TxtH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox ImgDone;
        private System.Windows.Forms.PictureBox GoToGithub;
    }
}

