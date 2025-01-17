﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Car genesis = new Car();
            genesis.Cost = 100000;
            genesis.Name = "Genesis";
            genesis.Logo = "Super Car Logo";
            genesis.TrunkSize = "Medium"; 


            Truck pickupTruck = new Truck();
            pickupTruck.Cost = 200000;
            pickupTruck.Name = "Pickup Truck";
            pickupTruck.Logo = "Truck Logo";


            SUV toyota = new SUV();
            toyota.Cost = 300000;
            toyota.Name = "Toyota";
            toyota.Logo = "Toyota Logo";
            toyota.NumberOfRows = 3;
            toyota.NumberOfFloormats = 4;



            var vehicles = new List<IVehicle>();
            vehicles.Add(genesis);
            vehicles.Add(pickupTruck);
            vehicles.Add(toyota);


            foreach (var vehicle in vehicles)
            {
                vehicle.Drive();
                vehicle.Honk();
                Console.WriteLine($"This vehicle costs {vehicle.Cost}!");
                vehicle.GetsGas();
                Console.WriteLine("======================================");
            }

            var companyVehicles = new List<ICompany>();
            companyVehicles.Add(genesis);
            companyVehicles.Add(pickupTruck);
            companyVehicles.Add(toyota);

            foreach (var companyVehicle in companyVehicles)
            {
                Console.WriteLine($"The name of this company vehicle is: {companyVehicle.Name}");
                Console.WriteLine($"The logo of this company vehicle is: {companyVehicle.Logo} ");
                Console.WriteLine("======================================");
            }



            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
        }
    }
}
