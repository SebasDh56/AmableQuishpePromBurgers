using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AmableQuishpePromBurgers.Models;

    public class AmableQuishpePromBurgersContext : DbContext
    {
        public AmableQuishpePromBurgersContext (DbContextOptions<AmableQuishpePromBurgersContext> options)
            : base(options)
        {
        }

        public DbSet<AmableQuishpePromBurgers.Models.Burger> Burger { get; set; } = default!;

public DbSet<AmableQuishpePromBurgers.Models.Promo> Promo { get; set; } = default!;
    }
