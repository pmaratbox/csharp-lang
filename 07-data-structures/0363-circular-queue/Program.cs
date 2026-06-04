var queue = new CircularQueue(3);
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Dequeue();
queue.Enqueue(4);

Console.WriteLine(string.Join(" ", queue.Items()));

sealed class CircularQueue(int capacity)
{
    private readonly int[] buffer = new int[capacity];
    private int head;
    private int count;

    public void Enqueue(int value)
    {
        if (count == capacity)
            throw new InvalidOperationException("queue full");
        buffer[(head + count) % capacity] = value;
        count++;
    }

    public int Dequeue()
    {
        if (count == 0)
            throw new InvalidOperationException("queue empty");
        var value = buffer[head];
        head = (head + 1) % capacity;
        count--;
        return value;
    }

    public IEnumerable<int> Items()
    {
        for (var i = 0; i < count; i++)
            yield return buffer[(head + i) % capacity];
    }
}
