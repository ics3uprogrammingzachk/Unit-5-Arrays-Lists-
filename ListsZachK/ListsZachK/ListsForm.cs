/*
 * Created by: Zachary Kranabetter
 * Created on: May 2nd 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #39 - Lists
 * This program accepts marks from (0 to 100) repeatedly from the 
 * user and lets the user press a button to calculate the average
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

namespace ListsZachK
{
    public partial class ListsForm : Form
    {
        public ListsForm()
        {
            InitializeComponent();
        }

        // create my list
        List<int> listOfMarks = new List<int>();

        private void btnEnter_Click(object sender, EventArgs e)
        {
            // declare my variables
            int userMark = -1;

            // convert the value in the textbox to an interger
            try
            {
                userMark = Convert.ToInt32(txtMarks.Text);
            }

            // if the user did not enter a vaild number, write the error to the command line
            catch (Exception parseError)
            {
                Console.WriteLine("An error occurred: '{0}'", parseError);
            }

            // check if the user entered a number between 0 and 100
            if ( (userMark >= 0) && (userMark<=100) )
            {
                // add the mark to the listbox
                this.lstMarks.Items.Add(userMark);

                // add the mark to list
                listOfMarks.Add(userMark);
            }

            // otherwise, display an error
            else
            {
                MessageBox.Show("Please enter a number between 0 and 100.", "Invalid Number");
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // declare my variables
            double average;

            // call the function to calculate the average
            average = Calculate(listOfMarks);

            // display the average
            lblAnswer.Text = "The average is " + average + "%";
        }

        private double Calculate(List<int> listOfMarks)
        {
            // declare my variables
            double tmpAverage = 0;
            double total = 0;
            int amountOfMarks = 0;

            for (int counter = 0; counter < listOfMarks.Count; counter++)
            {
                // add each mark to the total 
                total = total + listOfMarks[counter];

                // increment the counter
                amountOfMarks++;
            }

            //  calculate the average
            tmpAverage = total / amountOfMarks;

            return tmpAverage;
        }
    }
}
