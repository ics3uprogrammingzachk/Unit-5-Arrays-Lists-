/*
 * Created by: Zachary Kranabetter
 * Created on: April 26th 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #39 - 2D Arrays
 * This program generates a 2D Array the size the user asks for and then calculates the average
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

namespace _2DArraysZachK
{
    public partial class frm2DArrays : Form
    {
        public frm2DArrays()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // declare local variables
            int width;
            int length;
            Random randomNumberGenerator = new Random();
            int aRandomNumber;
            string aPieceOfText = null;
            double average;

            // get the disired width and length from the user
            width = Convert.ToInt16(this.nudWidth.Value);
            length = Convert.ToInt16(this.nudLength.Value);

            // declare the array with the desired width and length
            int[,] a2DArray = new int[width, length];

            // loop though each element in the width
            for (int widthCounter = 0; widthCounter < width; widthCounter++)
            {
                // loop though each element in the length
                for (int lengthCounter = 0; lengthCounter < length; lengthCounter++)
                {
                    // get a random number between 0 and 9
                    aRandomNumber = randomNumberGenerator.Next(0, 9 + 1);

                    // insert the random number into the array and the current width and length
                    a2DArray[widthCounter,lengthCounter] = aRandomNumber;

                    // add the random number to the string of array numbers
                    aPieceOfText = aPieceOfText + " " + aRandomNumber;
                }

                // add a line break to end of the line to show a new row in the string
                aPieceOfText = aPieceOfText + "\r" + "\n";
            }

            // insert the string into the textbox
            this.txtArray.Text = aPieceOfText;

            // call the function to calculate the average
            average = CalculateAverage(a2DArray, width, length);

            // display the average
            lblAverage.Text = "The average is: "+average;

        }

        private double CalculateAverage(int [,]a2DArray, int width, int length)
        {
            // declare the variables
            double average = 0;
            double sum = 0;

            for (int widthCounter = 0; widthCounter < width; widthCounter++)
            {
                for (int lengthCounter = 0; lengthCounter < length; lengthCounter++)
                {
                    // calculate the sum
                    sum = sum + a2DArray[widthCounter, lengthCounter];
                }
            }
            // calculate the average
            average = sum / a2DArray.Length;

            return average;
        }
    }
}
