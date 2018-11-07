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

// 데이터 바인딩(Data Binding) 실습(OneWay, TwoWay, OneWayToSource, OneTime
// DataContext를 이용한 데이터 바인딩

namespace DataBinding5
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

// 이번 예제에서 DataContext는 StackPanel에 한 번 설정되
// 었고 Label과 Button은 ScrollBar와 바인딩 되었다.Label에 바인딩 된 프로퍼티는
// Content이지만 Button에 바인딩 된것은 FontSize이므로 ScrollBar를 움직이면 Button
// 내부의 텍스트가 점점 커지고 Button도 커진다.
