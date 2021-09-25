using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RecruitCatsharm2al.Data;
using RecruitCatsharm2al.Models;

namespace RecruitCatsharm2al.Pages.Candidates
{
    public class CreateModel : PageModel
    {
        private readonly RecruitCatsharm2al.Data.RecruitCatsharm2alContext _context;

        public CreateModel(RecruitCatsharm2al.Data.RecruitCatsharm2alContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CompanyId"] = new SelectList(_context.Company, "Id", "Name");
        ViewData["IndustryId"] = new SelectList(_context.Industry, "Id", "Name");
        ViewData["JobTitleId"] = new SelectList(_context.JobTitle, "Id", "Title");
            return Page();
        }

        [BindProperty]
        public Candidate Candidate { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Candidate.Add(Candidate);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
