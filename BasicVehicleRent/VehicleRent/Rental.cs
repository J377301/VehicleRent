using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRent
{
    public class Rental
    {
        int perKm;
        int perDay;
        int numberofDays;
        int KMperRental;

        //Default Value
        public Rental()
        {
            perKm = 1;
            perDay = 100;
            numberofDays = 0;
            KMperRental = 0;
        }

        //Parameter Constructor
        public Rental(int PperKm, int PperDay, int PnumberofDays, int PKmperRental)
        {
            int perKm = PperKm;
            int perDay = PperDay;
            int numberofDays = PnumberofDays;
            int KmperRental = PKmperRental;
        }

        //Get set method
        public int getperKm
        {
            get
            {
                return (perKm);
            }
            set
            {
                perKm = value;
            }
        }

        public int getperDay
        {
            get
            {
                return (perDay);
            }
            set
            {
                perDay = value;
            }
        }
        public int getnumberofDays
        {
            get
            {
                return (numberofDays);
            }
            set
            {
                numberofDays = value;
            }
        }
        public int getKmperRental
        {
            get
            {
                return (KMperRental);
            }
            set
            {
                KMperRental = value;
            }
        }
    }
}
