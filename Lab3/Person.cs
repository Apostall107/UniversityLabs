
namespace Lab1 {

    public class Person {
        private string name;
        private int age;

        public string Name {
            get { return name; }
            set { name = value; }
        }

        public int Age {
            get { return age; }
            set { age = value; }
        }

        // Constructor 1: No arguments 
        public Person() {
            name = "No Name";
            age = 1;
        }

        // Constructor 2: Age as argument 
        public Person(int age) : this() {
            this.age = age;
        }

        // Constructor 3: Name and age as arguments 
        public Person(string name, int age) : this(age) {
            this.name = name;
        }

        public static void createSortPeopleList() {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 0; i < n; i++) {
                string[] tokens = Console.ReadLine().Split();
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                Person person = new Person(name, age);
                people.Add(person);
            }

            people = people
              .Where(p => p.Age > 30)
              .OrderBy(p => p.Name)
              .ToList();

            Console.WriteLine("\n Sorted");

            foreach (Person p in people) {
                Console.WriteLine($"{p.Name} - {p.Age}");
            }
        }

    }

}