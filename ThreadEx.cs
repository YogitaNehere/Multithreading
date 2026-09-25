using System;
using System.Collections.Generic;
using System.Text;

namespace Multithreading
{
    internal class ThreadEx
    {
        object obj = new object();
        internal void Display()
        {
            lock (obj)
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine($"Thread Subprocess {i} {Thread.CurrentThread.Name} {Thread.CurrentThread.ManagedThreadId}.");
                    Thread.Sleep(1000); // Simulate some work
                }
            }
            Console.WriteLine("Thread completed.");

        }
    }
}
