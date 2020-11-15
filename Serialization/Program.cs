using System;
using System.Collections.Generic;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            cars.Add(new Car(200, "volvo"));
            cars.Add(new RussianCar(80, "жигуль"));
            cars.Add(new SportCar(675, "McClaren"));
            Salon salon = new Salon(cars);
            Serialization<Salon> serialization = new Serialization<Salon>("salon");
            serialization.binarySerialize(salon);
            serialization.xmlSerialize(salon);
            serialization.jsonSerialize(salon);
            serialization.binaryDeserialize().startAll();
            serialization.xmlDeserialize().startAll();
            serialization.jsonDeserialize().startAll();
            Console.ReadKey();
        }
    }
}
