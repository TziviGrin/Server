using Microsoft.EntityFrameworkCore;
using REPOSITORIES.Entities;
using REPOSITORIES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPOSITORIES.Repositories
{
    public class ChildRepository : IChildRepository
    {

        IDataSource _dataSource;
        public ChildRepository(IDataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public async Task<Child> AddAsync(Child entity)
        {
            _dataSource.Children.Add(entity);
            await _dataSource.SaveChangesAsync();
            return entity;
        }

        //public void DeleteAsync(int key)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<List<Child>> GetAllAsync()
        {
            return await _dataSource.Children.ToListAsync();
        }
      
        public async Task<Child>GetByIdAsync(int key)
        {
            return await _dataSource.Children.FindAsync(key);
        }

        //public void UpdateAsync(Child entity)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
