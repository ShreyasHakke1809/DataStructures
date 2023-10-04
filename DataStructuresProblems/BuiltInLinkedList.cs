namespace DataStructuresProblems
{
    internal class BuiltInLinkedList
    {
        public void AddElement()
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddLast(09);
            list.AddLast(18);
            list.AddLast(27);
            list.AddLast(36);

            foreach (int element in list)
            {
                Console.WriteLine("Elements are " + element);
            }
            Console.WriteLine("\nUpdate element within range");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nAdd new element");
            // int b = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine(list.Contains(09));

            if (list.Contains(a))
            {
                list.Remove(a);

            }
            else
            {
                Console.WriteLine("Element not found");
            }
            Console.WriteLine("Updated list");
            foreach (int element in list)
            {
                Console.WriteLine(element);
            }
        }
    }
}
