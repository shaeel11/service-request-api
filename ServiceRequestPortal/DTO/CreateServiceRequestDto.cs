using System.ComponentModel.DataAnnotations;

namespace ServiceRequestPortal.DTOs
{
    public class CreateServiceRequestDto
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
