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
    internal partial class MainForm : Form
    {
        DBConnector conn=null;
        ReservationsForm reservationsForm = null;
        CustomersForm customersForm = null;
        UpdateCustomerForm updateCustomerForm = null;
        Dictionary<String, List<String>> hotels = null;
        PaymentsForm paymentsForm = null;
        CancelReservationForm cancelReservationForm = null;
        RoomsForm roomsForm = null;
        HotelsForm hotelsForm = null;
        HotelsUpdateForm hotelsUpdateForm = null;

        internal MainForm()
        {
            InitializeComponent();
            connectDB();
            hotels = conn.getHotelNames();
            newHotelBtn.Enabled = false;
            newHotelBtn.Hide();
            updateHotelBtn.Enabled = false;
            updateHotelBtn.Hide();
            hotelRoomsButt.Enabled = false;
            hotelRoomsButt.Hide();
        }

        private void connectDB()
        {
            if (conn == null)
                conn = new DBConnector();
           
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(conn.Count().ToString());
            //BindingList<StringValue> testList = new BindingList<StringValue>(conn.Select());
            //BindingSource bs = new BindingSource(testList, null);
            dataGridView1.DataSource = conn.Select();
        }

        private void newReservationButt_Click(object sender, EventArgs e)
        {
            ReservationsForm rf = new ReservationsForm(this, conn, hotels, "insert");
            if (reservationsForm != null)
            {
                reservationsForm.Close();
            }
            rf.Show();
            reservationsForm = rf;
            if (phoneText.MaskCompleted)
            {
                rf.setCustomersPhone(phoneText.Text);
            }
        }

        private void newPaymentButt_Click(object sender, EventArgs e)
        {
            PaymentsForm pf = new PaymentsForm(this, conn);
            if (paymentsForm != null)
            {
                paymentsForm.Close();
            }
            pf.Show();
            paymentsForm = pf;
            if (phoneText.MaskCompleted)
            {
                pf.setPhoneText(phoneText.Text);
            }
        }

        private void cancelResButt_Click(object sender, EventArgs e)
        {
            CancelReservationForm cr = new CancelReservationForm(this, conn, hotels);
            cr.Show();
            cancelReservationForm = cr;
            if (phoneText.MaskCompleted)
            {
                cr.setPhoneText(phoneText.Text);
            }
        }

        private void hotelRoomsButt_Click(object sender, EventArgs e)
        {
            RoomsForm rf = new RoomsForm(this, conn, hotels);
            rf.Show();
            roomsForm = rf;
        }

        private void newCustomerBtn_Click(object sender, EventArgs e)
        {
            if (customersForm != null)
            {
                customersForm.Close();
            }
            CustomersForm cf = new CustomersForm(conn, this);
            cf.Show();
            customersForm = cf;
        }

        private void updateCustomerBtn_Click(object sender, EventArgs e)
        {
            if (updateCustomerForm != null)
            {
                updateCustomerForm.Close();
            }
            UpdateCustomerForm ucf = new UpdateCustomerForm(conn, this);
            ucf.Show();
            updateCustomerForm = ucf;
        }

        private void newHotelBtn_Click(object sender, EventArgs e)
        {
            if (hotelsForm != null)
            {
                hotelsForm.Close();
            }
            HotelsForm hf = new HotelsForm(conn, this);
            hf.Show();
            hotelsForm = hf;
        }

        private void updateHotelBtn_Click(object sender, EventArgs e)
        {
            if (hotelsUpdateForm != null)
            {
                hotelsUpdateForm.Close();
            }
            HotelsUpdateForm huf = new HotelsUpdateForm(conn, this, hotels);
            huf.Show();
            hotelsUpdateForm = huf;
        }

        internal void setReservationsForm(ReservationsForm rf)
        {
            if (reservationsForm != null)
            {
                reservationsForm.Close();
            }
            reservationsForm = rf;
        }

        internal void setPaymentsForm(PaymentsForm pf)
        {
            paymentsForm = pf;
        }

        internal void setCancelReservationsForm(CancelReservationForm cf)
        {
            cancelReservationForm = cf;
        }

        public void renewHotels()
        {
            hotels = conn.getHotelNames();
        }

        private void phoneText_TextChanged(object sender, EventArgs e)
        {
            if (phoneText.MaskCompleted)
            {
                reservationsBox.DataSource = conn.getPaymentInfo(phoneText.Text)["info"];
            }
            else
            {
                reservationsBox.DataSource = null;
            }
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            if (passwordBox.Text == "root")
            {
                newHotelBtn.Enabled = true;
                newHotelBtn.Show();
                updateHotelBtn.Enabled = true;
                updateHotelBtn.Show();
                hotelRoomsButt.Enabled = true;
                hotelRoomsButt.Show();
            }
            else
            {
                newHotelBtn.Enabled = false;
                newHotelBtn.Hide();
                updateHotelBtn.Enabled = false;
                updateHotelBtn.Hide();
                hotelRoomsButt.Enabled = false;
                hotelRoomsButt.Hide();
            }
        }
    }
}
