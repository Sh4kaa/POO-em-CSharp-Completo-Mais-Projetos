using System;


namespace ReservaHotel.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {

        }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            Checkin = checkin;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(Checkin); // subtract mostra a diferença entre de tempo entre checkin e checkout
            return (int)duration.TotalDays; // total day mostra o resultado da duration em dias coinvertendo em inteiro com o casting
        }

        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            Checkin = checkin;
            CheckOut = checkout;
        }

        public override string ToString()
        {
            return "Room "
                + RoomNumber
                + ", check-in: "
                + Checkin.ToString("dd/MM/yyyy")
                + ", check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                +" nights";

        }
    }
}
