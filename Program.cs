using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace speedrun_timer
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Stopwatch stopwatch = new Stopwatch();
                Console.WriteLine("Press any key to start...");
                Console.ReadKey();
                Console.WriteLine("\nTiming...");

                stopwatch.Start();
                Console.ReadKey();
                stopwatch.Stop();
                Console.WriteLine($"\nElapsed time: {stopwatch.ElapsedMilliseconds} millis");
            }
        }
    }
}
