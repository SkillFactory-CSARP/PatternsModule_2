using System;
using System.Text;

namespace AntiPatternsTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            var candidate = new Candidate()
            {
                SkillLevel = 5
            };

            var result = candidate.PassInterview("HR Сергей");

            Console.WriteLine(result);
            Console.WriteLine(candidate.InterviewerRemarks);
        }
    }
}