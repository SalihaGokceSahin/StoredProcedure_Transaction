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
        ICustomerRepository _customerRepository;
        DatabaseContext _DatabaseContext;
        public CustomerController(ICustomerRepository customerRepository, DatabaseContext databaseContext)
        {
            _customerRepository = customerRepository;
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
                //_DatabaseContext.Add(customer);
                _customerRepository.Create(customer);
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
        public ActionResult Delete(int Id)
        {
            var customer = _customerRepository.GetCustomerById(Id);
            _customerRepository.Delete(customer);
            _DatabaseContext.SaveChanges();
            _customerRepository.GetCustomers();
            return RedirectToAction("getcustomers", "customer");

        }
        public async Task<IActionResult> GetCustomerById(int id)
        {
            _customerRepository.GetCustomerById(id);
            return View();
            //var model = _customerRepository.GetCustomerById(id);
            //return View("Add", model);
        }
        public ActionResult Edit(int Id)
        {
            var model = _customerRepository.GetCustomerById(Id);
            if (model == null)
            {
                NotFound();
            }
            return View("Add", model);
        }
    }
}
