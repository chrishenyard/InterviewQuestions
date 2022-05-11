using Questions.Helpers.Console;
using Questions.Helpers.Strings;
using Questions.Topics;

/* 

Display data using the Breadth First search.
Numbers represent levels.

*/
static void BreadthFirstSearchDisplay()
{
    /* 
                          A(1)
                         /    \
                        --------
                        B(2)   E(2)
                       /         \
                      -------------
                    C(3)           F(3)
                   /                \
                  --------------------
                D(4)                 G(4)
                -------------------------
                                        |
                                      H(5)
                                    --------
                                   /        \   
                                  I(6)     J(6)
    */

    var rootNode = BuildTree();
    Console.WriteLine("Display data using the Breadth First search. Numbers represent levels.\n");
    Node.BreadthFirstTraversal(rootNode);
    Console.WriteLine();
}

/* 

Display data using the Depth First search.
Numbers represent levels.

*/
static void DepthFirstSearchDisplay()
{
    /* 
                          A(1)
                         /    \
                        --------
                        B(2)   E(2)
                       /         \
                      -------------
                    C(3)           F(3)
                   /                \
                  --------------------
                D(4)                 G(4)
                -------------------------
                                        |
                                      H(5)
                                    --------
                                   /        \   
                                  I(6)     J(6)
    */

    var rootNode = BuildTree();
    Console.WriteLine("Display data using the Depth First search. Numbers represent levels.\n");
    Node.DepthFirstTraversal(rootNode);
    Console.WriteLine();
}


static Node BuildTree()
{
    var nodeA = new Node("A");
    var nodeB = new Node("B");
    var nodeC = new Node("C");
    var nodeD = new Node("D");
    var nodeE = new Node("E");
    var nodeF = new Node("F");
    var nodeG = new Node("G");
    var nodeH = new Node("H");
    var nodeI = new Node("I");
    var nodeJ = new Node("J");

    // nodeA
    Node.AddLeftNode(nodeA, nodeB);
    Node.AddRightNode(nodeA, nodeE);

    // nodeB
    Node.AddLeftNode(nodeB, nodeC);

    // nodeC
    Node.AddLeftNode(nodeC, nodeD);

    // nodeE
    Node.AddRightNode(nodeE, nodeF);

    // nodeF
    Node.AddRightNode(nodeF, nodeG);

    // nodeG
    Node.AddRightNode(nodeG, nodeH);

    // nodeH
    Node.AddLeftNode(nodeH, nodeI, true);
    Node.AddRightNode(nodeH, nodeJ);

    return nodeA;
}

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
static void GenericTypeDisplay()
{
    Console.WriteLine("Take a input of any generic type and return the output using C# generics and with the help of object oriented programming.");
    Console.WriteLine();

    var numberType = new NumberType<int>(1);
    var stringType = new StringType<string>("hello world");
    
    ConsoleHelper.SetRandomForegroundColor();
    numberType.DisplayData();
    ConsoleHelper.SetRandomForegroundColor();
    stringType.DisplayData();
    
    Console.ResetColor();
    Console.WriteLine();
}

// Given a list of cities "new york, detroit, miami", capitalize the first letter of each word: New York, Detroit, Miami
static void TitleCaseDisplay()
{
    Console.WriteLine("Given a list of cities \"new york, detroit, miami\", capitalize the first letter of each word: New York, Detroit, Miami.");
    Console.WriteLine();

    var titles = new List<string?>() { "new york", "detroit", "miami", null };
    var titleCase = new TitleCase(titles);

    ConsoleHelper.SetRandomForegroundColor();
    titleCase.DisplayData();
    Console.ResetColor();
    Console.WriteLine();
}

/*

Hashes

For objects, the GetHash method is used to retrieve the key in a dictionary or a hash table.
The GetHash method is also used as a lookup.
In the case of hash collisions, the Equals method is used to determine equality.
It is why when overriding the GetHash method it requires that you override the Equals method.

*/
static void EqualityDisplay()
{
    var point1 = new Point3D(1, 2, 3);
    var point2 = new Point3D(1, 2, 3);

    // The equals sign compares reference values. 
    // So even though the points have the same values, they are not equal.
    ConsoleHelper.SetRandomForegroundColor();
    Console.WriteLine("point 1 and point2 are not equal because each has a different reference value");
    Console.WriteLine($"{point1 == point2}\n");

    // The Equals method has been overriden in the Point3D class to accurately determine equality.
    // They are equal because all of the values are the same.
    ConsoleHelper.SetRandomForegroundColor();
    Console.WriteLine("The Equals method has been overriden in the Point3D class to accurately determine equality");
    Console.WriteLine($"{point1.Equals(point2)}\n");


    ConsoleHelper.SetRandomForegroundColor();
    var dictionary = new Dictionary<Point3D, Point3D> { { point1, point1 } };
    var point3D = dictionary[point1];

    // Objects must be immutable if used as a dictionary or hash key
    ConsoleHelper.SetRandomForegroundColor();
    Console.WriteLine("Objects must be immutable if used as a dictionary or hash key");
    Console.WriteLine($"Key exists: {point3D is not null}\n");

    // When values change, so does the key
    ConsoleHelper.SetRandomForegroundColor();
    Console.WriteLine("When values change, so does the key");
    
    if (point3D != null)
    {
        point3D.X = -1;
        dictionary.TryGetValue(point3D, out var point);
        Console.WriteLine($"Key exists: {point is not null}\n");
    }

    Console.ResetColor();
}

/*
Use the .Net binary search method to find comparable types such as strings and integers
*/
static void BinarySearch()
{
    ConsoleHelper.SetRandomForegroundColor();
    var random = new Random();

    // Find a string
    var stringList = Enumerable
        .Range(0, 1000)
        .Select(s => StringHelper.RandomString(20))
        .OrderBy(s => s)
        .ToList<IComparable>();

    var searchIndex = random.Next(0, stringList.Count);
    var stringValue = stringList[searchIndex];
    var index = new BinarySearch<List<IComparable>>(stringList).Search(stringValue);
    Console.WriteLine($"Searching for: {stringValue} at index: {index} found: {stringValue}\n");

    // Find an integer
    var intList = Enumerable
        .Range(0, 1000)
        .Cast<IComparable>()
        .OrderBy(n => n)
        .ToList();

    searchIndex = random.Next(0, intList.Count);
    var intValue = intList[searchIndex];
    index = new BinarySearch<List<IComparable>>(intList).Search(intValue);
    Console.WriteLine($"Searching for: {intValue} at index: {index} found: {intValue}\n");

    Console.ResetColor();
}

DepthFirstSearchDisplay();
BreadthFirstSearchDisplay();
GenericTypeDisplay();
TitleCaseDisplay();
EqualityDisplay();
BinarySearch();



