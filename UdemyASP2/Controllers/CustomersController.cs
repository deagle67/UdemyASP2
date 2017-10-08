using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UdemyASP2.ViewModels;
using UdemyASP2.Models;

namespace UdemyASP2.Controllers
{
    public class CustomersController : Controller
    {
        public List<Customer> listCustomers = new List<Customer>
        {
            new Customer { Name = "John Smith", Id = 1 },
            new Customer { Name = "Mary Williams", Id = 2}
        };

        public ActionResult Index()
        {
            var customersViewModel = new CustomersViewModel
            {
                customers = listCustomers
            };

            return View(customersViewModel);
        }

        [Route("customers/details/{id}")]
        public ActionResult DetailsById(int id)
        {
            var customerById = listCustomers.Where(c => c.Id.Equals(id)).FirstOrDefault();
            return View(customerById);
        }
    }
}