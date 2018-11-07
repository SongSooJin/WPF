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

// Input Controls – Key Input Control
// 키보드 입력을 제어해서 한글 또는 숫자만 입력 가능하도록 구현하는 예제

namespace InputControls2
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            InputMethod.SetIsInputMethodEnabled(this.txt1, false);
        }

        private void txt1_KeyDown(object sender, KeyEventArgs e) {
            Key inputKey = e.Key.Equals(Key.ImeProcessed) ? e.ImeProcessedKey : e.Key;
            if (inputKey == Key.Escape) Close();
        }

        private void txt2_PreviewTextInput(object sender, TextCompositionEventArgs e) {
            if (!char.IsDigit(e.Text, e.Text.Length - 1)) e.Handled = true;
        }

        private void txt2_PreviewKeyDown(object sender, KeyEventArgs e) {
            if (e.Key.Equals(Key.ImeProcessed)) {
                e.Handled = true;
            }
            if (e.Key.Equals(Key.Escape)) Close();
        }
    }
}
