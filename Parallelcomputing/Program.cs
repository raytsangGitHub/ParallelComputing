// See https://aka.ms/new-console-template for more information
using Parallelcomputing.SpecifyProcessor;

Console.WriteLine("Parallel Computing");


//var numbers = Enumerable.Range(1, 100000).ToList();
//var oddNums = numbers.AsParallel()
//    .Where(numb => numb % 2 != 0)
//    .ToList();


//Console.WriteLine(oddNums.Count);


#region Create a thread and set its processor affinity:
// Create a new thread
Thread thread = new Thread(SpecifyProcessor.ThreadMethod);

// Start the thread
thread.Start();

// Set the processor affinity for the thread
SpecifyProcessor.SetThreadAffinity(thread, 3); // Assign to core 3

// Join the thread to wait for its completion
thread.Join();
#endregion

Console.WriteLine();