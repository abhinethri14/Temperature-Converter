using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Fahrenheit to Celsius Converter code
            TempRef1.Service1Client test = new TempRef1.Service1Client(); // Creating reference to the temperature conversion webservice
            try
            {
                double ans = Convert.ToDouble(textBox_f2c.Text); // Converting text to double
                double res = test.f2c(ans);
                label11.Text = res.ToString();  //Convert from double to text
            }
            catch (Exception ex)
            {
                label11.Text = ex.Message.ToString();
            }
            }



        private void c2f_btn_Click(object sender, EventArgs e)
        {

            // Celsius to Fahrenheit Converter code
            TempRef1.Service1Client test = new TempRef1.Service1Client(); // Creating reference to the temperature conversion webservice
            try
            {
                double ans = Convert.ToDouble(textBox_c2f.Text); // Converting text to double
                double res = test.c2f(ans);
                label12.Text = res.ToString();  //Convert from double to text
            }
            catch (Exception ex)
            {
                label12.Text = ex.Message.ToString();
            }
            }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            //
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
