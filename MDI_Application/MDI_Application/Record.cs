/* Vasudev Vijayaraman
 * This is the file that was given by by Dr.Stringfellow to be added in the project. 
 * It contains all the variables and also its getters and setters */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDI_Application
{
    [Serializable]
    public class Record
    {
        // Default Constructor
        public Record()
        {

        }
        
        // Parameterized Constructor */
        public Record(int id, int quantity, double price, string name)
        {
            ID = id;
            Quantity = quantity;
            Price = price;
            Name = name;
        }
        
        // Getters and setters of the data members */
        public int ID   { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }

        [NonSerialized]
        public string shopDetails;

    }
}
