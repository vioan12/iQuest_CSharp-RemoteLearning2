using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemCustomerReservation
{
    public class Converter
    {
        public Converter()
        {
        }
        public List<Customer> ConvertCustomersFile(List<string> customersFileLines)
        {
            List<Customer> customersList = new List<Customer>();
            foreach (string line in customersFileLines)
            {
                customersList.Add(ConvertOneLineCustomersFile(line));
            }
            return customersList;
        }
        public List<UsernameReservation> ConvertReservationsFile(List<string> reservationsFileLines)
        {
            List<UsernameReservation> usernameReservationsList = new List<UsernameReservation>();
            foreach (string line in reservationsFileLines)
            {
                usernameReservationsList.Add(ConvertOneLineReservationsFile(line));
            }
            return usernameReservationsList;
        }
        private Customer ConvertOneLineCustomersFile(string line)
        {
            string name, username, password, address;
            string[] splitLine;
            name = username = password = address = "";
            splitLine = line.Split(';');
            name = splitLine[0];
            username = splitLine[1];
            password = splitLine[2];
            address = splitLine[3];
            Customer customer = new Customer(name, username, EncryptionDecryption.DecryptPassword(password), address);
            return customer;
        }
        private UsernameReservation ConvertOneLineReservationsFile(string line)
        {
            string username, hotelCity, hotelName;
            string[] splitLine, splitLineDate;
            DateTime hotelCheckInDate, hotelCheckOutDate;
            hotelCheckInDate = hotelCheckOutDate = default(DateTime);
            username = hotelCity = hotelName = "";
            splitLine = line.Split(';');
            username = splitLine[0];
            hotelName = splitLine[1];
            hotelCity = splitLine[2];
            splitLineDate = splitLine[3].Split('.');
            hotelCheckInDate = hotelCheckInDate.AddDays(double.Parse(splitLineDate[0]));
            hotelCheckInDate = hotelCheckInDate.AddMonths(int.Parse(splitLineDate[1]));
            hotelCheckInDate = hotelCheckInDate.AddYears(int.Parse(splitLineDate[2]));
            Hotel hotel = new Hotel(hotelName, hotelCity);
            HotelManager hotelManager = new HotelManager(hotel);
            Reservation reservation = hotelManager.CreateReservation(hotelCheckInDate);
            if (splitLine.Length == 5)
            {
                splitLineDate = splitLine[4].Split('.');
                hotelCheckOutDate = hotelCheckOutDate.AddDays(double.Parse(splitLineDate[0]));
                hotelCheckOutDate = hotelCheckOutDate.AddMonths(int.Parse(splitLineDate[1]));
                hotelCheckOutDate = hotelCheckOutDate.AddYears(int.Parse(splitLineDate[2]));
                hotelManager.EndingReservation(reservation, hotelCheckOutDate);
            }
            UsernameReservation usernameReservation = new UsernameReservation();
            usernameReservation.Reservation = reservation;
            usernameReservation.Username = username;
            return usernameReservation;
        }
    }
}
