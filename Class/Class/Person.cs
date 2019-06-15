using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    class Person
    {
        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public Person(string firstName, string lastName)
            : this(firstName, lastName, 0)
        {
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        private string Inn;
        public string Hello()
        {
            return $"Hi! My name is {FirstName} {LastName}";
        }
    }
}
