int[] a = [2, 2, 1, 2, 3, 2];

int candidate = 0;
int count = 0;
foreach (int x in a)
{
    if (count == 0)
    {
        candidate = x;
    }
    count += x == candidate ? 1 : -1;
}

Console.WriteLine(candidate);
