﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interfaces;
using Domain.Models;

namespace Domain.Interfaces
{
    public interface IUserRepository : IRepositoryBase<Pokupatel>
    {
        public Task<Pokupatel?> GetByEmailAndPassword(string email, string password);
    }
}
