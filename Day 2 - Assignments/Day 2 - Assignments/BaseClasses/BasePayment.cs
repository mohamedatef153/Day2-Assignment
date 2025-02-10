using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2___Assignments.BaseClasses
{
    internal abstract class BasePayment
    {
        public string TransactionID { get; } = Guid.NewGuid().ToString();
        public abstract void ProcessPayment();
    }
}