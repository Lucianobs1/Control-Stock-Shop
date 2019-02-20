using System;
using System.Collections.Generic;
using System.Text;

namespace ControlStock.Entities
{
    class ProcessOrder
    {
        public Boolean ProcessPayment(double balance, double TotalPurchase)
        {

            if (balance >= TotalPurchase)
            {
                Console.WriteLine("Payment Approved");
                return true;
            }

            else
            {
                Console.WriteLine("Payment ");
                return false;
                
            }
        }
    }
}
