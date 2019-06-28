using CustomerData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * 
 * CPRG 200 Part 2: Lab Assignment 2
 * Calculate customer bill for city power company
 * Author: Jay Gervais
 * Date: July 9, 2019
 *
 */

namespace Lab1_PowerBill
{
    public partial class powerBillForm : Form
    {
        // declaring customer variables
        private decimal kwh1; // kwh used/peak hours
        private decimal kwh2; // off-peak hours
        private int accountNo; // customer account number
        private string customerName; // customer name
        private char customerType; // customer type (residential, commercial, industrial)

        // declare customer list
        List<Customer> myCustomers;

        public powerBillForm()
        {
            InitializeComponent();
        }

        // combo box that selects customer type
        private void CboxCustType_SelectedIndexChanged(object sender, EventArgs e)
        // forms are hidden or displayed based on customer type
        {
            switch (cboxCustType.SelectedIndex)
            {
                case 0: // residential
                    gBKwhUsed.Visible = true;
                    gBoxIndust.Visible = false;
                    this.ActiveControl = txtCustName;
                    break;
                case 1: //commercial
                    gBKwhUsed.Visible = true;
                    gBoxIndust.Visible = false;
                    this.ActiveControl = txtCustName;
                    break;
                case 2: // industrial
                    gBoxIndust.Visible = true;
                    gBKwhUsed.Visible = false;
                    this.ActiveControl = txtCustName;
                    break;
            }
        }

        private void PowerBillForm_Load(object sender, EventArgs e)
        {   // displays residential form and activates input upon form load
            myCustomers = CustomerDB.ReadCustomers();
            DisplayCustomers();

            cboxCustType.SelectedIndex = 0;     // select residential on load
            this.ActiveControl = txtCustName;    // make text input active
            gBKwhUsed.Visible = true;        // hide residential and commercial panel
            gBoxIndust.Visible = false;    // hide industrial panel
        }

