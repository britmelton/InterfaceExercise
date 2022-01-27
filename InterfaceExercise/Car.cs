using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public bool HasTrunk { get; set; }
        public string FuelEfficiency { get; set; }
        public int NumberOfWheels { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Motto { get; set; }
        public string Website { get; set; }

        public void Drive()
        {
            Console.WriteLine($"Driving in my {GetType().Name}"); //GetType is method that gets the type of the current instance
        }
    }
}
