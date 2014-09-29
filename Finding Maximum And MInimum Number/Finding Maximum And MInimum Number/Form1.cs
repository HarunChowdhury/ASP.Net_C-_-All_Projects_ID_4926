using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finding_Maximum_And_MInimum_Number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int firstNum;
        private int secondNum;
        private int thirdNum;
        private int fourthNum;
        private int fifthNum;
       

        private void button1_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToInt32(firstNumTextBox.Text);
            secondNum = Convert.ToInt32(secondNumTextBox.Text);
            thirdNum = Convert.ToInt32(thirdNumTextBox.Text);
            fourthNum = Convert.ToInt32(fourthNumTextBox.Text);
            fifthNum = Convert.ToInt32(firstNumTextBox.Text);

            maxNumberTextBox.Text = Convert.ToString(Math.Max(Math.Max(Math.Max(Math.Max(firstNum, secondNum), thirdNum), fourthNum), fifthNum));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            minNumberTextBox.Text = Convert.ToString(Math.Min(Math.Min(Math.Min(Math.Min(firstNum, secondNum), thirdNum), fourthNum), fifthNum));
        }
    }
}
