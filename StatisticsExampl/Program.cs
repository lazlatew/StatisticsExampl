namespace StatisticsExampl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); 

            List<Person> people = new List<Person>(); //list za horata

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age); // susdv na objct
                people.Add(person); // advam v spisuka
            }
            
            // 30 > godini & sort po A-red
            List<Person> filtered = people
                .Where(p => p.Age > 30)
                .OrderBy(p => p.Name)
                .ToList();

            // Izhod

            foreach (var person in filtered)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
