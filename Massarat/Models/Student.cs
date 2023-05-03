using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Massarat.Models
{
	public class Student : General
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public String Name { get; set; }

		public bool Gender { get; set; }
		public int Age { get; set; }
		public String PhoneNumber { get; set; }
		public virtual int MentorId { get; set; }
		[ForeignKey("Id")]
		public virtual Mentor? Mentor { get; set; }
		public virtual int ProjectId { get; set; }
		[ForeignKey("Id")]
		public virtual Project? Project { get; set; }

		[Required]
		public virtual int UniversityId { get; set; }
		[ForeignKey("Id")]
		public virtual University? University { get; set; }

		public String Salary { get; set; }
	}
	
}
