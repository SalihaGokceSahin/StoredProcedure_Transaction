using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL
{
    public class CustomerRepository : ICustomerRepository
    {
       
        DatabaseContext _context;
        public CustomerRepository(DatabaseContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T:class
        {
            _context.Add(entity);
            _context.SaveChangesAsync();
        }

        public void Delete<T>(T entity) where T:class
        {
            _context.Remove(entity);
            _context.SaveChangesAsync();
        }

        public Customer GetCustomerById(int id)
        {
            var customer = _context.Customers.Find(id);
            return customer;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            var customers = _context.Customers.ToList();
            return customers;
        }

        //public void Update<T>(int id,T entity) where T:class
        //{
        //    var customer = _context.Customers.Find(id);


        //}
    }
}
