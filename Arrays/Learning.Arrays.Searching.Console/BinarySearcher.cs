namespace Learning.Arrays.Searching.Console
{
    internal class BinarySearcher
    {
        private readonly int[] _array;

        public BinarySearcher(int[] array) => _array = array;

        public int Find(int key)
        {
            var lowerBound = 0;
            var upperBound = _array.Length;

            while (true)
            {
                var currentIndex = (lowerBound + upperBound) / 2;
                if (_array[currentIndex] == key)
                {
                    return _array[currentIndex];
                }
                else if (lowerBound > upperBound)
                {
                    return -1;
                }
                else
                {
                    if (_array[currentIndex] > key)
                    {
                        upperBound = currentIndex - 1;
                    }
                    else
                    {
                        lowerBound = currentIndex + 1;
                    }
                }
            }
        }

        public int FindRec(int key) => BinarySearchRecursive(key, 0, _array.Length - 1, 0);

        private int BinarySearchRecursive(int key, int lowerBound, int upperBound, int tries)
        {
            if (lowerBound > upperBound)
            {
                return -1;
            }

            var currentIndex = (lowerBound + upperBound) / 2;
            if (_array[currentIndex] == key)
            {
                return _array[currentIndex];
            }

            return _array[currentIndex] > key ?
                BinarySearchRecursive(key, lowerBound, currentIndex - 1, ++tries) :
                BinarySearchRecursive(key, currentIndex + 1, upperBound, ++tries);
        }
    }
}
