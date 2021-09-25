using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Threading.Tasks;

namespace RecruitCatsharm2al.Models
{
    public class Industry
    {

            [StringLength(200, MinimumLength = 1)]
            [Required(ErrorMessage = "Invalid Industry name")]
            public string Name { get; set; }
            [DisplayName("Id")]
            [Range(1, 999)]
            public int Id { get; set; }
            [DisplayName("Type")]
            [StringLength(30, MinimumLength = 5)]
            [Required(ErrorMessage = "Invalid Industry Type")]
            public string Type { get; set; }
            [DisplayName("Global Rank")]
            [Range(1,9999)]
            public int? GlobalRank { get; set; }
            
            [DataType(DataType.Date)]
            [DisplayName("StartDate")]
            public DateTime Genesis { get; set; }
            [DisplayName("CompanyIds")]
            public List<Company> ComapnyIds { get; set; }
            [DisplayName("CandidateIds")]
            public List<Candidate> CandiadateIds { get; set; }
        }
    }
