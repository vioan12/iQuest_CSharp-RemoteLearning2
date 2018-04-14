using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemCustomerReservation
{
    public class ReservationRepository : Repository<Reservation>
    {
        public ReservationRepository(IDataSource dataSource) : base(dataSource.ReservationsList())
        {
        }
    }
}
