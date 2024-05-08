using System;
namespace CarLotSimulator
{
	public class Car
	{
		public Car()
		{
		}
		public int YearMade { get; set; }
		public string Make { get; set; }
		public string Model { get; set; }
		public string EngineNoise { get; set; }
		public string HonkNoise { get; set; }
		public string IsDrivable { get; set; }

		public void MakeEngineNoise(string engineNoise)
		{
			Console.WriteLine($"The {Make} {Model} makes a sound of {engineNoise}");
		}

		public void MakeHornSound(string honkNoise)
		{
			Console.WriteLine($"The {Make} {Model} makes the noise {honkNoise}when you honk");
		}
		public Car(int yearMade, string make, string model, string engineNoise, string honkNoise, string isDrivable)
		{
			YearMade = yearMade;
			Make = make;
			Model = model;
			EngineNoise = engineNoise;
			HonkNoise = honkNoise;
			IsDrivable = isDrivable;
		}
	}
}

//Year, Make, Model, EngineNoise, HonkNoise, IsDriveable