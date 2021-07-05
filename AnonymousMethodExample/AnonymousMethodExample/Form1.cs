using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnonymousMethodExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Button Button1 = new Button();
            //Button1.Text = "Click Me";
            //Button1.Click += new EventHandler(Button1_Click_1);

            //Unable to execute the Anonymous method piece of code in this program
            Button1.Click += delegate /*(object send, EventArgs eventArgs)*/
            {
                MessageBox.Show("Hello, you just clicked me");
            };

            this.Controls.Add(Button1);
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello, you just clicked me");
        }
    }
}
