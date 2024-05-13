using System;
using System.Collections.Generic;
namespace CarLotSimulator
{
    public class CarLot
	{
		public CarLot()
		{

		}
		public List<Car> ParkingLot { get; set; } = new List<Car>();
		public static int numberOfCars = 0;
		public void InventoryList()
		{
			Console.WriteLine("Parking Lot One:");


			foreach (var car in ParkingLot)
			{
				

				Console.WriteLine($"{car.Make} {car.Model}, made in the year {car.YearMade}");

			}
		}

    }
}

