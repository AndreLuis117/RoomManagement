using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json", true)
                 .AddEnvironmentVariables()
                 .Build();



            var builder = new DbContextOptionsBuilder<AppDbContext>();

            //var connectionString = configuration
            //            .GetConnectionString("DefaultConnection");

            var connectionString = "server=127.0.0.1; port=3306; database=dbRoomManagement; uid=root; pwd=room123-pw";

            //builder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString),
            //            x => x.MigrationsAssembly(typeof(ApplicationDbContextFactory).Assembly.FullName));

            builder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));



            return new AppDbContext(builder.Options);
        }
    }
}
