/*

Take a input of any generic type and return the output using C# generics and with the help of object oriented programming

Base Class - BaseClass
Rule 1 : BaseClass should be generic
Rule 2: Should avoid creating new instance of the base class
Derived Class - NumberType
Derived Class - StringType

=========================================================================================================================
Sample input:

NumberType(1);
StringType("hello world")

*/

namespace Questions
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
