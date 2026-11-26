using System.Buffers;
using System.Reflection.Emit;

namespace Calculation
{
    public partial class Form1 : Form
    {
        private string Operator = "";
        private string Operand1 = "";
        private string Operand2 = "";
        private decimal CalcResult = 0;
        private bool bCalcReset = false;
        private bool bEqualPressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            NormalizeDisplayNumber();

            if (Operator == "")
            {
                bCalcReset = true;
                bEqualPressed = true;
                return;
            }

            if (!bEqualPressed)
            {
                Operand2 = calcResult.Text;
            }

            string prevOperand1 = Operand1;
            CalcResult = Calculation(Operator);
            calcResult.Text = CalcResult.ToString();
            operatingPrintLabel.Text = $"{prevOperand1} {Operator} {Operand2} =";
            Operand1 = calcResult.Text;
            bEqualPressed = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            calcResult.Text = "0";

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            LabelPrint("1");
            return;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            LabelPrint("2");
            return;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            LabelPrint("3");
            return;
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            LabelPrint("4");
            return;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            LabelPrint("5");
            return;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            LabelPrint("6");
            return;
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            LabelPrint("7");
            return;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            LabelPrint("8");
            return;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            LabelPrint("9");
            return;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            LabelPrint("0");
            return;
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            calcResult.Text = (decimal.Parse(calcResult.Text) * -1).ToString();
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (calcResult.Text.IndexOf(".") == -1)
            {
                if (calcResult.Text != "")
                {
                    calcResult.Text += ".";
                    return;
                }

            }
            return;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            OperatorClick("+");
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            OperatorClick("-");
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            OperatorClick("×");
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            OperatorClick("÷");
        }
        private void btnPercent_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(calcResult.Text, out decimal currentValue))
            {
                return;
            }

            decimal percentResult;
            switch (Operator)
            {
                case "+":
                case "-":
                    if (!decimal.TryParse(Operand1, out decimal baseValue))
                    {
                        return;
                    }
                    percentResult = baseValue * (currentValue / 100.0m);
                    break;

                case "×":
                case "÷":
                    percentResult = currentValue / 100.0m;
                    break;

                default:
                    percentResult = 0.0m;
                    break;
            }

            Operand2 = percentResult.ToString();
            calcResult.Text = Operand2;
            bCalcReset = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (calcResult.Text.Length == 1) { calcResult.Text = "0"; return; }

            calcResult.Text = calcResult.Text.Remove(calcResult.Text.Length - 1);
        }

        public void LabelPrint(string text)
        {
            if (bEqualPressed)
            {
                Operator = "";
                Operand1 = "";
                Operand2 = "";
                bEqualPressed = false;
                operatingPrintLabel.Text = "";
            }

            if (bCalcReset == true)
            {
                calcResult.Text = "";
                bCalcReset = false;
            }

            if ((calcResult.Text.IndexOf("0") == 0) && (calcResult.Text.IndexOf(".") == -1))
            {
                calcResult.Text = "";
                calcResult.Text += text;
                return;
            }
            else { calcResult.Text += text; return; }
        }

        public decimal Calculation(string op)
        {
            decimal result = 0;
            switch (op)
            {
                case "+":
                    result = decimal.Parse(Operand1) + decimal.Parse(Operand2);
                    bCalcReset = true;
                    break;
                case "-":
                    result = decimal.Parse(Operand1) - decimal.Parse(Operand2);
                    bCalcReset = true;
                    break;
                case "×":
                    result = decimal.Parse(Operand1) * decimal.Parse(Operand2);
                    bCalcReset = true;
                    break;
                case "÷":
                    result = decimal.Parse(Operand1) / decimal.Parse(Operand2);
                    bCalcReset = true;
                    break;
            }
            return result;
        }
        private void NormalizeDisplayNumber()
        {
            if (decimal.TryParse(calcResult.Text, out decimal parsedValue))
            {
                calcResult.Text = parsedValue.ToString();
            }
        }

        public void OperatorClick(string op)
        {
            NormalizeDisplayNumber();

            if (bEqualPressed)
            {
                Operand1 = calcResult.Text;
                Operator = op;
                bEqualPressed = false;
                bCalcReset = true;
                operatingPrintLabel.Text = $"{Operand1} {Operator}";
                return;
            }

            if (Operand1 != "" && Operator != "")
            {
                if (bCalcReset)
                {
                    Operator = op;
                    operatingPrintLabel.Text = $"{Operand1} {Operator}";
                    return;
                }

                Operand2 = calcResult.Text;
                CalcResult = Calculation(Operator);
                calcResult.Text = CalcResult.ToString();
                Operand1 = calcResult.Text;
                Operator = op;
                operatingPrintLabel.Text = $"{Operand1} {Operator}";
                return;
            }
            Operand1 = calcResult.Text;
            Operator = op;
            calcResult.Text = calcResult.Text;
            bCalcReset = true;
            operatingPrintLabel.Text = $"{Operand1} {Operator}";
            return;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            calcResult.Text = "0";
            Operator = "";
            Operand1 = "";
            Operand2 = "";
            CalcResult = 0;
            bCalcReset = false;
            bEqualPressed = false;
            operatingPrintLabel.Text = "";
        }

        private void btnCrearEntry_Click(object sender, EventArgs e)
        {
            calcResult.Text = "0";
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData & (Keys.Control | Keys.Alt)) != 0)
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }

            Keys keyCode = keyData & Keys.KeyCode;
            bool shift = (keyData & Keys.Shift) != 0;

            if (!shift && keyCode >= Keys.D0 && keyCode <= Keys.D9)
            {
                LabelPrint((keyCode - Keys.D0).ToString());
                return true;
            }

            if (keyCode >= Keys.NumPad0 && keyCode <= Keys.NumPad9)
            {
                LabelPrint((keyCode - Keys.NumPad0).ToString());
                return true;
            }

            switch (keyCode)
            {
                case Keys.OemPeriod when !shift:
                case Keys.Decimal:
                    btnDot_Click(this, EventArgs.Empty);
                    return true;

                case Keys.Add:
                case Keys.Oemplus when shift:
                    OperatorClick("+");
                    return true;

                case Keys.Subtract:
                case Keys.OemMinus when !shift:
                    OperatorClick("-");
                    return true;

                case Keys.Multiply:
                case Keys.D8 when shift:
                    OperatorClick("×");
                    return true;

                case Keys.Divide:
                case Keys.OemQuestion when !shift:
                    OperatorClick("÷");
                    return true;

                case Keys.D5 when shift:
                    btnPercent_Click(this, EventArgs.Empty);
                    return true;

                case Keys.Enter:
                case Keys.Oemplus when !shift:
                    btnEqual_Click(this, EventArgs.Empty);
                    return true;

                case Keys.Back:
                    btnDelete_Click(this, EventArgs.Empty);
                    return true;

                case Keys.Escape:
                    btnClear_Click(this, EventArgs.Empty);
                    return true;

                case Keys.Delete:
                    btnCrearEntry_Click(this, EventArgs.Empty);
                    return true;

                case Keys.F9 when !shift:
                    btnSign_Click(this, EventArgs.Empty);
                    return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
