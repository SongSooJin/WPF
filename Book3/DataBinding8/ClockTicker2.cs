using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;using System.ComponentModel;
// 데이터 바인딩(Data Binding) 실습(OneWay, TwoWay, OneWayToSource, OneTime
// PropertyChanged 이벤트, PropertyChangedEventHandler를 통한 데이터 바인딩

// WPF의 데이터 바인딩 로직은 이벤트가 INotifyPropertyChanged 인터페이스를 구현
// 한 클래스안에 정의되어 있으면 이벤트를 찾는다.이 인터페이스를 상속받아 구현하
// 면 PropertyChangedEventHandler 델리게이트를 기본으로 하는 PropertyChanged
// 이벤트를 정의해야 한다.

namespace DataBinding8
{
    public class ClockTicker2 : INotifyPropertyChanged
    {
        // INotyfyPropertyChanged 인터페이스가 요구하는 이벤트
        public event PropertyChangedEventHandler PropertyChanged;

        // public 프로퍼티
        public DateTime DateTime
        {
            get { return DateTime.Now; }
        }

        // 생성자에서 Timer를 설정
        public ClockTicker2()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += TimerOnTick;
            timer.Interval = TimeSpan.FromSeconds(0.1);
            timer.Start();
        }

        // PropertyChanged 이벤트를 발생시키는 타이버 이벤트 핸들러
        void TimerOnTick(object sender, EventArgs args)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new
               PropertyChangedEventArgs("DateTime"));
            }
        }
    }
}
