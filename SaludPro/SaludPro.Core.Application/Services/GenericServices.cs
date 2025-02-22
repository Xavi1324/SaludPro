using Microsoft.EntityFrameworkCore;
using SaludPro.Core.Application.Interfaces.Repositories;
using SaludPro.Core.Application.Interfaces.Services;

namespace SaludPro.Core.Application.Services
{
    public class GenericServices<Entity> : IGenericServices<Entity> where Entity : class
    {
        private readonly IGenericRepositoryAsync<Entity> _dbContext;
        
        public GenericServices(IGenericRepositoryAsync<Entity> dbContext)
        {
            _dbContext = dbContext;
            
        }
        public async Task<Entity> CreateAsync(Entity entity)
        {
            await _dbContext.AddAsync(entity);
            return entity; 
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _dbContext.GetByIdAsync(id);
            if (entity != null) // Si la entidad existe, se elimina
            {
                await _dbContext.DeleteAsync(entity);
            }
            else
            {
                throw new Exception("No se encontró la entidad");
            }
        }
        public async Task<List<Entity>> GetAllAsync()
        {
            return await _dbContext.GetAllAsync();
        }

        public async Task<Entity?> GetByIdAsync(int id)
        {
            return await _dbContext.GetByIdAsync(id); 
        }

        public async Task<Entity> UpdateAsync(Entity entity)
        {
            await _dbContext.EditAsync(entity); 
            return entity; 
        }
    }
}
