namespace Lab7.Problem3 {
    internal class Ferrari : IFerrari {
        public string Model { get; set; } = "488-Spider";

        public void Brake() {
            Console.Write("Brakes!");
        }

        public void Accelerate() {
            Console.Write("Zadu6avam sA!");
        }

    }
}
