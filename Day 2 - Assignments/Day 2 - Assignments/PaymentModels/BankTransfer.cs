using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day_2___Assignments.BaseClasses;

namespace Day_2___Assignments.PaymentModels
{
    internal class BankTransfer : BasePayment
    {
        public override void ProcessPayment()
        {
            Console.WriteLine($"Processing bank transfer. Transaction ID: {TransactionID}");

        }
    }
}
