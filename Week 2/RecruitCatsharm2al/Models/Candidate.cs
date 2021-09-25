using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatsharm2al.Models
{
    public class Candidate
    {
        [Range(1, 999)]
        public int Id { get; set; }

        [DisplayName("First Name")]
        [StringLength(30, MinimumLength = 1)]
        [Required(ErrorMessage = "Invalid first name")]
        public string First { get; set; }
        [DisplayName("Last Name")]
        [StringLength(30, MinimumLength = 1)]
        [Required(ErrorMessage = "Invalid Last name")]
        public string Last { get; set; }
        
        [DisplayName("Target Salary")]
        public decimal TargetSalary { get; set; }
        [DisplayName("Start Date")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }
        [DisplayName("Job Title")]
        public JobTitle JobTitle { get; set; }
        [StringLength(25, MinimumLength = 6)]
        [Required(ErrorMessage = "Invalid Job Title ")]

        [DisplayName("Job Title")]
        [Range(1, 9999999)]
        public int JobTitleId { get; set; }
        public Company Company { get; set; }
        [DisplayName("Company")]
        [Range(1, 99999999)]
        public int CompanyId { get; set; }
        public Industry Industry { get; set; }
        [DisplayName("Industry")]
        [Range(1, 99999999)]
        public int IndustryId { get; set; }
    }
}
