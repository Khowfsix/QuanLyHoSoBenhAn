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
    
    public partial class Pay
    {
        public int payID { get; set; }
        public string patientID { get; set; }
        public string employeeID { get; set; }
        public string receiptID { get; set; }
        public Nullable<int> payTotal { get; set; }
        public byte status { get; set; }
        public Nullable<System.DateTime> createdAt { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Receipt Receipt { get; set; }
    }
}
