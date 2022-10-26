using ISP20.VladPolyakova.Route.V10;

namespace VtitBid.ISP20.Vlad.Route_ { 


class Program
  {
    static void Main(string[] args)
    {
       
        Console.Write("Введите количество маршрутов:");
        if (int.TryParse(Console.ReadLine(), out int value))
        {
            Route[] array = Route.GetRouteArray(value);
            Console.WriteLine();
            foreach (var route in array)
            {
                Console.WriteLine(route);
                Console.WriteLine();


            }

            Console.WriteLine(Route.SearchRoute(array));
        }
        else
        {
            Console.WriteLine("Количесвто маршрутов не опредлено ");
        }
    }
  }

}