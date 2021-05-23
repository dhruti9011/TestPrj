using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridgeInventory.Services
{
    /// <summary>
    /// Generic constraints to limit access of the data to class only
    /// </summary>
    /// <typeparam name="T">any class type is allowed</typeparam>
    public interface ICommonRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<T> SaveAsync(T entity);
    }
}
