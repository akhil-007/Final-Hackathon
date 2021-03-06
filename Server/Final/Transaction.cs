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
    
    public partial class Transaction
    {
        public int Trip_Id { get; set; }
        public string Vehicle_No { get; set; }
        public string Address_Start { get; set; }
        public string Address_End { get; set; }
        public string Ride_Type { get; set; }
        public decimal Fuel_Cost_Litre { get; set; }
        public double Distance { get; set; }
        public System.DateTime Start_Date { get; set; }
        public System.DateTime End_Date { get; set; }
        public string AC { get; set; }
        public int Fuel { get; set; }
        public double Mileage { get; set; }
        public Nullable<double> Rate_km { get; set; }

        [JsonIgnore]
        public virtual Master Master { get; set; }
    }
}
