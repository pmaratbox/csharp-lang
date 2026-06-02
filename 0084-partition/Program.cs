var nums = new[] { 1, 2, 3, 4, 5, 6 };
var evens = nums.Where(n => n % 2 == 0);
var odds = nums.Where(n => n % 2 != 0);
Console.WriteLine("evens: " + string.Join(" ", evens));
Console.WriteLine("odds: " + string.Join(" ", odds));
