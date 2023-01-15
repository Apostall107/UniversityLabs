using System.Text;

namespace Lab7.Problem8 {
    // Private Class
    internal class Private : Soldier, IPrivate {
        private double _salary;

        public Private(string firstName, string lastName, int id, double sallary)
            : base(id, firstName, lastName) {
            _salary = sallary;
        }

        public double Salary {
            get { return _salary; }
            set { _salary = double.Parse(value.ToString("#0.00")); }
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Salary: " + this.Salary);
            return base.ToString() + sb.ToString();
        }
    }


}
