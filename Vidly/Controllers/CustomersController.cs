using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Customers
        public ActionResult Index()
        {
            var cust = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(cust);
        }
        public ActionResult Edit(int id)
        {
            NewCustomerViewModel viewModel = null;
            Customer customer = null;
            if (id != 0)
                customer = _context.Customers.Include(c => c.MembershipType).ToList().FirstOrDefault(x => x.ID == id);
            else
                customer = new Customer();

            viewModel = new NewCustomerViewModel()
            {
                Customer = customer,
                MembershipType = _context.MembershipTypes.ToList()
            };
            return View("CustomerForm", viewModel);
        }

        public ActionResult New()
        {
            var membershipType = _context.MembershipTypes.ToList();
            var viewModel = new NewCustomerViewModel()
            {
                MembershipType = membershipType,
                Customer = new Customer()
            };
            return View("CustomerForm",viewModel);
        }

        [HttpPost]
        public ActionResult Save(Customer Customer)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new NewCustomerViewModel
                {
                    Customer =  Customer,
                    MembershipType = _context.MembershipTypes.ToList()
                };
                return View("CustomerForm", viewModel);
            }

            if (Customer.ID == 0)
                _context.Customers.Add(Customer);
            else
            {
                var inDb = _context.Customers.Single(c => c.ID == Customer.ID);
                inDb.Name = Customer.Name;
                inDb.DateOfBirth = Customer.DateOfBirth;
                inDb.IsSubscribedToNewsletter = Customer.IsSubscribedToNewsletter;
                inDb.MembershipTypeID = Customer.MembershipTypeID;
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Customers");
        }

        public Customer GetCustomerById(int id)
        {
            return _context.Customers.Include(c=>c.MembershipType).FirstOrDefault(x => x.ID == id);
        }
    }
}