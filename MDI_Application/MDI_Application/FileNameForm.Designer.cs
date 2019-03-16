namespace MDI_Application
{
    partial class FileNameForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.WorkshopNameTextBox = new System.Windows.Forms.TextBox();
            this.WorkshopEnterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the name of the workshop you want to open!";
            // 
            // WorkshopNameTextBox
            // 
            this.WorkshopNameTextBox.Location = new System.Drawing.Point(301, 154);
            this.WorkshopNameTextBox.Name = "WorkshopNameTextBox";
            this.WorkshopNameTextBox.Size = new System.Drawing.Size(136, 20);
            this.WorkshopNameTextBox.TabIndex = 1;
            // 
            // WorkshopEnterButton
            // 
            this.WorkshopEnterButton.Location = new System.Drawing.Point(320, 200);
            this.WorkshopEnterButton.Name = "WorkshopEnterButton";
            this.WorkshopEnterButton.Size = new System.Drawing.Size(91, 23);
            this.WorkshopEnterButton.TabIndex = 2;
            this.WorkshopEnterButton.Text = "ENTER";
            this.WorkshopEnterButton.UseVisualStyleBackColor = true;
            this.WorkshopEnterButton.Click += new System.EventHandler(this.WorkshopEnterButton_Click);
            // 
            // FileNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 391);
            this.Controls.Add(this.WorkshopEnterButton);
            this.Controls.Add(this.WorkshopNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "FileNameForm";
            this.Text = "Enter File Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button WorkshopEnterButton;
        private System.Windows.Forms.TextBox WorkshopNameTextBox;
    }
}