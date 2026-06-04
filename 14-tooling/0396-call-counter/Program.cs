int calls = 0;
Action wrapped = () => calls++;

for (int i = 0; i < 5; i++)
    wrapped();

Console.WriteLine($"calls: {calls}");
