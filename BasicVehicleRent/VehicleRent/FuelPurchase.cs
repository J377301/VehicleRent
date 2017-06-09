using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRent
{
    public class FuelPurchase
    {
        //Declare attribute
        private double fuelAmount;
        private double fuelCost;

        public FuelPurchase()
        {
            fuelAmount = 0;
            fuelCost = 0;
        }

        //parameter constructor
        public FuelPurchase(double pfuelAmount, double pfuelCost)
        {
            fuelAmount = pfuelAmount;
            fuelCost = pfuelCost;
        }

        //get set method
        public double getfuelAmount
        {
            get
            {
                return (fuelAmount);
            }
            set
            {
                fuelAmount = value;
            }
        }

        public double getfuelCost
        {
            get
            {
                return (fuelCost);
            }
            set
            {
                fuelCost = value;
            }
        }
    }
}
