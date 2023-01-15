namespace InheritanceLab.Problem2 {
    internal class GoldenEditionBook : Book {
        public GoldenEditionBook(string author, string title, decimal price)
            : base(title, author, price) { }

        public override decimal Price {
            set {
                base.Price = value * 1.3M;
            }
        }
    }
}
