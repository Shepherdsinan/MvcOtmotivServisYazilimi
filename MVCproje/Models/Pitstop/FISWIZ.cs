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
    
    public partial class FISWIZ
    {
        public int SB_NO { get; set; }
        public Nullable<byte> SB_TIP { get; set; }
        public string SB_ADI { get; set; }
        public Nullable<System.DateTime> SB_TRH1 { get; set; }
        public Nullable<System.DateTime> SB_TRH2 { get; set; }
        public string SB_ACIKLAMA { get; set; }
        public Nullable<byte> SB_DONEM { get; set; }
    }
}