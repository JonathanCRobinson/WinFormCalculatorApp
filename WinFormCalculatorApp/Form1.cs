using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

namespace WinFormCalculatorApp
{
    public partial class Form1 : Form
    {
        double firstNumber, secondNumber, result;
        string operation = "", sign = "";

        public Form1()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // 
            // NUMBER KEYS
            // 

            // Numpad numbers (0-9)
            if (keyData >= Keys.NumPad0 && keyData <= Keys.NumPad9)
            {
                int num = keyData - Keys.NumPad0;      // Convert Keys.NumPadX to integer
                InputNumber(num.ToString());           // Append the number to display
                return true;                           // Handled
            }

            // Top row numbers (0-9)
            if (keyData >= Keys.D0 && keyData <= Keys.D9)
            {
                int num = keyData - Keys.D0;          // Convert Keys.DX to integer
                InputNumber(num.ToString());          // Append the number to display
                return true;
            }

            // 
            // OPERATOR KEYS
            // 

            switch (keyData)
            {
                // ADDITION
                case Keys.Add:            // Numpad '+'
                case Keys.Oemplus:        // Top row '+'
                    Add_Click(buttonAdd, EventArgs.Empty);
                    return true;

                // SUBTRACTION
                case Keys.Subtract:       // Numpad '-'
                case Keys.OemMinus:       // Top row '-'
                    Sub_Click(buttonSub, EventArgs.Empty);
                    return true;

                // MULTIPLICATION
                case Keys.Multiply:       // Numpad '*'
                    Mult_Click(buttonMult, EventArgs.Empty);
                    return true;

                // DIVISION
                case Keys.Divide:         // Numpad '/'
                    Divide_Click(buttonDivide, EventArgs.Empty);
                    return true;

                // DECIMAL POINT
                case Keys.Decimal:        // Numpad '.'
                case Keys.OemPeriod:      // Top row '.'
                    Decimal_Click(buttonDecimal, EventArgs.Empty);
                    return true;

                // 
                // SPECIAL KEYS
                // 

                // ENTER key (main Enter or Numpad Enter)
                case Keys.Enter:
                    buttonEnter.PerformClick();  // Trigger calculation
                    return true;

                // ESCAPE key
                case Keys.Escape:
                    buttonClear.PerformClick();  // Clear everything
                    return true;

                // BACKSPACE key
                case Keys.Back:
                    if (textBoxCalculation.Text.Length > 0)
                        textBoxCalculation.Text = textBoxCalculation.Text[..^1];  // Remove last character
                    return true;
            }

            // 
            // CATCH ALL
            // 
            // For any other keys, let the base form handle them
            return base.ProcessCmdKey(ref msg, keyData);
        }

        // Function for inputing numbers as a string value based off button selection
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

        private void Number_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;    // Get the button that is clicked
            InputNumber(btn.Text);          // Use the Text property as the value
        }
        
        private void Decimal_Click(object sender, EventArgs e)
        {
            InputNumber(".");
        }
        
        // Function to set the firstNumber variable for the equation then reset the textBox to the number 0
        private void InputOperator(string o)
        {
            firstNumber = Convert.ToDouble(textBoxCalculation.Text);
            textBoxCalculation.Text = "0";
            operation = o;
        }

        private void Mult_Click(object sender, EventArgs e)
        {
            InputOperator("*");
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            InputOperator("/");
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            InputOperator("-");
        }

        private void Add_Click(object sender, EventArgs e)
        {
            InputOperator("+");
        }

        // Clears all the data stored in variables and sets textBox to display zero
        private void Clear_Click(object sender, EventArgs e)
        {
            firstNumber = 0;
            secondNumber = 0;
            result = 0;
            operation = "";
            textBoxCalculation.Text = "";

            this.ActiveControl = null; // keeps keyboard working

        }

        // Function to check the textBox for any number that isn't zero then change the sign to positive or negative
        private void PosNeg_Click(object sender, EventArgs e)
        {
            if (textBoxCalculation.Text != "0")
            {
                if (textBoxCalculation.Text.StartsWith('-'))
                {
                    sign = textBoxCalculation.Text;
                    textBoxCalculation.Text = sign[1..];    //removes the first character from the string
                }
                else
                {
                    textBoxCalculation.Text = "-" + textBoxCalculation.Text;
                }
            }
            
        }

        // Function to solve the equation from user input >>>!!!! Clean Up later !!!!<<<
        private void Equal_Click(object sender, EventArgs e)
        {
            secondNumber = Convert.ToDouble(textBoxCalculation.Text);

            if (operation == "+")
            {
                result = (firstNumber + secondNumber);
            }
            if (operation == "-")
            {
                result = (firstNumber - secondNumber);
            }
            if (operation == "*")
            {
                result = (firstNumber * secondNumber);
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
                }
            }

            textBoxCalculation.Text = Convert.ToString(result);
            firstNumber = result;
            operation = " ";
        }
    }
}
