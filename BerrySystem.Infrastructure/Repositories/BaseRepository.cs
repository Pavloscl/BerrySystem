using BerrySystem.Core.Interfaces;
using BerrySystem.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BerrySystem.Infrastructure.Repositories
{
    public class BaseRepository <T> : IRepository <T> where T : class  // where T : BaseEntity
    {

        private readonly BerrySystemContext _context;
        protected readonly DbSet<T> _entities;

        public BaseRepository(BerrySystemContext context)
        {
            _context = context;
            _entities = context.Set<T>();

        }
        //public IEnumerable<T> GetAll()
        public async Task<IEnumerable<T>> GetAll()
        {
            return await _entities.ToListAsync();
           // return _entities.AsEnumerable();   //Evitamos que la consulta se ejecute automaticamente y para aplicar filtros
        }

        public async Task<T> GetById(int id)
        {
            return await _entities.FindAsync(id);
        }
        public async Task Add(T entity)
        {
            await _entities.AddAsync(entity);
            // UnitOfWork se encanrga de manejar las transaciones a nivel de aplicacion 
            await _context.SaveChangesAsync();
        }
        public  async Task Update(T entity)
        {

            _entities.Update(entity);
           await _context.SaveChangesAsync();

        }

        public async Task Delete(int id)
        {
            T entity = await GetById(id);
            _entities.Remove(entity);
            await _context.SaveChangesAsync();


        }

    }
}
