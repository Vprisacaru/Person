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

        public int Tag 
        {
            get { return tag}
            set { tag = value}
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

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(this, obj)) return true;
            if (obj is not Person other) return false;

            string a1 = FirstName ?? string.Empty;
            string b1 = LastName ?? string.Empty;
            string a2 = other.FirstName ?? string.Empty;
            string b2 = other.LastName ?? string.Empty;


            return string.Equals(a1, a2, StringComparison.OrdinalIgnoreCase)
            && string.Equals(b1,b2, StringComparison.OrdinalIgnoreCase) && Age == other.Age;
          
        }
        public override int GetHashCode()
        {
            string f = (FirstName ?? string.Empty).ToLowerInvariant();
            string l = (LastName ?? string.Empty).ToLowerInvariant();
            return HashCode.Combine(f, l, Age);
        }
    }

    class Program
    {
        static void Main()
        {
            Person p1 = new Person("Maria", "Rusu", 22);                            
            Person p2 = new Person("Maria", "Rusu", 22);                            
            Person p3 = new Person("Maria", "Rusu", 22);                            
            Person p4 = new Person("Maria", "Rusu", 22);                            
            Person p5 = new Person("Maria", "Rusu", 22);
            Person p6 = new Person("Igor", "Popescu", 30);
            Person p7 = new Person("Maria", "Rusu", 22);
                

          var set = new HashSet<Person>();
            set.Add(p1);
            set.Add(p2);
            set.Add(p3);
            set.Add(p4);
            set.Add(p5);
            set.Add(p6);
            set.Add(p7);

            Console.WriteLine(set.Count);

        }

    }
}
