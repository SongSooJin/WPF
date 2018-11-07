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
// DataContext를 이용한 TwoWay 데이터 바인딩 실습

namespace DataBinding6
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
        private void OnClicked(object sender, RoutedEventArgs args) {
            Emp e = Grid1.DataContext as Emp;
            System.Console.WriteLine(e.Ename);
            System.Console.WriteLine(e.City);
        }
    }
}
