namespace GenericsLab.Problems7_8 {
    internal class MyCollection<T> : IMyCollection<T> where T : IComparable<T> {
        private const int DEFAULT_LENGTH = 16;

        private T[] _array;
        private int _length;

        public MyCollection() {
            _array = new T[DEFAULT_LENGTH];
        }

        public void Add(T element) {
            if (_length == _array.Length)
                _array = _array.Concat(new T[_length]).ToArray();

            _array[_length] = element;
            _length++;
        }

        public bool Contains(T element) {
            if (_length == 0)
                return false;

            var comparer = EqualityComparer<T>.Default;

            foreach (var item in _array) {
                if (comparer.Equals(item, element))
                    return true;
            }

            return false;
        }

        public int CountGreaterThan(T element) {
            var count = 0;

            for (int i = 0; i < _length; i++) {
                if (_array[i].CompareTo(element) > 0)
                    count++;
            }

            return count;
        }

        public T Max() {
            if (_length == 0)
                throw new ArgumentException("The collection is empty!");

            var max = _array[0];

            for (int i = 0; i < _length; i++) {
                if (_array[i].CompareTo(max) > 0)
                    max = _array[i];
            }

            return max;
        }

        public T Min() {
            if (_length == 0)
                throw new ArgumentException("The collection is empty!");

            var min = _array[0];

            for (int i = 0; i < _length; i++) {
                if (_array[i].CompareTo(min) < 0)
                    min = _array[i];
            }

            return min;
        }

        public T Remove(int index) {
            if (index >= _length || index < 0 || _length == 0)
                throw new ArgumentOutOfRangeException();


            var element = _array[index];
            _array = _array.Take(index).Concat(_array.Skip(index + 1)).ToArray();
            _length--;
            return element;
        }

        public void Swap(int index1, int index2) {
            if (_length == 0 || index1 >= _length || index2 >= _length || index1 < 0 || index2 < 0) {
                return;
            }

            var temp = _array[index1];
            _array[index1] = _array[index2];
            _array[index2] = temp;
        }

        public void Sort() {
            _array = _array
                .Take(_length)
                .OrderBy(x => x)
                .Concat(new T[_array.Length - _length])
                .ToArray();
        }

        public override string ToString() {
            return string.Join(Environment.NewLine, _array.Take(_length));
        }
    }
}
