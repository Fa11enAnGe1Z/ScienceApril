namespace Calculator
{
    public partial class Form1 : Form
    {
        string first, second, znak;
        bool operand2 = false;
        

        public Form1()
        {
            InitializeComponent();
        }


        // ������� Numbers
        // ��� ������ ��������� ���� � ���� ������, ���� �������� bool ���������� znakBool - false, ����� ��������
        // ������ �������, ����� ������ �������

        public void Numbers(string num)
        {
            tbAnswer.Text = "";
            if (keyPressZero <=1 && keyPressDot == 0)
            {
                tbAnswer.Text = "";
                if (operand2 == false)
                {
                    first += num;
                    tbAnswer.Text += first;
                }
                else
                {
                    second += num;
                    tbAnswer.Text += second;
                }
            }
            else if(keyPressZero > 1 && keyPressZero > 1)
            {
                if (operand2 == false)
                {
                    first += num;
                    tbAnswer.Text = first;
                }
                else
                {
                    second += num;
                    tbAnswer.Text = second;
                }
            }
        }

        public void OpStatus(char pol)
        {
            if (pol == '-')
            {
                btnSeparation.Enabled = false;   // �������
                btnDot.Enabled = false;          // �����
                btnBack.Enabled = false;         // �����
                btnMinus.Enabled = false;        // �����
                btnPlus.Enabled = false;         // ����
                btnMultiplication.Enabled = false;   // ���������
                btnReplace.Enabled = false;      // ����� �����
            }
            if (pol == '+')
            {
                btnSeparation.Enabled = true;   // �������
                btnDot.Enabled = true;          // �����
                btnBack.Enabled = true;         // �����
                btnMinus.Enabled = true;        // �����
                btnPlus.Enabled = true;         // ����
                btnMultiplication.Enabled = true;   // ���������
                btnReplace.Enabled = true;      // ����� �����
            }
        }


        // ������� Operation
        // ��� ��������� �������� bool ���������� znakBool �� true, ����� ������ 2 �������

        public void Operation(string zk)
        {
            operand2 = true;
            znak = zk;
            tbAnswer.Text = zk;
        }



        //-------------------------------------------------------------------------------------------------------------------------
        // �������� ����� � ���� ����� � ������� Numbers
        int keyPressZero = 0;
        private void numZero_Click(object sender, EventArgs e)
        {
            keyPressZero++;
            Numbers("0");
        }

        private void num1_Click(object sender, EventArgs e)
        {
            Numbers("1");
        }

        private void num2_Click(object sender, EventArgs e)
        {
            Numbers("2");
        }

        private void num3_Click(object sender, EventArgs e)
        {
            Numbers("3");
        }

        private void num4_Click(object sender, EventArgs e)
        {
            Numbers("4");
        }

        private void num5_Click(object sender, EventArgs e)
        {
            Numbers("5");
        }

        private void num6_Click(object sender, EventArgs e)
        {
            Numbers("6");
        }

        private void num7_Click(object sender, EventArgs e)
        {
            Numbers("7");
        }

        private void num8_Click(object sender, EventArgs e)
        {
            Numbers("8");
        }

        private void num9_Click(object sender, EventArgs e)
        {
            Numbers("9");
        }


        // ���� �������
        private void btnSeparation_Click(object sender, EventArgs e)
        {
            Operation("/");
        }

        // ���� ���������
        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            Operation("*");
        }

        // ���� �����
        private void btnMinus_Click(object sender, EventArgs e)
        {
            Operation("-");
        }

        // ���� ����
        private void btnPlus_Click(object sender, EventArgs e)
        {
            Operation("+");
        }

        //-------------------------------------------------------------------------------------------------------------------------



        // ���������� ��� ����������� ������
        double otvet = 0;

        double x = 0, y = 0;
        // ������� ���������
        int i = 0;
        // ���� ���������
        private void btnEqually_Click(object sender, EventArgs e)
        {
            if (i == 0)
                x = double.Parse(first);
            else
                x = otvet;
            y = double.Parse(second);
            switch (znak)
            {
                case "/":
                    {
                        otvet = x / y;
                        tbAnswer.Text = Convert.ToString(otvet);
                        i++;
                    }
                    break;

                case "*":
                    {
                        otvet = x * y;
                        tbAnswer.Text = Convert.ToString(otvet);
                        i++;
                    }
                    break;

                case "-":
                    {
                        otvet = x - y;
                        tbAnswer.Text = Convert.ToString(otvet);
                        i++;
                    }
                    break;

                case "+":
                    {
                        otvet = x + y;
                        tbAnswer.Text = Convert.ToString(otvet);
                        i++;
                    }
                    break;
                default:
                    break;
            }



            quanZnak = 0;
            first = "";
            second = "";
        }

        int quanZnak = 0;
        // ��� ������� TextBox ��������� ������ �� ��
        private void tbAnswer_TextChanged(object sender, EventArgs e)
        {
            // ���� �� ������ - ����� ��������������
            if (tbAnswer.Text.Length > 0 && quanZnak == 0)
            {
                quanZnak++;
                OpStatus('+');
            }
        }


        // ������ �
        private void btnClear_Click(object sender, EventArgs e)
        {
            i = 0;
            tbAnswer.Text = "";
            otvet = 0;
            first = "";
            second = "";
            x = 0;
            y = 0;
        }


        int keyPressDot = 0;
        private void btnDot_Click(object sender, EventArgs e)
        {
            keyPressDot++;
            Numbers(",");
            btnDot.Enabled = false;
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                if (first == "0")
                {
                    first = Convert.ToString(double.Parse(first) * -1.0);
                    tbAnswer.Text = first;
                }
            }

            else
            {
                if(otvet == 0)
                {
                    otvet = otvet * -1.0;
                    tbAnswer.Text = Convert.ToString(otvet);
                }

            }

        }
    }
}
