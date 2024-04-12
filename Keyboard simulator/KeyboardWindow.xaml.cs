using Keyboard_simulator.controls;
using System.Windows;
using System.Windows.Input;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Keyboard_simulator
{
    /// <summary>
    /// Interaction logic for KeyboardWindow.xaml
    /// </summary>
    public partial class KeyboardWindow : Window
    {
        private DispatcherTimer timer;
        private TimeSpan time;
        private int Time;
        private bool end = false;
        public KeyboardWindow()
        {
            InitializeComponent();
            LenguageChange();
            UpdateLine();
            Progress.Maximum = MainWindow.control.game.text.Length;
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            time = TimeSpan.Zero;
            timer.Start();
            Time = 0;
            TimerValue.Text = Time.ToString();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            Time++;
            TimerValue.Text = Time.ToString();
        }

        private void UpdateLine()
        {

            History.Text = MainWindow.control.game.history;
            Current.Text = MainWindow.control.game.current.ToString();
            Next.Text = MainWindow.control.game.next;
            Progress.Value = History.Text.Length;
            MissValue.Text = MainWindow.control.game.miss.ToString();

            if (Progress.Value == Progress.Maximum)
            {
                end = true;
                timer.Stop();
                if (MainWindow.control.language == Keyboard_simulator.Language.English)
                {
                    winInfo.TimeText = "Time:";
                    winInfo.RestartText = "Restart";
                    winInfo.GoToMenuText = "Menu";
                    winInfo.Time = Time.ToString() + " sec";
                }
                if (MainWindow.control.language == Keyboard_simulator.Language.Ukrainian)
                {
                    winInfo.TimeText = "Час:";
                    winInfo.RestartText = "Спочатку";
                    winInfo.GoToMenuText = "Меню";
                    winInfo.Time = Time.ToString() + " сек";
                }
                winInfo.Visibility = Visibility.Visible;

            }
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
            Space.TopText = "Space";
            Space.SecondText = " ";
            if (MainWindow.control.language == Keyboard_simulator.Language.English)
            {
                Oem3.TopText = "`";
                Oem3.SecondText = "~";
                D1.SecondText = "!";
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
            if (MainWindow.control.language == Keyboard_simulator.Language.Ukrainian)
            {
                Oem3.TopText = "'";
                Oem3.SecondText = "₴";
                D1.SecondText = "!";
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
        void Spaces(bool value)
        {
            if (value)
            {
                if (MainWindow.control.language == Keyboard_simulator.Language.English)
                {
                    Oem3.SecondText = "`";
                    Oem3.TopText = "~";
                    D1.SecondText = "1";
                    D2.SecondText = "2";
                    D3.SecondText = "3";
                    D4.SecondText = "4";
                    D5.SecondText = "5";
                    D6.SecondText = "6";
                    D7.SecondText = "7";
                    D8.SecondText = "8";
                    D9.SecondText = "9";
                    D0.SecondText = "0";
                    D1.TopText = "!";
                    D2.TopText = "@";
                    D3.TopText = "#";
                    D4.TopText = "$";
                    D5.TopText = "%";
                    D6.TopText = "^";
                    D7.TopText = "&";
                    D8.TopText = "*";
                    D9.TopText = "(";
                    D0.TopText = ")";
                    OemMinus.TopText = "_";
                    OemMinus.SecondText = "-";
                    OemPlus.TopText = "+";
                    OemPlus.SecondText = "=";


                    Q.SecondText = "q";
                    W.SecondText = "w";
                    E.SecondText = "e";
                    R.SecondText = "r";
                    T.SecondText = "t";
                    Y.SecondText = "y";
                    U.SecondText = "u";
                    I.SecondText = "i";
                    O.SecondText = "o";
                    P.SecondText = "p";
                    OemOpenBrackets.SecondText = "[";
                    Oem6.SecondText = "]";


                    A.SecondText = "a";
                    S.SecondText = "s";
                    D.SecondText = "d";
                    F.SecondText = "f";
                    G.SecondText = "g";
                    H.SecondText = "h";
                    J.SecondText = "j";
                    K.SecondText = "k";
                    L.SecondText = "l";
                    Oem1.SecondText = ";";
                    OemQuotes.SecondText = "\'";
                    Oem5.SecondText = "\\";


                    Z.SecondText = "z";
                    X.SecondText = "x";
                    C.SecondText = "c";
                    V.SecondText = "v";
                    B.SecondText = "b";
                    N.SecondText = "n";
                    M.SecondText = "m";
                    OemComma.SecondText = ",";
                    OemPeriod.SecondText = ".";
                    OemQuestion.SecondText = "/";




                    Q.TopText = "Q";
                    W.TopText = "W";
                    E.TopText = "E";
                    R.TopText = "R";
                    T.TopText = "T";
                    Y.TopText = "Y";
                    U.TopText = "U";
                    I.TopText = "I";
                    O.TopText = "O";
                    P.TopText = "P";
                    OemOpenBrackets.TopText = "{";
                    Oem6.TopText = "}";


                    A.TopText = "A";
                    S.TopText = "S";
                    D.TopText = "D";
                    F.TopText = "F";
                    G.TopText = "G";
                    H.TopText = "H";
                    J.TopText = "J";
                    K.TopText = "K";
                    L.TopText = "L";
                    Oem1.TopText = ":";
                    OemQuotes.TopText = "\"";
                    Oem5.TopText = "|";


                    Z.TopText = "Z";
                    X.TopText = "X";
                    C.TopText = "C";
                    V.TopText = "V";
                    B.TopText = "B";
                    N.TopText = "N";
                    M.TopText = "M";
                    OemComma.TopText = "<";
                    OemPeriod.TopText = ">";
                    OemQuestion.TopText = "?";
                }
                if (MainWindow.control.language == Keyboard_simulator.Language.Ukrainian)
                {
                    Oem3.SecondText = "'";
                    Oem3.TopText = "₴";
                    D1.TopText = "!";
                    D2.TopText = "\"";
                    D3.TopText = "№";
                    D4.TopText = ";";
                    D5.TopText = "%";
                    D6.TopText = ":";
                    D7.TopText = "?";
                    D8.TopText = "*";
                    D9.TopText = "(";
                    D0.TopText = ")";
                    D1.SecondText = "1";
                    D2.SecondText = "2";
                    D3.SecondText = "3";
                    D4.SecondText = "4";
                    D5.SecondText = "5";
                    D6.SecondText = "6";
                    D7.SecondText = "7";
                    D8.SecondText = "8";
                    D9.SecondText = "9";
                    D0.SecondText = "0";
                    OemMinus.TopText = "_";
                    OemMinus.SecondText = "-";
                    OemPlus.TopText = "+";
                    OemPlus.SecondText = "=";


                    Q.SecondText = "й";
                    W.SecondText = "ц";
                    E.SecondText = "у";
                    R.SecondText = "к";
                    T.SecondText = "е";
                    Y.SecondText = "н";
                    U.SecondText = "г";
                    I.SecondText = "ш";
                    O.SecondText = "щ";
                    P.SecondText = "з";
                    OemOpenBrackets.SecondText = "х";
                    Oem6.SecondText = "ї";


                    A.SecondText = "ф";
                    S.SecondText = "і";
                    D.SecondText = "в";
                    F.SecondText = "а";
                    G.SecondText = "п";
                    H.SecondText = "р";
                    J.SecondText = "о";
                    K.SecondText = "л";
                    L.SecondText = "д";
                    Oem1.SecondText = "ж";
                    OemQuotes.SecondText = "є";
                    Oem5.SecondText = "\\";


                    Z.SecondText = "я";
                    X.SecondText = "ч";
                    C.SecondText = "с";
                    V.SecondText = "м";
                    B.SecondText = "и";
                    N.SecondText = "т";
                    M.SecondText = "ь";
                    OemComma.SecondText = "б";
                    OemPeriod.SecondText = "ю";
                    OemQuestion.SecondText = ".";



                    Q.TopText = "Й";
                    W.TopText = "Ц";
                    E.TopText = "У";
                    R.TopText = "К";
                    T.TopText = "Е";
                    Y.TopText = "Н";
                    U.TopText = "Г";
                    I.TopText = "Ш";
                    O.TopText = "Щ";
                    P.TopText = "З";
                    OemOpenBrackets.TopText = "Х";
                    Oem6.TopText = "Ї";


                    A.TopText = "Ф";
                    S.TopText = "І";
                    D.TopText = "В";
                    F.TopText = "А";
                    G.TopText = "П";
                    H.TopText = "Р";
                    J.TopText = "О";
                    K.TopText = "Л";
                    L.TopText = "Д";
                    Oem1.TopText = "Ж";
                    OemQuotes.TopText = "Є";
                    Oem5.TopText = "/";


                    Z.TopText = "Я";
                    X.TopText = "Ч";
                    C.TopText = "С";
                    V.TopText = "М";
                    B.TopText = "И";
                    N.TopText = "Т";
                    M.TopText = "Ь";
                    OemComma.TopText = "Б";
                    OemPeriod.TopText = "Ю";
                    OemQuestion.TopText = ",";
                }
            }
            else
            {
                LenguageChange();
            }
        }

        private void Window_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (!end)
            {
                string buttonName = e.Key.ToString();
                KeyboardButton myButton = this.FindName(buttonName) as KeyboardButton;
                if (myButton != null)
                {
                    if ((Keyboard.Modifiers & ModifierKeys.Shift) == ModifierKeys.Shift)
                    {
                        Spaces(true);
                    }
                    myButton.Pressed();
                    MainWindow.control.game.Step(myButton.TopText);
                    UpdateLine();
                }
            }
        }

        private void Window_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (!end)
            {
                string buttonName = e.Key.ToString();
                KeyboardButton myButton = this.FindName(buttonName) as KeyboardButton;
                if (myButton != null)
                {
                    if ((Keyboard.Modifiers & ModifierKeys.Shift) != ModifierKeys.Shift)
                    {
                        Spaces(false);
                    }
                    myButton.UnPressed();
                }
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

        private void winInfo_RestartClick(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void winInfo_GoToMenuClick(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
