using System.Collections.ObjectModel;
using System.Windows;

namespace Keyboard_simulator
{
    public enum Language
    {
        English,
        Ukrainian
    }
    public class ControlClasss
    {
        public delegate void LenguageChangedEventHandler(object sender, EventArgs e);
        public event LenguageChangedEventHandler LenguageChanged;
        public ObservableCollection<Text> textes;
        public ObservableCollection<Theme> themes;
        public FileSystem fileSystem;
        public Game game;

        private Language _language;
        public Language language
        {
            get { return _language; }
            set
            {
                if (_language != value)
                {
                    _language = value;
                    OnLenguageChanged(EventArgs.Empty);
                }
            }
        }

        protected virtual void OnLenguageChanged(EventArgs e)
        {
            LenguageChanged?.Invoke(this, e);
        }
        public ControlClasss()
        {
            language = Language.English;
            textes = new ObservableCollection<Text>();
            themes = new ObservableCollection<Theme>();
            fileSystem = new FileSystem();
            //fileSystem.Init();
            themes.Add(new());
        }
        public void OpenOptions()
        {
            OptionWindow optionWindow = new OptionWindow();
            optionWindow.ShowDialog();
            if (optionWindow.DialogResult == true)
            {

            }
        }
        public void StartGame(Text text)
        {
            if (text.Lenguage == "English") language = Language.English;
            if (text.Lenguage == "Українська") language = Language.Ukrainian;
            game = new Game(text);
            KeyboardWindow keyboardWindow = new KeyboardWindow();
            keyboardWindow.ShowDialog();
            if (keyboardWindow.DialogResult == true)
            {
                StartGame(text);
            }
        }
    }
}
