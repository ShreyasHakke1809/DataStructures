namespace DataStructuresProblems
{
    internal class BuiltInStack
    {
        public void AddElement()
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(09);
            stack.Push(18);
            stack.Push(27);
            stack.Push(45);

            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Element at top");
            int pop = stack.Peek();
            Console.WriteLine(pop);

            Console.WriteLine("Element to remove");
            int peek = stack.Pop();
            Console.WriteLine(peek);
            Console.WriteLine("Updated stack");
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
        }
    }
}
