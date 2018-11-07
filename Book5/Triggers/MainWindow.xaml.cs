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
using System.Threading;

namespace Triggers
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

        //Trigger 엘리먼트가 같은 프로퍼티를 두번 설정하면 뒤 Trigger 엘리먼트는 이전의것을
        //오버라이딩 한다.아래 예제에서 두 Trigger 프로퍼티의 순서를 바꾸면 전경색은
        //빨강으로 바뀔 수 없다.IsPressed가 true이면 IsMouseOver 역시 true이기 때문이다. 
        //버튼에 마우스를 누르려면 버튼 안으로 마우스가 진입해야 하므로 항상
        //IsMouseOver 상태가 된다. (순서상 재정의 된 마지막의 것이 실행 되므로 이벤트가
        //겹치는 경우 나중에 정의된 것이 실행된다는 뜻이다.)
        void ButtonOnClick(object sender, RoutedEventArgs args) {
            Thread.Sleep(1000);
            Button btn = args.Source as Button;
            MessageBox.Show(btn.Content + "has been clicked", Title);
        }
    } 
}
