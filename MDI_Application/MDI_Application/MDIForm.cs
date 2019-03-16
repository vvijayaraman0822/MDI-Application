/* Vasudev Vijayaraman 
 * C# Programming 
 * 11/30/2018
 * Dr. Catherine Stringfellow
 * This form is the main form that contains the Main Menu and is the parent form. This program is an
 * MDI application,  where each child window contains a listView corresponding to a workshop supply list.
 * Menus, buttons, listview were used to implement this. This program also implements serialization which lets
 * the user save files and deserialize which lets the user open saved files */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MDI_Application
{
    public partial class MDIForm : Form
    {
        public MDIForm()
        {
            InitializeComponent();
        }

        TableForm table = new TableForm(); // Instantiaiting Table Form
        
        /* This method occurs when the user hits the new button. This lets the user
         * create a new file and takes you to the next form which the FileNameForm */

       private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileNameForm newForm = new FileNameForm(this);
            newForm.ShowDialog();

        }
        
        /* This method takes place when the about button on the menu is clicked.
         * It takes you to the about form that contains information on the version
         * and the author */

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm format = new AboutForm();
            format.ShowDialog();

        }
        
        /* This method takes place when the user clicks the exit button. It exits
         * out of the application */

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using our program", "THANKS BUDDY", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            Application.Exit();
        }

        /* This method occurs when the insert button in the menu gets clicked
         * It takes you to the add form and lets you add items to the list. This is programmed in such
         * a way that it raises the event handler from the Table Form */

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ((TableForm)this.ActiveMdiChild).AddButton_Click(sender, e);

        }

        /* This method occurs when the open button on the menu is clicked. It opens a file dialog,
         * lets you browse through your computer and open the desired file. It takes in sender and
         * e as parameters and returns nothing */

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog
            {
                Title = "Which file do you want to open?", DefaultExt = Workshop.append, CheckFileExists = true,
                CheckPathExists = true,
                InitialDirectory = Workshop.SavedDirectory,
            };

            if (file.ShowDialog() == DialogResult.OK)
            {
                Workshop.WorkName = Path.GetFileNameWithoutExtension(file.FileName);
                Workshop.FileSaveName = file.FileName;

                TableForm table = new TableForm(); // setting parent form
                table.MdiParent = this;
                table.Show();
            }
        }

        /* This method occurs when the save button in the menu gets clicked
         * It saves all the items on the list.This is programmed in such
         * a way that it raises the event handler from the Table Form */

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((TableForm)this.ActiveMdiChild).SaveChanges_Click(sender, e);
            MessageBox.Show("Your data has been saved", "LIST", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           
        }

        /* This method is so that the menu items are enabled and disabled appropriately.
         * When you start the program, there are no Active MDI child, so the insert, delete,'
         * save and update are disabled */

        private void TitleMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                insertToolStripMenuItem.Enabled = true;
                deleteToolStripMenuItem.Enabled = true;
                updateToolStripMenuItem.Enabled = true;
                saveToolStripMenuItem.Enabled = true;
            }

            else if (ActiveMdiChild == null)
            {
                insertToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
                updateToolStripMenuItem.Enabled = false;
                saveToolStripMenuItem.Enabled = false;
            }

        }

        /* This method occurs when the delete button in the menu gets clicked
         * It deletes the selected item from the list. This is programmed in such
         * a way that it raises the event handler from the Table Form */

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((TableForm)this.ActiveMdiChild).DeleteButton_Click(sender, e);
        }

        /* This method occurs when the update button in the menu gets clicked
        * It updates the selected item on the list. This is programmed in such
        * a way that it raises the event handler from the Table Form */

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((TableForm)this.ActiveMdiChild).UpdateButton_Click(sender, e);
        }
    }
}
