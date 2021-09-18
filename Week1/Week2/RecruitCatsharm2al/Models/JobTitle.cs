using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatsharm2al.Models
{
    public class JobTitle
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal SalaryMin { get; set; }
        public decimal SalaryMax { get; set; }
        public int CompanyId { get; set; }
        public List<Candidate> CandidateIds { get; set; }
        public Company OpenRole { get; set; }
        public int OpenRoleId { get; set; }
    }
}
