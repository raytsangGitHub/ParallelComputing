namespace Parallelcomputing
{
    public class LowerLevelThreading
    {
        public void LowerLevelThread()
        {
            Thread thread = new Thread(() => Console.WriteLine("Hello from a thread!"));
            thread.Start();
            thread.Join();
        }
    }
}
