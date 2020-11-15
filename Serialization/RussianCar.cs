using System;

namespace Serialization
{
    [Serializable]
    public class RussianCar:Car
    {

        public RussianCar(int horsePower, string model)
        {
            this.horsePower = horsePower;
            this.model = model;
        }

        public RussianCar()
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
            Console.WriteLine("ТРР ТТР ПУК");
        }

    }
}
