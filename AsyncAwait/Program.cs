﻿Console.WriteLine("Program started.");

await LongRunningTaskAsync();
var number = await Calculate();
Console.WriteLine(number);

Console.WriteLine("Program finished.");

async Task LongRunningTaskAsync()
{
    Console.WriteLine("\tTask starting...");
    await Task.Delay(5000);
    Console.WriteLine("\tTask completed.");
}

async Task<int> Calculate()
{
    await Task.Delay(5000);
    return 8;
}
