using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day_2___Assignments.BaseClasses;

namespace Day_2___Assignments.MediaModels
{
    internal class Audio : BaseMedia
    {
        public override void Play()
        {
            Console.WriteLine("Audio Started");
        }

        public override void Stop()
        {
            Console.WriteLine("Audio Stopped");
        }
    }
}
