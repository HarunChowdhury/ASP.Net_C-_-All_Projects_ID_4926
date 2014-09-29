using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplainCustomerCareEndueueDequeueUI
{
    public partial class CustomarComplainUI : Form
    {
        public CustomarComplainUI()
        {
            InitializeComponent();
        }

        private string name;
        private string complain;
        private int serialNo = 1;
        private Queue<string> myQueue =new Queue<string>();
        private ListViewItem details;



        private void enqueueButton_Click(object sender, EventArgs e)
        {
           
             name = nameEnqueueTextBox.Text;
             complain = complainEnqueueTextBox.Text;

            
              myQueue.Enqueue(Convert.ToString(serialNo));
              myQueue.Enqueue(name);
              myQueue.Enqueue(complain);
            
              details = new ListViewItem();

           // details.Tag = myQueue;
            
            details.Text = Convert.ToString(serialNo);



            details.SubItems.Add(name);
            details.SubItems.Add(complain);
            waitingQueueListView.Items.Add(details);


            serialNo++;

        }

        private void deQueueButton_Click(object sender, EventArgs e)
        {
            //Queue<string> dequeueDeat= new Queue<string>();
           // dequeueDeat = myQueue.Dequeue();


            if (myQueue.Count == 0)
            {
                MessageBox.Show("queue is empty");
            }
            else
            {
                serialNoDequeueTextBox.Text = myQueue.Dequeue();
                nameDequeueTextBox.Text = myQueue.Dequeue();
                complainDequeueTextBox.Text = myQueue.Dequeue();

                waitingQueueListView.Items[0].Remove();
            }
        }
    }
}
