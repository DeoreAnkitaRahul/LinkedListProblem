namespace LinkedListProblem
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to Linked List Program");
            Console.WriteLine("\nInserting 30 between 56 and 70\n");

            LinkedList linked = new LinkedList();
            linked.Add(56);
            linked.Add(30);
            linked.Add(70);
            linked.Display();

            Console.WriteLine("\n------------Deleting last node--------------");
            linked.PopLast();
            linked.Display();
        }
    }


    }

