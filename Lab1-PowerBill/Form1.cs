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
        private decimal kwh1;
        private decimal kwh2;
        private int accountNo;
        private string customerName;
        private char customerType;

        List<Customer> myCustomers;

        public powerBillForm()
        {
            InitializeComponent();
        }

        // combo box that selects customer type
        private void CboxCustType_SelectedIndexChanged(object sender, EventArgs e)
        // forms are hidden or displayed based on customer chosen
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

        // displays residential form and activates input upon form load
        private void PowerBillForm_Load(object sender, EventArgs e)
        {
            myCustomers = CustomerDB.ReadCustomers();
            DisplayCustomers();

            cboxCustType.SelectedIndex = 0;     // select residential on load
            this.ActiveControl = txtCustName;    // make text input active
            gBKwhUsed.Visible = true;        // hide residential and commercial panel
            gBoxIndust.Visible = false;    // hide industrial panel
        }

        private void DisplayCustomers()
        {
            lstCustomer.Items.Clear(); // empty the list box
            foreach (Customer c in myCustomers)
                lstCustomer.Items.Add(c);
            // display totals
            txtCustomerTotal.Text = myCustomers.Count.ToString();
            txtTotalCharges.Text = CalculateCustomerTotal().ToString("C");
            txtResTotal.Text = CalculateResidential().ToString("C");
            txtCommTotal.Text = CalculateCommercial().ToString("C");
            txtIndustTotal.Text = CalculateIndustrial().ToString("C");
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            switch (cboxCustType.SelectedIndex)
            {
                case 0: // residential

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
                        kwh1 = Convert.ToDecimal(txtKwhUsed.Text);
                        accountNo = Convert.ToInt32(txtAcctNum.Text);
                        customerName = Convert.ToString(txtCustName.Text);

                        ResidentialCustomer newResCust = new ResidentialCustomer(accountNo, customerName, customerType, kwh1, kwh2=0); // create new customer
                        myCustomers.Add(newResCust); // add to list
                        CustomerDB.SaveCustomers(myCustomers);
                        DisplayCustomers();
                        ClearFields();
                    }
                    break;
                case 1: //commercial

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
                        kwh1 = Convert.ToDecimal(txtKwhUsed.Text);
                        accountNo = Convert.ToInt32(txtAcctNum.Text);
                        customerName = Convert.ToString(txtCustName.Text);

                        CommercialCustomer newComCust = new CommercialCustomer(accountNo, customerName, customerType, kwh1, kwh2 = 0); // create new customer
                        myCustomers.Add(newComCust); // add to list
                        CustomerDB.SaveCustomers(myCustomers);
                        DisplayCustomers();
                        ClearFields();
                    }
                    break;
                case 2: // industrial

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
                        kwh1 = Convert.ToDecimal(txtPeakHours.Text);
                        kwh2 = Convert.ToDecimal(txtOffPeakHours.Text);
                        accountNo = Convert.ToInt32(txtAcctNum.Text);
                        customerName = Convert.ToString(txtCustName.Text);

                        IndustrialCustomer newIndusCust = new IndustrialCustomer(accountNo, customerName, customerType, kwh1, kwh2); // create new customer
                        myCustomers.Add(newIndusCust); // add to list       
                        CustomerDB.SaveCustomers(myCustomers);
                        DisplayCustomers();
                        ClearFields();
                    }
                    break;
            }
        }

        private decimal CalculateCustomerTotal()
        {
            decimal total = 0;
            foreach (Customer c in myCustomers)
            {
                total += c.CustomerCharge;
            }
            return total;
        }

        private decimal CalculateResidential()
        {
            decimal total = 0;
            foreach (Customer c in myCustomers.Where(Customer => Customer.CustomerType == 'R'))
            {
                total += c.CustomerCharge;
            }
            return total;
        }

        private decimal CalculateCommercial()
        {
            decimal total = 0;
            foreach (Customer c in myCustomers.Where(Customer => Customer.CustomerType == 'C'))
            {
                total += c.CustomerCharge;
            }
            return total;
        }

        private decimal CalculateIndustrial()
        {
            decimal total = 0;
            foreach (Customer c in myCustomers.Where(Customer => Customer.CustomerType == 'I'))
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
