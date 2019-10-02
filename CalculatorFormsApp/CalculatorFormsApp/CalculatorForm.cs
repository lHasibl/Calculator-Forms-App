using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorFormsApp
{
    public partial class CalculatorForm : Form
    {
        string firstnumber;
        string secondnumber;
        string result;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            firstnumber = firstNumberTextBox.Text;
            secondnumber = secondNumberTextBox.Text;
            double f = Convert.ToInt32(firstnumber);
            double s = Convert.ToInt32(secondnumber);
            double r = s + f;
            result = r.ToString();
            resultTextBox.Text = result;


        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            firstnumber = firstNumberTextBox.Text;
            secondnumber = secondNumberTextBox.Text;
            double f = Convert.ToInt32(firstnumber);
            double s = Convert.ToInt32(secondnumber);
            double r = f - s;
            result = r.ToString();
            resultTextBox.Text = result;
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            firstnumber = firstNumberTextBox.Text;
            secondnumber = secondNumberTextBox.Text;
            double f = Convert.ToInt32(firstnumber);
            double s = Convert.ToInt32(secondnumber);
            double r = f * s;
            result = r.ToString();
            resultTextBox.Text = result;
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            firstnumber = firstNumberTextBox.Text;
            secondnumber = secondNumberTextBox.Text;
            double f = Convert.ToInt32(firstnumber);
            double s = Convert.ToInt32(secondnumber);
            double r = f / s;
            result = r.ToString();
            resultTextBox.Text = result;
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            firstNumberTextBox.Clear();
            secondNumberTextBox.Clear();
            resultTextBox.Clear();
        }
    }
}
