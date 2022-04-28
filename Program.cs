using Questions;

var titles = new List<string?>() { "new york", "detroit", "miami", null };

var numberType = new NumberType<int>(1);
var stringType = new StringType<string>("hello world");
var titleCase = new TitleCase(titles);

numberType.DisplayData();
stringType.DisplayData();
titleCase.DisplayData();

Console.ReadLine();


