using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountApp
{
    public partial class BankAccountOperationUI : Form
    {
        public BankAccountOperationUI()
        {
            InitializeComponent();
        }

        private Account account;
        private void accountCreateButton_Click(object sender, EventArgs e)
        {
             account = new Account();
            account.accountNo = accountNoTextBox.Text;
            account.customerName = customerNameTextBox.Text;
            MessageBox.Show("Account is Created");
        }
       // private double depositeMoney;
        private void depositeButton_Click(object sender, EventArgs e)
        {
             account.GetDeposite(Convert.ToDouble(amountTextBox.Text));

            MessageBox.Show(amountTextBox.Text + " Taka is Deposited.");
        }

        
        private void withdrawButton_Click(object sender, EventArgs e)
        {
            account.GetWithdraw(Convert.ToDouble(amountTextBox.Text));
            MessageBox.Show(amountTextBox.Text + " Taka is WithDraw.");
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(account.customerName + ", Your account number :" + account.accountNo + " and it's balance :" +
                            account.balance + " Taka");
        }
    }
}
