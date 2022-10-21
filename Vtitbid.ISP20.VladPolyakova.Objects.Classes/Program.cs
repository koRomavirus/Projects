using System.ComponentModel.DataAnnotations;
using System.Threading;

namespace Vtitbid.ISP20.VladPolyakova.Objects.Classes
{
    public class Program
    {


        static void Main(string[] args)
        {
            bool repeat = true;
            Note[] notes = new Note[3];
            while (repeat == true)
            {

                for (int i = 0; i < notes.Length; i++)
                {
                    notes[i] = new Note();

                    Console.Write("Введите имя:");
                    notes[i].FirstName = Console.ReadLine();
                    if (notes[i].FirstName == string.Empty)
                    {
                        Console.WriteLine("Неправильно");
                        break;

                    }


                    Console.Write("Введите фамилию:");
                    notes[i].LastName = Console.ReadLine();
                    if (notes[i].LastName == string.Empty)
                    {

                        Console.WriteLine("Неправильно");
                        break;
                    }

                    Console.Write($"Введите номер телефона:");


                    int result;
                    if (int.TryParse(Console.ReadLine(), out result))
                    {
                        notes[i].PhoneNumber = result;
                    }
                    else
                    {
                        Console.WriteLine("Неправильно");
                        break;
                    }

                    Console.WriteLine("Введите дату рождения в след виде: день рождения<Enter>,месяц рождения<Enter>,год рождения<Enter>");

                    if (int.TryParse(Console.ReadLine(), out result))
                    {
                        notes[i].DaysBirth = result;
                    }
                    else
                    {
                        Console.WriteLine("Неправильно");
                        break;
                    }


                    if (int.TryParse(Console.ReadLine(), out result))
                    {
                        notes[i].MonthBirth = result;
                    }
                    else
                    {
                        Console.WriteLine("Неправильно");
                        break;
                    }

                    if (int.TryParse(Console.ReadLine(), out result))
                    {
                        notes[i].YearBirth = result;
                    }
                    else
                    {
                        Console.WriteLine("Неправильно");
                        break;
                    }

                    repeat = false;
                }
            }
            Console.WriteLine("Студенты:\n");
            for (int i = 0; i < notes.Length; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (notes[i].YearBirth == notes[j].YearBirth)
                    {
                        if (notes[i].MonthBirth == notes[j].MonthBirth)
                        {
                            if (notes[i].DaysBirth == notes[j].DaysBirth)
                            {
                                Note temp;

                                temp = notes[i];
                                notes[i] = notes[j];
                                notes[j] = temp;
                            }
                            else
                            {
                                if (notes[i].DaysBirth < notes[j].DaysBirth)
                                {
                                    Note temp;

                                    temp = notes[i];
                                    notes[i] = notes[j];
                                    notes[j] = temp;
                                }
                            }
                        }
                        else
                        {
                            if (notes[i].MonthBirth < notes[j].MonthBirth)
                            {
                                Note temp;

                                temp = notes[i];
                                notes[i] = notes[j];
                                notes[j] = temp;
                            }
                        }


                    }
                    else
                    {
                        if (notes[i].YearBirth < notes[j].YearBirth)
                        {
                            Note temp;

                            temp = notes[i];
                            notes[i] = notes[j];
                            notes[j] = temp;
                        }
                    }

                }
            }


            for (int i = 0; i < notes.Length; i++)
            {
                Console.WriteLine(notes[i]);

            }
            Console.WriteLine("Выберите студента по номеру телефона:");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < notes.Length; i++)
            {
                if (number != notes[i].PhoneNumber)
                {
                    Console.WriteLine("Такого нет");
                }


            }
            for (int i = 0; i < notes.Length; i++)
            {
                if (notes[i].PhoneNumber == number)
                {
                    Console.WriteLine(notes[i]);
                }
                else
                {

                }
            }

           

        }

    }
}