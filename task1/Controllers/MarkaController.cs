using Microsoft.AspNetCore.Mvc;
using task1.Models;

namespace task1.Controllers
{
    public class MarkaController : Controller
    {
        private readonly List<Marka> _marka;

        public MarkaController()
        {
            _marka = new List<Marka>
            {
                new Marka{ Id = 1, Name = "Mercedes"},
                new Marka{ Id = 2, Name = "Lexus"},
                new Marka{ Id = 3, Name = "BMW"},
                new Marka{ Id = 4, Name = "lada"},
            };
        }

        public IActionResult Index()
        {
            return View(_marka);
        }
    }
}
