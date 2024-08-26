using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Diagnostics;

namespace MVC.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<MVCApplicationDbContext>
{
    public MVCApplicationDbContext CreateDbContext(string[] args)
    {
        string mainPath = Path.GetFullPath(Path.Combine(System.Environment.CurrentDirectory, @"..\"));
        string folderPath = @"MVC.NetCore\"; // Ensure this path is correct
        var builder = new DbContextOptionsBuilder<MVCApplicationDbContext>();

        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(mainPath + folderPath)
            .AddJsonFile("appsettings.json")
            .Build();

        builder.UseSqlServer(configuration.GetConnectionString("MVCApplicationDbContextconstrg"));
        return new MVCApplicationDbContext(builder.Options);
    }
}
}
//namespace MVC.Data
//{
//    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<MVCApplicationDbContext>
//    {
//        public MVCApplicationDbContext CreateDbContext(string[] args)
//        {
//            string mainPath = Path.GetFullPath(Path.Combine(System.Environment.CurrentDirectory, @"..\"));
//            string folderPath = @"mMoser.Web.NetCore\";
//            var builder = new DbContextOptionsBuilder<MVCApplicationDbContext>();
//            IConfigurationRoot configuration = new ConfigurationBuilder()
//            .SetBasePath(mainPath + folderPath)
//            .AddJsonFile("appsettings.json")
//            .Build();
//            builder.UseSqlServer(configuration.GetConnectionString("MVCApplicationDbContextconstrg"));
//            return new MVCApplicationDbContext(builder.Options);
//        }
//    }
//}
