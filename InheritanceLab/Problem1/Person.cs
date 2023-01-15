namespace InheritanceLab.Problem1 {
    internal class Person {
        private string _name;
        private int _age;

        public Person(string name, int age) {
            Name = name;
            Age = age;
        }

        public virtual int Age {
            get => _age;
            set {
                if (value < 0)
                    throw new ArgumentException("Age must be positive!");

                _age = value;
            }
        }

        public virtual string Name {
            get => _name;
            set {
                if (value.Length < 3)
                    throw new ArgumentException("Name`s length shouldn`t be less than 3 symbols!");

                _name = value;
            }
        }

        public override string ToString() {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}
