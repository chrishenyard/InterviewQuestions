namespace Questions.Topics
{
    public class BinarySearch<T> where T : List<IComparable>
    {
        private readonly List<IComparable> _list;

        public BinarySearch(List<IComparable> list) { _list = list; }

        public int Search(IComparable value) {
            var index = _list.BinarySearch(value);
            return index;
        }
    }
}
