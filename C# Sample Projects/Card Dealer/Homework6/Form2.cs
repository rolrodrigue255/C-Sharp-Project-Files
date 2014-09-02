using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Homework6
{
    public partial class Form2 : Form
    {
        //passes Form1 to the constructor of Form2 so that information can be shared between forms
        Form1 originalForm;
        public Form2(Form1 incomingForm)
        {
            originalForm = incomingForm;
            InitializeComponent();
            
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            //opens up the original form when the "play again" button is clicked
            this.Visible = false;
            Form1 F1 = new Form1();
            F1.Visible = true;
            this.Close();
        }

        private void arrangeButton_Click(object sender, EventArgs e)
        {
            //splits the player's hands into separate arrays
            string[] arrayHand1 = originalForm.player1.Split(' ');
            string[] arrayHand2 = originalForm.player2.Split(' ');
            string[] arrayHand3 = originalForm.player3.Split(' ');
            string[] arrayHand4 = originalForm.player4.Split(' ');

            //sorts the 4 arrays
            Array.Sort(arrayHand1);
            Array.Sort(arrayHand2);
            Array.Sort(arrayHand3);
            Array.Sort(arrayHand4);

            //strings used to store the now sorted arrays
            string sortedHand1 = "";
            string sortedHand2 = "";
            string sortedHand3 = "";
            string sortedHand4 = "";

            //for loops used to combine all the elements of the arrays into strings
            for (int i = 0; i < arrayHand1.Length; i++)
            {
                sortedHand1 += arrayHand1[i] + " ";
            }
            for (int i = 0; i < arrayHand2.Length; i++)
            {
                sortedHand2 += arrayHand2[i] + " ";
            }
            for (int i = 0; i < arrayHand3.Length; i++)
            {
                sortedHand3 += arrayHand3[i] + " ";
            }
            for (int i = 0; i < arrayHand4.Length; i++)
            {
                sortedHand4 += arrayHand4[i] + " ";
            }

            //assigns the sorted arrays to the text boxes in Form2
            textBox1.Text = sortedHand1;
            textBox2.Text = sortedHand2;
            textBox3.Text = sortedHand3;
            textBox4.Text = sortedHand4;
        }
    }
}
