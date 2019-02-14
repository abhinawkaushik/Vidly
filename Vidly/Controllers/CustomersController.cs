using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;

namespace Vidly.Controllers
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
        // GET: Customers
        public ActionResult Index()
        {
            var cust = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(cust);
        }
        public ActionResult Details(int id)
        {
            var cust = GetCustomerById(id);
            if (cust == null)
                return HttpNotFound();
            return View(cust);
        }
        //public IEnumerable<Customer> GetCustomers()
        //{
        //    return new List<Customer>()
        //    {
        //        new Customer() {ID=1, Name="Abhinaw" },
        //        new Customer() {ID=2, Name="Manoj" },
        //    };
        //}

        public Customer GetCustomerById(int id)
        {
            return _context.Customers.FirstOrDefault(x => x.ID == id);
        }
    }
}