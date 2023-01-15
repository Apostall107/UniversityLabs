namespace Lab11.Problem3.Infrastructure {
    internal class Division : ICalculationStrategy {
        public int Calculate(int x, int y) {
            if (y != 0)
                return x / y;
            else
                throw new DivideByZeroException($"Can`t divide by 0: {nameof(x)} = {x}; {nameof(y)} = {y}");
        }
    }
}
