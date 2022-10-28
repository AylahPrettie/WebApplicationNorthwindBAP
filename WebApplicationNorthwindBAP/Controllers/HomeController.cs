//aylah prettie

using Microsoft.AspNetCore.Mvc;
using WebApplicationNorthwindBAP.Models;

namespace WebApplicationNorthwindBAP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            FileGateway aGateway = new FileGateway();

            List<Category> alistOfCategories = aGateway.GetCategory("C:\\Users\\ERC\\source\\repos\\WebApplicationNorthwindBAP\\WebApplicationNorthwindBAP\\Categories.csv");
            ViewBag.ListOfCategories = alistOfCategories;

            List<Employee> alistOfEmployees = aGateway.GetEmployee("C:\\Users\\ERC\\source\\repos\\WebApplicationNorthwindBAP\\WebApplicationNorthwindBAP\\Employees.csv");
            ViewBag.ListOfEmployees = alistOfEmployees;

            List<Supplier> alistOfSuppliers = aGateway.GetSupplier("C:\\Users\\ERC\\source\\repos\\WebApplicationNorthwindBAP\\WebApplicationNorthwindBAP\\Suppliers.csv");
            ViewBag.ListOfSuppliers = alistOfSuppliers;

            List<OrderDetail> alistOfOrderDetails = aGateway.GetOrderDetail("C:\\Users\\ERC\\source\\repos\\WebApplicationNorthwindBAP\\WebApplicationNorthwindBAP\\OrderDetails.csv");
            ViewBag.ListOfOrderDetails = alistOfOrderDetails;

            List<Shiper> alistOfShipers = aGateway.GetShiper("C:\\Users\\ERC\\source\\repos\\WebApplicationNorthwindBAP\\WebApplicationNorthwindBAP\\Shippers.csv");
            ViewBag.ListOfShipers = alistOfShipers;

            List<Product> alistOfProducts = aGateway.GetProduct("C:\\Users\\ERC\\source\\repos\\WebApplicationNorthwindBAP\\WebApplicationNorthwindBAP\\Products.csv");
            ViewBag.ListOfProducts = alistOfProducts;
            return View();
        }
    }
}
