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
    
    public partial class PERCV
    {
        public int ROW_ID { get; set; }
        public Nullable<System.DateTime> INS_DATE { get; set; }
        public string INS_USER { get; set; }
        public Nullable<System.DateTime> UPD_DATE { get; set; }
        public string UPD_USER { get; set; }
        public Nullable<byte> STATU { get; set; }
        public string PER_KOD { get; set; }
        public Nullable<short> BOLUM { get; set; }
        public Nullable<short> SIRANO { get; set; }
        public Nullable<System.DateTime> TARIH1 { get; set; }
        public Nullable<System.DateTime> TARIH2 { get; set; }
        public string BILGI_TXT1 { get; set; }
        public string BILGI_TXT2 { get; set; }
        public string BILGI_TXT3 { get; set; }
        public string BILGI_TXT4 { get; set; }
        public Nullable<int> BILGI_INT1 { get; set; }
    }
}
