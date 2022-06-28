using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace poprawaAPBD.Controllers
{
    public class TeamController : Controller
    {

        

        //[HttpGet]
        //public async Task<IActionResult>  (int TeamID)
        //{

        //}


        public IActionResult Index()
        {
            return View();
        }
    }
}
