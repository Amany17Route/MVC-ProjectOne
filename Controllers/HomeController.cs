using Microsoft.AspNetCore.Mvc;

namespace MVC_Project01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ContentResult result = new ContentResult();
            //result.Content = "Hello From Content Result";            
            //return Content("Hello From Content Result") ;

            return Redirect("/Home/AboutUs");
        }

        
        public string AboutUs()
        {
            return "About Us Action";
        }
    }
}
