using System.Text;

namespace Lab7.Problem8 {
    internal class Engineer : SpecialisedSoldier, IEngineer {
        public Engineer(string firstName, string lastName, int id, double sallary, string corps, List<string> repair)
            : base(firstName, lastName, id, sallary, corps) {
            Repair = repair;
        }

        public List<string> Repair { get; set; }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            foreach (var item in this.Repair) {
                sb.AppendLine("   " + item.ToString());
            }

            return base.ToString() + sb.ToString();
        }
    }
}
