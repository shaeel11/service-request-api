using ServiceRequestPortal.Models;
public interface IServiceRequestRepository
{
    Task<IEnumerable<ServiceRequest>> GetAllAsync(int pageNumber, int pageSize);
    Task<ServiceRequest> GetByIdAsync(int id);
    Task<ServiceRequest> CreateAsync(ServiceRequest request);
    Task UpdateAsync(ServiceRequest request);
    Task DeleteAsync(int id);
}
