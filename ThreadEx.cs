using System;
using System.Collections.Generic;
using System.Text;

namespace Multithreading
{
    internal class ThreadEx
    {
        internal void Display()
        {
            for (int i=0; i< 5; i++)
            {
                Console.WriteLine($"ThreadEx.Display() method is running on thread {System.Threading.Thread.CurrentThread.ManagedThreadId}.");
                System.Threading.Thread.Sleep(2000); // Simulate some work
            }
            
        }
    }
}
