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

// 트리뷰(TreeView)
// 트리뷰(TreeView)는 계층적인 데이터를 표시할 수 있는 컨트롤인데 윈도우 탐색기의
// 왼쪽창에서 디스크 내용과 디렉토리들을 보여주는 것을 생각하면 된다

namespace Book5
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
