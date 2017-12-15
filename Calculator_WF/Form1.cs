using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_WF
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string Operation;
        public Form1()
        {
            InitializeComponent();
        }             

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0" && txtdisplay.Text != null)
            {
                txtdisplay.Text = "1";
            }
            else
            {
                txtdisplay.Text = txtdisplay.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0" && txtdisplay.Text != null)
            {
                txtdisplay.Text = "2";
            }
            else
            {
                txtdisplay.Text = txtdisplay.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0" && txtdisplay.Text != null)
            {
                txtdisplay.Text = "3";
            }
            else
            {
                txtdisplay.Text = txtdisplay.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0" && txtdisplay.Text != null)
            {
                txtdisplay.Text = "4";
            }
            else
            {
                txtdisplay.Text = txtdisplay.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0" && txtdisplay.Text != null)
            {
                txtdisplay.Text = "5";
            }
            else
            {
                txtdisplay.Text = txtdisplay.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0" && txtdisplay.Text != null)
            {
                txtdisplay.Text = "6";
            }
            else
            {
                txtdisplay.Text = txtdisplay.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if(txtdisplay.Text=="0" && txtdisplay.Text!=null)
            {
                txtdisplay.Text = "7";
            }
            else
            {
                txtdisplay.Text = txtdisplay.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0" && txtdisplay.Text != null)
            {
                txtdisplay.Text = "8";
            }
            else
            {
                txtdisplay.Text = txtdisplay.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0" && txtdisplay.Text != null)
            {
                txtdisplay.Text = "9";
            }
            else
            {
                txtdisplay.Text = txtdisplay.Text + "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0" && txtdisplay.Text != null)
            {
                txtdisplay.Text = "0";
            }
            else
            {
                txtdisplay.Text = txtdisplay.Text + "0";
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = "0";
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + ".";
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtdisplay.Text);
            txtdisplay.Text = "0";
            Operation = "+";
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtdisplay.Text);
            txtdisplay.Text = "0";
            Operation = "-";
        }

        private void btnmutiply_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtdisplay.Text);
            txtdisplay.Text = "0";
            Operation = "*";
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtdisplay.Text);
            txtdisplay.Text = "0";
            Operation = "/";
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;
            SecondNumber = Convert.ToDouble(txtdisplay.Text);
            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                txtdisplay.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                txtdisplay.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                txtdisplay.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if(SecondNumber==0)
                {
                    txtdisplay.Text="Cannot divide zero";
                }
                else{
                    Result = (FirstNumber / SecondNumber);
                    txtdisplay.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }                
            }
        }

    }
}
