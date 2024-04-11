using System.Diagnostics;
using System.IO;
using System.Windows;

namespace Keyboard_simulator
{
    public class FileSystem
    {
        string TextesFilePath = Directory.GetCurrentDirectory() + "\\files\\textes.txt";
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
                if (File.Exists(TextesFilePath))
                {
                    List<string> files = new List<string>(File.ReadAllLines(TextesFilePath));
                    foreach (string line in files)
                    {
                        MainWindow.control.textes.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Current.Shutdown();
            }
        }
        public void OpenTextFile()
        {
            try
            {
                if (File.Exists(TextesFilePath))
                {
                    var file = new ProcessStartInfo(TextesFilePath)
                    {
                        UseShellExecute = true
                    };
                    System.Diagnostics.Process.Start(file);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Current.Shutdown();
            }
        }
    }
}
