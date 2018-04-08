using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Remove(string username);
        TEntity GetById(string username);
        List<TEntity> GetAll();
    }
}
