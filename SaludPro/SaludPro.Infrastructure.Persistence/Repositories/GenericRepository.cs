using Microsoft.EntityFrameworkCore;
using SaludPro.Core.Application.Interfaces.Repositories;
using SaludPro.Infrastructure.Persistence.Contexts;

namespace SaludPro.Infrastructure.Persistence.Repositories
{
    public class GenericRepository<Entity> : IGenericRepositoryAsync<Entity> where Entity : class 
    {
        private readonly SaludProContext _dbContext;
        public GenericRepository(SaludProContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(Entity entity)
        {
            await _dbContext.Set<Entity>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }
        public async Task EditAsync(Entity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
        public async Task DeleteAsync(Entity entity)
        {
            _dbContext.Set<Entity>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
        public async Task<List<Entity>> GetAllAsync()
        {
            return await _dbContext.Set<Entity>().ToListAsync();
        }
        public async Task<Entity> GetByIdAsync(int id)
        {
            return await _dbContext.Set<Entity>().FindAsync(id);
        }

    }
}
