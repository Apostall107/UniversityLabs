using System.Text;

namespace InheritanceLab.Problem3 {
    internal class Worker : Human {
        private decimal _weekSalary;
        private int _workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, int workHours)
            : base(firstName, lastName) {
            WeekSalary = weekSalary;
            WorkingHours = workHours;
        }

        private decimal WeekSalary {
            get => _weekSalary;
            set {
                if (value <= 10)
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");

                _weekSalary = value;
            }
        }

        private int WorkingHours {
            get => _workHoursPerDay;
            set {
                if (value < 1 || value > 12)
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");

                _workHoursPerDay = value;
            }
        }

        private object GetSalaryPerHour() {
            return (WeekSalary / 5) / WorkingHours;
        }

        public override string ToString() {
            var builder = new StringBuilder();
            builder.Append(base.ToString())
                .AppendLine($"Week Salary {WeekSalary:F2}")
                .AppendLine($"Hours per day {WorkingHours:F2}")
                .AppendLine($"Salary per hour {GetSalaryPerHour():F2}");

            return builder.ToString();
        }
    }
}
