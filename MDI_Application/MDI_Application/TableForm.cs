/* Vasudev Vijayaraman
 * This is the TableForm that contains the ListView which inherits from a ListBox and ListView
 * is better to use since it has multiple rows and columns. This form has insert, delete and update buttons
 * that lets you do the function accordingly. It also lets you save your project and open back up
 * as desired */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace MDI_Application
{
    public partial class TableForm : Form
    {
        // List containing all the content in the ListBox
        public List<Record> content = new List<Record>();

        public TableForm()
        {
            InitializeComponent();
        }

        public bool itemsInserted = false; // bool to keep track if the item needs to be Inserted

        // This is the proerty that gets the label on the form and enables to change the label
        // to the workshop Name

        public string LabelText
        {
            get
            {
                return this.ContentLabel.Text; // Label
            }
            set
            {
                this.ContentLabel.Text = value; // Label set to its value
            }

        }

        /* This method occurs when this form loads. Deserialization happens because
         * you want to load the saved data */

        private void TableForm_Load(object sender, EventArgs e)
        {

            if (new FileInfo(Workshop.FileSaveName.ToString()).Length > 0)
            {
                Deserialize(Workshop.FileSaveName.ToString()); // Deserialize method

                ResetView();
              }
            
        }

        /* This method enables us to Serialize the files and save them accordingly. BinaryFormatter and
         * FileStream classes are being used. It takes in file as parameter and returns nothing */
        public void Serialize(string file)
        {

            BinaryFormatter binary = new BinaryFormatter();

            // Make sure the file is set to write mode, took me 6 hours to 
            // figure why I wasn't able to write to my files.

            FileStream files = new FileStream(Workshop.FileSaveName.ToString(), FileMode.Open, FileAccess.Write, FileShare.None);

            try
            {
                using (files)
                {
                    binary.Serialize(files, content); // Serialize
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRORS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /* This method enables to Deserialize the files, which is open the saved files and display them.
         * BinaryFormatter and FileStream classes are being used. It takes in file as parameter
         * and returns nothing */

        private void Deserialize(string file)
        {
            BinaryFormatter binary = new BinaryFormatter();

            // File Access needs to be in read mode. I am getting blind!!!!
            FileStream files = new FileStream(Workshop.FileSaveName.ToString(), FileMode.Open, FileAccess.Read , FileShare.None);

            try
            {
                using (files)
                {
                    content = (List<Record>)binary.Deserialize(files);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /* This method takes place when the add button is clicked. It adds
         * the items in the list */

        public void AddButton_Click(object sender, EventArgs e)
        {
            itemsInserted = true;

            AddForm add = new AddForm();
            add.ShowDialog();

            if (add.record != null)
            {
                content.Add(add.record);
                ListView(add.record);
            }

        }

        /* This method adds all the items to the list and returns it.
         * It is used later on in the program to display the list */

        private ListViewItem AddToListView(Record record)
        {

            ListViewItem list = new ListViewItem(record.ID.ToString());
            list.Name = record.ID.ToString();
            list.SubItems.Add(record.Name);
            list.SubItems.Add(record.Quantity.ToString());
            list.SubItems.Add(record.Price.ToString());

            return list;

        }

        /* This method takes place when the user clicks the Update Button. 
         * When the user selects and item and clicks it, it enables them edit the list
         * and update them */

        public void UpdateButton_Click(object sender, EventArgs e)
        {

         foreach (ListViewItem list in ContentListView.Items)
            
            {
                if (list.Selected)
                {
                    Int32.TryParse(list.Name, out int id);
                    Record update = content.Find(item => item.ID == id);

                    UpdateForm edit = new UpdateForm(update);
                    edit.ShowDialog();

                    content.Remove(update);
                    list.Remove();

                    content.Add(edit.UpdateRecord);
                    UpdateToListView(edit.UpdateRecord);
                   
                }
            }
        }

        /* This method enables us to view the list. It takes in record as parameter
         * and returns nothing */

        public void ListView(Record record)
        {
            ListViewItem list = AddToListView(record);
            if (!ContentListView.Items.ContainsKey(record.ID.ToString()))
            {
                ContentListView.Items.Add(list);
            }
            else
                MessageBox.Show("Entry Exists", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        /* This method is used to update the list everytime something gets
         * added to it or updated. It takes in record as parameter
         * and returns nothing */

        private void UpdateToListView(Record record)
        {
            ListViewItem list = AddToListView(record);

            ContentListView.Items.Add(list);
        }

        /* This method resets the view before showing the list. It takes in
         * no parameters and returns nothing */

        public void ResetView()
        {
            ContentListView.Items.Clear(); 

            foreach (Record item in content)
            {
                ListViewItem list = AddToListView(item);
            
                ContentListView.Items.Add(list);
            }
        }

        /* This method takes places when the user hits the save button. It
         * lets them save their data and resume at a later by opening it again */

        public void SaveChanges_Click(object sender, EventArgs e)
        {
            Serialize(Workshop.FileSaveName.ToString());
            Close();
            itemsInserted = false;
        }

      
        /* This method takes place when the user selects and item and hits 
         * the delete button. It deletes an item from the list */

        public void DeleteButton_Click(object sender, EventArgs e)
        {

            foreach(ListViewItem list in ContentListView.SelectedItems)
            {
                ContentListView.Items.Remove(list);
            }
        }

        /* This method sorts the list by name, that is alphabetical order.
         * It compares the first item and second item to its name and there is
         * an inbuilt sorting method for the list */

        private void SortCheckBox_CheckedChanged(object sender, EventArgs e)
        {
           if(SortCheckBox.Enabled == true)
            {
                content.Sort((first_item, second_item) => first_item.Name.CompareTo(second_item.Name));
                ResetView();
            
            }
        }
    }

}
