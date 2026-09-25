using System;
using System.Collections.Generic;
using System.Text;

namespace Multithreading
{
    internal class Game
    {
        object obj = new object();
        internal void GetScore()
        {
            lock (obj)
            {
                int score = 0;
                Random r = new Random();
                for (int i = 1; i <= 6; i++)
                {
                    int roll = r.Next(1, 7);
                    Thread.Sleep(1000); // Simulate some work
                    Console.WriteLine($"{Thread.CurrentThread.Name} rolled - {roll} ");
                    score += roll;
                }  
                
                Console.WriteLine($"{Thread.CurrentThread.Name} scored {score} runs.\n\n");
            }
        }

        internal void GetScoreWithoutLock()
        {
            int score = 0;
            Random r = new Random();
            for (int i = 1; i <= 6; i++)
            {
                int roll = r.Next(1, 7);
                Thread.Sleep(1000); // Simulate some work
                Console.WriteLine($"{Thread.CurrentThread.Name} rolled - {roll}.");
                score += roll;
            }
            Console.WriteLine($"Thread {Thread.CurrentThread.Name} scored {score} runs.\n\n");
        }

        internal void GetWinner()
        {
            

        }
    }
}
