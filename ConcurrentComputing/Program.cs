// See https://aka.ms/new-console-template for more information
Console.WriteLine("Parallel computing!");

Parallel.For(0, 10, i =>
{
    Console.WriteLine($"Processing {i}");
});


