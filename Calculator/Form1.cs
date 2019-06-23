using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        VerCal Calc = new VerCal();
        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += button1.Text;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text;
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += button11.Text;
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += button10.Text;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            bool calDot = textBox1.Text.LastIndexOf(".") > 0;
            bool caloper = textBox1.Text.IndexOf("*") > 0|| textBox1.Text.IndexOf("/") > 0|| textBox1.Text.IndexOf("+") > 0|| textBox1.Text.IndexOf("-") > 0;
            bool operVsDOt = textBox1.Text.LastIndexOf(".") < textBox1.Text.IndexOf("*")|| textBox1.Text.LastIndexOf(".") < textBox1.Text.IndexOf("/")|| textBox1.Text.LastIndexOf(".") < textBox1.Text.IndexOf("-")|| textBox1.Text.LastIndexOf(".") < textBox1.Text.IndexOf("+");
            if (!calDot)
            {
                textBox1.Text += ".";
            }
            else if (calDot && caloper&&operVsDOt)
            {
                textBox1.Text += ".";
            }
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += button15.Text;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Calc.Ver1 = 0;
            Calc.Ver2 = 0;
            Calc.VerOp = " ";
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.TextLength - 1);
            }
            bool caloper = textBox1.Text.IndexOf("*") > 0 || textBox1.Text.IndexOf("/") > 0 || textBox1.Text.IndexOf("+") > 0 || textBox1.Text.IndexOf("-") > 0;
            if (!caloper)
            {
                Calc.VerOp = "";
            }

        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            bool caloper = textBox1.Text.IndexOf("*") > 0 || textBox1.Text.IndexOf("/") > 0 || textBox1.Text.IndexOf("+") > 0 || textBox1.Text.IndexOf("-") > 0;
            
            if (textBox1.Text.IndexOf(Calc.VerOp) + 1 == textBox1.Text.Length)
            {
                
                textBox1.Text = textBox1.Text.Substring(0, textBox1.TextLength - 1)+"*";
                Calc.VerOp = "*";
                return;

            }
            if (caloper)
            {
                Calc.VerOp = "*";
                Calc.Ver2 = int.Parse(textBox1.Text.Substring(Calc.Ver1.ToString().Length+1));
                int res = Calc.Operate();
                Calc.Ver1 = res;
                textBox1.Text = res.ToString()+"*";
                
                
            }
            else
            {
                Calc.VerOp = "*";

                Calc.Ver1 = int.Parse(textBox1.Text);
                 textBox1.Text += "*";
            }
        }

        private void BtnNotX_Click(object sender, EventArgs e)
        {
            bool caloper = textBox1.Text.IndexOf("*") > 0 || textBox1.Text.IndexOf("/") > 0 || textBox1.Text.IndexOf("+") > 0 || textBox1.Text.IndexOf("-") > 0;
            
            if (textBox1.Text.IndexOf(Calc.VerOp) + 1 == textBox1.Text.Length)
            {

                textBox1.Text = textBox1.Text.Substring(0, textBox1.TextLength - 1) + "/";
                Calc.VerOp = "/";
                return;

            }
            if (caloper)
            {
                Calc.VerOp = "/";
                Calc.Ver2 = int.Parse(textBox1.Text.Substring(Calc.Ver1.ToString().Length + 1));
                int res = Calc.Operate();
                Calc.Ver1 = res;
                textBox1.Text = res.ToString() + "/";
                

            }
            else
            {
                Calc.VerOp = "/";
                Calc.Ver1 = int.Parse(textBox1.Text);
                textBox1.Text += "/";
            }
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            bool caloper = textBox1.Text.IndexOf("*") > 0 || textBox1.Text.IndexOf("/") > 0 || textBox1.Text.IndexOf("+") > 0 || textBox1.Text.IndexOf("-") > 0;
            
            if (textBox1.Text.IndexOf(Calc.VerOp) + 1 == textBox1.Text.Length)
            {

                textBox1.Text = textBox1.Text.Substring(0, textBox1.TextLength - 1) + "-";
                Calc.VerOp = "-";
                return;

            }
            if (caloper)
            {
                Calc.VerOp = "-";
                Calc.Ver2 = int.Parse(textBox1.Text.Substring(Calc.Ver1.ToString().Length + 1));
                int res = Calc.Operate();
                Calc.Ver1 = res;
                textBox1.Text = res.ToString()+"-";
                
            }
            else
            {
                Calc.VerOp = "-";
                Calc.Ver1 = int.Parse(textBox1.Text);
                textBox1.Text += "-";
            }
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            bool caloper = textBox1.Text.IndexOf("*") > 0 || textBox1.Text.IndexOf("/") > 0 || textBox1.Text.IndexOf("+") > 0 || textBox1.Text.IndexOf("-") > 0;
            if (textBox1.Text.IndexOf(Calc.VerOp) + 1 == textBox1.Text.Length)
            {

                textBox1.Text = textBox1.Text.Substring(0, textBox1.TextLength - 1) + "+";
                Calc.VerOp = "+";
                return;


            }
            if (caloper)
            {
                Calc.VerOp = "+";
                Calc.Ver2 = int.Parse(textBox1.Text.Substring(Calc.Ver1.ToString().Length));
                int res = Calc.Operate();
                Calc.Ver1 = res;
                textBox1.Text = res.ToString()+"+";
                
            }
            else
            {
                Calc.VerOp = "+";
                Calc.Ver1 = int.Parse(textBox1.Text);
                textBox1.Text += "+";
            }
        }

        private void BtnAssigin_Click(object sender, EventArgs e)
        {
            bool caloper = textBox1.Text.IndexOf("*") > 0 || textBox1.Text.IndexOf("/") > 0 || textBox1.Text.IndexOf("+") > 0 || textBox1.Text.IndexOf("-") > 0;
            bool ceckAsi = textBox1.Text.Length > textBox1.Text.IndexOf(Calc.VerOp)+1;
            if (ceckAsi&&caloper)
            {
                Calc.Ver2 = int.Parse(textBox1.Text.Substring(Calc.Ver1.ToString().Length + 1));
                int res = Calc.Operate();
                textBox1.Text = res.ToString();
                Calc.VerOp = " ";
                Calc.Ver1 = 0;
                Calc.Ver2 = 0;


            }
            else
            {

                
            }
        }
    }
}
