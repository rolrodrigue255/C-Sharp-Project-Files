/*
PROGRAMMER'S NAME: Rolando Rodriguez 
STUDENT ID: 10300030
CLASS: CSCI 3328        ASSIGNMENT #: 5
DATE DUE: October 9, 2013       DATE TURNED IN: October 9, 2013
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Homework5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveArray_Click(object sender, EventArgs e)
        {
            int sum = 0;
            double average = 0.0;
            double devSum = 0.0;
            double standardDev = 0.0;

            //Parses the first text box and puts the integers into array 'y'
            string x = inputTextBox.Text;
            int[] y = x.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();

            //for loop used to list the values in the rich text box
            for (int i = 0; i < y.Length; i++)
            {
                listBox.Text += y[i];
                listBox.Text += "\n";
            }

            //for loop used to compute the average
            for (int i = 0; i < y.Length; i++)
            {
                sum += y[i];
            }

            average = Math.Round(Convert.ToDouble(sum) / y.Length, 2);


            //for loop used to get the sum of the deviations squared
            //I then use this value to get the standard deviation
            for (int i = 0; i < y.Length; i++)
            {
                double temp = Math.Abs(y[i] - average);
                devSum += Math.Pow(temp, 2);
            }

            standardDev = Math.Sqrt((devSum / (y.Length - 1)));

            
            //Places the values into the respective text box
            countBox.Text = Convert.ToString(y.Length);
            sumBox.Text = Convert.ToString(sum);
            averageBox.Text = Convert.ToString(average);
            devSumBox.Text = Convert.ToString(Math.Round(devSum, 2));
            standardDevBox.Text = Convert.ToString(Math.Round(standardDev, 2));

        }
    }
}
