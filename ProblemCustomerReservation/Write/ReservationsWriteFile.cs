using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemCustomerReservation
{
    class ReservationsWriteFile : WriteFile<Reservation>
    {
        public ReservationsWriteFile(string fileName) : base(fileName)
        {
        }
        public override string WriteOneLine()
        {
            return entity.Id.ToString() + ";" +
                entity.CustomerId.ToString() + ";" +
                entity.CheckInDate.ToString() + ";" +
                entity.CheckOutDate.Value.ToString();
        }
    }
}
