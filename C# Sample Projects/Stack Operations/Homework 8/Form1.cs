/*
PROGRAMMERS NAME: Rolando Rodriguez
STUDENT ID: 10300030
CLASS: CSCI 3328        ASSIGNMENT #: 8
DATE DUE: November 13, 2013     DATE TURNED IN: November 13, 2013
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Homework_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string input = "";
        public string[] parsedStack;


        //Function to clear the form when the "Another problem" button is clicked
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            richTextBox1.Text = "";
            richTextBox2.Text = "";
        }

        //Function that closes the from when the "Stop" button is clicked
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Takes the user's input for the stack and stores it in string "input"
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            input = textBox1.Text;
           

        }

        //Function that parses the string and pushes the values onto the stack
        //When OpCode is found, the function pops the last two numbers of the stack and uses the operator on them
        private void button1_Click(object sender, EventArgs e)
        {
            Stack<string> myStack = new Stack<string>();
            parsedStack = input.Split(' ');

            decimal number2, number1;
            string tempNum2, tempNum1;
            decimal tempAnswer = 0;

            for (int i = 0; i < parsedStack.Length; i++)
            {
                //If statement to see whether the next element is OpCode or number
                if (parsedStack[i].Equals("+") || parsedStack[i].Equals("-") || parsedStack[i].Equals("*") || parsedStack[i].Equals("/") || parsedStack[i].Equals("%"))
                {
                    MessageBox.Show("OpCode found, will pop 2 numbers from the stack and perform operation!");
                    tempNum2= myStack.Pop();
                    number2 = Convert.ToDecimal(tempNum2);
                    MessageBox.Show("Popped the stack.");
                    tempNum1 = myStack.Pop();
                    number1 = Convert.ToDecimal(tempNum1);
                    MessageBox.Show("Popped the stack.");

                    if (parsedStack[i].Equals("+"))
                    {
                        tempAnswer = number2 + number1;
                        richTextBox1.Text += "Performing addition on " + number2 + " and " + number1 + ".\n";
                    }
                    if (parsedStack[i].Equals("-"))
                    {
                        tempAnswer = number1 - number2;
                        richTextBox1.Text += "Subtracting " + number2 + " from " + number1 + ".\n";
                    }
                    if (parsedStack[i].Equals("*"))
                    {
                        tempAnswer = number2 * number1;
                        richTextBox1.Text += "Performing multiplication on " + number2 + " and " + number1 + ".\n";
                    }
                    if (parsedStack[i].Equals("/"))
                    {
                        tempAnswer = number2 / number1;
                        richTextBox1.Text += "Dividing " + number2 + " by " + number1 + ".\n";
                    }
                    if (parsedStack[i].Equals("%"))
                    {
                        tempAnswer = number2 % number1;
                        richTextBox1.Text += "Performing Modulus on " + number2 + " and " + number1 + ".\n";
                    }
                    else
                    {
                    }

                    myStack.Push(tempAnswer.ToString());
                    richTextBox1.Text += "Pushed: " + tempAnswer.ToString() + "\n";
                    richTextBox2.Text += tempAnswer.ToString() + "\n";
                    MessageBox.Show("Pushed: " + tempAnswer.ToString() + "\n");
                    
 

                }
                //else if the string element isn't OpCode, push the element onto the stack and display a message
                else
                {
                    myStack.Push(parsedStack[i]);
                    richTextBox1.Text += "Pushed: " + parsedStack[i] + "\n";
                    richTextBox2.Text += parsedStack[i] + "\n";
                    MessageBox.Show(parsedStack[i] + " has been pushed onto the stack.");
                }
            }

            //At the end of the for loop, the final answer is popped and sent to "textBox2"
            richTextBox1.Text += "Popped: Answer!\n";
            textBox2.Text = myStack.Pop();
        }

        }
    }
