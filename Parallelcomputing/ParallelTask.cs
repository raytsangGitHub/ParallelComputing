namespace Parallelcomputing
{
    public class ParallelTask
    {
        public void ParallelCompute(int proc)
        {
            Parallel.For(0, proc, i =>
            {
                Console.WriteLine($"Processing {i} on thread {Task.CurrentId}");
            });
        }
    }
}
