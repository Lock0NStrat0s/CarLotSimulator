using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public Car()
        {

        }

        public Car(int year, string make, string model, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            IsDriveable = isDriveable;
        }

        public void MakeEngineNoise(string engineNoise)
        {
            EngineNoise = engineNoise;
            Console.WriteLine(EngineNoise);
        }

        public void MakeHonkNoise(string honkNoise)
        {
            HonkNoise = honkNoise;
            Console.WriteLine(HonkNoise);
        }
    }
}
