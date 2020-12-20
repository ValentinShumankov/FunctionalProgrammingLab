using System;

namespace Filter_by_Age
{
    class Program
    {
        static void Main( string [ ] args )
        {
            int countPeople = int.Parse(Console.ReadLine());
            Person[] people = new Person[countPeople];
            for (int i = 0; i < countPeople; i++)
            {
                var input = Console.ReadLine()
                    .Split(", ",StringSplitOptions.RemoveEmptyEntries);
                people [ i ] = new Person( ) { Name = input [ 0 ], Age = int.Parse(input [ 1 ]) };
            }
            string condition = Console.ReadLine();
            int ageToFilter = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();
            Func<Person,bool> conditionDelegate = getCondition(condition,ageToFilter);
            Action<Person> printerDelegate = GetPrinter(format);
            //  FilterPerson(people,conditionDelegate,printerDelegate);
            //  FilterPerson(people, p => p.Name.Length == 4, printerDelegate);
            
            static void FilterPerson( Person [ ] people,
                Func<Person, bool> filter,
                Action<Person> printer )
            {
                foreach (var person in people)
                {
                    if (filter(person))
                    {
                        printer(person);
                    }
                }

            }


            static Action<Person> GetPrinter( string format )
            {
                switch (format)
                {
                    case "name":
                        return p => { Console.WriteLine($"{p.Name}"); };
                    case "age":
                        return p => { Console.WriteLine($"{p.Age}"); };
                    case "name age":
                        return p => { Console.WriteLine($"{p.Name} - {p.Age}"); };
                    default:
                        return null;

                }
            }


            static Func<Person, bool> getCondition( string condition, int age )
            {
                switch (condition)
                {
                    case "younger": return p => p.Age < age;
                    case "older": return p => p.Age >= age;
                    default:
                        return null;
                }
            }
        }

        class Person
        {
            public int Age { get; set; }
            public string Name { get; set; }
        }
    }
}
