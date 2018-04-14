using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemCustomerReservation
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : IEntity
    {
        protected IEnumerable<TEntity> Data { get; set; }
        public Repository(IEnumerable<TEntity> dataSource)
        {
            Data = dataSource;
        }
        public bool Add(TEntity newEntity)
        {
            bool containNewEntity = Data.Any(entity => entity.Id == newEntity.Id);
            if (!containNewEntity)
            {
                Data = Data.Concat(new[] { newEntity });
                return true;
            }
            else
            {
                return false;
            }
        }
        public IEnumerable<TEntity> GetAll()
        {
            return Data;
        }
        public TEntity GetById(int id)
        {
            try
            {
                return Data.Single(entity => entity.Id == id);
            }
            catch(Exception exception)
            {
                throw exception;
            }
        }
        public bool Remove(int id)
        {
            bool containNewEntity = Data.Any(entity => entity.Id == id);
            if (containNewEntity)
            {
                Data = Data.Where(entity => entity.Id != id);
                return true;
            }
            else
            {
                return false;
            }
        }
        public IEnumerable<TEntity> FindBy(Func<TEntity, bool> function)
        {
            return Data.Where(function);
        }
    }
}
