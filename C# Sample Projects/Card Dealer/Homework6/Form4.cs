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
    public partial class Form4 : Form
    {
        Form1 originalForm;
        public Form4(Form1 incomingForm)
        {
            originalForm = incomingForm;
            InitializeComponent();
        }

        private void showPicButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < originalForm.parseShuffled.Length; i++)
            {
                
            }
        }
    }
}
