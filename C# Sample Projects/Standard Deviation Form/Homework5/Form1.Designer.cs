namespace Homework5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.saveArray = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.countBox = new System.Windows.Forms.TextBox();
            this.sumBox = new System.Windows.Forms.TextBox();
            this.averageBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.devSumBox = new System.Windows.Forms.TextBox();
            this.standardDevBox = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(50, 116);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(377, 20);
            this.inputTextBox.TabIndex = 0;
            // 
            // saveArray
            // 
            this.saveArray.Location = new System.Drawing.Point(456, 113);
            this.saveArray.Name = "saveArray";
            this.saveArray.Size = new System.Drawing.Size(93, 23);
            this.saveArray.TabIndex = 1;
            this.saveArray.Text = "Save To Array";
            this.saveArray.UseVisualStyleBackColor = true;
            this.saveArray.Click += new System.EventHandler(this.saveArray_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter scores separated by spaces and press Save to Array button";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(504, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "This program calculates standard deviation for a set of scores entered.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "No of Scores";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Average";
            // 
            // countBox
            // 
            this.countBox.Location = new System.Drawing.Point(196, 214);
            this.countBox.Name = "countBox";
            this.countBox.ReadOnly = true;
            this.countBox.Size = new System.Drawing.Size(67, 20);
            this.countBox.TabIndex = 7;
            // 
            // sumBox
            // 
            this.sumBox.Location = new System.Drawing.Point(329, 214);
            this.sumBox.Name = "sumBox";
            this.sumBox.ReadOnly = true;
            this.sumBox.Size = new System.Drawing.Size(68, 20);
            this.sumBox.TabIndex = 8;
            // 
            // averageBox
            // 
            this.averageBox.Location = new System.Drawing.Point(472, 214);
            this.averageBox.Name = "averageBox";
            this.averageBox.ReadOnly = true;
            this.averageBox.Size = new System.Drawing.Size(63, 20);
            this.averageBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sum of Dev Sq";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(137, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Std Dev";
            // 
            // devSumBox
            // 
            this.devSumBox.Location = new System.Drawing.Point(196, 264);
            this.devSumBox.Name = "devSumBox";
            this.devSumBox.ReadOnly = true;
            this.devSumBox.Size = new System.Drawing.Size(67, 20);
            this.devSumBox.TabIndex = 12;
            // 
            // standardDevBox
            // 
            this.standardDevBox.Location = new System.Drawing.Point(196, 314);
            this.standardDevBox.Name = "standardDevBox";
            this.standardDevBox.ReadOnly = true;
            this.standardDevBox.Size = new System.Drawing.Size(67, 20);
            this.standardDevBox.TabIndex = 13;
            // 
            // listBox
            // 
            this.listBox.Location = new System.Drawing.Point(57, 177);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(48, 174);
            this.listBox.TabIndex = 14;
            this.listBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 389);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.standardDevBox);
            this.Controls.Add(this.devSumBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.averageBox);
            this.Controls.Add(this.sumBox);
            this.Controls.Add(this.countBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveArray);
            this.Controls.Add(this.inputTextBox);
            this.Name = "Form1";
            this.Text = "Standard Deviation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button saveArray;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox countBox;
        private System.Windows.Forms.TextBox sumBox;
        private System.Windows.Forms.TextBox averageBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox devSumBox;
        private System.Windows.Forms.TextBox standardDevBox;
        private System.Windows.Forms.RichTextBox listBox;
    }
}

