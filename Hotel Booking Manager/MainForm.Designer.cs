namespace HotelBookingManager
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.DateTimePicker dtCheckIn;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.DateTimePicker dtCheckOut;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpBookings;
        private System.Windows.Forms.ListBox lstBookings;
        private System.Windows.Forms.Label lblStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblGuestName = new System.Windows.Forms.Label();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.dtCheckIn = new System.Windows.Forms.DateTimePicker();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.dtCheckOut = new System.Windows.Forms.DateTimePicker();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpBookings = new System.Windows.Forms.GroupBox();
            this.lstBookings = new System.Windows.Forms.ListBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpBookings.SuspendLayout();
            this.SuspendLayout();

            // lblGuestName
            this.lblGuestName.Location = new System.Drawing.Point(20, 20);
            this.lblGuestName.Size = new System.Drawing.Size(80, 22);
            this.lblGuestName.Text = "Guest Name:";

            // txtGuestName
            this.txtGuestName.Location = new System.Drawing.Point(110, 20);
            this.txtGuestName.Size = new System.Drawing.Size(180, 22);

            // lblRoomNumber
            this.lblRoomNumber.Location = new System.Drawing.Point(320, 20);
            this.lblRoomNumber.Size = new System.Drawing.Size(90, 22);
            this.lblRoomNumber.Text = "Room Number:";

            // txtRoomNumber
            this.txtRoomNumber.Location = new System.Drawing.Point(420, 20);
            this.txtRoomNumber.Size = new System.Drawing.Size(80, 22);

            // lblCheckIn
            this.lblCheckIn.Location = new System.Drawing.Point(20, 60);
            this.lblCheckIn.Size = new System.Drawing.Size(80, 22);
            this.lblCheckIn.Text = "Check-In:";

            // dtCheckIn
            this.dtCheckIn.Location = new System.Drawing.Point(110, 60);
            this.dtCheckIn.Size = new System.Drawing.Size(180, 22);
            this.dtCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCheckIn.CustomFormat = "MM/dd/yyyy HH:mm";

            // lblCheckOut
            this.lblCheckOut.Location = new System.Drawing.Point(320, 60);
            this.lblCheckOut.Size = new System.Drawing.Size(80, 22);
            this.lblCheckOut.Text = "Check-Out:";

            // dtCheckOut
            this.dtCheckOut.Location = new System.Drawing.Point(420, 60);
            this.dtCheckOut.Size = new System.Drawing.Size(180, 22);
            this.dtCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCheckOut.CustomFormat = "MM/dd/yyyy HH:mm";

            // Buttons
            this.btnBook.Location = new System.Drawing.Point(20, 100);
            this.btnBook.Size = new System.Drawing.Size(100, 30);
            this.btnBook.Text = "Book Room";

            this.btnCancel.Location = new System.Drawing.Point(140, 100);
            this.btnCancel.Size = new System.Drawing.Size(120, 30);
            this.btnCancel.Text = "Cancel Booking";

            this.btnView.Location = new System.Drawing.Point(280, 100);
            this.btnView.Size = new System.Drawing.Size(120, 30);
            this.btnView.Text = "View All Bookings";

            this.btnExit.Location = new System.Drawing.Point(420, 100);
            this.btnExit.Size = new System.Drawing.Size(100, 30);
            this.btnExit.Text = "Exit";

            // grpBookings
            this.grpBookings.Location = new System.Drawing.Point(20, 150);
            this.grpBookings.Size = new System.Drawing.Size(580, 200);
            this.grpBookings.Text = "Current Bookings";
            this.grpBookings.Controls.Add(this.lstBookings);

            // lstBookings
            this.lstBookings.Location = new System.Drawing.Point(10, 25);
            this.lstBookings.Size = new System.Drawing.Size(560, 165);

            // lblStatus
            this.lblStatus.Location = new System.Drawing.Point(20, 370);
            this.lblStatus.Size = new System.Drawing.Size(580, 22);
            this.lblStatus.Text = "Status: Ready";

            // MainForm
            this.ClientSize = new System.Drawing.Size(620, 420);
            this.Controls.Add(this.lblGuestName);
            this.Controls.Add(this.txtGuestName);
            this.Controls.Add(this.lblRoomNumber);
            this.Controls.Add(this.txtRoomNumber);
            this.Controls.Add(this.lblCheckIn);
            this.Controls.Add(this.dtCheckIn);
            this.Controls.Add(this.lblCheckOut);
            this.Controls.Add(this.dtCheckOut);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpBookings);
            this.Controls.Add(this.lblStatus);
            this.Text = "Hotel Booking Manager";

            this.grpBookings.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}