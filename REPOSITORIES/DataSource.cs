using Microsoft.EntityFrameworkCore;
using REPOSITORIES.Entities;
using REPOSITORIES.Interfaces;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;
using Microsoft.EntityFrameworkCore;

namespace REPOSITORIES
{
    public class DataSource : DbContext, IDataSource
    {
       // public Microsoft.EntityFrameworkCore.DbSet<User> IDataSource.Users { get; set; }

        public Microsoft.EntityFrameworkCore.DbSet<User> Users { get ; set ; }
        public Microsoft.EntityFrameworkCore.DbSet<Child> Children { get ; set ; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(@"Data Source=sqlsrv;Initial Catalog=rikiShmuelEx2;Integrated Security=True;trustServerCertificate=true");
            //base.OnConfiguring(optionBuilder);
        }
        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
        //public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    return await base.SaveChangesAsync(cancellationToken);  
        //}

    }
}
