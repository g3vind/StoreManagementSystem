using Microsoft.EntityFrameworkCore;

namespace Crud_With_UI.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
