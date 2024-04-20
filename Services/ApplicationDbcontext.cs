using Microsoft.EntityFrameworkCore;
using MiMovil.Models;

namespace MiMovil.Services
{
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products{ get; set; }

    }
}
