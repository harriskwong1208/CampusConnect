/*
using Microsoft.AspNetCore.Mvc;
using MVCApi.Data;
using MVCApi.Models;

namespace MVCApi.Controllers
{
    public class StudentController : Controller
    {
  

        private readonly ApplicationDbContext _db;

        public StudentController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Student> objStudentList = _db.students;
            return View(objStudentList);
        }
        //GET
        public IActionResult Create()
        {

            return View();
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student obj)
        {
            
            if (ModelState.IsValid)
            {
                _db.students.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Student created successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var studentFromDb = _db.students.Find(id);
            if (studentFromDb == null)
            {
                return NotFound();
            }
            return View(studentFromDb);
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Student obj)
        {
            
            if (ModelState.IsValid)
            {
                _db.students.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Student updated successfully";

                return RedirectToAction("Index");
            }
            return View(obj);
        }
        //GET
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var studentFromDb = _db.students.Find(id);
            if (studentFromDb == null)
            {
                return NotFound();
            }
            return View(studentFromDb);
        }
        //POST
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _db.students.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.students.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Student deleted successfully";

            return RedirectToAction("Index");

            return View(obj);
        }
    }
}
}
*/
