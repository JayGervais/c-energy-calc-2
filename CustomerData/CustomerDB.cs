using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CustomerData
{

    public static class CustomerDB
    {
        // path to customer text file
        const string path = "Customers.txt";

        // customer list for reading data
        public static List<Customer> ReadCustomers()
        {
            // create an empty customer list
            List<Customer> customerList = new List<Customer>();
            // new Filestream
            FileStream fs = null;
            // new StreamReader
            StreamReader sr = null;
            Customer c; // for reading
            string line;
            string[] fields;
            try
            {
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
                sr = new StreamReader(fs);

                while (!sr.EndOfStream)// while there is data
                {
                    line = sr.ReadLine();
                    fields = line.Split(','); // split sections by commas
                    c = new Customer(); // initializes customer object
                    c.AccountNo = Convert.ToInt32(fields[0].Trim());
                    c.CustomerName = Convert.ToString(fields[1].Trim());
                    c.CustomerType = Convert.ToChar(fields[2].Trim());
                    c.CustomerCharge = Convert.ToDecimal(fields[3]);
                    customerList.Add(c);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally // always execute
            {
                if (fs != null) fs.Close(); // close file
            }
            return customerList;
        }

        // public method for saving customer data to list
        public static void SaveCustomers(List<Customer> list)
        {
            FileStream fs = null;
            StreamWriter sw = null;
            string line;

            try
            {
                fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs);
                foreach (Customer c in list)     // for each customer in the list
                {
                    line = c.AccountNo.ToString() + ", " + c.CustomerName.ToString() + ", " +
                        c.CustomerType.ToString() + ", " + c.CustomerCharge;  // make a line with data
                    sw.WriteLine(line);         // and write it to the file
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sw != null) sw.Close(); // stream writer requires closing!
                if (fs != null) fs.Close();
            }
        }
    }
}
