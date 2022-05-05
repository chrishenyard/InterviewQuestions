namespace Questions
{
    public class Node
    {
        public Node? Left;
        public Node? Right;
        public string Data;
        public bool Last;

        public Node(string data)
        {
            Data = data;
        }

        public static void AddLeftNode(Node parent, Node node, bool last = false)
        {
            parent.Left = node;
            parent.Left.Last = last;
        }

        public static void AddRightNode(Node parent, Node node, bool last = false)
        {
            parent.Right = node;
            parent.Right.Last = last;
        }

        public static void BreadthFirstTraversal(Node node)
        {
            if (node == null) return;

            var level = 1;
            var queue = new Queue<Node>();
            queue.Enqueue(node);
            string content = string.Empty;

            SetRandomForegroundColor();
            Console.WriteLine($"{level++}" + node.Data);

            while (queue.Count > 0)
            {
                node = queue.Dequeue();

                if (node.Left != null)
                {
                    queue.Enqueue(node.Left);
                    content += $"{level}" + node.Left.Data + Tabs(1);
                }

                if (node.Right != null)
                {
                    queue.Enqueue(node.Right);
                    content += $"{level}" + node.Right.Data + Tabs(1);

                    SetRandomForegroundColor();
                    Console.Write(content + Environment.NewLine);
                    content = Tabs(level);
                    level++;
                }
            }

            Console.ResetColor();
        }

        public static Node? BreadthFirstTraversalFind(string data, Node root)
        {
            if (root == null) return null;

            var queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();

                if (string.Equals(data, node.Data, StringComparison.OrdinalIgnoreCase))
                {
                    return node;
                }

                if (node.Left != null)
                {
                    queue.Enqueue(node.Left);

                }

                if (node.Right != null)
                {
                    queue.Enqueue(node.Right);
                }
            }

            return null;
        }

        public static void DepthFirstTraversal(Node node)
        {
            if (node == null) return;

            var stack = new Stack<Node>();
            var level = 1;
            stack.Push(node);

            while (stack.Count > 0)
            {
                var current = stack.Pop();
                SetRandomForegroundColor();
                Console.WriteLine(Tabs(level-1) + $"{level}" + current.Data);

                if (current.Right != null)
                {
                    stack.Push(current.Right);
                }

                if (current.Left != null)
                {
                    stack.Push(current.Left);
                }

                if (current.Left != null || current.Right != null)
                {
                    level++;
                }

                if (current.Left == null && current.Right == null && !current.Last)
                {
                    level = 2;
                }
            }

            Console.ResetColor();

        }

        public static Node? DepthFirstTraversalFind(string data, Node root)
        {
            if (root == null) return null;

            var stack = new Stack<Node>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                var current = stack.Pop();

                if (string.Equals(data, current.Data, StringComparison.OrdinalIgnoreCase))
                {
                    return current;
                }

                if (current.Right != null)
                {
                    stack.Push(current.Right);
                }

                if (current.Left != null)
                {
                    stack.Push(current.Left);
                }
            }

            return null;
        }

        private static string Tabs(int count)
        {
            var tabs = Enumerable.Repeat("\t", count);
            return string.Join("", tabs);
        }

        private static void SetRandomForegroundColor()
        {
            Random r = new Random();
            Console.ForegroundColor = (ConsoleColor)r.Next(1, 16);
        }
    }
}
