//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyCuaHangApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Input
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Input()
        {
            this.InputInfoes = new HashSet<InputInfo>();
        }
    
        public string Input1 { get; set; }
        public System.DateTime DateIn { get; set; }
        public string Staffs { get; set; }
        public string Supliers { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InputInfo> InputInfoes { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual Suplier Suplier { get; set; }
    }
}
