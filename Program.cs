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
            linked.Add(40);
            linked.Add(70);
            linked.Display();

            linked.DeleteValue(40);
            linked.Display();
            linked.Size();


        }
    }


    }

