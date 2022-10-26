using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtitbid.ISP20.VladNote_
{


    public class Note
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long NumberOfPhone { get; set; }

        public Note(string firstName, string secondName, int numberOfPhone)
        {
            FirstName = firstName;
            LastName = secondName;
            NumberOfPhone = numberOfPhone;
        }

        public static Note CreateNote()
        {

            Console.Write("Введите имя: ");
            var firstName = ChekName(Console.ReadLine(), nameof(FirstName));
            Console.Write("Введите фамилию: ");
            var secondName = ChekName(Console.ReadLine(), nameof(LastName));
            Console.Write("Введите номер телефона: ");
            bool CheckOfNumberOfPhone = int.TryParse(Console.ReadLine(), out int value);
            if (CheckOfNumberOfPhone)
            {

                int numberOfPhone = value;
                return new Note(firstName, secondName, numberOfPhone);

            }
            else
            {
                Console.WriteLine("Ошибка ввода данных");
            }
            return null;
        }
        public static Note[] GetNoteArray(int count)
        {
            Note[] routes = new Note[count];

            for (int i = 0; i < routes.Length; i++)
            {
                routes[i] = CreateNote();
            }

            return routes;
        }
        private static string ChekName(string input, string fieldName = "")
        {

            switch (fieldName)
            {
                case nameof(FirstName):
                    if (!string.IsNullOrEmpty(input))
                    { return input; }
                    else { return "Имя не определено"; }
                    break;
                case nameof(LastName):
                    if (!string.IsNullOrEmpty(input))
                    { return input; }
                    else { return "Фамилия не определена"; }
                    break;

            }
            return null;

        }
        public static Note[] SearchNote(Note[] notes)
        {

            Console.WriteLine("Введите номер Телефона");
            if (!int.TryParse(Console.ReadLine(), out int numberOfPhone))
                return notes;
            for (int i = 0; i < notes.Length; i++)
            {
                if (numberOfPhone == notes[i].NumberOfPhone)
                {

                    Console.WriteLine(notes[i]);

                }

            }

            return notes;

        }
        public int CompareTo(object? o)
        {
            if (o is Note note) return NumberOfPhone.CompareTo(note.NumberOfPhone);
            else throw new ArgumentException("Некорректное значение параметра");
        }
        public override string ToString()
        {

            return $"Имя: {FirstName} \nФамилия: {LastName}\nНомер телефона: {NumberOfPhone}";
        }

    }

}

