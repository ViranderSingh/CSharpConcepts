using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace MultiThreadingExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBoxNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTimeConsumingWork_Click(object sender, EventArgs e)
        {
            btnTimeConsumingWork.Enabled = false;
            btnPrintNumbers.Enabled = false;

            Thread workerThread = new Thread(DoTimeConsumingWork);
            workerThread.Start();       //This thread makes the application more responsive by offloading the work of executing time consuming functions to a background thread
            //DoTimeConsumingWork();

            btnTimeConsumingWork.Enabled = true;
            btnPrintNumbers.Enabled = true;
        }

        private void DoTimeConsumingWork()
        {
            Thread.Sleep(5000);
        }

        private void btnPrintNumbers_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                listBoxNumbers.Items.Add(i);
            }
        }
    }
}
