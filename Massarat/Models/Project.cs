using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Massarat.Models
{
	public class Project : General
	{
        [Key]
        public int Id { get; set; }
        [Required]
        public String Name { get; set; } = null!;

		public String Description { get; set; } = null!;

		[Required]
		public virtual int MentorId { get; set; }
		[ForeignKey("Id")]
		public virtual Mentor? Mentor { get; set; }

		public String Industry { get; set; } = null!;
		[Required]
		public int TeamNumber { get; set; }
	}
}
