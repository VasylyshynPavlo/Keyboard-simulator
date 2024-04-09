using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Keyboard_simulator.controls
{
    /// <summary>
    /// Interaction logic for KeyboardButton.xaml
    /// </summary>
    public partial class KeyboardButton : UserControl
    {
        public KeyboardButton()
        {
            InitializeComponent();
        }
        public static readonly DependencyProperty BaseTextProperty = DependencyProperty.Register("BaseText",
               typeof(String),
               typeof(KeyboardButton),
               new PropertyMetadata(string.Empty,
               ValueChangedBase));
        private static void ValueChangedBase(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as KeyboardButton;
            control.LabelBase.Content = e.NewValue;
        }
        public string TopText
        {
            get { return (string)GetValue(BaseTextProperty); }
            set { SetValue(BaseTextProperty, value); }
        }

        public static readonly DependencyProperty SecondTextProperty = DependencyProperty.Register("SecondText",
               typeof(String),
               typeof(KeyboardButton),
               new PropertyMetadata(string.Empty,
               ValueChangedSecond));
        private static void ValueChangedSecond(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as KeyboardButton;
            control.LabelSecond.Content = e.NewValue;
        }
        public string SecondText
        {
            get { return (string)GetValue(SecondTextProperty); }
            set { SetValue(SecondTextProperty, value); }
        }

        public void Pressed()
        {
            ThicknessAnimation thicknessAnimation = new ThicknessAnimation
            {
                From = new Thickness(0),
                To = new Thickness(3, 7, 3, 1),
                Duration = new Duration(TimeSpan.FromMilliseconds(80)),
                EasingFunction = new QuadraticEase { EasingMode = EasingMode.EaseInOut }
            };
            border.BeginAnimation(Border.BorderThicknessProperty, thicknessAnimation);
        }
        public void UnPressed()
        {
            ThicknessAnimation thicknessAnimation = new ThicknessAnimation
            {
                From = new Thickness(3, 7, 3, 1),
                To = new Thickness(0),
                Duration = new Duration(TimeSpan.FromMilliseconds(80)),
                EasingFunction = new QuadraticEase { EasingMode = EasingMode.EaseInOut }
            };
            border.BeginAnimation(Border.BorderThicknessProperty, thicknessAnimation);
        }

        private void grid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            double size = Math.Min(grid.ActualHeight, grid.ActualWidth);
            LabelBase.FontSize = size  * 0.55;
            LabelSecond.FontSize = size * 0.25;
        }
    }
}
