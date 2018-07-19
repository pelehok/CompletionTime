using CompletionTime.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompletionTime
{
    delegate int MethodCompere(Job item1, Job item2);

    class GreedyAlgorithm
    {
        private List<Job> _jobs { get; set; }

        private MethodCompere _method { get; set; }

        public long Result { get; set; }
        public GreedyAlgorithm(List<Job> jobs,MethodCompere method)
        {
            _jobs = jobs;
            _method = method;
            Process();
        }
        private void Process() 
        {
            _jobs.Sort(Compere);
            List<CompletionTimeForJob> compeTime = new List<CompletionTimeForJob>();

            CalculateCompetTimeForJob(compeTime);

            CalculateMinCompetTime(compeTime);
        }

        private void CalculateMinCompetTime(List<CompletionTimeForJob> completionTimes)
        {
            long sum = 0;
            for(int i = 0; i < completionTimes.Count; i++)
            {
                long dod = completionTimes[i].Time * completionTimes[i].Job.weight;
                sum += dod;
            }
            Result = sum;
        }

        private void CalculateCompetTimeForJob(List<CompletionTimeForJob> completionTimes)
        {
            int sum = 0;
            for(int i = 0; i < _jobs.Count; i++)
            {
                sum += _jobs[i].lenght;
                completionTimes.Add(new CompletionTimeForJob() { Job = _jobs[i], Time = sum });
            }
        }

        public int Compere(Job i1,Job i2)
        {
            return _method(i1,i2);
        }
    }
}
