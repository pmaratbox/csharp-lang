const int Capacity = 3;
var data = new int[Capacity];
int head = 0, count = 0;

void Push(int value)
{
    int tail = (head + count) % Capacity;
    data[tail] = value;
    if (count < Capacity) count++;
    else head = (head + 1) % Capacity; // overwrite oldest
}

foreach (var v in new[] { 1, 2, 3, 4, 5 }) Push(v);

var contents = new List<int>();
for (int i = 0; i < count; i++) contents.Add(data[(head + i) % Capacity]);
Console.WriteLine(string.Join(" ", contents));
