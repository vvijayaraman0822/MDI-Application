namespace MDI_Application
{
    partial class TableForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.ContentLabel = new System.Windows.Forms.Label();
            this.ContentListView = new System.Windows.Forms.ListView();
            this.ListID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SaveChanges = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.NoteLabel = new System.Windows.Forms.Label();
            this.SortCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ContentLabel
            // 
            this.ContentLabel.AutoSize = true;
            this.ContentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContentLabel.Location = new System.Drawing.Point(191, 28);
            this.ContentLabel.Name = "ContentLabel";
            this.ContentLabel.Size = new System.Drawing.Size(187, 24);
            this.ContentLabel.TabIndex = 1;
            this.ContentLabel.Text = "Title of the Workshop";
            // 
            // ContentListView
            // 
            this.ContentListView.AllowColumnReorder = true;
            this.ContentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ListID,
            this.ListName,
            this.ListQuantity,
            this.ListPrice});
            this.ContentListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.ContentListView.Location = new System.Drawing.Point(53, 73);
            this.ContentListView.Name = "ContentListView";
            this.ContentListView.Size = new System.Drawing.Size(492, 350);
            this.ContentListView.TabIndex = 2;
            this.ContentListView.UseCompatibleStateImageBehavior = false;
            this.ContentListView.View = System.Windows.Forms.View.Details;
            // 
            // ListID
            // 
            this.ListID.Text = "ID";
            this.ListID.Width = 126;
            // 
            // ListName
            // 
            this.ListName.Text = "Name";
            this.ListName.Width = 132;
            // 
            // ListQuantity
            // 
            this.ListQuantity.Text = "Quantity";
            this.ListQuantity.Width = 107;
            // 
            // ListPrice
            // 
            this.ListPrice.Text = "Price";
            this.ListPrice.Width = 121;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(607, 148);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(607, 203);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 4;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // SaveChanges
            // 
            this.SaveChanges.Location = new System.Drawing.Point(453, 429);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(92, 23);
            this.SaveChanges.TabIndex = 5;
            this.SaveChanges.Text = "Save";
            this.SaveChanges.UseVisualStyleBackColor = true;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(607, 261);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // NoteLabel
            // 
            this.NoteLabel.AutoSize = true;
            this.NoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteLabel.Location = new System.Drawing.Point(562, 342);
            this.NoteLabel.Name = "NoteLabel";
            this.NoteLabel.Size = new System.Drawing.Size(318, 18);
            this.NoteLabel.TabIndex = 7;
            this.NoteLabel.Text = "When updating, please select the item under ID!";
            this.NoteLabel.UseMnemonic = false;
            // 
            // SortCheckBox
            // 
            this.SortCheckBox.AutoSize = true;
            this.SortCheckBox.Location = new System.Drawing.Point(37, 439);
            this.SortCheckBox.Name = "SortCheckBox";
            this.SortCheckBox.Size = new System.Drawing.Size(90, 17);
            this.SortCheckBox.TabIndex = 8;
            this.SortCheckBox.Text = "Sort by Name";
            this.SortCheckBox.UseVisualStyleBackColor = true;
            this.SortCheckBox.CheckedChanged += new System.EventHandler(this.SortCheckBox_CheckedChanged);
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 461);
            this.Controls.Add(this.SortCheckBox);
            this.Controls.Add(this.NoteLabel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SaveChanges);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ContentListView);
            this.Controls.Add(this.ContentLabel);
            this.Name = "TableForm";
            this.Text = "TableForm";
            this.Load += new System.EventHandler(this.TableForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label ContentLabel;
        public System.Windows.Forms.ColumnHeader ListID;
        public System.Windows.Forms.ColumnHeader ListName;
        public System.Windows.Forms.ColumnHeader ListQuantity;
        public System.Windows.Forms.ColumnHeader ListPrice;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button SaveChanges;
        private System.Windows.Forms.Button DeleteButton;
        public System.Windows.Forms.ListView ContentListView;
        private System.Windows.Forms.Label NoteLabel;
        private System.Windows.Forms.CheckBox SortCheckBox;
    }
}