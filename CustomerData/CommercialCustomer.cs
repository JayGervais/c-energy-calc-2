using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerData
{
    public class CommercialCustomer : Customer
    {
        const decimal KWH_COMMERCIAL = 0.045m;          // commercial charge per kWh after 1000 kWh
        const decimal KWH_COMM_BASE_PRICE = 60.00m;     // commercial flat rate
        const decimal BASE_HOURS = 1000m;               // base hours used to determine calculations

        public CommercialCustomer(int accountNo, string customerName, char customerType, decimal kwh1, decimal kwh2) : base(accountNo, customerName, customerType, kwh1, kwh2)
        {
            this.AccountNo = AccountNo;
            this.CustomerName = CustomerName;
            this.CustomerType = CustomerType;
            this.Kwh1 = Kwh1;
            this.Kwh2 = Kwh2;
        }

        public CommercialCustomer(Customer c)
        {
            this.AccountNo = c.AccountNo;
            this.CustomerName = c.CustomerName;
            this.CustomerType = c.CustomerType;
            this.Kwh1 = c.Kwh1;
            this.Kwh2 = c.Kwh2;
            CustomerCharge = CalculateCharge();
        }

        public override string ToString()
        {
            return AccountNo + "\t" + CustomerName + "\t" + CustomerType + "\t" + CustomerCharge.ToString("C");
        }

        public override decimal CalculateCharge()
        {
            if (Kwh1 > BASE_HOURS)
            {
                return ((Kwh1 - BASE_HOURS) * KWH_COMMERCIAL) + KWH_COMM_BASE_PRICE;
            }
            else
            {
                return KWH_COMM_BASE_PRICE;
            }
        }
    }
}
