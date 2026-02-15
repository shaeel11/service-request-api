using Microsoft.AspNetCore.Mvc;
using ServiceRequestPortal.Models;
using Microsoft.AspNetCore.Authorization;
using ServiceRequestPortal.DTOs;

[ApiController]
[Route("api/[controller]")]
public class ServiceRequestsController : ControllerBase
{
    private readonly IServiceRequestRepository _repository;

    public ServiceRequestsController(IServiceRequestRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll(int pageNumber = 1, int pageSize = 10)
    {
        var requests = await _repository.GetAllAsync(pageNumber, pageSize);

        var result = requests.Select(r => new ServiceRequestResponseDto
        {
            Id = r.Id,
            Title = r.Title,
            Description = r.Description,
            Status = r.Status,
            CreatedAt = r.CreatedAt,
            UserId = r.UserId
        });

        return Ok(result);
    }


    [HttpPost]
    [AllowAnonymous]
    [HttpPost]
    public async Task<IActionResult> Create(CreateServiceRequestDto dto)
    {
        var request = new ServiceRequest
        {
            Title = dto.Title,
            Description = dto.Description,
            Status = "Open",
            CreatedAt = DateTime.UtcNow,
            UserId = 1 // temporary (we’ll fix this with JWT later)
        };

        await _repository.CreateAsync(request);

        return Ok(request);
    }
}
