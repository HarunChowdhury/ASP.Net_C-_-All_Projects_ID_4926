using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemAddWithListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       // private string itemObj;
        private void addButton_Click(object sender, EventArgs e)
        {
            itemListBox.Items.Clear();
            int numberOfItem = Convert.ToInt32(itemTextBox.Text);

            for (int i = 0; i < numberOfItem; i++)
            {
                itemListBox.Items.Add(i+1);
            }

        }

        private void showButton_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("You have selected the " +itemListBox.SelectedItem + " item.");
        }
    }
}
