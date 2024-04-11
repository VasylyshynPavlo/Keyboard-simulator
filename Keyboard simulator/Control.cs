using System.Collections.ObjectModel;

namespace Keyboard_simulator
{
    public enum Lenguage
    {
        English,
        Ukrainian
    }
    public class Control
    {
        public delegate void LenguageChangedEventHandler(object sender, EventArgs e);
        public event LenguageChangedEventHandler LenguageChanged;
        public ObservableCollection<string> textes;
        public FileSystem fileSystem;
        public Game game;

        private Lenguage _lenguage;
        public Lenguage lenguage
        {
            get { return _lenguage; }
            set
            {
                if (_lenguage != value)
                {
                    _lenguage = value;
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
            lenguage = Lenguage.English;
            textes = new ObservableCollection<string>();
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
        public void StartGame(string text)
        {
            game = new Game(text);
            KeyboardWindow keyboardWindow = new KeyboardWindow();
            keyboardWindow.ShowDialog();
            if( keyboardWindow.DialogResult == true )
            {
                StartGame(text);
            }
        }
    }
}
