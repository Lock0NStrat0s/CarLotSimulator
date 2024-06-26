﻿using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            CarLot carLot = new CarLot();

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property
            Console.WriteLine($"NUMBER OF CARS IN THE LOT: {CarLot.numberOfCars}");

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //METHOD 1: Using the default constructor
            Car car1 = new Car()
            { 
                IsDriveable = true, 
                Make = "Toyota", 
                Model = "Corolla", 
                Year = 2000
            };
            carLot.Cars.Add(car1);
            CarLot.numberOfCars++;
            Console.WriteLine($"NUMBER OF CARS IN THE LOT: {CarLot.numberOfCars}");

            //METHOD 2: Using the dot notation to set the properties
            Car car2 = new Car();
            car2.Year = 2010;
            car2.Make = "Ford";
            car2.Model = "F150";
            car2.IsDriveable = true;
            carLot.Cars.Add(car2);
            CarLot.numberOfCars++;
            Console.WriteLine($"NUMBER OF CARS IN THE LOT: {CarLot.numberOfCars}");

            //METHOD 3: Using the overloaded constructor
            Car car3 = new Car(2024, "Chevy", "Camaro", true);
            carLot.Cars.Add(car3);
            CarLot.numberOfCars++;
            Console.WriteLine($"NUMBER OF CARS IN THE LOT: {CarLot.numberOfCars}");

            car1.MakeEngineNoise("VROOOOOOOOM");
            car1.MakeHonkNoise("QUAAAAAAACK");

            car2.MakeEngineNoise("OIIIINK");
            car2.MakeHonkNoise("GLUB GLUB GLUB");

            car3.MakeEngineNoise("BAAZZOOOONGA");
            car3.MakeHonkNoise("MEEP MEEP");

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach(var car in carLot.Cars)
            {
                Console.WriteLine($"Year: {car.Year}, Make: {car.Make}, Model: {car.Model}");
            }
        }
    }
}
