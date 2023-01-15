using System.Text;

namespace InheritanceLab.Problem3 {
    internal class Human {
        private string _firstName;
        private string _lastName;

        public Human(string firstName, string lastName) {
            FirstName = firstName;
            LastName = lastName;
        }

        private string FirstName {
            get => _firstName;
            set {
                if (char.IsLower(value[0]))
                    throw new ArgumentException("Expected upper case letter! Argument: firstName");

                if (value.Length < 4)
                    throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");

                _firstName = value;
            }
        }

        private string LastName {
            get => _lastName;
            set {
                if (char.IsLower(value[0]))
                    throw new ArgumentException("Expected upper case letter! Argument: lastName");

                if (value.Length < 3)
                    throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");

                _lastName = value;
            }
        }

        public override string ToString() {
            var builder = new StringBuilder();
            builder.AppendLine($"First Name: {FirstName}")
                .AppendLine($"Last Name: {LastName}");

            return builder.ToString();
        }
    }
}
