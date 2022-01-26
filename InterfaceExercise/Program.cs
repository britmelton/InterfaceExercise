using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces
            //Create 2 Interfaces called IVehicle & ICompany
            //Create 3 classes called Car , Truck , & SUV

            /*In each of your car, truck, and suv classes
             Create 2 members that are specific to each class
             Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             Then, Set each class to inherit from both IVehicle and ICompany and implement their members.*/

            //Now, create objects of your 3 classes and give their members values
            var car = new Car() { FuelEfficiency = "very good", HasTrunk = true, NumberOfWheels = 4, Make = "Toyota", Model = "Yaris", Year = 2012, Logo = "T with circles", Website = "www.Toyota.com"};

            var truck = new Truck() { BedSize = "Large", CabSize = "small", NumberOfWheels = 4, Make = "Chevrolet", Model = "Silverado", Year = 2014, Logo = "bowtie emblem", Website = "www.Chevrolet.com" };

            var suv = new SUV() { OffRoad = true, NoTrunk = "has a wagon-style extended roofline, rather than a trunk", NumberOfWheels = 4, Make = "Subaru", Model = "Ascent", Year = 2022, Logo = "encircled star cluster", Website = "www.Subaru.com"};

            var vehicles = new List<IVehicle>();
            vehicles.Add(car);
            vehicles.Add(truck);   
            vehicles.Add(suv);

            foreach (var item in vehicles)
            {
                Console.WriteLine($"\n{item.Year} {item.Make} {item.Model}\n Number of Wheels: {item.NumberOfWheels} \n Logo: {item.Logo} \n {item.Website}\n");
                if (item.GetType() == car.GetType())
                {
                    Console.WriteLine($"The {car.Make} {car.Model} has {car.FuelEfficiency} fuel efficiency.");
                }
                else if (item.GetType() == truck.GetType())
                {
                    Console.WriteLine($"The {truck.Make} {truck.Model} has a {truck.BedSize} bedsize, but a {truck.CabSize} cabin.");
                }
                else if (item.GetType() == suv.GetType())
                {
                    Console.WriteLine($"The {suv.Make} {suv.Model} {suv.NoTrunk}");
                }
          
            }
 
            //Creatively display and organize their values
        }
    }
}
