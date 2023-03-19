using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Interfaces;
using WebApplication1.Models.ViewModels;

namespace WebApplication1.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomer _customer;

        public CustomerController(ICustomer customer)
        {
            _customer = customer;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
                      
            return View(_customer.AllCustomers());

           
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
           
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(VmCustomer customer)
        {
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(int id, VmCustomer customer)
        {
            return View();
        }

    }
}
