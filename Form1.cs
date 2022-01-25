using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            label1.Text = "..."; //default state 
            label2.Text = "...";
            label3.Text = "...";
            label4.Text = "...";
            label5.Text = "...";
            label6.Text = "..."; 
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();  // create a random number generator
            int[] seq = new int[59];  // create an array to hold number 1-59
            for ( int i = 1 ; i < 60; i++ ) seq[i - 1] = i;  //fill array elements 0-58 with number 1 - 59
            //Shuffle values in all elements labels 1-6
            for (int i = 0; i < 59; i++)
            {
                int j = (rnd.Next() % 59);
                int k = seq[i]; seq[i] = seq[j];seq[j] = k;
            }
            // Display values in array elements 1-6
            label1.Text = seq[1].ToString();
            label2.Text = seq[2].ToString();
            label3.Text = seq[3].ToString();
            label4.Text = seq[4].ToString();
            label5.Text = seq[5].ToString();
            label6.Text = seq[6].ToString();

            //set the button states to done
            button1.Enabled = false;
            button2.Enabled = true;



        }

        
    }
}
