using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    public class Customer
    {
        public string Name { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string Address { get; private set; }
        public List<Reservation> ReservationsList { get; private set; }
        public Customer(string name, string username, string password, string address)
        {
            Name = name;
            Username = username;
            Password = password;
            Address = address;
            ReservationsList = new List<Reservation>();
        }
        public bool IsEqualUsername(string username)
        {
            if (Username == username)
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
    }
}
