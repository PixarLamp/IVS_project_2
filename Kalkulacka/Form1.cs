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
        public bool result = false;

        public string screen = "";
        public string[] parts;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if(result == true){
                input.Text = "";
                screen = "";
                result = false;
            }

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
                        screen += "0.";
                    }
                    else
                    {
                        input.Text += ",";
                        screen += ",";
                    }
                    decimalpoint = true;
                    digit_only_input = true;
                }
                else
                {
                    input.Text += "";
                    screen += "";
                }
            }

            else
            {
                if (factorial == false && power == false)
                {
                    input.Text += button.Text;
                    screen += button.Text;
                    valueinput = true;
                    digit_only_input = false;
                }
                else
                {
                    input.Text += "";
                    screen += "";
                }
            }
        }

        private void operation_click(object sender, EventArgs e)
        {

            if(result == true){
                input.Text = "";
                screen = "";
                result = false;
            }

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
                        screen += "^";
                    }
                    else 
                    {
                        input.Text += "";
                        screen += "";
                    }
                }
                else if (button.Name == "log")
                {
                    input.Text += "log";
                    screen += "log";
                }
                else
                {
                    input.Text = input.Text + " " + button.Text + " ";
                    screen = screen + " " + button.Text + " ";
                }
            }
            else
            {
                input.Text += "";
                screen += "";
            }
            valueinput = false;
        }

        private void power2_click(object sender, EventArgs e)
        {
            if(result == true){
                input.Text = "";
                screen = "";
                result = false;
            }

            if (power == false && digit_only_input == false && valueinput == true)
            {
                input.Text += "²";
                screen += "^2";
                power = true;
                valueinput = false;
            }
            else 
            {
                input.Text += "";
                screen += "";
            }
        }

        private void fact_click(object sender, EventArgs e)
        {

            if(result == true){
                input.Text = "";
                screen = "";
                result = false;
            }

            if (factorial == false && digit_only_input == false && valueinput == true)
            {
                input.Text += "!";
                screen += "!";
                factorial = true;
                valueinput = false;
            }
            else
            {
                input.Text += "";
                screen += "";
            }
        }

        private void sqrt_click(object sender, EventArgs e)
        {
            if(result == true){
                input.Text = "";
                screen = "";
                result = false;
            }

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
                        screen += "2-/";
                        factorial = false;
                    }
                    else
                    {
                        input.Text += "";
                        screen += "";
                    }
                }
                else //sqrt_n
                {
                    if (valueinput == false && factorial == false && power == false)
                    {
                        input.Text += "2ˣ√";
                        screen += "2-/";
                        factorial = false;
                        power = false;
                    }
                    else
                    {
                        input.Text += "ˣ√";
                        screen += "-/";
                        factorial = false;
                        power = false;
                    }
                }
            }
            else
            {
                input.Text += "";
                screen += "";
            }
        }

        private void result_click(object sender, EventArgs e)
        {
            if(screen != ""){
                input.Text = screen;

                int indexer = screen.IndexOf(" ");
                if(indexer == 0){
                    input.Text = "Syntax Error!";
                    result = true;
                    return;

                }

                string [] splitter = screen.Split(' ');
                calcB.calcmain mycalc = new calcB.calcmain();
                input.Text = mycalc.getResult(splitter).ToString();

                if(input.Text == "-123456789,54321"){
                    input.Text = "Syntax Error!";
                }
                else{
                    if(input.Text == "-123456789,98765"){
                        input.Text = "Infinity";
                    }
                }
                result = true;
                decimalpoint = false;
                digit_only_input = false;
                valueinput = false;
                operation = false;
                power = false;
                sqrt = false;
                factorial = false;
                result = false;
            }
            
            //input.Text += " =";
        }

        private void CE_click(object sender, EventArgs e)
        {
            input.Clear();

            decimalpoint = false;
            digit_only_input = false;
            valueinput = false;
            operation = false;
            power = false;
            sqrt = false;
            factorial = false;
            result = false;

            screen = "";
        }
    }
}