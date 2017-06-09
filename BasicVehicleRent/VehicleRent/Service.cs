using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRent
{
    public class Service
    {
        bool ServiceDone;
             

        public Service()
        {
            ServiceDone = true;
            
        }

        //Parameter Constructor
        public Service(bool pServiceDone)
        {
            bool ServiceDone = pServiceDone;
           
        }
        //Get Set Method
        public bool getServiceDone
        {
            get
            {
                return (ServiceDone);
            }
            set
            {

            }
        }

        public double getrequiredService(double speedo)
        {          
                return (speedo / 100);
                                  
        }
    }
}
