using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelBookingManager
{
    public sealed class BookingManager
    {
        private readonly List<Booking> _bookings = new();

        public IReadOnlyList<Booking> All() => _bookings.OrderBy(b => b.CheckIn).ToList();

        public void Add(Booking b)
        {
            EnsureNoOverlap(b.RoomNumber, b.CheckIn, b.CheckOut, null);
            _bookings.Add(b);
        }

        public bool Cancel(string roomNumber, string guestName)
        {
            var toRemove = _bookings.FirstOrDefault(b =>
                b.RoomNumber.Equals(roomNumber, StringComparison.OrdinalIgnoreCase) &&
                b.GuestName.Equals(guestName, StringComparison.OrdinalIgnoreCase));

            if (toRemove == null) return false;

            _bookings.Remove(toRemove);
            return true;
        }

        public bool TryFind(string roomNumber, string guestName, out Booking? booking)
        {
            booking = _bookings.FirstOrDefault(b =>
                b.RoomNumber.Equals(roomNumber, StringComparison.OrdinalIgnoreCase) &&
                b.GuestName.Equals(guestName, StringComparison.OrdinalIgnoreCase));

            return booking != null;
        }

        public bool IsAvailable(string roomNumber, DateTime checkIn, DateTime checkOut)
        {
            try
            {
                EnsureNoOverlap(roomNumber, checkIn, checkOut, null);
                return true;
            }
            catch { return false; }
        }

        private void EnsureNoOverlap(string roomNumber, DateTime checkIn, DateTime checkOut, Booking? except)
        {
            bool Overlaps(Booking a) => a.CheckIn < checkOut && checkIn < a.CheckOut;

            foreach (var existing in _bookings)
            {
                if (except != null && ReferenceEquals(existing, except)) continue;
                if (!existing.RoomNumber.Equals(roomNumber, StringComparison.OrdinalIgnoreCase)) continue;

                if (Overlaps(existing))
                    throw new InvalidOperationException(
                        $"Room {roomNumber} already booked {existing.CheckIn:MM/dd HH:mm}–{existing.CheckOut:MM/dd HH:mm}.");
            }
        }
    }
}