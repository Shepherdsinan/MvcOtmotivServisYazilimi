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
    
    public partial class BINDOC
    {
        public int ROW_ID { get; set; }
        public string DOC_DESC { get; set; }
        public string DOC_NAME { get; set; }
        public Nullable<byte> DOC_GRP { get; set; }
        public Nullable<System.DateTime> DOC_DATE { get; set; }
        public string DOC_USER { get; set; }
        public byte[] DOC_BIN { get; set; }
        public Nullable<double> DOC_REF_ID { get; set; }
        public string DOC_REF_ID2 { get; set; }
    }
}
