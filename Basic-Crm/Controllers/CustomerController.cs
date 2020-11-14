using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Basic_Crm.Data;
using BL;
using DAL;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace Basic_Crm.Controllers
{
    public class CustomerController : Controller
    {
        AuthDbContext _authDbContext;
        ICustomerRepository _customerRepository;
        public CustomerController(ICustomerRepository customerRepository,AuthDbContext authDbContext)
        {
            _customerRepository = customerRepository;
            _authDbContext = authDbContext;
        }
        
        //[HttpPost]
        public async Task<ActionResult> Add(Customer customer)
        {
            
            //if (!ModelState.IsValid)
            //{
            //    return View("add");
            //}
            customer.UserSession = User.Identity.Name;
            _customerRepository.Add(customer);
            //if (customer.Id == 0)
            //{
            //    _customerRepository.Add(customer);
            //}
            return View(customer);
            //return RedirectToAction("getcustomers", customer);

            //var redirect = RedirectToAction();
            //redirect.ActionName = "GetCustomers";
            //redirect.ControllerName = "Customer";
            //return redirect;

        }
        [HttpGet]
        public async Task<ActionResult> GetCustomers()
        {
            IEnumerable<Customer> customerr = _customerRepository.GetCustomers();
            var cust = customerr.Where(x => x.UserSession == User.Identity.Name).ToList();
            return View(cust);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var customer = _customerRepository.GetCustomerById(id);
            _customerRepository.Delete(customer);
            return RedirectToAction("getcustomers");
        }
        public async Task<IActionResult> GetCustomerById(int id)
        {
            _customerRepository.GetCustomerById(id);
            return RedirectToAction("getcustomers");

            //return View();
        }
    }
}
