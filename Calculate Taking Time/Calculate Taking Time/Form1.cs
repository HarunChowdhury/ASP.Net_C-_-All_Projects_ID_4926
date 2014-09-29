using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate_Taking_Time
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateTakTimeButton_Click(object sender, EventArgs e)
        {
            if ((typeComboBox.Text=="Prepaid") && (operatorComboBox.Text=="BL"))
            {
                int blPostTalkTime = Convert.ToInt32(balanceTextBox.Text)*2;
                string minutes = Convert.ToString(blPostTalkTime);
               showTalkTimeLabel.Text="He/She can talk about "+minutes+" minutes";   
            }
            else if ((typeComboBox.Text == "Postpaid") && (operatorComboBox.Text == "BL"))
            {
                int blPostTalkTime = (Convert.ToInt32(balanceTextBox.Text)+50) * 2;
                string minutes = Convert.ToString(blPostTalkTime);
                showTalkTimeLabel.Text = "He/She can talk about " + minutes + " minutes";
            }
            else if ((typeComboBox.Text == "Prepaid") && (operatorComboBox.Text == "GP"))
            {
                int blPostTalkTime = Convert.ToInt32(balanceTextBox.Text)  * 3;
                string minutes = Convert.ToString(blPostTalkTime);
                showTalkTimeLabel.Text = "He/She can talk about " + minutes + " minutes";
            }
            else if ((typeComboBox.Text == "Postpaid") && (operatorComboBox.Text == "GP"))
            {
                int blPostTalkTime = (Convert.ToInt32(balanceTextBox.Text) + 20) * 2;
                string minutes = Convert.ToString(blPostTalkTime);
                showTalkTimeLabel.Text = "He/She can talk about " + minutes + " minutes";
            }
            else if ((typeComboBox.Text == "Prepaid") && (operatorComboBox.Text == "Robi"))
            {
                int blPostTalkTime = Convert.ToInt32(balanceTextBox.Text) * 1;
                string minutes = Convert.ToString(blPostTalkTime);
                showTalkTimeLabel.Text = "He/She can talk about " + minutes + " minutes";
            }
            else if ((typeComboBox.Text == "Postpaid") && (operatorComboBox.Text == "Robi"))
            {
                int blPostTalkTime = (Convert.ToInt32(balanceTextBox.Text) + 70) * 2;
                string minutes = Convert.ToString(blPostTalkTime);
                showTalkTimeLabel.Text = "He/She can talk about " + minutes + " minutes";
            }
            else if ((typeComboBox.Text == "Prepaid") && (operatorComboBox.Text == "Airtel"))
            {
                int blPostTalkTime = Convert.ToInt32(balanceTextBox.Text)  * 4;
                string minutes = Convert.ToString(blPostTalkTime);
                showTalkTimeLabel.Text = "He/She can talk about " + minutes + " minutes";
            }
            else if ((typeComboBox.Text == "Postpaid") && (operatorComboBox.Text == "Airtel"))
            {
                int blPostTalkTime = (Convert.ToInt32(balanceTextBox.Text) + 30) * 4;
                string minutes = Convert.ToString(blPostTalkTime);
                showTalkTimeLabel.Text = "He/She can talk about " + minutes + " minutes";
            }
            else if ((typeComboBox.Text == "Prepaid") && (operatorComboBox.Text == "Citycel"))
            {
                int blPostTalkTime = Convert.ToInt32(balanceTextBox.Text) * 4;
                string minutes = Convert.ToString(blPostTalkTime);
                showTalkTimeLabel.Text = "He/She can talk about " + minutes + " minutes";
            }
            else 
            {
                int blPostTalkTime = (Convert.ToInt32(balanceTextBox.Text) + 15) * 5;
                string minutes = Convert.ToString(blPostTalkTime);
                showTalkTimeLabel.Text = "He/She can talk about " + minutes + " minutes";
            }

        }
    }
}
