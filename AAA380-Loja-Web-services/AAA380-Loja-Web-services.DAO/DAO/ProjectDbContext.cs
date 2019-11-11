using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loja_Web_services.Entidade.Entidade;
using Microsoft.EntityFrameworkCore;

namespace AAA380_Loja_Web_services.DAO.DAO
{
    public class ProjectDbContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                optionsBuilder.UseSqlServer("SERVER=DESKTOP-UQSM4T9\\HENRIQUE; DATABASE=ProjectDB; Integrated Security=true;");

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
