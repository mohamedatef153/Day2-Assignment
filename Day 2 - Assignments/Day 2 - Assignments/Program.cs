using Day_2___Assignments;
using Day_2___Assignments.BaseClasses;
using Day_2___Assignments.MediaModels;
using Day_2___Assignments.PaymentModels;
#region Assignment 1: Payment Methods

//Console.WriteLine("Choose a payment method: CreditCard, BankTransfer, PayPal");
//string method = Console.ReadLine();
//BasePayment payment = null;
//if (method.ToLower() == "creditcard")
//{
//    payment = new CreditCardPayment();
//}
//else if (method.ToLower() == "banktransfer")
//{
//    payment = new BankTransfer();
//}
//else if (method.ToLower() == "paypal")
//{
//    payment = new PayPal();
//}
//else
//{
//    Console.WriteLine("Invalid payment method selected.");
//    return;
//}

//payment.ProcessPayment();
#endregion

#region Assignment 2: Vehicle Control System
//BaseVehicle[] vehicles = new BaseVehicle[] { new Car(),new Truck(), new Motorcycle()};
//foreach (var vehicle in vehicles)
//{
//    vehicle.Start();
//    vehicle.Describe();
//    vehicle.Stop();
//    Console.WriteLine("----------------------");
//}
#endregion

#region Assignment 3: Media Player Plugins

//BaseMedia[] MediaPlayer= new BaseMedia[] {new Video(),new Audio(),new Video()};
//foreach (var media in MediaPlayer)
//{
//   media.Play();
//    media.Stop();
//    Console.WriteLine("----------------------");
//}
#endregion

#region Assignment 4: Customer Notifications
BaseNotification[] notifications = new BaseNotification[] { new Email(),new SMS(),new Email()};
foreach(var notification in notifications)
{
    notification.Notify();
    Console.WriteLine("----------------------");
}
#endregion