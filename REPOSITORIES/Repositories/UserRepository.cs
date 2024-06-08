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
    public class UserRepository : IUserRepository
    {
        IDataSource _dataSource;
        public UserRepository(IDataSource datasource)
        {
            _dataSource=datasource; 
        }
        public async Task<User>AddAsync(User entity)
        {
           _dataSource.Users.Add(entity);
            await _dataSource.SaveChangesAsync();
            return entity;  
        }

        //public void DeleteAsync(int key)
        //{
        //    _dataSource.Users.Remove(_dataSource.Users.ToList()[key]);
        //}

        public async Task<List<User>> GetAllAsync()
        {
            return await _dataSource.Users.ToListAsync();
        }

        public async Task<User> GetByIdAsync(int key)
        {
            try
            {
                if (_dataSource.Users.First(k => k.UserId == key) != null)
                    return await _dataSource.Users.FirstAsync(k => k.UserId == key);

                else
                    throw new Exception("no value matches");
                   
            }
            catch (Exception)
            { 

                throw ;
            }
        }

        //public void UpdateAsync(User entity)
        //{

        //    for (int i = 0; i < _dataSource.Users.Count(); i++)
        //    {
        //        if (_dataSource.Users.ToList()[i].UserId==entity.UserId)
        //        {
        //            _dataSource.Users.ToList()[i].Name = entity.Name;
        //            _dataSource.Users.ToList()[i].FamilyName = entity.FamilyName;
        //            _dataSource.Users.ToList()[i].TZ = entity.TZ;
        //            _dataSource.Users.ToList()[i].DOB = entity.DOB;
        //            _dataSource.Users.ToList()[i].Gender = entity.Gender;
        //            _dataSource.Users.ToList()[i].HMO = entity.HMO;
        //            for (int j = 0; j < entity.Children.Count(); j++)
        //            {
        //                if (j < _dataSource.Users.ToList()[i].Children.Count())
        //                    _dataSource.Users.ToList()[i].Children[j] = entity.Children[j];
        //                else
        //                    _dataSource.Users.ToList()[i].Children.Add(entity.Children[j]);
        //            }

        //        }
        //    }
        //}
    }
}
