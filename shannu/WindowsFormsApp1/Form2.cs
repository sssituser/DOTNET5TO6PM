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

    
    public partial class Form2 : Form
    {
        double a;
        string oper;
        public Form2()
        {
            InitializeComponent();
        }

        
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            }
           
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "0";
            }
            else
                txtDisplay.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "1";
            }
            else
                txtDisplay.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "2";
            }
            else
                txtDisplay.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "3";
            }
            else
                txtDisplay.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "4";
            }
            else
                txtDisplay.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "5";
            }
            else
                txtDisplay.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "6";
            }
            else
                txtDisplay.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "7";
            }
            else
                txtDisplay.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "8";
            }
            else
                txtDisplay.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "9";
            }
            else
                txtDisplay.Text += "9";

        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            oper = "+";
            a = double.Parse(txtDisplay.Text);
            txtDisplay.Text=string.Empty;

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            oper = "-";
            a = double.Parse(txtDisplay.Text);
            txtDisplay.Text = string.Empty;
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            oper = "*";
            a = double.Parse(txtDisplay.Text);
            txtDisplay.Text = string.Empty;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            switch (oper)
            {
                case "+":
                    a+=double.Parse(txtDisplay.Text);
                    break;
                case "-":
                    a -= double.Parse(txtDisplay.Text);
                    break;
                case "*":
                    a *= double.Parse(txtDisplay.Text);
                    break; 
                case "/":
                    {
                        if(txtDisplay.Text=="0")
                        {
                            MessageBox.Show("Divisor should not be Zero");
                            return;
                        }
                        a /= double.Parse(txtDisplay.Text);
                    }
                    break;

            }

            txtDisplay.Text = a.ToString();
            MessageBox.Show($"Result is : {a.ToString()}" );
           

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            oper = "/";
            a = double.Parse(txtDisplay.Text);
            txtDisplay.Text = string.Empty;

        }

        private void btnAllClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = string.Empty;
        }

       

        private void btnDot_Click(object sender, EventArgs e)
        {
           if(txtDisplay.Text.Contains("."))
            {

            }
            else
            {
                if (txtDisplay.Text == "0")
                {
                    txtDisplay.Text = "0.";
                }
                else
                    txtDisplay.Text += ".";
            }
        }
    }
}
