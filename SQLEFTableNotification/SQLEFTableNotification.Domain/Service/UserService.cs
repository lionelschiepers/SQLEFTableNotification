﻿using AutoMapper;
using SQLEFTableNotification.Entity;
using SQLEFTableNotification.Entity.UnitofWork;

namespace SQLEFTableNotification.Domain.Service
{
    public class UserService<Tv, Te> : GenericService<Tv, Te>, IUserService<Tv, Te>
                                                where Tv : UserViewModel
                                                where Te : User
    {
        //DI must be implemented in specific service as well beside GenericService constructor
        public UserService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            if (_unitOfWork == null)
                _unitOfWork = unitOfWork;
            if (_mapper == null)
                _mapper = mapper;
        }

        //add here any custom service method or override generic service method
        public bool DoNothing()
        {
            return true;
        }
    }

    internal interface IUserService<Tv, Te> : IService<Tv, Te>
    {
    }
}
