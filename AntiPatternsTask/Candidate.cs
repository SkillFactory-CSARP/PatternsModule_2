using System;

namespace AntiPatternsTask
{
    public class Candidate
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime InterviewDate { get; set; }
        public int RecruiterId { get; set; }
        public string Recruiter { get; set; }
        public string Interviewer { get; set; }
        public string InterviewerRemarks { get; set; }
        public double CurrentSalary { get; set; }
        public double ExpectedSalary { get; set; }
        public int SkillLevel { get; set; }

        public bool PassInterview(string interViewerName, string interviewerAddress = null)
        {
            Interviewer = interViewerName;

            if (!string.IsNullOrEmpty(Recruiter))
                Recruiter = Interviewer;

            if (!string.IsNullOrEmpty(interviewerAddress))
                Address = interviewerAddress;
            
            if (SkillLevel < 8)
            {
                CurrentSalary = 0;
                InterviewerRemarks = "Не прошел собеседованиие";
                return false;

            }
            else if(DateTime.Now - InterviewDate > TimeSpan.FromHours(1))
            {
                CurrentSalary = 0;
                InterviewerRemarks = "Опоздал на собеседованиие";
                return false;
            }
            else
            {
                CurrentSalary = ExpectedSalary - (ExpectedSalary * 0.15);
                
                InterviewerRemarks = "Прошел собеседование";
                return true;
            }
        }
    }
}