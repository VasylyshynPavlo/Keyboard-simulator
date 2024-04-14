using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Keyboard_simulator
{
    public class Theme
    {
        public SolidColorBrush WindowControlButtonsClose_MouseOver_False { get; set; }
        public SolidColorBrush WindowControlButtonsClose_MouseOver_True { get; set; }
        public SolidColorBrush WindowControlButtonsMinimize_MouseOver_False { get; set; }
        public SolidColorBrush WindowControlButtonsMinimize_MouseOver_True { get; set; }
        public SolidColorBrush WindowControlButtonsDefalutWithText_MouseOverBackground_False { get; set; }
        public SolidColorBrush WindowControlButtonsDefalutWithText_MouseOverBackground_True { get; set; }
        public SolidColorBrush WindowControlButtonsDefalutWithText_MouseOverForeground_False { get; set; }
        public SolidColorBrush WindowControlButtonsDefalutWithText_MouseOverForeground_True { get; set; }
        public SolidColorBrush WindowControlButtonsDragMove_MouseOverBackground_False { get; set; }
        public SolidColorBrush WindowControlButtonsDragMove_MouseOverBackground_True { get; set; }
        public SolidColorBrush DefaultBackgroundBorderElement_Background { get; set; }
        public CornerRadius DefaultBackgroundBorderElement_CornerRadius { get; set; }
        public SolidColorBrush TextBox_Background { get; set; }
        public FontFamily TextBox_FontFamily { get; set; }
        public SolidColorBrush TextBox_BorderBrush { get; set; }
        public SolidColorBrush TextBox_Foreground { get; set; }
        public FontFamily RadioButton_FontFamily { get; set; }
        public SolidColorBrush RadioButton_Foreground { get; set; }
        public SolidColorBrush RadioButton_OuterCircle { get; set; }
        public SolidColorBrush RadioButton_OuterCircle_MouseOver_True { get; set; }
        public SolidColorBrush RadioButton_InnerCircle { get; set; }
        public SolidColorBrush ComboBox_Default_Color_1 { get; set; }
        public SolidColorBrush ComboBox_Default_Color_2 { get; set; }
        public SolidColorBrush ComboBox_Default_Color_Arrow { get; set; }
        public SolidColorBrush ComboBox_Default_Color_Foreground { get; set; }
        public SolidColorBrush DefaultButton_Foreground { get; set; }
        public SolidColorBrush DefaultButton_Background { get; set; }
        public SolidColorBrush DefaultButton_BorderBrush { get; set; }
        public FontFamily DefaultButton_FontFamily { get; set; }
        public SolidColorBrush WindowBackgroundTheme_Border { get; set; }
        public ImageBrush WindowBackgroundTheme_ImageBrush { get; set; }
        public FontFamily DefaultTextBlock_FontFamily { get; set; }
        public SolidColorBrush DefaultTextBlock_Foreground { get; set; }
        public Theme()
        {
            try
            {
                WindowControlButtonsClose_MouseOver_False = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#CD5151"));
                WindowControlButtonsClose_MouseOver_True = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF5151"));

                WindowControlButtonsMinimize_MouseOver_False = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#C9CD51"));
                WindowControlButtonsMinimize_MouseOver_True = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#C9FF51"));

                WindowControlButtonsDefalutWithText_MouseOverBackground_False = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#CDCDCD"));
                WindowControlButtonsDefalutWithText_MouseOverBackground_True = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#999999"));
                WindowControlButtonsDefalutWithText_MouseOverForeground_False = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
                WindowControlButtonsDefalutWithText_MouseOverForeground_True = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));

                WindowControlButtonsDragMove_MouseOverBackground_False = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#CDCDCD"));
                WindowControlButtonsDragMove_MouseOverBackground_True = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));

                DefaultBackgroundBorderElement_Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#66000000"));
                DefaultBackgroundBorderElement_CornerRadius = new CornerRadius(10);

                TextBox_Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
                TextBox_FontFamily = new FontFamily("Bahnschrift");
                TextBox_BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
                TextBox_Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));

                RadioButton_FontFamily = new FontFamily("Bahnschrift");
                RadioButton_Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFFFF"));
                RadioButton_OuterCircle = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF808080"));
                RadioButton_OuterCircle_MouseOver_True = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFB7B7B7"));
                RadioButton_InnerCircle = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFFFF"));

                ComboBox_Default_Color_1 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#66000000"));
                ComboBox_Default_Color_2 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#888888"));
                ComboBox_Default_Color_Arrow = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFFFF"));
                ComboBox_Default_Color_Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFFFF"));

                DefaultButton_Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFFFF"));
                DefaultButton_Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#66000000"));
                DefaultButton_BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFFFF"));
                DefaultButton_FontFamily = new FontFamily("Bahnschrift");

                WindowBackgroundTheme_Border = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFFFF"));
                WindowBackgroundTheme_ImageBrush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri("pack://application:,,,/Mystic_Elegance.png");
                bitmap.EndInit();
                WindowBackgroundTheme_ImageBrush.ImageSource = bitmap;

                DefaultTextBlock_FontFamily = new FontFamily("Bahnschrift");
                DefaultTextBlock_Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFFFF"));
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ApplyTheme()
        {
            var styleDictionary = Application.Current.Resources.MergedDictionaries
                .FirstOrDefault(d => d.Source.OriginalString.EndsWith("Style.xaml"));

            if (styleDictionary != null)
            {
                foreach (var prop in typeof(Theme).GetProperties())
                {
                    var styleKey = prop.Name;
                    if (styleDictionary.Contains(styleKey))
                    {
                        var style = styleDictionary[styleKey] as Style;
                        if (style != null)
                        {
                            var value = prop.GetValue(this);
                            if (value is SolidColorBrush brush)
                            {
                                var setter = new Setter(Control.BackgroundProperty, brush);
                                style.Setters.Add(setter);
                            }
                            else if (value is FontFamily fontFamily)
                            {
                                var setter = new Setter(Control.FontFamilyProperty, fontFamily);
                                style.Setters.Add(setter);
                            }
                            else if (value is CornerRadius cornerRadius)
                            {
                                var setter = new Setter(Control.BorderThicknessProperty, cornerRadius);
                                style.Setters.Add(setter);
                            }
                            else if (value is ImageBrush imageBrush)
                            {
                                var setter = new Setter(Control.BackgroundProperty, imageBrush);
                                style.Setters.Add(setter);
                            }
                        }
                    }
                }
            }
        }
    }
}

