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
    internal partial class CancelReservationForm : Form
    {
        MainForm mainForm = null;
        DBConnector conn = null;
        Dictionary<String, List<String>> reservationsInfo = null;
        Dictionary<String, List<String>> hotels = null;

        internal CancelReservationForm(MainForm mf, DBConnector c, Dictionary<String, List<String>> h)
        {
            InitializeComponent();
            mainForm = mf;
            conn = c;
            hotels = h;
        }

        private void fillTexts()
        {
            try
            {
                reservationsCombo.DataSource = reservationsInfo["info"];
            }
            catch (System.ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
                resetTexts();
            }
        }

        private void resetTexts()
        {
            reservationsCombo.DataSource = null;
        }

        private void connect()
        {
            Dictionary<String, String> retVal = conn.getCustomersName(phoneText.Text);
            if (retVal.Any())
            {
                customerText.Text = retVal["name"];
                reservationsInfo = conn.getPaymentInfo(phoneText.Text);
                if (reservationsInfo["bill_id"].Any())
                {
                    fillTexts();
                    cancelReservationButt.Enabled = true;
                    changeReservationButt.Enabled = true;
                }
                else
                {
                    resetTexts();
                    cancelReservationButt.Enabled = false;
                    changeReservationButt.Enabled = false;
                }
            }
            else
            {
                customerText.Text = "No customer found.";
            }
        }

        private void phoneText_TextChanged(object sender, EventArgs e)
        {
            if (phoneText.MaskCompleted)
            {
                connect();
            }
            else
            {
                customerText.Text = "";
                cancelReservationButt.Enabled = false;
                changeReservationButt.Enabled = false;
            }
        }

        private void cancelReservationButt_Click(object sender, EventArgs e)
        {
            if (conn.cancelReservation(reservationsInfo["book_id"][reservationsCombo.SelectedIndex]))
            {
                MessageBox.Show("Deleted reservation sucessfully. Will send an email to inform customer.");
                String emailMessage = "Canceled reservation for " + reservationsInfo["info"][reservationsCombo.SelectedIndex];
                SendEmail em = new SendEmail(conn.getEmails(reservationsInfo["cust_id"][reservationsCombo.SelectedIndex]));
                em.sendEmail("Canceled reservation", emailMessage, customerText.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Something went wrong.");
                connect();
            }
        }

        private void changeResButt_Click(object sender, EventArgs e)
        {
            ReservationsForm rf = new ReservationsForm(mainForm, conn, hotels, "update");
            rf.setFromDateText(DateTime.Parse(reservationsInfo["from"][reservationsCombo.SelectedIndex]).ToString("dd-MM-yyyy"));
            rf.setToDateText(DateTime.Parse(reservationsInfo["to"][reservationsCombo.SelectedIndex]).ToString("dd-MM-yyyy"));
            rf.setCustomersPhone(phoneText.Text);
            rf.setHotelsComboSelection(reservationsInfo["hotel_id"][reservationsCombo.SelectedIndex]);
            rf.setBookId(reservationsInfo["book_id"][reservationsCombo.SelectedIndex]);
            rf.setPeopleNo(reservationsInfo["people_number"][reservationsCombo.SelectedIndex]);
            mainForm.setReservationsForm(rf);
            rf.Location = this.Location;
            rf.Show();
            this.Close();
        }

        internal void setPhoneText(String phone)
        {
            phoneText.Text = phone;
        }
    }
}
