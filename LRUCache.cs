/*
Design and implement a data structure for Least Recently Used (LRU) cache. It should support the following operations: get and put.

get(key) - Get the value (will always be positive) of the key if the key exists in the cache, otherwise return -1.
put(key, value) - Set or insert the value if the key is not already present. When the cache reached its capacity, it should invalidate the least recently used item before inserting a new item.

The cache is initialized with a positive capacity.
*/

class LRUCache
{
    public LRUCache(int capacity)
    {
        Capacity = capacity;
        Head.Next = Tail;
        Head.Prior = null;
        Tail.Prior = Head;
        Tail.Next = null;
    }

    public int Get(int key)
    {
        if (!Cache.TryGetValue(key, out ListNode node)) return -1;
        MoveNodeToHead(node);
        return node.Value;
    }

    public void Put(int key, int value)
    {
        if (!Cache.TryGetValue(key, out ListNode node))
        {
            ListNode newNode = new ListNode
            {
                Key = key,
                Value = value,
            };

            Cache.Add(key, newNode);
            AddNodeToHead(newNode);
            Count++;

            if (Count > Capacity)
            {
                var tailNode = Tail.Prior;
                RemoveNode(tailNode);
                Cache.Remove(tailNode.Key);
                Count--;
            }
        }
        else
        {
            node.Value = value;
            MoveNodeToHead(node);
        }
    }

    // Add new node to head
    private void AddNodeToHead(ListNode node)
    {
        node.Prior = Head;
        node.Next = Head.Next;
        Head.Next.Prior = node;
        Head.Next = node;
    }

    // Remove node from list
    private void RemoveNode(ListNode node)
    {
        node.Next.Prior = node.Prior;
        node.Prior.Next = node.Next;
        node.Prior = null;
        node.Next = null;
    }

    // Move node to head
    private void MoveNodeToHead(ListNode node)
    {
        RemoveNode(node);
        AddNodeToHead(node);
    }

    // Print node
    public void PrintCache()
    {
        for (ListNode n = Head.Next; n != Tail; n = n.Next)
        {
            Console.Write($"[{n.Key}, {n.Value}] ");
        }
        Console.WriteLine();
    }

    private Dictionary<int, ListNode> Cache = new Dictionary<int, ListNode>();

    private int Capacity { get; set; } = 0;
    private int Count { get; set; } = 0;

    private ListNode Head = new ListNode() { Key = -100, Value = -1, };
    private ListNode Tail = new ListNode() { Key = -111, Value = -1, };

    class ListNode
    {
        public int Key { get; set; }
        public int Value { get; set; }

        public ListNode Prior { get; set; }
        public ListNode Next { get; set; }
    }
}
