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
    
    public partial class PERIYOTTUR
    {
        public int PER_ID { get; set; }
        public Nullable<int> PER_KATEGORI { get; set; }
        public string PER_TANIM { get; set; }
        public string PER_ACIKLAMA { get; set; }
        public string PER_BIRIM { get; set; }
        public Nullable<int> PER_SAYAC { get; set; }
        public Nullable<int> PER_AY { get; set; }
        public Nullable<System.DateTime> PER_BAS_TRH { get; set; }
    }
}
