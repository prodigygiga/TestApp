using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PrivateNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsMarried { get; set; }
        public Decimal Height { get; set; }

        public Person() { }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Person(string firstName, string lastName, string privateNumber, DateTime birthDate, bool isMarried, decimal height)
        {
            PrivateNumber = privateNumber;
            BirthDate = birthDate;
            IsMarried = isMarried;
            Height = height;
            FirstName = firstName;
            LastName = lastName;
        }

        public int CalculateAndDisplayAge()
        {
            int age = 0;
            if (this.BirthDate != default(DateTime))
            {
                // Save today's date.
                var today = DateTime.Today;

                // Calculate the age.
                age = today.Year - this.BirthDate.Year;

                // Go back to the year in which the person was born in case of a leap year
                if (this.BirthDate.Date > today.AddYears(-age)) age--;
            }
            else
            {
                throw new Exception("Birth Date not provided!");
            }

            return age;
        }

    }
}
