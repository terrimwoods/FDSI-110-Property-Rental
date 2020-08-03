using Microsoft.AspNetCore.Mvc;
using PropertyRental.Models;

namespace PropertyRental.Controllers{

    public class CatalogController : Controller {

        public IActionResult Test(){
            return View();
        }
        public IActionResult Index(){
            return View();
        }
        public IActionResult Register(){
            return View();
        }
        // catalog/register property
        [HttpPost]

        public IActionResult RegisterProperty([FromBody] Property p){
            System.Console.WriteLine("user is saving something");

            // save p on database

            return Json(p);
        }
    }
}