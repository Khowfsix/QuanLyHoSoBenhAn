//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class UsingService
    {
        public int usingServiceID { get; set; }
        public string patientID { get; set; }
        public string serviceID { get; set; }
        public Nullable<byte> quantity { get; set; }
        public byte status { get; set; }
        public Nullable<System.DateTime> createdAt { get; set; }
    
        public virtual Patient Patient { get; set; }
        public virtual Service Service { get; set; }
    }
}
