using System.Text;

var bytes = Encoding.UTF8.GetBytes("Hi");

Console.WriteLine(string.Join(" ", bytes));
