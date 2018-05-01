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
            DateTime hotelCheckInDate, hotelCheckOutDate;
            splitLine = line.Split(';');
            reservationId = int.Parse(splitLine[0]);
            customerId = int.Parse(splitLine[1]);
            hotelCheckInDate = DateTime.ParseExact(splitLine[2], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            HotelManager hotelManager = new HotelManager(Constants.Hotel);
            entity = hotelManager.CreateReservation(customerId, hotelCheckInDate);
            entity.Id = reservationId;
            if (splitLine.Length == 4)
            {
                hotelCheckOutDate = DateTime.ParseExact(splitLine[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                hotelManager.EndingReservation(entity, hotelCheckOutDate);
            }
            return entity;
        }
    }
}
