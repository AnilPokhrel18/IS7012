using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatsharm2al.Models
{
    public class Company
    {
        
        public Industry Industry { get; set; }

        [DisplayName("Industry")]
        public int IndustryId { get; set; }

        [StringLength(50, MinimumLength = 1)]
        [Required(ErrorMessage = "Invalid Company name")]
        public string Name { get; set; }
        
        [DisplayName("Minimum Salary")]
        public decimal MinSalary { get; set; }
        [DisplayName("Maximum Salary")]
        public decimal MaxSalary { get; set; }
        
        [DisplayName("Start Date")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }
        
        [StringLength(200, MinimumLength = 5)]
        [Required(ErrorMessage = "Invalid Location name")]
        public string Location { get; set; }
        
        [Range(1, 999999)]
        public int Id { get; set; }


        [DisplayName("Green Initiative")]
        public bool GreenInitiative { get; set; }
        [DisplayName("Job Titles")]
        public JobTitle JobTitle { get; set; }


        [DisplayName("Candidates")]
        public List<Candidate> CandidateIds { get; set; }


        [DisplayName("Open Positions")]
        public bool OpenPositin { get; set; }


        [DisplayName("Job Titles")]
        [Range(1, 999999)]
        public int JobTitleId { get; set; }
    }
}
