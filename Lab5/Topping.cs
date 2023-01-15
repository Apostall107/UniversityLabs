namespace Lab5 {
    internal class Topping {
        const double caloriesPerGram = 2;

        private double _typeIndex;
        private int _grams;

        Dictionary<string, double> typeDict = new Dictionary<string, double>
        {
            {"Meat" ,  1.2  },
            {"Veggies" ,  0.8  },
            {"Cheese" ,  1.1  },
            { "Sauce", 0.9 }
        };




        public Topping(string type, int grams) {
            ToppingType = typeDict.Where(x => x.Key == type).FirstOrDefault().Value;
            Gram = grams;
        }

        private int Gram {
            get { return _grams; }
            set {
                if (value > 50 || value < 0) {
                    Console.WriteLine($"{typeDict.Where(x => x.Value == ToppingType).First().Key} weight should be in the range [1..50]");
                } else {
                    _grams = value;
                }
            }
        }
        private double ToppingType {
            get { return _typeIndex; }
            set {
                if (value == 0) {
                    Console.WriteLine("Invalid type of topping.");
                } else {
                    _typeIndex = value;
                }

            }
        }

        public double Calories {
            get {
                return Gram * ToppingType * caloriesPerGram;
            }
        }

        public static Topping CreateTopping(string[] doppingInput) {

            string topingName = doppingInput[1];
            int grams = int.Parse(doppingInput[2]);

            Topping topping = new Topping(topingName, grams);

            return topping;
        }
    }


}

