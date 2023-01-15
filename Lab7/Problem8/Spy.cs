using System.Text;

namespace Lab7.Problem8 {
    internal class Spy : Soldier, ISpy {
        public Spy(string firstName, string lastName, int id, int codeNum)
            : base(id, firstName, lastName) {
            CodeNumber = codeNum;
        }

        public int CodeNumber { get; set; }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CodeNumber: " + this.CodeNumber);

            return base.ToString() + sb.ToString();
        }
    }
}
