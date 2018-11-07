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

// WPF Style, Trigger
// WPF Style


namespace WPFStyle
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


        //Setter가 Style의 자식중 대체로 이용 되지만 라우팅된 특정 이벤트의 이벤트핸들러를 
        //설정하기 위해서는 EventSetter 엘리먼트를 이용할 수 있는데 다수의 엘리먼트에서 
        //이벤트를 공유할 수 있다.
        void ButtonOnClick(object sender, RoutedEventArgs args) {
            Button btn = args.Source as Button;
            MessageBox.Show(btn.Content + " has been clicked", Title);
        }
    }
}
