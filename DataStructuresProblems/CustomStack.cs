namespace DataStructuresProblems
{
    internal class CustomStack
    {
        public Node top;

        public CustomStack()
        {
            this.top = null;
        }
        public void Push(int data)
        {
            Node node = new Node(data);

            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("inserted value is {0}", data);
        }
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty, Deletion is not possible");
                return;
            }
            Console.WriteLine("\n{0} is deleted from top of the stack", this.top.data);
            this.top = this.top.next;
        }
        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
