namespace DataStructuresProblems
{
    internal class CustomQueue
    {
        public Node head;
        public CustomQueue()
        {
            this.head = null;
        }
        public void Enqueue(int data)
        {
            Node node = new Node(data);

            if (this.head == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.head;
            }
            this.head = node;
            Console.WriteLine("inserted value is {0}", data);
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
