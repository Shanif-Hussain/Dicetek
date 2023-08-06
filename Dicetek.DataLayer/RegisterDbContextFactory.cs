using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Dicetek.DomainLayer;

namespace Dicetek.DataLayer
{
    public class RegisterDbContextFactory : IDesignTimeDbContextFactory<RegisterDbContext>
    {
        public RegisterDbContext CreateDbContext(string[] args) {
            AppConfiguration appConfig = new AppConfiguration();
            var opsBuilder = new DbContextOptionsBuilder<RegisterDbContext>();
            opsBuilder.UseSqlServer(appConfig.sqlConnectionString);
            return new RegisterDbContext(opsBuilder.Options);
        }
    }
}
