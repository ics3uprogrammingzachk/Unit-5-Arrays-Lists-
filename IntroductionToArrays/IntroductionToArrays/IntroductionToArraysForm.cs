using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroductionToArrays
{
    public partial class IntroductionToArraysForm : Form
    {
        // declare my global variables and constants
        const int MAX_ARRAY_SIZE = 10;
        int[] arrayOfNumbers = new int[MAX_ARRAY_SIZE];
        public IntroductionToArraysForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // declare local variables
            int randomNumber;
            int counter;
            Random randomNumberGenerator = new Random();

            // clear the list box
            this.lstNumbers.Items.Clear();

            for (counter = 0; counter<MAX_ARRAY_SIZE; counter++)
            {
                // generate a new random number beetween 1 and the MAX_ARRAY_SIZE
                randomNumber = randomNumberGenerator.Next(1, MAX_ARRAY_SIZE);

                // assign the random number to the cell position "counter" in the array
                arrayOfNumbers[counter] = randomNumber;

                // add the random number to the list
                this.lstNumbers.Items.Add(randomNumber);

                // refresh the form to display the new item in the list box
                this.Refresh();
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // declare local variables
            double average = 0;
            double sum = 0;
            int counter;

            // calculate the sum of all the values in the array
            for (counter = 0;counter<arrayOfNumbers.Length;counter++)
            {
                sum = sum + arrayOfNumbers[counter];
            }

            // calculate the average of values in the array
            average = sum / arrayOfNumbers.Length;

            // display the text in a label
            lblAverage.Text = "The average is: " + average + "%";
        }
    }
}
