using Microsoft.AspNetCore.Mvc;

namespace FastFood.Core.Controllers
{
    public class TestsController : Controller
    {
        
        public IActionResult Test()
        {
            return this.View();
        }
    }
}
