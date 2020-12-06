using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public interface ICustomerRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T:class;
        IEnumerable<Customer> GetCustomers();
        Customer GetCustomerById(int id);
        void Create(Customer customers);

    }
}
