Console.WriteLine("LRUCache");
Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");

var cache = new LRUCache(2);
cache.Put(1, 1);
cache.Put(2, 2);

Console.WriteLine("Harusnya dapat 1: " + cache.Get(1) + "\n");

Console.WriteLine("Set dengan cache.Put(3,3) -> otomatis tambah di index 0\n");
cache.Put(3, 3);

Console.WriteLine("Harusnya -1 karena kapasitas cuma 2, data terakhir akan selalu di remove dan data yang ada sudah ada 3,3 dan 1,1");
Console.WriteLine(cache.Get(2));



class LRUCache
{
    private int _capacity;
    private Dictionary<int, LinkedListNode<(int key, int value)>> _cache;

    private LinkedList<(int key, int value)> _linkedlist;

    public LRUCache(int capacity)
    {
        _capacity = capacity;
        _cache = new Dictionary<int, LinkedListNode<(int key, int value)>>();
        _linkedlist = new LinkedList<(int key, int value)>();
    }

    public int Get(int key)
    {
        if (!_cache.ContainsKey(key))
            return -1;

        var node = _cache[key];
        _linkedlist.Remove(node);
        _linkedlist.AddFirst(node);

        Console.WriteLine($"Get(key), LinkedList Count: {_linkedlist.Count}");
        foreach (var item in _linkedlist)
        {
            Console.WriteLine($"LinkedList[{item.key}]: {item.value}");
        }

        return node.Value.value;
    }

    public void Put(int key, int value)
    {
        Console.WriteLine($"1. Put(key, value), LinkedList Count: {_linkedlist.Count}");
        foreach (var item in _linkedlist)
        {
            Console.WriteLine($"LinkedList[{item.key}]: {item.value}");
        }

        if (_cache.ContainsKey(key))
        {
            var node = _cache[key];
            _linkedlist.Remove(node);
        }

        Console.WriteLine();
        Console.WriteLine($"2. Put(key, value), LinkedList Count: {_linkedlist.Count}");
        foreach (var item in _linkedlist)
        {
            Console.WriteLine($"LinkedList[{item.key}]: {item.value}");
        }

        var newNode = new LinkedListNode<(int, int)>((key, value));
        _linkedlist.AddFirst(newNode);
        _cache.Add(key, newNode);

        Console.WriteLine();
        Console.WriteLine($"3. Put(key, value), LinkedList Count: {_linkedlist.Count}");
        foreach (var item in _linkedlist)
        {
            Console.WriteLine($"LinkedList[{item.key}]: {item.value}");
        }

        if (_cache.Count > _capacity)
        {
            var nodeRem = _linkedlist.Last;
            _linkedlist.RemoveLast();

            _cache.Remove(nodeRem!.Value.key);
        }

        Console.WriteLine();
        Console.WriteLine($"4. Put(key, value), LinkedList Count: {_linkedlist.Count}");
        foreach (var item in _linkedlist)
        {
            Console.WriteLine($"LinkedList[{item.key}]: {item.value}");
        }
    }
}