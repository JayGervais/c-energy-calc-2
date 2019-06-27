using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerData
{
    public class IndustrialCustomer : Customer
    {
        const decimal KWH_INDUST_PEAK = 0.065m;         // industrial peak hour charge per kWh after 1000 kWh
        const decimal KWH_INDUST_OFFPEAK = 0.028m;      // industrial off-peak hour charge per kWh after 1000 kWh
        const decimal KWH_PEAK_BASE_PRICE = 76.00m;     // industrial peak hour base charge
        const decimal KWH_OFF_PEAK_BASE_PRICE = 40.00m; // industrial off-peak hour base charge
        const decimal INDUST_BASE_HOURS = 1000m;        // base hours used to determine calculations

        public IndustrialCustomer(int accountNo, string customerName, char customerType, decimal kwh1, decimal kwh2 = 0) : base(accountNo, customerName, customerType, kwh1, kwh2)
        {
            this.AccountNo = AccountNo;
            this.CustomerName = CustomerName;
            this.CustomerType = CustomerType;
            this.Kwh1 = Kwh1;
            this.Kwh2 = Kwh2;
        }

        public IndustrialCustomer(Customer c)
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
            decimal peak;
            decimal offpeak;

            if (Kwh1 <= INDUST_BASE_HOURS)
            {
                peak = KWH_PEAK_BASE_PRICE;
            }
            else
            {
                peak = ((Kwh1 - INDUST_BASE_HOURS) * KWH_INDUST_PEAK) + KWH_PEAK_BASE_PRICE;
            }

            if (Kwh2 <= INDUST_BASE_HOURS)
            {
                offpeak = KWH_OFF_PEAK_BASE_PRICE;
            }
            else
            {
                offpeak = ((Kwh2 - INDUST_BASE_HOURS) * KWH_INDUST_OFFPEAK) + KWH_OFF_PEAK_BASE_PRICE;
            }
            
            return peak + offpeak;
        }
    }
}
