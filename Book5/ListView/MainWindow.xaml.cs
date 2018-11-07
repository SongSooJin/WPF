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

// 리스트뷰(ListView)
// ListView 컨트롤은 가장 간단한 형태의 리스트를 나열하는 객체로 ListBox와 매우 비슷하다.
// ListView는 ListBox 컨트롤에서 직접 상속되고 기본적인 ListView는 실제로 다른 
// 선택 모드를 가진 ListBox이다.

namespace ListView
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
    }
}
