//------------------------------------------------------------------------------
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
    
    public partial class StaffBU : BaseViewModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StaffBU()
        {
            this.Inputs = new HashSet<Input>();
            this.Outputs = new HashSet<Output>();
        }

        private int _id;
        public int Id { get { return _id; } set { _id = value; OnPropertyChanged(); } }
        private int _yearBirth;
        public int YearBirth { get { return _yearBirth; } set { _yearBirth = value; OnPropertyChanged(); } }
        private string _Staff1;
        public string Staff1 { get { return _Staff1; } set { _Staff1 = value; OnPropertyChanged(); } }
        private string _NameSta;
        public string NameSta { get { return _NameSta; } set { _NameSta = value; OnPropertyChanged(); } }
        private string _sex;
        public string Sex { get { return _sex; } set { _sex = value; OnPropertyChanged(); } }
        private string _AddressSta;
        public string AddressSta { get { return _AddressSta; } set { _AddressSta = value; OnPropertyChanged(); } }
        private string _Phone;
        public string Phone { get { return _Phone; } set { _Phone = value; OnPropertyChanged(); } }
        private string _Position;
        public string Position { get { return _Position; } set { _Position = value; OnPropertyChanged(); } }
        private int? _salary;
        public Nullable<int> Salary { get { return _salary; } set { _salary = value; OnPropertyChanged(); } }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Input> Inputs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Output> Outputs { get; set; }
    }
}