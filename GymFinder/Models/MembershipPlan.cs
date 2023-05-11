using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace GymFinder.Models
{
	public class MembershipPlan
	{
        [Key]
        public int MembershipId { get; set; }
        [Required]
        public string? PlanName { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        [Precision(6, 2)]
        public decimal Price { get; set; }
        public string? Benefit { get; set; }
	}
}
