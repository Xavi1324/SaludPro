namespace SaludPro.Core.Application.Interfaces.Services
{
    public interface IGenericServices<Entity> 
    {
        Task<Entity> CreateAsync(Entity entity);
        Task DeleteAsync(int id);
        Task<List<Entity>> GetAllAsync();
        Task<Entity?> GetByIdAsync(int id);
        Task<Entity> UpdateAsync(Entity entity);
    }

}
