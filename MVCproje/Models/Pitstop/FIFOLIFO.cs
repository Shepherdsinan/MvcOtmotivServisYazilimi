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
    
    public partial class FIFOLIFO
    {
        public double STOK_NO { get; set; }
        public string DEPO_KODU { get; set; }
        public Nullable<System.DateTime> TARIH { get; set; }
        public string TIP { get; set; }
        public Nullable<double> REF { get; set; }
        public Nullable<System.DateTime> KTARIH { get; set; }
        public string KTIP { get; set; }
        public Nullable<double> KREF { get; set; }
        public Nullable<double> GIRMIK { get; set; }
        public Nullable<double> GIRTUT { get; set; }
        public Nullable<double> MALIYET { get; set; }
        public Nullable<double> CIKMIK { get; set; }
        public Nullable<double> CIKTUT { get; set; }
        public Nullable<double> GIRTUT_USD { get; set; }
        public Nullable<double> CIKTUT_USD { get; set; }
        public Nullable<double> MALIYET_USD { get; set; }
        public Nullable<double> GIRTUT_EUR { get; set; }
        public Nullable<double> CIKTUT_EUR { get; set; }
        public Nullable<double> MALIYET_EUR { get; set; }
    }
}
