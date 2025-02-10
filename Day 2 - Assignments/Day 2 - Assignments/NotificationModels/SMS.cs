using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day_2___Assignments.BaseClasses;

namespace Day_2___Assignments.MediaModels
{
    internal class SMS : BaseNotification
    {
      

        public override void Notify()
        {
            Console.WriteLine("SMS Notification");
        }
    }
}
