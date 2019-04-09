namespace TransparentWindow.Forms
{
    partial class AboutDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutDialog));
            this.buttonGithub = new System.Windows.Forms.Button();
            this.labelAbout = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGithub
            // 
            this.buttonGithub.Location = new System.Drawing.Point(14, 151);
            this.buttonGithub.Margin = new System.Windows.Forms.Padding(5);
            this.buttonGithub.Name = "buttonGithub";
            this.buttonGithub.Size = new System.Drawing.Size(95, 46);
            this.buttonGithub.TabIndex = 2;
            this.buttonGithub.Text = "GitHub";
            this.buttonGithub.UseVisualStyleBackColor = true;
            this.buttonGithub.Click += new System.EventHandler(this.ButtonGithub_Click);
            // 
            // labelAbout
            // 
            this.labelAbout.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAbout.Location = new System.Drawing.Point(14, 9);
            this.labelAbout.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.Size = new System.Drawing.Size(471, 137);
            this.labelAbout.TabIndex = 0;
            this.labelAbout.Text = ">ω<";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(390, 151);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(5);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(95, 46);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // AboutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 211);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelAbout);
            this.Controls.Add(this.buttonGithub);
            this.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "AboutDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGithub;
        private System.Windows.Forms.Label labelAbout;
        private System.Windows.Forms.Button buttonOK;
    }
}