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
    
    public partial class POLIODE
    {
        public int POL_NO { get; set; }
        public short ODE_NO { get; set; }
        public System.DateTime ODE_TRH { get; set; }
        public string ODE_TIP { get; set; }
        public Nullable<short> TAKSIT_NO { get; set; }
        public Nullable<double> ODE_TUTAR { get; set; }
        public string ODE_SEKLI { get; set; }
        public string TAH_SEKLI { get; set; }
        public Nullable<double> TAH_REF { get; set; }
        public Nullable<System.DateTime> TAH_TRH { get; set; }
        public Nullable<double> TAH_TUTAR { get; set; }
        public Nullable<double> TAH_KALAN { get; set; }
        public string TAH_EDILDI { get; set; }
        public string TAH_PER { get; set; }
        public string HATIRLAT { get; set; }
        public string SIG_ODENDI { get; set; }
        public string ACIKLAMA { get; set; }
    }
}
