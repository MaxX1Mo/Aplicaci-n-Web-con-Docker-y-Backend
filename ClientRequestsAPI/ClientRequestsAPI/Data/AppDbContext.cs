using Microsoft.EntityFrameworkCore;
using ClientRequestsAPI.Models;
namespace ClientRequestsAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<ClientRequest> ClientRequests { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientRequest>().ToTable("client_requests");
        }
    }
}