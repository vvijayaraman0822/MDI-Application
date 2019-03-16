/* Vasudev Vijayaraman 
 * This form is where the user enters the name of the Workshop which becomes the name of the file.
 * The label in the next form also changes on what the user enters */

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
    public partial class FileNameForm : Form
    {
        private MDIForm newmdi; // Set instance

        string WorkshopName; // String containing the name of the workshop

        public FileNameForm(MDIForm mdi)
        {
            newmdi = mdi;
            InitializeComponent();
        }

        /* This method occurs when the user enetrs the name of the workshop in the text field 
         * and clicks enter. It creates a file that can later on be saved. It takes the user
         * to the Tableform where the data can be entered into the list */

        private void WorkshopEnterButton_Click(object sender, EventArgs e)
        {

            WorkshopName = WorkshopNameTextBox.Text; // Name of the workshop
            string workPlace = WorkshopNameTextBox.Text + Workshop.append; // Append .sup file extension
            Directory.CreateDirectory(Workshop.SavedDirectory); // Create default directory

            TableForm changeForm = new TableForm(); // Instantiate tableform

           string savedContent = Path.Combine(Workshop.SavedDirectory, workPlace);
            var file = File.Create(savedContent);
            file.Close(); // Close file

            Workshop.FileSaveName = savedContent; 
            Workshop.WorkName = WorkshopNameTextBox.Text; // Set workshop name to the one user entered in the text Box

             TableForm table = new TableForm // Set its MDI parent
            {
                MdiParent = newmdi
            };

            table.ContentLabel.Text = this.WorkshopName; // Change the label to the work shop name
            table.Show();
            this.Hide();

        }
    }
}
