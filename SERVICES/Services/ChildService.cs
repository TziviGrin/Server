using AutoMapper;
using REPOSITORIES.Entities;
using REPOSITORIES.Interfaces;
using SERVICES.Interfaces;
using SERVICES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICES.Services
{
    public class ChildService : IChildService
    {
        IChildRepository _rep;
        IMapper _mapper;
        public ChildService(IChildRepository rep, IMapper mapper)
        {
            _rep = rep; 
            _mapper = mapper;   
        }
        public async Task<ChildModel> AddAsync(ChildModel model)
        {
            
            return _mapper.Map<ChildModel>(await _rep.AddAsync(_mapper.Map<Child>(model)));
        }

        //public void Delete(int key)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<List<ChildModel>> GetAllAsync()
        {
            List<ChildModel> listToReturn = new List<ChildModel>();
            List<Child> list = await _rep.GetAllAsync();
            foreach (var item in list)
                listToReturn.Add(_mapper.Map<ChildModel>(item));
            return listToReturn;
        }

        public async Task<ChildModel> GetByIdAsync(int key)
        {
            return _mapper.Map<ChildModel>(await _rep.GetByIdAsync(key));   
        }

        //public void Update(ChildModel model)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
