//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCproje.Models.Pitstop
{
    using System;
    using System.Collections.Generic;
    
    public partial class AKTIFZ
    {
        public short YIL { get; set; }
        public short HAFTA { get; set; }
        public string BASLIK { get; set; }
        public string ACIKLAMA { get; set; }
        public string ACIKLAMA2 { get; set; }
        public Nullable<short> HEDEF { get; set; }
        public Nullable<short> GERCEK { get; set; }
        public Nullable<byte> STATU { get; set; }
        public Nullable<System.DateTime> GON_TRH { get; set; }
        public Nullable<System.DateTime> CEVAP_TRH { get; set; }
        public string CEVAP_PER { get; set; }
        public string CEVAP_NOT { get; set; }
        public string INS_PER { get; set; }
        public Nullable<System.DateTime> INS_TRH { get; set; }
        public string UPD_PER { get; set; }
        public Nullable<System.DateTime> UPD_TRH { get; set; }
    }
}