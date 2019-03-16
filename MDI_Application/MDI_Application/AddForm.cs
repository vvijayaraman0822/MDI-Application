/* Vasudev Vijayaraman
 * This form lets you add data/items to the listView. It has an add function that takes in data
 * from the textboxes and adds it to the list */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_Application
{
    public partial class AddForm : Form
    {
        public Record newrecord;

        public AddForm()
        {
            newrecord = record; // Set record to newRecord
            InitializeComponent();
        }


        /* This method checks to make sure there are no empty fields while the user
         * enters in the data. The catch block will occur when the user has atleast one
         * empty field and it will throw a message. It is passed on in the next method */
        private bool checkEmptyFields()
        {
            if (IDTextBox.Text == "" || PriceTextBox.Text == "" || QuantityTextBox.Text == "" || NameTextBox.Text == "")
                return false;
            else
                return true;
        }

        public Record record; // Instantiating record class that has all the data

        /* This method occurs when the user hits the enter button after entering all the text fields.
         * If any of the fields are missing, the method will throw an error */

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (checkEmptyFields() == true)
            {
                try
                {
                    record = new Record
                    {
                        ID = Int32.Parse(this.IDTextBox.Text),
                        Name = this.NameTextBox.Text,
                        Quantity = Int32.Parse(this.QuantityTextBox.Text),
                        Price = Double.Parse(this.PriceTextBox.Text),
                    };


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("You have empty fields, please check again", "ERROR", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
            
        Close();

        }
    }
}
