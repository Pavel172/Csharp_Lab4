using System;

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
            public static void Compare(List<Car> list, int x) 
            {
                if(x == -1) 
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        for (int j = 0; j < list.Count-1; j++)
                        {
                            if (list[j].Name.Length > list[j+1].Name.Length)
                            {
                                string temp = list[j].Name;
                                list[j].Name = list[j + 1].Name;
                                list[j + 1].Name = temp; 
                            }
                        }
                    }
                }
                if (x == 1)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        for (int j = 0; j < list.Count - 1; j++)
                        {
                            if (list[j].ProductionYear > list[j + 1].ProductionYear)
                            {
                                int temp = list[j].ProductionYear;
                                list[j].ProductionYear = list[j + 1].ProductionYear;
                                list[j + 1].ProductionYear = temp;
                            }
                        }
                    }
                }
                if (x == 0)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        for (int j = 0; j < list.Count - 1; j++)
                        {
                            if (list[j].MaxSpeed > list[j + 1].MaxSpeed)
                            {
                                int temp = list[j].MaxSpeed;
                                list[j].MaxSpeed = list[j + 1].MaxSpeed;
                                list[j + 1].MaxSpeed = temp;
                            }
                        }
                    }
                }
            }
        }

        public interface IComparer<Car> { }

        public static void Main() 
        {
            Car car1 = new Car("Ford", 1999, 130);
            Car car2 = new Car("BWM", 2009, 135);
            Car car3 = new Car("Renault", 2020, 150);
            Car car4 = new Car("Honda", 2004, 125);
            List<Car> list1 = new List<Car>() {car1, car2, car3, car4};
            Console.WriteLine("Сортировка по названию: ");
            for (int i = 0;i < list1.Count; i++) 
            {
                Console.WriteLine(list1[i].Name);
            }
            CarComparer.Compare(list1, -1);
            Console.WriteLine("--------------");
            for (int i = 0; i < list1.Count; i++)
            {
                Console.WriteLine(list1[i].Name);
            }
            List<Car> list2 = new List<Car>() { car1, car2, car3, car4 };
            Console.WriteLine();
            Console.WriteLine("Сортировка по году выпуска: ");
            for (int i = 0; i < list2.Count; i++)
            {
                Console.WriteLine(list2[i].ProductionYear);
            }
            CarComparer.Compare(list2, 1);
            Console.WriteLine("--------------");
            for (int i = 0; i < list2.Count; i++)
            {
                Console.WriteLine(list2[i].ProductionYear);
            }
            List<Car> list3 = new List<Car>() { car1, car2, car3, car4 };
            Console.WriteLine();
            Console.WriteLine("Сортировка по максимальной скорости: ");
            for (int i = 0; i < list3.Count; i++)
            {
                Console.WriteLine(list3[i].MaxSpeed);
            }
            CarComparer.Compare(list3, 0);
            Console.WriteLine("--------------");
            for (int i = 0; i < list3.Count; i++)
            {
                Console.WriteLine(list3[i].MaxSpeed);
            }
        }
    }
}
