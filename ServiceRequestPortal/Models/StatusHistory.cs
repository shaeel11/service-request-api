using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceRequestPortal.Models
{
    public class StatusHistory
    {
        public int Id { get; set; }

        public string OldStatus { get; set; }
        public string NewStatus { get; set; }

        public DateTime ChangedAt { get; set; } = DateTime.UtcNow;

        [ForeignKey("ServiceRequestId")]
        public int ServiceRequestId { get; set; }
        public ServiceRequest ServiceRequest { get; set; }
    }
}
