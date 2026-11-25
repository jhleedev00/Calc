namespace Calculation
{
    public partial class Form1 : Form
    {
        private bool bbtnDotClick = false;

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
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            LabelPrint("2");

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            LabelPrint("3");

        }
        private void btn4_Click(object sender, EventArgs e)
        {
            LabelPrint("4");

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            LabelPrint("5");

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            LabelPrint("6");

        }
        private void btn7_Click(object sender, EventArgs e)
        {
            LabelPrint("7");

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            LabelPrint("8");

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            LabelPrint("9");

        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            LabelPrint("0");

        }

        private void btnSign_Click(object sender, EventArgs e)
        {

        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            bbtnDotClick = true;
            LabelPrint(".");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            calcResult.Text += " + ";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            calcResult.Text += " - ";

        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            calcResult.Text += " × ";

        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            calcResult.Text += " ÷ ";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
        }
        public void LabelPrint(string text)
        {
            if (calcResult.Text.IndexOf(".") == -1)
            {
                if (calcResult.Text.IndexOf("0") == 0)
                {
                    calcResult.Text = "";

                }
                if(bbtnDotClick == true)
                {
                    bbtnDotClick = false;
                    return;
                }
                calcResult.Text += text;
            }
            else if (bbtnDotClick == true)
            {
                bbtnDotClick = false;
                return;
            }
            else
            {
                calcResult.Text += text;
            }
        }
    }
}
