using Keyboard_simulator.controls;
using System.Windows;
using System.Windows.Input;
using System.Windows.Shapes;

namespace Keyboard_simulator
{
    /// <summary>
    /// Interaction logic for KeyboardWindow.xaml
    /// </summary>
    public partial class KeyboardWindow : Window
    {
        public KeyboardWindow()
        {
            InitializeComponent();
            LenguageChange();
        }

        private void Border_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void LenguageChange()
        {
            D1.TopText = "1";
            D2.TopText = "2";
            D3.TopText = "3";
            D4.TopText = "4";
            D5.TopText = "5";
            D6.TopText = "6";
            D7.TopText = "7";
            D8.TopText = "8";
            D9.TopText = "9";
            D0.TopText = "0";
            Tab.TopText = "↹";
            Tab.SecondText = " ";
            Capital.TopText = "🠉";
            Capital.SecondText = " ";
            LeftShift.TopText = "Shift";
            LeftShift.SecondText = " ";
            LeftCtrl.TopText = "Ctrl";
            LeftCtrl.SecondText = " ";
            RightShift.TopText = "Shift";
            RightShift.SecondText = " ";
            RightCtrl.TopText = "Ctrl";
            RightCtrl.SecondText = " ";
            Back.TopText = "🠈";
            Back.SecondText = " ";
            OemPlus.TopText = "=";
            OemPlus.SecondText = "+";
            OemMinus.TopText = "-";
            OemMinus.SecondText = "_";
            Return.TopText = "↲";
            Return.SecondText = " ";
            if (MainWindow.control.lenguage == Lenguage.English)
            {
                Oem3.TopText = "`";
                Oem3.SecondText = "~";
                D2.SecondText = "@";
                D3.SecondText = "#";
                D4.SecondText = "$";
                D5.SecondText = "%";
                D6.SecondText = "^";
                D7.SecondText = "&";
                D8.SecondText = "*";
                D9.SecondText = "(";
                D0.SecondText = ")";


                Q.TopText = "q";
                W.TopText = "w";
                E.TopText = "e";
                R.TopText = "r";
                T.TopText = "t";
                Y.TopText = "y";
                U.TopText = "u";
                I.TopText = "i";
                O.TopText = "o";
                P.TopText = "p";
                OemOpenBrackets.TopText = "[";
                Oem6.TopText = "]";


                A.TopText = "a";
                S.TopText = "s";
                D.TopText = "d";
                F.TopText = "f";
                G.TopText = "g";
                H.TopText = "h";
                J.TopText = "j";
                K.TopText = "k";
                L.TopText = "l";
                Oem1.TopText = ";";
                OemQuotes.TopText = "\'";
                Oem5.TopText = "\\";


                Z.TopText = "z";
                X.TopText = "x";
                C.TopText = "c";
                V.TopText = "v";
                B.TopText = "b";
                N.TopText = "n";
                M.TopText = "m";
                OemComma.TopText = ",";
                OemPeriod.TopText = ".";
                OemQuestion.TopText = "/";




                Q.SecondText = "Q";
                W.SecondText = "W";
                E.SecondText = "E";
                R.SecondText = "R";
                T.SecondText = "T";
                Y.SecondText = "Y";
                U.SecondText = "U";
                I.SecondText = "I";
                O.SecondText = "O";
                P.SecondText = "P";
                OemOpenBrackets.SecondText = "{";
                Oem6.SecondText = "}";


                A.SecondText = "A";
                S.SecondText = "S";
                D.SecondText = "D";
                F.SecondText = "F";
                G.SecondText = "G";
                H.SecondText = "H";
                J.SecondText = "J";
                K.SecondText = "K";
                L.SecondText = "L";
                Oem1.SecondText = ":";
                OemQuotes.SecondText = "\"";
                Oem5.SecondText = "|";


                Z.SecondText = "Z";
                X.SecondText = "X";
                C.SecondText = "C";
                V.SecondText = "V";
                B.SecondText = "B";
                N.SecondText = "N";
                M.SecondText = "M";
                OemComma.SecondText = "<";
                OemPeriod.SecondText = ">";
                OemQuestion.SecondText = "?";

            }
            if (MainWindow.control.lenguage == Lenguage.Ukrainian)
            {
                Oem3.TopText = "'";
                Oem3.SecondText = "₴";
                D2.SecondText = "\"";
                D3.SecondText = "№";
                D4.SecondText = ";";
                D5.SecondText = "%";
                D6.SecondText = ":";
                D7.SecondText = "?";
                D8.SecondText = "*";
                D9.SecondText = "(";
                D0.SecondText = ")";


                Q.TopText = "й";
                W.TopText = "ц";
                E.TopText = "у";
                R.TopText = "к";
                T.TopText = "е";
                Y.TopText = "н";
                U.TopText = "г";
                I.TopText = "ш";
                O.TopText = "щ";
                P.TopText = "з";
                OemOpenBrackets.TopText = "х";
                Oem6.TopText = "ї";


                A.TopText = "ф";
                S.TopText = "і";
                D.TopText = "в";
                F.TopText = "а";
                G.TopText = "п";
                H.TopText = "р";
                J.TopText = "о";
                K.TopText = "л";
                L.TopText = "д";
                Oem1.TopText = "ж";
                OemQuotes.TopText = "є";
                Oem5.TopText = "\\";


                Z.TopText = "я";
                X.TopText = "ч";
                C.TopText = "с";
                V.TopText = "м";
                B.TopText = "и";
                N.TopText = "т";
                M.TopText = "ь";
                OemComma.TopText = "б";
                OemPeriod.TopText = "ю";
                OemQuestion.TopText = ".";



                Q.SecondText = "Й";
                W.SecondText = "Ц";
                E.SecondText = "У";
                R.SecondText = "К";
                T.SecondText = "Е";
                Y.SecondText = "Н";
                U.SecondText = "Г";
                I.SecondText = "Ш";
                O.SecondText = "Щ";
                P.SecondText = "З";
                OemOpenBrackets.SecondText = "Х";
                Oem6.SecondText = "Ї";


                A.SecondText = "Ф";
                S.SecondText = "І";
                D.SecondText = "В";
                F.SecondText = "А";
                G.SecondText = "П";
                H.SecondText = "Р";
                J.SecondText = "О";
                K.SecondText = "Л";
                L.SecondText = "Д";
                Oem1.SecondText = "Ж";
                OemQuotes.SecondText = "Є";
                Oem5.SecondText = "/";


                Z.SecondText = "Я";
                X.SecondText = "Ч";
                C.SecondText = "С";
                V.SecondText = "М";
                B.SecondText = "И";
                N.SecondText = "Т";
                M.SecondText = "Ь";
                OemComma.SecondText = "Б";
                OemPeriod.SecondText = "Ю";
                OemQuestion.SecondText = ",";
            }

        }



