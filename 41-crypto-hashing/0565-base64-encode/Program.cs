using System.Text;

var bytes = Encoding.UTF8.GetBytes("hello");
Console.WriteLine(Convert.ToBase64String(bytes));
