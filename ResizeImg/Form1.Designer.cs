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
            this.components = new System.ComponentModel.Container();
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
            this.RdButtonSQ = new System.Windows.Forms.RadioButton();
            this.RdButtonHQ = new System.Windows.Forms.RadioButton();
            this.PanelQuality = new System.Windows.Forms.Panel();
            this.CheckBoxCond = new System.Windows.Forms.CheckBox();
            this.TxtBoxWCond = new System.Windows.Forms.TextBox();
            this.PanelType = new System.Windows.Forms.Panel();
            this.RdButtonTif = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ImgDone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoToGithub)).BeginInit();
            this.PanelQuality.SuspendLayout();
            this.PanelType.SuspendLayout();
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
            this.BtnStart.TabIndex = 13;
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
            this.BtnLoad.TabIndex = 5;
            this.BtnLoad.Text = "Load ...";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // TxtBoxLoad
            // 
            this.TxtBoxLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxLoad.Location = new System.Drawing.Point(53, 12);
            this.TxtBoxLoad.Name = "TxtBoxLoad";
            this.TxtBoxLoad.ReadOnly = true;
            this.TxtBoxLoad.Size = new System.Drawing.Size(325, 18);
            this.TxtBoxLoad.TabIndex = 4;
            this.TxtBoxLoad.Text = "Chose your folder ...";
            // 
            // TxtTotales
            // 
            this.TxtTotales.AutoSize = true;
            this.TxtTotales.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TxtTotales.Location = new System.Drawing.Point(258, 139);
            this.TxtTotales.Name = "TxtTotales";
            this.TxtTotales.Size = new System.Drawing.Size(16, 13);
            this.TxtTotales.TabIndex = 3;
            this.TxtTotales.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(193, 139);
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
            this.LabelDone.Location = new System.Drawing.Point(362, 141);
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
            this.TxtW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtW_KeyPress);
            // 
            // TxtH
            // 
            this.TxtH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtH.Location = new System.Drawing.Point(161, 33);
            this.TxtH.Name = "TxtH";
            this.TxtH.Size = new System.Drawing.Size(41, 18);
            this.TxtH.TabIndex = 7;
            this.TxtH.Text = "2200";
            this.TxtH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtH_KeyPress);
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
            this.label3.Location = new System.Drawing.Point(114, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Height :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
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
            this.label5.Location = new System.Drawing.Point(202, 36);
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
            this.label7.Location = new System.Drawing.Point(2, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Copyright © Abdessalam 2022.";
            // 
            // ImgDone
            // 
            this.ImgDone.Image = ((System.Drawing.Image)(resources.GetObject("ImgDone.Image")));
            this.ImgDone.Location = new System.Drawing.Point(395, 139);
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
            this.GoToGithub.Location = new System.Drawing.Point(446, 139);
            this.GoToGithub.Name = "GoToGithub";
            this.GoToGithub.Size = new System.Drawing.Size(17, 16);
            this.GoToGithub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GoToGithub.TabIndex = 16;
            this.GoToGithub.TabStop = false;
            this.toolTip1.SetToolTip(this.GoToGithub, "Go to Github.");
            this.GoToGithub.Click += new System.EventHandler(this.GoToGithub_Click);
            // 
            // RdButtonSQ
            // 
            this.RdButtonSQ.AutoSize = true;
            this.RdButtonSQ.Checked = true;
            this.RdButtonSQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RdButtonSQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdButtonSQ.ForeColor = System.Drawing.Color.DimGray;
            this.RdButtonSQ.Location = new System.Drawing.Point(3, 4);
            this.RdButtonSQ.Name = "RdButtonSQ";
            this.RdButtonSQ.Size = new System.Drawing.Size(103, 17);
            this.RdButtonSQ.TabIndex = 9;
            this.RdButtonSQ.TabStop = true;
            this.RdButtonSQ.Text = "Standard Quality";
            this.RdButtonSQ.UseVisualStyleBackColor = true;
            this.RdButtonSQ.CheckedChanged += new System.EventHandler(this.RdButtonSQ_CheckedChanged);
            // 
            // RdButtonHQ
            // 
            this.RdButtonHQ.AutoSize = true;
            this.RdButtonHQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RdButtonHQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdButtonHQ.ForeColor = System.Drawing.Color.OrangeRed;
            this.RdButtonHQ.Location = new System.Drawing.Point(112, 3);
            this.RdButtonHQ.Name = "RdButtonHQ";
            this.RdButtonHQ.Size = new System.Drawing.Size(84, 17);
            this.RdButtonHQ.TabIndex = 10;
            this.RdButtonHQ.Text = "Hight Quality";
            this.RdButtonHQ.UseVisualStyleBackColor = true;
            // 
            // PanelQuality
            // 
            this.PanelQuality.BackColor = System.Drawing.Color.Transparent;
            this.PanelQuality.Controls.Add(this.RdButtonHQ);
            this.PanelQuality.Controls.Add(this.RdButtonSQ);
            this.PanelQuality.Location = new System.Drawing.Point(12, 114);
            this.PanelQuality.Name = "PanelQuality";
            this.PanelQuality.Size = new System.Drawing.Size(208, 24);
            this.PanelQuality.TabIndex = 8;
            // 
            // CheckBoxCond
            // 
            this.CheckBoxCond.AutoSize = true;
            this.CheckBoxCond.BackColor = System.Drawing.Color.Transparent;
            this.CheckBoxCond.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckBoxCond.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxCond.ForeColor = System.Drawing.Color.Navy;
            this.CheckBoxCond.Location = new System.Drawing.Point(280, 117);
            this.CheckBoxCond.Name = "CheckBoxCond";
            this.CheckBoxCond.Size = new System.Drawing.Size(135, 17);
            this.CheckBoxCond.TabIndex = 11;
            this.CheckBoxCond.Text = "Add Condition: width < ";
            this.CheckBoxCond.UseVisualStyleBackColor = false;
            this.CheckBoxCond.CheckedChanged += new System.EventHandler(this.CheckBoxCond_CheckedChanged);
            // 
            // TxtBoxWCond
            // 
            this.TxtBoxWCond.Enabled = false;
            this.TxtBoxWCond.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxWCond.Location = new System.Drawing.Point(408, 116);
            this.TxtBoxWCond.Name = "TxtBoxWCond";
            this.TxtBoxWCond.Size = new System.Drawing.Size(51, 18);
            this.TxtBoxWCond.TabIndex = 12;
            this.TxtBoxWCond.Text = "3000";
            this.TxtBoxWCond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxWCond_KeyPress);
            // 
            // PanelType
            // 
            this.PanelType.BackColor = System.Drawing.Color.Transparent;
            this.PanelType.Controls.Add(this.label8);
            this.PanelType.Controls.Add(this.RdButtonTif);
            this.PanelType.Controls.Add(this.radioButton2);
            this.PanelType.Location = new System.Drawing.Point(219, 33);
            this.PanelType.Name = "PanelType";
            this.PanelType.Size = new System.Drawing.Size(240, 24);
            this.PanelType.TabIndex = 1;
            // 
            // RdButtonTif
            // 
            this.RdButtonTif.AutoSize = true;
            this.RdButtonTif.Checked = true;
            this.RdButtonTif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RdButtonTif.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdButtonTif.ForeColor = System.Drawing.Color.DimGray;
            this.RdButtonTif.Location = new System.Drawing.Point(97, 3);
            this.RdButtonTif.Name = "RdButtonTif";
            this.RdButtonTif.Size = new System.Drawing.Size(39, 17);
            this.RdButtonTif.TabIndex = 2;
            this.RdButtonTif.TabStop = true;
            this.RdButtonTif.Text = "TIF";
            this.toolTip1.SetToolTip(this.RdButtonTif, "Chose your type befor you click Load Button.");
            this.RdButtonTif.UseVisualStyleBackColor = true;
            this.RdButtonTif.CheckedChanged += new System.EventHandler(this.RdButtonTif_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.OrangeRed;
            this.radioButton2.Location = new System.Drawing.Point(145, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(99, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "All format image";
            this.toolTip1.SetToolTip(this.radioButton2, "Chose your type befor you click Load Button.");
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(8, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Chose your type :";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 163);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.PanelType);
            this.Controls.Add(this.TxtBoxWCond);
            this.Controls.Add(this.CheckBoxCond);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelQuality);
            this.Controls.Add(this.GoToGithub);
            this.Controls.Add(this.ImgDone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtH);
            this.Controls.Add(this.TxtW);
            this.Controls.Add(this.LabelDone);
            this.Controls.Add(this.TxtTotales);
            this.Controls.Add(this.TxtBoxLoad);
            this.Controls.Add(this.BtnLoad);
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
            this.PanelQuality.ResumeLayout(false);
            this.PanelQuality.PerformLayout();
            this.PanelType.ResumeLayout(false);
            this.PanelType.PerformLayout();
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
        private System.Windows.Forms.RadioButton RdButtonSQ;
        private System.Windows.Forms.RadioButton RdButtonHQ;
        private System.Windows.Forms.Panel PanelQuality;
        private System.Windows.Forms.CheckBox CheckBoxCond;
        private System.Windows.Forms.TextBox TxtBoxWCond;
        private System.Windows.Forms.Panel PanelType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton RdButtonTif;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

