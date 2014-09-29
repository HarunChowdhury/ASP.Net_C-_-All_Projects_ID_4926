using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string fileLocation = @"C:\Users\PC21\Desktop\19 Sep 2014\Prac\employeeInfo.txt";
       // private string employeeName;
       // private string employeeId;
        //private string employeeAmount;
        private void saveButton_Click(object sender, EventArgs e)
        {
          string  employeeName = employeeNameTextBox.Text;
          string  employeeId = employeeIdTextBox.Text;
          string  employeeAmount = employeeSalaryTextBox.Text;
            string aRow = employeeName + "," + employeeId + "," + employeeAmount;

            FileStream aFileStream = new FileStream(fileLocation, FileMode.Append);
            StreamWriter aStreamWriter = new StreamWriter(aFileStream);
            aStreamWriter.Write(aRow);
            aStreamWriter.WriteLine();
            aStreamWriter.Close();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            FileStream aFileStream = new FileStream(fileLocation, FileMode.Open);
            StreamReader aStreamReader = new StreamReader(aFileStream);
            employeeInfoListBox.Items.Clear();

            double totalSalary = 0;

           
            while(!aStreamReader.EndOfStream)
            {
                string aRow = aStreamReader.ReadLine();
                char[] sp = {','};
                string[] employeeInformation = aRow.Split(sp);

                employeeInfoListBox.Items.Add(employeeInformation[0] + " " + employeeInformation[1] + " " + employeeInformation[2]);
                double amount=Convert.ToDouble(employeeInformation[2]);
                totalSalary += amount;

            }

            totalAmountTextBox.Text = totalSalary.ToString();

            aStreamReader.Close();


        }
    }
}
