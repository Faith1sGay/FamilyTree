using System;

namespace FamilyTree
{
    class Program
    {
        public static Person Person = null;
        static void Main(string[] args)
        {
            Console.WriteLine("Person name?\n");
            var a = Console.ReadLine();
            Console.WriteLine("Person Age?\n");
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine("Person Year of Birth?\n");
            var c = int.Parse(Console.ReadLine());
            Console.WriteLine("Is the person alive? (True / False)\n");
            var d = bool.Parse(Console.ReadLine());
            if (d == false)
            {
                Console.WriteLine("Person Year of Death?\n");
                var e = int.Parse(Console.ReadLine());
                var P = new Person
                {
                    Name = a,
                    Age = b,
                    YearOfBirth = c,
                    Alive = d,
                    YearOfDeath = e
                };
                Console.WriteLine("___________________");
                Console.WriteLine("|                 |");
                Console.WriteLine($"|    Name: {P.Name}     |");
                Console.WriteLine($"|    Age: {P.Age}      |");
                Console.WriteLine($"|    YearOfBirth: {P.YearOfBirth} |");
                Console.WriteLine($"|    Alive: {P.Alive}|");
                Console.WriteLine($"|    YearOfDeath: {P.YearOfDeath} |");
                Console.ReadKey();
            }
            var p = new Person
            {
                Name = a,
                Age = b,
                YearOfBirth = c,
                Alive = d,
            };
            Console.WriteLine("___________________");
            Console.WriteLine("|                 |");
            Console.WriteLine($"|    Name: {p.Name}     |");
            Console.WriteLine($"|    Age: {p.Age}      |");
            Console.WriteLine($"|    YearOfBirth: {p.YearOfBirth} |");
            Console.WriteLine($"|    Alive: {p.Alive}|");
            Console.ReadKey();
        }
    }
}
