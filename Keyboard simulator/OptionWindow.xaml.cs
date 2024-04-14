using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Keyboard_simulator
{
     //<summary>
     //Interaction logic for OptionWindow.xaml
     //</summary>
    public partial class OptionWindow : Window
    {
        private Theme theme;
        public OptionWindow()
        {
            InitializeComponent();
            //comboBox_theme.Items.Add(new ComboBoxItemNew((Style)Resources.FindName("WindowBackgroundTheme")));
            comboBox_lenguage.SelectedIndex = ((int)MainWindow.control.language);
            MainWindow.control.themes.CollectionChanged += Themes_CollectionChanged;
            viewModel viewModel = new viewModel();
            this.DataContext = viewModel;
            comboBox_theme.SelectedIndex = 0;
        }

        private void Themes_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {

            //comboBox_theme.Items.Clear();
            //foreach (var theme in MainWindow.control.themes)
            //{
            //    comboBox_theme.Items.Add(new ComboBoxItemNew((Style)Resources.FindName("WindowBackgroundTheme")));
            //}
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
            if (MainWindow.control.language == Keyboard_simulator.Language.English)
            {
                textBlock_Lenguage.Text = "Text";
                button_apply.Content = "Apply";
                button_close.Content = "Close";
            }
            if (MainWindow.control.language == Keyboard_simulator.Language.Ukrainian)
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
            MainWindow.control.language = (Language)comboBox_lenguage.SelectedIndex;
            LenguageChange();
            theme.ApplyTheme();
            DialogResult = true;
        }

        private void comboBox_theme_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            theme = (Theme)comboBox_theme.SelectedItem;
        }
        public class viewModel
        {
            List<Theme> comboboxItems = new();
            public IEnumerable<Theme> themeItems => comboboxItems;
            public viewModel()
            {
                for (int i = 0; i < MainWindow.control.themes.Count; i++)
                {
                    comboboxItems.Add(new Theme());
                }
            }
        }
    }
}
