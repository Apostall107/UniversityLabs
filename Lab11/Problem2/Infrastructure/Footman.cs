namespace Lab11.Problem2.Infrastructure {
    internal class Footman : Person {
        public Footman(string name) : base(name) {
        }

        public override void OnBeingAttacked(object sender, EventArgs args) {
            Console.WriteLine($"Footman {Name} is panicking!");
        }
    }
}
