using System.Globalization;

namespace Lab3 {
    public class Employee {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        public Employee(string name, decimal salary, string position, string department, string email, int age) {
            this.Name = name;
            this.Salary = salary;
            this.Position = position;
            this.Department = department;
            this.Email = email;
            this.Age = age;
        }

        public static void readAndSortEmployees() {
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";

            int n = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < n; i++) {
                string[] tokens = Console.ReadLine().Split();
                string name = tokens[0];
                decimal salary = decimal.Parse(tokens[1], provider);
                string position = tokens[2];
                string department = tokens[3];
                string email = tokens.Length > 4 ? tokens[4] : null;
                int age = tokens.Length > 5 ? int.Parse(tokens[5]) : 0;

                Employee employee = new Employee(name, salary, position, department, email, age);
                employees.Add(employee);
            }

            var highestAverageSalaryDep = employees
              .GroupBy(e => e.Department)
              .OrderByDescending(g => g.Average(e => e.Salary))
              .First();

            Console.WriteLine($"Highest Average Salary: {highestAverageSalaryDep.Key}");

            var employeesBySalary = highestAverageSalaryDep
              .OrderByDescending(e => e.Salary);

            foreach (Employee employee in employeesBySalary) {
                Console.WriteLine(employee);
            }
        }


        public override string ToString() {
            string output = $"{Name} {Salary:f2}";
            output += Email != null ? $" {Email}" : " n/a";
            output += Age != 0 ? $" {Age}" : " -1";

            return output;
        }
    }
}

