using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car: Check.
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable: Check.
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise(): Check.
            //The methods should take one string parameter: the respective noise property: Check.

            //Standard Member Initialization
            Car acura = new Car();
            acura.Year = 2014;
            acura.Make = "Acura:";
            acura.Model = "RDX";
            acura.EngineNoise = "Engine Note: Deep hum";
            acura.HonkNoise = "Horn: Robust honk";
            acura.IsDriveable = true;

            acura.CarMake();
            acura.MakeEngineNoise();
            acura.MakeHonkNoise();

            Car honda = new Car();
            honda.Year = 2010;
            honda.Make = "Honda:";
            honda.Model = "Civic";
            honda.EngineNoise = "Engine Note: Reeeeee + whineeee (terrible)";
            honda.HonkNoise = "Horn: Dainty lil pip-squeak honk";
            honda.IsDriveable = true;

            honda.CarMake();
            honda.MakeEngineNoise();
            honda.MakeHonkNoise();

            Car ford = new Car();
            ford.Year = 2003;
            ford.Make = "Ford:";
            ford.Model = "Explorer";
            ford.EngineNoise = "Engine Note: Vroooom, guzzle-gas!";
            ford.HonkNoise = "Horn: BEEP FREAKIN' BEEP";
            ford.IsDriveable = false;

            ford.CarMake();
            ford.MakeEngineNoise();
            ford.MakeHonkNoise();

            var car1 = new Car();
            car1.Model = "Acura";

            var car2 = new Car();
            car2.Model = "Honda";

            var car3 = new Car();
            car3.Model = "Ford";

            var parking = new CarLot();
            parking.Lot = new List<Car>() { car1, car2, car3 };

            foreach(var car in parking.Lot)
            {
                Console.WriteLine($"{car.Model} {car.Year}");
            }


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
