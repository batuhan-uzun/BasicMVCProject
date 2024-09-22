using BasicMVCProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicMVCProject.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            var customer = new Customer // Customer has been created
            {
                Id = 1,
                FirstName = "Ahmet",
                LastName = "Deniz",
                Email = "ahmetdeniz@gmail.com"
            };

            var firstOrder = new Orders
            {
                Id = 123,
                ProductName = "Telephone",
                Price = 500,
                Quantity = 2
            };

            var secondOrder = new Orders
            {
                Id = 125,
                ProductName = "Computer",
                Price = 1300,
                Quantity = 1
            };

            var orderList = new List<Orders> { firstOrder, secondOrder }; // Orders were saved with List method because there is more than one

            var viewModel = new CustomerOrderViewModel
            {
                customer = customer,
                orders = orderList
            };

            return View(viewModel); 
        }
    }
}
