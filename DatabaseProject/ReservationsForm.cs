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
    internal partial class ReservationsForm : Form
    {
        DBConnector conn = null;
        Dictionary<String, List<String>> rooms = null;
        Dictionary<String, List<String>> hotels = null;
        MainForm parentForm = null;
        DateTime from;
        DateTime to;
        String customersPhone = "";
        String choice = "";
        String book_id = "";

        ReservationsForm2 reservationsForm2 = null;

        internal ReservationsForm(MainForm mf, DBConnector c, Dictionary<String, List<String>> h, String ch)
        {
            InitializeComponent();
            parentForm = mf;
            conn = c;
            hotels = h;
            fillFormData();
            choice = ch;
        }

        internal void fillFormData()
        {
            hotelsCombo.DataSource = hotels["name"];
        }

        private void determineSelectionLabel()
        {
            try
            {
                if ((rooms["type"].Any()) && (roomsList.DataSource != null))
                {
                    String selection = rooms["type"][roomsList.SelectedIndex];
                    selectionLabel.Text = "Selection: " + selection;
                    nextReserveButt.Enabled = true;
                }
                else
                {
                    selectionLabel.Text = "No rooms available.";
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {

            }
        }

        internal void fillRoomsList()
        {
            try
            {
                if ((fromDate.MaskCompleted) && (toDate.MaskCompleted))
                {
                    from = DateTime.Parse(fromDate.Text);
                    to = DateTime.Parse(toDate.Text);
                    if (from < to)
                    {
                        rooms = conn.getRooms(hotels["id"][hotelsCombo.SelectedIndex], from.ToString("yyyy-MM-dd"), to.ToString("yyyy-MM-dd"), peopleNo.Text);
                        roomsList.DataSource = rooms["data"];
                        if (roomsList.SelectedIndex != -1)
                        {
                            roomsList.SelectedIndex = 0;
                        }
                        determineSelectionLabel();
                    }
                    else
                    {
                        MessageBox.Show("Fill dates properly.");
                    }
                }
                
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (System.ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void findRoomsButt_Click(object sender, EventArgs e)
        {
            fillRoomsList();
        }

        internal void deleteResForm2(ReservationsForm2 rf2)
        {
            if (reservationsForm2 == rf2)
            {
                reservationsForm2 = null;
            }
        }

        private void proceedReserveButt_Click(object sender, EventArgs e)
        {
            if (reservationsForm2 == null)
            {
                reservationsForm2 = new ReservationsForm2(conn, this, choice);
                reservationsForm2.Location = this.Location;
            }
            else
            {
                reservationsForm2.updateTexts();
            }
            reservationsForm2.Show();
            this.Hide();
        }

        private void roomsList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            determineSelectionLabel();
        }


        private void hotelsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillRoomsList();
        }

        private void ReservationsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (reservationsForm2 != null)
            {
                reservationsForm2.Close();
            }
        }


        internal String getRoomType()
        {
            if (roomsList.SelectedIndex != -1)
            {
                return rooms["type"][roomsList.SelectedIndex];
            }
            else
            {
                return null;
            }
        }

        internal String getRoomPrice()
        {
            if (roomsList.SelectedIndex != -1)
            {
                return rooms["price"][roomsList.SelectedIndex];
            }
            else
            {
                return null;
            }
        }

        internal String getToDate()
        {
            return to.Date.ToString("yyyy-MM-dd");
        }

        internal String getDisplayToDate()
        {
            return to.Date.ToString("dd-MM-yyyy");
        }


        internal String getDisplayFromDate()
        {
            return from.Date.ToString("dd-MM-yyyy");
        }

        internal String getFromDate()
        {
            return from.Date.ToString();
        }

        internal String getHotelName()
        {
            return hotelsCombo.SelectedValue.ToString();
        }

        internal String getHotelId()
        {
            return hotels["id"][hotelsCombo.SelectedIndex];
        }

        internal String getCustomersPhone()
        {
            return customersPhone;
        }

        internal void setCustomersPhone(String p)
        {
            customersPhone = p;
        }

        private void checkIfTextsCompleted()
        {
            if ((fromDate.MaskCompleted) && (toDate.MaskCompleted) && (peopleNo.MaskCompleted))
            {
                fillRoomsList();
            }
            else
            {
                roomsList.DataSource = null;
            }
        }

        private void fromDate_TextChanged(object sender, EventArgs e)
        {
            checkIfTextsCompleted();
        }

        private void toDate_TextChanged(object sender, EventArgs e)
        {
            checkIfTextsCompleted();
        }

        private void peopleNo_TextChanged(object sender, EventArgs e)
        {
            checkIfTextsCompleted();
        }

        internal void setFromDateText(String from)
        {
            fromDate.Text = from;
        }

        internal void setToDateText(String to)
        {
            toDate.Text = to;
        }

        internal void setHotelsComboSelection(String hotelId)
        {
            hotelsCombo.SelectedIndex = hotels["id"].IndexOf(hotelId);
        }

        internal String getPeopleNo()
        {
            return peopleNo.Text;
        }

        internal String getBookId()
        {
            return book_id;
        }

        internal void setBookId(String id)
        {
            book_id = id;
        }

        internal void setPeopleNo(String pn)
        {
            peopleNo.Text = pn;
        }
    }
}
