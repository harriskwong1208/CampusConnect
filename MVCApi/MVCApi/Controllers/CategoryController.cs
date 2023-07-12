using Microsoft.AspNetCore.Mvc;
using MVCApi.Data;
using MVCApi.Models;

namespace MVCApi.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> objCategoryList = _db.categories;
            return View(objCategoryList);
        }
    }
}
