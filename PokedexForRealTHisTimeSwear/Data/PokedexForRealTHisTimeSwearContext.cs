using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PokedexForRealTHisTimeSwear.Models;

namespace PokedexForRealTHisTimeSwear.Data
{
    public class PokedexForRealTHisTimeSwearContext : DbContext
    {
        public PokedexForRealTHisTimeSwearContext (DbContextOptions<PokedexForRealTHisTimeSwearContext> options)
            : base(options)
        {
        }

        public DbSet<PokedexForRealTHisTimeSwear.Models.Pokemon> Pokemon { get; set; } = default!;
    }
}
