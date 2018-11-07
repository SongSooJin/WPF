using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Helpers.Model;
using Helpers.Helpers;

namespace Helpers.ViewModel
{
    class ViewModelMain : ViewModelBase
    {
        public ObservableCollection<Emp> Emps { get; set; }

        object _SelectedEmp;
        public object SelectedEmp {
            get { return _SelectedEmp; }
            set { _SelectedEmp = value; OnPropertyChanged("SelectedEmp"); }
        }

        string _TextProperty;
        public string TextProperty {
            get { return _TextProperty; }
            set { _TextProperty = value; OnPropertyChanged("TextProperty1"); }
        }

        public RelayCommand  AddEmpCommand { get; set; }

        public ViewModelMain() {
            Emps = new ObservableCollection<Emp>() {
                new Emp() { Empno = 1, Ename = "송수진"},
                new Emp() { Empno = 2, Ename = "후이"},
                new Emp() { Empno = 3, Ename = "도라에몽"},
                new Emp() { Empno = 4, Ename = "도라미"},
                new Emp() { Empno = 5, Ename = "진구"},
                new Emp() { Empno = 6, Ename =" 콩알"},
            };

            TextProperty = "이순신";
            AddEmpCommand = new RelayCommand(AddEmp);
        }

        void AddEmp(object param) {
            if (param == null) param = "NAME";
            Emps.Add(new Emp() { Empno = Emps.Count + 1, Ename = param.ToString() });
        }
    }
}
