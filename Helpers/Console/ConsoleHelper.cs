namespace Questions.Helpers.Console
{
    public static class ConsoleHelper
    {
        public static string Tabs(int count)
        {
            var tabs = Enumerable.Repeat("\t", count);
            return string.Join("", tabs);
        }

        public static void SetRandomForegroundColor()
        {
            var r = new Random();
            System.Console.ForegroundColor = (ConsoleColor)r.Next(1, 16);
        }
    }
}
