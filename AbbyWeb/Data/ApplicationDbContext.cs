using AbbyWeb.Model;
using Microsoft.EntityFrameworkCore;

namespace AbbyWeb.Data
{
    public class ApplicationDbContext:DbContext
    {
        private readonly ApplicationDbContext _context;
        public ApplicationDbContext(ApplicationDbContext context)
        {
            _context= context;
        }

        public DbSet<Category> Category { get; set; }
    }
}
