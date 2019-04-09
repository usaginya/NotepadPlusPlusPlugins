namespace TransparentWindow.Forms
{
    partial class TransparentWindowSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransparentWindowSettings));
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelTransparency = new System.Windows.Forms.Label();
            this.trackBarTransparency = new System.Windows.Forms.TrackBar();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTransparency)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonOK.Location = new System.Drawing.Point(174, 110);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(98, 43);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "确定";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelTransparency);
            this.groupBox1.Controls.Add(this.trackBarTransparency);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(374, 89);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "透明度(Transparency)";
            // 
            // labelTransparency
            // 
            this.labelTransparency.AutoSize = true;
            this.labelTransparency.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTransparency.Location = new System.Drawing.Point(337, 38);
            this.labelTransparency.Name = "labelTransparency";
            this.labelTransparency.Size = new System.Drawing.Size(29, 17);
            this.labelTransparency.TabIndex = 13;
            this.labelTransparency.Text = "250";
            // 
            // trackBarTransparency
            // 
            this.trackBarTransparency.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarTransparency.Location = new System.Drawing.Point(6, 36);
            this.trackBarTransparency.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBarTransparency.Maximum = 250;
            this.trackBarTransparency.Minimum = 50;
            this.trackBarTransparency.Name = "trackBarTransparency";
            this.trackBarTransparency.Size = new System.Drawing.Size(325, 45);
            this.trackBarTransparency.TabIndex = 12;
            this.trackBarTransparency.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarTransparency.Value = 250;
            this.trackBarTransparency.Scroll += new System.EventHandler(this.TrackBarTransparency_Scroll);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCancel.Location = new System.Drawing.Point(288, 110);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(98, 44);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // TransparentWindowSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 166);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonOK);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "TransparentWindowSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TransparentWindow Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TransparentWindowSettings_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTransparency)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelTransparency;
        private System.Windows.Forms.TrackBar trackBarTransparency;
        private System.Windows.Forms.Button buttonCancel;
    }
}