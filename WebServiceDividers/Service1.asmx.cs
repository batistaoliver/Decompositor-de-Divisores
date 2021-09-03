using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;

namespace WebServiceDividers
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class Service1 : System.Web.Services.WebService
    {

        [WebMethod]
        //Method return the input number
        public decimal InputValue(decimal number)
        {
            return number;
        }

        [WebMethod]
        //Method for calculating divisors 
        public List<decimal> ListDividers(decimal number)
        {
            //declaration of variable
            List<decimal> listNumber = new List<decimal>();

            //Calculates the divisors of the entered Number and fills the list of divisors
            for (decimal i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    listNumber.Add(i);
                }
            }
            return listNumber;
        }

        [WebMethod] 
        //method for calculating prime numbers
        public List<decimal> ListPrime(decimal number)
        {
            //declaration of variable 
            List<decimal> listDividers = ListDividers(number);
            List<decimal> listNumber = new List<decimal>();

            //get the dividers from the "ListDividers" method
            listDividers = ListDividers(number);

            //for each divisor, check if it is prime.
            foreach (int divider in listDividers)
            {

                bool isPrime = true;
                for (int j = 2; j < divider; j++)
                {
                    if (divider % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    //if it is prime, fill the list of prime numbers
                    listNumber.Add(divider);  
                } 
            }
            return listNumber;
        }
    }
}