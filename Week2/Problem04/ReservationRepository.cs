using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    public class ReservationRepository : IRepository<UsernameReservation>
    {
        private ICustomersCollection context { get; set; }
        public ReservationRepository(ICustomersCollection context)
        {
            this.context = context;
        }
        public void Add(UsernameReservation entity)
        {
            context.FindByUsername(entity.Username).AddReservation(entity.Reservation);
        }
        public List<UsernameReservation> GetAll()
        {
            List<UsernameReservation> allReservation = new List<UsernameReservation>();
            for (int index = 0; index < context.CountCustomers(); index++)
            {
                for (int index2 = 0; index2 < context.GetCustomer(index).ReservationsList.Count(); index2++)
                {
                    UsernameReservation newItem = new UsernameReservation();
                    newItem.Username = context.GetCustomer(index).Username;
                    newItem.Reservation = context.GetCustomer(index).ReservationsList.ElementAt(index2);
                    allReservation.Add(newItem);
                }
            }
            return allReservation;
        }
        public UsernameReservation GetById(string username)
        {
            throw new NotImplementedException();
        }

        public void Remove(string username)
        {
            context.FindByUsername(username).RemoveAllReservations();
        }
    }
}
