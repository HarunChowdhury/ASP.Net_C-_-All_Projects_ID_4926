using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interest_Calculatior
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int balance;
        int time;

        private void calculateButton_Click_1(object sender, EventArgs e)
        {
            time = Convert.ToInt32(timeInYearTextBox.Text);
            balance = Convert.ToInt32(balanceTextBox.Text);

         if(bankNameComboBox.Text=="BRAC(6%)")
         {
           interestLabel.Text=Convert.ToString("Interest = "+Convert.ToDouble((time*balance*6)/100));
         }
         else if(bankNameComboBox.Text=="DBBL(7%)")
         {
         interestLabel.Text=Convert.ToString("Interest = "+Convert.ToDouble((time*balance*7)/100));
         }

         else
         {
         interestLabel.Text=Convert.ToString("Interest = "+Convert.ToDouble((time*balance*8)/100));
         }

        }
    }
}
