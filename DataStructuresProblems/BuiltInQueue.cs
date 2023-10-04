namespace DataStructuresProblems
{
    internal class BuiltInQueue
    {
        public void AddElement()
        {
            Queue<int> elements = new Queue<int>();

            elements.Enqueue(09);
            elements.Enqueue(18);
            elements.Enqueue(27);
            elements.Enqueue(45);

            foreach (int element in elements)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("Element at first");
            int peek = elements.Peek();
            Console.WriteLine(peek);

            Console.WriteLine("element removed");
            int deque = elements.Dequeue();
            Console.WriteLine(deque);

            Console.WriteLine("Updated queue");
            foreach (int element in elements)
            {
                Console.WriteLine(element);
            }
        }
    }
}
