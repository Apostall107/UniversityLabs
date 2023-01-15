namespace Lab5 {
    internal class Dough {
        const double caloriesPerGram = 2;

        private double _flourType;
        private double _backingTechnique;
        private int _grams;

        Dictionary<string, double> _flourTypeDict = new Dictionary<string, double>
        {
            {"White" ,  1.5  },
            { "Wholegrain", 1.0 }
        };

        Dictionary<string, double> _backingTechniqueDict = new Dictionary<string, double>
        {
            {"Crispy" ,  0.9  },
            { "Chewy", 1.1 },
            { "Homemade", 1.0 }
        };


        public Dough() {

        }
        public Dough(string flourType, string backingTechnique, int grams) {
            FlourTypeIndex = _flourTypeDict.Where(x => x.Key == flourType).FirstOrDefault().Value;
            BackingTechniqueIndex = _backingTechniqueDict.Where(x => x.Key == backingTechnique).FirstOrDefault().Value;
            Gram = grams;
        }


        private double FlourTypeIndex {
            get { return _flourType; }
            set {
                if (value == null) {
                    Console.WriteLine("Invalid type of dough.");
                } else {
                    _flourType = value;
                }
            }

        }
        private double BackingTechniqueIndex {
            get { return _backingTechnique; }
            set {
                if (value == null) {
                    Console.WriteLine("Invalid type of dough.");
                } else {
                    _backingTechnique = value;
                }
            }
        }
        private int Gram {
            get { return _grams; }
            set {
                if (value > 200) {
                    Console.WriteLine("Dough weight should be in the range [1..200].");
                } else {
                    _grams = value;
                }
            }
        }
        public double Calories {
            get {
                return (Gram * caloriesPerGram) * FlourTypeIndex * BackingTechniqueIndex;
            }
        }

        public static Dough CreateDought(string[] doughInput) {

            string flourT = doughInput[1];
            string backingT = doughInput[2];
            int grams = int.Parse(doughInput[3]);

            Dough dough = new Dough(flourT, backingT, grams);

            return dough;
        }
    }

}

