using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BrasilTeamMVC.Models;

namespace BrasilTeamMVC.Data
{
    public class BrasilTeamMVCContext : DbContext
    {
        public BrasilTeamMVCContext (DbContextOptions<BrasilTeamMVCContext> options)
            : base(options)
        {
        }

        public DbSet<BrasilTeamMVC.Models.Brasil> Brasil { get; set; }
    }
}
