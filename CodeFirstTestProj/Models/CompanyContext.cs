using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstTestProj.Models
{
    class CompanyContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Member> Members { get; set; }
    }
}
