//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class View_Patients
    {
        public string patientID { get; set; }
        public string patientFirstName { get; set; }
        public string patientLastname { get; set; }
        public string sex { get; set; }
        public System.DateTime birthDay { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string cardID { get; set; }
        public string patientJob { get; set; }
        public string healthInsurance { get; set; }
        public string reason { get; set; }
        public Nullable<System.DateTime> createdAt { get; set; }
        public Nullable<System.DateTime> updatedAt { get; set; }
    }
}
