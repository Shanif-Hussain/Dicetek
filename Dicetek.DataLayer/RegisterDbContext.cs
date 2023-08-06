using Dicetek.DataLayer;
using Dicetek.DomainModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dicetek.DomainLayer
{
    public class RegisterDbContext : DbContext
    {
        public class OptionsBuild
        {
            public DbContextOptionsBuilder<RegisterDbContext> opsBuilder { get; set; }
            public DbContextOptions<RegisterDbContext> dbOptions { get; set; }
            public AppConfiguration settings { get; set; }

            public OptionsBuild()
            {
                settings = new AppConfiguration();
                opsBuilder = new DbContextOptionsBuilder<RegisterDbContext>();
                opsBuilder.UseSqlServer(settings.sqlConnectionString);
                dbOptions = opsBuilder.Options;
            }

        }
        public static OptionsBuild ops = new OptionsBuild();

        public RegisterDbContext(DbContextOptions<RegisterDbContext> options) : base(options)
        { }

        public DbSet<RegisterModel> Registers { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        //    optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=Dicetek;Integrated Security=True");
        //}
    }
}
