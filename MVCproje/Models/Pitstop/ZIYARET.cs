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
    
    public partial class ZIYARET
    {
        public int VIZ_ID { get; set; }
        public Nullable<System.DateTime> VIZ_DATE { get; set; }
        public Nullable<byte> VIS_USR { get; set; }
        public Nullable<byte> VIZ_TYPE { get; set; }
        public Nullable<byte> VIZ_DEPT { get; set; }
        public string VIZ_DEALER { get; set; }
        public Nullable<System.DateTime> VIZ_AT_DATE { get; set; }
        public Nullable<byte> VIZ_DUR { get; set; }
        public Nullable<byte> VIZ_TO_DEPT { get; set; }
        public string VIZ_TO_WHY { get; set; }
        public string VIZ_EXP { get; set; }
        public string VIZ_STAFF { get; set; }
        public Nullable<byte> VIZ_STATE { get; set; }
        public string VIZ_RESULT { get; set; }
        public Nullable<System.DateTime> VIZ_UPD_DATE { get; set; }
    }
}
