using System.Globalization;

var numberType = new NumberType<int>(1);
var stringType = new StringType<string>("hello world");
var caps = new Caps();

numberType.DisplayData();
stringType.DisplayData();
caps.DisplayData();

Console.ReadLine();


/*

Take a input of any generic type and return the output using C# generics and with the help of object oriented programming

Base Class - BaseClass
Rule 1 : BaseClass should be generic
Rule 2: Should avoid creating new instance of the base class
Derived Class - NumberType
Derived Class - StringType
Sample input:
==
NumberType(1);
StringType("hello world")
 
*/
internal abstract class GenericType<T>
{
    private readonly T _genericType;

    internal GenericType(T genericType)
    {
        _genericType = genericType;
    }

    internal void DisplayData()
    {
        Console.WriteLine(_genericType?.ToString());
    }
}

internal class NumberType<T> : GenericType<T> where T : struct
{
    internal NumberType(T genericType) : base(genericType) { }
}

internal class StringType<T> : GenericType<T> where T : IEnumerable<char>
{
    internal StringType(T genericType) : base(genericType) { }
}

// Given a list of cities "new york, detroit, miami", capitalize the first letter of each word: New York, Detroit, Miami
internal class Caps
{
    private readonly List<string> _cities = new() { "new york", "detroit", "miami", null };

    public void DisplayData()
    {
        var capCities = _cities.Select(c =>
        {
            return c != null ? CultureInfo.CurrentCulture.TextInfo.ToTitleCase(c.ToLower()) : c;
        });

        Console.WriteLine(String.Join(" ", capCities));
    }
}




