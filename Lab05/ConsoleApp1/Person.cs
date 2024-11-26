using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // class declaration
    public class Person
    {
        // constructor
        public Person(string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }

        // properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string EmailAddress { get; set; }

        // method
        public string GetFullName()
        {
            return $"{FirstName} {LastName} ";
        }
        /* zadanie 3 */
        public double GetAge()
        {
            return (DateTime.Now - BirthDate).TotalDays / 365;
        }
        public bool IsAdualt()
        {
            return this.GetAge() >= 18;
        }
        /* komiec 3 */
    }
}