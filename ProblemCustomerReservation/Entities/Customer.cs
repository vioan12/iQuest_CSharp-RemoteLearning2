using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemCustomerReservation
{
    public partial class Customer : IEntity
    {
        public bool IsEqualId(int id)
        {
            if (Id == id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsEqualName(string name)
        {
            if (Name == name)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AddReservation(Reservation reservation)
        {
            Reservation.Add(reservation);
            return true;
        }
        public bool RemoveAllReservations()
        {
            Reservation = new HashSet<Reservation>();
            return true;
        }
    }
}
