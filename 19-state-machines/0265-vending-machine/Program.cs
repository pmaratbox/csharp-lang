const int price = 25;
var total = 0;
foreach (var coin in new[] { 10, 10, 5 })
{
    total += coin;
    if (total >= price)
    {
        Console.WriteLine("dispensed");
        break;
    }
}
