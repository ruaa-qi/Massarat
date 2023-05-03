using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Massarat.Models
{
	public class Project : General
	{
        [Key]
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
		
		public String Description { get; set; }

        [Required]
		public virtual int MentorId { get; set; }
		[ForeignKey("Id")]
		public virtual Mentor? Mentor { get; set; }

		public String Industry { get; set; }
		[Required]
		public int TeamNumber { get; set; }
	}
}
