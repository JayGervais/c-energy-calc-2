using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // any form controls

namespace Lab1_PowerBill
{
    public static class Validator
    {
        // all methods in a static class are static

        /// <summary>
        /// tests for an empty string
        /// </summary>
        /// <param name="tb">text box tested</param>
        /// <param name="name">name to use in error message</param>
        /// <returns>is it valid</returns>
        public static bool IsNotEmpty(TextBox tb, string name)
        {
            bool valid = true; // setting parameter
            if (tb.Text == "") // empty
            {
                valid = false;
                MessageBox.Show(name + " is required");
                tb.Focus();
            }
            return valid;
        }

        /// <summary>
        /// test if text box contains integer value
        /// </summary>
        /// <param name="tb">text box tested</param>
        /// <param name="name">name to use in error message</param>
        /// <returns>is it valid</returns>
        public static bool IsInteger(TextBox tb, string name)
        {
            bool valid = true;
            int value;
            if(!Int32.TryParse(tb.Text, out value)) // parse unsuccessful
            {
                valid = false;
                MessageBox.Show(name + " must be a whole number");
                tb.SelectAll(); // select all content for replacement
                tb.Focus();
            }
            return valid;
        }

        /// <summary>
        /// test if text box contains double value
        /// </summary>
        /// <param name="tb">text box tested</param>
        /// <param name="name">name to use in error message</param>
        /// <returns>is it valid</returns>
        public static bool IsDouble(TextBox tb, string name)
        {
            bool valid = true;
            double value;
            if (!Double.TryParse(tb.Text, out value)) // parse unsuccessful
            {
                valid = false;
                MessageBox.Show(name + " has to be a decimal number");
                tb.SelectAll(); // select all content for replacement
                tb.Focus();
            }
            return valid;
        }

        /// <summary>
        /// test if text box contains non-negative integer value
        /// </summary>
        /// <param name="tb">text box tested</param>
        /// <param name="name">name to use in error message</param>
        /// <returns>is it valid</returns>
        public static bool IsNonNegativeInt(TextBox tb, string name)
        {
            bool valid = true;
            int value;
            if (!Int32.TryParse(tb.Text, out value)) // parse unsuccessful
            {
                valid = false;
                MessageBox.Show(name + " must be a positive number");
                tb.SelectAll(); // select all content for replacement
                tb.Focus();
            }
            else // parsed correctly
            {
                if(value < 0)
                {
                    valid = false;
                    MessageBox.Show(name + " has to be positive or zero");
                    tb.SelectAll(); // select all content for replacement
                    tb.Focus();
                }
            }
            return valid;
        }

        /// <summary>
        /// test if text box contains non-negative integer value
        /// </summary>
        /// <param name="tb">text box tested</param>
        /// <param name="name">name to use in error message</param>
        /// <returns>is it valid</returns>
        public static bool IsNonNegativeDouble(TextBox tb, string name)
        {
            bool valid = true;
            double value;
            if (!Double.TryParse(tb.Text, out value)) // parse unsuccessful
            {
                valid = false;
                MessageBox.Show(name + " has to be a decimal number");
                tb.SelectAll(); // select all content for replacement
                tb.Focus();
            }
            else // parsed correctly
            {
                if (value < 0)
                {
                    valid = false;
                    MessageBox.Show(name + " has to be positive or zero");
                    tb.SelectAll(); // select all content for replacement
                    tb.Focus();
                }
            }
            return valid;
        }

    } // class
} // namespace
