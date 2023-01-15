namespace Lab11.Problem2.Infrastructure {
    internal class RoyalGuard : Person {
        public RoyalGuard(string name) : base(name) {
        }

        public override void OnBeingAttacked(object sender, EventArgs args) {
            Console.WriteLine($"Royal Guard {Name} is defending!");
        }
    }
}
