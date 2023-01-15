namespace Lab11.Problem1 {
    internal class Dispatcher {
        public delegate void NameChangeEventHandler(object sender, NameChangeEventArgs args);
        public event NameChangeEventHandler NameChange;
        private string _name;

        public string Name {
            get => _name;
            set {
                _name = value;
                OnNameChange(new NameChangeEventArgs(value));
            }
        }

        public void OnNameChange(NameChangeEventArgs args) {
            if (args is not null)
                NameChange(this, args);
        }
    }
}
