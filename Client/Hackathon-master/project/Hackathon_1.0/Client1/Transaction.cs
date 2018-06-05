using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Client1
{
    public class Transaction
    {
        private int trip_Id;
        private string vehicle_No;
        private string address_Start;
        private string address_End;

        private string gps_Start;
            private string gps_End;
        private string ride_Type;
        private float fuel_Cost_Litre;
        private float distance;
        private System.DateTime start_Date;
        private System.DateTime end_Date;
        private string ac;

        public int Trip_Id
        {
            get
            {
                return trip_Id;
            }

            set
            {
                trip_Id = value;
            }
        }

        public string Vehicle_No
        {
            get
            {
                return vehicle_No;
            }

            set
            {
                vehicle_No = value;
            }
        }

        public string Address_Start
        {
            get
            {
                return address_Start;
            }

            set
            {
                address_Start = value;
            }
        }

        public string Address_End
        {
            get
            {
                return address_End;
            }

            set
            {
                address_End = value;
            }
        }

        public string Gps_Start
        {
            get
            {
                return gps_Start;
            }

            set
            {
                gps_Start = value;
            }
        }

        public string Gps_End
        {
            get
            {
                return gps_End;
            }

            set
            {
                gps_End = value;
            }
        }

        public string Ride_Type
        {
            get
            {
                return ride_Type;
            }

            set
            {
                ride_Type = value;
            }
        }

        public float Fuel_Cost_Litre
        {
            get
            {
                return fuel_Cost_Litre;
            }

            set
            {
                fuel_Cost_Litre = value;
            }
        }

        public float Distance
        {
            get
            {
                return distance;
            }

            set
            {
                distance = value;
            }
        }

        public DateTime Start_Date
        {
            get
            {
                return start_Date;
            }

            set
            {
                start_Date = value;
            }
        }

        public DateTime End_Date
        {
            get
            {
                return end_Date;
            }

            set
            {
                end_Date = value;
            }
        }

        public string Ac
        {
            get
            {
                return ac;
            }

            set
            {
                ac = value;
            }
        }
    }
}