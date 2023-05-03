using System.ComponentModel.DataAnnotations;

namespace Massarat.Models
{
	public class Mentor : General
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public String Name { get; set; }

        public Boolean? Gender { get; set; }
        public int? Age { get; set; }

		[Required]
		public String PhoneNumber { get; set; }



    }
}
