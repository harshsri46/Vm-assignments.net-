using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxProfit
{
    class Job
    {
        public char Id { get; set; }
        public int Profit {  get; set; }
        public int Deadline {  get; set; }  

        public Job(char id, int profit,int deadline)
        {
            Id = id;
            Profit = profit;
            Deadline = deadline;
        }
    }
    
    class JobSequencing
    {
        static void Main()
        {
            List<Job> jobs = new List<Job>
            {
            new Job('A',50,2),
            new Job('B', 40, 2),
            new Job('C', 90, 1),
            new Job('D', 10, 3),
            new Job('E', 5, 3),
            new Job('F', 11, 2),
            new Job('G', 70, 1),
            new Job('H', 15, 4)
            };

            int maxDeadline = 4;
            List<Job> scheduledJobs = JobSequence(jobs, maxDeadline);
            Console.WriteLine("Jobs maximum profit");
            int totalProfit = 0;

            foreach (var job in scheduledJobs)
            {
                Console.WriteLine(job.Id + " ");
                totalProfit += job.Profit;
            }
            Console.WriteLine($"Total Profit:{totalProfit}");
        }
        static List<Job>
      JobSequence(List<Job> jobs,int maxDeadline)
        {
            jobs.Sort((a,b)=>b.Profit.CompareTo(a.Profit));

            List<Job>result=new List<Job>(new Job[maxDeadline]);

            bool[] timeSlots= new bool[maxDeadline];

            foreach (var job in jobs)
            {
                for (int j = Math.Min(maxDeadline, job.Deadline) - 1; j >= 0; j--)
                {
                    if (!timeSlots[j])
                    {
                        timeSlots[j] = true;
                        result[j] = job;
                        break;
                    }
                }
            }

            result.RemoveAll(job => job == null);
            return result;

        }
    }
   
    
}
