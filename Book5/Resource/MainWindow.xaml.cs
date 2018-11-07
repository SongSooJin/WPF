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

// WPF 리소스(Resource) 관리
// 리소스(Resource)는 일반적으로 한 번 이상 자주 사용하기를 원하는 자원을 이야기한다.
// 컨트롤 또는 현재 창(Window)에 대해 또는 전체 응용 프로그램에 대해 전역으로 어떤 데이터를 
// 저장하는 기능이다.
// 객체를 리소스로 정의하면 다른 윈도우, 컨트롤, 다른 어셈블리에서 객체에 접근할수 있다.
// 즉 객체가 재사용 될 수 있다.
// StaticResource는 일회성 조회이지만, DynamicResource는 데이터 바인딩과 유사하고
// 속성이 특정 리소스 키와 연관되어 있는 경우이다.해당 키와 연관된 개체가 변경되면 // DynamicResource가 대상 속성을 업데이트 한다.

namespace Resource
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
