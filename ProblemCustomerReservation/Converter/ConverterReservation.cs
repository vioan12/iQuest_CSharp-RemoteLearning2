using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemCustomerReservation
{
    public class ConverterReservation : Converter<Reservation>
    {
        public override Reservation ConvertOneLine(string line)
        {
            int customerId, reservationId;
            string hotelCity, hotelName;
            DateTime hotelCheckInDate, hotelCheckOutDate;
            splitLine = line.Split(';');
            reservationId = int.Parse(splitLine[0]);
            customerId = int.Parse(splitLine[1]);
            hotelName = splitLine[2];
            hotelCity = splitLine[3];
            hotelCheckInDate = DateTime.ParseExact(splitLine[4], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            Hotel hotel = new Hotel(Constants.DefaultHotelId, hotelName, hotelCity);
            HotelManager hotelManager = new HotelManager(hotel);
            entity = hotelManager.CreateReservation(reservationId, customerId, hotelCheckInDate);
            if (splitLine.Length == 6)
            {
                hotelCheckOutDate = DateTime.ParseExact(splitLine[5], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                hotelManager.EndingReservation(entity, hotelCheckOutDate);
            }
            return entity;
        }
    }
}
