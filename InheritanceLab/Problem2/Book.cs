using System.Text;

namespace InheritanceLab.Problem2 {
    internal class Book {
        private string _title;
        private string _author;
        private decimal _price;

        public Book(string author, string title, decimal price) {
            Title = title;
            Author = author;
            Price = price;
        }

        public string Title {
            get => _title;
            set {
                if (value.Length < 3)
                    throw new ArgumentException("Title not valid!");

                _title = value;
            }
        }
        public string Author {
            get => _author;
            set {
                var space = value.IndexOf(' ');
                if (char.IsDigit(value[space + 1]))
                    throw new ArgumentException("Author not valid");

                _author = value;
            }
        }
        public virtual decimal Price {
            get => _price;
            set {
                if (value <= 0)
                    throw new ArgumentException("Price not valid");

                _price = value;
            }
        }

        public override string ToString() {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"Type: {this.GetType().Name}")
            .AppendLine($"Title: {this.Title}")
            .AppendLine($"Author: {this.Author}")
            .AppendLine($"Price: {this.Price:f2}");
            string result = resultBuilder.ToString().TrimEnd();
            return result;
        }

    }
}
