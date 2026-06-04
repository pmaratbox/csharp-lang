int[] a = [1, 2, 3];
int[] b = [4, 5, 6];

var summed = a.Zip(b, (x, y) => x + y);

Console.WriteLine(string.Join(" ", summed));
