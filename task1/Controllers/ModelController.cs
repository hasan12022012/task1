using Microsoft.AspNetCore.Mvc;
using task1.Models;

namespace task1.Controllers
{
    public class ModelController : Controller
    {
        private readonly List<Model> _models;

        public ModelController()
        {
            _models = new List<Model>
            {
                new Model { Id = 1, Name = "e300", MarkaId= 1 },
                new Model { Id = 2, Name = "LX570", MarkaId= 2 },
                new Model { Id = 4, Name = "525", MarkaId= 3 },
                new Model { Id = 6, Name = "Niva", MarkaId= 4 },
            };
        }
        public IActionResult Index(int? id)
        {
            if (id != null)
            {
                if (_models.Exists(m => m.Id == id)) NotFound();

                return View(_models.FindAll(m => m.MarkaId == id));
            }
            return View(_models);
        }
    }
}
