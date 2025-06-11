using Infrastructure.EventOps.Entities;
using Infrastructure.EventOps.Interfaces;
namespace Infrastructure.EventOps.Repositories
{
    public class Repository<T>: IRepository<T> where T : BaseEntity
    {
        
        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }
        public T? GetById(int id)
        {
            throw new NotImplementedException();
        }
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }
        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
