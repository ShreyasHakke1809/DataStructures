namespace DataStructuresProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n1.CustomMLinkedList\n2.Custom Stack\n3.Custom Queue" +
                "\n4.Built in LinkedList\n5.Built in Stack\n6.Built in Queue\n7.Data in descending order\n8.Exit");
            bool loopAgain = true;
            while (loopAgain)
            {
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        CustomLinkedLIst linkedLIst = new CustomLinkedLIst();
                        linkedLIst.Add(09);
                        linkedLIst.Add(18);
                        linkedLIst.Add(27);
                        linkedLIst.Display();
                        break;
                    case 2:
                        CustomStack customStack = new CustomStack();
                        customStack.Push(09);
                        customStack.Push(18);
                        customStack.Push(27);
                        customStack.Display();
                        customStack.Pop();
                        customStack.Display();
                        break;
                    case 3:
                        CustomQueue customQueue = new CustomQueue();
                        customQueue.Enqueue(09);
                        customQueue.Enqueue(18);
                        customQueue.Enqueue(27);
                        customQueue.Display();
                        break;
                    case 4:
                        BuiltInLinkedList list = new BuiltInLinkedList();
                        list.AddElement();
                        break;
                    case 5:
                        BuiltInStack builtInStack = new BuiltInStack();
                        builtInStack.AddElement();
                        break;
                    case 6:
                        BuiltInQueue builtInQueue = new BuiltInQueue();
                        builtInQueue.AddElement();
                        break;
                    case 7:
                        DescendingData ascendingData = new DescendingData();
                        ascendingData.OrderedLinkedlist(27);
                        ascendingData.OrderedLinkedlist(45);
                        ascendingData.OrderedLinkedlist(99);
                        ascendingData.OrderedLinkedlist(18);
                        ascendingData.Display();
                        break;
                    case 8:
                        Environment.Exit(0);
                        break;
                    case 9:
                        loopAgain = false;
                        break;
                }
            }
        }
    }
}