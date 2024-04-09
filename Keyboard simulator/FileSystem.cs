using System.IO;
using System.Windows;

namespace Keyboard_simulator
{
    public class FileSystem
    {
        public FileSystem()
        {

        }
        public void Init()
        {
            UpdateTextes();
        }
        public void UpdateTextes()
        {
            MainWindow.control.textes.Clear();
            try
            {
                string[] pngFiles = Directory.GetFiles(@"./files/", "*.txt", SearchOption.AllDirectories);
                bool find = false;
                foreach (string file in pngFiles)
                {
                    if (Path.GetFileName(file) == "textes.txt")
                    {
                        List<string> files = new List<string>(File.ReadAllLines(file));
                        foreach (string line in files)
                        {
                            MainWindow.control.textes.Add(line);
                        }
                        find = true;
                        break;
                    }
                }
                if (!find)
                {
                    MessageBox.Show("Can't find textes.txt", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    Application.Current.Shutdown();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
