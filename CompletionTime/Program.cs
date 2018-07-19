using CompletionTime.Model;
using CompletionTime.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompletionTime
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Job> jobs = FileService.ReadFile();

            GreedyAlgorithm greedyAlgorithm = new GreedyAlgorithm(new List<Job>(jobs), new CompereMethods().Diff);

            Console.WriteLine(greedyAlgorithm.Result);
            greedyAlgorithm = new GreedyAlgorithm(new List<Job>(jobs), new CompereMethods().Ratio);

            Console.WriteLine(greedyAlgorithm.Result);
            Console.ReadKey();
        }
    }
}
