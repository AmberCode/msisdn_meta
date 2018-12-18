using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Reflection;

namespace DAL.Entities
{
    ////Generate Migration
    ////cmd: dotnet ef migrations add initial
    //public class TemporaryDbContextFactory : IDesignTimeDbContextFactory<MsisdnContext>
    //{
    //    public MsisdnContext CreateDbContext(string[] args)
    //    {
    //        var builder = new DbContextOptionsBuilder<MsisdnContext>();
    //        builder.UseSqlServer("Server=localhost\\sqlexpress;Database=efmigrations2017;Trusted_Connection=True;MultipleActiveResultSets=true",
    //            optionsBuilder => optionsBuilder.MigrationsAssembly(typeof(MsisdnContext).GetTypeInfo().Assembly.GetName().Name));
    //        return new MsisdnContext(builder.Options);

    //    }
    //}
}
