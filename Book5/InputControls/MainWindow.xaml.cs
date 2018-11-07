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

// Input Controls
// Input Controls - PasswordBox
// PasswordBox 컨트롤은 한 줄짜리 TextBox처럼 보이고 동작한다.사용자가 적은 양의
// 일반 텍스트를 입력 할 수 있지만 텍스트는 화면에 표시되지 않는다.대신 입력 한텍스트의 
// 각 문자에 대한 기호가 입력된다.또한 입력된 텍스트는 SecureString 개체에 
// 저장되므로 메모리를 직접 읽어도 의미가 없다.

namespace InputControls
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

        private void passwordBox1_PasswordChanged(object sender, RoutedEventArgs e) {
            MessageBox.Show("Password changed");
        }

        private void Logon_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show(pwd.SecurePassword.Length.ToString());
            MessageBox.Show(pwd.Password);
        }
    }
}
