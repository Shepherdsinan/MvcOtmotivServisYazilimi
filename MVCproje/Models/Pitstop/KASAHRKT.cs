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
    
    public partial class KASAHRKT
    {
        public System.DateTime TARIH { get; set; }
        public string REF_TIP { get; set; }
        public double HRKNO { get; set; }
        public double SIRANO { get; set; }
        public string HRK_TURU { get; set; }
        public string REFAYRTIP { get; set; }
        public string BELGE_NO { get; set; }
        public string KASAKOD { get; set; }
        public string KARSIKOD { get; set; }
        public string TIP { get; set; }
        public Nullable<double> TUTAR { get; set; }
        public Nullable<double> TUTAR_USD { get; set; }
        public Nullable<double> TUTAR_DVZ { get; set; }
        public Nullable<double> TL_KURDEGER { get; set; }
        public Nullable<double> TL_USDEGER { get; set; }
        public string PARA_BAZ { get; set; }
        public string DOVIZ_KOD { get; set; }
        public string ACIKLAMA { get; set; }
        public string ACIKLAMA1 { get; set; }
        public Nullable<short> AY { get; set; }
        public Nullable<short> YIL { get; set; }
        public Nullable<double> FIS_NO { get; set; }
        public Nullable<byte> ENT_KOD { get; set; }
        public Nullable<double> KDV { get; set; }
        public Nullable<double> KDVTUT { get; set; }
        public Nullable<System.DateTime> INS_DATE { get; set; }
        public string INS_USER { get; set; }
        public Nullable<System.DateTime> UPD_DATE { get; set; }
        public string UPD_USER { get; set; }
    }
}