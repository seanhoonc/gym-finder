using System.ComponentModel.DataAnnotations;

namespace GymFinder.Models
{
    public class Gym
    {
        [Key]
        public int GymId { get; set; }
        [Required]
        public string? GymName { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public string? Website { get; set; }

        public MembershipPlan? MembershipPlan { get; set; }
        public Branch? Branch { get; set; }
    }
}
