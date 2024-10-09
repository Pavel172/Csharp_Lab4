using System;

namespace Task3
{
    public class Program
    {
        public class Car
        {
            public string Name { get; set; }

            public int ProductionYear { get; set; }

            public int MaxSpeed { get; set; }

            public Car(string Name, int ProductionYear, int MaxSpeed)
            {
                this.Name = Name;
                this.ProductionYear = ProductionYear;
                this.MaxSpeed = MaxSpeed;
            }
        }

        public class CarCatalog
        {
            public Car[] Cars_list { get; set; }

            public CarCatalog(Car[] Cars_list) 
            {
                this.Cars_list = Cars_list;
            }

            public IEnumerator<Car> GetEnumerator() 
            {
                for (int i = 0; i < Cars_list.Length; ++i)
                {
                    yield return Cars_list[i];
                }
            }

            public IEnumerable<Car> GetCarsReverse(int flag)
            {
                for (int i = Cars_list.Length-1; i > -1; --i)
                {
                    yield return Cars_list[i];
                }
            }

            public IEnumerable<Car> GetCarsYear(int ProductionYear)
            {
                for (int i = 0; i < Cars_list.Length; ++i)
                {
                    if (Cars_list[i].ProductionYear == ProductionYear) 
                    {
                        yield return Cars_list[i];
                    }
                }
            }

            public IEnumerable<Car> GetCarsSpeed(int MaxSpeed)
            {
                for (int i = 0; i < Cars_list.Length; ++i)
                {
                    if (Cars_list[i].MaxSpeed == MaxSpeed)
                    {
                        yield return Cars_list[i];
                    }
                }
            }
        }


        public static void Main()
        {
            Car car1 = new Car("Ford", 1999, 130);
            Car car2 = new Car("BWM", 2009, 135);
            Car car3 = new Car("Renault", 2020, 150);
            Car car4 = new Car("Honda", 2004, 125);
            Car car5 = new Car("Audi", 2004, 120);
            Car car6 = new Car("Hyundai", 2010, 135);
            Car[] list = { car1, car2, car3, car4, car5, car6 };
            CarCatalog catalog = new CarCatalog(list);
            Console.WriteLine("Прямой проход");
            foreach (Car car in catalog)
            {
                Console.WriteLine(car.Name);
            }
            Console.WriteLine("\nОбратный проход");
            foreach (Car car in catalog.GetCarsReverse(4))
            {
                Console.WriteLine(car.Name);
            }
            Console.WriteLine("\nФильтр по году выпуска 2004г");
            foreach (Car car in catalog.GetCarsYear(2004))
            {
                Console.WriteLine(car.Name);
            }
            Console.WriteLine("\nФильтр по максимальной скорости 135км/ч");
            foreach (Car car in catalog.GetCarsSpeed(135))
            {
                Console.WriteLine(car.Name);
            }
        }
    }
}
