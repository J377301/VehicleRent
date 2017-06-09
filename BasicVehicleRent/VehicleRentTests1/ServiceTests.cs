using Microsoft.VisualStudio.TestTools.UnitTesting;
using VehicleRent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRent.Tests
{
    [TestClass()]
    public class ServiceTests
    {       
       [TestMethod]
      
        public void getrequiredService()
        {
            //arrange
            double speedo = 100;
            int expected = 1;
            var test1 = new Service();

            //act
            double actual = test1.getrequiredService(speedo);

            //assert
            Assert.AreEqual(expected, actual);
            
        }
       
    }
}