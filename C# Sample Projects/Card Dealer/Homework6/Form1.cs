/*
PROGRAMMERS NAME: Rolando Rodriguez
STUDENT ID: 10300030
CLASS: CSCI 3328        ASSIGNMENT #: 7
DATE DUE: October 30, 2013      DATE TURNED IN: October 30, 2013
*/

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string fullDeck;
        string spacedDeck;
        string shuffledDeck;
        public string[] parseShuffled;

        //strings used to store the hands of each player
        public string player1 = "";
        public string player2 = "";
        public string player3 = "";
        public string player4 = "";

        //creates a new deck when the button is clicked
        private void button1_Click(object sender, EventArgs e)
        {
            string deckC = "CA C2 C3 C4 C5 C6 C7 C8 C9 C10 CJ CQ CK";
            string deckD = "DA D2 D3 D4 D5 D6 D7 D8 D9 D10 DJ DQ DK";
            string deckH = "HA H2 H3 H4 H5 H6 H7 H8 H9 H10 HJ HQ HK";
            string deckS = "SA S2 S3 S4 S5 S6 S7 S8 S9 S10 SJ SQ SK";

            richTextBox1.Text = deckC + "\n" + deckD + "\n" + deckH + "\n" + deckS;
            fullDeck = richTextBox1.Text;
            spacedDeck = deckC + " " + deckD + " " + deckH + " " + deckS;
        }

        //Shuffles the deck so that the cards can be dealt
        private void button2_Click(object sender, EventArgs e)
        {
            string[] shuffled = spacedDeck.Split(' ');
            Random rnd = new Random();
            string[] MyRandomArray = shuffled.OrderBy(x => rnd.Next()).ToArray();
            int counter = 0;

            for (int i = 0; i < MyRandomArray.Length; i++)
            {
                shuffledDeck += MyRandomArray[i] + " ";
                counter++;

                if (counter > 12)
                {
                    shuffledDeck += "\n";
                    counter = 0;
                }
            }

            richTextBox2.Text = shuffledDeck;
        }

        //Deals the now shuffled cards to the 4 players
        private void button3_Click(object sender, EventArgs e)
        {
            parseShuffled = shuffledDeck.Split(' ');
            int i = 0;
            int j = 1;
            int k = 2;
            int l = 3;

            while (i <= 52)
            {
                player1 += parseShuffled[i] + " ";
                i += 4;
            }

            while (j <= 51)
            {
                player2 += parseShuffled[j] + " ";
                j += 4;
            }
            while (k <= 50)
            {
                player3 += parseShuffled[k] + " ";
                k += 4;
            }
            while (l <= 51)
            {
                player4 += parseShuffled[l] + " ";
                l += 4;
            }

            textBox3.Text = player1;
            textBox4.Text = player2;
            textBox5.Text = player3;
            textBox6.Text = player4;
        }

        //opens up the second form when the "Show Hands" button is clicked
        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 s = new Form2(this);
            s.Visible = true;
        }
        
        //closes the form when the "stop" button is clicked
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //opens a new form to display images of the deck
        private void Pictures_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3();
            F3.ShowDialog();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            Form4 F4 = new Form4(this);
            F4.ShowDialog();
        }
    }
}
