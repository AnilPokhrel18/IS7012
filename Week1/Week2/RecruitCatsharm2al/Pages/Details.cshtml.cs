using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatsharm2al.Data;
using RecruitCatsharm2al.Models;

namespace RecruitCatsharm2al.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatsharm2al.Data.RecruitCatsharm2alContext _context;

        public DetailsModel(RecruitCatsharm2al.Data.RecruitCatsharm2alContext context)
        {
            _context = context;
        }

        public Candidate Candidate { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Candidate = await _context.Candidate
                .Include(c => c.Company)
                .Include(c => c.Industry)
                .Include(c => c.JobTitle).FirstOrDefaultAsync(m => m.Id == id);

            if (Candidate == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
