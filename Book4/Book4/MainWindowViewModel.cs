﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Book4
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public Emp _SelectedEmp;
        public Emp SelectedEmp
        {
            get
            {
                return _SelectedEmp;
            }
            set
            {
                _SelectedEmp = value;
                OnPropertyChanged("SelectedEmp");
            }
        }
        public Emp _SelectedJob;
        public Emp SelectedJob
        {
            get
            {
                return _SelectedJob;
            }
            set
            {
                _SelectedJob = value;
                OnPropertyChanged("SelectedJob");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string Pname = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Pname));
        }

        public RelayCommand AddEmpCommand { get; set; }
        public ObservableCollection<Emp> Emps { get; set; }
        public MainWindowViewModel()
        {
            Emps = new ObservableCollection<Emp>();

            Emps.Add(new Emp { Ename = "홍길동", Job = "111" });
            Emps.Add(new Emp { Ename = "김길동", Job = "111" });
            Emps.Add(new Emp { Ename = "정길동", Job = "111" });
            Emps.Add(new Emp { Ename = "박길동", Job = "111" });
            Emps.Add(new Emp { Ename = "성길동", Job = "111" });

            AddEmpCommand = new RelayCommand(AddEmp);

        }

        public void AddEmp(object param)
        {
            Emps.Add(new Emp { Ename = param.ToString() });
        }
    }
}
