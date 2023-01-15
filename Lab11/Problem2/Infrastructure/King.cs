namespace Lab11.Problem2.Infrastructure {
    internal class King {
        public event EventHandler BeingAttacked;
        public string Name { get; private set; }

        public King(string name) {
            Name = name;
        }

        public void OnBeingAttacked() {
            Console.WriteLine($"King {Name} is under attack!");
            BeingAttacked?.Invoke(this, new EventArgs());
        }
    }
}
