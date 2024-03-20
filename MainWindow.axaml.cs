using Avalonia.Controls;
using Avalonia.Interactivity;
using System;

namespace Calculator
{

    public partial class MainWindow : Window
    {
        public int countVhod = 0;
        public int countStVhod = 0;
        public string chislo;
        public double tempChislo;
        public double secChislo;
        public double newChislo;
        public double thirdChislo;
        public string operationPre;
        public string operationPreSec;
        public bool minuschislo;

        public MainWindow()
        {
            InitializeComponent();
            newChislo = 0;
        }

        public void Operation(string operationPre, double firstChislo, double secondChislo)
        {
            thirdChislo = tempChislo;
            switch (operationPre)
            {
                case "+":
                    newChislo += secChislo;
                    break;

                case "-":
                    newChislo -= secChislo;
                    break;

                case "*":
                    newChislo *= secChislo;
                    break;

                case "/":
                    newChislo /= secChislo;
                    break;
                case "=":
                    vvodChisla.Text = newChislo.ToString();
                    break;
                case "sqrt":
                    newChislo = Math.Sqrt(newChislo);
                    break;
                case "step":
                    newChislo = Math.Pow(firstChislo, secondChislo);
                    break;
            }
        }

        private void ForDoubleBtn_Click(object sender, RoutedEventArgs e)
        {
            chislo += ",";
            vvodChisla.Text = chislo;
        }
        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            if (minuschislo == true)
            {
                chislo = "-";
            }
            chislo += "0";
            vvodChisla.Text = chislo;
            tempChislo = Convert.ToDouble(chislo);
            minuschislo = false;
        }
        private void One_Click(object sender, RoutedEventArgs e)
        {
            if (minuschislo == true)
            {
                chislo = "-";
            }
            chislo += "1";
            vvodChisla.Text = chislo;
            tempChislo = Convert.ToDouble(chislo);
            minuschislo = false;
        }
        private void Two_Click(object sender, RoutedEventArgs e)
        {
            if (minuschislo == true)
            {
                chislo = "-";
            }
            chislo += "2";
            vvodChisla.Text = chislo;
            tempChislo = Convert.ToDouble(chislo);
            minuschislo = false;
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            if (minuschislo == true)
            {
                chislo = "-";
            }
            chislo += "3";
            vvodChisla.Text = chislo;
            tempChislo = Convert.ToDouble(chislo);
            minuschislo = false;
        }
        private void Four_Click(object sender, RoutedEventArgs e)
        {
            if (minuschislo == true)
            {
                chislo = "-";
            }
            chislo += "4";
            vvodChisla.Text = chislo;
            tempChislo = Convert.ToDouble(chislo);
            minuschislo = false;
        }
        private void Five_Click(object sender, RoutedEventArgs e)
        {
            if (minuschislo == true)
            {
                chislo = "-";
            }
            chislo += "5";
            vvodChisla.Text = chislo;
            tempChislo = Convert.ToDouble(chislo);
            minuschislo = false;
        }
        private void Six_Click(object sender, RoutedEventArgs e)
        {
            if (minuschislo == true)
            {
                chislo = "-";
            }
            chislo += "6";
            vvodChisla.Text = chislo;
            tempChislo = Convert.ToDouble(chislo);
            minuschislo = false;
        }
        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            if (minuschislo == true)
            {
                chislo = "-";
            }

