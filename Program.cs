using Questions;
using Questions.Helpers.Console;

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
}

DepthFirstSearchDisplay();
BreadthFirstSearchDisplay();
GenericTypeDisplay();
TitleCaseDisplay();

