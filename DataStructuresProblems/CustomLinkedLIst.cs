namespace DataStructuresProblems
{
    internal class CustomLinkedLIst
    {
        public Node head;
        public void Add(int data)
        {
            Node node = new Node(data);

            if (head == null)
            {
                head = node;
                Console.WriteLine("{0} is inserted", node.data);
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = node;
                Console.WriteLine("{0} is inserted", node.data);
            }
        }
        public Node GetLastNode()
        {
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        public void Display()
        {
            Node temp = head;
            if (head == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }
}
