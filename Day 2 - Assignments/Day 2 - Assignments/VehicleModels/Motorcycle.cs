﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day_2___Assignments.BaseClasses;

namespace Day_2___Assignments.VehicleModels
{
    internal class Motorcycle : BaseVehicle
    {
        public override void Describe()
        {
            Console.WriteLine($"Motorcycle ID = {VehicleID}");
        }

        public override void Start()
        {
            Console.WriteLine("Motorcycle Started");
        }

        public override void Stop()
        {
            Console.WriteLine("Motorcycle Stopped");
        }
    }
}
