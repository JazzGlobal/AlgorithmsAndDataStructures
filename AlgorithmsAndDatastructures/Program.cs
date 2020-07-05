using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDatastructures
{
    class Program
    {
        static void Main(string[] args)
        {
            // Benchmark code template.

           /* Stopwatch s = new Stopwatch();
            var source = Enumerable.Range(1, 1000000).Cast<int>().ToArray(); // Sorted Array
            List<TimeSpan> times = new List<TimeSpan>();
            for(int runs = 0; runs < 3; runs++)
            {
                s.Start();
                var result = ArrayAlgorithms.GetIndex(source, 97586);
                s.Stop();
                Console.WriteLine(result);
                times.Add(s.Elapsed);
            }
            PrintBenchmark(times);
            Console.ReadLine(); */
        }

        static void PrintBenchmark(List<TimeSpan> times)
        {
            var average_elapsed = new TimeSpan();
            for (int time = 0; time < times.Count; time++)
            {
                {
                    average_elapsed += times[time];
                    Console.WriteLine($"Run #{time}:{times[time].TotalMilliseconds}");
                }
            }
            var average_miliseconds = average_elapsed.TotalMilliseconds / times.Count;
            Console.WriteLine($"Average Runtime: {average_miliseconds}");
        }
    }
}
