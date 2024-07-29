namespace Parallelcomputing
{
    public class ParallelAsync
    {
        public async void ParallelAsyncCompute1()
        {
            await Task.Delay(1000); // Simulate asynchronous work
            Console.WriteLine("Task1 completed.");
        }

        public async void ParallelAsyncCompute2()
        {
            await Task.Delay(2000); // Simulate asynchronous work
            Console.WriteLine("Task2 completed.");
        }
    }
}
