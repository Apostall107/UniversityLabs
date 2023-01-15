namespace Lab11.Problem1 {
    internal class PrintHandler {
        public void OnDispatcherNameChange(object sender, NameChangeEventArgs args) {
            Console.WriteLine($"Dispatcher`s name changed to {args.Name}");
        }
    }
}
