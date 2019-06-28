using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerData
{
    public class ResidentialCustomer : Customer
    {
        const decimal KWH_RESIDENTIAL = 0.052m;              // residential charge per kWh
        const decimal KWH_RESIDENTIAL_BASE_PRICE = 6.00m;    // residential base price

        // residential customer constructor
        public ResidentialCustomer(int accountNo, string customerName, char customerType, decimal kwh1, decimal kwh2 = 0) :base(accountNo, customerName, customerType, kwh1, kwh2)
        {
            this.AccountNo = AccountNo;
            this.CustomerName = CustomerName;
            this.CustomerType = CustomerType;
            this.Kwh1 = Kwh1;
            this.Kwh2 = Kwh2;
        }

        // create new residential customer method
        public ResidentialCustomer(Customer c)
        {
            this.AccountNo = c.AccountNo;
            this.CustomerName = c.CustomerName;
            this.CustomerType = c.CustomerType;
            this.Kwh1 = c.Kwh1;
            this.Kwh2 = c.Kwh2;
            CustomerCharge = CalculateCharge();
        }

        // tostring override method to display residential customer data
        public override string ToString()
        {
            return AccountNo + "\t" + CustomerName + "\t" + CustomerType + "\t" + CustomerCharge.ToString("C");
        }

        // residential calculation override
        public override decimal CalculateCharge()
        {
            return (KWH_RESIDENTIAL * Kwh1) + KWH_RESIDENTIAL_BASE_PRICE;
        } 
            
    }
}
