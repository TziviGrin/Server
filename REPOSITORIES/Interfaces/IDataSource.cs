using Microsoft.EntityFrameworkCore;
using REPOSITORIES.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPOSITORIES.Interfaces
{
    public interface IDataSource
    {
        DbSet<User> Users{ get; set; }
        DbSet<Child> Children { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
