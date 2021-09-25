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
    public class IndexModel : PageModel
    {
        private readonly RecruitCatsharm2al.Data.RecruitCatsharm2alContext _context;

        public IndexModel(RecruitCatsharm2al.Data.RecruitCatsharm2alContext context)
        {
            _context = context;
        }

        public IList<Candidate> Candidate { get;set; }

        public async Task OnGetAsync()
        {
            Candidate = await _context.Candidate
                .Include(c => c.Company)
                .Include(c => c.Industry)
                .Include(c => c.JobTitle).ToListAsync();
        }
    }
}
