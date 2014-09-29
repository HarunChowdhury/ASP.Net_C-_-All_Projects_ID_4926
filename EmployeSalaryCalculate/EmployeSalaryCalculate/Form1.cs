using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeSalaryCalculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateSalaryButton_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(amountTextBox.Text);

            if (amount>10000)
            {
                resultSalaryTextBox.Text = Convert.ToString(amount + (amount*5)/100);
            }
            else if (amount>=8000)
            {
                resultSalaryTextBox.Text = Convert.ToString(amount + (amount * 6) / 100);
            }
            else if (amount <= 10000)
            {
                resultSalaryTextBox.Text = Convert.ToString(amount + (amount * 6) / 100);
            }
            else
            {
                resultSalaryTextBox.Text = Convert.ToString(amount + (amount * 7) / 100);  
            }
            
        }
    }
}
