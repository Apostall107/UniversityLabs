namespace Lab3 {
    internal class Rectangle {
        string id;
        int width;
        int height;
        Coordinates topLeft;
        Coordinates botRight = new Coordinates();

        public Rectangle() {

        }
        public Rectangle(string id, int width, int height, Coordinates coordinates) {
            this.id = id;
            this.width = width;
            this.height = height;
            topLeft = coordinates;
            botRight.X = coordinates.X + width;
            botRight.Y = coordinates.Y - height;
        }

        public static string EnterValue() {

            string[] tokensNM = Console.ReadLine().Split();
            int n = int.Parse(tokensNM[0]);
            int m = int.Parse(tokensNM[1]);
            List<Rectangle> rectangles = new List<Rectangle>();
            for (int i = 0; i < n; i++) {
                string[] tokens = Console.ReadLine().Split();
                string id = tokens[0];
                int width = int.Parse(tokens[1]);
                int height = int.Parse(tokens[2]);
                int X = int.Parse(tokens[3]);
                int Y = int.Parse(tokens[4]);
                Coordinates topLeft = new Coordinates(X, Y);
                Rectangle rectangle = new Rectangle(id, width, height, topLeft);
                rectangles.Add(rectangle);
            }
            List<string> toCompare = new List<string>();
            for (int i = 0; i < m; i++) {
                string[] tokenPairs = Console.ReadLine().Split();
                string id1 = tokenPairs[0];
                string id2 = tokenPairs[1];

                toCompare.Add(id1);
                toCompare.Add(id2);
            }

            return DoIntersect(rectangles, toCompare);
        }
        static string DoIntersect(List<Rectangle> rectangles, List<string> toCompare) {
            for (int i = 0; i < toCompare.Count; i = +2) {
                int y = i + 1;
                var compare1 = rectangles.Where(x => x.id.ToString() == toCompare[i].ToString()).First();
                var compare2 = rectangles.Where(x => x.id.ToString() == toCompare[y].ToString()).First();
                // If one rectangle is on left side of other

                if (compare1.botRight.X > compare2.topLeft.X || compare1.topLeft.X > compare2.botRight.X) {
                    return "false";
                }

                // If one rectangle is above other
                if (compare1.botRight.Y > compare2.topLeft.Y || compare1.topLeft.Y > compare2.botRight.Y) {
                    return "false";
                }

            }

            return "true";
        }
    }

    internal class Coordinates {
        public int X, Y;

        public Coordinates() { }
        public Coordinates(int x, int y) {
            X = x;
            Y = y;
        }
    }


}


