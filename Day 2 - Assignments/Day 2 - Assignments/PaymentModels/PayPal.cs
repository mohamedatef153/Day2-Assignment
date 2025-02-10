using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day_2___Assignments.BaseClasses;

namespace Day_2___Assignments.PaymentModels
{
    internal class PayPal : BasePayment
    {
        public override void ProcessPayment()
        {
            Console.WriteLine($"Processing PayPal payment. Transaction ID: {TransactionID}");

        }
    }
}
