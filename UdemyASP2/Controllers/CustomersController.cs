using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UdemyASP2.ViewModels;
using UdemyASP2.Models;
using System.Data.Entity;

namespace UdemyASP2.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            /*var customersViewModel = new CustomersViewModel
            {
                customers = listCustomers
            };
            */

            var customers = _context.Customers.Include(c => c.MemberShipType).ToList();

            return View(customers);
        }

        //[Route("customers/details/{id}")]
        public ActionResult Details(int id)
        {
            var customerById = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerById == null)
                return HttpNotFound();

            return View(customerById);
        }
    }
}