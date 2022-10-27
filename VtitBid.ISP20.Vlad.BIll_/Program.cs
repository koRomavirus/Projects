namespace VtitBid.ISP20.Vlad.BIll_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите кол-во операций:");
            if (int.TryParse(Console.ReadLine(), out int value))
            {
                Bill[] array = Bill.GetBillArray(value);

                Console.WriteLine();
                foreach (var route in array)
                {
                    Console.WriteLine(route);
                    Console.WriteLine();
                }

                Bill.SearchBill(array);

            }
            else
            {
                Console.WriteLine("кол-во операций не опредлено ");
            }




        }
    }
}