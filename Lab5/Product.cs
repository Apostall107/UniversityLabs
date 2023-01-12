namespace Lab5 {
    internal class Product {
        public string Name { get; set; }
        public int Cost { get; set; }

        public Product(string name, int cost) {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be empty", nameof(name));
            if (cost < 0)
                throw new ArgumentException("Cost cannot be negative", nameof(cost));

            Name = name;
            Cost = cost;
        }


    }
}