using System;
using System.Windows.Forms;

namespace HotelBookingManager
{
    public partial class MainForm : Form
    {
        private readonly BookingManager manager = new();

        public MainForm()
        {
            InitializeComponent();

            // Optional: Set DateTimePicker formats
            dtCheckIn.Format = DateTimePickerFormat.Custom;
            dtCheckIn.CustomFormat = "MM/dd/yyyy HH:mm";
            dtCheckOut.Format = DateTimePickerFormat.Custom;
            dtCheckOut.CustomFormat = "MM/dd/yyyy HH:mm";

            // Wire up events (if not done in Designer)
            btnBook.Click += BtnBook_Click;
            btnCancel.Click += BtnCancel_Click;
            btnView.Click += BtnView_Click;
            btnExit.Click += BtnExit_Click;
        }

        // --- Button Event Handlers ---

        private void BtnBook_Click(object? sender, EventArgs e)
        {
            try
            {
                string guest = txtGuestName.Text.Trim();
                string room = txtRoomNumber.Text.Trim();
                DateTime checkIn = dtCheckIn.Value;
                DateTime checkOut = dtCheckOut.Value;

                Booking booking = new(room, guest, checkIn, checkOut);

                if (manager.IsAvailable(room, checkIn, checkOut))
                {
                    manager.Add(booking);
                    SetStatus($"Room {room} booked successfully.");
                    RefreshList();
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show("Room is already booked for this period.", "Booking Conflict");
                    SetStatus("Booking conflict.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                SetStatus("Failed to book room.");
            }
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            string guest = txtGuestName.Text.Trim();
            string room = txtRoomNumber.Text.Trim();

            if (manager.Cancel(room, guest))
            {
                SetStatus($"Booking for Room {room} canceled.");
                RefreshList();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Booking not found.", "Error");
                SetStatus("Cancel failed.");
            }
        }

        private void BtnView_Click(object? sender, EventArgs e)
        {
            RefreshList();
        }

        private void BtnExit_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        // --- Helper Methods ---

        private void RefreshList()
        {
            lstBookings.Items.Clear();
            foreach (var booking in manager.All())
            {
                lstBookings.Items.Add(booking.ToString());
            }
        }

        private void ClearInputs()
        {
            txtGuestName.Clear();
            txtRoomNumber.Clear();
        }

        private void SetStatus(string message)
        {
            lblStatus.Text = "Status: " + message;
        }
    }
}