﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyCuaHangApp.Model
{
    using QuanLyCuaHangApp.ViewModel;
    using System;
    using System.Collections.Generic;

    public partial class GoodBU:BaseViewModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GoodBU()
        {
            this.InputInfoes = new HashSet<InputInfo>();
            this.OutputInfoes = new HashSet<OutputInfo>();
        }

        private int _id;
        public int Id { get { return _id; } set { _id = value; OnPropertyChanged(); } }
        private string _Good1;
        public string Good1 { get { return _Good1; } set { _Good1 = value; OnPropertyChanged(); } }
        private string _NameGoo;
        public string NameGoo { get { return _NameGoo; } set { _NameGoo = value; OnPropertyChanged(); } }
        private string _Producer;
        public string Producer { get { return _Producer; } set { _Producer = value; OnPropertyChanged(); } }
        private int _Numbers;
        public int Numbers { get { return _Numbers; } set { _Numbers = value; OnPropertyChanged(); } }
        private string _Warranty;
        public string Warranty { get { return _Warranty; } set { _Warranty = value; OnPropertyChanged(); } }
        private string _Unit;
        public string Unit { get { return _Unit; } set { _Unit = value; OnPropertyChanged(); } }
        private string _Statuss;
        public string Statuss { get { return _Statuss; } set { _Statuss = value; OnPropertyChanged(); } }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InputInfo> InputInfoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OutputInfo> OutputInfoes { get; set; }
    }
}