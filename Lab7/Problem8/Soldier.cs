using System.Text;

namespace Lab7.Problem8 {
    // Soldier Class
    internal class Soldier : ISoldier {
        public Soldier(int id, string firstName, string lastName) {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("FirstName: " + this.FirstName);
            sb.AppendLine("LastName: " + this.LastName);
            sb.AppendLine("Id: " + this.Id);
            return   sb.ToString();
        }
    }


}
