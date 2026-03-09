using System;

namespace HotelBookingManager
{
    public sealed class Booking
    {
        public string RoomNumber { get; }
        public string GuestName { get; }
        public DateTime CheckIn { get; private set; }
        public DateTime CheckOut { get; private set; }

        public Booking(string roomNumber, string guestName, DateTime checkIn, DateTime checkOut)
        {
            if (string.IsNullOrWhiteSpace(roomNumber))
                throw new ArgumentException("Room number is required.");
            if (string.IsNullOrWhiteSpace(guestName))
                throw new ArgumentException("Guest name is required.");
            if (checkOut <= checkIn)
                throw new ArgumentException("Check-out must be after check-in.");

            RoomNumber = roomNumber;
            GuestName = guestName;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public void Reschedule(DateTime newIn, DateTime newOut)
        {
            if (newOut <= newIn)
                throw new ArgumentException("Check-out must be after check-in.");

            CheckIn = newIn;
            CheckOut = newOut;
        }

        public override string ToString()
        {
            return $"[{RoomNumber}] {CheckIn:MM/dd HH:mm}–{CheckOut:MM/dd HH:mm} {GuestName}";
        }
    }
}