using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AmableQuishpePromBurgers.Models;

    public class PromBurgersContext : DbContext
    {
        public PromBurgersContext (DbContextOptions<PromBurgersContext> options)
            : base(options)
        {
        }

        public DbSet<AmableQuishpePromBurgers.Models.Burges> Burges { get; set; } = default!;
    }
