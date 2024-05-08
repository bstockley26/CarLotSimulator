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

		public void MakeEngineNoise()
		{
			Console.WriteLine(EngineNoise);
		}

		public void MakeHornSound()
		{
			Console.WriteLine(HonkNoise);
		}
	}
}

//Year, Make, Model, EngineNoise, HonkNoise, IsDriveable