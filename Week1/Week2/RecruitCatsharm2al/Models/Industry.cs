using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatsharm2al.Models
{
    public class Industry
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Type { get; set; }
        public int? GlobalRank { get; set; }
        public DateTime Genesis { get; set; }
        public List<Company> ComapnyIds { get; set; }
        public List<Candidate> CandiadateIds { get; set; }
    }
}
