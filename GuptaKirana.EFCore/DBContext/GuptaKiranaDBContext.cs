using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace GuptaKirana.EFCore.DBContext
{
    public class GuptaKiranaDBContext : DbContext
    {
        public GuptaKiranaDBContext(DbContextOptions<GuptaKiranaDBContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }

    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<GuptaKiranaDBContext>
    {
        public GuptaKiranaDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile(@Directory.GetCurrentDirectory() + "/../GuptaKirana.API/appsettings.json").Build();
            var builder = new DbContextOptionsBuilder<GuptaKiranaDBContext>();
            var connectionString = configuration.GetSection("ConnectionString")["DefaultConnection"];
            builder.UseSqlServer(connectionString);
            return new GuptaKiranaDBContext(builder.Options);
        }
    }
}
