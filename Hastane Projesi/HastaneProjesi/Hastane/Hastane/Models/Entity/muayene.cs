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
    
    public partial class muayene
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public muayene()
        {
            this.islemler = new HashSet<islemler>();
        }
    
        public int muayeneid { get; set; }
        public Nullable<int> hastaid { get; set; }
        public Nullable<System.DateTime> muayenetarih { get; set; }
        public Nullable<int> poliklinik { get; set; }
        public string teshis { get; set; }
        public Nullable<bool> yatis { get; set; }
        public Nullable<System.DateTime> yatistarihi { get; set; }
        public Nullable<System.DateTime> yatisbitistarihi { get; set; }
        public string randevusaat { get; set; }
        public Nullable<System.DateTime> muayenebaslangici { get; set; }
        public Nullable<System.DateTime> muayenebitisi { get; set; }
        public Nullable<bool> muayeneonay { get; set; }
        public Nullable<int> kullanici { get; set; }
        public Nullable<int> randevuid { get; set; }
        public Nullable<bool> cikisonay { get; set; }
    
        public virtual hasta hasta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<islemler> islemler { get; set; }
        public virtual klinik klinik { get; set; }
        public virtual kullanici_Yetki kullanici_Yetki { get; set; }
    }
}
