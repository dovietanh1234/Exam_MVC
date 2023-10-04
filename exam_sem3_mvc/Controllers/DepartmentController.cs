using exam_sem3_mvc.Entities;
using exam_sem3_mvc.Models.Department;
using Microsoft.AspNetCore.Mvc;

namespace exam_sem3_mvc.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly MyDbContext _context;

        public DepartmentController(MyDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var Department = _context.department.ToList();
            return View(Department);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DepartmentModel model)
        {
            if (ModelState.IsValid)
            {
                _context.department.Add(new Department
                {
                    name_department = model.name_department
                });
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public async Task<IActionResult> Edit (int id)
        {
            Department department = await _context.department.FindAsync(id);

            if ( department == null )
            {
                return NotFound();
            }
            return View(new EditDepartmentModel
            {
                Id = id,
                name_department = department.name_department
            });
        }

        [HttpPost]
        public IActionResult Edit(EditDepartmentModel model)
        {
            if (ModelState.IsValid)
            {
                _context.department.Update(new Department
                {
                    id = model.Id,
                    name_department = model.name_department
                });
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            Department department = _context.department.Find(id);

            if( department == null)
            {
                return NotFound();
            }
            _context.department.Remove(department);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
