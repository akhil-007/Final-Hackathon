//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Final
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class Master
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Master()
        {
            this.Transactions = new HashSet<Transaction>();
        }
    
        public string Vehicle_No { get; set; }
        public int Wheel_Type { get; set; }
        public string Vehicle_Type { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string Fuel_Capacity { get; set; }

        [JsonIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}