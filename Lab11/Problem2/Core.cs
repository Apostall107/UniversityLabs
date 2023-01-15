using Lab11.Problem2.Infrastructure;

namespace Lab11.Problem2 {
    internal class Core {
        private King _king;
        private List<Person> _soldiers;

        public Core() {
            _soldiers = new List<Person>();
        }

        public void Start() {
            InitiateCore();
            Execute();
        }

        private void Die(string name) {
            var person = _soldiers.FirstOrDefault(x => x.Name == name);
            _king.BeingAttacked -= person.OnBeingAttacked;
            _soldiers.Remove(person);
        }

        private void InitiateCore() {
            var kingName = Console.ReadLine();
            _king = new King(kingName);

            var royalGuardNames = Console.ReadLine().Split();
            foreach (var name in royalGuardNames) {
                var royalGuard = new RoyalGuard(name);
                _soldiers.Add(royalGuard);
                _king.BeingAttacked += royalGuard.OnBeingAttacked;
            }

            var footmanNames = Console.ReadLine().Split();
            foreach (var name in footmanNames) {
                var footman = new Footman(name);
                _soldiers.Add(footman);
                _king.BeingAttacked += footman.OnBeingAttacked;
            }
        }

        private void Execute() {
            var cmd = Console.ReadLine().Split();

            while (cmd[0].ToLower() != "end") {
                switch (cmd[0]) {
                    case "Attack":
                    _king.OnBeingAttacked();
                    break;
                    case "Kill":
                    Die(cmd[1]);
                    break;
                    default:
                    break;
                }

                cmd = Console.ReadLine().Split();
            }
        }
    }
}
