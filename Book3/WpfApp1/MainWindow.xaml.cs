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
using System.Diagnostics;
// 데이터 바인딩에서 의존속성을 사용하는 예제

namespace WpfApp1
{

    public class DPTest : DependencyObject {

        public static readonly DependencyProperty TestProperty = DependencyProperty.Register(
            "Test",
            typeof(string),
            typeof(DPTest),
            new PropertyMetadata ("Dependency Property Initial Value", OnTestPropertyChanged) 
            );

        public string Test {
            get {
                Debug.WriteLine("Test GetValue");
                return (string)GetValue(TestProperty);
            }

            set {
                Debug.WriteLine("Test SetValue");
                SetValue(TestProperty, value);
            }

        }

        private static void OnTestPropertyChanged (DependencyObject d, DependencyPropertyChangedEventArgs e) {
            Debug.WriteLine("Property Changed : {0} " , e.NewValue);
        }
    }
}
