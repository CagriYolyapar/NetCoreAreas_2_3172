using Microsoft.AspNetCore.Mvc;

namespace NetCoreAreas_2.Areas.Administrator.Controllers
{
    //Area'lar Attribute olarak tanımlanmadan calıstırılamaz...

    [Area("Administrator")]

    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
