int[] a = [3, 1, 2, 3, 1];

int max = a.Max();
int[] counts = new int[max + 1];
foreach (int x in a) counts[x]++;

List<int> sorted = [];
for (int value = 0; value <= max; value++)
    for (int c = 0; c < counts[value]; c++)
        sorted.Add(value);

Console.WriteLine(string.Join(' ', sorted));
