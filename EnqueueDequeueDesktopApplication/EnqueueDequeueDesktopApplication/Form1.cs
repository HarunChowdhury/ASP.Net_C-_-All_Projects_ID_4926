using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnqueueDequeueDesktopApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Queue<Customar> customer = new Queue<Customar>();
        public int i = 1;
        private void enqueueButton_Click(object sender, EventArgs e)
        {

            Customar newCustomer = new Customar();
            newCustomer.Name = nameEnqueueTextBox.Text;
            newCustomer.Compalin = complainEnqueueTextBox.Text;
            newCustomer.SerialNo = Convert.ToString(i);

            customer.Enqueue(newCustomer);
            i++;

            ListViewItem item = new ListViewItem();
            item.Tag = newCustomer;
            item.Text = newCustomer.SerialNo;
            item.SubItems.Add(newCustomer.Name);
            item.SubItems.Add(newCustomer.Compalin);
            listView1.Items.Add(item);
            MessageBox.Show(newCustomer.Name+@"'s Serial Number is  "+newCustomer.SerialNo);
            nameEnqueueTextBox.Text = "";
            complainEnqueueTextBox.Text = "";
          /*  Customar customer = new Customar();
            customer.Name = nameEnqueueTextBox.Text;
            customer.Compalin = complainEnqueueTextBox.Text; */

       /*     foreach(var control in groupBox1.Controls)
            {
                  Customar customerSelected=(Customar)control;

                  break;
            } */
          
            

          
          /*  ListViewItem item = new ListViewItem(customer.SerialNo+Convert.ToString(i++));
            item.SubItems.Add(customer.Name);
            item.SubItems.Add(customer.Compalin);
            item.Tag = customer;
            listView1.Items.Add(item);  */
        }

        private void dequeueButton_Click(object sender, EventArgs e)
        {
            Customar newCustomer = new Customar();
            newCustomer = customer.Dequeue();

            serialTextBox.Text = newCustomer.SerialNo;
            nameDequeueTextBox.Text = newCustomer.Name;
            complainDequeueTextBox.Text = newCustomer.Compalin;

            listView1.Items[0].Remove();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
