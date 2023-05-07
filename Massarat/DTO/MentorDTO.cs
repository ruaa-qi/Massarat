using System.ComponentModel.DataAnnotations;

namespace Massarat.Models
{
	public class MentorDTO
	{

		[Required]
		public String Name { get; set; } = null!;

        public int? Age { get; set; }

		[Required]
		public String PhoneNumber { get; set; } = null!;
		public Boolean? Gender { get; set; }



	}
}
