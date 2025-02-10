using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2___Assignments.BaseClasses
{
    internal abstract class BaseVehicle
    {
        public string VehicleID { get; } = Guid.NewGuid().ToString();
        public abstract void Start();
        public abstract void Stop();
        public abstract void Describe();
    }
}
