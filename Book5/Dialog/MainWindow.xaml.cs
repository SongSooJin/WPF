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

// 다이얼로그(Dialog)
// 1. 메시지 박스(MessageBox) & 툴팁(ToolTip)


namespace Dialog
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, RoutedEventArgs e) {
            MessageBoxResult result = MessageBox.Show("YES/NO를 선택하세요. ", "2버튼 메세지 박스 테스트 ", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                tb.Text = "2버튼 YES 클릭 ";
            }
            else {
                tb.Text = "2버튼 NO 클릭";
            }
        }

        private void Button3_Click(object sender, RoutedEventArgs e) {
            MessageBoxResult result = MessageBox.Show("메세지", "타이틀(Question 메세지박스, YesNoCancel)",
                MessageBoxButton.YesNoCancel, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                tb.Text = "3버튼 YES 클릭";
            }
            else if (result == MessageBoxResult.No)
            {
                tb.Text = "3버튼 NO 클릭";
            else if (result == MessageBoxResult.Cancel) {
                tb.Text = "3버튼 CANCEL 클릭";
            }
        }
    }
}