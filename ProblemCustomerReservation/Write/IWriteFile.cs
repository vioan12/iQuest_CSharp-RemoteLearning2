using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemCustomerReservation
{
    public interface IWriteFile<TEntity> where TEntity : class
    {
        void Write(IEnumerable<TEntity> listWriteToFile);
    }
}
