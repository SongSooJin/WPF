﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace WpfApp1
{

    public enum DutyType {
        Inner, OutSide
    }

    public class Duty
    {
        private string _name;
        private DutyType _dutyType;

        public Duty() {

        }

        public Duty(string name, DutyType dutyType) {
            _name = name;
            _dutyType = dutyType;
        }

        public string DutyName {
            get {
                return _name;
            }
            set {
                _name = value;
            }
        }

        public DutyType DutyType {
            get {
                return _dutyType;
            }
            set {
                _dutyType = value;
            }
        }
    }

    public class Duties : ObservableCollection<Duty> {
        public Duties() {
            Add(new Duty("SALES", DutyType.OutSide));
            Add(new Duty("LOGISTICS", DutyType.OutSide));
            Add(new Duty("IT", DutyType.OutSide));
            Add(new Duty("MARKETING", DutyType.OutSide));
            Add(new Duty("HR", DutyType.OutSide));
            Add(new Duty("PROPRTION", DutyType.OutSide));
        }
    }
}
