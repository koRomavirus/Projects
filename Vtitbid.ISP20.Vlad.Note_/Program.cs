using System.ComponentModel.DataAnnotations;
using System.Threading;

namespace Vtitbid.ISP20.VladNote_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите количество людей:");
            if (int.TryParse(Console.ReadLine(), out int value))
            {
                Note[] array = Note.GetNoteArray(value);
                Console.WriteLine();
                foreach (var note in array)
                {
                    Console.WriteLine(note);
                    Console.WriteLine();


                }
                Note.SearchNote(array);
            }
            else
            {
                Console.WriteLine("Количесвто людей не опредлено ");
            }



        }
    }
}