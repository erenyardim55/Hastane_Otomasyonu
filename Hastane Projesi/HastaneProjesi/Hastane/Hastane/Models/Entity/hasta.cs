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
    
    public partial class hasta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hasta()
        {
            this.muayene = new HashSet<muayene>();
        }
    
        public int hastaid { get; set; }
        public string tc { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string dtarih { get; set; }
        public string cinsiyet { get; set; }
        public Nullable<int> kurum { get; set; }
        public string babaad { get; set; }
        public string annead { get; set; }
        public string adres { get; set; }
        public string ceptel { get; set; }
        public Nullable<int> kullanici { get; set; }
        public string email { get; set; }
        public string sifre { get; set; }
        public Nullable<int> randevuID { get; set; }
        public Nullable<int> kanGrubu { get; set; }
    
        public virtual kanGrubu kanGrubu1 { get; set; }
        public virtual kullanici_Yetki kullanici_Yetki { get; set; }
        public virtual randevu randevu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<muayene> muayene { get; set; }
    }
}
