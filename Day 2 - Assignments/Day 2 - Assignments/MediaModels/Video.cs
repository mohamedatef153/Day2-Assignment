using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day_2___Assignments.BaseClasses;

namespace Day_2___Assignments.MediaModels
{
    internal class SmS : BaseMedia
    {
        public override void Play()
        {
            Console.WriteLine("Video Started");
        }

        public override void Stop()
        {
            Console.WriteLine("Video Stopped");
        }
    }
}
