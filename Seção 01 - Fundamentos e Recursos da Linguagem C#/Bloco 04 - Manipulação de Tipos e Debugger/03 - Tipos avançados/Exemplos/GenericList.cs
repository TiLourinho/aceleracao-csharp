namespace Exemplos
{
    public class GenericList<T>
    {
        private class Node
        {
            public T Value;
            public Node? Next;

            public Node(T t)
            {
                Value = t;
                Next = null;
            }
        }

        private Node? Head;

        public void GenericaList()
        {
            Head = null;
        }

        public void Add(T input)
        {
            if (Head == null)
            {
                Head = new Node(input);
                Console.WriteLine("Nó Head criado!");
            }
            else
            {
                Node lastNode = Head;

                while (lastNode.Next != null) lastNode = lastNode.Next;

                lastNode.Next = new Node(input);
            }
        }

        public void Print()
        {
            Node? printNode = Head;

            while (printNode?.Next != null)
            {
                Console.Write(printNode.Value + " ");
                printNode = printNode.Next;
            }

            Console.WriteLine(printNode!.Value);
        }
    }
}