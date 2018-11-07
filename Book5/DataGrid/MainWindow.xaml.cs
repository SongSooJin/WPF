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
using System.Collections.ObjectModel;


// 데이터 그리드(DataGrid)
// Grid는 컨트롤들을 담지만 DataGrid는 사용자 정의 가능한 표 형태로 데이터를 표시하는 
// 컨트롤로 행 및 열에 데이터 or 그 모임을 표시하는 유연한 방법을 제공한다

namespace DataGrid
{
    public class Skill
    {
        public int Years { get; set; }
        public string Name { get; set; }
    }
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public List<Skill> SkillList { get; set; }
    }
    public class Persons : ObservableCollection<Person>
    {
        public Persons()
        {
            Add(new Person()
            {
                Id = 1,
                Name = "홍길동",
                Position = "Programmer",
                SkillList
           = new List<Skill>()
            });
            Add(new Person()
            {
                Id = 2,
                Name = "정길동",
                Position = "Programmer",
                SkillList
           = new List<Skill>()
            });
        }
    }
    public partial class MainWindow : Window
    {
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Persons pList = new Persons();
            pList[0].SkillList.Add(new Skill() { Years = 5, Name = "C++" });
            pList[0].SkillList.Add(new Skill() { Years = 15, Name = "Visual Basic" });
            pList[1].SkillList.Add(new Skill() { Years = 7, Name = "C#" });
            pList[1].SkillList.Add(new Skill() { Years = 4, Name = "VB.NET" });
            dg.ItemsSource = pList;
        }
        private void dg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems[0] is Person) dg1.ItemsSource =
           ((Person)e.AddedItems[0]).SkillList;
        }
    }
}
