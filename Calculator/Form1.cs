namespace Calculator
{
    public partial class Form1 : Form
    {
        string first="0", second, znak;
        bool firstNumber = false;
        bool statusZnak = false;
        bool operand2 = false;
        bool era = false;
        

        public Form1()
        {
            InitializeComponent();
        }


        // Функция Numbers
        // Для записи введенных цифр в виде строки, если значение bool переменной znakBool - false, тогда вводится
        // первый операнд, иначе второй операнд

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





            /*
                        if (era == true)
                        {
                            tbAnswer.Text = "";
                            era = false;
                        }

                        if (znakBool == false)
                        {
                            y = y + num;
                        }
                        else
                        {
                            z = z + num;
                        }
                        btnRoot.Enabled = true;
                        tbAnswer.Text += num;
            */
        }

        public void OpStatus(char pol)
        {
            if (pol == '-')
            {
                btnSeparation.Enabled = false;   // Деление
                btnDot.Enabled = false;          // Точка
                btnBack.Enabled = false;         // Назад
                btnMinus.Enabled = false;        // Минус
                btnPlus.Enabled = false;         // Плюс
                btnMultiplication.Enabled = false;   // Умножение
                btnRoot.Enabled = false;         // Корень
                btnReplace.Enabled = false;      // Смена знака
            }
            if (pol == '+')
            {
                btnSeparation.Enabled = true;   // Деление
                btnDot.Enabled = true;          // Точка
                btnBack.Enabled = true;         // Назад
                btnMinus.Enabled = true;        // Минус
                btnPlus.Enabled = true;         // Плюс
                btnMultiplication.Enabled = true;   // Умножение
                btnRoot.Enabled = true;         // Корень
                btnReplace.Enabled = true;      // Смена знака
            }
        }


        // Функция Operation
        // Для изменения значения bool переменной znakBool на true, чтобы ввести 2 операнд

        public void Operation(string zk)
        {
           // if()




            operand2 = true;
            znak = zk;
            tbAnswer.Text = zk;


            /*
                        OpStatus('-');
                        btnBack.Enabled = true;         // Назад
            */
        }



        //-------------------------------------------------------------------------------------------------------------------------
        // Передаем цифры в виде строк в функцию Numbers
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


        // Знак деления
        private void btnSeparation_Click(object sender, EventArgs e)
        {
            Operation("/");
        }

        // Знак умножения
        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            Operation("*");
        }

        // Знак минус
        private void btnMinus_Click(object sender, EventArgs e)
        {
            Operation("-");
        }

        // Знак плюс
        private void btnPlus_Click(object sender, EventArgs e)
        {
            Operation("+");
        }

        //-------------------------------------------------------------------------------------------------------------------------



        // Переменная для запоминания ответа
        double otvet = 0;

        double x = 0, y = 0;
        // Счетчик выражений
        int i = 0;
        // Знак равенства
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




            statusZnak = false;
            quanZnak = 0;
            era = true;
            first = "";
            second = "";
        }

        int quanZnak = 0;
        // При измении TextBox проверяет пустой ли он
        private void tbAnswer_TextChanged(object sender, EventArgs e)
        {
            // Если не пустой - знаки разблокируются
            if (tbAnswer.Text.Length > 0 && quanZnak == 0)
            {
                quanZnak++;
                OpStatus('+');
            }
        }


        // Кнопка С
        private void btnClear_Click(object sender, EventArgs e)
        {
            i = 0;
            tbAnswer.Text = "";
            otvet = 0;
            first = "";
            second = "";
            x = 0;
            y = 0;




            /*
                        otvet = 0;
                        first = "";
                        second = "";
                        tbAnswer.Text = "";

                        statusZnak = false;
                        OpStatus('-');
                        btnBack.Enabled = true;         // Назад
            */
        }


        int keyPressDot = 0;
        private void btnDot_Click(object sender, EventArgs e)
        {
            keyPressDot++;
            Numbers(",");
            btnDot.Enabled = false;
        }

        private void btnRoot_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                double otvetfirst = 0;
                otvetfirst = double.Parse(first);
                if (otvetfirst == 0)
                {
                    tbAnswer.Text = "Введите число!";
                    Task.Delay(50);
                    tbAnswer.Text = "";

                }
                else
                {
                    Task.Delay(50);
                    first = Convert.ToString(Math.Sqrt(otvetfirst));
                    tbAnswer.Text = first;
                }

                    

            }
            else
            {
                otvet = Math.Sqrt(otvet);
                tbAnswer.Text = Convert.ToString(otvet);
            }

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
