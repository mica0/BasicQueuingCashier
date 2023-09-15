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

namespace BasicQueuingCashier
{
    public partial class CashierWindowQueueForm : Form
    {
       // private CustomerView customerView;
        public CashierWindowQueueForm()
        {
            InitializeComponent();
            //  customerView = new CustomerView();
            //  customerView.Show();
           
        }
        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //listCashierQueue.Items.Remove();
            foreach (object obj in listCashierQueue.Items)
            {
               
            }
            {
                if (CashierClass.CashierQueue.Contains(CashierClass.CashierQueue.Peek()))
                {
                    string s = CashierClass.CashierQueue.Peek();
                }
                else
                {
                    MessageBox.Show("The queue is empty. " );
                }
                
            }
        }
        public void timer1_Tick(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }
    }
}
