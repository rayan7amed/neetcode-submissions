public class LinkedList
{
    Node Head, Tail;
    internal class Node
    {
        public int Value;
        public Node Next;
        public Node(int i, Node next = null)
        {
            Value = i;
            Next = next;
        }
    }
    public LinkedList()
    {

    }

    public int Get(int index)
    {
        Node tmp = Head;
        while (tmp != null)
        {
            if (index == 0)
            {
                return tmp.Value;
            }
            tmp = tmp.Next;
            --index;
        }
        return -1;
    }

    public void InsertHead(int val)
    {
        Node node = new Node(val, Head);
        Head = node;
        if (Tail == null)
            Tail = Head;

    }

    public void InsertTail(int val)
    {
        Node node = new Node(val);
        if(Tail != null)
            Tail.Next = node;
        Tail = node;
        if(Head == null) 
            Head = node;
    }

    public bool Remove(int index)
    {
        if (Head == null)    return false;

        if (Head == Tail)
        {
            if (index > 0) return false;
            Head = null;
            Tail = null;
            return true;
        }
        if (index == 0)
        {
            Head = Head.Next;
            return true;

        }
        Node curr = Head.Next;
        Node prev = Head;
        int idx = 1;
        while (curr != null)
        {
            if (index == idx)
            {
                prev.Next = curr.Next;
                if (curr == Tail)
                    Tail = prev;
                return true;
            }
            ++idx;
            curr = curr.Next;
            prev = prev.Next;
        }

        return false;
    }

    public List<int> GetValues()
    {
        List<int> data = new List<int>();
        Node tmp = Head;
        while (tmp != null)
        {
            data.Add(tmp.Value);
            tmp = tmp.Next;
        }
        return data;
    }
}