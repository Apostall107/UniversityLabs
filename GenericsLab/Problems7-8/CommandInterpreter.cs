namespace GenericsLab.Problems7_8 {
    internal class CommandInterpreter {
        private IMyCollection<string> _myList;

        public CommandInterpreter() {
            _myList = new MyCollection<string>();
        }

        public void ExecuteCommand(string[] cmd) {
            var command = cmd[0];
            string value;

            switch (command) {
                case "Add":
                value = cmd[1];
                _myList.Add(value);
                break;
                case "Remove":
                int.TryParse(cmd[1], out var index);
                _myList.Remove(index);
                break;
                case "Contains":
                value = cmd[1];
                Console.WriteLine(_myList.Contains(value));
                break;
                case "Swap":
                var firstSwapItem = int.Parse(cmd[1]);
                var secondSwapItem = int.Parse(cmd[2]);
                _myList.Swap(firstSwapItem, secondSwapItem);
                break;
                case "Greater":
                value = cmd[1];
                Console.WriteLine(_myList.CountGreaterThan(value));
                break;
                case "Max":
                Console.WriteLine(_myList.Max());
                break;
                case "Min":
                Console.WriteLine(_myList.Min());
                break;
                case "Print":
                Console.WriteLine(_myList);
                break;
                case "Sort":
                _myList.Sort();
                break;
                default:
                break;
            }
        }
    }
}
