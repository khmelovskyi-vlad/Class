using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            var bohdan = new Person("Bohdan", "Hukivs", 26);


            var vlad = new Person("Vlad", "Xmel");

            Person[] persons = new Person[2]
            {
                bohdan,
                vlad
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.Hello());
            }


            Console.ReadKey();
        }
    }
}
