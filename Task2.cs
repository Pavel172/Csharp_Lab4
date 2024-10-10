using System;
using System.Collections;
using System.Collections.Generic;

namespace Task2 
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

        public class CarComparer : IComparer<Car>
        {
            public string sortby { get; set; }

            public CarComparer(string sortby) 
            {
                this.sortby = sortby;
            }
            public int Compare(Car? x, Car? y)
            {
                if (sortby == "Name")
                {
                    return x.Name.Length - y.Name.Length;
                }
                if (sortby == "ProductionYear")
                {
                    return x.ProductionYear-y.ProductionYear;
                }
                if (sortby == "MaxSpeed")
                {
                    return x.MaxSpeed-y.MaxSpeed;
                }
                else
                {
                    throw new ArgumentException("Ошибка при сортировке");
                }
            }
        }

        public static void Main() 
        {
            Car car1 = new Car("Ford", 1999, 130);
            Car car2 = new Car("BWM", 2009, 135);
            Car car3 = new Car("Renault", 2020, 150);
            Car car4 = new Car("Honda", 2004, 125);
            Car[] car_array = {car1, car2, car3, car4};
            Console.WriteLine("Сортировка по названию: ");
            for (int i = 0;i < car_array.Length; i++) 
            {
                Console.WriteLine(car_array[i].Name);
            }
            Array.Sort(car_array, new CarComparer("Name"));
            Console.WriteLine("--------------");
            for (int i = 0; i < car_array.Length; i++)
            {
                Console.WriteLine(car_array[i].Name);
            }
            Console.WriteLine();
            Console.WriteLine("Сортировка по году выпуска: ");
            for (int i = 0; i < car_array.Length; i++)
            {
                Console.WriteLine(car_array[i].ProductionYear);
            }
            Array.Sort(car_array, new CarComparer("ProductionYear"));
            Console.WriteLine("--------------");
            for (int i = 0; i < car_array.Length; i++)
            {
                Console.WriteLine(car_array[i].ProductionYear);
            }
            Console.WriteLine();
            Console.WriteLine("Сортировка по максимальной скорости: ");
            for (int i = 0; i < car_array.Length; i++)
            {
                Console.WriteLine(car_array[i].MaxSpeed);
            }
            Array.Sort(car_array, new CarComparer("MaxSpeed"));
            Console.WriteLine("--------------");
            for (int i = 0; i < car_array.Length; i++)
            {
                Console.WriteLine(car_array[i].MaxSpeed);
            }
        }
    }
}
