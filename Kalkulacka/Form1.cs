using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulacka
{
    public partial class Form1 : Form
    {
        public bool decimalpoint;
        public bool digit_only_input;
        public bool valueinput;
        public bool operation;
        public bool power;
        public bool sqrt;
        public bool factorial;
        public bool result;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if (input.Text == "0")
            {
                input.Clear();
            }
            operation = false;
            sqrt = false;
            Button button = (Button)sender;

            if (button.Name == "decimal_point")
            {
                if (decimalpoint == false && factorial == false && power == false)
                {
                    if (valueinput == false || input.Text == "")
                    {
                        input.Text += "0,";
                    }
                    else
                    {
                        input.Text += ",";
                    }
                    decimalpoint = true;
                    digit_only_input = true;
                }
                else
                {
                    input.Text += "";
                }
            }

            else
            {
                if (factorial == false && power == false)
                {
                    input.Text += button.Text;
                    valueinput = true;
                    digit_only_input = false;
                }
                else
                {
                    input.Text += "";
                }
            }
        }

        private void operation_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            decimalpoint = false;
            power = false;
            factorial = false;

            if (operation == false && digit_only_input == false && sqrt == false) 
            {
                operation = true;
                if (button.Name == "power_n")
                {
                    if (valueinput == true)
                    {
                        input.Text += "^";
                    }
                    else 
                    {
                        input.Text += "";
                    }
                }
                else if (button.Name == "log")
                {
                    input.Text += "log";
                }
                else
                {
                    input.Text = input.Text + " " + button.Text + " ";
                }
            }
            else
            {
                input.Text += "";
            }
            valueinput = false;
        }

        private void power2_click(object sender, EventArgs e)
        {
            if (power == false && digit_only_input == false && valueinput == true)
            {
                input.Text += "²";
                power = true;
                valueinput = false;
            }
            else 
            {
                input.Text += "";
            }
        }

        private void fact_click(object sender, EventArgs e)
        {
            if (factorial == false && digit_only_input == false && valueinput == true)
            {
                input.Text += "!";
                factorial = true;
                valueinput = false;
            }
            else
            {
                input.Text += "";
            }
        }

        private void sqrt_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            decimalpoint = false;

            if (sqrt == false && digit_only_input == false)
            {
                sqrt = true;
                if (button.Name == "sqrt2")
                {
                    if (valueinput == false && factorial == false && power == false)
                    {
                        input.Text += "√";
                        factorial = false;
                    }
                    else
                    {
                        input.Text += "";
                    }
                }
                else //sqrt_n
                {
                    if (valueinput == false && factorial == false && power == false)
                    {
                        input.Text += "2ˣ√";
                        factorial = false;
                        power = false;
                    }
                    else
                    {
                        input.Text += "ˣ√";
                        factorial = false;
                        power = false;
                    }
                }
            }
            else
            {
                input.Text += "";
            }
        }

        private void result_click(object sender, EventArgs e)
        {
            input.Text += " =";
        }
    }
}
