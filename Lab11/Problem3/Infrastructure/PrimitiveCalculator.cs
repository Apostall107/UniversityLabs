namespace Lab11.Problem3.Infrastructure {
    internal class PrimitiveCalculator {
        private ICalculationStrategy _calculationStrategy;

        public PrimitiveCalculator() : this(new Addition()) {
        }

        public PrimitiveCalculator(ICalculationStrategy calculationStrategy) {
            _calculationStrategy = calculationStrategy;
        }

        public void SwitchStrategy(ICalculationStrategy calculationStrategy) => _calculationStrategy = calculationStrategy;

        public int Calculate(int x, int y) => _calculationStrategy.Calculate(x, y);
    }
}
