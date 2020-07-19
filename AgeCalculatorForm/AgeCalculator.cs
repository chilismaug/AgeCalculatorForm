using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AgeCalculatorForm
{
    public partial class AgeCalculator : Form
    {
        public AgeCalculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int day, month, year, TotalDays;

            //creating the object of WCF service client       
            ServiceReference1.Service1Client age = new ServiceReference1.Service1Client();

            //assigning the input values to the variables       
            day = int.Parse(textBox1.Text);
            month = int.Parse(textBox2.Text);
            year = int.Parse(textBox3.Text);

            //assigning the output value from service Response       
            TotalDays = age.calculateDays(day, month, year);

            //assigning the output value to the lable to show user       
            MessageBox.Show("You are Currently " + Convert.ToString(TotalDays) + " days old");

        }
    }
}


 
