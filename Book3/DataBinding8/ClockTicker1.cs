using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using System.Windows;

// 데이터 바인딩(Data Binding) 실습(OneWay, TwoWay, OneWayToSource, OneTime
//  Source, StaticResource를 통한 데이터 바인딩


namespace DataBinding8
{
    class ClockTicker1 : DependencyObject
    {
        public static DependencyProperty DateTimeProperty = DependencyProperty.Register(
            "DateTime", typeof(DateTime), typeof(ClockTicker1)
            );

        public DateTime DateTime {
            set { SetValue(DateTimeProperty, value); }
            get { return (DateTime)GetValue(DateTimeProperty); }
        }

        public ClockTicker1() {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += TimerOnTick;
            timer.Interval = TimeSpan.FromSeconds(0.1); //1초에 한번씩
            timer.Start();
        }
        void TimerOnTick(object sender, EventArgs args)
        {
            DateTime = DateTime.Now;
        }
    }
}
