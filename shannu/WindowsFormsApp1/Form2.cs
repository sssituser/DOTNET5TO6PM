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
        public Form2()
        {
            InitializeComponent();
        }
        private void btnDel_Click(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            AppendNumber("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            AppendNumber("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            AppendNumber("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            AppendNumber("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            AppendNumber("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            AppendNumber("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            AppendNumber("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            AppendNumber("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            AppendNumber("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
           
            AppendNumber("9");
        }

        private void AppendNumber(string number)
        {
            txtDisplay.Text += number;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnSub_Click(object sender, EventArgs e)
        {

        }

        private void btnMul_Click(object sender, EventArgs e)
        {

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {

        }
    }
}
