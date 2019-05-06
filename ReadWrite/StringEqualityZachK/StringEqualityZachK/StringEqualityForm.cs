/*
 * Created by: Zachary Kranabetter
 * Created on: April 23 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #35 - String Equality
 * This program lets the user enter two strings and checks if the strings are equal not counting capitals
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

namespace StringEqualityZachK
{
    public partial class StringEqualityForm : Form
    {
        public StringEqualityForm()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //declare my variables
            bool equal;
            string input1, input2;

            //set the input to the strings they entered
            input1 = this.txtInput1.Text;
            input2 = this.txtInput2.Text;

            //call the function to check if they are the same
            equal = Check(input1, input2);

            //check if the strings are the same
            if (equal == true)
            {
                //tell the user the strings are equal
                lblAnswer.Text = "These strings are equal";
            }

            else
            {
                //tell the user the strings are not equal
                lblAnswer.Text = "These strings are NOT equal";
            }
        }

        public bool Check(string input1, string input2)
        {
            //set the strings to not equal
            bool equal = false;

            //check if the strings are the same length
            if (input1.Length == input2.Length)             
            {
                //set them both to all capitals
                input1 = input1.ToUpper();
                input2 = input2.ToUpper();

                //check if the strings are the same
                if (input1 == input2)
                {
                    equal = true;
                }
            }
            return equal;
        }
    }
}
