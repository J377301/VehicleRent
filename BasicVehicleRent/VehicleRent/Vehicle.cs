using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRent
{
    public class Vehicle
    {
        //Declared attributes
        private string manufacturer;
        private string model;
        private int makeYear;
        private string registration;
        private int vehicleId;

        public Journey journey { get; set; }
        public FuelPurchase fuelpurchased { get; set; }

        //default constructor
        public Vehicle()
        {

        }

        //paramater constructor
        public Vehicle(string pManufacturer, string pModel, int pMakeYear, string pRegistration, Journey pjourney, FuelPurchase pfuelpurchashed)
        {
            manufacturer = pManufacturer;
            model = pModel;
            makeYear = pMakeYear;
            registration = pRegistration;
            journey = pjourney;
            fuelpurchased = pfuelpurchashed;
        }

        //get set methods for the properties 

        public string getManufacturer
        {
            get
            {
                return (manufacturer);
            }
            set
            {
                manufacturer = value;
            }
        }
        public string getModel
        {
            get
            {
                return (model);
            }
            set
            {
                model = value;
            }
        }
        public int getMakeYear
        {
            get
            {
                return (makeYear);
            }
            set
            {
                makeYear = value;
            }
        }
        public string getRegistration
        {
            get
            {
                return (registration);
            }
            set
            {
                registration = value;
            }
        }
        public int getId
        {
            get
            {
                return (vehicleId);
            }
            set
            {
                vehicleId = value;
            }
        }
      

       
        //Override variables from  class and covert to string 
        public override string ToString()
        {
            return "Vehicle Id: " + vehicleId + "\r\n"+
                    "Manufacturer: " + manufacturer +
                    "Model: " + model +
                    "Make Year:" + makeYear +
                    "Registration:" + registration;
                    
        }

        public void addJourney()
        {
            
        }

        public void addFuelPurchased()
        {

        }
    }
}
