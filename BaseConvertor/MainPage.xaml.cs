using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace BaseConvertor
{
    public partial class MainPage : PhoneApplicationPage
    {
        int value1 = 0xCAFE;
        int value2 = 0xDEAD;
        int operation;
        bool hexMode = false;

        // Constructor
        public MainPage()
        {
            InitializeComponent();
            HideButtons();
            value1 = 0;
            value2 = 0;
            operation = 0;
            refreshDisplay();
        }

        private void buttonReset_Click(object sender, RoutedEventArgs e)
        {
            value1 = 0;
            value2 = 0;
            operation = 0;
            refreshDisplay();
        }

        public static string ToBinary(Int64 Decimal)
        {
            // Declare a few variables we're going to need
            Int64 BinaryHolder;
            char[] BinaryArray;
            string BinaryResult = "";

            while (Decimal > 0)
            {
                BinaryHolder = Decimal % 2;
                BinaryResult += BinaryHolder;
                Decimal = Decimal >> 1;
            }

            // The algoritm gives us the binary number in reverse order (mirrored)
            // We store it in an array so that we can reverse it back to normal
            BinaryArray = BinaryResult.ToCharArray();
            Array.Reverse(BinaryArray);
            BinaryResult = new string(BinaryArray);

            return BinaryResult;
        }

        private void refreshDisplay()
        {
            textBlockResult1.Text = hexMode ? "0x" : "";
            textBlockResult1.Text += hexMode ? value1.ToString("X") : value1.ToString("d");
            if (value2 != 0)
            {
                textBlockResult2.Text = hexMode ? "0x" : "";
                textBlockResult2.Text += hexMode ? value2.ToString("X") : value2.ToString("d");
                textBlockResult2.Visibility = Visibility.Visible;
            }
            else
            {
                textBlockResult2.Visibility = Visibility.Collapsed;
            }

            textBlockBin1.Text = ToBinary(value1);
            textBlockBin2.Text = ToBinary(value2);

            switch (operation)
            {
                case 0: //No op
                    {
                        textBlockOp.Visibility = Visibility.Collapsed;
                        break;
                    }
                case 1: //XOR
                    {
                        textBlockOp.Visibility = Visibility.Visible;
                        textBlockOp.Text = "XOR";
                        break;
                    }
                case 2: //NOT
                    {
                        textBlockOp.Visibility = Visibility.Visible;
                        textBlockOp.Text = "NOT";
                        break;
                    }
                case 3: //AND
                    {
                        textBlockOp.Visibility = Visibility.Visible;
                        textBlockOp.Text = "AND";
                        break;
                    }
                case 4: //OR
                    {
                        textBlockOp.Visibility = Visibility.Visible;
                        textBlockOp.Text = "OR";
                        break;
                    }
                case 5: //DIV
                    {
                        textBlockOp.Visibility = Visibility.Visible;
                        textBlockOp.Text = "/";
                        break;
                    }
                case 6: //PLUS
                    {
                        textBlockOp.Visibility = Visibility.Visible;
                        textBlockOp.Text = "+";
                        break;
                    }
                case 7: //MINUS
                    {
                        textBlockOp.Visibility = Visibility.Visible;
                        textBlockOp.Text = "-";
                        break;
                    }
                case 8: //MUL
                    {
                        textBlockOp.Visibility = Visibility.Visible;
                        textBlockOp.Text = "*";
                        break;
                    }
            }

        }

        private void HideButtons()
        {
            if (hexMode)
            {
                buttonDec.IsEnabled = true;
                buttonHex.IsEnabled = false;
                buttonA.IsEnabled = true;
                buttonB.IsEnabled = true;
                buttonC.IsEnabled = true;
                buttonD.IsEnabled = true;
                buttonE.IsEnabled = true;
                buttonF.IsEnabled = true;
            }
            else
            {
                buttonDec.IsEnabled = false;
                buttonHex.IsEnabled = true;
                buttonA.IsEnabled = false;
                buttonB.IsEnabled = false;
                buttonC.IsEnabled = false;
                buttonD.IsEnabled = false;
                buttonE.IsEnabled = false;
                buttonF.IsEnabled = false;
            }
            refreshDisplay();
        }

        private void swapValues()
        {
            value2 = value1;
            value1 = 0;
            refreshDisplay();
        }

        private void buttonDec_Click(object sender, RoutedEventArgs e)
        {
            hexMode = false;
            HideButtons();
        }

        private void buttonHex_Click(object sender, RoutedEventArgs e)
        {
            hexMode = true;
            HideButtons();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            value1 = value1 != 0 ? value1 * (hexMode ? 16 : 10) + 1 : 1;
            refreshDisplay();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            value1 = value1 != 0 ? value1 * (hexMode ? 16 : 10) + 2 : 2;
            refreshDisplay();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            value1 = value1 != 0 ? value1 * (hexMode ? 16 : 10) + 3 : 3;
            refreshDisplay();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            value1 = value1 != 0 ? value1 * (hexMode ? 16 : 10) + 4 : 4;
            refreshDisplay();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            value1 = value1 != 0 ? value1 * (hexMode ? 16 : 10) + 5 : 5;
            refreshDisplay();
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            value1 = value1 != 0 ? value1 * (hexMode ? 16 : 10) + 6 : 6;
            refreshDisplay();
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            value1 = value1 != 0 ? value1 * (hexMode ? 16 : 10) + 7 : 7;
            refreshDisplay();
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            value1 = value1 != 0 ? value1 * (hexMode ? 16 : 10) + 8 : 8;
            refreshDisplay();
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            value1 = value1 != 0 ? value1 * (hexMode ? 16 : 10) + 9 : 9;
            refreshDisplay();
        }

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            value1 *= (hexMode ? 16 : 10);
            refreshDisplay();
        }

        private void buttonA_Click(object sender, RoutedEventArgs e)
        {
            value1 = value1 * 16 + 0xA;
            refreshDisplay();
        }

        private void buttonB_Click(object sender, RoutedEventArgs e)
        {
            value1 = value1 * 16 + 0xB;
            refreshDisplay();
        }

        private void buttonC_Click(object sender, RoutedEventArgs e)
        {
            value1 = value1 * 16 + 0xC;
            refreshDisplay();
        }

        private void buttonD_Click(object sender, RoutedEventArgs e)
        {
            value1 = value1 * 16 + 0xD;
            refreshDisplay();
        }

        private void buttonE_Click(object sender, RoutedEventArgs e)
        {
            value1 = value1 * 16 + 0xE;
            refreshDisplay();
        }

        private void buttonF_Click(object sender, RoutedEventArgs e)
        {
            value1 = value1 * 16 + 0xF;
            refreshDisplay();
        }

        private void buttonDel_Click(object sender, RoutedEventArgs e)
        {
            value1 = value1 / (hexMode ? 16 : 10);
            refreshDisplay();
        }

        private void buttonXOR_Click(object sender, RoutedEventArgs e)
        {
            operation = 1;
            swapValues();
            refreshDisplay();
        }

        private void buttonNOT_Click(object sender, RoutedEventArgs e)
        {
            operation = 2;
            swapValues();
            refreshDisplay();
        }

        private void buttonAND_Click(object sender, RoutedEventArgs e)
        {
            operation = 3;
            swapValues();
            refreshDisplay();
        }

        private void buttonOR_Click(object sender, RoutedEventArgs e)
        {
            operation = 4;
            swapValues();
            refreshDisplay();
        }

        private void buttonDiv_Click(object sender, RoutedEventArgs e)
        {
            operation = 5;
            swapValues();
            refreshDisplay();
        }

        private void buttonPlus_Click(object sender, RoutedEventArgs e)
        {
            operation = 6;
            swapValues();
            refreshDisplay();
        }

        private void buttonSub_Click(object sender, RoutedEventArgs e)
        {
            operation = 7;
            swapValues();
            refreshDisplay();
        }

        private void buttonMul_Click(object sender, RoutedEventArgs e)
        {
            operation = 8;
            swapValues();
            refreshDisplay();
        }

        private void buttonEqual_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case 1: //XOR
                    {
                        value1 ^= value2;
                        break;
                    }
                case 2: //NOT
                    {
                        break;
                    }
                case 3: //AND
                    {
                        break;
                    }
                case 4: //OR
                    {
                        break;
                    }
                case 5: //DIV
                    {
                        value1 /= value2;
                        break;
                    }
                case 6: //PLUS
                    {
                        value1 += value2;
                        break;
                    }
                case 7: //MINUS
                    {
                        value1 -= value2;
                        break;
                    }
                case 8: //MUL
                    {
                        value1 *= value2;
                        break;
                    }
            }
            value2 = 0;
            operation = 0;
            refreshDisplay();
        }
    }
}