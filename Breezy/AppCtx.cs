using Breezy.Models.BaseManagement;
using Breezy.Models.SystemManagement;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breezy
{
    internal class AppCtx : DbContext
    {
        #region system management
        public DbSet<Account> Accounts { get; set; }
        #endregion

        #region base management
        public DbSet<Company> Companys { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string localConn = "server=localhost;uid=root;pwd=sniper89757;database=breezy";
                optionsBuilder
                    .UseMySql(localConn, ServerVersion.AutoDetect(localConn));
            }
        }
    }
}
