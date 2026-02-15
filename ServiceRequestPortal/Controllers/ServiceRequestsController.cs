using Microsoft.AspNetCore.Mvc;
using ServiceRequestPortal.Models;
using Microsoft.AspNetCore.Authorization;

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
        return Ok(requests);
    }

    [HttpPost]
    [Authorize]
    public async Task<IActionResult> Create(ServiceRequest request)
    {
        var result = await _repository.CreateAsync(request);
        return CreatedAtAction(nameof(GetAll), new { id = result.Id }, result);
    }
}
