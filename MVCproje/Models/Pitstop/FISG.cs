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
    
    public partial class FISG
    {
        public double HRK_NO { get; set; }
        public Nullable<System.DateTime> TARIH { get; set; }
        public Nullable<System.DateTime> KYT_TRH { get; set; }
        public Nullable<double> ALACAK { get; set; }
        public Nullable<double> ALACAK_USD { get; set; }
        public Nullable<double> ALACAK_DVZ { get; set; }
        public Nullable<double> BORC { get; set; }
        public Nullable<double> BORC_USD { get; set; }
        public Nullable<double> BORC_DVZ { get; set; }
        public string DOVIZ_KODU { get; set; }
        public Nullable<double> DOVIZ_KUR { get; set; }
        public string TIP { get; set; }
        public Nullable<double> FIS_NO { get; set; }
        public string ACIKLAMA { get; set; }
        public Nullable<System.DateTime> INS_DATE { get; set; }
        public string INS_USER { get; set; }
        public Nullable<System.DateTime> UPD_DATE { get; set; }
        public string UPD_USER { get; set; }
    }
}