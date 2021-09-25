using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatsharm2al.Data;
using RecruitCatsharm2al.Models;

namespace RecruitCatsharm2al.Pages.JobTitles
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCatsharm2al.Data.RecruitCatsharm2alContext _context;

        public IndexModel(RecruitCatsharm2al.Data.RecruitCatsharm2alContext context)
        {
            _context = context;
        }

        public IList<JobTitle> JobTitle { get;set; }

        public async Task OnGetAsync()
        {
            JobTitle = await _context.JobTitle.ToListAsync();
        }
    }
}
