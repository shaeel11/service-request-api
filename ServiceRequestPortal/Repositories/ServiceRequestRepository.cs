using Microsoft.EntityFrameworkCore;
using ServiceRequestPortal.Data;
using ServiceRequestPortal.Models;

public class ServiceRequestRepository : IServiceRequestRepository
{
    private readonly AppDbContext _context;

    public ServiceRequestRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<ServiceRequest>> GetAllAsync(int pageNumber, int pageSize)
    {
        return await _context.ServiceRequests
            .Include(s => s.User)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<ServiceRequest> GetByIdAsync(int id)
    {
        var request = await _context.ServiceRequests
            .Include(s => s.User)
            .FirstOrDefaultAsync(s => s.Id == id);

        if (request == null)
            throw new KeyNotFoundException($"ServiceRequest with Id {id} not found.");

        return request;
    }

    public async Task<ServiceRequest> CreateAsync(ServiceRequest request)
    {
        _context.ServiceRequests.Add(request);
        await _context.SaveChangesAsync();
        return request;
    }

    public async Task UpdateAsync(ServiceRequest request)
    {
        _context.ServiceRequests.Update(request);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var request = await _context.ServiceRequests.FindAsync(id);
        if (request != null)
        {
            _context.ServiceRequests.Remove(request);
            await _context.SaveChangesAsync();
        }
    }
}
