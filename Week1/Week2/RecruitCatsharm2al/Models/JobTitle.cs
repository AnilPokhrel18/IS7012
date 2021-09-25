using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatsharm2al.Models
{
    public class JobTitle
    {
        public int Id { get; set; }
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }
        public string Title { get; set; }
        public List<Company> Company { get; set; }
        public List<Candidate> CandidateIds { get; set; }
        public int OpenPositionId { get; set; }
    }
}
