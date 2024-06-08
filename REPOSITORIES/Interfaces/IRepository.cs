using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPOSITORIES.Interfaces
{
    public interface IRepository<T>
    {
       Task<T> AddAsync(T entity);
     // Task UpdateAsync(T entity);
      //Task DeleteAsync(int key);
        Task<T> GetByIdAsync(int key);
        Task<List<T>> GetAllAsync();
        //search


    }
}
