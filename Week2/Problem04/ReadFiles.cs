using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    public class ReadFiles
    {
        private ICustomersCollection iCustomersCollection;
        private string fileNameCustomersDetails, fileNameReservationsDetails;
        public ReadFiles(string fileNameCustomersDetails, string fileNameReservationsDetails, ICustomersCollection iCustomersCollection)
        {
            this.fileNameCustomersDetails = fileNameCustomersDetails;
            this.fileNameReservationsDetails = fileNameReservationsDetails;
            this.iCustomersCollection = iCustomersCollection;
        }
        public bool Read()
        {
            string line, name, username, password, address, hotelCity, hotelName, hotelCheckInDate, hotelCheckOutDate;
            try
            {
                using (System.IO.StreamReader inputFile = new System.IO.StreamReader(fileNameCustomersDetails))
                {
                    while ((line = inputFile.ReadLine()) != null)
                    {
                        name = username = password = address = "";
                        int i = 0;
                        while (!line.ElementAt(i).Equals(';'))
                        {
                            name = name + line.ElementAt(i);
                            i++;
                        }
                        i++;
                        while (!line.ElementAt(i).Equals(';'))
                        {
                            username = username + line.ElementAt(i);
                            i++;
                        }
                        i++;
                        while (!line.ElementAt(i).Equals(';'))
                        {
                            password = password + line.ElementAt(i);
                            i++;
                        }
                        i++;
                        while (i < line.Count())
                        {
                            address = address + line.ElementAt(i);
                            i++;
                        }
                        Customer customer = new Customer(name, username, EncryptionDecryption.DecryptPassword(password), address);
                        iCustomersCollection.AddCustomer(customer);
                    }
                }
                using (System.IO.StreamReader inputFile = new System.IO.StreamReader(fileNameReservationsDetails))
                {
                    while ((line = inputFile.ReadLine()) != null)
                    {
                        username = hotelCity = hotelName = hotelCheckInDate = hotelCheckOutDate = "";
                        int i = 0;
                        while (!line.ElementAt(i).Equals(';'))
                        {
                            username = username + line.ElementAt(i);
                            i++;
                        }
                        i++;
                        while (!line.ElementAt(i).Equals(';'))
                        {
                            hotelName = hotelName + line.ElementAt(i);
                            i++;
                        }
                        i++;
                        while (!line.ElementAt(i).Equals(';'))
                        {
                            hotelCity = hotelCity + line.ElementAt(i);
                            i++;
                        }
                        i++;
                        while (!line.ElementAt(i).Equals(';'))
                        {
                            hotelCheckInDate = hotelCheckInDate + line.ElementAt(i);
                            i++;
                        }
                        i++;
                        while (i < line.Count())
                        {
                            hotelCheckOutDate = hotelCheckOutDate + line.ElementAt(i);
                            i++;
                        }
                        Hotel hotel = new Hotel(hotelName, hotelCity);
                        HotelManager hotelManager = new HotelManager(hotel);
                        Reservation reservation = hotelManager.CreateReservation(hotelCheckInDate);
                        iCustomersCollection.FindByUsername(username).AddReservation(reservation);
                        if (hotelCheckOutDate != "")
                        {
                            hotelManager.EndingReservation(reservation, hotelCheckOutDate);
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return true;
        }
    }
}
