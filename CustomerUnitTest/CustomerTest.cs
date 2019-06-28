using System;
using CustomerData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerUnitTest
{
    [TestClass()]
    public class CustomerTest
    {
        [TestMethod()] 
        // testing that zero value is being added for KWH2 for residential calculations
        public void ResidentialKWH2ZeroValue()
        {
            int acctnum = 1111;
            string custName = "John Doe";
            char custType = 'R';
            decimal expectedkwh2value = 0;
            decimal kwhvalue = 1500;
            decimal kwhvalue2 = 0;

            Customer calc = new ResidentialCustomer(acctnum, custName, custType, kwhvalue, kwhvalue2);
            Assert.AreEqual(expectedkwh2value, kwhvalue2);
        }

        [TestMethod()]
        // testing that zero value is being added for KWH2 for industrial calculations
        public void IndustrialKWH2ZeroValue()
        {
            int acctnum = 1111;
            string custName = "John Doe";
            char custType = 'R';
            decimal expectedkwh2value = 0;
            decimal kwhvalue = 1500;
            decimal kwhvalue2 = 0;

            Customer calc = new IndustrialCustomer(acctnum, custName, custType, kwhvalue, kwhvalue2);
            Assert.AreEqual(expectedkwh2value, kwhvalue2);
        }

        [TestMethod()]
        // testing expected value for residential calculation
        public void ResidentialCalcValue()
        {
            int acctnum = 1111;
            string custName = "John Doe";
            char custType = 'R';
            decimal kwhvalue = 1500;
            decimal kwhvalue2 = 0;

            decimal expectedvalue = 84.00m;
            decimal actualvalue;

            Customer res = new Customer(acctnum, custName, custType, kwhvalue, kwhvalue2);
            actualvalue = res.CalculateCharge();
            Assert.AreEqual(expectedvalue, actualvalue);
        }

        [TestMethod()]
        // testing calculation expected value for residential when KWH is zero
        public void ResidentialCalcZero()
        {
            int acctnum = 1111;
            string custName = "John Doe";
            char custType = 'R';
            decimal kwhvalue = 0;
            decimal kwhvalue2 = 0;

            decimal expectedvalue = 6.00m;
            decimal actualvalue;

            Customer res = new Customer(acctnum, custName, custType, kwhvalue, kwhvalue2);
            actualvalue = res.CalculateCharge();
            Assert.AreEqual(expectedvalue, actualvalue);
        }

        [TestMethod()]
        // testing expected value for commercial calculation
        public void CommercialCalcValue()
        {
            int acctnum = 1111;
            string custName = "John Doe";
            char custType = 'C';
            decimal kwhvalue = 1500;
            decimal kwhvalue2 = 0;

            decimal expectedvalue = 82.5m;
            decimal actualvalue;

            Customer com = new Customer(acctnum, custName, custType, kwhvalue, kwhvalue2);
            actualvalue = com.CalculateCharge();
            Assert.AreEqual(expectedvalue, actualvalue);
        }

        [TestMethod()]
        // testing expected value for commercial when KWH is zero
        public void CommercialCalcZero()
        {
            int acctnum = 1111;
            string custName = "John Doe";
            char custType = 'C';
            decimal kwhvalue = 0;
            decimal kwhvalue2 = 0;

            decimal expectedvalue = 60.00m;
            decimal actualvalue;

            Customer com = new Customer(acctnum, custName, custType, kwhvalue, kwhvalue2);
            actualvalue = com.CalculateCharge();
            Assert.AreEqual(expectedvalue, actualvalue);
        }

        [TestMethod()]
        // testing expected value for industrial calculation
        public void IndustCalcValue()
        {
            int acctnum = 1111;
            string custName = "John Doe";
            char custType = 'I';
            decimal kwhvalue = 1500;
            decimal kwhvalue2 = 1500;

            decimal expectedvalue = 162.50m;
            decimal actualvalue;

            Customer indust = new Customer(acctnum, custName, custType, kwhvalue, kwhvalue2);
            actualvalue = indust.CalculateCharge();
            Assert.AreEqual(expectedvalue, actualvalue);
        }

        [TestMethod()]
        // testing  expected value for commercial when KWH1 and KWH2 is zero
        public void IndustCalcZero()
        {
            int acctnum = 1111;
            string custName = "John Doe";
            char custType = 'I';
            decimal kwhvalue = 0;
            decimal kwhvalue2 = 0;

            decimal expectedvalue = 116.00m;
            decimal actualvalue;

            Customer indust = new Customer(acctnum, custName, custType, kwhvalue, kwhvalue2);
            actualvalue = indust.CalculateCharge();
            Assert.AreEqual(expectedvalue, actualvalue);
        }

        [TestMethod()]
        // testing calculation expected value for industrial when KWH1 is zero
        public void IndustCalcKWH1Zero()
        {
            int acctnum = 1111;
            string custName = "John Doe";
            char custType = 'I';
            decimal kwhvalue = 0;
            decimal kwhvalue2 = 1500;

            decimal expectedvalue = 130.00m;
            decimal actualvalue;

            Customer indust = new Customer(acctnum, custName, custType, kwhvalue, kwhvalue2);
            actualvalue = indust.CalculateCharge();
            Assert.AreEqual(expectedvalue, actualvalue);
        }

        [TestMethod()]
        // testing calculation expected value for industrial when KWH2 is zero
        public void IndustCalcKWH2Zero()
        {
            int acctnum = 1111;
            string custName = "John Doe";
            char custType = 'I';
            decimal kwhvalue = 1500;
            decimal kwhvalue2 = 0;

            decimal expectedvalue = 148.50m;
            decimal actualvalue;

            Customer indust = new Customer(acctnum, custName, custType, kwhvalue, kwhvalue2);
            actualvalue = indust.CalculateCharge();
            Assert.AreEqual(expectedvalue, actualvalue);
        }
    }
}
