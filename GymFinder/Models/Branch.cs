using System.ComponentModel.DataAnnotations;

namespace GymFinder.Models
{
	public class Branch
	{
		[Key]
		public int BranchId { get; set; }
		[Required]
		public string? BranchName { get; set; }
		[Required]
		public string? Address { get; set; }
		[Required]
		public string? Phone { get; set; }
		[Required]
		public string? Email { get; set; }
		[Required]
		public string? OpenTime { get; set; }
		[Required]
		public string? CloseTime { get; set; }
	}
}
