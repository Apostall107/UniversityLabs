namespace GenericsLab.Problem9 {
    internal class Tupple<T, U> {
        private T _firstElement;
        private U _secondElement;

        public Tupple(T firstElement, U secondElement) {
            _firstElement = firstElement;
            _secondElement = secondElement;
        }

        public override string ToString() {
            return $"{_firstElement} -> {_secondElement}";
        }
    }
}
