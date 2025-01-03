using BibliotecaFilmesLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaFilmesLibrary.Data
{
    public class BibliotecaFilmeContext : DbContext
    {
        public BibliotecaFilmeContext(DbContextOptions<BibliotecaFilmeContext> opts):
            base(opts)
        {
               
        }
        public DbSet<User> Users { get; set; }
    }
}
