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
    
    public partial class VERSIPDE
    {
        public double SIP_NO { get; set; }
        public int SIRA_NO { get; set; }
        public string STOK_KODU { get; set; }
        public string STOK_ADI { get; set; }
        public double STOK_NO { get; set; }
        public Nullable<System.DateTime> TESLIM_TRH { get; set; }
        public double SIP_MIK { get; set; }
        public double BRM_FYT { get; set; }
        public double SIP_TUTAR { get; set; }
        public double KDV { get; set; }
        public double BACK_ORDER { get; set; }
        public double SON_GELEN { get; set; }
        public double GELEN_MIK { get; set; }
        public string IS_EMRI_NO { get; set; }
        public string ACIKLAMA { get; set; }
        public Nullable<double> FIYAT_USD { get; set; }
        public Nullable<double> FYT_DOVIZ { get; set; }
        public string DOVIZ_KODU { get; set; }
        public Nullable<double> TL_KURDEGER { get; set; }
        public Nullable<short> IE_SIRANO { get; set; }
        public Nullable<System.DateTime> INS_DATE { get; set; }
        public string INS_USER { get; set; }
        public Nullable<System.DateTime> UPD_DATE { get; set; }
        public string UPD_USER { get; set; }
        public string KDV_DAHIL { get; set; }
        public Nullable<double> CLAIMNO { get; set; }
        public Nullable<short> CI_SIRANO { get; set; }
        public Nullable<decimal> ALIS_SON_FYT { get; set; }
    }
}