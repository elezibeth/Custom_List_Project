using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List_Project
{
    class Text
    {
        public Text()
        {

        }

        public string StringBuild(string[] array)
        {
            System.Text.StringBuilder returnString = new System.Text.StringBuilder();
            // Create a string of 1000 numbers from 0 to 999    
            // separated by a comma and space    
            for (int counter = 0; counter <= (array.Length - 1); counter++)
            {
                returnString.Append(array[counter]);
                
            }
            string returnString1 = returnString.ToString();
            return returnString1;
        }
    }
}
