namespace Questions.Topics
{
    public abstract class GenericType<T>
    {
        private readonly T _genericType;

        public GenericType(T genericType)
        {
            _genericType = genericType;
        }

        public void DisplayData()
        {
            Console.WriteLine(_genericType?.ToString());
        }
    }

    public class NumberType<T> : GenericType<T> where T : struct
    {
        public NumberType(T genericType) : base(genericType) { }
    }

    public class StringType<T> : GenericType<T> where T : IEnumerable<char>
    {
        public StringType(T genericType) : base(genericType) { }
    }
}
