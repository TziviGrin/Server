using AutoMapper;
using REPOSITORIES.Interfaces;
using SERVICES.Interfaces;
using SERVICES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using REPOSITORIES.Entities;

namespace SERVICES.Services
{
    public class UserService : IUserService
    {
        IUserRepository _rep;
        IMapper _mapper;
        public  UserService(IUserRepository service, IMapper mapper)
        {
            _rep = service;
            _mapper = mapper;   
        }


        public async Task<UserModel> AddAsync(UserModel model)
        {
           
            return _mapper.Map<UserModel>(await _rep.AddAsync(_mapper.Map<User>(model)));
        }

        //public void DeleteAsync(int key)
        //{
        //   _rep.Delete(key);    
        //}
        
        public async Task<List<UserModel>>GetAllAsync()
        {
           List<UserModel>listToReturn=new List<UserModel>();   
            List<User>list= await _rep.GetAllAsync();
            foreach (var item in list)   
           listToReturn.Add(_mapper.Map<UserModel>(item));
            return listToReturn;
        }

        public async Task<UserModel> GetByIdAsync(int key)
        {
           return _mapper.Map<UserModel> (await _rep.GetByIdAsync(key));
        }

        //public void Update(UserModel model)
        //{
        //  _rep.Update( _mapper.Map<User>(model));   
        //}
    }
}
