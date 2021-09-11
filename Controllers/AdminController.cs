using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Miraii.Models;

namespace Miraii.Controllers
{
    public class AdminController : Controller
    {
        [Route("admin")]
        public IActionResult Index()
        {
            //admin landing
            return View();
        }
    }
}
