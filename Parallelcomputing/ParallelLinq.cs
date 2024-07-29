namespace ConcurrentComputing
{
    public class ParallelLinq
    {
        public void ParallelLinqCompute()
        {
            var num = Enumerable.Range(0, 10);
            var paraQuery = num.AsParallel().Select(n => n * n);

            foreach (var item in paraQuery)
            {
                Console.WriteLine(item);
            }
        }
    }
}
