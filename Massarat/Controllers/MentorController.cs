using Massarat.Data;
using Massarat.Models;
using Microsoft.AspNetCore.Mvc;

namespace Massarat.Controllers
{

	public class MentorController : Controller
	{
		private readonly ApplicationDbContext _context;

		public MentorController(ApplicationDbContext context)
        {
			_context = context;
		}

		[HttpGet]
		[Route("api/[Controller]/[Action]")]

		public ICollection<Mentor> GetAllMentors()
		{
			return _context.Mentor.ToList();
		}
			[HttpGet]
		[Route("api/[Controller]/[Action]")]

		public ICollection<Project> GetAllProjects()
		{
			return _context.Project.Where(p=>p.Status == true).ToList();
		}


		[HttpGet]
		[Route("api/[Controller]/[Action]")]
		public IActionResult GetMentorByID(int? MentorId)
		{
			if (MentorId == null)
				return NoContent();
			return Ok(_context.Mentor.Where(m => m.Id == MentorId).FirstOrDefault());
		}
		[HttpGet]
		[Route("api/[Controller]/[Action]")]
		public IActionResult GetStudentByName(String? Name)
		{
			if (Name == null)
				return NotFound();
			var StudentName = _context.Student.Where(N => N.Name == Name).FirstOrDefault();
			if(StudentName!= null)
			return Ok(StudentName);
			return BadRequest(); 


	
		}
	}
}
