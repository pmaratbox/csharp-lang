int[] houses = { 2, 7, 9, 3, 1 };
int rob = 0, skip = 0;
foreach (int h in houses)
{
    int newRob = skip + h;
    skip = Math.Max(skip, rob);
    rob = newRob;
}
Console.WriteLine(Math.Max(rob, skip));
