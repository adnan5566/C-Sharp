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
        public Form1()
        {
            InitializeComponent();
        }
        int count = 0;
        private void btnOne_Click(object sender, EventArgs e)
        {
            if(count==0)
            {
                txtResult.Text = "1";
                count = 1;
            }
            else 
            {
                txtResult.Text += "1";
            }
            
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {

            if (count == 0)
            {
                txtResult.Text = "2";
                count = 1;
            }
            else
            {
                txtResult.Text += "2";
            }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {

            if (count == 0)
            {
                txtResult.Text = "3";
                count = 1;
            }
            else
            {
                txtResult.Text += "3";
            }
        }

        private void btnFour_Click(object sender, EventArgs e)
        {

            if (count == 0)
            {
                txtResult.Text = "4";
                count = 1;
            }
            else
            {
                txtResult.Text += "4";
            }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {

            if (count == 0)
            {
                txtResult.Text = "5";
                count = 1;
            }
            else
            {
                txtResult.Text += "5";
            }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {

            if (count == 0)
            {
                txtResult.Text = "6";
                count = 1;
            }
            else
            {
                txtResult.Text += "6";
            }
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {

            if (count == 0)
            {
                txtResult.Text = "7";
                count = 1;
            }
            else
            {
                txtResult.Text += "7";
            }
        }

        private void btnEight_Click(object sender, EventArgs e)
        {

            if (count == 0)
            {
                txtResult.Text = "8";
                count = 1;
            }
            else
            {
                txtResult.Text += "8";
            }
        }

        private void btnNine_Click(object sender, EventArgs e)
        {

            if (count == 0)
            {
                txtResult.Text = "9";
                count = 1;
            }
            else
            {
                txtResult.Text += "9";
            }
        }

        private void btnZero_Click(object sender, EventArgs e)
        {

            if (count == 0)
            {
                txtResult.Text = "0";
                count = 1;
            }
            else
            {
                txtResult.Text += "0";
            }
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {

            if (count == 0)
            {
                txtResult.Text = ".";
                count = 1;
            }
            else if(!txtResult.Text.Contains("."))
            {
                txtResult.Text += ".";
            }
        }
        double num1 = 0.0;
        double num2 = 0.0;
        string op = "";
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtResult.Text)&&txtResult.Text!=".")
            {
                num1 = Convert.ToDouble(txtResult.Text);
                op = "+";
                count = 0;
            }
        }

        private void btnSubstraction_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtResult.Text) && txtResult.Text != ".")
            {
                num1 = Convert.ToDouble(txtResult.Text);
                op = "-";
                count = 0;
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtResult.Text) && txtResult.Text != ".")
            {
                num1 = Convert.ToDouble(txtResult.Text);
                op = "*";
                count = 0;
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtResult.Text) && txtResult.Text != ".")
            {
                num1 = Convert.ToDouble(txtResult.Text);
                op = "/";
                count = 0;
            }
        }
        double result;
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtResult.Text)&& op!=""&& txtResult.Text != ".")
            {
                num2 = Convert.ToDouble(txtResult.Text);
                if(op=="+")
                {
                    result = num1 + num2;
                }
                if (op == "-")
                {
                    result = num1 - num2;
                }
                if (op == "*")
                {
                    result = num1 * num2;
                }
                if (op == "/")
                {
                    result = num1 / num2;
                }
                txtResult.Text=result.ToString();
            }
        }

        private void btnClearOne_Click(object sender, EventArgs e)
        {
           /* try
            {
                ShowResult.Text = ShowResult.Text.Remove(ShowResult.Text.Length - 1);
            }
            catch(Exception p)
            {
                ShowResult.Text = p.Message;
            }
           */
           if(!string.IsNullOrWhiteSpace(txtResult.Text))
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1);
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtResult.Text = null;
            num1 = 0.0;
            num2 = 0.0;
            count = 0;
        }

        private void pnl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Closing App");
            Application.Exit();
            
        }

        
    }
}
