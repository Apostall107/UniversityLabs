namespace Lab5 {
    internal class Chicken {
        Random _random = new Random();

        private int _age;
        private string _name;
        private int _productPerDay;

        public Chicken(string name, int age) {
            Age = age;
            Name = name;
            _productPerDay = _random.Next(1, 10);
        }

        private int Age {
            get { return _age == null ? 0 : _age; }
            set {
                if (value > 15 || value < 0) {
                    Console.WriteLine("Age should be between 0 and 15.");
                } else {
                    _age = value;
                }
            }
        }
        private string Name {
            get { return _name == null ? "No name set" : _name; }
            set {
                if (value == string.Empty || string.IsNullOrWhiteSpace(value)) {
                    Console.WriteLine("Name cannot be empty.");
                } else {
                    _name = value;
                }
            }
        }

        public string ProductPerDay {
            get { return CalculateProductPerDay(); }
        }

        private string CalculateProductPerDay() {
            return $" Chicken {Name} ({Age}) can produce- {_productPerDay} eggs per day";

        }


    }
}

