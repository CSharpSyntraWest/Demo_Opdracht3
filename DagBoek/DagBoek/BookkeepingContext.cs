using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DagBoek
{
    public class BookkeepingContext:DbContext
    {
        public BookkeepingContext(DbContextOptions<BookkeepingContext> options)
                   : base(options)
        {
        }

        public DbSet<FinancieelDagBoek> FinancieelDagBoek { get; set; }
        public DbSet<DiversenDagBoek> DiversenDagboek { get; set; }
        public DbSet<KasBoek> Kasboek { get; set; }
        public DbSet<AankoopDagBoek> aankoopDagboek { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<ShoppingCart> ShoppingCart { get; set; }
        public DbSet<OrderHeader> OrderHeader { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
    }
}
