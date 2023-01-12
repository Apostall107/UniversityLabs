using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab.Problem3
{
    internal class Student : Human
    {
        private string _facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            :base(firstName, lastName)
        {
            FacultyNumber = facultyNumber;
        }

        private string FacultyNumber
        {
            get => _facultyNumber;
            set
            {
                if (value.Length < 5 || value.Length > 10)
                    throw new ArgumentException("Invalid faculty number!");

                _facultyNumber = value;
            }
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.Append(base.ToString())
                .AppendLine($"Faculty numver: {FacultyNumber}");

            return builder.ToString();
        }
    }
}
