using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatsharm2al.Data;
using RecruitCatsharm2al.Models;

namespace RecruitCatsharm2al.Pages.Companies
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCatsharm2al.Data.RecruitCatsharm2alContext _context;

        public IndexModel(RecruitCatsharm2al.Data.RecruitCatsharm2alContext context)
        {
            _context = context;
        }

        public IList<Company> Company { get;set; }

        public async Task OnGetAsync()
        {
            Company = await _context.Company
                .Include(c => c.Industry)
                //Include(x => x.Industry)
                .Include(c => c.JobTitle).ToListAsync();
        }
    }
}
