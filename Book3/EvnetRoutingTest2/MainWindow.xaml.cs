﻿using System;
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

// 입력 이벤트의 라우팅(RoutedEvent), Bubbling, Tunneling

namespace EvnetRoutingTest2
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        string mouseActivity = string.Empty;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_PreviewMouseDown(object sender, RoutedEventArgs e) {
            mouseActivity = "PreivewMouseDown Button \n";
            MessageBox.Show(mouseActivity);
        }

        private void StackPanel_PreviewMouseDown(object sender, RoutedEventArgs e)
        {
            mouseActivity = "PreiviewMouseDown StackPanel \n";
        }

        private void Window_PreviewMouseDown(object sender, RoutedEventArgs e) {
            mouseActivity = "PreiviewMouseDown Window \n";
        }
    }
}
