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
    
    public partial class islemler
    {
        public int islemid { get; set; }
        public Nullable<int> muayeneid { get; set; }
        public string hastaadisoyadi { get; set; }
        public string hastatc { get; set; }
        public Nullable<int> tetkikid { get; set; }
        public string ilac { get; set; }
        public Nullable<int> ilacadet { get; set; }
        public Nullable<System.DateTime> islemtarihi { get; set; }
        public Nullable<bool> yatis { get; set; }
        public Nullable<int> islemiyapan { get; set; }
        public Nullable<int> kullanici { get; set; }
    
        public virtual kullanici_Yetki kullanici_Yetki { get; set; }
        public virtual muayene muayene { get; set; }
    }
}