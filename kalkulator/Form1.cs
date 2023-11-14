using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace kalkulator
{
    public partial class Calculator : Form
    {
        double value = 0;
        string operation = "";
        bool operation_pressed = false;
        bool btn_pressed = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (ResultBox.Text == "Nie dziel przez 0")
                ResultBox.Text = btn.Text;

            if (btn.Text == ",")
            {
                if (!ResultBox.Text.Contains(','))
                {
                    ResultBox.Text += btn.Text;
                }

                if (operation_pressed)
                {
                    ResultBox.Text = "0,";
                    operation_pressed = false;
                }
            }
            else
            {
                if (operation_pressed)
                {
                    ResultBox.Clear();
                    operation_pressed = false;
                }

                if (ResultBox.Text != "0")
                {
                    ResultBox.Text += btn.Text;
                }
                else
                {
                    if (btn.Text != "0")
                    {
                        ResultBox.Text = btn.Text;
                    }
                }
            }
        }

        private void ClearEntryBtn_Click(object sender, EventArgs e)
        {
            ResultBox.Text = "0";
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (value != 0 && !operation_pressed)
            {
                EqualBtn.PerformClick();
            }

            operation_pressed = true;

            operation = btn.Text;
            value = Double.Parse(ResultBox.Text);
            Display_Label.Text = $"{value} {operation}";
        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            Display_Label.Text = "";

            double parsedValue = Double.Parse(ResultBox.Text);
            switch (operation)
            {
                case "+":
                    ResultBox.Text = $"{value + parsedValue}";
                    break;
                case "-":
                    ResultBox.Text = $"{value - parsedValue}";
                    break;
                case "*":
                    ResultBox.Text = $"{value * parsedValue}";
                    break;
                case "%":
                    ResultBox.Text = $"{value % parsedValue}";
                    break;
                case "/":
                    {
                        if (parsedValue == 0)
                        {
                            ResultBox.Text = "Nie dziel przez 0";
                            break;
                        }
                        else
                        {
                            ResultBox.Text = $"{value / parsedValue}";
                            break;
                        }
                    }
            }

            if (double.TryParse(ResultBox.Text, out double x))
            {
                value = x;
            }
            operation = "";
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ResultBox.Text = "0";
            Display_Label.Text = "";
            value = 0;
        }

        private void PlusMinusBtn_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text != "0")
            {
                if (ResultBox.Text.Contains('-'))
                    ResultBox.Text = ResultBox.Text[1..];
                else
                    ResultBox.Text = $"-{ResultBox.Text}";
            }
        }

        private void BackSpaceBtn_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text.Length == 1)
            {
                ResultBox.Text = "0";
            }
            else
            {
                ResultBox.Text = ResultBox.Text.Substring(0, ResultBox.Text.Length - 1);
            }
        }
    }
}