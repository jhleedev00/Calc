using System.Buffers;
using System.Reflection.Emit;

namespace Calculation
{
    public partial class Form1 : Form
    {
        private string Operator = "";
        private string Operand1 = "";
        private string Operand2 = "";
        private double CalcResult = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnThree_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            calcResult.Text = "0";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if(calcResult.Text.IndexOf(".") == -1)
            {
                if(calcResult.Text != "")
                {
                    calcResult.Text += ".";
                    return;
                }

            }
            return;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (Operand1 != "" && Operator != "")
            {
                Operand2 = calcResult.Text;
                CalcResult = Calculation(Operator);
                calcResult.Text = CalcResult.ToString();
                Operand1 = calcResult.Text;
                Operator = "+";
                return;
            }
            Operand1 = calcResult.Text;
            Operator = "+";
            calcResult.Text = "0";
            return;

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (Operand1 != "" && Operator != "")
            {
                Operand2 = calcResult.Text;
                CalcResult = Calculation(Operator);
                calcResult.Text = CalcResult.ToString();
                Operand1 = calcResult.Text;
                Operator = "-";
                return;
            }
            Operand1 = calcResult.Text;
            Operator = "-";
            calcResult.Text = "0";
            return;
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (Operand1 != "" && Operator != "")
            {
                Operand2 = calcResult.Text;
                CalcResult = Calculation(Operator);
                calcResult.Text = CalcResult.ToString();
                Operand1 = calcResult.Text;
                Operator = "*";
                return;
            }
            Operand1 = calcResult.Text;
            Operator = "*";
            calcResult.Text = "0";
            return;
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (Operand1 != "" && Operator != "")
            {
                Operand2 = calcResult.Text;
                CalcResult = Calculation(Operator);
                calcResult.Text = CalcResult.ToString();
                Operand1 = calcResult.Text;
                Operator = "/";
                return;
            }
            Operand1 = calcResult.Text;
            Operator = "/";
            calcResult.Text = "0";
            return;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(Operator != "") { return; }
            if (calcResult.Text.Length == 1) { calcResult.Text = "0"; return; }

            calcResult.Text = calcResult.Text.Remove(calcResult.Text.Length - 1);
        }


        public void LabelPrint(string text)
        {
            if ((calcResult.Text.IndexOf("0") == 0) && (calcResult.Text.IndexOf(".") == -1))
            {
                calcResult.Text = "";
                calcResult.Text += text;
                return;
            }
            else { calcResult.Text += text; return; }

            /*
             * 연산결과가 있을 때에 대한 예외처리 필요
             */
        }
        public double Calculation(string op)
        {
            double result = 0;
            switch (op)
            {
                case "+":
                    result = double.Parse(Operand1) + double.Parse(Operand2);
                    break;
                case "-":
                    result = double.Parse(Operand1) - double.Parse(Operand2);
                    break;
                case "*":
                    result = double.Parse(Operand1) * double.Parse(Operand2);
                    break;
                case "/":
                    result = double.Parse(Operand1) / double.Parse(Operand2);
                    break;
            }
            return result;

        }
    }
}
