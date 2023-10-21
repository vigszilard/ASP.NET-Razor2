using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vig_Szilard_Lab2.Models;

namespace Vig_Szilard_Lab2.Data
{
    public class Vig_Szilard_Lab2Context : DbContext
    {
        public Vig_Szilard_Lab2Context (DbContextOptions<Vig_Szilard_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Vig_Szilard_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Vig_Szilard_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Vig_Szilard_Lab2.Models.Author>? Author { get; set; }
    }
}
