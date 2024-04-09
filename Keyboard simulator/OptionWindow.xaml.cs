using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Keyboard_simulator
{
    /// <summary>
    /// Interaction logic for OptionWindow.xaml
    /// </summary>
    public partial class OptionWindow : Window
    {
        public OptionWindow()
        {
            InitializeComponent();
            comboBox_lenguage.SelectedIndex = ((int)MainWindow.control.lenguage);
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Button_Minimize(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Button_Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        void LenguageChange()
        {
            if (MainWindow.control.lenguage == Lenguage.English)
            {
                textBlock_Lenguage.Text = "Text";
                button_apply.Content = "Apply";
                button_close.Content = "Close";
            }
            if (MainWindow.control.lenguage == Lenguage.Ukrainian)
            {
                textBlock_Lenguage.Text = "Текст";
                button_apply.Content = "Застосувати";
                button_close.Content = "Закрити";
            }
        }

        private void comboBox_lenguage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LenguageChange();
        }

        private void button_apply_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.control.lenguage = (Lenguage)comboBox_lenguage.SelectedIndex;
            LenguageChange();
            DialogResult = true;
        }
    }
}
