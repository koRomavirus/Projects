using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VtitBid.ISP20.Vlad.BIll_
{
    public class Bill 
    {
        public string PayerBill { get; set; }
        public string RecipentBill { get; set; }
        public int Amount { get; set; }

        public Bill(string payerBill, string recipentBill, int amount)
        {
            PayerBill = payerBill;
            RecipentBill = recipentBill;
            Amount = amount;
        }

        public static Bill CreateBill()
        {

            Console.Write("Введите расчетный счет плательщика: ");
            var payerBill = ChekName(Console.ReadLine(), nameof(PayerBill));
            Console.Write("Введите расчетный счет получателя: ");
            var recipentBill = ChekName(Console.ReadLine(), nameof(RecipentBill));
            Console.Write("Введите сумму начисления: ");
            bool CheckOfAmount = int.TryParse(Console.ReadLine(), out int value);
            if (CheckOfAmount)
            {

                int amount = value;
                return new Bill(payerBill, recipentBill, amount);

            }
            else
            {
                Console.WriteLine("Ошибка ввода данных");
                Environment.Exit(0);
            }
            return null;
        }
        public static Bill[] GetBillArray(int count)
        {
            Bill[] routes = new Bill[count];

            for (int i = 0; i < routes.Length; i++)
            {
                routes[i] = CreateBill();
            }

            return routes;
        }
        private static string ChekName(string input, string fieldName = "")
        {

            switch (fieldName)
            {
                case nameof(PayerBill):
                    if (!string.IsNullOrEmpty(input))
                    { return input; }
                    else { return "Расчетный счет плательщика не определен"; }
                    break;
                case nameof(RecipentBill):
                    if (!string.IsNullOrEmpty(input))
                    { return input; }
                    else { return "Расчетный счет получателя не определен"; }
                    break;

            }
            return "Ошибка ввода";

        }
        public static int SearchBill(Bill[] routes)
        {
            int count = 0;
            Console.Write("Введите расчетный счет плательщика: ");
            string input = Console.ReadLine();
            Console.WriteLine();
            if (string.IsNullOrEmpty(input))
                return -1;
            for (int i = 0; i < routes.Length; i++)
            {
                if (input == routes[i].PayerBill)
                {

                    Console.WriteLine(routes[i]);

                }
                {
                    count++;
                }
                if (count == routes.Length) { return -1; }
            }

            return 0;

        }
 
        public override string ToString()
        {

            return $"Расчетный счет плательщика: {PayerBill} \nРасчетный счет получателя: {RecipentBill}\nСумма начисления: {Amount}";
        }

    }
}