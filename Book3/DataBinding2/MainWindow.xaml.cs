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
using System.Windows.Controls.Primitives;

// 데이터 바인딩(Data Binding) 실습(OneWay, TwoWay, OneWayToSource, OneTime
// 바인딩을 C#코드로 구현한 예문

namespace DataBinding2
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Binding bind = new Binding();
            bind.Source = scrollbar;
            bind.Path = new PropertyPath(ScrollBar.ValueProperty);
            label.SetBinding(Label.ContentProperty, bind);
        }
    }
}

 
// Binding의 Mode 속성의 기본값은 Default인데 Textbox처럼 사용자가 편집 가능한
// 컨트롤 속성의 기본값은 양방향 바인딩으로 설정되지만 대부분의 경우 기본값은 단
// 방향 바인딩으로 설정된다.
// TwoWay로 설정할 수도 있는데 Label의 Content 프로퍼티의 변화도 scrollbar의
// Value 프로퍼티에 반영된다.
// OneTime 모드도 있는데 타겟이 소스로부터 초기화 되지만 소스의 변화가 계속 반
// 영되지 않고 초기 한 번만 반영된다.
// OneWayToSource 모드는 소스, 타겟의 의미와 반대가 되도록 타겟이 소스를 갱신하
// 는 모양이다.본 예제의 경우 Label은 ScrollBar에 넘겨줄 숫자 데이터가 없기에
// Label은 비어 있고 ScrollBar를 움직여도 반응이 없는 형태가 된다.