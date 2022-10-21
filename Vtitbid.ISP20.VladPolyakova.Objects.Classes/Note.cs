using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtitbid.ISP20.VladPolyakova.Objects.Classes
{


    public class Note
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int PhoneNumber { get; set; }

        public int DaysBirth { get; set; }
        public int MonthBirth { get; set; }
        public int YearBirth { get; set; }
        public Note()
        {

        }
        public Note(string firstName, string lastName, int phoneNumber, int daysBirth, int monthBirth, int yearBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            DaysBirth = daysBirth ;
            MonthBirth = monthBirth;
            YearBirth = yearBirth;
        }

        public override string ToString()
        {
            return $"Имя: {FirstName}, Фамилия: {LastName}, Номер телефона: {PhoneNumber}, Др: {DaysBirth}.{MonthBirth}.{YearBirth}\n";
        }
    }


}

