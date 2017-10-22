using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UdemyASP2.ViewModels;
using UdemyASP2.Models;
using System.Data.Entity;
using System.Runtime.Caching;

namespace UdemyASP2.Controllers
{
    [Authorize]
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

            if (MemoryCache.Default["Genres"] == null)
                MemoryCache.Default["Genres"] = _context.Genres.ToList();

            var genres = MemoryCache.Default["Genres"] as IEnumerable<Genre>;

            if (User.IsInRole(RoleName.CanManageMovies))
                return View("List");

            return View("ReadOnlyList");
        }

        //[Route("customers/details/{id}")]
        public ActionResult Details(int id)
        {
            var customerById = _context.Customers.Include(c => c.MemberShipType).SingleOrDefault(c => c.Id == id);

            if (customerById == null)
                return HttpNotFound();

            return View(customerById);
        }

        public ActionResult New()
        {
            var memberShipTypes = _context.MemberShipTypes.ToList();
            var viewModel = new CustomerFormViewModel
            {
                Customer = new Customer(),
                MemberShipTypes = memberShipTypes
            };

            return View("CustomerForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customer customer)
        {
            if(!ModelState.IsValid)
            {
                var viewModel = new CustomerFormViewModel
                {
                    Customer = customer,
                    MemberShipTypes = _context.MemberShipTypes.ToList()
                };
                return View("CustomerForm", viewModel);
            }
            if(customer.Id == 0)
            {
                _context.Customers.Add(customer);
            }
            else
            {
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);
                customerInDb.Name = customer.Name;
                customerInDb.BirthDate = customer.BirthDate;
                customerInDb.MemberShipTypeId = customer.MemberShipTypeId;
                customerInDb.IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;
            }

            _context.SaveChanges();
            return RedirectToAction("Index", "Customers");
        }

        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if(customer == null)
            {
                return HttpNotFound();
            }

            var viewModel = new CustomerFormViewModel
            {
                Customer = customer,
                MemberShipTypes = _context.MemberShipTypes.ToList()
            };

            return View("CustomerForm", viewModel);
        }
    }
}