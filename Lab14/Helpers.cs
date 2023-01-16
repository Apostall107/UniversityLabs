using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    internal static class Helpers
    {
        public static List<Student> GetStudentsByGroup()
        {
            var students = new List<Student>();
            var input = Console.ReadLine()
                .Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "END")
            {
                if (input.Length != 3)
                {
                    input = Console.ReadLine()
                        .Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                    continue;
                }

                if (int.TryParse(input.Last(), out int group))
                    students.Add(new Student { FirstName = input[0], LastName = input[1], Group = group });

                input = Console.ReadLine()
                        .Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            }

            return students;
        }

        public static List<KeyValuePair<string, string>> GetStudentsByFirstName()
        {
            var students = new List<KeyValuePair<string, string>>();
            var input = Console.ReadLine()
                .Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "END")
            {

                if (input.Length == 2)
                    students.Add(new KeyValuePair<string, string>(input[0], input[1]));

                input = Console.ReadLine()
                    .Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            }

            return students;
        }

        public static Dictionary<string, int> GetStudentsByAge()
        {
            var students = new Dictionary<string, int>();
            var input = Console.ReadLine();

            while (input != "END")
            {
                var indexOfLastSpace = input.LastIndexOf(' ');// Mike Anderson 12

                if (indexOfLastSpace >= 1 && int.TryParse(input.Substring(indexOfLastSpace + 1), out int age))
                {
                    students[input.Substring(0, indexOfLastSpace)] = age;
                }

                input = Console.ReadLine();
            }

            return students;
        }

        public static List<Student> SortStudents()
        {
            var students = new List<Student>();
            var input = Console.ReadLine().Split();

            while (input[0] != "END")
            {
                if (input.Length == 2)
                {
                    students.Add(new Student { FirstName = input[0], LastName = input[1] });
                }
                input = Console.ReadLine().Split();
            }

            return students;
        }

        public static List<string> FilterStudentsByEmail(Func<string, bool> predicate)
        {
            var students = new List<string>();
            var input = Console.ReadLine();

            while (input != "END")
            {
                var lastSpaceIndex = input.LastIndexOf(' ');
                if (lastSpaceIndex > 0 && predicate.Invoke(input))
                {
                    students.Add(input.Substring(0, lastSpaceIndex));
                }

                input = Console.ReadLine();
            }
            return students;
        }

        public static List<KeyValuePair<string, string>> FilterStudentsByPhone()
        {
            var students = new List<KeyValuePair<string, string>>();
            var input = Console.ReadLine();

            while (input != "END")
            {
                var lastSpaceIndex = input.LastIndexOf(' ');

                if (lastSpaceIndex > 1)
                {
                    var phone = input.Substring(lastSpaceIndex + 1);
                    var name = input.Substring(0, lastSpaceIndex);
                    students.Add(new KeyValuePair<string, string>(name, phone));
                }

                input = Console.ReadLine();
            }

            return students;
        }

        public static List<string> GetExcelentStudents()
        {
            var students = new List<string>();
            var input = Console.ReadLine();

            while (input != "END")
            {
                students.Add(input);

                input = Console.ReadLine();
            }

            return students;
        }

        public static List<Student> GetWeekStudents()
        {
            var students = new List<Student>();
            var input = Console.ReadLine()
                .Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "END")
            {
                var name = string.Join(" ", input.Where(x => char.IsLetter(x[0])));
                var marks = input.Where(x => char.IsDigit(x[0])).Select(int.Parse);

                var current = new Student { FullName = name, Marks = new List<int>(marks) };

                if (students.Contains(current))
                {
                    var toUpdate = students.Where(x => x.Equals(current)).First();
                    toUpdate.Marks = toUpdate.Marks.Concat(marks).ToList();
                }
                else
                {
                    students.Add(current);
                }

                input = Console.ReadLine()
                    .Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            }

            return students;
        }

        public static List<Student> GetEnrolledStudents()
        {
            var students = new List<Student>();
            var input = Console.ReadLine()
                .Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "END")
            {
                students.Add(new Student
                {
                    Id = input[0],
                    Marks = input.Skip(1).Select(int.Parse).ToList()
                });

                input = Console.ReadLine()
                    .Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            }

            return students;
        }

        public static List<Student> GetStudentsForGroupBy()
        {
            var students = new List<Student>();
            var input = Console.ReadLine();

            while (input != "END")
            {
                var lastSpaceIndex = input.LastIndexOf(' ');

                if (lastSpaceIndex > 0)
                {
                    students.Add(new Student
                    {
                        FullName = input.Substring(0, lastSpaceIndex),
                        Group = int.Parse(input.Substring(lastSpaceIndex + 1))
                    });
                }

                input = Console.ReadLine();
            }

            return students;
        }

        public static List<Student> GetStudentsForSpecs()
        {
            var students = new List<Student>();
            var input = Console.ReadLine().Trim();

            while (input != "END")
            {
                var indexOfFirstSpace = input.IndexOf(' ');

                if (indexOfFirstSpace > 0)
                {
                    students.Add(new Student
                    {
                        FullName = input.Substring(indexOfFirstSpace + 1).Trim(),
                        Faculty = input.Substring(0, indexOfFirstSpace).Trim()
                    });
                }

                input = Console.ReadLine().Trim();
            }

            return students;
        }

        public static List<StudentsSpecialities> GetSpecs()
        {
            var specialities = new List<StudentsSpecialities>();
            var input = Console.ReadLine().Trim();

            while (input != "Students:")
            {
                var indexOfLastSpace = input.LastIndexOf(' ');

                if (indexOfLastSpace > 0)
                {
                    specialities.Add(new StudentsSpecialities
                    {
                        Name = input.Substring(0, indexOfLastSpace).Trim(),
                        Faculty = input.Substring(indexOfLastSpace + 1).Trim()
                    });
                }

                input = Console.ReadLine().Trim();
            }

            return specialities;
        }
    }
}
