namespace Lab11.Problem2.Infrastructure {
    internal abstract class Person {
        public string Name { get; private set; }

        public Person(string name) {
            Name = name;
        }

        public abstract void OnBeingAttacked(object sender, EventArgs args);
    }
}
