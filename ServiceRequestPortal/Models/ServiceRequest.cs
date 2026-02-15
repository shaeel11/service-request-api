using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceRequestPortal.Models
{
    public class ServiceRequest
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public string Status { get; set; } = "Open";

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;



        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<StatusHistory> StatusHistories { get; set; }
    }
}
