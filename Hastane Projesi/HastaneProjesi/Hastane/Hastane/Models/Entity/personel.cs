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
    
    public partial class personel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public personel()
        {
            this.doktor = new HashSet<doktor>();
            this.izin = new HashSet<izin>();
            this.kullanici_Yetki = new HashSet<kullanici_Yetki>();
        }
    
        public int personelid { get; set; }
        public string tc { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string ceptel { get; set; }
        public string adres { get; set; }
        public Nullable<System.DateTime> dtarih { get; set; }
        public string sicilno { get; set; }
        public Nullable<int> unvan { get; set; }
        public string diplomano { get; set; }
        public string mezuniyet { get; set; }
        public Nullable<int> kullanilanizin { get; set; }
        public Nullable<int> kalanizin { get; set; }
        public string cinsiyet { get; set; }
        public Nullable<System.DateTime> izinbitis { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<doktor> doktor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<izin> izin { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<kullanici_Yetki> kullanici_Yetki { get; set; }
        public virtual unvan unvan1 { get; set; }
    }
}
