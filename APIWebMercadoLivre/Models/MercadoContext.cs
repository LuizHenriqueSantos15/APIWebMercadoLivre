using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIWebMercadoLivre.Models
{
    public class MercadoContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-I7KDD5F;Initial Catalog=MercadoLivre;Integrated Security=True");
        }
    }
}
