using System.Runtime.InteropServices;

namespace Parallelcomputing.SpecifyProcessor
{
    public static class SpecifyProcessor
    {
        [DllImport("kernel32.dll")]
        private static extern IntPtr GetCurrentThread();

        [DllImport("kernel32.dll")]
        private static extern uint SetThreadAffinityMask(IntPtr hThread, UIntPtr dwThreadAffinityMask);

        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Thread running on core {Thread.GetCurrentProcessorId()}");
                Thread.Sleep(1000);
            }
        }
        public static void SetProcessorAffinity(Thread thread, int core)
        {
            // Wait for the thread to start
            thread.Join();

            // Get the current thread handle
            IntPtr handle = GetCurrentThread();

            // Set the processor affinity mask
            UIntPtr affinityMask = new UIntPtr((uint)(1 << core));
            SetThreadAffinityMask(handle, affinityMask);
        }
        public static void SetThreadAffinity(Thread thread, int core)
        {
            // Wait for the thread to start
            thread.Join();

            // Get the current thread handle
            IntPtr handle = GetCurrentThread();

            // Set the processor affinity mask
            UIntPtr affinityMask = new UIntPtr((uint)(1 << core));
            SetThreadAffinityMask(handle, affinityMask);
        }

        public static int GetCurrentProcessorId()
        {
            int processorId = -1;
            Thread.BeginThreadAffinity();
            try
            {
                processorId = Thread.GetCurrentProcessorId();
            }
            finally
            {
                Thread.EndThreadAffinity();
            }

            return processorId;
        }
    }
}
