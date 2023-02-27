namespace LinkedListProblem
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to Linked List Program");
            LinkedList linked = new LinkedList();
            linked.Add(40);
            linked.Add(60);
            linked.Add(50);

            linked.Display();
        }


    }
}
