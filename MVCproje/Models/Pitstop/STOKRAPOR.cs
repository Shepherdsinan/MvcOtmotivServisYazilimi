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
    
    public partial class STOKRAPOR
    {
        public int KAYIT_ID { get; set; }
        public Nullable<double> STOK_NO { get; set; }
        public string STOK_KOD_NO { get; set; }
        public string STOK_ADI_TR { get; set; }
        public Nullable<double> MIKTAR { get; set; }
        public Nullable<double> MALIYET_FYT_TL { get; set; }
        public Nullable<double> SAT_FYT_TL { get; set; }
        public string RAF_YERI { get; set; }
        public Nullable<double> KRITIK_SEV { get; set; }
        public Nullable<short> REKABET { get; set; }
        public Nullable<int> KDV { get; set; }
    }
}