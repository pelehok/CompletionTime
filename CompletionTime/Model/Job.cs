using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompletionTime.Model
{
    public class Job : IItem
    {
        public int weight { get; set; }
        public int lenght { get; set; }
    }
}
