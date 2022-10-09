using Microsoft.EntityFrameworkCore;
using Trackingapi.Models;
namespace Trackingapi.Data
{
    public class IssueDbContext : DbContext
    {
        public IssueDbContext(DbContextOptions<IssueDbContext> options)
            : base(options)
        {
        }

        public DbSet<Issue> Issues { get; set; }
    }
}