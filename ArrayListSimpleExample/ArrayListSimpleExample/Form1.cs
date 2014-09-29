using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayListSimpleExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private ArrayList dataList;
        private void addButton_Click(object sender, EventArgs e)
        {
            dataList=new ArrayList();

            dataList.Add(inputDataTextBox.Text);
           
            inputDataTextBox.Text = "";
           
        }

        private void showAllDataButton_Click(object sender, EventArgs e)
        {
             
            // ListBox showData=new ListBox();
            foreach (string receiveData in dataList)
            {


                showDataListBox.Items.Add(receiveData);

            }

            showDataListBox.Text = "";
        }
    }
}