        private void Window_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {

            string buttonName = e.Key.ToString();
            KeyboardButton myButton = this.FindName(buttonName) as KeyboardButton;
            if (myButton != null)
            {
                myButton.Pressed();

            }
        }

        private void Window_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {

            string buttonName = e.Key.ToString();
            KeyboardButton myButton = this.FindName(buttonName) as KeyboardButton;
            if (myButton != null)
            {
                myButton.UnPressed();
            }
        }


        #region ResizeWindows
        bool ResizeInProcess = false;
        private void Resize_Init(object sender, MouseButtonEventArgs e)
        {
            Rectangle senderRect = sender as Rectangle;
            if (senderRect != null)
            {
                ResizeInProcess = true;
                senderRect.CaptureMouse();
            }
        }

        private void Resize_End(object sender, MouseButtonEventArgs e)
        {
            Rectangle senderRect = sender as Rectangle;
            if (senderRect != null)
            {
                ResizeInProcess = false; ;
                senderRect.ReleaseMouseCapture();
            }
        }

        private void Resizeing_Form(object sender, MouseEventArgs e)
        {
            if (ResizeInProcess)
            {
                Rectangle senderRect = sender as Rectangle;
                Window mainWindow = senderRect.Tag as Window;
                if (senderRect != null)
                {
                    double width = e.GetPosition(mainWindow).X;
                    double height = e.GetPosition(mainWindow).Y;
                    senderRect.CaptureMouse();
                    if (senderRect.Name.ToLower().Contains("right"))
                    {
                        width += 5;
                        if (width > 0)
                            mainWindow.Width = width;
                    }
                    if (senderRect.Name.ToLower().Contains("left"))
                    {
                        width -= 5;
                        mainWindow.Left += width;
                        width = mainWindow.Width - width;
                        if (width > 0)
                        {
                            mainWindow.Width = width;
                        }
                    }
                    if (senderRect.Name.ToLower().Contains("bottom"))
                    {
                        height += 5;
                        if (height > 0)
                            mainWindow.Height = height;
                    }
                    if (senderRect.Name.ToLower().Contains("top"))
                    {
                        height -= 5;
                        mainWindow.Top += height;
                        height = mainWindow.Height - height;
                        if (height > 0)
                        {
                            mainWindow.Height = height;
                        }
                    }
                }
            }
        }
        #endregion

    }
}
