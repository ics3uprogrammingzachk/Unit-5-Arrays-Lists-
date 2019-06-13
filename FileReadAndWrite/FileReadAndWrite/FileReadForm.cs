/*
 * Created by: Zachary Kranabetter
 * Created on: May 1st 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #40 - String Equality
 * This program lets the user compares strings from an input file and determine if they are the 
 * same, then in an output file it will say true or false for eacdh line
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileReadAndWrite
{
    public partial class FileReadForm : Form
    {
        public FileReadForm()
        {
            InitializeComponent();
        }

        private bool StringsAreEqual(string case1, string case2)
        {
            // make the boolean variable
            bool Equal;

            // check if the strings have the same number of characters
            if (case1.Length == case2.Length)
            {
                // make the strings lowercase
                case1 = case1.ToLower();
                case2 = case2.ToLower();

                if (case1 == case2)
                {
                    // set equal to true
                    Equal = true;
                }
                else
                {
                    // set equal to true
                    Equal = false;
                }
            }
            else
            {
                // set equal to flase
                Equal = false;
            }
            
            return Equal;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // create my array of lines and set it to the input file
            string[] lines = System.IO.File.ReadAllLines(@"input.txt");

            // create the seperators to read the input
            char[] charSeperators = new char[] { ' ', '\t' };

            string output = "";

            // go though each line and check if the strings are the same 
            foreach (string line in lines)
            {
                string[] words = line.Split(charSeperators, StringSplitOptions.RemoveEmptyEntries);

                if (StringsAreEqual(words[0], words[1]) == true)
                {
                    output = output + "True\r\n";
                }
                else
                {
                    output = output + "False\r\n";
                }
            }

            // display it
            System.IO.File.WriteAllText(@"output.txt", output);

            this.lblAnswer.Show();

        }
    }
}
