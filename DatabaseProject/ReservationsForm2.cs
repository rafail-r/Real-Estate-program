using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject
{
    internal partial class ReservationsForm2 : Form
    {
        DBConnector conn = null;
        ReservationsForm parentForm = null;
        String customerId = "";
        String choice = "";

        internal ReservationsForm2(DBConnector c, ReservationsForm rf, String ch)
        {
            InitializeComponent();
            conn = c;
            parentForm = rf;
            setTextBoxes();
            choice = ch;
            if (ch == "update")
            {
                phoneCustomerText.ReadOnly = true;
            }
        }

        private void ReservationsForm2_Shown(object sender, EventArgs e)
        {
            phoneCustomerText.Focus();
        }

        internal void updateTexts()
        {
            setTextBoxes();
        }

        private int getTotalCost()
        {
            String roomPrice = parentForm.getRoomPrice();
            String from = parentForm.getDisplayFromDate();
            String to = parentForm.getDisplayToDate();
            int duration = (int)(DateTime.Parse(to) - DateTime.Parse(from)).TotalDays;
            int totalCost = duration * int.Parse(roomPrice);
            return totalCost;
        }

        private void setTextBoxes()
        {

            String roomType = parentForm.getRoomType();
            String from = parentForm.getDisplayFromDate();
            String to = parentForm.getDisplayToDate();
            String hotel = parentForm.getHotelName();

            hotelText.Text = hotel;
            fromText.Text = from;
            toText.Text = to;
            totalPriceText.Text = getTotalCost().ToString();
            roomTypeText.Text = roomType;
            peopleNoText.Text = parentForm.getPeopleNo();

            paymentMethodCombo.DataSource = new String[] { "Credit Card", "Cash", "Bank Deposit" };

            if (parentForm.getCustomersPhone() != "")
            {
                phoneCustomerText.Text = parentForm.getCustomersPhone();
            }
        }

        private void backButt_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            parentForm.setCustomersPhone(phoneCustomerText.Text);
            parentForm.fillRoomsList();
            parentForm.deleteResForm2(this);
        }

        private void connect()
        {
            Dictionary<String, String> searchVal = conn.getCustomersName(phoneCustomerText.Text);
            if (searchVal.Any())
            {
                customerId = searchVal["id"];
                customerText.Text = searchVal["name"];
                finalReserveButt.Enabled = true;
            }
            else
            {
                customerId = "";
                customerText.Text = "No customer found.";
                finalReserveButt.Enabled = false;
            }
        }

        private void phoneCustomerText_TextChanged(object sender, EventArgs e)
        {
            if (phoneCustomerText.MaskCompleted)
            {
                connect();
            }
        }

        private void finalReserveButt_Click(object sender, EventArgs e)
        {
            DBBooking book = new DBBooking(customerId, parentForm.getHotelId(),
                DateTime.Parse(parentForm.getFromDate()), DateTime.Parse(parentForm.getToDate()));
            DBBilling bill = new DBBilling(getTotalCost().ToString(), paymentMethodCombo.Text, DateTime.Parse(parentForm.getToDate()));
            if (choice == "insert")
            {
                if (conn.addReservation(book, bill, customerId, peopleNoText.Text))
                {
                    MessageBox.Show("New Reservation added successfully. Will send an email to inform customer.");
                    String emailMessage = "New Reservation. Info:\nHotel: " + hotelText.Text + "\nRoom type: " +
                       roomTypeText.Text + "\nPrice: " + totalPriceText.Text + "\nFrom: " + fromText.Text +
                       "\nTo " + toText.Text;
                    SendEmail em = new SendEmail(conn.getEmails(customerId));
                    em.sendEmail("New Reservation", emailMessage, customerText.Text);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Something went wrong. Try again.");
                    connect();
                }
            }
            else if (choice == "update")
            {
                if (conn.updateReservation(book, bill, parentForm.getBookId(), peopleNoText.Text))
                {
                    MessageBox.Show("Reservation changed successfully. Will send an email to inform customer.");
                    String emailMessage = "Reservation Change. Info:\nHotel: " + hotelText.Text + "\nRoom type: " +
                       roomTypeText.Text + "\nPrice: " + totalPriceText.Text + "\nFrom: " + fromText.Text +
                       "\nTo " + toText.Text;
                    SendEmail em = new SendEmail(conn.getEmails(customerId));
                    em.sendEmail("Changed reservation", emailMessage, customerText.Text);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Something went wrong. Try again.");
                    connect();
                }
            }

        }
    }
}
