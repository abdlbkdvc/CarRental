﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAllListAsync();
        Task<T> GetByIdAsync(int id);
        Task CreateAsync(T entity);
        Task DeleteAsync(T entity);
        Task UpdateAsync(T entity);
    }
}
