/*
 * Created by: Zachary Kranabetter
 * Created on: April 25 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #36 - Find Max Value
 * This program creates an array with numbers ranging from 1-500 and puts them
 * into an array and then finds the biggist number and displays it to the user
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

namespace FindMaxValue
{
    public partial class FindMaxValueForm : Form
    {
        // declare my global variables and constants
        const int MAX_ARRAY_SIZE = 10;
        const int MAX_RANDOM_NUMBER = 500;
        int[] arrayOfNumbers = new int[MAX_ARRAY_SIZE];

        public FindMaxValueForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // create my variables
            int randomNumber, counter, maxValue;
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
                maxValue = GetMaxValue(arrayOfNumbers);

                // display the max value
                lblAnswer.Text = "The max value is " + maxValue;
            }
        }

        private int GetMaxValue(int[] arrayOfNumbers)
        {
            // declare local variables
            int counter;
            int tmpMaxValue = 1;
            int value;

            // calculate the the max value in the list box
            for (counter = 0; counter < arrayOfNumbers.Length; counter++)
            {
                value = arrayOfNumbers[counter];

                if (value > tmpMaxValue)
                {
                    tmpMaxValue = value;
                } 
            }
            return tmpMaxValue;
        } 
    }
}
