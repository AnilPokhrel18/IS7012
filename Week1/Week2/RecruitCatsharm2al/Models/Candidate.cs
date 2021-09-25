using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatsharm2al.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
        public decimal TargetSalary { get; set; }
        public DateTime? StartDate { get; set; }
        public JobTitle JobTitle { get; set; }
        public int JobTitleId { get; set; }
        public Company Company { get; set; }
        public int CompanyId { get; set; }
        public Industry Industry { get; set; }
        public int IndustryId { get; set; }
    }
}