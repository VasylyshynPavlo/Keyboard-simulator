using System.Windows;
using System.Windows.Input;

namespace Keyboard_simulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Control control = new();
        public MainWindow()
        {
            InitializeComponent();
            ViewModel viewModel = new ViewModel();
            this.DataContext = viewModel;
            control.LenguageChanged += MyClass_LenguageChanged;
            control.textes.CollectionChanged += Textes_CollectionChanged;
            control.fileSystem.UpdateTextes();
        }

        private void Textes_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            combobox_textes.Items.Clear();
            foreach (Text txt in control.textes)
            {
                combobox_textes.Items.Add(txt);
            }
        }

        private void MyClass_LenguageChanged(object sender, EventArgs e)
        {
            LenguageChange();
        }
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        private void LenguageChange()
        {
            if (control.language == Keyboard_simulator.Language.English)
            {
                textBlock_text.Text = "Text";
                button_play.Content = "Play";
                button_settings.Content = "Setting";
                button_about.Content = "About";
            }
            if (control.language == Keyboard_simulator.Language.Ukrainian)
            {
                textBlock_text.Text = "Текст";
                button_play.Content = "Грати";
                button_settings.Content = "Налаштунки";
                button_about.Content = "Про";
            }
        }

        private void button_update_Click(object sender, RoutedEventArgs e)
        {
            control.fileSystem.UpdateTextes();
        }

        private void button_play_Click(object sender, RoutedEventArgs e)
        {
            if (combobox_textes.SelectedIndex != -1)
            {
                control.StartGame(control.textes[combobox_textes.SelectedIndex]);
            }

        }

        private void TextFileOpen_Click(object sender, RoutedEventArgs e)
        {
            control.fileSystem.OpenTextFile();
        }
    }
    public class ViewModel
    {
        RelayCommand _closeCommand;
        RelayCommand _minimizeCommand;
        RelayCommand _openOptionCommand;
        RelayCommand _updateTextFilesCommand;
        public ViewModel()
        {
            _closeCommand = new RelayCommand((o) => Close());
            _minimizeCommand = new RelayCommand((o) => Minimize());
            _openOptionCommand = new RelayCommand((o) => OpenOption());
            _updateTextFilesCommand = new RelayCommand((o) => UpdateTextFilesCommand());
        }
        public ICommand closeCommand => _closeCommand;
        public ICommand minimizeCommand => _minimizeCommand;
        public ICommand openOptionCommand => _openOptionCommand;
        public ICommand updateTextFilesCommand => _updateTextFilesCommand;
        void Close()
        {
            Application.Current.Shutdown();
        }
        void Minimize()
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }
        void OpenOption()
        {
            MainWindow.control.OpenOptions();
        }
        void UpdateTextFilesCommand()
        {
            MainWindow.control.fileSystem.Init();
        }
    }
}