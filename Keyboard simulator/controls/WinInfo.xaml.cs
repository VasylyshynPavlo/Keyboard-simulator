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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Keyboard_simulator.controls
{
    /// <summary>
    /// Interaction logic for WinInfo.xaml
    /// </summary>
    public partial class WinInfo : UserControl
    {
        public WinInfo()
        {
            InitializeComponent();
        }

        public static readonly RoutedEvent RestartClickEvent = 
            EventManager.RegisterRoutedEvent(nameof(RestartClick), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(WinInfo));
        
        public event RoutedEventHandler RestartClick
        {
            add { AddHandler(RestartClickEvent, value); }
            remove { RemoveHandler(RestartClickEvent, value);}
        }

        private void OnRestartClick(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(RestartClickEvent));
        }


        public static readonly RoutedEvent GoToMenuClickEvent =
            EventManager.RegisterRoutedEvent(nameof(GoToMenuClick), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(WinInfo));

        public event RoutedEventHandler GoToMenuClick
        {
            add { AddHandler(RestartClickEvent, value); }
            remove { RemoveHandler(RestartClickEvent, value); }
        }
        private void OnGoToMenuClick(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(GoToMenuClickEvent));
        }



        public string Time
        {
            get { return (string)GetValue(TimeProperty); }
            set { SetValue(TimeProperty, value); }
        }
        public static readonly DependencyProperty TimeProperty =
            DependencyProperty.Register("Time", typeof(string), typeof(WinInfo), new PropertyMetadata(string.Empty));


    }
}
