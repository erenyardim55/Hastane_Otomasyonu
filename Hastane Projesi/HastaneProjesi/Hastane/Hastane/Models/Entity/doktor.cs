//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hastane.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class doktor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public doktor()
        {
            this.mesajgiden = new HashSet<mesajgiden>();
        }
    
        public int drid { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string brans { get; set; }
        public string branskod { get; set; }
        public string diplomano { get; set; }
        public string tc { get; set; }
        public Nullable<int> klinik { get; set; }
        public Nullable<int> personelID { get; set; }
        public Nullable<bool> izindeMi { get; set; }
    
        public virtual klinik klinik1 { get; set; }
        public virtual personel personel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mesajgiden> mesajgiden { get; set; }
    }
}
