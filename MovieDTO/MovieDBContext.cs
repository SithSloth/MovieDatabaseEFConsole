

using Microsoft.EntityFrameworkCore;

namespace MovieDTO
{
    public class MovieDBContext : DbContext
    {
        public DbSet <Movie> Movies { get; set; }
    }
}