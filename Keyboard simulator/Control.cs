using System.Collections.ObjectModel;

namespace Keyboard_simulator
{
    public enum Language
    {
        English,
        Ukrainian
    }
    public class Control
    {
        public delegate void LenguageChangedEventHandler(object sender, EventArgs e);
        public event LenguageChangedEventHandler LenguageChanged;
        public ObservableCollection<Text> textes;
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
        public Control()
        {
            language = Language.English;
            textes = new ObservableCollection<Text>();
            fileSystem = new FileSystem();
            //fileSystem.Init();
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
