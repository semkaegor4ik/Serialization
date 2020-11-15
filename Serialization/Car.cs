using System;
using System.Xml.Serialization;

namespace Serialization
{
    [Serializable]
    [XmlInclude(typeof(SportCar)),
        XmlInclude(typeof(RussianCar))]
    public class Car
    {
        protected int horsePower;
        protected String model;

        public Car(int horsePower, string model)
        {
            this.horsePower = horsePower;
            this.model = model;
        }

        public Car()
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
        public virtual void startEngine()
        {
            Console.WriteLine("Вжууух...");
        }

    }
}
