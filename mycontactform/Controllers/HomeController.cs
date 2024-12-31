using Microsoft.AspNetCore.Mvc;
using mycontactform.Models;
using System.Diagnostics;

namespace mycontactform.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            ViewBag.Message = "Hello Maham";
            return View();
        }

       
        [HttpPost]
        public IActionResult SubmitForm(string username, string password, string email, string phone)
        {
    
            ViewBag.Message = $"Form submitted! Username: {username}, Password: {password}, Email: {email}, Phone: {phone}";

            return View("Index"); 
        }
    }
}