            chislo += "7";
            vvodChisla.Text = chislo;
            tempChislo = Convert.ToDouble(chislo);
            minuschislo = false;
        }
        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            if (minuschislo == true)
            {
                chislo = "-";
            }
            chislo += "8";
            vvodChisla.Text = chislo;
            tempChislo = Convert.ToDouble(chislo);
            minuschislo = false;
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            if (minuschislo == true)
            {
                chislo = "-";
            }
            chislo += "9";
            vvodChisla.Text = chislo;
            tempChislo = Convert.ToDouble(chislo);
            minuschislo = false;
        }


        private void SlozhBtn_Click(object sender, RoutedEventArgs e)
        {
            if (countVhod == 0)
            {
                newChislo = 0;
                operationPre = "+";
            }
            secChislo = tempChislo;
            switch (operationPre)
            {
                case "+":
                    newChislo = newChislo + secChislo;

                    break;

                case "-":
                    newChislo -= secChislo;

                    break;

                case "*":
                    newChislo *= secChislo;

                    break;

                case "/":
                    int ost = Convert.ToInt32(newChislo % secChislo);
                    newChislo /= secChislo;

                    break;
                case "=":
                    vvodChisla.Text = newChislo.ToString();

                    break;

            }

            vvodChisla.Text = null;
            operationPre = "+";
            countVhod++;
            chislo = null;
        }
        private void UmenshBtn_Click(object sender, RoutedEventArgs e)
        {
            if (countVhod == 0)
            {
                newChislo = 0;
                operationPre = "+";
            }

            if (chislo == null && countVhod == 0)
            {
                newChislo = 0;
                operationPre = "+";
                minuschislo = true;

            }
            else
            {
                minuschislo = false;
            }
            secChislo = tempChislo;
            switch (operationPre)
            {
                case "+":
                    newChislo += secChislo;
                    vvodChisla.Text = null;
                    break;

                case "-":
                    newChislo -= secChislo;
                    vvodChisla.Text = null;
                    break;

                case "*":
                    newChislo *= secChislo;
                    vvodChisla.Text = null;
                    break;

                case "/":
                    int ost = Convert.ToInt32(newChislo % secChislo);
                    newChislo /= secChislo;
                    vvodChisla.Text = null;
                    break;
            }
            vvodChisla.Text = null;
            operationPre = "-";
            countVhod++;
            chislo = null;
        }
        private void UmnozhBtn_Click(object sender, RoutedEventArgs e)
        {
            if (countVhod == 0)
            {
                newChislo = 0;
                operationPre = "+";
            }
            secChislo = tempChislo;
            switch (operationPre)
            {
                case "+":
                    newChislo += secChislo;
                    vvodChisla.Text = null;
                    break;

                case "-":
                    newChislo -= secChislo;
                    vvodChisla.Text = null;
                    break;

                case "*":
                    newChislo *= secChislo;
                    vvodChisla.Text = null;
                    break;

                case "/":
                    int ost = Convert.ToInt32(newChislo % secChislo);
                    newChislo /= secChislo;
                    vvodChisla.Text = null;
                    break;

            }
            vvodChisla.Text = null;
            operationPre = "*";
            countVhod++;
            chislo = null;
        }
        private void DelenieBtn_Click(object sender, RoutedEventArgs e)
        {
            if (countVhod == 0)
            {
                newChislo = 0;
                operationPre = "+";
            }
            secChislo = tempChislo;

            switch (operationPre)
            {
                case "+":
                    newChislo += secChislo;
                    vvodChisla.Text = null;
                    break;

                case "-":
                    newChislo -= secChislo;
                    vvodChisla.Text = null;
                    break;

                case "*":
                    newChislo *= secChislo;
                    vvodChisla.Text = null;
                    break;

                case "/":
                    int ost = Convert.ToInt32(newChislo % secChislo);
                    newChislo /= secChislo;
                    vvodChisla.Text = null;
                    break;
            }
            vvodChisla.Text = null;
            operationPre = "/";
            countVhod++;
            chislo = null;
        }
        private void RavnoBtn_Click(object sender, RoutedEventArgs e)
        {
            vvodChisla.Text = null;
            if (countVhod == 0)
            {
                newChislo = 0;
                operationPre = "+";
            }
           
            secChislo = tempChislo;
            
            switch (operationPre)
            {
                case "+":
                    newChislo += secChislo;
                    break;
                case "-":
                    newChislo -= secChislo;
                    break;
                case "*":
                    newChislo *= secChislo;
                    break;
                case "/":
                    int ost = Convert.ToInt32(newChislo % secChislo);
                    newChislo /= secChislo;
                    break;
                case "=":
                    vvodChisla.Text = newChislo.ToString();
                    break;
                      case "step":
                          if (countStVhod > 1)
                          {
                              thirdChislo = tempChislo;
                              operationPreSec = "step";
                              Operation(operationPreSec, secChislo, thirdChislo);
                          }
                          else
                          {
                              secChislo = tempChislo;
                              operationPreSec = "step";
                          }
                         
                          break;
            }
            
            tempChislo = newChislo;
            operationPre = "=";
            Operation(operationPre, newChislo, secChislo);
            vvodChisla.Text = newChislo.ToString();
            chislo = null;
        }
        private void OchistitBtn_Click(object sender, RoutedEventArgs e)
        {
            secChislo = 0;
            vvodChisla.Text = null;
            countVhod = 0;
            operationPre = "";
            operationPreSec = "";
            newChislo = 0;
            chislo = null;
        }

        private void SqrtBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            if (countVhod == 0)
            {
                newChislo = Math.Sqrt(tempChislo);
            }
            else
            {
                newChislo = Math.Sqrt(tempChislo);
                tempChislo = newChislo;

                Operation(operationPre, newChislo, secChislo);
            }

            countVhod++;

            operationPre = "";

        }
        private void LnBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {

            if (countVhod == 0)
            {
                newChislo = Math.Log(tempChislo);
                tempChislo = newChislo;
            }
            else
            {
                newChislo = Math.Log(tempChislo);
                tempChislo = newChislo;
                Operation(operationPre, newChislo, secChislo);
            }

            operationPre = "";
            countVhod++;

        }
        private void SinBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {

            if (countVhod == 0)
            {
                newChislo = Math.Sin(tempChislo);
                thirdChislo = tempChislo;
            }
            else
            {
                newChislo = Math.Sin(Math.PI * tempChislo / 180);
               thirdChislo = tempChislo;

                Operation(operationPre, newChislo, secChislo);
            }
            operationPreSec = "sin";
            operationPre = "";
            countVhod++;

        }
        private void CosBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {

            if (countVhod == 0)
            {
                newChislo = Math.Cos(Math.PI * tempChislo / 180);
                tempChislo = newChislo;
            }
            else
            {
                newChislo = Math.Cos(Math.PI * tempChislo / 180);
                tempChislo = newChislo;
                Operation(operationPre, newChislo, secChislo);
            }
            operationPreSec = "cos";
            operationPre = "";
            countVhod++;

        }
        private void TgBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {


            if (countVhod == 0)
            {
                newChislo = Math.Tan(Math.PI * tempChislo / 180);
                tempChislo = newChislo;
            }
            else
            {
                newChislo = Math.Tan(Math.PI * tempChislo / 180);
                tempChislo = newChislo;

                Operation(operationPre, newChislo, secChislo);
            }
            operationPreSec = "tan";
            operationPre = "";
            countVhod++;
        }

        private void StepenBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            vvodChisla.Text = null;
            if (countVhod == 0)
            {
                newChislo = tempChislo;
                operationPre = "step";
            }
            else
            {
                if (countStVhod > 1)
                {
                    thirdChislo = tempChislo;
                    operationPreSec = "step";
                    Operation(operationPreSec, secChislo, thirdChislo);
                }
                else
                {
                    secChislo = tempChislo;
                    operationPreSec = "step";
                }

            }
            chislo = null;
            countStVhod++;
            countVhod++;
        }

        private void PiBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            if (countVhod == 0)
            {
                newChislo = Math.PI;
                vvodChisla.Text = newChislo.ToString();
            }
            else
            {
                newChislo = Math.PI;
                vvodChisla.Text = newChislo.ToString();
                tempChislo = newChislo;

                Operation(operationPre, newChislo, secChislo);
            }
            operationPre = "";
            countVhod++;

        }
        private void TenStepenBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {


            if (countVhod == 0)
            {
                newChislo = Math.Pow(10, tempChislo);
            }
            else
            {
                newChislo = Math.Pow(10, tempChislo);
                tempChislo = newChislo;

                Operation(operationPre, newChislo, secChislo);
            }
            operationPre = "";
            countVhod++;

        }

        private void FactorialBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            if (countVhod == 0)
            {
                newChislo = Factorial(Convert.ToInt32(tempChislo));
                
            }
            else
            {
                newChislo = Factorial(Convert.ToInt32(tempChislo));
                tempChislo = newChislo;

                Operation(operationPre, newChislo, secChislo);
            }
            vvodChisla.Text = newChislo.ToString();
            operationPre = "";
            countVhod++;



        }

        long Factorial(int n)
        {
            if (n == 1)
            {
                return 1;

            }
            else
            {
                return n * Factorial(n - 1);
            }
            
        }

        private void DelenieNaXBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            if (countVhod == 0)
            {
                newChislo = 1 / tempChislo;
            }
            else
            {
                newChislo = 1 / tempChislo;
                tempChislo = newChislo;

                Operation(operationPre, newChislo, secChislo);
            }

            operationPre = "";
            countVhod++;



        }
        private void ModBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            if (countVhod == 0)
            {
                if (tempChislo < 0)
                {
                    newChislo = -tempChislo;
                }
                else
                {
                    newChislo = -tempChislo;
                }
                vvodChisla.Text = newChislo.ToString();
            }
            else
            {
                if (tempChislo < 0)
                {
                    newChislo = -tempChislo;
                }
                else
                {
                    newChislo = tempChislo;
                }
                tempChislo = newChislo;
                vvodChisla.Text = newChislo.ToString();
                Operation(operationPre, newChislo, secChislo);
            }
           
            operationPre = "";
            countVhod++;



        }
       private void LogTenBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
       {
            if (countVhod == 0)
            {
                newChislo = Math.Log(tempChislo, 10);
            }
            else
            {
                newChislo = Math.Log(tempChislo, 10);
                tempChislo = newChislo;

                Operation(operationPre, newChislo, secChislo);
            }

            operationPre = "";
            countVhod++;

        }


        private void CubeBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            if (countVhod == 0)
            {
                newChislo = Math.Pow(tempChislo, 2);
            }
            else
            {
                newChislo = Math.Pow(tempChislo, 2);
                tempChislo = newChislo;

                Operation(operationPre, newChislo, secChislo);
            }

            operationPre = "";
            countVhod++;


        }

        private void KvadrBtn_Click (object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            if (countVhod == 0)
            {
                newChislo = Math.Pow(tempChislo, 3);
            }
            else
            {
                newChislo = Math.Log(tempChislo, 3);
                tempChislo = newChislo;

                Operation(operationPre, newChislo, secChislo);
            }

            operationPre = "";
            countVhod++;

        }


        private void SinhBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            if (countVhod == 0)
            {
                newChislo = Math.Sinh(tempChislo);
            }
            else
            {
                newChislo = Math.Sinh(tempChislo);
                tempChislo = newChislo;

                Operation(operationPre, newChislo, secChislo);
            }

            operationPre = "";
            countVhod++;

        }
        private void CoshBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            if (countVhod == 0)
            {
                newChislo = Math.Cosh(Math.PI * tempChislo / 180);
            }
            else
            {
                newChislo = Math.Cosh(tempChislo);
                tempChislo = newChislo;
                Operation(operationPre, newChislo, secChislo);
            }
            operationPre = "";
            countVhod++;
        }


        private void TanhBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            if (countVhod == 0)
            {
                newChislo = Math.Tanh(tempChislo);
            }
            else
            {
                newChislo = Math.Tan(Math.PI * tempChislo / 180)+1;
                tempChislo = newChislo;
                Operation(operationPre, newChislo, secChislo);
            }
            operationPre = "";
            countVhod++;
        }

        private void ExpBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            if (countVhod == 0)
            {
                newChislo = Math.Exp(tempChislo);
            }
            else
            {
                newChislo = Math.Tanh(tempChislo);
                tempChislo = newChislo;
                Operation(operationPre, newChislo, secChislo);
            }
            operationPre = "";
            countVhod++;
        }

        private void InvBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            if (countVhod == 0)
            {
                switch (operationPreSec)
                {
                    case "sin":
                        newChislo = Math.Asin(newChislo) * (180.0 / Math.PI);
                        break;
                    case "cos":
                        newChislo = Math.Acos(newChislo) * (180.0 / Math.PI);
                        break;
                    case "tan":
                        newChislo = Math.Atan(newChislo) * (180.0 / Math.PI);
                        break;
                }
            }
            else
            {
                switch (operationPreSec)
                {
                    case "sin":
                        newChislo = Math.Asin(newChislo) * (180.0 / Math.PI);
                        break;
                    case "cos":
                        newChislo = Math.Acos(newChislo) * (180.0 / Math.PI); 
                        break;
                    case "tan":
                        newChislo = Math.Atan(newChislo) * (180.0 / Math.PI);
                        break;
                }
                tempChislo = newChislo;
                Operation(operationPre, newChislo, secChislo);
            }
            operationPre = "";
            countVhod++;
        }

        private void IntBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            if (countVhod == 0)
            {
                newChislo = Math.Floor(tempChislo);
            }
            else
            {
                newChislo = Math.Floor(tempChislo);
                tempChislo = newChislo;
                Operation(operationPre, newChislo, secChislo);
            }
            operationPre = "";
            countVhod++;
        }


        private void DmsBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            double grad, minutes, seconds;
           
                grad = Math.Floor(tempChislo);
                minutes = (tempChislo - Math.Floor(tempChislo)) * 60;
                seconds = (minutes - Math.Floor(minutes)) * 60;
                string dms = grad.ToString() + " " + minutes.ToString() + "' " + seconds.ToString() + "''" ;
           
                grad = Math.Floor(tempChislo);
                minutes = (tempChislo - Math.Floor(tempChislo)) * 60;
                seconds = (minutes - Math.Floor(minutes)) * 60;
                 dms = grad.ToString() + "°  " + minutes.ToString() + "'  " + seconds.ToString() + "''";

            vvodChisla.Text = dms;
            operationPre = "";
            countVhod++;
        }


    }
}