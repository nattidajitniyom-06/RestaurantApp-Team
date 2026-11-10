using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp_Team
{
    class Restaurant
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double Rating { get; set; }

     
    }

    internal class Program
    {
        static List<Restaurant> restaurants = new List<Restaurant>
    {
        new Restaurant { Name = "KFC", Type = "Fast Food", Rating = 4.2 },
        new Restaurant { Name = "MK", Type = "Suki", Rating = 4.7 },
        new Restaurant { Name = "PIZZA HUT", Type = "Fast Food", Rating = 4.8 },
        new Restaurant { Name = "TEE NOI", Type = "Suki", Rating = 4.9 },
        new Restaurant { Name = "MC", Type = "Fast Food", Rating = 4.5 },
        new Restaurant { Name = "STARBUCKS", Type = "Coffeehouse", Rating = 4.6},
    };

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n===== Restaurant Menu =====");
                Console.WriteLine("1. Add Restaurant");
                Console.WriteLine("2. Show Good Rating");
                Console.WriteLine("3. Show Summary");
                Console.WriteLine("0. Exit");
                Console.Write("Select Menu: ");

                string menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        AddRestaurant();
                        break;
                    case "2":
                        ShowGoodRating();
                        break;
                    case "3":
                        ShowSummary();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid Menu");
                        break;
                }
            }
        }

        // คน A รับผิดชอบ
        static void AddRestaurant()
        {
            Console.WriteLine("Not completed");

        }

        // คน B รับผิดชอบ
        static void ShowGoodRating()
        {
            Console.WriteLine("completed");

            foreach (Restaurant r in restaurants)
            {
                if (r.Rating >= 4.5)
                {
                    Console.WriteLine("ชื่อร้าน : " + r.Name + " คะแนน : " + r.Rating);
                }
            }
        }

        // คน C รับผิดชอบ
        static void ShowSummary()
        {
            Console.WriteLine("Not completed");


            }
        }

}
