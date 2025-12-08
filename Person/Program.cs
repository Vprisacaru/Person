using System;

namespace Person
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value == null)
                    firstName = "";
                else
                    firstName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (value == null)
                    lastName = "";
                else
                    lastName = value;
            }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Person(string f, string l, int a)
        {
            FirstName = f;
            LastName = l;
            Age = a;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + ", " + Age + " ani";
        }
    }

    class Program
    {
        static void Main()
        {
            Person p1 = new Person("Maria", "Rusu", 22);
            Person p2 = new Person(null, "Popescu", 30);

            Console.WriteLine("Pana la schimbare");
            Console.WriteLine(p1);
            Console.WriteLine(p2);

            Console.WriteLine("Dupa schimbare");

            p1.Age = 30;
            p1.LastName = "Monca";
            p1.FirstName = "Test";

            Console.WriteLine(p1);
        }

    }
}
