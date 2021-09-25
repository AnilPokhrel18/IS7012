using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatsharm2al.Models
{
    public class JobTitle
    {
        public int Id { get; set; }

        [DisplayName("Minimum Salary")]
        public decimal MinSalary { get; set; }
        [DisplayName("Maximum Salary")]
        public decimal MaxSalary { get; set; }

        [StringLength(30, MinimumLength = 2)]
        [Required(ErrorMessage = "Invalid Job Title")]
        public string Title { get; set; }
        public List<Company> Comapany { get; set; }
    }
}
