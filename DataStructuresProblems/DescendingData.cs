namespace DataStructuresProblems
{
    internal class DescendingData
    {
        public Node head;

        public void OrderedLinkedlist(int data)
        {
            Node newNode = new Node(data);
            Node currentNode = this.head, temp = null;
            while (currentNode != null && currentNode.data > newNode.data)
            {
                temp = currentNode;
                currentNode = currentNode.next;
            }
            if (temp == null)
            {
                this.head = newNode;
            }
            else
            {
                temp.next = newNode;
            }
            newNode.next = currentNode;
            Console.WriteLine("{0} is inserted into ordered LinkedList (descending order)", newNode.data);
        }
        public void AddLast(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                Console.WriteLine("{0} is inserted into lastnode", newNode.data);
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = newNode;
                Console.WriteLine("{0} is inserted into lastnode", newNode.data);
            }
        }
        private Node GetLastNode()
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
