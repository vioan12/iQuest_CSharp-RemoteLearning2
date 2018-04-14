using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemCustomerReservation
{
    public class Customer : IEntity
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Password { get; private set; }
        public string Address { get; private set; }
        public List<Reservation> ReservationsList { get; private set; }
        public Customer(int id, string name, string password, string address)
        {
            Id = id;
            Name = name;
            Password = password;
            Address = address;
            ReservationsList = new List<Reservation>();
        }
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
            ReservationsList.Add(reservation);
            return true;
        }
        public bool RemoveAllReservations()
        {
            ReservationsList = new List<Reservation>();
            return true;
        }
    }
}
