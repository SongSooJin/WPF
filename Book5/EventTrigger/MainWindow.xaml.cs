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

// 이벤트 트리거(EventTrigger), ColorAnimation, DoubleAnimation, DoubleAnimationUsingKeyFrames

// Trigger 또는 MultiTrigger는 특정 속성값이 변했을 때, DataTrigger, MultiDataTrigger는 
// 바인딩 되는 값이 변경 되었을 때 발생하는 트리거이지만 EventTrigger는 특정
// 이벤트가 일어 났을때 트리거가 실행되며 FrameworkElement의 RoutedEvent가 발생
// 했을 때 실행되는 트리거 이다.
// EventTrigger는 특정 이벤트가 발생했을 때 컨트롤이나 엘리먼트의 변경을 유도하는데
// 주로 그래픽 애니메이션등에서 사용되며 FrameworkElement도 Triggers라는 프로퍼티를
// 정의하며 이 컬렉션에 들어갈 수 있는 유일한 Trigger가 EventTrigger이다

// ColorAnimation : UIElement의 컬러 프로퍼티(SolidColorBrush, LinearGradientBrush)
// 변화에 사용되는 애니메이션으로 Duration으로 시:분:초를 정의하고 From(source),
// To(target) 등의 속성등을 지정할 수 있다.


namespace EventTrigger
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
