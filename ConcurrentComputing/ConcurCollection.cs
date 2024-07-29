using System.Collections.Concurrent;

namespace ConcurrentComputing
{
    public class ConcurCollection
    {
        public void ConcurCompute()
        {
            var concurrentBag = new ConcurrentBag<int>();

            Parallel.For(0, 10, i =>
            {
                concurrentBag.Add(i);
            });

            foreach (var item in concurrentBag)
            {
                Console.WriteLine(item);
            }
        }
    }
}
