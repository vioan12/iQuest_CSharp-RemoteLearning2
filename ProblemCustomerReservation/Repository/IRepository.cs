using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProblemCustomerReservation
{
    public interface IRepository<TEntity>
    {
        bool Add(TEntity newEntity);
        bool Remove(int id);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> FindBy(Func<TEntity, bool> function);
    }
}
