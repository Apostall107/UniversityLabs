
using Lab3;
using Lab3.CarFolder;
using Lab3.CarFolder.CarV3;

namespace Lab1 {
    public class Program {
        public static void Main(string[] args) {
            // Creating Person objects: 
            Person pesho = new Person("Pesho", 20);
            Person gosho = new Person("Gosho", 18);
            Person stamat = new Person("Stamat", 43);

            Person anonymous = new Person();
            Person anonymous2 = new Person(30);

            Family family = new Family();

            family.AddMember(pesho);
            family.AddMember(gosho);
            family.AddMember(stamat);

            family.GetOldestMember();

            /*--------------------------------------------4 PROBLEM---------------------------------*/
            Console.WriteLine("4 problem");
            Console.WriteLine("begin");

            Person.createSortPeopleList();

            Console.WriteLine("end");
            /*--------------------------------------------5 PROBLEM---------------------------------*/
            Console.WriteLine("5 problem");
            Console.WriteLine("begin");

            DateModifier dateModifier = new DateModifier();

            var daysOfDiff = dateModifier.GetDifferenceInDays("1999 02 05", "2023 01 01");

            Console.WriteLine("end");
            /*--------------------------------------------6 PROBLEM---------------------------------*/

            Console.WriteLine("6 problem");
            Console.WriteLine("begin");

            Employee.readAndSortEmployees();

            Console.WriteLine("end");
            /*--------------------------------------------7 PROBLEM---------------------------------*/
            Console.WriteLine("7 problem");
            Console.WriteLine("begin");

            Car.CheckCarDriveDistanceAvaliable();

            Console.WriteLine("end");
            /*--------------------------------------------8 PROBLEM---------------------------------*/
            Console.WriteLine("8 problem");
            Console.WriteLine("begin");

            CarV2.Problem8Task();

            Console.WriteLine("end");
            /*--------------------------------------------9 PROBLEM---------------------------------*/
            Console.WriteLine("9 problem");
            Console.WriteLine("begin");

            Console.WriteLine(Rectangle.EnterValue());

            Console.WriteLine("end");
            /*--------------------------------------------10 PROBLEM---------------------------------*/
            Console.WriteLine("10 problem");
            Console.WriteLine("begin");

            CarV3.Problem10Task();

            Console.WriteLine("end");
        }
    }
}