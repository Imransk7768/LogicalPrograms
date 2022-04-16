using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class StopWatch
    {
        public void Measure()
        {
            Stopwatch stopWatch = new Stopwatch();
            Console.WriteLine("Click spacebar & enter to start stopwatch");
            string watcher = Console.ReadLine();
            if (watcher == " ")
            {
                stopWatch.Start();
                Console.WriteLine("Press spacebar & enter again to stop stopwatch");
                while (watcher == " ")
                {
                    watcher += Console.ReadLine();
                }
                stopWatch.Stop();
                Console.WriteLine($"Time elapsed is: {stopWatch.Elapsed} seconds");
            }
            else
            {
                Console.WriteLine("Press spacebar & enter to start and stop stopwatch");
            }
        }
    }
}
