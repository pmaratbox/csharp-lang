int[] a = [2, 0, 2, 1, 1, 0];

int low = 0, mid = 0, high = a.Length - 1;
while (mid <= high)
{
    switch (a[mid])
    {
        case 0:
            (a[low], a[mid]) = (a[mid], a[low]);
            low++;
            mid++;
            break;
        case 1:
            mid++;
            break;
        default:
            (a[mid], a[high]) = (a[high], a[mid]);
            high--;
            break;
    }
}

Console.WriteLine(string.Join(' ', a));
