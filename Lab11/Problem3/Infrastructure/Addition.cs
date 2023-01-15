namespace Lab11.Problem3.Infrastructure {
    internal class Addition : ICalculationStrategy {
        public int Calculate(int x, int y) => x + y;
    }
}
