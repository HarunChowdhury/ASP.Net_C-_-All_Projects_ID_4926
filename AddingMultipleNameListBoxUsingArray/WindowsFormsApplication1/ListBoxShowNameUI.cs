using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ListBoxShowNameUI : Form
    {
        public ListBoxShowNameUI()
        {
            InitializeComponent();
            nameAddButton.Enabled = false;
        }

       
   
        List<string> nameList=new List<string>(); 
       
        public int numberOfEmployee = 0;

      
        private void nameAddButton_Click(object sender, EventArgs e)
        {
          

            if (nameList.Count <= numberOfEmployee)
            {
              
                nameList.Add(nameTextBox.Text);

                addCountLabel.Text = "Number of Name =" + nameList.Count;             

                nameTextBox.Text = "";
                if (numberOfEmployee == nameList.Count)
                {
                    nameAddButton.Enabled = false;
                    foreach (string allName in nameList)
                    {
                        if (allName != null)
                        {
                            nameListBox.Items.Add(allName);
                        }
                    }
                }

            }

            setCountTextBox.Text = "";


        }

        private void nameResetButton_Click(object sender, EventArgs e)
        {
            nameListBox.Items.Clear();
            setCountButton.Enabled = true;
            nameAddButton.Enabled=true;
            addCountLabel.Text = "Number of Name =" + "";
            nameTextBox.Text = "";
            setCountTextBox.Text = "";
          
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            nameListBox.Items.Clear();
            foreach (string allName in nameList)
            {
                if (allName != null)
                {
                    nameListBox.Items.Add(allName);
                }
            }


            
        }

        
        private void setCountButton_Click(object sender, EventArgs e)
        {
             numberOfEmployee =Convert.ToInt32(setCountTextBox.Text);
             setCountButton.Enabled = false;
             nameAddButton.Enabled = true;
             setCountTextBox.Text = "";
        }

        private void setCountTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
