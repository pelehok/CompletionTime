using CompletionTime.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompletionTime.Services
{
    class FileService
    {
        private static string filename = @"I:/Jobs1.txt";
        public static List<Job> ReadFile()
        {
            List<Job> res = new List<Job>();

            string[] lines = System.IO.File.ReadAllLines(filename);

            for(int i=1;i<lines.Length;i++)
            {
                string[] job = lines[i].Split(' ');

                res.Add(new Job() { weight = Convert.ToInt32(job[0]), lenght = Convert.ToInt32(job[1]) });
            }
            return res;
        }
    }
}
