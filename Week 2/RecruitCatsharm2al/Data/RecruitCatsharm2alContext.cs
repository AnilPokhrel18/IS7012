using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitCatsharm2al.Models;

namespace RecruitCatsharm2al.Data
{
    public class RecruitCatsharm2alContext : DbContext
    {
        public RecruitCatsharm2alContext (DbContextOptions<RecruitCatsharm2alContext> options)
            : base(options)
        {
        }

        public DbSet<RecruitCatsharm2al.Models.Candidate> Candidate { get; set; }

        public DbSet<RecruitCatsharm2al.Models.JobTitle> JobTitle { get; set; }

        public DbSet<RecruitCatsharm2al.Models.Company> Company { get; set; }

        public DbSet<RecruitCatsharm2al.Models.Industry> Industry { get; set; }
    }
}
