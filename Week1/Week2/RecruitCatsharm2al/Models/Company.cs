using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatsharm2al.Models
{
    public class Company
    {
        public Industry Industry { get; set; }
        public int IndustryId { get; set; }
        public string Name { get; set; }
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }
        public DateTime? StartDate { get; set; }
        public int CompanyId { get; set; }
        public string Recruiting { get; set; }
        public int Id { get; set; }
        public bool GreenInitiative { get; set; }
        public JobTitle JobTitle { get; set; }
        public List<Candidate> CandidateIds { get; set; }
        public bool OpenPositin { get; set; }
        public int JobTitleId { get; set; }
    }
}
