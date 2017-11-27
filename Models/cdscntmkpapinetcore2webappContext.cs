using Microsoft.EntityFrameworkCore;

namespace cdscntmkpapinetcore2webapp.Models
{
    public class cdscntmkpapinetcore2webappContext : DbContext
    {
        public cdscntmkpapinetcore2webappContext (DbContextOptions<cdscntmkpapinetcore2webappContext> options)
            : base(options)
        {
        }

        public DbSet<cdscntmkpapinetcore2webapp.Models.SoapCall> SoapCall { get; set; }
    }
}