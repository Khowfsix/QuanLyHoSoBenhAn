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
    
    public partial class Prescription
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Prescription()
        {
            this.CreatedPrescriptions = new HashSet<CreatedPrescription>();
            this.Prescription_Medicine = new HashSet<Prescription_Medicine>();
        }
    
        public string prescriptionID { get; set; }
        public string descriptionPrescription { get; set; }
        public Nullable<System.DateTime> createdAt { get; set; }
        public Nullable<System.DateTime> updatedAt { get; set; }
        public byte status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CreatedPrescription> CreatedPrescriptions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prescription_Medicine> Prescription_Medicine { get; set; }
    }
}
