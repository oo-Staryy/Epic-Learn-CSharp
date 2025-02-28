using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Services
{
    public static class TimeMeter
    {
        public static void Run(Action action)
        {
            Stopwatch sv = new();
            sv.Start();
            action();
            sv.Stop();
            Console.WriteLine($"Executing time: {sv.Elapsed}");
        }
    }
}
