using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Client1
{
    public class Vehicle
    {
        private string vehicle_No;
        private int wheel_Type;
        private string vehicle_Type;
        private int year;
        private string model;
        private string manufacturer;
        private string fuel_Capacity;

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

        public int Wheel_Type
        {
            get
            {
                return wheel_Type;
            }

            set
            {
                wheel_Type = value;
            }
        }

        public string Vehicle_Type
        {
            get
            {
                return vehicle_Type;
            }

            set
            {
                vehicle_Type = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return manufacturer;
            }

            set
            {
                manufacturer = value;
            }
        }

        public string Fuel_Capacity
        {
            get
            {
                return fuel_Capacity;
            }

            set
            {
                fuel_Capacity = value;
            }
        }
    }
}

       