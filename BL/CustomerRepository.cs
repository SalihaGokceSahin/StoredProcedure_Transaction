using DAL;
using Entities;
using Microsoft.EntityFrameworkCore;
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
        }


        public void Delete<T>(T entity) where T:class
        {
            _context.Remove(entity);
        }

        public Customer GetCustomerById(int Id)
        {
            return _context.Customers.FromSqlRaw<Customer>("EXECUTE dbo.spGetCustomerById {0}",Id).ToList().FirstOrDefault();

            //var customer = _context.Customers.Find(id);
            //return customer;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            //var customers = _context.Customers.ToList();
            //return customers;

            var customers = _context.Customers.FromSqlRaw<Customer>("spGetCustomers").ToList();
            return customers;

        }
        public void Create(Customer customer)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    _context.Customers.Add(customer);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }
        }

    }
}
