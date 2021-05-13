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
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

      

       

        private void btn9_Click(object sender, EventArgs e)
        {
           
            if (lblResult.Text == "0")
            {
                lblResult.Text = (sender as Button).Text;
                
            }
            else
            {
                lblResult.Text+= (sender as Button).Text;
            }
            
        }

        
        private void btnPlus_Click(object sender, EventArgs e)
        {
            ChangeSymbol("+");
        }

        private void ChangeSymbol(string symbol)
        {
            var elem = lblResult.Text.Split(" ");
            if (elem.Length > 3 && elem[2] == "")
            {
                return;
            }
            if (elem.Length > 2)
            {
                if(elem.Length >= 3)
                {
                    btnEquals_Click(null, null);
                    elem[0] = lblResult.Text.Split(" ")[0];
                }
                elem[1] = symbol;
                lblResult.Text = $"{elem[0]} {elem[1]} ";

            }
            else if (elem.Length == 1 || elem[1] == "")
            {
                lblResult.Text += $" {symbol} ";
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            ChangeSymbol("-");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            ChangeSymbol("*");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            ChangeSymbol("/");
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            var elem = lblResult.Text.Split(" ");
            if(elem.Length < 3 || (elem[2] == "" && elem.Length == 3))
            {
                return;
            }
            var firstNum = decimal.Parse(elem[0]);
            var secondNum = decimal.Parse(elem[2]);

            switch (elem[1])
            {
                case "+":
                    lblResult.Text = ((decimal)(firstNum + secondNum)).ToString();
                    break;
                case "-":
                    lblResult.Text = ((decimal)(firstNum - secondNum)).ToString();
                    break;
                case "/":
                    lblResult.Text = ((decimal)(firstNum / secondNum)).ToString();
                    break;
                case "*":
                    lblResult.Text = ((decimal)(firstNum * secondNum)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            var elem = lblResult.Text.Split(" ");
            if (elem.Length == 3 && elem[2] != "")
            {
                lblResult.Text = $"{elem[0]} {elem[1]} " ;
            }else
            {
                lblResult.Text = "0";
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            lblResult.Text = "0";
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            var elem = lblResult.Text.Split(" ");
            if (elem.Length == 3 && elem[2] != "")
            {
                lblResult.Text = $"{elem[0]} {elem[1]} {decimal.Parse(elem[2])*-1}";
            }
            else if(elem[0] != "0")
            {
                lblResult.Text = $"{decimal.Parse(elem[0]) * -1}";
            }
        }

        private void RemoveOneSumbol(ref string str,string nullSumbol)
        {
            if(str.Length == 1)
            {
                str = nullSumbol;
            }
            else
            {
               str = str.Remove(str.Length - 1);
            }
                
        }
        private void btnBackSpace_Click(object sender, EventArgs e)
        {

            var elem = lblResult.Text.Split(" ");
            if(elem.Length == 1)
            {
                RemoveOneSumbol(ref elem[0],"0");
                lblResult.Text = $"{elem[0]}";
            }
            else if (elem.Length == 2 || elem[2] == "")
            {
                lblResult.Text = elem[0];
            }else
            {
                RemoveOneSumbol(ref elem[2],"");
                 lblResult.Text = $"{elem[0]} {elem[1]} {elem[2]}";
            }
        }

        private void btnRoot_Click(object sender, EventArgs e)
        {
            var elem = lblResult.Text.Split(" ");
            if (elem.Length == 1 || elem[1] == "")
            {
                elem[0] = (Math.Sqrt((double)(decimal.Parse(elem[0])))).ToString();
                lblResult.Text = elem[0];
            }
            else if (elem.Length == 2 || elem[2] == "")
            {
                string elem2 = (Math.Sqrt((double)(decimal.Parse(elem[0])))).ToString();
                lblResult.Text = $"{elem[0]} {elem[1]} {elem2}";

            }
            else if (elem.Length == 3 || elem[3] == "")
            {
                elem[2] = (Math.Sqrt((double)(decimal.Parse(elem[2])))).ToString();
                lblResult.Text = $"{elem[0]} {elem[1]} {elem[2]}";
                btnEquals_Click(null, null);
            }

        }

        private void button24_Click(object sender, EventArgs e)
        {
            var elem = lblResult.Text.Split(" ");
            if (elem.Length == 1 || elem[1] == "")
            {
                elem[0] = (((double)(1 /  decimal.Parse(elem[0])))).ToString();
                lblResult.Text = elem[0];
            }
            else if (elem.Length == 2 || elem[2] == "")
            {
                string elem2 = (((double)(1 / decimal.Parse(elem[0])))).ToString();
                lblResult.Text = $"{elem[0]} {elem[1]} {elem2}";

            }
            else if (elem.Length == 3 || elem[3] == "")
            {
                elem[2] = (((double)(1 / decimal.Parse(elem[2])))).ToString();
                lblResult.Text = $"{elem[0]} {elem[1]} {elem[2]}";
                btnEquals_Click(null, null);
            }
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            var elem = lblResult.Text.Split(" ");
            if (elem.Length == 1 || elem[1] == "")
            {
                elem[0] = (Math.Pow((double)(decimal.Parse(elem[0])),2)).ToString();
                lblResult.Text = elem[0];
            }
            else if (elem.Length == 2 || elem[2] == "")
            {
                string elem2 = (Math.Pow((double)(decimal.Parse(elem[0])),2)).ToString();
                lblResult.Text = $"{elem[0]} {elem[1]} {elem2}";

            }
            else if (elem.Length == 3 || elem[3] == "")
            {
                elem[2] = (Math.Pow((double)(decimal.Parse(elem[2])),2)).ToString();
                lblResult.Text = $"{elem[0]} {elem[1]} {elem[2]}";
                btnEquals_Click(null, null);
            }
        }

        private void btnProccent_Click(object sender, EventArgs e)
        {
            var elem = lblResult.Text.Split(" ");
            if(elem.Length < 3)
            {
                return;
            }
            if (elem.Length == 3 || elem[3] == "")
            {
                var proc = (((decimal.Parse(elem[0]))/100)* decimal.Parse(elem[2]) );
                lblResult.Text = $"{elem[0]} {elem[1]} {(proc)}";
                btnEquals_Click(null, null);
            }
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            var elem = lblResult.Text.Split(" ");
            if(elem.Length == 1)
            {
                elem[0] += ".";
                lblResult.Text = $"{elem[0]}";
            }
            else if(elem.Length == 3)
            {
                elem[2] += ".";
                lblResult.Text = $"{elem[0]} {elem[1]} {elem[2]}";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.Width = 514;
            this.Refresh();

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.Width = 658;
            this.Refresh();
        }

        private void btnSIN_Click(object sender, EventArgs e)
        {
            double cof;
            if (radioButton1.Checked)
            {
                cof = 1;
            }
            else
            {
                cof = 0.017453298768179;
            }
            var elem = lblResult.Text.Split(" ");
            if (elem.Length == 1 || elem[1] == "")
            {
                elem[0] = (Math.Sin((double.Parse(elem[0])*cof))).ToString();
                lblResult.Text = elem[0];
            }
            else if (elem.Length == 2 || elem[2] == "")
            {
                string elem2 = (Math.Sin((double.Parse(elem[0])*cof))).ToString();
                lblResult.Text = $"{elem[0]} {elem[1]} {elem2}";

            }
            else if (elem.Length == 3 || elem[3] == "")
            {
                elem[2] = (Math.Sin((double.Parse(elem[0])*cof))).ToString();
                lblResult.Text = $"{elem[0]} {elem[1]} {elem[2]}";
                btnEquals_Click(null, null);
            }
        }

        private void btnCOS_Click(object sender, EventArgs e)
        {
            var elem = lblResult.Text.Split(" ");
            double cof;
            if (radioButton1.Checked)
            {
                cof = 1;
            }
            else
            {
                cof = 0.017453298768179;
            }
                if (elem.Length == 1 || elem[1] == "")
                {
                    elem[0] = (Math.Cos(double.Parse(elem[0])*cof)).ToString();
                    lblResult.Text = elem[0];
                }
                else if (elem.Length == 2 || elem[2] == "")
                {
                    string elem2 = (Math.Cos(double.Parse(elem[0])*cof)).ToString();
                    lblResult.Text = $"{elem[0]} {elem[1]} {elem2}";

                }
                else if (elem.Length == 3 || elem[3] == "")
                {
                    elem[2] = (Math.Cos(double.Parse(elem[0])*cof)).ToString();
                    lblResult.Text = $"{elem[0]} {elem[1]} {elem[2]}";
                    btnEquals_Click(null, null);
                }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var elem = lblResult.Text.Split(" ");
            double cof;
            if (radioButton1.Checked)
            {
                cof = 1;
            }
            else
            {
                cof = 0.017453298768179;
            }
            if (elem.Length == 1 || elem[1] == "")
            {
                elem[0] = (Math.Tan(double.Parse(elem[0])*cof)).ToString();
                lblResult.Text = elem[0];
            }
            else if (elem.Length == 2 || elem[2] == "")
            {
                string elem2 = (Math.Tan(double.Parse(elem[0]))).ToString();
                lblResult.Text = $"{elem[0]} {elem[1]} {elem2}";

            }
            else if (elem.Length == 3 || elem[3] == "")
            {
                elem[2] = (Math.Tan(double.Parse(elem[0])*cof)).ToString();
                lblResult.Text = $"{elem[0]} {elem[1]} {elem[2]}";
                btnEquals_Click(null, null);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.S)
            {
                btnSIN_Click(null,null);
            }else if(e.KeyCode == Keys.C)
            {
                btnCOS_Click(null, null);
            }else if(e.KeyCode == Keys.T)
            {
                button3_Click(null, null);
            }else if(e.KeyCode == Keys.Enter)
            {
                btnEquals_Click(null, null);
                return;
            }else if(e.KeyCode == Keys.F9)
            {
                btnChange_Click(null, null);
            }else if(e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                 btn9_Click(btn1,null);
            }
            else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                btn9_Click(btn2, null);
            }
            else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                btn9_Click(btn3, null);
            }
            else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                btn9_Click(btn4, null);
            }
            else if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
            {
                btn9_Click(btn5, null);
            }
            else if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
            {
                btn9_Click(btn6, null);
            }
            else if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            {
                btn9_Click(btn7, null);
            }
            else if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
            {
                btn9_Click(btn7, null);
            }
            else if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
            {
                btn9_Click(btn8, null);
            }
            else if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
            {
                btn9_Click(btnZero, null);
            }
            else if (e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.OemPeriod )
            {
                btn9_Click(btnZero, null);
            }else if(e.KeyCode == Keys.Oemplus)
            {
                btnPlus_Click(null, null);
            }else if(e.KeyCode == Keys.Divide)
            {
                btnDivide_Click(null, null);
            }else if(e.KeyCode == Keys.OemMinus)
            {
                btnMinus_Click(null, null);
            }else if(e.KeyCode == Keys.Multiply)
            {
                btnMultiply_Click(null,null);
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar== (char)Keys.Return)
            {
                btnEquals_Click(null, null);
            }
        }
    }
}
