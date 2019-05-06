/*
 * Created by: Zachary Kranabetter
 * Created on: April 30th 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #37 - Find Min Value
 * This program generates an array of numbers from 1-500 and finds the min value
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

namespace FindMinValue
{
    public partial class FindMinValueForm : Form
    {
        // declare my global variables and constants
        const int MAX_ARRAY_SIZE = 10;
        const int MAX_RANDOM_NUMBER = 500;
        int[] arrayOfNumbers = new int[MAX_ARRAY_SIZE];

        public FindMinValueForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // create my variables
            int randomNumber, counter, minValue;
            Random randomNumberGenerator = new Random();

            // clear the list box
            this.lstNumbers.Items.Clear();

            for (counter = 0; counter < MAX_ARRAY_SIZE; counter++)
            {
                // generate a new random number beetween 1 and the MAX_ARRAY_SIZE
                randomNumber = randomNumberGenerator.Next(1, MAX_RANDOM_NUMBER);

                // assign the random number to the cell position "counter" in the array
                arrayOfNumbers[counter] = randomNumber;

                // add the random number to the list
                this.lstNumbers.Items.Add(randomNumber);

                // call the function to calculate the max value
                minValue = GetMaxValue(arrayOfNumbers);

                // display the min value
                lblAnswer.Text = "The min value is " + minValue;
            }
        }

        private int GetMaxValue(int[] arrayOfNumbers)
        {
            // declare local variables
            int tmpMinValue = 500;
            int counter = 0;


            // calculate the the min value in the list box
            foreach (double arrayValue in arrayOfNumbers)
            {
                if (arrayOfNumbers[counter] < tmpMinValue)
                {
                    tmpMinValue = arrayOfNumbers[counter];
                    
                }
                counter++;
            }
            return tmpMinValue;
        }
    }
}
