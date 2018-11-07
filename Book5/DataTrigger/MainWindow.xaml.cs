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

namespace DataTrigger
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>


    //    //Slider 컨트롤과 ProgressBar, TextBox 컨트롤을 만들어 Slider 컨트롤을 움지이면
    //    //ProgressBar도 같이 움직이고, TextBox에는 현재의 Value 값이 표시되도록 하자. 아래클래스 추가
    //    public class DataObject
    //    {
    //        public int TheValue { get; set; }
    //    }
    //public partial class MainWindow : Window
    //    {

    //    public mainwindow()
    //    {
    //        initializecomponent();
    //        datacontext = new dataobject();
    //    }


    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

        }

    }
   
    

}
