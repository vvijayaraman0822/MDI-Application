/* Vasudev Vijayaraman
 * This form contains the update. It lets the user edit and uodate their changes */

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
    public partial class UpdateForm : Form
    {

        public UpdateForm(Record record)
        {
            newRecord = record;
            InitializeComponent();
        }


        public Record newRecord; // instantiate 
        public Record UpdateRecord; // instantiate

        /* This method happens on this form loading. When the user selects an item and hits the update button,
         * it puts the selected item ij their respective textboxes so it makes it easier for them to make 
         * changes */

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            IDTextBox.Text = newRecord.ID.ToString();
            NameTextBox.Text = newRecord.Name;
            QuantityTextBox.Text = newRecord.Quantity.ToString();
            PriceTextBox.Text = newRecord.Price.ToString();
        }

        /* This method checks to see if the user entered any empty fields in the
         * update form */

        private bool checkEmptyFields()
        {
            if (IDTextBox.Text == "" || PriceTextBox.Text == "" || QuantityTextBox.Text == "" || NameTextBox.Text == "")
                return false;
            else
                return true;
        }

        /* This method occurs when the user hits the update button after entering all the text fields.
         * If any of the fields are missing, the method will throw an error */
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (checkEmptyFields() == true)
            {
                try
                {
                    UpdateRecord = new Record
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

