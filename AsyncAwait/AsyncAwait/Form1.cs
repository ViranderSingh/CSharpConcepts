using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace AsyncAwait
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int CountCharacters()
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(@"C:\Users\MandeepSingh\Documents\CSharpDemo\Data.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(5000);
            }

            return count;
        }

        int characterCount = 0;
        //private async void btnProcessFile_Click(object sender, EventArgs e)
        private void btnProcessFile_Click(object sender, EventArgs e)
        {
            //Task, async and await keywords
            //Task<int> task = new Task<int>(CountCharacters);
            //task.Start();

            //Using Thread instead of Task
            //int count = 0; //used to thread
            Thread thread = new Thread(() => { 
                characterCount = CountCharacters();
                Action action = new Action(setLabelTextProperty);
                this.BeginInvoke(action);
            });
            thread.Start();

            lblCount.Text = "Processing File. Please wait...";
            //int count = await task;
            //lblCount.Text = count.ToString() + " Characters in file";           
            
        }
        private void setLabelTextProperty()
        {
            lblCount.Text = characterCount.ToString() + " Characters in file";
        }
    }
}
