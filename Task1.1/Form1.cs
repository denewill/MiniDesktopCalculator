using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorforTask1;

namespace Task1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            CTextbox();
            empty = true;
            stack1 = new Stack<double>();
        }

        calculator operation = new calculator();

        string sign = "";
        bool empty = false;
        bool clear = false;
        Stack<double> stack1;


        private void buttonC_Click(object sender, EventArgs e)
        {
            CTextbox();
            empty = true;
            stack1.Clear();
        }

        
        //clear calculator function -> show 0
        private void CTextbox()
        {
            Display.Text = "0";
        }

        //empty calculator function -> clear screen
        private void ETextbox()
        {
            Display.Text = "";
        }

        //CE status check
        private void CETextbox()
        {
            if (clear)
            {
                CTextbox();
                clear = false;
            }

            if (empty)
            {
                ETextbox();
                empty = false;
            }
        }

        //display result
        private void DisplayResult(double result)
        {
            CETextbox();
            Display.Text = Convert.ToString(result);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CETextbox();
            Display.Text += "9";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CETextbox();
            Display.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CETextbox();
            Display.Text += "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CETextbox();
            Display.Text += "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CETextbox();
            Display.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CETextbox();
            Display.Text += "4";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CETextbox();
            Display.Text += "3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CETextbox();
            Display.Text += "2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CETextbox();
            Display.Text += "1";
        }

        private void button0_Click(object sender, EventArgs e)
        {            
            if (Display.Text != "0")
            {
                CETextbox();
                Display.Text += "0";
            }            
        }

        private void buttonpoint_Click(object sender, EventArgs e)
        {
            CETextbox();
            if ((Display.Text.Length == 0))
            {
                Display.Text += "0";
                Display.Text += ".";
            }
            else if (!Display.Text.Contains("."))
            {
                Display.Text += ".";
            }
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            sign = "+";
            empty = true;
            clear = true;
            if (stack1.Count == 0)
            {
                stack1.Push(Convert.ToDouble(Display.Text));
            }
            Display.Text += sign;
        }

        private void buttonsub_Click(object sender, EventArgs e)
        {
            sign = "-";
            empty = true;
            clear = true;
            if (stack1.Count == 0)
            {
                stack1.Push(Convert.ToDouble(Display.Text));
            }
            Display.Text += sign;
        }

        private void buttonmul_Click(object sender, EventArgs e)
        {
            sign = "×";
            empty = true;
            clear = true;
            if (stack1.Count == 0)
            {
                stack1.Push(Convert.ToDouble(Display.Text));
            }
            Display.Text += sign;
        }

        private void buttondiv_Click(object sender, EventArgs e)
        {
            sign = "÷";
            empty = true;
            clear = true;
            if (stack1.Count == 0)
            {
                stack1.Push(Convert.ToDouble(Display.Text));
            }
            Display.Text += sign;
        }

        private void buttonpercent_Click(object sender, EventArgs e)
        {
            sign = "%×";
            empty = true;
            clear = true;
            if (stack1.Count == 0)
            {
                stack1.Push(Convert.ToDouble(Display.Text));
            }
            Display.Text += sign;
        }

        private void buttonpow_Click(object sender, EventArgs e)
        {
            sign = "^";
            empty = true;
            clear = true;
            if (stack1.Count == 0)
            {
                stack1.Push(Convert.ToDouble(Display.Text));
            }
            Display.Text += sign;
        }

        private void buttonroot_Click(object sender, EventArgs e)
        {
            sign = "√";
            empty = true;
            clear = true;
            if (stack1.Count == 0)
            {
                stack1.Push(Convert.ToDouble(Display.Text));
            }
            Display.Text += sign;
        }

        private void buttoneq_Click(object sender, EventArgs e)
        {
            double result = 0.0;
            double a = 0.0;
            double b = 0.0; 
            if (sign != "")
            {
                stack1.Push(Convert.ToDouble(Display.Text));
                if (stack1.Count > 1)
                {
                    b = stack1.Pop();
                    a = stack1.Pop();

                    switch (sign)
                    {
                        case "+":
                            {
                                result = operation.Add(a, b);
                                DisplayResult(result);
                                stack1.Push(result);
                                sign = "";
                                break;
                            }
                        case "-":
                            {
                                result = operation.Sub(a, b);
                                DisplayResult(result);
                                stack1.Push(result);
                                sign = "";
                                break;
                            }
                        case "×":
                            {
                                result = operation.Mul(a, b);
                                DisplayResult(result);
                                stack1.Push(result);
                                sign = "";
                                break;
                            }
                        case "÷":
                            {
                                if (b != 0)
                                {
                                    result = operation.Div(a, b);
                                    DisplayResult(result);
                                    stack1.Push(result);
                                    sign = "";
                                }
                                else
                                {
                                    Display.Text = "ERROR";
                                }
                               
                                break;
                            }
                        case "%×":
                            {
                                result = operation.Percent(a, b);
                                DisplayResult(result);
                                stack1.Push(result);
                                sign = "";
                                break;
                            }
                        case "^":
                            {
                                result = operation.Power(a, b);
                                DisplayResult(result);
                                stack1.Push(result);
                                sign = "";
                                break;
                            }
                        case "√":
                            {
                                if (b != 0)
                                {
                                    result = operation.Root(a, b);
                                    DisplayResult(result);
                                    stack1.Push(result);
                                    sign = "";
                                }
                                else
                                {
                                    Display.Text = "ERROR";
                                }
                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }  
                }               
            }            
        }        
    }
}
