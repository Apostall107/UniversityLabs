namespace Lab5 {
    internal class Person {
        public string Name { get; set; }
        public int Money { get; set; }
        public List<Product> Bag { get; set; }

        public Person(string name, int money) {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be empty", nameof(name));
            if (money < 0)
                throw new ArgumentException("Money cannot be negative", nameof(money));

            Name = name;
            Money = money;
            Bag = new List<Product>();
        }


        public static void Shoping() {

            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();
            string[] nameMoney = Console.ReadLine().Split(";");


            for (int i = 0; i < nameMoney.Length; i++) {
                string[] tokens = nameMoney[i].Split("=");
                string name = tokens[0];
                int money = int.Parse(tokens[1]);

                Person person = new Person(name, money);
                people.Add(person);
            }
            string[] namePrice = Console.ReadLine().Split(";");
            for (int i = 0; i < namePrice.Length; i++) {
                //needs to delete after item ; if its the last item
                string[] tokens = namePrice[i].Split("=");
                string name = tokens[0];
                int price = int.Parse(tokens[1]);

                Product product = new Product(name, price);
                products.Add(product);
            }
            string[] personProduct;
            List<KeyValuePair<Person, Product>> tryToBuy = new List<KeyValuePair<Person, Product>>();
            do {
                personProduct = Console.ReadLine().Split();

                if (personProduct.Length < 2) { break; }

                string personName = personProduct[0];
                string productName = personProduct[1];


                Product product = products.Where(x => x.Name == productName).First();
                Person person = people.Where(x => x.Name == personName).First();

                tryToBuy.Add(new KeyValuePair<Person, Product>(person, product));

            } while (true);

            foreach (var pair in tryToBuy) {

                if (pair.Key.Money >= pair.Value.Cost) {
                    pair.Key.Money -= pair.Value.Cost;
                    pair.Key.Bag.Add(pair.Value);
                    Console.WriteLine($"{pair.Key.Name} bought {pair.Value.Name}");
                } else {
                    Console.WriteLine($"{pair.Key.Name}  can't afford  {pair.Value.Name} ");
                }
            }


            foreach (var person in people) {
                Console.Write($"\n{person.Name} - ");
                if (person.Bag.Count == 0) {
                    Console.Write($" Nothing bought");
                } else {
                    foreach (var product in person.Bag) {
                        Console.Write($" {product.Name}");
                    }
                }


            }

        }




    }
}

