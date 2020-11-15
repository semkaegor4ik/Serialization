using System;

namespace Serialization
{
    [Serializable]
    public class SportCar : Car
    {

        public SportCar(int horsePower, string model)
        {
            this.horsePower = horsePower;
            this.model = model;
        }

        public SportCar()
        {
        }

        public int HorsePower
        {
            get => horsePower;
            set => horsePower = value;
        }
        public string Model
        {
            get => model;
            set => model = value;
        }
        public override void startEngine()
        {
            Console.WriteLine("ВРУУУММ ВРУМММ...");
        }
    }
}
