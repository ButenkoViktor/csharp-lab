using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // class declaration
    public class Person
    {
        // constructor
        public Person(string firstName, string lastName, DateTime birthDate, string emailAddress)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
            this.EmailAddress = emailAddress;
        }
        // properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string EmailAddress { get; set; }

        // method
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
        public int GetAge()
        {
            return (int)(DateTime.Now - this.BirthDate).TotalDays / 365;
        }
        public bool IsAdult()
        {
            return GetAge() >= 18;
        }
    }
}
