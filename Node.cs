namespace Questions
{
    public class Node
    {
        public Node? Left;
        public Node? Right;
        public string Data;

        public Node(string data)
        {
            Data = data;
        }

        public static void AddLeftNode(Node parent, Node node)
        {
            parent.Left = node;
        }

        public static void AddRightNode(Node parent, Node node)
        {
            parent.Right = node;
        }

        public static void DisplayData(Node node)
        {
            var level = 1;
            var queue = new Queue<Node>();
            queue.Enqueue(node);
            string content = string.Empty;

            SetRandomForegroundColor();
            Console.WriteLine(node.Data + $"({level++})");

            while (queue.Count > 0)
            {
                node = queue.Dequeue();

                if (node.Left != null)
                {
                    queue.Enqueue(node.Left);
                    content += $"{node.Data}->" + node.Left.Data + $"({level})" + Tabs(1);
                }

                if (node.Right != null)
                {
                    queue.Enqueue(node.Right);
                    content += $"{node.Data}->" + node.Right.Data + $"({level})" + Tabs(1);

                    SetRandomForegroundColor();
                    Console.Write(content + Environment.NewLine);
                    content = Tabs(level);
                    level++;
                }
            }

            Console.ResetColor();
        }

        private static string Tabs(int count)
        {
            var tabs = Enumerable.Repeat("\t", count);
            return string.Join("", tabs);
        }

        private static void SetRandomForegroundColor()
        {
            Random r = new Random();
            Console.ForegroundColor = (ConsoleColor)r.Next(0, 16);
        }
    }
}
