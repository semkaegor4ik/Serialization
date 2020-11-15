using System;
using System.Collections.Generic;

namespace Serialization
{
    [Serializable]
    public class Salon
    {
        private List<Car> cars;

        public Salon(List<Car> cars)
        {
            this.cars = cars;
        }

        public Salon()
        {
        }

        public List<Car> Cars
        {
            get => cars;
            set => cars = value;
        }
        public void startAll()
        {
            cars.ForEach(car=>car.startEngine());
        }
    }
}
