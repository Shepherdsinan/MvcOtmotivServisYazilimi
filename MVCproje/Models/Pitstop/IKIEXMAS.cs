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
    
    public partial class IKIEXMAS
    {
        public int DOSYA_NO { get; set; }
        public string DOSYA_KOD { get; set; }
        public string CARI_KOD { get; set; }
        public string SASI_NO { get; set; }
        public System.DateTime EXPERTIZ_TAR { get; set; }
        public string GENEL_GORUN { get; set; }
        public string BAKIM_GEREK { get; set; }
        public string YEDEK_ANAHTAR { get; set; }
        public string KATALITIK { get; set; }
        public Nullable<double> KM { get; set; }
        public string MUAYENE_OK { get; set; }
        public Nullable<double> TOPLAM_KAP { get; set; }
        public Nullable<double> TOPLAM_MEK { get; set; }
        public Nullable<double> TOPLAM_AKS { get; set; }
        public Nullable<double> TOPLAM_OPS { get; set; }
        public Nullable<double> TOPLAM_LAS { get; set; }
        public Nullable<double> TOPLAM_DIG1 { get; set; }
        public Nullable<double> TOPLAM_DIG2 { get; set; }
        public Nullable<double> TOPLAM_PAR { get; set; }
        public Nullable<double> TOPLAM_ISC { get; set; }
        public Nullable<double> TOPLAM_GEN { get; set; }
    }
}