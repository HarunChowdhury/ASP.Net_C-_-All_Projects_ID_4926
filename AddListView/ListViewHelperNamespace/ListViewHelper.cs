using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViewHelperNamespace
{
    public class ListViewHelper
    {
       public  void AddListView(ListView myListView,string name,double salary)
       {
           ListViewItem item = new ListViewItem(name);
           item.SubItems.Add(salary.ToString());
           myListView.Items.Add(item);
       }
    }
}
