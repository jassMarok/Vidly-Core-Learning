using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private readonly List<Customer> customers = new List<Customer>
        {
            new Customer {Id = 1, Name = "Jaspal"},
            new Customer {Id = 2, Name = "Harpreet"}
        };

        public ActionResult Index()
        {
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = customers.FirstOrDefault(x => x.Id == id);

            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }
    }
}
