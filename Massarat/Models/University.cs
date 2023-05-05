using System.ComponentModel.DataAnnotations;

namespace Massarat.Models
{
	public class University: General
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; } = null!;
		public string? Location { get; set; }
		
	}
}
