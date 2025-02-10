using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day_2___Assignments.BaseClasses;
using Day_2___Assignments.PaymentModels;

namespace Day_2___Assignments
{
    internal class PaymentFactory
    {
        
        public static BasePayment GetPaymentMethod(string paymentMethod)
        {
            return paymentMethod.ToLower() switch
            {
                "creditcard" => new CreditCardPayment(),
                "paypal" => new PayPal(),
                "banktransfer" => new BankTransfer(),
                _ => throw new ArgumentException("Invalid payment method"),
            }; 
        }
    }
}
