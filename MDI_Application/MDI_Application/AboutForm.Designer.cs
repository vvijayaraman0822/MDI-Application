namespace MDI_Application
{
    partial class AboutForm
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
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.AboutLabel = new System.Windows.Forms.Label();
            this.ProgramLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.StoreMangerLabel = new System.Windows.Forms.Label();
            this.VersionAnswerLabel = new System.Windows.Forms.Label();
            this.VasLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AboutLabel
            // 
            this.AboutLabel.AutoSize = true;
            this.AboutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutLabel.Location = new System.Drawing.Point(212, 27);
            this.AboutLabel.Name = "AboutLabel";
            this.AboutLabel.Size = new System.Drawing.Size(136, 39);
            this.AboutLabel.TabIndex = 0;
            this.AboutLabel.Text = "ABOUT";
            // 
            // ProgramLabel
            // 
            this.ProgramLabel.AutoSize = true;
            this.ProgramLabel.Location = new System.Drawing.Point(197, 90);
            this.ProgramLabel.Name = "ProgramLabel";
            this.ProgramLabel.Size = new System.Drawing.Size(49, 13);
            this.ProgramLabel.TabIndex = 1;
            this.ProgramLabel.Text = "Program:";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(197, 131);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(45, 13);
            this.VersionLabel.TabIndex = 2;
            this.VersionLabel.Text = "Version:";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(197, 170);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(41, 13);
            this.AuthorLabel.TabIndex = 3;
            this.AuthorLabel.Text = "Author:";
            // 
            // StoreMangerLabel
            // 
            this.StoreMangerLabel.AutoSize = true;
            this.StoreMangerLabel.Location = new System.Drawing.Point(305, 90);
            this.StoreMangerLabel.Name = "StoreMangerLabel";
            this.StoreMangerLabel.Size = new System.Drawing.Size(77, 13);
            this.StoreMangerLabel.TabIndex = 4;
            this.StoreMangerLabel.Text = "Store Manager";
            // 
            // VersionAnswerLabel
            // 
            this.VersionAnswerLabel.AutoSize = true;
            this.VersionAnswerLabel.Location = new System.Drawing.Point(317, 131);
            this.VersionAnswerLabel.Name = "VersionAnswerLabel";
            this.VersionAnswerLabel.Size = new System.Drawing.Size(31, 13);
            this.VersionAnswerLabel.TabIndex = 5;
            this.VersionAnswerLabel.Text = "2.3.2";
            // 
            // VasLabel
            // 
            this.VasLabel.AutoSize = true;
            this.VasLabel.Location = new System.Drawing.Point(305, 170);
            this.VasLabel.Name = "VasLabel";
            this.VasLabel.Size = new System.Drawing.Size(109, 13);
            this.VasLabel.TabIndex = 6;
            this.VasLabel.Text = "Vasudev Vijayaraman";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 261);
            this.Controls.Add(this.VasLabel);
            this.Controls.Add(this.VersionAnswerLabel);
            this.Controls.Add(this.StoreMangerLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.ProgramLabel);
            this.Controls.Add(this.AboutLabel);
            this.Name = "AboutForm";
            this.Text = "About ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Label AboutLabel;
        private System.Windows.Forms.Label ProgramLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label StoreMangerLabel;
        private System.Windows.Forms.Label VersionAnswerLabel;
        private System.Windows.Forms.Label VasLabel;
    }
}