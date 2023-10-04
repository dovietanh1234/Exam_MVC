using exam_sem3_mvc.Entities;
using exam_sem3_mvc.Models.Staff;
using exam_sem3_mvc.Models.StaffModel;
using Microsoft.AspNetCore.Mvc;

namespace exam_sem3_mvc.Controllers
{
	public class StaffController1 : Controller
	{
		private readonly MyDbContext _context;

		public StaffController1(MyDbContext context)
		{
			 _context = context;
		}


		public IActionResult Index()
		{
			var staff = _context.Staff.ToList();
			return View(staff);
		}

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
        public IActionResult Create(StaffModel model)
		{
			if (ModelState.IsValid)
			{
				_context.Staff.Add(new Staff
				{
					name = model.name,
					position = model.position,
					department_id = model.department_id,

				});
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
			return View(model);
		}

		public async Task<IActionResult> Edit(int id)
		{

			Staff staff = await _context.Staff.FindAsync(id);

			if (staff == null)
			{
				return NotFound();	
			}
			return View(new EditStaff
			{
				name = staff.name,
            });
		}


		[HttpPost]
		public IActionResult Edit(EditStaff model)
		{
			if (ModelState.IsValid)
			{
				_context.Staff.Update(new Staff { Id = model.Id, name = model.name, position = model.position, department_id = model.department_id });
				_context.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(model);
		}

		public IActionResult Delete(int id)
		{ 
		
			Staff staff = _context.Staff.Find(id);

			if (staff == null)
			{
				return NotFound();
			}

			_context.Staff.Remove(staff);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}



        }
    }
