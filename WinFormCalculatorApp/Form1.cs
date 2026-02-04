using System.Runtime.CompilerServices;

namespace WinFormCalculatorApp
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void inputNumber(string c)
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

        private void n1_Click(object sender, EventArgs e)
        {
            inputNumber("1");
        }

        private void n2_Click(object sender, EventArgs e)
        {
            inputNumber("2");
        }

        private void n3_Click(object sender, EventArgs e)
        {
            inputNumber("3");
        }

        private void n4_Click(object sender, EventArgs e)
        {
            inputNumber("4");
        }

        private void n5_Click(object sender, EventArgs e)
        {
            inputNumber("5");
        }

        private void n6_Click(object sender, EventArgs e)
        {
            inputNumber("6");
        }

        private void n7_Click(object sender, EventArgs e)
        {
            inputNumber("7");
        }

        private void n8_Click(object sender, EventArgs e)
        {
            inputNumber("8");
        }

        private void n9_Click(object sender, EventArgs e)
        {
            inputNumber("9");
        }

        private void n0_Click(object sender, EventArgs e)
        {
            inputNumber("0");
        }

        private void KeyboardInput(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0)
            {
                inputNumber("0");
            }
            else if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
            {
                inputNumber("1");
            }
            else if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
            {
                inputNumber("2");
            }
            else if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
            {
                inputNumber("3");
            }
            else if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
            {
                inputNumber("4");
            }
            else if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
            {
                inputNumber("5");
            }
            else if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
            {
                inputNumber("6");
            }
            else if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
            {
                inputNumber("7");
            }
            else if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8)
            {
                inputNumber("8");
            }
            else if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
            {
                inputNumber("9");
            }
            else if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
            {
                inputNumber("9");
            }
            else if (e.KeyCode == Keys.Multiply || e.KeyCode == Keys.D9)
            {
                inputNumber("*");
            }
            else if (e.KeyCode == Keys.Add || e.KeyCode == Keys.Oemplus)
            {
                inputNumber("+");
            }
            else if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus)
            {
                inputNumber("-");
            }
            else if (e.KeyCode == Keys.Decimal || e.KeyCode == Keys.OemPeriod)
            {
                inputNumber(".");
            }
            else if (e.KeyCode == Keys.Divide)
            {
                inputNumber("/");
            }
        }

        private void SolveEquation(int inputNumber)
        {
            double firstNumber, secondNumber, result;
        }
    }
}
