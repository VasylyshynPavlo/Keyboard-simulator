﻿using System.Windows;
using System.Windows.Controls;

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
            remove { RemoveHandler(RestartClickEvent, value); }
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




        public string TimeText
        {
            get { return (string)GetValue(TimeTextProperty); }
            set { SetValue(TimeTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TimeText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TimeTextProperty =
            DependencyProperty.Register("TimeText", typeof(string), typeof(WinInfo), new PropertyMetadata(string.Empty));




        public string RestartText
        {
            get { return (string)GetValue(RestartTextProperty); }
            set { SetValue(RestartTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for RestartText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RestartTextProperty =
            DependencyProperty.Register("RestartText", typeof(string), typeof(WinInfo), new PropertyMetadata(string.Empty));



        public string GoToMenuText
        {
            get { return (string)GetValue(GoToMenuTextProperty); }
            set { SetValue(GoToMenuTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for GoToMenuText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty GoToMenuTextProperty =
            DependencyProperty.Register("GoToMenuText", typeof(string), typeof(WinInfo), new PropertyMetadata(string.Empty));


    }
}
