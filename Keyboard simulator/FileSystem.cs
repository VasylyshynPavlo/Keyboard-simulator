using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows;

namespace Keyboard_simulator
{
    public class FileSystem
    {
        string TextesFilePath = Directory.GetCurrentDirectory() + @"\files\textes.txt";
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
                    string content = File.ReadAllText(TextesFilePath);
                    string[] blocks = content.Split(new string[] { "Name=" }, StringSplitOptions.None);

                    foreach (string block in blocks)
                    {
                        if (string.IsNullOrWhiteSpace(block))
                            continue;

                        Match match = Regex.Match(block, @"^""([^""]*)""\s*\{\s*Language=""([^""]*)""\s*Text=""([^""]*)""\s*\}");
                        if (match.Success)
                        {
                            if (match.Groups[2].Value.Length > 0 && match.Groups[3].Value.Length > 0)
                            {
                                if (match.Groups[1].Value.Length == 0) MainWindow.control.textes.Add(new Text { Name = "Text", Lenguage = match.Groups[2].Value, text = match.Groups[3].Value });
                                else MainWindow.control.textes.Add(new Text { Name = match.Groups[1].Value, Lenguage = match.Groups[2].Value, text = match.Groups[3].Value });
                            }
                        }
                    }
                }
                else
                {
                    using (StreamWriter sw = new StreamWriter(TextesFilePath))
                    {
                        sw.Write(string.Empty);
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
