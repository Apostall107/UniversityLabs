using System.Text;

namespace Lab7.Problem8 {
    // SpecialisedSoldier Class
    internal class SpecialisedSoldier : Private, ISpecialisedSoldier {

        private string _corps;

        public SpecialisedSoldier( string firstName, string lastName, int id, double sallary, string corps) 
            : base( firstName, lastName, id, sallary) {
            Corps= corps;
        }

        public string Corps {
            get { return _corps; }
            set {
                if (value == "Airforces" || value == "Marines") {
                    _corps = value;
                } else {
                    _corps = "";
                }
            }
        }
        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            if (_corps != "") {
                sb.AppendLine("Corps: " + this.Corps);
            }

            return base.ToString() +  sb.ToString();
        }



    }
}
