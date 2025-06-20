





using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AvtoKushta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ETAП 1-А)
            List<Avtokushta> cars = new List<Avtokushta>
            {
              new Avtokushta(1, 7334, 234, 305, "Toyota", 15000, 1999),
              new Avtokushta(2, 3445, 324, 203, "Honda", 12000, 2010),
              new Avtokushta(3, 9779, 545, 453, "Ford", 18000, 2024),
              new Avtokushta(4, 1334, 678, 890, "BMW", 11000, 2009),
              new Avtokushta(5, 5679, 910, 111, "Audi", 34500, 2022),

            };
            //Б)
            foreach (var car in cars)
            {
                car.Print();
            }
            // ЕТАП 2-В)
            Console.Write("Въведи марка: ");
            string brand = Console.ReadLine();
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].CarBrand.ToLower() == brand.ToLower())
                {
                    cars[i].Print();

                }
            }
            //Г)
            Console.Write("Въведи минимална цена: ");
            int minPrice = int.Parse(Console.ReadLine());
            Console.Write("Въведи максимална цена: ");
            int maxPrice = int.Parse(Console.ReadLine());
            foreach (var car in cars)
            {
                if (car.Price >= minPrice && car.Price <= maxPrice)
                {
                    car.Print();
                }
            }
            //Д)
            Console.Write("Въведи номер на автомобил за актуализация: ");
            int carNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].CarNumber == carNumber)
                {
                    cars[i].EngineNumber = int.Parse(Console.ReadLine());
                    cars[i].KupeNumber = int.Parse(Console.ReadLine());
                    cars[i].CarBrand = Console.ReadLine();
                    cars[i].Price = int.Parse(Console.ReadLine());
                    cars[i].CarYear = int.Parse(Console.ReadLine());
                    cars[i].Print();

                }
            }
            //E)
            Console.Write("Въведи марка: ");
            string brandForRemove = Console.ReadLine();
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].CarBrand.ToLower() == brandForRemove.ToLower())
                {
                    cars.RemoveAt(i);
                }
            }
            foreach (var car in cars)
            {
                car.Print();
            }
            //EТАП 3-Ж)
            double averageCarAge = 0;
            double totalAge = 0;
            for (int i = 0; i < cars.Count; i++)
            {
                totalAge += DateTime.Now.Year - cars[i].CarYear;
            }
            averageCarAge = totalAge / cars.Count;
            Console.WriteLine($"Средната възраст на автомобилите е: {averageCarAge}");

            //З)
            for (int i = 0; i < cars.Count; i++)
            {
                int OldestCar = cars[0].CarYear;
                if (cars[i].CarYear < OldestCar)
                {
                    OldestCar = cars[i].CarYear;
                    Console.WriteLine($"Най-старият автомобил е: {cars[i].CarBrand}, година: {OldestCar}");

                }
            }
            //И)

            //Й
            for (int i = 0; i < cars.Count - 1; i++)
            {
                for (int j = i + 1; j < cars.Count; j++)
                {
                    if (cars[i].Price > cars[j].Price)
                    {
                      
                        var temp = cars[i];
                        cars[i] = cars[j];
                        cars[j] = temp;
                    }
                }
                cars[i].Print();
            }
            









        }
    }
}
