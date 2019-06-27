using System;

namespace CustomerData
{
    public class Customer
    {
        // private data
        int accountNo;
        string customerName;
        char customerType;
        decimal kwh1;
        decimal kwh2;
        decimal customerCharge;

        // public properties
        public int AccountNo
        {
            get
            { return accountNo; }
            set 
            { accountNo = value; }
        }

        public string CustomerName
        {
            get
            { return customerName; }
            set
            { customerName = value; }
        }

        public char CustomerType
        {
            get
            { return customerType; }
            set
            { customerType = value; }
        }

        public decimal Kwh1
        {
            get
            { return kwh1; }
            set
            { kwh1 = value; }
        }

        public decimal Kwh2
        {
            get
            { return kwh2; }
            set
            { kwh2 = value; }
        }

        public decimal CustomerCharge
        {
            get
            { return customerCharge; }
            set
            { customerCharge = value; }
        }

        public Customer() { }

        public Customer(int accountNo, string customerName, char customerType, decimal kwh1, decimal kwh2 = 0)
        {
            this.accountNo = accountNo;
            this.customerName = customerName;
            this.customerType = customerType;
            this.kwh1 = kwh1;
            this.kwh2 = kwh2;
            CustomerCharge = CalculateCharge();
        }

        public virtual decimal CalculateCharge()
        {
            if(this.customerType == 'R')
            {
                Customer c = new ResidentialCustomer(accountNo, customerName, customerType, kwh1, kwh2);
                return c.CalculateCharge();
            }
            else if(this.customerType == 'C')
            {
                Customer c = new CommercialCustomer(accountNo, customerName, customerType, kwh1, kwh2);
                return c.CalculateCharge();
            }
            else if(this.customerType == 'I')
            {
                Customer c = new IndustrialCustomer(accountNo, customerName, customerType, kwh1, kwh2);
                return c.CalculateCharge();
            }
            return 0;
        }

        // tostring method
        public override string ToString()
        {
            return accountNo.ToString() + "\t" + customerName + "\t" + customerType + "\t" + CustomerCharge.ToString("C");
        }

    }
}
