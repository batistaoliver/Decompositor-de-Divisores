using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace decomposeDividers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //declaration of variables
            decimal number =  new decimal(); 
            List<decimal> ListDividers = new List<decimal>();
            List<decimal> ListPrimes = new List<decimal>(); 

            //Webservice Connection
            WebServiceDividers.Service1SoapClient cliente = new WebServiceDividers.Service1SoapClient();

            //get input value
            number = Convert.ToDecimal(txtNumber.Text);

            //Call Webservice Function "InputValue"
            txtInputValue.Text = Convert.ToString(cliente.InputValue(number));

            //reset listbox values
            lbDividers.Items.Clear();
            lbPrime.Items.Clear();

            //Call Webservice Function "ListDividers"
            ListDividers = cliente.ListDividers(number);

            //fill the listbox from Dividers
            foreach (int divider in ListDividers)
            {
                lbDividers.Items.Add(divider);
            }


            //Call Webservice Function "ListPrime"
            ListPrimes = cliente.ListPrime(number);

            //fill the listbox from Primes Numbers
            foreach (int prime in ListPrimes)
            {
                lbPrime.Items.Add(prime);
            }
        }
    }
}
