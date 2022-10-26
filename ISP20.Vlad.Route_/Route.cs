using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP20.VladPolyakova.Route.V10
{
    
    public class Route
    {
        public string StartRoute { get; set; }
        public string EndRoute { get; set; }
        public int NumberRoute { get; set; }

        public Route(string startRoute, string endRoute, int numberRoute)
        {
            StartRoute = startRoute;
            EndRoute = endRoute;
            NumberRoute = numberRoute;
        }

        public static Route CreateRoute()
        {

            Console.Write("Введите начало маршрута: ");
            string startRoute = ChekName(Console.ReadLine(), nameof(StartRoute));
            Console.Write("Введите конец маршрута: ");
            string endRoute = ChekName(Console.ReadLine(), nameof(EndRoute));
            Console.Write("Введите номер маршрута: ");
            if (int.TryParse(Console.ReadLine(), out int value))
            {
                int numberOfRoute = value;
                return new Route(startRoute, endRoute, numberOfRoute);
            }
            else
            {
                Console.WriteLine("Ошибка ввода данных");
                return null;
            }


        }
        public static Route[] GetRouteArray(int count)
        {
            Route[] routes = new Route[count];

            for (int i = 0; i < routes.Length; i++)
            {
                routes[i] = CreateRoute();
            }

            return routes;
        }
        private static string ChekName(string input, string Check = "")
        {

            switch (Check)
            {
                case nameof(StartRoute):
                    if (!string.IsNullOrEmpty(input))
                    { return input; break; }
                    else { return "Начальная точка маршрута не определена"; break; }

                case nameof(EndRoute):
                    if (!string.IsNullOrEmpty(input))
                    { return input; break; }
                    else { return "Конечная точка маршрут не определена"; break; }


            }
            return input;

        }
        public static Route[] SearchRoute(Route[] routes)
        {
            Console.WriteLine("Введите номер вашего маршрута");
            if (int.TryParse(Console.ReadLine(), out int numberOfRoute))
                return routes;
            {
                for (int i = 0; i < routes.Length; i++)
                {
                    if (!(numberOfRoute == routes[i].NumberRoute))
                    {
                        Console.WriteLine(routes[i]);
                    }
                    else
                    {
                        Console.WriteLine("Такого нет");
                    }
                }
            }
            return routes;
        }
        public override string ToString()
        {

            return $"Начало марщрута: {StartRoute} \nКонец маршрута: {EndRoute}\nНомер маршрута: {NumberRoute}";
        }

    }
}