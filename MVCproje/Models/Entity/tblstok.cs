//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCproje.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblstok
    {
        public int ıd { get; set; }
        public string urunadi { get; set; }
        public int kategorid { get; set; }
        public string marka { get; set; }
        public string stok { get; set; }
    
        public virtual tblkategori tblkategori { get; set; }
    }
}