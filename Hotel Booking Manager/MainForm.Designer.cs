namespace HotelBookingManager
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.DateTimePicker dtCheckIn;
        private System.Windows.Forms.DateTimePicker dtCheckOut;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstBookings;
        private System.Windows.Forms.Label lblStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.dtCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtCheckOut = new System.Windows.Forms.DateTimePicker();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstBookings = new System.Windows.Forms.ListBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // txtGuestName
            this.txtGuestName.Location = new System.Drawing.Point(120, 20);
            this.txtGuestName.Size = new System.Drawing.Size(150, 22);
            this.txtGuestName.PlaceholderText = "Guest Name";

            // txtRoomNumber
            this.txtRoomNumber.Location = new System.Drawing.Point(400, 20);
            this.txtRoomNumber.Size = new System.Drawing.Size(80, 22);
            this.txtRoomNumber.PlaceholderText = "Room #";

            // dtCheckIn
            this.dtCheckIn.Location = new System.Drawing.Point(120, 60);
            this.dtCheckIn.Size = new System.Drawing.Size(200, 22);

            // dtCheckOut
            this.dtCheckOut.Location = new System.Drawing.Point(400, 60);
            this.dtCheckOut.Size = new System.Drawing.Size(200, 22);

            // btnBook
            this.btnBook.Location = new System.Drawing.Point(20, 100);
            this.btnBook.Size = new System.Drawing.Size(100, 30);
            this.btnBook.Text = "Book Room";

            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(140, 100);
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.Text = "Cancel Booking";

            // btnView
            this.btnView.Location = new System.Drawing.Point(260, 100);
            this.btnView.Size = new System.Drawing.Size(100, 30);
            this.btnView.Text = "View All";

            // btnExit
            this.btnExit.Location = new System.Drawing.Point(380, 100);
            this.btnExit.Size = new System.Drawing.Size(100, 30);
            this.btnExit.Text = "Exit";

            // lstBookings
            this.lstBookings.Location = new System.Drawing.Point(20, 150);
            this.lstBookings.Size = new System.Drawing.Size(580, 200);

            // lblStatus
            this.lblStatus.Location = new System.Drawing.Point(20, 370);
            this.lblStatus.Size = new System.Drawing.Size(580, 22);
            this.lblStatus.Text = "Status: Ready";

            // MainForm
            this.ClientSize = new System.Drawing.Size(620, 420);
            this.Controls.Add(this.txtGuestName);
            this.Controls.Add(this.txtRoomNumber);
            this.Controls.Add(this.dtCheckIn);
            this.Controls.Add(this.dtCheckOut);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lstBookings);
            this.Controls.Add(this.lblStatus);
            this.Text = "Hotel Booking Manager";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}