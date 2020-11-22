using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Basic_Crm.Data;
using BL;
using DAL;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Basic_Crm.Controllers
{
    [Authorize]
    public class CustomerController : Controller
    {
        AuthDbContext _authDbContext;
        ICustomerRepository _customerRepository;
        DatabaseContext _DatabaseContext;
        public CustomerController(ICustomerRepository customerRepository,AuthDbContext authDbContext, DatabaseContext databaseContext)
        {
            _customerRepository = customerRepository;
            _authDbContext = authDbContext;
            _DatabaseContext = databaseContext;
        }
        public ActionResult Add(Customer customer)
        {
            customer.UserSession = User.Identity.Name;

            if (!ModelState.IsValid)
            {
                return View(customer);
            }
            if (customer.Id == 0 && customer.Name != null)
            {
                _DatabaseContext.Add(customer);
            }
            else
            {
                var editCustomer = _DatabaseContext.Customers.FirstOrDefault(x => x.Id == customer.Id);
                if (editCustomer == null)
                {
                    return NotFound();
                }
                editCustomer.Id = customer.Id;
                editCustomer.Name = customer.Name;
                editCustomer.Surname = customer.Surname;
                editCustomer.Phone = customer.Phone;
                editCustomer.UserSession = customer.UserSession;
                editCustomer.Gender = customer.Gender;
                editCustomer.Adress = customer.Adress;
            }
            _DatabaseContext.SaveChanges();
            //return View(customer);
            return RedirectToAction("getcustomers", customer);
        }

        [HttpGet]
        public async Task<ActionResult> GetCustomers()
        {
            IEnumerable<Customer> customer = _customerRepository.GetCustomers();
            var customerList = customer.Where(x => x.UserSession == User.Identity.Name).ToList();
            return View(customerList);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var customer = _customerRepository.GetCustomerById(id);
            _customerRepository.Delete(customer);
            return RedirectToAction("GetCustomers");
        }
        public async Task<IActionResult> GetCustomerById(int id)
        {
            _customerRepository.GetCustomerById(id);
            return View();
            //var model = _customerRepository.GetCustomerById(id);
            //return View("Add", model);
        }
        public ActionResult Edit(int id)
        {
            var model = _customerRepository.GetCustomerById(id);
            if (model == null)
            {
                NotFound();
            }
            return View("Add", model);
        }
    }
}
