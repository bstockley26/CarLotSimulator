using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var parkingLotOne = new CarLot();
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            var carOne = new Car();
            carOne.YearMade = 2024;
            carOne.Make = "Porsche";
            carOne.Model = "911";
            carOne.EngineNoise = "vroooom";
            carOne.HonkNoise = "beeeeeeeeeep";
            carOne.IsDrivable = "ohh yaaa";

            carOne.MakeEngineNoise(carOne.EngineNoise);
            carOne.MakeHornSound(carOne.HonkNoise);
            parkingLotOne.ParkingLot.Add(carOne);

            var carTwo = new Car()
            {
                YearMade = 2021,
                Make = "Toyota",
                Model = "4runner",
                EngineNoise = "skirt",
                HonkNoise = "Moooveeee",
                IsDrivable="yesss",

            };
            carTwo.MakeEngineNoise(carTwo.EngineNoise);
            carTwo.MakeHornSound(carTwo.HonkNoise);
            parkingLotOne.ParkingLot.Add(carTwo);


            var carThree = new Car(2024, "Audi", "R8", "wahhh", "beep beep","yes");
            carThree.MakeEngineNoise(carThree.EngineNoise);
            carThree.MakeHornSound(carThree.HonkNoise);
            parkingLotOne.ParkingLot.Add(carThree);

            parkingLotOne.InventoryList();
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
