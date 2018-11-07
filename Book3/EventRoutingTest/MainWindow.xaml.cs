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

// 입력 이벤트의 라우팅(RoutedEvent), Bubbling, Tunneling

namespace EventRoutingTest
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

        private void Button_Click(object sender, RoutedEventArgs e) {
            txt1.Text = "Button is Clicked ";
        }

        private void StackPanel_Click(object sender, RoutedEventArgs e) {
            txt2.Text = "Click event is bubbled to Stack Panel";
            //e.Handled = true; 
            //상위 객체로 라우팅 되는 것을 막으려면 RoutedEventArgs의 Handled 속성을 true로
            //설정하면 된다. 버튼 클릭 이벤트에 “e.Handled = true” 라고 하면 버튼까지만, 스택
            //패널 클릭 이벤트에 “e.Handled = true” 라고 한다면 스택 패널 까지만 이벤트가 전
            //달된다
        }

        private void Window_Click(object sender, RoutedEventArgs e) {
            txt3.Text = "Click event is bubbled to Window";
        }
    }
}
