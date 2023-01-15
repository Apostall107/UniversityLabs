using System.Text;

namespace Lab7.Problem8 {
    internal class Commando : SpecialisedSoldier, ICommando {
        private string _state;


        public Commando(string firstName, string lastName, int id, double sallary, string corps, string codeName, string state)
            : base(firstName, lastName, id, sallary, corps) {
            State = state;
            CodeName = codeName;
        }

        public string State {
            get { return _state; }
            set {
                if (value == "inProgress" || value == "Finished") {
                    _state = value;
                } else {
                    _state = "";
                }
            }
        }
        public string CodeName { get; set; }

        public void CompleteMission() {
            _state = "Finished";
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Missions:");
            if (CodeName != "" || State != "") {
                sb.AppendLine($"{CodeName}Code Name: Freedom {State}: inProgress");
            }
            return base.ToString() + sb.ToString();
        }
    }
}
