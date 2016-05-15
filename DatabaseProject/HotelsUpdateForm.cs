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
    internal partial class HotelsUpdateForm : Form
    {
        MainForm parentForm = null;
        DBConnector conn = null;
        Dictionary<String, List<String>> hotels = null;

        internal HotelsUpdateForm(DBConnector c, MainForm mf, Dictionary<String, List<String>> h)
        {
            InitializeComponent();
            parentForm = mf;
            conn = c;
            hotels = h;
            hotelsCombo.DataSource = hotels["name"];
        }

        

        private Boolean checkData()
        {
            if ((nameHotel2.Text == "") || (typeHotel2.Text == "") || (countryText2.Text == "") ||
                (cityText2.Text == "") || (streetText2.Text == "") || (streetnoText2.Text == "") || (!phoneText2.MaskCompleted) ||
                (!zipcodeText2.MaskCompleted))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkData())
                {
                    DBHotels hotel = new DBHotels(nameHotel2.Text, typeHotel2.Text, starsHotel2.Text);
                    DBAddress address = new DBAddress(phoneText2.Text, countryText2.Text, cityText2.Text, zipcodeText2.Text, streetText2.Text, streetnoText2.Text);
                    if (conn.updateHotel(hotel, address, hotels["addr_id"][hotelsCombo.SelectedIndex]))
                    {
                        hotel.address_id = hotels["addr_id"][hotelsCombo.SelectedIndex];
                        if (conn.updateHotelView(hotel))
                        {
                            MessageBox.Show("Updated hotel successfully");
                            parentForm.renewHotels();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Something went wrong");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong");
                    }
                }

                else
                {
                    MessageBox.Show("Please fill all data");
                }

            }
            catch (System.FormatException ex)
            {
                MessageBox.Show("Please fill all data properly");
                Console.WriteLine(ex.Data);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Close();
        }

        private void fillText()
        {
            phoneText2.Text = hotels["phone"][hotelsCombo.SelectedIndex];
            countryText2.Text = hotels["country"][hotelsCombo.SelectedIndex];
            cityText2.Text = hotels["city"][hotelsCombo.SelectedIndex];
            zipcodeText2.Text = hotels["zipcode"][hotelsCombo.SelectedIndex];
            streetnoText2.Text = hotels["streetNo"][hotelsCombo.SelectedIndex];
            streetText2.Text = hotels["street"][hotelsCombo.SelectedIndex];
            nameHotel2.Text = hotels["name"][hotelsCombo.SelectedIndex];
            typeHotel2.Text = hotels["type"][hotelsCombo.SelectedIndex];
            starsHotel2.Text = hotels["stars"][hotelsCombo.SelectedIndex];
        }


        
        private void hotelsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillText();
        }
        
    }
}
