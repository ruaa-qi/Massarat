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
			var MentorInfo = _context.Mentor.Where(m => m.Id == MentorId).FirstOrDefault();
			var MentorDTO = new MentorDTO
			{
				Name = MentorInfo.Name,
				Age = MentorInfo.Age,
				PhoneNumber = MentorInfo.PhoneNumber
			};
			return Ok(MentorDTO);
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

		[HttpPost]
		[Route("api/[Controller]/[Action]")]
		public IActionResult CreateMentor(MentorDTO mentorDTO)
		{
			if (mentorDTO == null)
				return NoContent();
		
			var Mentor = new Mentor
			{
				Name = mentorDTO.Name ?? "AlternativeName",
				Age = mentorDTO.Age ?? -1,
				PhoneNumber = mentorDTO.PhoneNumber == null ? "No phone" : mentorDTO.PhoneNumber,
				CreateDate = DateTime.Now,
				CreateBy = "Ruaa Mohammed",
				Status = true,
				Gender = mentorDTO.Gender ?? false,
			};
			_context.Mentor.Add(Mentor);
			_context.SaveChanges();
			return Ok();
		}
		[HttpGet]	
		[Route("api/[Controller]/[Action]")]

		public List<MentorDTO> GetMentorsByAge(int? age)
		{
			var MentorsByAge = _context.Mentor.Where(a=>a.Age == age).ToList();
			List<MentorDTO> mentorListMentor =new List<MentorDTO>();
			foreach(var Mentor in MentorsByAge)
			{
				var Object = new MentorDTO()
				{
                  Name = Mentor.Name,
                  Age = Mentor.Age,
				};
				mentorListMentor.Add(Object);
			}
			
			return mentorListMentor;
		} 
	}
}
