using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRent
{
 
    public class Journey
    {

        int travelled;

        public Journey()
        {
           travelled = 0;
        }

        //Parameter constructor
        public Journey(int ptravelled)
        {
            int travelled = ptravelled;
        }

        //Get set method
        public int gettravelled
        {
            get
            {
                return (travelled);
            }
            set
            {
                travelled = value;
            }
        }
        
    }
    
}
