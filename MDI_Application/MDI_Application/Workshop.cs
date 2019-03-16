/* Vasudev Vijayaraman 
 * This form contains the name of the workshop and the name of the file. It also 
 * has read only data members such as the .sup filename as mentioned in the assignment
 * and also the saved file directory */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MDI_Application
{
    class Workshop
    {
        static public string WorkName { get; set; }
        static public string FileSaveName { get; set; }

        static public readonly string SavedFile = System.AppDomain.CurrentDomain.BaseDirectory;
        static public readonly string SavedDirectory = Path.Combine(SavedFile);
        static public readonly string append = ".sup";
    }
}
