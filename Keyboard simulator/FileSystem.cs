using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Controls;
using Newtonsoft.Json;

namespace Keyboard_simulator
{
    public class FileSystem
    {
        string TextesFilePath = Directory.GetCurrentDirectory() + @"\files\textes.txt";
        string ThemeFilePath = Directory.GetCurrentDirectory() + @"\files\themes\themes.json";
        public FileSystem()
        {
        }
        public void Init()
        {
            Update();
        }
        public void Update()
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
                            if (match.Groups[2].Value == "English" || match.Groups[2].Value == "Українська")
                            {
                                if (match.Groups[3].Value.Length > 0)
                                {
                                    if (match.Groups[1].Value.Length == 0) MainWindow.control.textes.Add(new Text { Name = "Text", Lenguage = match.Groups[2].Value, text = match.Groups[3].Value });
                                    else MainWindow.control.textes.Add(new Text { Name = match.Groups[1].Value, Lenguage = match.Groups[2].Value, text = match.Groups[3].Value });
                                }
                                else
                                {
                                    MessageBox.Show($"Unable to add `{match.Groups[1]}`. The text line is empty", "Information", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
                                }
                            }
                            else
                            {
                                MessageBox.Show($"Unable to add `{match.Groups[1]}`. The language line is empty or incorrect", "Information", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
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
                if (File.Exists(ThemeFilePath))
                {
                    var text = File.ReadAllText(ThemeFilePath);
                    var themes = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(text);

                    foreach (var theme in themes)
                    {
                        var themeObj = new Theme();
                        foreach (var prop in theme)
                        {
                            var propName = prop.Key;
                            var propValue = prop.Value.ToString();
                            var themeProp = typeof(Theme).GetProperty(propName);
                            if (themeProp != null)
                            {
                                if (themeProp.PropertyType == typeof(SolidColorBrush))
                                {
                                    themeProp.SetValue(themeObj, new SolidColorBrush((Color)ColorConverter.ConvertFromString(propValue)));
                                }
                                else if (themeProp.PropertyType == typeof(FontFamily))
                                {
                                    themeProp.SetValue(themeObj, new FontFamily(propValue));
                                }
                                else if (themeProp.PropertyType == typeof(CornerRadius))
                                {
                                    themeProp.SetValue(themeObj, new CornerRadius(double.Parse(propValue)));
                                }
                                else if (themeProp.PropertyType == typeof(ImageBrush))
                                {
                                    var image = new ImageBrush();
                                    image.ImageSource = new BitmapImage(new Uri(propValue, UriKind.Relative));
                                    themeProp.SetValue(themeObj, image);
                                }
                            }
                        }
                        MainWindow.control.themes.Add(themeObj);
                    }
                }
                else
                {
                    using (StreamWriter sw = new StreamWriter(ThemeFilePath))
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