        private void DisplayCustomers()
        {   // displays all customers
            lstCustomer.Items.Clear(); // empty the list box
            // loop through all customers in list
            foreach (Customer c in myCustomers)
                lstCustomer.Items.Add(c);
            // display total amounts
            txtCustomerTotal.Text = myCustomers.Count.ToString(); // number of customers
            txtTotalCharges.Text = CalculateCustomerTotal().ToString("C"); // total charges
            txtResTotal.Text = CustomerTypeCalc('R').ToString("C"); // residential total
            txtCommTotal.Text = CustomerTypeCalc('C').ToString("C"); // commercial total
            txtIndustTotal.Text = CustomerTypeCalc('I').ToString("C"); // industrial total
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {   // create new customer type based on selection
            switch (cboxCustType.SelectedIndex)
            {
                case 0: // residential

                    // set customer type
                    customerType = 'R';
                    this.ActiveControl = txtCustName;

                    if (// validating customer name
                        Validator.IsNotEmpty(txtCustName, "Customer name") &&
                        // validating account number
                        Validator.IsNotEmpty(txtAcctNum, "Account number") &&
                        Validator.IsInteger(txtAcctNum, "Account number") &&
                        Validator.IsNonNegativeInt(txtAcctNum, "Account number") &&
                        // validating KWH Total
                        Validator.IsNotEmpty(txtKwhUsed, "kWh") &&
                        Validator.IsInteger(txtKwhUsed, "kWh") &&
                        Validator.IsNonNegativeInt(txtKwhUsed, "kWh"))
                    {
                        // set text values to customer variables
                        kwh1 = Convert.ToDecimal(txtKwhUsed.Text);
                        accountNo = Convert.ToInt32(txtAcctNum.Text);
                        customerName = Convert.ToString(txtCustName.Text);
                        // create new customer object
                        ResidentialCustomer newResCust = new ResidentialCustomer(accountNo, customerName, customerType, kwh1, kwh2=0);
                        myCustomers.Add(newResCust); // add to list
                        CustomerDB.SaveCustomers(myCustomers);
                        DisplayCustomers();
                        ClearFields();
                    }
                    break;
                case 1: //commercial

                    // set customer type
                    customerType = 'C';
                    this.ActiveControl = txtCustName;

                    if (// validating customer name
                        Validator.IsNotEmpty(txtCustName, "Customer name") &&
                        // validating account number
                        Validator.IsNotEmpty(txtAcctNum, "Account number") &&
                        Validator.IsInteger(txtAcctNum, "Account number") &&
                        Validator.IsNonNegativeInt(txtAcctNum, "Account number") &&
                        // validating KWH Total
                        Validator.IsNotEmpty(txtKwhUsed, "kWh") &&
                        Validator.IsInteger(txtKwhUsed, "kWh") &&
                        Validator.IsNonNegativeInt(txtKwhUsed, "kWh"))
                    {
                        // set text values to customer variables
                        kwh1 = Convert.ToDecimal(txtKwhUsed.Text);
                        accountNo = Convert.ToInt32(txtAcctNum.Text);
                        customerName = Convert.ToString(txtCustName.Text);
                        // create new customer object
                        CommercialCustomer newComCust = new CommercialCustomer(accountNo, customerName, customerType, kwh1, kwh2 = 0);
                        myCustomers.Add(newComCust); // add to list
                        CustomerDB.SaveCustomers(myCustomers);
                        DisplayCustomers();
                        ClearFields();
                    }
                    break;
                case 2: // industrial

                    // set customer type
                    customerType = 'I';
                    this.ActiveControl = txtCustName;
  
                    if (// validating customer name
                        Validator.IsNotEmpty(txtCustName, "Customer name") &&
                        // validating account number
                        Validator.IsNotEmpty(txtAcctNum, "Account number") &&
                        Validator.IsInteger(txtAcctNum, "Account number") &&
                        Validator.IsNonNegativeInt(txtAcctNum, "Account number") &&
                        // validation Peak Hours
                        Validator.IsNotEmpty(txtPeakHours, "Peak Hours") &&
                        Validator.IsInteger(txtPeakHours, "Peak Hours") &&
                        Validator.IsNonNegativeInt(txtPeakHours, "Peak Hours") &&
                        // validation Off-Peak Hours
                        Validator.IsNotEmpty(txtOffPeakHours, "Off-Peak Hours") &&
                        Validator.IsInteger(txtOffPeakHours, "Off-Peak Hours") &&
                        Validator.IsNonNegativeInt(txtOffPeakHours, "Off-Peak Hours"))
                    {
                        // set text values to customer variables
                        kwh1 = Convert.ToDecimal(txtPeakHours.Text);
                        kwh2 = Convert.ToDecimal(txtOffPeakHours.Text);
                        accountNo = Convert.ToInt32(txtAcctNum.Text);
                        customerName = Convert.ToString(txtCustName.Text);
                        // create new customer object
                        IndustrialCustomer newIndusCust = new IndustrialCustomer(accountNo, customerName, customerType, kwh1, kwh2);
                        myCustomers.Add(newIndusCust); // add to list       
                        CustomerDB.SaveCustomers(myCustomers);
                        DisplayCustomers();
                        ClearFields();
                    }
                    break;
            }
        }

        // display total for all customers
        private decimal CalculateCustomerTotal()
        {
            decimal total = 0;
            foreach (Customer c in myCustomers)
            {
                total += c.CustomerCharge;
            }
            return total;
        }

        private decimal CustomerTypeCalc(char type)
        {
            decimal total = 0;
            foreach (Customer c in myCustomers.Where(Customer => Customer.CustomerType == type))
            {
                total += c.CustomerCharge;
            }
            return total;
        }

        // method clears all values on click
        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            // clear all fields
            txtCustName.Text = "";
            txtAcctNum.Text = "";
            txtKwhUsed.Text = "";
            txtPeakHours.Text = "";
            txtOffPeakHours.Text = "";
        }

        // button method exits application
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnRemoveCust_Click(object sender, EventArgs e)
        {
            // if there is a customer selection
            if (lstCustomer.SelectedIndex != -1)
            {
                // identify customer to remove
                int index = lstCustomer.SelectedIndex; // position (in the list) of product to remove
                // confirm removal
                DialogResult answer = MessageBox.Show("Are you sure you want to remove customer " + myCustomers[index].CustomerName + "?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // if yes, remove product
                if (answer == DialogResult.Yes)
                {
                    myCustomers.RemoveAt(index); // remove selected object at index
                    // write products to the file
                    CustomerDB.SaveCustomers(myCustomers); // save to the file
                    // re-display customers
                    DisplayCustomers();
                }
            }
            else
            {
                MessageBox.Show("You need to select customer to remove first");
                lstCustomer.Focus();
            }
        }
    }
}
