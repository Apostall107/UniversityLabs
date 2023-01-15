using Lab11.Problem3.Infrastructure;

namespace Lab11.Problem3 {
    internal class Core {
        private PrimitiveCalculator _calculator;
        private Dictionary<char, ICalculationStrategy> _strategyDictionary;

        public Core() {
            _calculator = new PrimitiveCalculator();
            _strategyDictionary = new Dictionary<char, ICalculationStrategy>();
            _strategyDictionary['+'] = new Addition();
            _strategyDictionary['-'] = new Substraction();
            _strategyDictionary['*'] = new Multiplication();
            _strategyDictionary['/'] = new Division();
        }

        public void Execute() {
            var cmd = Console.ReadLine().Split();
            while (cmd[0].ToLower() != "End") {
                if (cmd[0].ToLower().Equals("mode")) {
                    var strategy = _strategyDictionary[cmd[1][0]];
                    _calculator.SwitchStrategy(strategy);
                } else {
                    try {
                        int.TryParse(cmd[0], out var x);
                        int.TryParse(cmd[1], out var y);
                        int result = _calculator.Calculate(x, y);
                        Console.WriteLine(result);
                    } catch (DivideByZeroException ex) {
                        Console.WriteLine(ex.Message);
                    }
                }

                cmd = Console.ReadLine().Split();
            }
        }
    }
}
