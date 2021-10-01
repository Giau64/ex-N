using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double num1, num2, result;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e) //Add button
        {
            try
            {
                num1 = double.Parse(txtNum1.Text);
                num2 = double.Parse(txtNum2.Text);

                txtResult.Text = AddNum(num1, num2).ToString();
                /*Method Invocation*/
            }
            catch
            {
                txtResult.Text = "Please enter num2er!"; //Error when user enters invalid value

                txtNum1.Clear();
                txtNum2.Clear();
            }
        }

        private double MultiplyNum(double a, double b) //Declaring Methods
        {
            result = a * b;

            return result;
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = double.Parse(txtNum1.Text);
                num2 = double.Parse(txtNum2.Text);

                txtResult.Text = MultiplyNum(num1, num2).ToString();
                /*Method Invocation*/
            }
            catch
            {
                txtResult.Text = "Please enter num2er!"; //Error when user enters invalid value

                txtNum1.Clear();
                txtNum2.Clear();
            }
        }

        private double AddNum(double a, double b) //Declaring Methods
        {
            result = a + b;

            return result;
        }

        

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResult.Clear();
        }

        
    }
}
