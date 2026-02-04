using System.Diagnostics.Eventing.Reader;

namespace WinFormCalculatorApp
{
    public partial class Form1 : Form
    {
        double firstNumber, secondNumber, result;
        string operation = " ", charge = " ";

        public Form1()
        {
            InitializeComponent();
        }

        private void InputNumber(string c)
        {
            if (textBoxCalculation.Text == "0" && textBoxCalculation.Text != null)
            {
                textBoxCalculation.Text = c;
            }
            else
            {
                textBoxCalculation.Text = textBoxCalculation.Text + c;
            }
        }

        private void N1_Click(object sender, EventArgs e)
        {
            InputNumber("1");
        }

        private void N2_Click(object sender, EventArgs e)
        {
            InputNumber("2");
        }

        private void N3_Click(object sender, EventArgs e)
        {
            InputNumber("3");
        }

        private void N4_Click(object sender, EventArgs e)
        {
            InputNumber("4");
        }

        private void N5_Click(object sender, EventArgs e)
        {
            InputNumber("5");
        }

        private void N6_Click(object sender, EventArgs e)
        {
            InputNumber("6");
        }

        private void N7_Click(object sender, EventArgs e)
        {
            InputNumber("7");
        }

        private void N8_Click(object sender, EventArgs e)
        {
            InputNumber("8");
        }

        private void N9_Click(object sender, EventArgs e)
        {
            InputNumber("9");
        }

        private void N0_Click(object sender, EventArgs e)
        {
            InputNumber("0");
        }

        private void Decimal_Click(object sender, EventArgs e)
        {
            InputNumber(".");
        }

        private void Mult_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBoxCalculation.Text);
            textBoxCalculation.Text = "0";
            operation = "*";
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBoxCalculation.Text);
            textBoxCalculation.Text = "0";
            operation = "/";
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBoxCalculation.Text);
            textBoxCalculation.Text = "0";
            operation = "-";
        }

        private void Add_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBoxCalculation.Text);
            textBoxCalculation.Text = "0";
            operation = "+";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            firstNumber = 0;
            secondNumber = 0;
            result = 0;
            operation = " ";
            textBoxCalculation.Text = "0";
        }

        private void PosNeg_Click(object sender, EventArgs e)
        {
            if (textBoxCalculation.Text != "0")
            {
                if (textBoxCalculation.Text.StartsWith('-'))
                {
                    charge = textBoxCalculation.Text;
                    textBoxCalculation.Text = charge[1..];
                }
                else
                {
                    textBoxCalculation.Text = "-" + textBoxCalculation.Text;
                }
            }
            else;
            
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            secondNumber = Convert.ToDouble(textBoxCalculation.Text);


            if (operation == "+")
            {
                result = (firstNumber + secondNumber);
                textBoxCalculation.Text = Convert.ToString(result);
                firstNumber = result;
                operation = " ";
            }
            if (operation == "-")
            {
                result = (firstNumber - secondNumber);
                textBoxCalculation.Text = Convert.ToString(result);
                firstNumber = result;
                operation = " ";
            }
            if (operation == "*")
            {
                result = (firstNumber * secondNumber);
                textBoxCalculation.Text = Convert.ToString(result);
                firstNumber = result;
                operation = " ";
            }
            if (operation == "/")
            {
                if (secondNumber == 0)
                {
                    MessageBox.Show("ERROR: Cannot divide by zero", "ERROR");
                }
                else
                {
                    result = (firstNumber / secondNumber);
                    textBoxCalculation.Text = Convert.ToString(result);
                    firstNumber = result;
                    operation = " ";
                }
            }

        }

        private void KeyboardInput(object sender, KeyEventArgs e)
        {

            if (e.KeyCode != Keys.NumPad0 && e.KeyCode != Keys.D0)
            {
                if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
                {
                    InputNumber("1");
                }
                else if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
                {
                    InputNumber("2");
                }
                else if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
                {
                    InputNumber("3");
                }
                else if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
                {
                    InputNumber("4");
                }
                else if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
                {
                    InputNumber("5");
                }
                else if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
                {
                    InputNumber("6");
                }
                else if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
                {
                    InputNumber("7");
                }
                else if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8)
                {
                    InputNumber("8");
                }
                else if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
                {
                    InputNumber("9");
                }
                else if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
                {
                    InputNumber("9");
                }
                else if (e.KeyCode == Keys.Multiply || e.KeyCode == Keys.D9)
                {
                    InputNumber("*");
                }
                else if (e.KeyCode == Keys.Add || e.KeyCode == Keys.Oemplus)
                {
                    InputNumber("+");
                }
                else if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus)
                {
                    InputNumber("-");
                }
                else if (e.KeyCode == Keys.Decimal || e.KeyCode == Keys.OemPeriod)
                {
                    InputNumber(".");
                }
                else if (e.KeyCode == Keys.Divide)
                {
                    InputNumber("/");
                }
            }
            else
            {
                InputNumber("0");
            }
        }
    }
}
