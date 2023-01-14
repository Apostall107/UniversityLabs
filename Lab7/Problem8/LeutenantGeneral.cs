using System.Collections;
using System.Text;

namespace Lab7.Problem8 {
    // LeutenantGeneral Class
    internal class LeutenantGeneral : Private, ILeutenantGeneral {
        public LeutenantGeneral(string firstName, string lastName, int id, double sallary, List<Private> privates) 
            : base(firstName, lastName, id, sallary) {
            Privates = privates;
        }

        public List<Private> Privates { get; set; }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Privates:");
            foreach (var item in this.Privates) {
                sb.AppendLine("   " + item.ToString());
            }

            return base.ToString() + sb.ToString();
        }


    }
}
