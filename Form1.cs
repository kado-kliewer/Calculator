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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private Value1 value1;
        private ButtonClicks buttons;
        private Value2 value2;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            buttons = new ButtonClicks();
            value1 = new Value1(double.NaN);
            value2 = new Value2(double.NaN);
            this.KeyPress += Form1_KeyPress;
            this.KeyUp += Form1_KeyUp;
            this.AcceptButton = button12;
            button1.TabStop = false;
            button2.TabStop = false;
            button3.TabStop = false;
            button4.TabStop = false;
            button5.TabStop = false;
            button6.TabStop = false;
            button7.TabStop = false;
            button8.TabStop = false;
            button9.TabStop = false;
            button10.TabStop = false;
            button11.TabStop = false;
            button12.TabStop = false;
            plusButton.TabStop = false;
            minusButton.TabStop = false;
            multiplyButton.TabStop = false;
            divideButton.TabStop = false;
            clearButton.TabStop = false;
            clearEntry.TabStop = false;
        }

        private void Form1_KeyPress1(object sender, KeyPressEventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///  Checks to see if the label is empty
        /// </summary>
        private bool ValueCheck()
        {
            var t = false;
            if (displayValue.Text == string.Empty)
            {
                t = true;
            }

            return t;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // These buttons are just adding the numbers to the label
        private void button1_Click(object sender, EventArgs e)
        {
            displayValue.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            displayValue.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            displayValue.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            displayValue.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            displayValue.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            displayValue.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            displayValue.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            displayValue.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            displayValue.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            displayValue.Text += ".";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            displayValue.Text += "0";
        }

        // Operator logic
        private void plusButton_Click(object sender, EventArgs e)
        {
            var isNull = ValueCheck();

            if(isNull)
            {
                MessageBox.Show("Please enter a number");
            } 
            else
            {
                value1.Value = Convert.ToDouble(displayValue.Text);
                buttons.IsAddition = true;
                displayValue.Text = string.Empty;
                buttons.Check();
            }
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            var isNull = ValueCheck();

            if (isNull)
            {
                MessageBox.Show("Please enter a number");
            }
            else
            {
                value1.Value = Convert.ToDouble(displayValue.Text);
                buttons.IsSubtraction = true;
                displayValue.Text = string.Empty;
                buttons.Check();
            }
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            var isNull = ValueCheck();

            if (isNull)
            {
                MessageBox.Show("Please enter a number");
            }
            else
            {
                buttons.IsMultiplication = true;
                value1.Value = Convert.ToDouble(displayValue.Text);
                displayValue.Text = string.Empty;
                buttons.Check();
            }
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            var isNull = ValueCheck();

            if (isNull)
            {
                MessageBox.Show("Please enter a number");
            }
            else
            {
                value1.Value = Convert.ToDouble(displayValue.Text);
                buttons.IsDivision = true;
                displayValue.Text = string.Empty;
                buttons.Check();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                var isNull = ValueCheck();

                if (isNull)
                {
                    throw new Exception("Secondary value was not provided");
                }

                value2.Value = Convert.ToDouble(displayValue.Text);

                if (value2.Value == double.NaN)
                {
                    throw new Exception("Secondary value was not provided");
                }

                double value = double.NaN;

                if (value1.Value == double.NaN)
                {
                    throw new Exception("No inital value was provided");
                }
                else
                {
                    if ((bool)buttons.IsSubtraction)
                    {
                        value = value1.Value - value2.Value;
                    }
                    else if ((bool)buttons.IsMultiplication)
                    {
                        value = value1.Value * value2.Value;
                    }
                    else if ((bool)buttons.IsDivision)
                    {
                        value = value1.Value / value2.Value;
                    }
                    else if ((bool)buttons.IsAddition)
                    {
                        value = value1.Value + value2.Value;
                    }

                    value1.Value = value;
                    displayValue.Text = value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // For keybinding
        // Reference: https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.keys?view=windowsdesktop-8.0
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"KeyCode: {e.KeyCode}, KeyValue: {e.KeyValue}");

            if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                button12_Click(sender, e);
            }
            else if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
            {
                displayValue.Text += "1";
            }
            else if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
            {
                displayValue.Text += "2";
            }
            else if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
            {
                displayValue.Text += "3";
            }
            else if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
            {
                displayValue.Text += "4";
            }
            else if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
            {
                displayValue.Text += "5";
            }
            else if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
            {
                displayValue.Text += "6";
            }
            else if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
            {
                displayValue.Text += "7";
            }
            else if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8)
            {
                displayValue.Text += "8";
            }
            else if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
            {
                displayValue.Text += "9";
            }
            else if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0)
            {
                displayValue.Text += "0";
            }
            else if (e.KeyCode == Keys.Add)
            {
                plusButton_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Subtract)
            {
                minusButton_Click(sender, e);
            }
            else if(e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                var length = displayValue.Text.Length;
                if (length > 0)
                {
                    displayValue.Text = displayValue.Text.Substring(0, length - 1);
                }
            }
            else if(e.KeyCode == Keys.M)
            {
                var text = displayValue.Text;
                var newText = "-" + text;

                displayValue.Text = newText;
            }
            else if(e.KeyCode == Keys.C)
            {
                clearButton_Click(sender, e);
            }
            else if(e.KeyCode == Keys.Z)
            {
                clearEntry_Click(sender, e);
            }
        }

        // Clearing and function logic
        private void clearButton_Click(object sender, EventArgs e)
        {
            value1.Value = double.NaN;
            value2.Value = double.NaN;
            displayValue.Text = string.Empty;
        }

        private void clearEntry_Click(object sender, EventArgs e)
        {
            if (value2.Value != double.NaN)
            {
                value2.Value = double.NaN;
                displayValue.Text = value1.Value.ToString();
            }
        }

        // Tracking to see if the key has been handled
        private bool _isAsteriskHandled = false;
        private bool _IsDivideHandled = false;

        // Reference: https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.keypresseventargs.keychar?view=windowsdesktop-8.0
        // Refetence: https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.keys?view=windowsdesktop-8.0
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '*' && !_isAsteriskHandled)
            {
                _isAsteriskHandled = true;
                multiplyButton_Click(sender, e);
                e.Handled = true;
            }

            if(e.KeyChar == '/' && !_IsDivideHandled)
            {
                _IsDivideHandled = true;
                divideButton_Click(sender, e);
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Shift || e.KeyCode == Keys.D8)
            {
                _isAsteriskHandled = false;
            }

            if(e.KeyCode == Keys.Shift || e.KeyCode == Keys.OemQuestion)
            {
                _IsDivideHandled = false;
            }
        }

        private Form2 form2;
        private void keyBindsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            form2.Show();
        }
    }
}
